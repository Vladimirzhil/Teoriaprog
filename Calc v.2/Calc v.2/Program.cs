using System.Data;

namespace Calc_v._2
{
    class Program
    {
   
        static void Main(string[] args)
        {
            while (true)
            {
                string expression;
                Console.WriteLine("Введите выражение: ");
                expression = Console.ReadLine();
                Console.WriteLine(Calculate(expression));
            }
        }
        public static double Calculate(string expression)
        {         
            DataTable table = new DataTable();    
            table.Columns.Add("expression", typeof(string), expression);        
            DataRow row = table.NewRow();         
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        } 
    }   
} 