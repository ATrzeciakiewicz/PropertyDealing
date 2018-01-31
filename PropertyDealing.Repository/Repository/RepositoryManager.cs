using PropertyDealing.Repository.Interfaces;
using PropertyDealing.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyDealing.DataAccess.Models;

namespace PropertyDealing.Repository.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private IRepository<User> userRepository;
        private IRepository<Property> propertyRepository;

        public IRepository<User> UserRepository
        {
            get
            {
                if(userRepository == null)
                {
                    //userRepository = new Repository<User>(new DataAccess.PropertyDealingDbContext());
                }
                return userRepository;
            }
        }

        public IRepository<Property> PropertyRepository
        {
            get
            {
                if(propertyRepository == null)
                {

                }
                return propertyRepository;
            }
        }
    }
}
