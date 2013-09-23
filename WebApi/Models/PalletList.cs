using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWebAPI.Models
{
    public static class PalletList
    {
        public static List<Pallet> palletList;
        public static int i = 0;

        public static void Add(Pallet pallet)
        {
            if (i == 0)
            {
                palletList = new List<Pallet>();
                i++;
            }
            
            palletList.Add(pallet);
        }

        public static Pallet Get(int id)
        {
            return palletList.Where(pallet => pallet.id == id).First();
        }

    }
}