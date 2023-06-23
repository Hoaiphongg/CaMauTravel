using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.DAO
{
    public class PlaceTypeDAO
    {
        CaMauTravelDBContext db = null;

        public PlaceTypeDAO()
        {
            db = new CaMauTravelDBContext();
        }

        public IEnumerable<PlaceType> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<PlaceType> model = db.PlaceTypes;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString) || x.Name.Contains(searchString));
            }
            return model.OrderByDescending(x => x.Name).ToPagedList(page, pageSize);
        }

        public List<PlaceType> listAll()
        {
            return db.PlaceTypes.Where(x => x.Status == true).ToList();
        }

        public PlaceType Detail(int id)
        {
            return db.PlaceTypes.Find(id);
        }
    }
}
