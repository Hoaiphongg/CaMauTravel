using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class NewsDAO
    {
        CaMauTravelDBContext db = null;

        public NewsDAO()
        {
            db = new CaMauTravelDBContext();
        }

        public List<News> ListAll()
        {
            return db.News.Where(x => x.Status == true).ToList();
        }
        public News Detail(long id)
        {
            return db.News.Find(id);
        }

    }
}
