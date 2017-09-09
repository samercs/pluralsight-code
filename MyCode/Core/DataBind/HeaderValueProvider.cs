using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace MyCode.Core.DataBind
{
    public class HeaderValueProvider: IValueProvider
    {

        private readonly NameValueCollection _headers;
        private readonly string[] _keys;

        public HeaderValueProvider(NameValueCollection collections)
        {
            _headers = collections;
            _keys = _headers.AllKeys;
        }

        public bool ContainsPrefix(string prefix)
        {
            return _keys.Any(i => i.Replace("-", "").Equals(prefix, StringComparison.OrdinalIgnoreCase));
        }

        public ValueProviderResult GetValue(string key)
        {
            var headerKey =
                _keys.FirstOrDefault(i => i.Replace("-", "").Equals(key, StringComparison.OrdinalIgnoreCase));
            if (headerKey != null)
            {
                return new ValueProviderResult(_headers[headerKey], _headers[headerKey], CultureInfo.CurrentCulture);
            }
            return null;
        }
    }

    public class HeaderValueFactory : ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(ControllerContext controllerContext)
        {
            return new HeaderValueProvider(controllerContext.HttpContext.Request.Headers);
        }
    }
}