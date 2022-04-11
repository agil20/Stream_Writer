using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Reader
{
    internal class Employe
    {
        /*
Employee class
- Id
- Name
- Salary
- ShowInfo()*/
        public static int _id;
        public int Id { get { return _id; } private set { } }
        public string Name { get; set; }
        public int Salary { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Name {Name}\n" +
                $"Salary {Salary}\n" +
                $"id {Id}");
        }
        public Employe()
        {
            _id++;
            

        }
      



    }
}
