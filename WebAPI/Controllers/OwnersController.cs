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
    public class OwnersController : ControllerBase
    {
        IOwnerService _ownerService; // Global değişkenler _ ile başlar
        // Loosely coupled
        // IoC Container -- Inversion of Control
        // injection
        public OwnersController(IOwnerService ownerService)
        {
            _ownerService = ownerService;

        }

        [HttpGet]
        public List<Owner> Get()
        {
            // Dependency chain -- Bağımlılık zinciri
            // EfOwnerDal ı newledik

            var result = _ownerService.GetAll();// GetAll() methodu IOwnerService'de tanımlı
            return result;
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var owners = _ownerService.GetById(id);

            if (owners == null || owners.Count == 0)
            {
                return Ok(StatusCode(404, "Bulunamadı"));
            }

            // Eğer GetById sonucu gerçekten bir liste ise, burada listeden ilgili öğeyi bulup silin
            var ownerToDelete = owners.FirstOrDefault(c => c.OwnerId == id);

            if (ownerToDelete == null)
            {
                return Ok(StatusCode(200, "Öğe silindi."));
            }

            _ownerService.Delete(ownerToDelete);

            return Ok(StatusCode(200, "Silindi"));
        }

        [HttpPost]
        public IActionResult Add([FromBody] OwnerDto ownerToAdd)
        {
            if (ownerToAdd == null)
            {
                return Ok(StatusCode(404, "Invalid data received."));
            }

            var owner = new Owner
            {
                FirstName= ownerToAdd.FirstName,
                LastName = ownerToAdd.LastName,
                Email = ownerToAdd.Email,
                Country = ownerToAdd.Country,
                ComputerId = ownerToAdd.ComputerId,
                Status = ownerToAdd.Status
            };

            _ownerService.Add(owner);

            return Ok(StatusCode(200, "Computer added successfully."));
        }





    }
}
