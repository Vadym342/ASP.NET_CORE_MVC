﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Data.Models
{
    public class CommentCategory
    {
       public int id { get; set; }

       public string categoryName { get; set; }

        public string description { get; set; }

        public List<Comment> comments { get; set; }







    }
}
