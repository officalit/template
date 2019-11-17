using mvc_ang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvc_ang.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        public BaseRepository Model => BaseRepository.Model;
        [HttpGet]
        [Route("list")]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new JsonContent(new
                {
                    Success = true, //error
                    Message = "Success",
                    list = Model.GetBuyProducts(),
                    //return exception
                })
            };
        }
    }
}