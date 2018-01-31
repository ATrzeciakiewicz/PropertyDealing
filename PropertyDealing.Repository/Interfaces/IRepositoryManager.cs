using PropertyDealing.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDealing.Repository.Interfaces
{
    public interface IRepositoryManager
    {
        IRepository<User> UserRepository { get; }
        IRepository<Property> PropertyRepository { get; }
    }
}
