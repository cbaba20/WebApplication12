using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace WebApplication12.Controllers
{
    public class DefaultController : ApiController
    {
        public HttpResponseMessage get()
        {




            int count = 0;

            Parallel.Invoke(() =>
            {
                testdbEntities tdb = new testdbEntities();
                ObjectParameter obj1 = new ObjectParameter("count", typeof(int));

                tdb.usp_FetchEmployeecount(obj1);

                count += Convert.ToInt32(obj1.Value);

            }, () =>
            {
                testdbEntities tdb = new testdbEntities();
                ObjectParameter obj2 = new ObjectParameter("count", typeof(int));

                tdb.usp_GetEmployeeCount(obj2);

                count += Convert.ToInt32(obj2.Value);

            });

            var resp = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(count.ToString(), System.Text.Encoding.UTF8, "application/json")
            };
            return resp;


        }
    }
}
