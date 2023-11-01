using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phaseOnePlayersTeam
{
    public interface ITeam
    {
         void AddingPlayer(); 
         void RemovingPlayer(); 
         void GetPlayerById();
         void GetPlayerByName(); 
         void listOfPlayers(); 
    }

    class oneDayTeam : ITeam
    {
        public static List<Player> playerslist = new List<Player>();

        public void AddingPlayer()
        {
            Player p = new Player();
            Console.WriteLine("\nEnter Player ID ");
            p.Pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Player Name  ");
            p.Pname = Console.ReadLine();
            Console.WriteLine("\nEnter age ");
            p.Page = Convert.ToInt32(Console.ReadLine());
            playerslist.Add(p);
            Console.WriteLine("Successfully added player to list");
        }

        public void RemovingPlayer()
        {
            Console.WriteLine("\nEnter player ID to remove from player List  ");
            int giveIdToRremove = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < playerslist.Count; i++)
            {
                if (playerslist[i].Pid == giveIdToRremove)
                {
                    playerslist.RemoveAll(p => p.Pid == giveIdToRremove);
                }
            }
            Console.WriteLine($"Removed {giveIdToRremove} from playerlist");
        }

        public void GetPlayerById()
        {
            Console.WriteLine("\n Enter Id to get player details \n");
            int id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < playerslist.Count; i++)
            {

                if (playerslist[i].Pid == id)
                {
                    Console.WriteLine(playerslist[i].Pid);
                    Console.WriteLine(playerslist[i].Pname);
                    Console.WriteLine(playerslist[i].Page);
                }
            }
        }

        public void GetPlayerByName()
        {
            Console.WriteLine("\n Enter Name to get player details \n");
            string name = Console.ReadLine();
            for (int i = 0; i < playerslist.Count; i++)
            {

                if (playerslist[i].Pname == name)
                {
                    Console.WriteLine(playerslist[i].Pid);
                    Console.WriteLine(playerslist[i].Pname);
                    Console.WriteLine(playerslist[i].Page);
                }
            }
        }

        public void listOfPlayers()
        {
            Console.WriteLine("\nThe list of players are\n");
            foreach (Player item in playerslist)
            {
                Console.WriteLine(item.Pid);
                Console.WriteLine(item.Pname);
                Console.WriteLine(item.Page);
                Console.WriteLine("-------------------------------------------------");
            }
        }

      
    }
}
