using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpressoApi.Service
{
    public class MenuRepository : IMenu
    {
        private ExpressoDbContext expressoDbContext;

        public MenuRepository(ExpressoDbContext anExpressoDbContext)
        {
            expressoDbContext = anExpressoDbContext;
        }

        public IEnumerable<Menu> GetMenus()
        {
            return expressoDbContext.Menus.Include("SubMenus");
        }

        public Menu GetMenu(int id)
        {
            return expressoDbContext.Menus.Include("SubMenus").FirstOrDefault(x => x.Id == id);
        }

        public void AddMenu(Menu menu)
        {
            expressoDbContext.Add(menu);
            expressoDbContext.SaveChanges(true);
        }

        public void UpdateMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        public void DeleteMenu(int id)
        {
            throw new NotImplementedException();
        }
    }
}
