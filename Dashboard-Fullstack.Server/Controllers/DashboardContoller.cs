using Microsoft.AspNetCore.Mvc;


namespace Dashboard_Fullstack.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {

        [HttpGet]
        public Dashboard Get()
        {
            return new Dashboard
            {
                Id = 0,
                Name = "Loaded Dash",
                Organization = "CoolLLC",
                Widgets = new Widget[]
                {
                    new Widget
                    {
                        Id = 1,
                        Name = "Loaded Widget",
                        Position = "col-lg-4 col-md-6 col-sm-12",
                        Elements = new Element[]
                        {
                            new Element
                            {
                                Id = 1,
                                Private = false,
                                ElementType = ElementType.Kpi,
                                Data = new Data
                                {
                                    Id = 1,
                                    Name = "Some data",
                                    Value = 100
                                }
                            },
                            new Element
                            {
                                Id = 1,
                                Private = false,
                                ElementType = ElementType.Kpi,
                                Data = new Data
                                {
                                    Id = 1,
                                    Name = "Apples",
                                    Value = 24
                                }
                            }}
                    },
                    new Widget
                    {
                        Id = 2,
                        Name = "Another Loaded Widget",
                        Position = "col-lg-8 col-md-12 col-sm-12",
                        Elements = new Element[]
                        {
                            new Element
                            {
                                Id = 2,
                                Private = false,
                                ElementType = ElementType.Text,
                                Data = new Data
                                {
                                    Id = 2,
                                    Name = "Another data",
                                    TextValue =  "Some string value"
                                }
                            }}
                    }
                }
            };
        }
    }
}
