using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.DAO
{
    public class OrderDetailDAO
    {
        CaMauTravelDBContext db = null;
        public OrderDetailDAO()
        {
            db = new CaMauTravelDBContext();
        }
        public bool Insert(OderDetail detail)
        {
            try
            {
                db.OderDetails.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
