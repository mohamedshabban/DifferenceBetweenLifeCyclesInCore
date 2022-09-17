using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingTransientAndScopedAndSingleton.Services;

namespace UnderstandingTransientAndScopedAndSingleton.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {            
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        public HomeController(ITransientService transientService1,
            ITransientService transientService2,
            IScopedService scopedService1,
            IScopedService scopedService2,
            ISingletonService singletonService1,
            ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        [HttpGet]
        public Dictionary<string, string> Get()
        {
            var dict=new Dictionary<string, string>();

            dict.Add("transient1", _transientService1.GetOperationID().ToString());
            dict.Add("transient2", _transientService2.GetOperationID().ToString());
            dict.Add("scoped1", _scopedService1.GetOperationID().ToString());
            dict.Add("scoped2", _scopedService2.GetOperationID().ToString());
            dict.Add("singleton1", _singletonService1.GetOperationID().ToString());
            dict.Add("singleton2", _singletonService2.GetOperationID().ToString());

            return dict;
        }
    }
}
