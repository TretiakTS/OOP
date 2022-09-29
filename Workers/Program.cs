// See https://aka.ms/new-console-template for more information
using Workers;
Manager manager = new Manager("Tetiana");
Developer developer = new Developer("Katya");
Team team = new Team("Team_Workers");
team.AddWorker(manager);
team.AddWorker(developer);
Team.ShowInform(team);
