using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data.IRepositories
{
    public interface ICommanderRepository
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllComands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
        void UpdateCommand(Command command);
        void DeleteCommand(Command command);
    }
}