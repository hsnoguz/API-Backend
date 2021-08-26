using Bussines.Abstract;
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
        private IListService<Jop> _JopService;

        public JopController(IListService<Jop> JopService)
        {
            _JopService = JopService;
        }


        [Route("jop/[jopList]")]
        public IResultData<List<Jop>>  JopList()
        {
          return  _JopService.getList();
        }

        [Route("jop/[jopAdd]")]
        public IResult JopAdd(Jop Jop)
        {

            return _JopService.Add(Jop);
        }

        [Route("jop/[jopDelete]")]
        public IResult JopDelete(Jop Jop)
        {

            return _JopService.Delete(Jop);
        }
    }
}
