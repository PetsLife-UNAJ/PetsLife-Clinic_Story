using Microsoft.EntityFrameworkCore;

namespace AccessData.Commands
{
    public class GenericRepository : IGenericRepository
    {
        private readonly ApplicationDbContext _context;


        public GenericRepository(ApplicationDbContext templateDbContext)
        {
            _context = templateDbContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

    }
}
