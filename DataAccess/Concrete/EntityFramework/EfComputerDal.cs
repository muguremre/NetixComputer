using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace DataAccess.EntityFramework
{
    public class EfComputerDal : EfEntityRepositoryBase<Computer, NetixComputerContext>, IComputerDal
    {
        public List<Computer> GetComputerDetails()
        {
            using(NetixComputerContext context = new NetixComputerContext())
            {
               var result = from c in context.Computers
                            join b in context.Owners
                            on c.ComputerId equals b.ComputerId
                            select new Computer
                            {
                                ComputerId = c.ComputerId,
                                ComputerName = c.ComputerName,
                                ComputerModel = c.ComputerModel,
                                GraphicsCard = c.GraphicsCard,
                                OperatingSystem = c.OperatingSystem,
                                Ram = c.Ram,
                                ScreenSize = c.ScreenSize,  
                            };
                return result.ToList();
            }
        }
    }
}
