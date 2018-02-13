using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDealing.DataAccess.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public byte[] Image { get; set; }
        public int RoomsNumber { get; set; }
        public int PropertyArea { get; set; }
        public int Storey { get; set; }
        public bool IsBalcony { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
