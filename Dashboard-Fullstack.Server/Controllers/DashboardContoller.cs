using Microsoft.AspNetCore.Mvc;


namespace Dashboard_Fullstack.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Dashboard> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Dashboard
            {
                Id = index,
                Name = "Loaded Dash",
                Organization = "CoolLLC",
                Widgets = new Widget[]
                {
                    new Widget 
                    {
                        Id = index,
                        Name = "Loaded Widget",
                        Position = "col-lg-4 col-md-6 col-sm-12",
                        Elements = new Element[]
                        {
                            new Element
                            {
                                Id = index,
                                Private = false,
                                ElementType = ElementType.Text,
                                Data = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"]
                            }}
                    }
                }
            })
            .ToArray();
        }
    }
}
