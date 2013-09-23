using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWebAPI.Models
{
    public class Pallet
    {
        public int id;
        public int[] pattern;
        public int[] changePattern;

        public Pallet()
        {
            
        }
        public Pallet(int _id)
        {
            id = _id;
        }
    }
}