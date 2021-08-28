using Bussines.Abstract;
using Bussines.Service.Abstract;
using Core.Results;
using DAL.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    
    [Route("jop/[controller]")]
    [Authorize()]
    public class JopController : Controller
    {
        private IJopService _JopService;

        public JopController(IJopService JopService)
        {
            _JopService = JopService;
        }


        [HttpGet("jopList")]
        public IResultData<List<Jop>>  JopList()
        {
          return  _JopService.getList();
        }

        [HttpPost("jopAdd")]
        public IResult JopAdd(Jop Jop)
        {

            return _JopService.Add(Jop);
        }

        [HttpDelete("jopDelete")]
        public IResult JopDelete(Jop Jop)
        {

            return _JopService.Delete(Jop);
        }
    }
}
