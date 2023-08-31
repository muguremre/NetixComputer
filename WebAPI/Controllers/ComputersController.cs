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
    public class ComputersController : ControllerBase
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
        public async Task<IActionResult> Delete(int id)
        {
            var computers = _computerService.GetById(id);

            if (computers == null || computers.Count == 0)
            {
                return Ok(StatusCode(404, "Bulunamadı"));
                
            }

            // Eğer GetById sonucu gerçekten bir liste ise, burada listeden ilgili öğeyi bulup silin
            var computerToDelete = computers.FirstOrDefault(c => c.ComputerId == id);

            if (computerToDelete == null)
            {
                return Ok(StatusCode(200, "Öğe silindi."));
            }

            _computerService.Delete(computerToDelete);

            return Ok(StatusCode(200,"Silindi"));
        }

        [HttpPost]
        public IActionResult Add([FromBody] ComputerDto computerToAdd)
        {
            if (computerToAdd == null)
            {
                return Ok(StatusCode(404, "Invalid data received."));
            }

            var computurre = new Computer
            {
                ComputerModel = computerToAdd.ComputerModel,
                ComputerName = computerToAdd.ComputerName,
                GraphicsCard = computerToAdd.GraphicsCard,
                OperatingSystem = computerToAdd.OperatingSystem,
                Ram = computerToAdd.Ram,
                ScreenSize = computerToAdd.ScreenSize
            };

            _computerService.Add(computurre);

            return Ok(StatusCode(200, "Computer added successfully."));
        }





    }
}
