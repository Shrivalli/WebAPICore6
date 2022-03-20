using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("getvalues")]
        public ActionResult<List<string>> GetValues()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Kiwi");
            fruits.Add("Cherry");
            fruits.Add("Strawberry");
            return fruits;
        }
    }
}
