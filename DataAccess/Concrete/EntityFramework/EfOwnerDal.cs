using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess.Concrete.EntityFramework;

namespace DataAccess.EntityFramework
{
    public class EfOwnerDal : EfEntityRepositoryBase<Owner, NetixComputerContext>, IOwnerDal
    {
        public List<Owner> GetOwnerDetails()
        {
            using (NetixComputerContext context = new NetixComputerContext())
            {
                var result = from o in context.Owners
                             join c in context.Computers
                             on o.ComputerId equals c.ComputerId
                             select new Owner
                             {
                                 OwnerId = o.OwnerId,
                                 FirstName = o.FirstName,
                                 LastName = o.LastName,
                                 Email = o.Email,
                                 Country = o.Country,
                                 Zip = o.Zip,
                                 Status = o.Status,
                                 ComputerId = o.ComputerId,
                                 
                             };
                return result.ToList();
            }
        }
    }
}
