﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab8_WebAPI.Models
{
    public class Lab8_WebAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Lab8_WebAPIContext() : base("name=Lab8_WebAPIContext")
        {
            //writing generated SQL queries to the debug output window so i can actually see it
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public System.Data.Entity.DbSet<Lab8_WebAPI.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<Lab8_WebAPI.Models.Book> Books { get; set; }
    }
}
