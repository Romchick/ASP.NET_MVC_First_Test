using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>

    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book{Name = "The Dark Tower: The Gunslinger", Author = "Stephen King", Id = 1, Price = 80});
            db.Books.Add(new Book { Name = "The Dark Tower II: The Drawing of the Three", Author = "Stephen King", Id = 2, Price = 90 });
            db.Books.Add(new Book { Name = "The Dark Tower III: The Waste Lands", Author = "Stephen King", Id = 2, Price = 90 });
            db.Books.Add(new Book { Name = "The Dark Tower IV: Wizard and Glass", Author = "Stephen King", Id = 2, Price = 90 });
            db.Books.Add(new Book { Name = "The Dark Tower: The Wind Through the Keyhole", Author = "Stephen King", Id = 2, Price = 90 });
            db.Books.Add(new Book { Name = "The Dark Tower V: Wolves of the Calla", Author = "Stephen King", Id = 2, Price = 90 });
            db.Books.Add(new Book { Name = "The Dark Tower VI: Song of Susannah", Author = "Stephen King", Id = 2, Price = 90 });
            db.Books.Add(new Book { Name = "The Dark Tower VII: The Dark Tower", Author = "Stephen King", Id = 2, Price = 90 });
            base.Seed(db);
        }
    }
}