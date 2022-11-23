using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.models
{
    internal class Workline
    {
        public int Order_number { get; set; }
        public int Job_line_number { get; set; }
        public string? Value { get; set; }
        public int Job_id { get; set; }
    }
}
