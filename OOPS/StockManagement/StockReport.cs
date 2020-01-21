using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.StockManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;


    public class StockReport
    {

        public string nameOfShare { get; set; }
        public int numberOfShare { get; set; }
        public double sharePrice { get; set; }
        public void StockGetInput()
        {
            try
            {
                Console.WriteLine("Enter Name of Stock ");
                this.nameOfShare = Console.ReadLine();
                Console.WriteLine("Enter Number of Share ");
                this.numberOfShare = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Price of Per Share ");
                this.sharePrice = Convert.ToInt32(Console.ReadLine());
            }
            catch (InvalidCastException i)
            {
                Console.WriteLine("Please Enter Valide Input " + i);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valide Input" + e);
            }

        }

        internal IEnumerable<object> Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }

}
