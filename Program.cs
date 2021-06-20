using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IToy doll = new Doll();
            IToy warrior = new Warrior();
            IToy raceDriver = new RaceDriver();
            IToy minotaur = new OOD_Retake_1.Minotaur("Min", 80, 190, 120);
            IToy centaur = new OOD_Retake_1.Centaur("Min", 80, 190, true);
            OOD_Retake_1.Decorator[] toysWithParts = { new OOD_Retake_1.Sword(new OOD_Retake_1.Helmet(new OOD_Retake_1.Jump(new OOD_Retake_1.FlowerDress(doll)))),
             new OOD_Retake_1.Sword(new OOD_Retake_1.Helmet(new OOD_Retake_1.Jump(new OOD_Retake_1.ScaryStories(centaur)))),
             new OOD_Retake_1.Sword(new OOD_Retake_1.Jump(new OOD_Retake_1.ScaryStories(minotaur))),
             new OOD_Retake_1.Helmet(new OOD_Retake_1.FlowerDress(raceDriver)),
             new OOD_Retake_1.Sword(new OOD_Retake_1.Helmet(new OOD_Retake_1.Jump(new OOD_Retake_1.ScaryStories(warrior)))) };
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(toysWithParts[0].Summary());
            }
            Console.WriteLine(toysWithParts[0].Cost());
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(toysWithParts[i].Summary());
                Console.WriteLine(toysWithParts[i].Cost());
            }
           
            // Please make sure to put here the code which shows what you've implemented
        }
    }
}
