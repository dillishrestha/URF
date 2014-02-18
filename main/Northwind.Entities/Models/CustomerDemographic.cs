using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace Northwind.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class CustomerDemographic : ITrackable
    {
        public CustomerDemographic()
        {
            this.Customers = new List<Customer>();
        }

        [DataMember]
        public string CustomerTypeID { get; set; }
        [DataMember]
        public string CustomerDesc { get; set; }
        [DataMember]
        public List<Customer> Customers { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
