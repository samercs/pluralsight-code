using System.Web.Mvc;
using System.Xml.Serialization;

namespace MyCode.Core.ActionResult
{
    public class XmlResult: System.Web.Mvc.ActionResult
    {
        private readonly object _data;
        public XmlResult(object data)
        {
            _data = data;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            XmlSerializer serializer = new XmlSerializer(_data.GetType());
            context.HttpContext.Request.ContentType = "text/xml";
            serializer.Serialize(context.HttpContext.Response.Output, _data);
        }
    }
}