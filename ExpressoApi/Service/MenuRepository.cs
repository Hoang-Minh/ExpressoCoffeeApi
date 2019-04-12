using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Models;

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
            throw new NotImplementedException();
        }

        public Menu GetMenu(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Menu menu)
        {
            throw new NotImplementedException();
        }

        public void Put(Menu menu)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
