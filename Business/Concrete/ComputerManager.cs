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
    public class ComputerManager : IComputerService
    {
        IComputerDal _computerDal;
        public ComputerManager(IComputerDal computerDal)
        {
            _computerDal = computerDal;
        }

        public void Add(Computer entity)
        {
            _computerDal.Add(entity);
        }

        public void Delete(Computer entity)
        {
            _computerDal.Delete(entity);
        }

        public List<Computer> GetAll(Expression<Func<Computer, bool>> filter = null)
        {
            return _computerDal.GetAll();
        }

        public List<Computer> GetByComputerModel(string computerModel)
        {
            return _computerDal.GetAll(c => c.ComputerModel == computerModel);
        }

        public List<Computer> GetByComputerName(string computerName)
        {
            return _computerDal.GetAll(c => c.ComputerName == computerName);
        }

        public List<Computer> GetByGraphicsCard(string graphicsCard)
        {
            return _computerDal.GetAll(c => c.GraphicsCard == graphicsCard);
        }

        public List<Computer> GetById(int id)
        {
            return _computerDal.GetAll(c => c.ComputerId == id);
        }

        public List<Computer> GetByOperatingSystem(string operatingSystem)
        {
            return _computerDal.GetAll(c => c.OperatingSystem == operatingSystem);
        }

        public List<Computer> GetByRam(string ram)
        {
            return _computerDal.GetAll(c => c.Ram == ram);
        }

        public List<Computer> GetByScreenSize(float screenSize)
        {
            return _computerDal.GetAll(c => c.ScreenSize == screenSize);
        }

        public void Update(Computer entity)
        {
            _computerDal.Update(entity);
             
        }


        //public void Delete(int computerId)
        //{
        //   _computerDal.Delete(new Computer { ComputerId = computerId }) ;
        //}

        //public List<Computer> GetAll()
        //{
        //    return _computerDal.GetAll();
        //}

        //public List<Computer> GetByComputerModel(string computerModel)
        //{
        //    return _computerDal.GetAll(c => c.ComputerModel == computerModel);
        //}

        //public List<Computer> GetByComputerName(string computerName)
        //{
        //    return _computerDal.GetAll(c => c.ComputerName == computerName);
        //}

        //public List<Computer> GetByGraphicsCard(string graphicsCard)
        //{
        //    return _computerDal.GetAll(c => c.GraphicsCard == graphicsCard);
        //}

        //public List<Computer> GetById(int computerId)
        //{
        //    return _computerDal.GetAll(c => c.ComputerId == computerId);
        //}

        //public List<Computer> GetByOperatingSystem(string operatingSystem)
        //{
        //    return _computerDal.GetAll(c => c.OperatingSystem == operatingSystem);
        //}

        //public List<Computer> GetByRam(string ram)
        //{
        //    return _computerDal.GetAll(c => c.Ram == ram);
        //}

        //public List<Computer> GetByScreenSize(float screenSize)
        //{
        //    return _computerDal.GetAll(c => c.ScreenSize == screenSize);
        //}
    }
}
