﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_storage.Models
{
    public interface IReviewContext
    {
        int IncrementAndGetLikes(int reviewId);

        List<Review> GetAll();
        void Report(int reviewId, string reason);
    }
}
