using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    public enum Status { on, off }
    public class PC
    {
        string Brand { get; set; }
        string SerialNumber { get; set; }
        public int Price { get; set; }

        public PC()
        {

        }

        public PC(string brand, string serialnumber, int price)
        {
            this.Brand = brand;
            this.SerialNumber = serialnumber;
            this.Price = price;
        }
        public void GetStatus(string s)
        {
            Console.WriteLine(s.ToString());
            Console.WriteLine();
        }
    }
}
