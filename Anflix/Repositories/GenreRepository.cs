using Anflix.Interfaces;
using AnFlix.Models;

namespace Anflix.Repositories;

public class GenreRepository : IGenreRepository
{
    string connectionString = "server=localhost;port=3306;database=Anflixdb;uid=root;pwd=''";
    public void Create(Genre model)
    {
        throw new NotImplementedException();
    }

    public void Delete(int? id)
    {
        throw new NotImplementedException();
    }

    public List<Genre> ReadAll()
    {
        throw new NotImplementedException();
    }

    public Genre ReadById(int? id)
    {
        throw new NotImplementedException();
    }

    public void Update(Genre model)
    {
        throw new NotImplementedException();
    }
}
