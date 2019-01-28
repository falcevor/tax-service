using System;
using System.Runtime.Serialization;

namespace TaxServiceLibrary.Model
{
    [DataContract]
    public class TaxpayerInfo
    {
        [DataMember]
        public int id;

        [DataMember]
        public string inn;

        [DataMember]
        public string kpp;

        [DataMember]
        public string name;

        [DataMember]
        public string category;

        [DataMember]
        public string taxType;

        [DataMember]
        public int percent;

        [DataMember]
        public string placeType;

        [DataMember]
        public string placeAddress;

        [DataMember]
        public DateTime beginDate;

        [DataMember]
        public string additionalInfo;

        [DataMember]
        public DocumentInfo[] documents;
    }
}
