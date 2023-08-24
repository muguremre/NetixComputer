using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryOwnerDal : IOwnerDal
    {
        List<Owner> _owners;

        public void Add(Owner entity)
        {
            
            _owners.Add(entity);
        }

        public void Delete(Owner entity)
        {
            Owner ownerToDelete = _owners.SingleOrDefault(o => o.OwnerId == entity.OwnerId);
            _owners.Remove(ownerToDelete);
            
        }

        public List<Owner> GetAll(Expression<Func<Owner, bool>> filter = null)
        {
            
            return _owners;
        }

        public List<Owner> GetOwnerDetails()
        {
            _owners = new List<Owner> {
             new Owner { OwnerId = 1, FirstName = "Emir Eren", LastName = "Gümüştaş",
                Email= "erengumustas@gmail.com",
                Country="Turkey",Zip=34000,Status="Student" },
            new Owner
            {
                OwnerId = 2,
                FirstName = "Abdullah Emir",
                LastName = "Taşdemir",
                Email = "emirtasdemir@gmail.com",
                Country = "Turkey",
                Zip = 34000,
                Status = "Student"
            },
            new Owner
            {
                OwnerId = 3,
                FirstName = "Ahmet Geylani",
                LastName = "Akdemir",
                Email = "ahmetakdemir@gmail.com",
                Country = "Turkey",
                Zip = 34000,
                Status = "Student"
            },
            new Owner
            {
                OwnerId = 4,
                FirstName = "Devrim",
                LastName = "Güneş",
                Email = "devrimgunes@gmail.com",
                Country = "Turkey",
                Zip = 34000,
                Status = "Student"
            },
        };
           
            return _owners;


        }

        public void Update(Owner entity)
        {
            
            Owner ownerToUpdate = _owners.SingleOrDefault(o => o.OwnerId == entity.OwnerId);
            ownerToUpdate.FirstName = entity.FirstName;
            ownerToUpdate.LastName = entity.LastName;
            ownerToUpdate.Email = entity.Email;
            ownerToUpdate.Country = entity.Country;
            ownerToUpdate.Zip = entity.Zip;
            ownerToUpdate.Status = entity.Status;
        }

        public Owner GetById(int id)
        {
            return _owners.SingleOrDefault(o => o.OwnerId == id);
        }

        List<Owner> IEntityRepositoryBase<Owner>.GetById(int id)
        {
            return _owners.Where(o => o.OwnerId == id).ToList();
        }
    }
}
