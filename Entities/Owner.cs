using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Entities
{
    public class Owner : IEntity
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        public int Zip { get; set; }
       
        public string Status { get; set; }
        public int ComputerId { get; set; }

    }
}
