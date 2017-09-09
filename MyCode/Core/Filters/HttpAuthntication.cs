using System;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MyCode.Core.Filters
{
    public class HttpAuthntication: FilterAttribute, IAuthenticationFilter
    {
        private readonly string _username;
        private readonly string _password;

        public HttpAuthntication(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void OnAuthentication(AuthenticationContext filterContext)
        {
            var request = filterContext.HttpContext.Request;
            var headerAuth = request.Headers["Authorization"];
            if (!string.IsNullOrEmpty(headerAuth))
            {
                var value = headerAuth.Replace("Basic", "");
                var decodedValues = Encoding.ASCII.GetString(Convert.FromBase64String(value));
                var values = decodedValues.Split(':');
                if (values[0] != _username || values[1] != _password)
                {
                    filterContext.Result = new HttpUnauthorizedResult();
                }

            }
            else
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            
        }
    }
}