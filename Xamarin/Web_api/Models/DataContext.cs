using System.Data.Entity;

namespace Web_api.Models
{
    public class DataContext : DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }
    }
}