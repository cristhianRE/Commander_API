using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Data.IRepositories;
using Commander.Data.PersistenceContext;
using Commander.Models;

namespace Commander.Data.Repositories 
{
    public class SqlCommanderRepository : ICommanderRepository 
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepository (CommanderContext context) 
        {
            _context = context;
        }

        public void CreateCommand (Command command) 
        {
            if (command == null) 
            {
                throw new ArgumentException (nameof (command));
            }

            _context.Commands.Add (command);
        }

        public void DeleteCommand(Command command)
        {
            if (command == null) 
            {
                throw new ArgumentException (nameof (command));
            }

            _context.Commands.Remove(command);
        }

        public IEnumerable<Command> GetAllComands () 
        {
            return _context.Commands.ToList ();
        }

        public Command GetCommandById (int id) 
        {
            return _context.Commands.FirstOrDefault (p => p.Id == id);
        }

        public bool SaveChanges () 
        {
            return (_context.SaveChanges () >= 0);
        }

        public void UpdateCommand (Command command) 
        {
            //Nothing
        }
    }
}