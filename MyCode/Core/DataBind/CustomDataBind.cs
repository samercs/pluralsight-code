using System;
using System.Web.Mvc;
using Entity;


namespace MyCode.Core.DataBind
{
    public class CustomDataBind : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            return new DataBindTest
            {
                Name = request.Form.Get("Name"),
                Data = new DateTime(int.Parse(request.Form.Get("Year")), int.Parse(request.Form.Get("Month")), int.Parse(request.Form.Get("Day")))

            };
        }
    }
}