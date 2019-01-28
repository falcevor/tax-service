using System;
using System.Runtime.Serialization;

namespace TaxServiceLibrary.Model
{
    [DataContract]
    public class FinOperationInfo
    {
        [DataMember]
        int id;

        [DataMember]
        DateTime date;

        [DataMember]
        int amount;
    }
}
