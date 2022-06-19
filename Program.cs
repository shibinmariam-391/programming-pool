using System;
using System.Data;
using System.Linq;

namespace TemperatureVariation
{
    class Program
    {
        static void Main(string[] args)
        {
            //To create a Datatable to read data
            DataTable table= new DataTable("Temperature");
            table.Columns.Add("Dy", typeof(int));
            table.Columns.Add("MxT", typeof(int));
            table.Columns.Add("MnT", typeof(int));

            //To insert data into datatable
            table.Rows.Add(1, 88, 59);
            table.Rows.Add(2, 79, 63);
            table.Rows.Add(3, 77, 55);
            table.Rows.Add(4, 77, 59);
            table.Rows.Add(5, 90, 66);
            table.Rows.Add(6, 81, 61);
            table.Rows.Add(7, 73, 57);
            table.Rows.Add(8, 75, 54);
            table.Rows.Add(9, 86, 32);
            table.Rows.Add(10, 84, 64);
            table.Rows.Add(11, 91, 59);
            table.Rows.Add(12, 88, 73);
            table.Rows.Add(13, 70, 59);
            table.Rows.Add(14, 61, 59);
            table.Rows.Add(15, 64, 55);
            table.Rows.Add(16, 79, 59);
            table.Rows.Add(17, 81, 57);
            table.Rows.Add(18, 82, 52);
            table.Rows.Add(19, 81, 61);
            table.Rows.Add(20, 84, 57);
            table.Rows.Add(21, 86, 59);
            table.Rows.Add(22, 90, 64);
            table.Rows.Add(23, 90, 68);
            table.Rows.Add(24, 90, 77);
            table.Rows.Add(25, 90, 72);
            table.Rows.Add(26, 97, 64);
            table.Rows.Add(27, 91, 72);
            table.Rows.Add(28, 84, 68);
            table.Rows.Add(29, 88, 66);
            table.Rows.Add(30, 90, 45);

            //To get min difference
            var required = (from sel in table.AsEnumerable()
            select sel.Field<int>("MxT")-sel.Field<int>("MnT")).Min();
            
            //To compare with the difference
            var day = from x in table.AsEnumerable()
            where x.Field<int>("MxT")-x.Field<int>("MnT") == required
            select x;

            foreach(var item in day){
                Console.WriteLine("Day with minimum variation is : "+item.Field<int>("Dy"));
            }
            
        }
    }
}
