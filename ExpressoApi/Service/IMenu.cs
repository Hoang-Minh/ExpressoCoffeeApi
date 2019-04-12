using System.Collections.Generic;
using ExpressoApi.Models;

namespace ExpressoApi.Service
{
    public interface IMenu
    {
        IEnumerable<Menu> GetMenus();
        Menu GetMenu(int id);
        void AddMenu(Menu menu);
    }
}
