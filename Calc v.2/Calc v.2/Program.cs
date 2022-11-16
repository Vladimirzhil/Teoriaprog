using System.Data;

namespace Calc_v._2
{
    class Program
    {
   
        static void Main(string[] args)
        {
            while (true)
            {
                string a;
                Console.WriteLine("Введите выражение: ");  
                a = Console.ReadLine();
                Console.WriteLine(Evaluate(a));
            }
        }
        public static double Evaluate(string expression)
        {         
            DataTable table = new DataTable();    
            table.Columns.Add("expression", typeof(string), expression);        
            DataRow row = table.NewRow();         
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        } 
    }   
}