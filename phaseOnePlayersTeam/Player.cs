using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phaseOnePlayersTeam
{
    public class Player
    {
        public string Pname;
        public int Pid;
        public int Page;
        public Player() { }

        public Player(string Pname, int Pid, int Page)
        {
            this.Pname = Pname;
            this.Pid = Pid;
            this.Page = Page;
        }
    }
}