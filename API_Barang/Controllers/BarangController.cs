using Microsoft.AspNetCore.Mvc;

namespace API_Barang.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BarangController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet(Name = "GetBarang")]
        public IEnumerable<Barang> Get()
        {
            return Barang;
        }
    }
}
