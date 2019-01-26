using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickCV.Data.DataModels
{
    public class PersonalDetailsDataSet
    {
        public int Id { get; set; }
        public Guid Link { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public int Phone { get; set; }
                
    }

}
