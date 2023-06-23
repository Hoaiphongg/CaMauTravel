using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.DAO
{
    public class OrderDAO
    {
        CaMauTravelDBContext db = null;
        public OrderDAO()
        {
            db = new CaMauTravelDBContext();
        }
        public long Insert(Oder order)
        {
            
            order.Status = false;
            db.Oders.Add(order);
            db.SaveChanges();
            return order.ID;
        }


        public IEnumerable<Oder> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<Oder> model = db.Oders;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.ShipName.Contains(searchString));
            }
            return model.OrderByDescending(x => x.ShipName).ToPagedList(page, pageSize);
        }

        public bool ChangeStatus(long id)
        {
            var order = db.Oders.Find(id);
            order.Status = !order.Status;
            db.SaveChanges();
            return order.Status;
        }
    }
}
