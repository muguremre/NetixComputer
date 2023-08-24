using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOwnerService
    {
        List<Owner> GetAll();
        List<Owner> GetByFirstName(string firstName);
        List<Owner> GetByLastName(string lastName);
        List<Owner> GetByEmail(string email);
        List<Owner> GetByCountry(string country);
        List<Owner> GetByZip(int zip);
        List<Owner> GetByStatus(string status);
        List<Owner> GetById(int ownerId);

    }
}
