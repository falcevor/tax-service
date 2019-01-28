using System.Runtime.Serialization;

namespace TaxServiceLibrary.Model
{
    [DataContract]
    public class ReportTemplateInfo
    {
        [DataMember]
        public int id;

        [DataMember]
        public string name;

        [DataMember]
        public string description;

        [DataMember]
        public byte[] file;

        [DataMember]
        public ReportTemplateParameterInfo[] parameters;
    }
}
