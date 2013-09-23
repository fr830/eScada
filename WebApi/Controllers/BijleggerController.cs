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
    /// Bijlegger Controller
    /// </summary>
    public class BijleggerController : ApiController
    {
        public static int id=0;
        /// <summary>
        /// Start the Bijlegger 
        /// </summary>
        /// <returns>Unique Identifier of pallet</returns>
        [HttpGet]
        public int Start()
        {
            id++;
            PalletList.Add(new Pallet(id));
            return id;
        }
    }
}
