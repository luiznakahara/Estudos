using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace WebApiBookStore.Domain
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}