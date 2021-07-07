using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TaxService.Client;

namespace TaxServiceDesktop.Report
{
    public partial class CreateReportForm : Form
    {
        private readonly GetReportTemplateByIdResponse _info;

        public CreateReportForm(GetReportTemplateByIdResponse info)
        {
            _info = info;
            InitializeComponent();
            tbName.Text = info.Name;
            tbDescription.Text = info.Description;

            foreach (var paramInfo in info.Parameters)
            {
                if (string.IsNullOrEmpty(paramInfo.Name)) continue;
                dgvParameters.Rows.Add(new object[] { paramInfo.Name, paramInfo.Description, paramInfo.DefaultValue });
            }
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            var paramDict = new Dictionary<string, string>();
            foreach (DataGridViewRow row in dgvParameters.Rows)
            {
                paramDict.Add(Convert.ToString(row.Cells[0].Value), Convert.ToString(row.Cells[2].Value));
            }

            var dlg = new SaveFileDialog();
            dlg.Filter = "Word Documents (*.docx)|*.docx";
            dlg.DefaultExt = "docx";
            dlg.AddExtension = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var filePath = dlg.FileName;
                File.WriteAllBytes(filePath, _info.File);
                ReplaceParameters(filePath, paramDict);
            }
        }

        private void ReplaceParameters(string filePath, Dictionary<string, string> parameters)
        {
            // TODO: Реализовать замену параметров на значения в документе.
            //Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            //Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(filePath);
            //app.Visible = false;
            //doc.Activate();
            //Microsoft.Office.Interop.Word.Words wds = doc.Sections[1].Range.Words;

            //foreach (var pair in parameters)
            //{
            //    FindAndReplace(app, $"##{pair.Key}##", pair.Value);
            //}
            //doc.Save();
            //doc.Close();
            //app.Quit();
        }

        private void FindAndReplace()//Microsoft.Office.Interop.Word.Application WordApp, object findText, object replaceWithText)
        {
            //object matchCase = true;
            //object matchWholeWord = true;
            //object matchWildCards = false;
            //object matchSoundsLike = false;
            //object nmatchAllWordForms = false;
            //object forward = true;
            //object format = false;
            //object matchKashida = false;
            //object matchDiacritics = false;
            //object matchAlefHamza = false;
            //object matchControl = false;
            //object read_only = false;
            //object visible = true;
            //object replace = 2;
            //object wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue;
            //object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
            //WordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
            //ref nmatchAllWordForms, ref forward,
            //ref wrap, ref format, ref replaceWithText,
            //ref replaceAll, ref matchKashida,
            //ref matchDiacritics, ref matchAlefHamza,
            //ref matchControl);
        }
    }
}
