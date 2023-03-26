using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT
{
    internal class Class1
    {
        public static List<Player> Players = new List<Player>();

        public static void LoadData(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 8)
                    {
                        string name = parts[0];
                        string lastname = parts[1];
                        string studentid = parts[2];
                        string major = parts[3];
                        string displayname = parts[4];
                        string mail = parts[5];
                        string phone = parts[6];
                        int age = int.Parse(parts[7]);
                        Player player = new Player(name, lastname, studentid, major, displayname, mail, phone, age);
                        Players.Add(player);
                    }
                }
            }
        }
        public static void SaveData(string path)
        {
            List<string> lines = new List<string>();
            foreach (Player player in Players)
            {
                string line = string.Join(",", player.Name, player.Lastname, player.ID, player.Major, player.Displayname, player.Mail, player.Phone, player.Age);
                lines.Add(line);
            }
            File.WriteAllLines(path, lines);
        }


    }
}
