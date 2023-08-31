using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOwnerService : IEntityRepositoryBase<Owner>
    {
       // List<Owner> GetAll();
        List<Owner> GetByFirstName(string firstName);
        List<Owner> GetByLastName(string lastName);
        List<Owner> GetByEmail(string email);
        List<Owner> GetByCountry(string country);
        List<Owner> GetByComputerId(int computerId);
        List<Owner> GetByStatus(string status);
        List<Owner> GetById(int ownerId);

    }
}
