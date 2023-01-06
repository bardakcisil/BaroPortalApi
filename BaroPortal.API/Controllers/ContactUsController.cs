
using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto.ContactUs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }
        [HttpGet("getAll")]
        public ActionResult GetAll()
        {

            var result = _contactUsService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddAdvertisement(AddContactUsDto contactUs)
        {
            var result = _contactUsService.AddContactUs(contactUs);
            if (result is not null)
            {
                return Ok(result);
            }
            else { return BadRequest("Advert is not added"); }


        }
    }
}
