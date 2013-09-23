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
    /// Pallet Controller
    /// </summary>
    public class PalletController : ApiController
    {
        /// <summary>
        /// Get Pallet information
        /// </summary>
        /// <param name="palletId">Pallet Identifier</param>
        /// <returns>A Pallet Object</returns>
        [HttpGet]
        public Pallet GetPallet(int palletId)
        {
            Pallet pallet = PalletList.Get(palletId);
            return pallet;
        }
    }
}
