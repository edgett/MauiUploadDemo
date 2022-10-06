using Microsoft.AspNetCore.Mvc;
using SharedBetweenWebApiAndMaui;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        // POST api/<FileUploadController>
        [HttpPost]
        public void Post([FromForm] IFormFile filex, [FromForm] string metaData)
        {

            var metaDataObj = System.Text.Json.JsonSerializer.Deserialize<XXMediaMetaData>(metaData);
            metaDataObj.


        }

        
    }
}
