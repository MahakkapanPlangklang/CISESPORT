using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private string team;
        private string name;
        private string lastname;
        

        //public Team(string team, string name ,string lastname)
        //{
        //    this.team = team;
        //    this.name = name;
        //    this.lastname = lastname;



        //}

        public void addperson2Class(Player p)
        {
            this.players.Add(p);
           // this.ageSum += p.getAge();


           
        }

        //public string Teams { get => team; }
        //public string Name2 { get => name; }
        //public string LastName2 { get => lastname; }


    }
}
