using Dashboard_Fullstack.Server.Models;
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
                Id = 23412,
                Name = "Loaded Dash",
                Organization = "CoolLLC",
                Widgets = new Widget[]
                {
                    new Widget
                    {
                        Id = 3214,
                        Name = "Loaded Widget",
                        Position = "col-lg-4 col-md-6 col-sm-12",
                        Elements = new Element[]
                        {
                            new Element
                            {
                                Id = 7676,
                                Private = false,
                                ElementType = ElementType.Kpi,
                                Data = new Data
                                {
                                    Id = 8383,
                                    Name = "Some data",
                                    Value = 100
                                }
                            },
                            new Element
                            {
                                Id = 6546,
                                Private = false,
                                ElementType = ElementType.Spline,
                                Data = new Data
                                {
                                    Id = 15435,
                                    Name = "Apples",
                                    Value = 24
                                }
                            }}
                    },
                    new Widget
                    {
                        Id = 54279,
                        Name = "Another Loaded Widget",
                        Position = "col-lg-8 col-md-12 col-sm-12",
                        Elements = new Element[]
                        {
                            new Element
                            {
                                Id = 9056,
                                ElementType = ElementType.Bar,
                                Data = new Data
                                {
                                    Id = 1354353,
                                    Name = "Another data",
                                    TextValue = "Some string value"
                                }
                            },
                            new Element
                            {
                                Id = 90561,
                                ElementType = ElementType.Kpi,
                                Data = new Data
                                {
                                    Id = 135212323,
                                    Name = "Anotherd data",
                                    Value = 5
                                }
                            },
                            new Element
                            {
                                Id = 903561,
                                ElementType = ElementType.Kpi,
                                Data = new Data
                                {
                                    Id = 135212323,
                                    Name = "Anotherddd data",
                                    Value = 6
                                }
                            }},


                    }
                }
            };
        }
    }
}
