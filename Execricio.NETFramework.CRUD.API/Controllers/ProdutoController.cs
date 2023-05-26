using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Execricio.NETFramework.CRUD.API.Controllers
{
    [Route("produtos")]
    public class ProdutoController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> BuscarProdutos()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet]
        [Route("produtos/{id}")]
        public string BuscarProduto(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    //public sealed class RouteAttribute2 : Attribute, IDirectRouteFactory, IHttpRouteInfoProvider
    //{
    //    public string Name { get; }
    //    public string Template { get; private set; }
    //    public int Order { get; }

    //    //
    //    // Summary:
    //    //     Initializes a new instance of the System.Web.Http.RouteAttribute class.
    //    public RouteAttribute2()
    //    {
    //        Template = string.Empty;
    //    }
    //    public RouteAttribute2(string template)
    //    {

    //        Template = template;
    //    }
    //    RouteEntry IDirectRouteFactory.CreateRoute(DirectRouteFactoryContext context)
    //    {
    //        IDirectRouteBuilder directRouteBuilder = context.CreateBuilder(Template);
    //        directRouteBuilder.Name = Name;
    //        directRouteBuilder.Order = Order;
    //        return directRouteBuilder.Build();
    //    }
    //}
}
