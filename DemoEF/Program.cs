using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            webOnlineEntities1 _db = new webOnlineEntities1();

            #region Selecting
            /*var query = _db.News_Category.OrderBy(o => o.CateName).ToList();
            foreach (var item in query)
            {
                Console.WriteLine(item.CateName + " " + item.cOrder);
            };*/
            #endregion


            #region Inserting
            /*News_Category _news = new News_Category();
            _news.CateName = "Phim anh";
            _news.cLink = "phim-anh";
            _news.cOrder = 10;
            _news.cActive = true;

            _db.News_Category.Add(_news);
            _db.SaveChanges();*/
            #endregion

            #region Updating
            /*var Res = _db.News_Category
                .Where(w => w.IDCategory == 3).SingleOrDefault();
            if (Res != null)
            {
                Res.CateName = "Tin Tuc su kien";
                Res.cLink = "Tintuc-sukien";
                Res.cActive = true;
            }
            _db.SaveChanges();*/
            #endregion

            #region Deleting
            /*var Res = _db.News_Category
                .SingleOrDefault(s => s.IDCategory == 5);
            if (Res != null)
            {
                _db.News_Category.Remove(Res);
            }
            _db.SaveChanges();*/
            #endregion

            #region Store Procedure
            var Res = _db.spgetList_News_Category();
            foreach(var item in Res)
            {
                Console.WriteLine(item.CateName);
            }

            #endregion

            Console.ReadLine();
        }
    }
}