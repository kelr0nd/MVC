using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace book_storage.Models
{
    public class Book: IComparable<Book>
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле \"Автор\" обязательно для заполнения")]
        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Поле \"Название Книги\" обязательно для заполнения")]
        [Display(Name = "Название Книги")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле \"Жанр\" обязательно для заполнения")]
        [Display(Name = "Жанр")]
        public string Genre { get; set; }

        public int CompareTo(Book book)
        {
            return string.Compare(this.Name, book.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}