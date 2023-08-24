using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities;

namespace Business.Abstract
{
    public interface IComputerService : IEntityRepositoryBase<Computer>
    {
        //List <Computer> GetAll();
        List<Computer> GetByComputerName(string computerName);
        List<Computer> GetByComputerModel(string computerModel);
        List<Computer> GetByGraphicsCard(string graphicsCard);
        List<Computer> GetByOperatingSystem(string operatingSystem);
        List<Computer> GetByRam(string ram);
        List<Computer> GetByScreenSize(float screenSize);
        //List<Computer> GetById(int computerId);
        //void Delete(int computerId);

    }
}
