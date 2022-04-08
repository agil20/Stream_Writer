using System;
using System.IO;

namespace Stream_Reader
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
1-ci əməliyyatda istifadəçidən employee-nin bütün məlumatları istənəcək yeni bir employee
obyekti yaranacaq və add methodu vasitəsilə listə əlavə oluncaq daha sonra həmin listi
//json-a serialize edəcəksiniz və həmin serialize olunmuş obyekti database.json faylına əlavə
//edəcəksiniz.*/
            //            Employe employe = new Employe();
            //            Console.WriteLine( "Adi daxil edin");
            //            employe.Name =Console.ReadLine();
            //            Console.WriteLine("Maasi qeyd edin");
            //            employe.Salary=Convert.ToInt32(Console.ReadLine());
            /*Files folder-i yaradırsız içindədə Database.json deyə bir file yaradırsız amma database.json-u
yaratmamışdan qabaq yoxlayırsız bu adda file yoxdursa yaradır*/

            if (!(Directory.Exists(@"C: \Users\User\Source\Repos\Stream_Writer11\Stream_Reader\Stream_Reader\Fils\")))
            {
                Directory.CreateDirectory(@"C: \Users\User\Source\Repos\Stream_Writer11\Stream_Reader\Stream_Reader\Fils\database.json");

            } 





        }
    }
}
