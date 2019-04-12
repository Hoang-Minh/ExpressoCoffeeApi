using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Models;

namespace ExpressoApi.Service
{
    public interface IMenu
    {
        IEnumerable<Menu> GetMenus();
        Menu GetMenu(int id);
        void Post(Menu menu);
        void Put(Menu menu);
        void Delete(int id);
    }
}
