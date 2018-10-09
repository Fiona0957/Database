using System;
using System.Linq;
using Model;

namespace ProjectDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BagContext())
            {
                User u = new User {Id = 50};
                Item i = new Item {Id = 40};
                db.Users.Add(u);
                db.Items.Add(i);
                db.SaveChanges();
            }
        }
    }
}
