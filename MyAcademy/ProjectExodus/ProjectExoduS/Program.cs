using System;

namespace ProjectExoduS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ooga booga din kommun....");
            while (true)
            {
                MainMenu A = new MainMenu();
                BattleField B = new BattleField();

                B.Battle();
            }
        
        }
    }
}
