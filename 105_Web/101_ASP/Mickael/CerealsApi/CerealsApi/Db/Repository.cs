using CerealsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CerealsApi.Db
{
    public class Repository<T> where T : Model
    {
        private DbContext ctx;
        public Repository(DbContext context) 
        {
            ctx = context;            
        }

        public T Get()
        {
            return ctx.
        }
    }
}
