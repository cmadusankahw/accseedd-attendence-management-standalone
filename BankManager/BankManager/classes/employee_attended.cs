using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.classes
{
    class employee_attended
    {
        public String emp_id { get; set; }
        public String date { get; set; }
        public String in_time { get; set; }
        public String out_time { get; set; }

        public double late_time { get; set; }
        
        public double ot_hours { get; set; }
    }
}
