using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT
{
    
    internal class Team
    {
        Player player;
        List<Player> players = new List<Player>();
        private int ageSum = 0;
        string team;
        Player name;

        public Team(string team, string name ,string lastname)
        {
            this.team = team;

        }

        public void addperson2Class(Player p)
        {
            this.players.Add(p);
           // this.ageSum += p.getAge();

           
        }


    }
}
