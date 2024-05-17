﻿using BanDoWeb.Access.Dbcontext;
using BanDoWeb.Access.Repository.IRepository;
using BanDoWeb.Model.Models;
using Project.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDoWeb.Access.Repository
{
    public class ReviewsRepon : Repository<Reviews>,IReviews
    {
        private DbcontextBanDo _dbcon;

        public ReviewsRepon(DbcontextBanDo dbcontext):base(dbcontext)
        {
            _dbcon = dbcontext;

        }
        public void UpdateReviews(Reviews reviews)
        {
            _dbcon.Update(reviews);
            _dbcon.SaveChanges();
        }
    }
}