using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryComputerDal : IComputerDal
    {
        List<Computer> _computers;
        public List<Computer> GetComputerDetails()
        {
            _computers = new List<Computer>
            {
                new Computer{ComputerId=1,ComputerName="Asus",ComputerModel="Zenbook",GraphicsCard="Nvidia",OperatingSystem="Windows 10",Ram="16 GB",ScreenSize=15.6f},
                new Computer{ComputerId=2,ComputerName="Lenovo",ComputerModel="Legion",GraphicsCard="Nvidia",OperatingSystem="Windows 10",Ram="16 GB",ScreenSize=15.6f},
                new Computer{ComputerId=3,ComputerName="Apple",ComputerModel="Macbook Pro",GraphicsCard="AMD",OperatingSystem="MacOS",Ram="16 GB",ScreenSize=15.6f},
                new Computer{ComputerId=4,ComputerName="HP",ComputerModel="Pavilion",GraphicsCard="Nvidia",OperatingSystem="Windows 10",Ram="16 GB",ScreenSize=15.6f},
                new Computer{ComputerId=5,ComputerName="Dell",ComputerModel="XPS",GraphicsCard="Nvidia",OperatingSystem="Windows 10",Ram="16 GB",ScreenSize=15.6f},
                new Computer{ComputerId=6,ComputerName="MSI",ComputerModel="GS66",GraphicsCard="Nvidia",OperatingSystem="Windows 10",Ram="16 GB",ScreenSize=15.6f},
                new Computer{ComputerId=7,ComputerName="Acer",ComputerModel="Predator",GraphicsCard="Nvidia",OperatingSystem="Windows 10",Ram="16 GB",ScreenSize=15.6f},
                new Computer{ComputerId=8,ComputerName="Huawei",ComputerModel="Matebook",GraphicsCard="Nvidia",OperatingSystem="Windows 10",Ram="16 GB",ScreenSize=15.6f},
                new Computer{ComputerId=9,ComputerName="Samsung",ComputerModel="Galaxy Book",GraphicsCard="Nvidia",OperatingSystem="Windows 10",Ram="16 GB",ScreenSize=15.6f},
                new Computer{ComputerId=10,ComputerName="Xiaomi",ComputerModel="Mi Notebook",GraphicsCard="Nvidia",OperatingSystem="Windows 10",Ram="16 GB",ScreenSize=15.6f}
            };
            return _computers;
            


        }
    }
}
