using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CWTechnicalAssignment.Data;

namespace CWTechnicalAssignment.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IHelloWorldRepository helloWorldRepository;

        public ValuesController(IHelloWorldRepository injectedHelloWorldRepository)
        {
            helloWorldRepository = injectedHelloWorldRepository;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            var returnMessage = helloWorldRepository.GetMessage();

            //Validate Good Reponse from the Repository
            if (returnMessage == null || returnMessage.Length == 0)
            {
                return "Error";
            }

            return returnMessage;
           
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //Validate Input
            if (value  == null || value.Length == 0)
            {
                return ;
            }

            helloWorldRepository.SaveResponse(value);
        }

    }
}
