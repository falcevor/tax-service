using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;

namespace TaxService.Data
{
    public class PostgreTaxServiceDataProvider : IDisposable
    {
        private const string CONNECTION_STRING = "";
        private NpgsqlConnection _conn;

        public PostgreTaxServiceDataProvider()
        {
            _conn = new NpgsqlConnection(CONNECTION_STRING);
            _conn.Open();
        }

        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }

        private DataTable ExecuteQuery(string sql)
        {
            var command = _conn.CreateCommand();
            command.CommandText = sql;
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        private void ExecuteNonQuery(string sql)
        {
            var command = _conn.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        private int GetMaxId(string table)
        {
            var command = _conn.CreateCommand();
            command.CommandText = $"SELECT MAX(id) max_id FROM \"{table}\"";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            try
            {
                var result = Int32.Parse(dt.Rows[0]["max_id"].ToString());
                return result;
            }
            catch
            {
                return 1;
            }
        }

        private int GetTaxpayerCategoryByName(string name)
        {
            var command = _conn.CreateCommand();
            command.CommandText = $"SELECT id FROM \"tTaxpayerCategory\" WHERE name LIKE '%{name}%'";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            var result = Int32.Parse(dt.Rows[0]["id"].ToString());
            return result;
        }

        private int GetTaxTypeByName(string name)
        {
            var command = _conn.CreateCommand();
            command.CommandText = $"SELECT id FROM \"tTaxType\" WHERE name LIKE '%{name}%'";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            var result = Int32.Parse(dt.Rows[0]["id"].ToString());
            return result;
        }

        private int GetPlaceTypeByName(string name)
        {
            var command = _conn.CreateCommand();
            command.CommandText = $"SELECT id FROM \"tPlaceType\" WHERE name LIKE '%{name}%'";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            var result = Int32.Parse(dt.Rows[0]["id"].ToString());
            return result;
        }

        private int GetAreaIdByInspectorId(int inspectorId)
        {
            var command = _conn.CreateCommand();
            command.CommandText = $"SELECT area_id FROM \"tAreaInspector\" WHERE inspector_id = {inspectorId}";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            var result = Int32.Parse(dt.Rows[0]["area_id"].ToString());
            return result;
        }

        public DataTable GetAllReportTemplates()
        {
            var sql = $"SELECT * FROM \"tReportTemplate\"";
            return ExecuteQuery(sql);
        }

        public DataTable GetIncomesByTaxpayerIf(int taxpayerId)
        {
            var sql = $"SELECT * FROM \"tIncomes\" WHERE taxpayer_id = {taxpayerId}";
            return ExecuteQuery(sql);
        }

        public DataTable GetInspectorInfoByName(string name)
        {
            var sql = $"SELECT id, login, password FROM \"tInspector\" where login ='{name}'";
            return ExecuteQuery(sql);
        }

        public DataTable GetPaymentsByTaxpayerIf(int taxpayerId)
        {
            var sql = $"SELECT * FROM \"tPayments\" WHERE taxpayer_id = {taxpayerId}";
            return ExecuteQuery(sql);
        }

        public DataTable GetReportTemplateInfoById(int templateId)
        {
            var sql = $"SELECT * FROM \"tReportTemplate\" WHERE id = {templateId}";
            return ExecuteQuery(sql);
        }

        public DataTable GetDocumentsByTaxpayerId(int taxpayerId)
        {
            var sql = $"SELECT * FROM \"tDocument\" WHERE taxpayer_id = {taxpayerId}";
            return ExecuteQuery(sql);
        }


        public DataTable GetTemplateParameterInfoByTemplateId(int templateId)
        {
            var sql = $"SELECT * FROM \"tReportTemplateParameter\" WHERE template_id = {templateId}";
            return ExecuteQuery(sql);
        }

        public DataTable GetTaxpayerInfoById(int taxpayerId)
        {
            var sql = $"SELECT payer.*, categ.name category_name, taxtype.name tax_type_name, placetype.name place_type_name " +
                $"FROM \"tInspector\" insp " +
                $"INNER JOIN \"tAreaInspector\" area ON insp.id = area.inspector_id " +
                $"INNER JOIN \"tTaxpayer\" payer ON payer.area_id = area.area_id " +
                $"INNER JOIN \"tTaxpayerCategory\" categ ON payer.category_id = categ.id " +
                $"INNER JOIN \"tTaxType\" taxtype ON taxtype.id = payer.tax_type_id " +
                $"INNER JOIN \"tPlaceType\" placetype ON placetype.id = payer.place_type_id " +
                $"WHERE payer.id = {taxpayerId}";
            return ExecuteQuery(sql);
        }

        public DataTable GetTaxpayersByInspectorId(int inspectorId)
        {
            var sql = $"SELECT payer.*, categ.name category_name, taxtype.name tax_type_name, placetype.name place_type_name " +
                $"FROM \"tInspector\" insp " +
                $"INNER JOIN \"tAreaInspector\" area ON insp.id = area.inspector_id " +
                $"INNER JOIN \"tTaxpayer\" payer ON payer.area_id = area.area_id " +
                $"INNER JOIN \"tTaxpayerCategory\" categ ON payer.category_id = categ.id " +
                $"INNER JOIN \"tTaxType\" taxtype ON taxtype.id = payer.tax_type_id " +
                $"INNER JOIN \"tPlaceType\" placetype ON placetype.id = payer.place_type_id " +
                $"WHERE insp.id = {inspectorId}";
            return ExecuteQuery(sql);
        }

        public void DeleteAllTaxpayerDocuments(int taxpayerId)
        {
            var sql = $"DELETE FROM \"tDocument\"" +
                $" WHERE taxpayer_id = {taxpayerId}";
            ExecuteNonQuery(sql);
        }

        public void UpdateTaxpayerDocument(int taxpayerId, int id, string name, string description, byte[] file)
        {
            var sql = $"DELETE FROM \"tDocument\"" +
                 $" WHERE id = {id}";
            ExecuteNonQuery(sql);
            CreateTaxpayerDocument(taxpayerId, name, description, file);
        }

        public void CreateTaxpayerDocument(int taxpayerId, string name, string description, byte[] file)
        {
            var id = GetMaxId("tDocument") + 1;

            var sql = $"INSERT INTO \"tDocument\"" +
                 $" VALUES ({id}, '{name}', '{description}', {taxpayerId}, :file)";

            var command = new NpgsqlCommand(sql, _conn);
            var param = new NpgsqlParameter("file", NpgsqlDbType.Bytea);
            param.Value = file;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }

        public void UpdateTaxpayerInfo(int id, string inn, string kpp, string name, 
            string category, string taxType, int percent, string placeType, string placeAddress, 
            DateTime beginDate, string additionalInfo)
        {
            var catId = GetTaxpayerCategoryByName(category);
            var taxTypeId = GetTaxTypeByName(taxType);
            var placeTypeId = GetPlaceTypeByName(placeType);

            var sql = $"UPDATE \"tTaxpayer\"" +
                $" SET inn = '{inn}', kpp = '{kpp}', name = '{name}', " +
                $" category_id = {catId}, tax_type_id = {taxTypeId}, tax_percent = {percent}, " +
                $" place_type_id = {placeTypeId}, place_address = '{placeAddress}', " +
                $" begin_date = '{beginDate}', additional_info = '{additionalInfo}' " +
                $" WHERE id = {id}";
            ExecuteNonQuery(sql);
        }

        public int CreateTaxpayerInfo(int inspectorId, string inn, string kpp, string name,
            string category, string taxType, int percent, string placeType, string placeAddress,
            DateTime beginDate, string additionalInfo)
        {
            var id = GetMaxId("tTaxpayer") + 1;
            var catId = GetTaxpayerCategoryByName(category);
            var taxTypeId = GetTaxTypeByName(taxType);
            var placeTypeId = GetPlaceTypeByName(placeType);
            var areaId = GetAreaIdByInspectorId(inspectorId);

            var sql = $"INSERT INTO \"tTaxpayer\"" +
                $" VALUES ({id}, '{inn}', '{kpp}', '{name}', {catId}, {taxTypeId}, {percent}, " +
                $" {placeTypeId}, '{placeAddress}', '{beginDate}', '{additionalInfo}', {areaId})";
            ExecuteNonQuery(sql);
            return id;
        }

        public void DeleteTaxpayerInfo(int id)
        {
            var sql = $"DELTE FROM \"tTaxpayer\" WHERE id = {id}";
            ExecuteNonQuery(sql);
        }

        public void DeleteReportTemplateInfo(int id)
        {
            var sql = $"DELTE FROM \"tReportTemplate\" WHERE id = {id}";
            ExecuteNonQuery(sql);
        }

        public int CreateReportTemplateInfo(string name, string description, byte[] file)
        {
            var id = GetMaxId("tReportTemplate") + 1;

            var sql = $"INSERT INTO \"tReportTemplate\"" +
                $" VALUES ({id}, '{name}', '{description}', :file)";

            var command = new NpgsqlCommand(sql, _conn);
            var param = new NpgsqlParameter("file", NpgsqlDbType.Bytea);
            param.Value = file;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();

            return id;
        }

        public void UpdateReportTemplateInfo(int id, string name, string description, byte[] file)
        {
            var sql = $"UPDATE \"tReportTemplate\"" +
                $" SET name = '{name}', description = '{description}', file = :file" +
                $" WHERE id = {id}";

            var command = new NpgsqlCommand(sql, _conn);
            var param = new NpgsqlParameter("file", NpgsqlDbType.Bytea);
            param.Value = file;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }

        public void UpdateReportTemplateParameter(int templateId, int id, string name, string description, string defaultValue)
        {
            var sql = $"DELETE FROM \"tReportTemplateParameter\"" +
                 $" WHERE id = {id}";
            ExecuteNonQuery(sql);
            CreateReportTemplateParameter(templateId, name, description, defaultValue);
        }

        public void CreateReportTemplateParameter(int templateId, string name, string description, string defaultValue)
        {
            var id = GetMaxId("tReportTemplateParameter") + 1;

            var sql = $"INSERT INTO \"tReportTemplateParameter\"" +
                 $" VALUES ({id}, '{name}', '{description}', '{defaultValue}', {templateId})";

            ExecuteNonQuery(sql);
        }

        public void DeleteAllTemplateParameters(int templateId)
        {
            var sql = $"DELETE FROM \"tReportTemplateParameter\"" +
                $" WHERE template_id = {templateId}";
            ExecuteNonQuery(sql);
        }
    }
}
