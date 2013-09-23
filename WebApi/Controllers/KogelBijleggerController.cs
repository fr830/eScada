using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebAPI.Controllers
{
    /// <summary>
    /// KogelBijlegger Controller
    /// </summary>
    public class KogelBijleggerController : ApiController
    {
        /// <summary>
        /// Check if locked
        /// </summary>
        /// <returns>Boolean</returns>
        [HttpGet]
        public Boolean Locked()
        {
            return true;
        }
        
        /// <summary>
        /// Check if Done
        /// </summary>
        /// <returns>Boolean</returns>
        [HttpGet]
        public Boolean Done()
        {
            return true;
        }
    }
}
