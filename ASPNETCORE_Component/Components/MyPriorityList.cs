using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCORE_Component.Components
{
    // 3 way to define viewcomponent class:--->
    //public class MyPriorityListViewComponent : ViewComponent
    //public class MyPriorityList : ViewComponent

    // [ViewComponent(Name = "CustomNameOfMyPriorityList")]   // We can change name of Component using attribute "ViewComponent"
    public class MyPriorityList : ViewComponent
    {


        public MyPriorityList()   // Can Use Dependency Injection 
        {
        
        }

        public IViewComponentResult Invoke(int ItemCount)
        {
            string viewName = "Default";
            if (ItemCount > 4)
            {
                viewName = "MyViewComp";
            }
            var items = GetItemsAsync(ItemCount);
            return View(viewName,items);
        }

        private List<string> GetItemsAsync(int ItemCount)
        {

            List<string> items = new List<string>() { "Item1","Item2","Item3","Item4","Item5","Item6"};
            var LimitedItems= items.Take(ItemCount).ToList();
            return LimitedItems;
        }
        
    }
}
