using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webApiAspNetCore.Services;
using webApiAspNetCore.ViewModel;

namespace webApiAspNetCore.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonsController: ControllerBase
    {
        private readonly IPersonService _PersonService;
        public PersonsController(IPersonService personService)
        {
            _PersonService = personService;
        }
        [HttpPost("[action]")]
        public Task<HttpResponseMessage> Insert([FromBody]PersonViewModel viewModel)
        {
            try{
                _PersonService.Add(viewModel);
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            } catch {
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        [HttpGet]
        public Task<IEnumerable<PersonViewModel>> GetAll(){
            try
            {
                var list = _PersonService.GetAll();
                return Task.FromResult(list);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpGet("{id}")]
        public Task<PersonViewModel> GetById(int id)
        {
            var pvm = _PersonService.GetById(id);
            return Task.FromResult(pvm);
        }
    }
}