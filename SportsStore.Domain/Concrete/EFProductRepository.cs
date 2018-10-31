
using System.Collections.Generic;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Concrete;


namespace SportsStore.Domain.Concrete
{
   public class EFProductRepository : IProductRepository

    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

    }
}
