using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Team
    {
        private string name;
        public Team(string name)
        {
            this.name = name;
        }
        private List<Worker> list = new List<Worker>();
        public void AddWorker(Worker worker)
        {
            if ((worker is Developer) || (worker is Manager))
            {
                list.Add(worker);
            }
        }
        static public void ShowInform(Team team)
        {
            for (int i = 0; i < team.list.Count; i++)
            {
                if (team.list[i] is Manager)
                {
                    Manager manager = (Manager)team.list[i];
                    Console.WriteLine("< " + team.name + " > - < " + manager.Name + " > - < " + manager.Position + " > - < " + manager.WorkDay + ">");
                }
                if (team.list[i] is Developer)
                {
                    Developer developer = (Developer)team.list[i];
                    Console.WriteLine("< " + team.name + " > - < " + developer.Name + " > - < " + developer.Position + " > - < " + developer.WorkDay + ">");
                }
            }
        }
    }
}
