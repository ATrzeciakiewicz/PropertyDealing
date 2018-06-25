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
        private IRepository<Property> propertyRepository;    

        public IRepository<Property> PropertyRepository
        {
            get
            {
                if(propertyRepository == null)
                {
                    propertyRepository = new PropertyRepository(new DataAccess.PropertyDealingDbContext());
                }
                return propertyRepository;
            }
        }
    }
}
