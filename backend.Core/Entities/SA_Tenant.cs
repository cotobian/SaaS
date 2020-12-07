using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Core.Entities
{
    public class SA_Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TaxCode { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public List<TA_User> TA_users { get; set; }
        public DateTime update_time { get; set; }
    }
}
