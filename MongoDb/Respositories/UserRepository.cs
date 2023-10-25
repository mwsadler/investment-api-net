using MongoDB.Bson;
using MongoDb.Models;

namespace MongoDb.Respositories;

public class UserRepository : IUserRepository
{
    private readonly MongoDbContext.MongoDbContext _mongoDbContext;
    public UserRepository(MongoDbContext.MongoDbContext mongoDbContext)
    {
        _mongoDbContext = mongoDbContext;
    }
    public User AddBook(User user)
    {
        _mongoDbContext.Books.Add(user);
        _mongoDbContext.SaveChanges();
        return user;
    }

    public void DeleteBook(User user)
    {
        _mongoDbContext.Books.Remove(user);
        _mongoDbContext.SaveChanges();
    }

    public IEnumerable<User> GetAllBooks()
    {
        var book = _mongoDbContext.Books.FirstOrDefault(x => x.email == "webersadler.mark@gmail.com");
        var test = new ObjectId("650cae042ea489e75f9a98b6");
        var book2 = _mongoDbContext.Books.Find(book._id);
        var testStringId = test.ToString();
        // test.
        var book3 = _mongoDbContext.Books.Find(test);
        book3.Cash.First().value = 99.9;
        _mongoDbContext.SaveChanges();
        var books = _mongoDbContext.Books.ToList();
        return books;
    }

    public User GetBookById(string bookId)
    {
        var book = _mongoDbContext.Books.Find("650cae042ea489e75f9a98b6");
        return book;
    }

    public void UpdateBook(User userToUpdate, User user)
    {
        userToUpdate.Cash.First().value = 99.9;
        // bookToUpdate.Author = book.Author;
        // bookToUpdate.Price = book.Price;
        // bookToUpdate.Category = book.Category;
        _mongoDbContext.SaveChanges();
    }
}