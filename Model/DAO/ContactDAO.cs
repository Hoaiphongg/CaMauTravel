using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ContactDAO
    {
        CaMauTravelDBContext db = null;

        public ContactDAO()
        {
            db = new CaMauTravelDBContext();
        }

        public long InsertFeedBack(Feedback feedback)
        {
            db.Feedbacks.Add(feedback);
            db.SaveChanges();

            return feedback.ID; 
        }
    }
}
