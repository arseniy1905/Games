using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Games.Common.Extensions
{
    public static class MVCExtensions
    {
        /// <summary>
        /// Get controller name according to MVC convension. Exsample: If conroller class is MyAwesomeController, then it's name is: MyAwesome
        /// </summary>
        /// <param name="controller"></param>
        /// <returns>Name of controller</returns>
        public static string GetControllerName(this Controller controller)
        {
            return controller.GetType().Name.Replace("Controller", string.Empty);
        }
        public static void SelectListItem(this List<SelectListItem> list, string selectedValue)
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Value == selectedValue)
                {
                    list[i].Selected = true;
                }
                else
                {
                    list[i].Selected = false;
                }
            }
        }

    }


}
