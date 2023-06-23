using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class AccountDAO
    {
        CaMauTravelDBContext db = null;

        public AccountDAO()
        {
            db = new CaMauTravelDBContext();
        }

        public long Insert(Account entity)
        {       
            db.Accounts.Add(entity);
            db.SaveChanges();
            return entity.account_id;
        }

        public IEnumerable<Account> ListAllPaging(string searchString,int page, int pageSize)
        {
            IQueryable<Account> model = db.Accounts;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.username.Contains(searchString) || x.name.Contains(searchString));
            }
            return model.OrderByDescending(x => x.username).ToPagedList(page, pageSize);
        }

        public Account GetByID(string Username)
        {
            return db.Accounts.SingleOrDefault(x => x.username == Username);
        }

        public int AdminLogin(string userName, string passWord, int roll = 2)
        {
            var result = db.Accounts.SingleOrDefault(x => x.username == userName && x.roll == roll);

            if(result == null)
            {
                return 0;
            }
            else
            {
                if(result.status == false)
                {
                    return -1;
                }
                else
                {
                    if (result.password == passWord)
                        return 1;
                    else
                        return -2;
                }
            }
        }

        public bool CheckUsername(string username)
        {
            return db.Accounts.Count(x => x.username == username) > 0;
        }

        public bool CheckEmail(string email)
        {
            return db.Accounts.Count(x => x.email == email) > 0;
        }

        public int ClientLogin(string userName, string passWord, int roll = 1)
        {
            var result = db.Accounts.SingleOrDefault(x => x.username == userName && x.roll == roll);

            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.status == false)
                {
                    return -1;
                }
                else
                {
                    if (result.password == passWord)
                        return 1;
                    else
                        return -2;
                }
            }
        }
    }
}
