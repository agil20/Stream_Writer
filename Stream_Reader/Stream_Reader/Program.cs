using Newtonsoft.Json;
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
                "2.Get employe by id\n" +
                "3.Remove employee\n" +
                "0.Qiut\n");
            Console.WriteLine("secin");
            Department department = new Department();
            int secim = Convert.ToInt16(Console.ReadLine());
            do
            {
                switch (secim)

                {
                    case 1:
                        Employe employe = new Employe();
                        Console.WriteLine("Ad daxil edin");
                        employe.Name = Console.ReadLine();
                        Console.WriteLine("Maasi qey edin");
                        employe.Salary = Convert.ToInt16(Console.ReadLine());


                        department.AddEmploye(employe);

                        string result = JsonConvert.SerializeObject(department);
                        string path = (@"C:\Users\User\Desktop\File\database.json");
                        using (StreamWriter stream = new(path))
                        {
                            stream.WriteLine(result);
                        }
                        break;
                    case 2:

                        string result2;
                        string path2 = (@"C:\Users\User\Desktop\File\database.json");
                        Console.WriteLine("Id daxil edin");
                        int idd = Convert.ToInt32(Console.ReadLine());
                        using (StreamReader stream = new(path2))
                        {
                            result2 = stream.ReadToEnd();
                        }
                        Department department2 = JsonConvert.DeserializeObject<Department>(result2);
                        foreach (var item in department2.Employes)
                        {
                            if (item.Id == idd)
                            {
                                department.GetEmployeeById(idd);
                            }

                        }
                        break;
                    case 3:
                        string result3;
                        string path3 = (@"C:\Users\User\Desktop\File\database.json");
                        Console.WriteLine("Id daxil edin");
                        int iddd = Convert.ToInt32(Console.ReadLine());
                        using (StreamReader stream = new(path3))
                        {
                            result3 = stream.ReadToEnd();
                        }
                        Department department3 = JsonConvert.DeserializeObject<Department>(result3);
                        foreach (var item in department3.Employes)
                        {
                            if (item.Id == iddd)
                            {
                                department3.RemoveEmploye(iddd);
                            }

                        }
                        string result4 = JsonConvert.SerializeObject(department3);
                        string path4 = (@"C:\Users\User\Desktop\File\database.json");
                        using (StreamWriter stream = new(path4))
                        {
                            stream.WriteLine(result4);
                        }
                        break;

                    case 0: break;
                }

            } while (secim<0&& secim >3);  /*
3-cü əməliyyatda isə yenə 2 ci əməliyyatdakı kimi database.json oxunacaq deserialize olunacaq
department obyektinə həmin idli employee tapılacaq və listdən silinəcək daha sonra həmin depatment
yenidən obyekti serialize olunacaq json-a və database.json file-na yazılacaq.*/





        }
    }
}
