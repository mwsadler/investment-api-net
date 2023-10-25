using MongoDb.Models;

namespace MongoDb.Respositories;

public interface IUserRepository
{
    IEnumerable<User> GetAllBooks();
    User GetBookById(string bookId);
    User AddBook(User user);
    void UpdateBook(User userToUpdate, User user);
    void DeleteBook(User user);
}