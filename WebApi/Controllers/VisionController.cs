using HelloWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace HelloWebAPI.Controllers
{
    /// <summary>
    /// Vision Controller
    /// </summary>
    public class VisionController : ApiController
    {
        /// <summary>
        /// Locked Call
        /// </summary>
        /// <returns>Return if the pallet is locked<</returns>
        [HttpGet]
        public Boolean Locked()
        {
            return true;
        }

        /// <summary>
        /// Ready Call
        /// </summary>
        /// <returns>Return if the robotic arm is ready</returns>
        [HttpGet]
        public int[] Pattern()
        {
            //Should be a vision call
            return new int[20] { 0,1,1,1,1,
                                 1,1,1,1,1,
                                 0,1,1,1,1,
                                 1,1,1,1,1 };
        }

        //[HttpPost]
        //public Boolean Continue(int palletId, Boolean ok, int[] pattern)
        //{
        //    Pallet pallet = PalletList.Get(palletId);
        //    if (ok)
        //    {

        //        // go further 
        //    }
        //    else
        //    {
        //        pallet.changePattern = pattern;
        //        // go to bijlegger
        //    }
        //    return true;
        //}

        [HttpPost]
        public Boolean Continue(int palletId, Boolean ok)
        {
            Pallet pallet = PalletList.Get(palletId);
            if (ok)
            {
                //Go further 
            }
            else
            {
                pallet.changePattern = pallet.pattern;
                //Go to bijlegger
            }
            return true;
        }


    }
}
