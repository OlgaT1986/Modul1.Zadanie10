using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод мер угла-градусы, минуты, секунды
            Console.Write("Введите меру угла - градусы:");
            double gradus_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите меру угла - минуты:");
            double min_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите меру угла - секунды:");
            double sec_ = Convert.ToInt32(Console.ReadLine());
            // создаю экземпляр класса-объект
            Corner corner = new Corner(gradus_, min_, sec_);    
            // преобразую введенные данные угла в радианы
            double totalRadians = corner.ToRadians();
            Console.WriteLine(totalRadians);
            Console.Write("для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }

}

