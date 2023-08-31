using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OwnerManager : IOwnerService
    {
        IOwnerDal _ownerDal;
        public OwnerManager(IOwnerDal ownerDal)
        {
            _ownerDal = ownerDal;
        }

        public void Add(Owner entity)
        {
            _ownerDal.Add(entity);   
        }

        public void Delete(Owner entity)
        {
            _ownerDal.Delete(entity);
        }

        public List<Owner> GetAll(Expression<Func<Owner, bool>> filter = null)
        {
            return _ownerDal.GetAll();
        }

        public List<Owner> GetByCountry(string country)
        {
            return _ownerDal.GetAll(o => o.Country == country);
        }

        public List<Owner> GetByEmail(string email)
        {
            return _ownerDal.GetAll(o => o.Email == email);
        }

        public List<Owner> GetByFirstName(string firstName)
        {
            return _ownerDal.GetAll(o => o.FirstName == firstName);
        }

        public List<Owner> GetById(int ownerId)
        {
            return _ownerDal.GetAll(o => o.OwnerId == ownerId);
        }

        public List<Owner> GetByLastName(string lastName)
        {
            return _ownerDal.GetAll(o => o.LastName == lastName);
        }

        public List<Owner> GetByStatus(string status)
        {
            return _ownerDal.GetAll(o => o.Status == status);
        }

        public List<Owner> GetByComputerId(int computerId)
        {
            return _ownerDal.GetAll(o => o.ComputerId == computerId);
        }

        public void Update(Owner entity)
        {
            throw new NotImplementedException();
        }
    }
}
