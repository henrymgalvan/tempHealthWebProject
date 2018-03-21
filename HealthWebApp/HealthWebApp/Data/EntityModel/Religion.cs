using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel
{
    public class Religion
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }

        public long EmployeeId { get; set; }

    }
}
