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
    /// Robotic Arm Controller
    /// </summary>
    public class RobotController : ApiController
    {
        /// <summary>
        /// Start the the robotic arm
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        [HttpPost]
        public Boolean Start(int palletId, int[] array)
        {
            try
            {
                Pallet pallet = PalletList.Get(palletId);
                pallet.pattern = array;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Locked Call
        /// </summary>
        /// <returns>Return if the robotic arm is locked<</returns>
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
        public Boolean Ready()
        {
            return true;
        }
    }
}
