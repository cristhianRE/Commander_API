using System.Collections.Generic;
using Commander.Data.IRepositories;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllComands()
        {
            var Commands = new List<Command>
            {
                new Command
                {
                    Id = 1,
                    HowTo = "Build an egg",
                    Line = "Boil water",
                    Platform = "Kettle & pan"
                },
                new Command
                {
                    Id = 2,
                    HowTo = "Cut a bread",
                    Line = "Get a knife",
                    Platform = "knife and chopping board"
                },
                new Command
                {
                    Id = 3,
                    HowTo = "Make cup of tea",
                    Line = "Place teabag in cup",
                    Platform = "Kettle & cup"
                }
            };

            return Commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 1,
                HowTo = "Build an egg",
                Line = "Boil water",
                Platform = "Kettle & pan"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}