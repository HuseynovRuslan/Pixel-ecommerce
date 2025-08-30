using Microsoft.EntityFrameworkCore;

namespace Pixel.WebUI.Models.Persistences
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }
    }
}

