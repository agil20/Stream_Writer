using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Reader
{
    internal class Department
    {
        /* Department
 - Id
 - Name
 - Employees list*/

        public int Id { get; set; }
        public static int _id;
        public string Name { get; set; }
        List<Employe>Employes=new List<Employe>();
        /*- AddEmployee() - employee obyekti qebul edecek
- GetEmployeeById() - id qebul edecek
- RemoveEmployee() - id qebul edecek*/
        public void AddEmploye(Employe employe)
        {
            Employes.Add(employe);
        }
        public void GetEmployeeById(int ? id)
        {
            if (id == null)
            {
                throw new Exception("Not Found ");
            }
            else
            {
                Employes.FindAll(x => x.Id == id);
            }
         
        }
        public void RemoveEmploye(int id)
        {
            if (id == null)
            {
                throw new Exception("Not Found ");
            }
            else
            {

            }
            foreach (var item in Employes)
            {
                if (id == item.Id)
                {
                    Employes.RemoveAt(item.Id);
                }
            }
        }
        }
    }
}
