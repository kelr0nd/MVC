using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace book_storage.Models
{
    public class BookReview
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле \"Автор\" отзыва обязательно для заполнения")]
        [Display(Name = "Автор отзыва")]
        public String Name { get; set; }

        [Display(Name = "Название книги")]
        public String BookName { get; set; }

        [Required(ErrorMessage = "Поле \"Отзыв\" обязательно для заполнения")]
        [Display(Name = "Отзыв")]

        public String Review { get; set; }

        public int IdBook { get; set; }

        public int Likes { get; set; }

        public bool IsOffensive { get; set; }

        public string ReportReason { get; set; }
    }
}