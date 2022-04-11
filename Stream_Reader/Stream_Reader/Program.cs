using System;
using System.Collections.Generic;
using System.IO;

namespace Stream_Reader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\User\Desktop\File");
            if (!(File.Exists(@"C:\Users\User\Desktop\File\database.json")))
            {
                File.Create(@"C:\Users\User\Desktop\File\database.json");

            }
            /*Menu
1. Add employee
2. Get employee by id
3. Remove employee
0. Quit

1-ci əməliyyatda istifadəçidən employee-nin bütün məlumatları istənəcək yeni bir employee
obyekti yaranacaq və add methodu vasitəsilə listə əlavə oluncaq daha sonra həmin listi
json-a serialize edəcəksiniz və həmin serialize olunmuş obyekti database.json faylına əlavə
edəcəksiniz.*/
            Console.WriteLine("1.Add emloyee\n" +
                "Get employe by id\n" +
                "Remove employee\n" +
                "Qiut\n");
            Console.WriteLine("secin");
            int secim = Convert.ToInt16(Console.ReadLine());
            switch (secim)
            {
                case 1: Employe employe = new Employe();
                    Console.WriteLine("Ad daxil edin");
                    employe.Name = Console.ReadLine();
                    Console.WriteLine("Maasi qey edin");
                    employe.Salary=Convert.ToInt16(Console.ReadLine());
                List<Employe> employeList = new List<Employe>();
                   Department department = new Department();
                    department.AddEmploye(employe); break;
                   
                    
                default:
                    break;
            }





        }
    }
}
