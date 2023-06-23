using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaMauTravel.Models
{
    [Serializable]
    public class CartItem
    {
        public Touri Touri { get; set; }
        public int Quanlity { get; set; }
    }
}