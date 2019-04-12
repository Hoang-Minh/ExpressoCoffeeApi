using ExpressoApi.Models;
using ExpressoApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace ExpressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private IMenu menuRepository;

        public MenusController(IMenu aMenuRepository)
        {
            menuRepository = aMenuRepository;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = menuRepository.GetMenus();
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = menuRepository.GetMenu(id);
            return menu == null ? NotFound("Menus not found...") : (IActionResult)Ok(menu);
        }

        [HttpPost]
        public void AddMenu(Menu menu)
        {
            menuRepository.AddMenu(menu);
        }
    }
}