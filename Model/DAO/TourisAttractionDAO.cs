using Model.EF;
using Model.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class TourisAttractionDAO
    {
        CaMauTravelDBContext db = null;

        public TourisAttractionDAO()
        {
            db = new CaMauTravelDBContext();
        }
        public bool ChangeStatus(long id)
        {
            var touris = db.TouristAttractions.Find(id);
            touris.Status = !touris.Status;
            db.SaveChanges();
            return touris.Status;
        }

        public List<TourisAttrDetail> getAll()
        {
            return db.TourisAttrDetails.ToList();
        }

        public List<TouristAttraction> getTouris()
        {
            return db.TouristAttractions.ToList();
        }
        public IEnumerable<TouristAttraction> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<TouristAttraction> model = db.TouristAttractions;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString));
            }
            return model.OrderByDescending(x => x.Name).ToPagedList(page, pageSize);
        }

        public TouristAttraction GetByID(string Name)
        {
            return db.TouristAttractions.SingleOrDefault(x => x.Name == Name);
        }

        public TouristAttraction Detail(long id)
        {
            return db.TouristAttractions.Find(id);
        }

        public List<TourisAttractionViewModels> ListByPlaceType(int attID, ref int totalRecord, int pageIndex = 1, int pageSize = 2)
        {
            totalRecord = db.TouristAttractions.Where(x => x.PlaceTypeID == attID).Count();
            var model = (from a in db.TouristAttractions
                         join b in db.PlaceTypes
                         on a.PlaceTypeID equals b.ID
                         where a.PlaceTypeID == attID
                         select new
                         {
                             CateMetaTitle = b.MetaTitle,
                             CateName = b.Name,
                             CreatedDate = a.CreateDate,
                             ID = a.ID,
                             Images = a.Images,
                             Name = a.Name,
                             MetaTitle = a.MetaTitle,
                         }).AsEnumerable().Select(x => new TourisAttractionViewModels()
                         {
                             CateMetaTitle = x.MetaTitle,
                             CateName = x.Name,
                             CreatedDate = x.CreatedDate,
                             ID = x.ID,
                             Images = x.Images,
                             Name = x.Name,
                             MetaTitle = x.MetaTitle,
                         });
            model.OrderByDescending(x => x.CreatedDate).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return model.ToList();
        }

    }
}
