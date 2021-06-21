using System;

namespace TaxServiceLibrary.Model
{
    public class TaxpayerInfo
    {
        public int id;
        public string inn;
        public string kpp;
        public string name;
        public string category;
        public string taxType;
        public int percent;
        public string placeType;
        public string placeAddress;
        public DateTime beginDate;
        public string additionalInfo;
        public DocumentInfo[] documents;
    }
}
