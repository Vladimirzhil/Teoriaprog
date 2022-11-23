using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.models
{
    internal class Orderforobject
    {
        public int Order_number { get; set; }
        public string? Order_date { get; set; }
        public int Client_ID { get; set; }
        public string? Address_of_the_object { get; set; }
        public string? Execution_date { get; set; }
        public int Contract_number { get; set; }
        public int Manageremployee_Id { get; set; }
        public int Masteremployee_Id { get; set; }
        public int Designeremployee_Id { get; set; }
        public int Design_ID { get; set; }
        public int line_of_work { get; set; }
        public int Order_line { get; set; }
        public string? Execution_Status { get; set; }

    }
}
