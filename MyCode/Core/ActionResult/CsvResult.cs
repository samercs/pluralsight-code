using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MyCode.Core.ActionResult
{
    public class CsvResult: FileResult
    {
        private readonly IEnumerable _data;
        public CsvResult(IEnumerable data, string fileName) : base("text/csv")
        {
            _data = data;
            FileDownloadName = fileName;
        }


        protected override void WriteFile(HttpResponseBase response)
        {
            var strBuilder = new StringBuilder();
            var strWriter = new StringWriter(strBuilder);
            foreach (var item in _data)
            {
                var proporites = item.GetType().GetProperties();
                foreach (var proporite in proporites)
                {
                    strWriter.Write(GetValue(item, proporite.Name));
                    strWriter.Write(" ,");
                }
                strWriter.WriteLine();
            } 
            response.Write(strBuilder);
        }

        private string GetValue(object item, string propName)
        {
            return item.GetType().GetProperty(propName).GetValue(item, null).ToString() ?? "";
        }
    }
}