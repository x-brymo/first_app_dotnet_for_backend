

using BookService;
using first_app.Models;
using RepositoryBook;

namespace first_app.data.impl_repo
{
    public class ImplRepoBook : ISBookService
    {
        private readonly BookDbContext _db;
        public ImplRepoBook(BookDbContext db) => _db = db;
        public BookEntity GetById(int id)
        {
          BookEntity books = _db.Books.Find(id);
          return books;
           
        }

        public IQueryable<BookEntity> ListAll()=> _db.Books;
        
        public void Remove(int? Id)
        {
          BookEntity book =  _db.Books.Find(Id);
          _db.Books.Remove(book);
           _db.SaveChanges();
        }

        public void Save(BookEntity item)
        {
           if(item.Id == 0){
            _db.Books.Add(item);
            _db.SaveChanges();
           }else if(item.Id > 0){
            _db.Books.Update(item);
            _db.SaveChanges();      
           }
        }
    }

}