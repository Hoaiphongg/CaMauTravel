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
    public class TourisDAO
    {
        CaMauTravelDBContext db = null;

        public TourisDAO()
        {
            db = new CaMauTravelDBContext();
        }


        public bool ChangeStatus(long id)
        {
            var touris = db.Touris.Find(id);
            touris.Status = !touris.Status;
            db.SaveChanges();
            return touris.Status;
        }

        public IEnumerable<Touri> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<Touri> model = db.Touris;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString));
            }
            return model.OrderByDescending(x => x.Name).ToPagedList(page, pageSize);
        }

        public Touri GetByID(string Name)
        {
            return db.Touris.SingleOrDefault(x => x.Name == Name);
        }

        public List<TourisViewModels> ListByPlaceType(int placeId,ref int totalRecord, int pageIndex = 1, int pageSize = 2)
        {
            totalRecord = db.Touris.Where(x => x.PlaceTypeID == placeId).Count();
            var model = (from a in db.Touris
                         join b in db.PlaceTypes
                         on a.PlaceTypeID equals b.ID
                         where a.PlaceTypeID == placeId
                         select new
                         {
                             CateMetaTitle = b.MetaTitle,
                             CateName = b.Name,
                             CreatedDate = a.CreateDate,
                             ID = a.ID,
                             Images = a.Image,
                             Name = a.Name,
                             MetaTitle = a.MetaTitle,
                             Price = a.Price
                         }).AsEnumerable().Select(x => new TourisViewModels()
                         {
                             CateMetaTitle = x.MetaTitle,
                             CateName = x.Name,
                             CreatedDate = x.CreatedDate,
                             ID = x.ID,
                             Images = x.Images,
                             Name = x.Name,
                             MetaTitle = x.MetaTitle,
                             Price = x.Price
                         });
            model.OrderByDescending(x => x.CreatedDate).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return model.ToList();
        }
        public List<Touri> ListNewTouris(int top)
        {
            return db.Touris.OrderByDescending(x => x.CreateDate).Take(top).ToList();
        }
        public List<Touri> ListHot(int top)
        {
            return db.Touris.Where(x => x.TopHot != null && x.TopHot > DateTime.Now).OrderByDescending(x => x.CreateDate).Take(top).ToList();
        }
        public List<Touri> ListAll()
        {
            return db.Touris.Where(x => x.Status == true).ToList();
        }
        public Touri Detail(long id)
        {
            return db.Touris.Find(id);
        }

        public List<Touri> ReletedTouris()
        {
            return db.Touris.Where(x => x.Status == true && x.DisplayOrder == 1).OrderByDescending(x => x.CreateDate).ToList();
        }
    }
}
