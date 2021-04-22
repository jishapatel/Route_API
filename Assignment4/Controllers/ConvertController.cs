using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment4.Controllers
{
    public class ConvertController : ApiController
    {
        static String str = "";
        [Route("api/Upper")]
        public String GetUppercase(String str)
        {

            return str.ToUpper();
        }
        [Route("api/Lower")]
        public String GetLowercase(String str)
        {

            return str.ToLower();
        }
        [Route("api/Reverse")]
        public String GetReversecase(String str)
        {

            char ch;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    ch = Char.ToLower(str[i]);
                    str.Append(ch);
                }
                else if (char.IsLower(str[i]))
                {
                    ch = Char.ToUpper(str[i]);
                    str.Append(ch);

                }
                else
                {
                    ch = str[i];
                    str.Append(ch);
                }


            }
           

            return str;
        }

        [Route("api/Init")]
        public String GetInitcase(String str)
        {

            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(str);
        }
    }
}
