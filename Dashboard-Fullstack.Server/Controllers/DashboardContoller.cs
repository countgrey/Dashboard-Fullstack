using AngularAuthAPI.Context;
using Dashboard_Fullstack.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Dashboard_Fullstack.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {

        private readonly AppDBContext _context;

        public DashboardController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dashboard = await _context.Dashboards
                .Include(d => d.Widgets)
                    .ThenInclude(w => w.Elements) // Загружаем элементы связанных виджетов
                        .ThenInclude(e => e.Data)
                .FirstOrDefaultAsync(d => d.Id == 1);

            return Ok(dashboard); // Возвращаем дашборд
        }
    }
}
