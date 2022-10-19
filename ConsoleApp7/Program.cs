using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static void Example04(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //User user = new User();
                    string[] parts = line.Split(';');
                    User user = new User(parts[0], parts[1], parts[2], parts[3]);
                    parts.Add(user);
                }
            }
            using (FileStream fs = new FileStream("Книга1", FileMode.OpenOrCreate))
            {
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, parts.ToArray());
            }
        }
    }
    public class SoapFormatter
    {

    }
    public class User
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public User()
        {

        }
        public User(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

        public string SecondName { get; set; }

        public void GetUser(int UserId, string Name, string FullName, string SecondName)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.FullName = FullName;
            this.SecondName = SecondName;
        }
        public override string ToString()
        {
            return String.Format("Id: {0}\n, FullName:{1}",UserId,Name);
        }
    }
}
