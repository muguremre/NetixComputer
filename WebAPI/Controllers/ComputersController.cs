using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.EntityFramework;
using Entities;
using Entities.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //Attribute
    public class ComputersController
    {
        IComputerService _computerService; // Global değişkenler _ ile başlar
        // Loosely coupled
        // IoC Container -- Inversion of Control
        // injection
        public ComputersController(IComputerService computerService)
        {
            _computerService = computerService;

        }

        [HttpGet]
        public List<Computer> Get()
        {
            // Dependency chain -- Bağımlılık zinciri
            // EfComputerDal ı newledik

            var result = _computerService.GetAll();// GetAll() methodu IComputerService'de tanımlı
            return result;
        }


        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            var computers = _computerService.GetById(id);

            if (computers == null || computers.Count == 0)
            {
                return ("Boş");
            }

            // Eğer GetById sonucu gerçekten bir liste ise, burada listeden ilgili öğeyi bulup silin
            var computerToDelete = computers.FirstOrDefault(c => c.ComputerId == id);

            if (computerToDelete == null)
            {
                return ("Bulunan öğe silindi");
            }

            _computerService.Delete(computerToDelete);

            return ("Silindi");
        }

        [HttpPost]
        public string Add([FromBody] ComputerDto computerToAdd)
        {
            if (computerToAdd == null)
            {
                return ("Invalid data received.");
            }

            var computurre = new Computer
            {
                ComputerModel = computerToAdd.ComputerModel,
                ComputerName = computerToAdd.ComputerName,
                GraphicsCard = computerToAdd.GraphicsCard,
                OperatingSystem = computerToAdd.OperatingSystem,
                Ram = computerToAdd.Ram,

            };

            _computerService.Add(computurre);

            return ("Computer added successfully.");
        }





    }
}
