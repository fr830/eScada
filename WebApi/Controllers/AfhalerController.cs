using HelloWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebAPI.Controllers
{
    /// <summary>
    /// Afhaler Controller
    /// </summary>
    public class AfhalerController : ApiController
    {
        /// <summary>
        /// Check if Afhaler is locked.
        /// </summary>
        /// <returns>Boolean</returns>
        [HttpGet]
        public Boolean Locked()
        {
            return true;
        }

        /// <summary>
        /// Check if afhaler is ready
        /// </summary>
        /// <returns>Boolean</returns>
        [HttpGet]
        public Boolean Done()
        {
            return true;
        }
    }
}
