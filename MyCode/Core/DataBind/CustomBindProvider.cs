using System;
using System.Web.Mvc;
using Entity;

namespace MyCode.Core.DataBind
{
    public class CustomBindProvider: IModelBinderProvider
    {
        public IModelBinder GetBinder(Type modelType)
        {
            if (modelType == typeof(DataBindTest))
            {
                return new CustomDataBind();
            }
            return null;
        }
    }
}