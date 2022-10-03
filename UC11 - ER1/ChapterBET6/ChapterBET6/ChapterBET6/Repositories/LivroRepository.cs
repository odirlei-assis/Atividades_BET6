using ChapterBET6.Contexts;
using ChapterBET6.Models;

namespace ChapterBET6.Repositories
{
    public class LivroRepository
    {
        private readonly SqlContext _context;

        public LivroRepository(SqlContext context)
        {
            _context = context;
        }


        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }


    }
}
