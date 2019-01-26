using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickCV.Data.DataModels
{
    public class JobDetailsDataSet
    {
        public int Id { get; set; }
        public Guid Link { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Description { get; set; }

    }
}
