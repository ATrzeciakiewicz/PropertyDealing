using PropertyDealing.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyDealing.Models
{
    public class PropertyContainer
    {
        public PropertyContainer()
        {
            Property = new Property();
        }
        public Property Property { get; set; }
    }
}