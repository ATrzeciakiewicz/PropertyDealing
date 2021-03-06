﻿using PropertyDealing.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDealing.Repository.Interfaces
{
    public interface IRepositoryManager
    {
        IRepository<Property> PropertyRepository { get; }
    }
}
