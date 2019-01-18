using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KhMedium.Entities;

namespace KhMedium.Data
{
    public static class Extension
    {
        //Articles
        public static Boolean IsDeleted(this Article article)
        {
            return article.DeletedAt == null;
        }
    }
}