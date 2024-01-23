 using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using first_app.Models;

namespace BookService
{
    public interface ISBookService
    {
        void Save(BookEntity item);
        void Remove(int? Id);
        IQueryable<BookEntity> ListAll();
        BookEntity GetById(int id);
    }
}