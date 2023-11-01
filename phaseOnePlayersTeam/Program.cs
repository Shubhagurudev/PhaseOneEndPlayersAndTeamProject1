using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phaseOnePlayersTeam
{
    public class Program
    {
        static void Main(string[] args)
        {
                  
          oneDayTeam team = new oneDayTeam();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("MENU \n 1.Adding player to list \n 2.Removing player from list \n 3.Get Player By Id \n 4.Get Player by Name \n 5.Get Players list ");
                Console.WriteLine("\n");
                Console.WriteLine("Enter your choice:");


                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        team.AddingPlayer(); break;
                    case 2:
                        team.RemovingPlayer(); break;
                    case 3:
                        team.GetPlayerById(); break;
                    case 4:
                        team.GetPlayerByName(); break;
                    case 5:
                        team.listOfPlayers(); break;
                }
                continue;
            }
            Console.ReadLine();
        }
    }
}
