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
        public static int _id;
        public int Id { get { return _id; } set { } }
        public Employe employe { get; set; }
        public string Name { get; set; }
        public List<Employe> Employes;
        public Department()
        {
            Employes   = new List<Employe>();
            _id++;
            Id = _id;
            
        }
        
        /*- AddEmployee() - employee obyekti qebul edecek
- GetEmployeeById() - id qebul edecek
- RemoveEmployee() - id qebul edecek*/
        public void AddEmploye(Employe employe)
        {
            Employes.Add(employe);
        }
        public void GetEmployeeById(int ? id)
        {
            
                foreach (var item in Employes)
                {
                    if (item.Id==id)
                    {
                        item.ShowInfo();
                    }

                }
            
         
        }
        public void RemoveEmploye(int? id)
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
