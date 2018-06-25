using PropertyDealing.DataAccess;
using PropertyDealing.DataAccess.Models;
using PropertyDealing.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDealing.Repository.Repository
{
    public class PropertyRepository : Repository<Property>, IPropertyRepository
    {
        public PropertyRepository(PropertyDealingDbContext context) : base(context)
        {

        }
    }
}
