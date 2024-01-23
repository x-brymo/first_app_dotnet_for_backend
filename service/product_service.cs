 using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using first_app.Models;

namespace ProductService
{
    public interface ISProductService
    {
        void Save(ProductEntity entity);
        void Remove(ProductEntity entity);
        IQueryable <ProductEntity> ListAll();
        ProductEntity GetById(int id);
    }
}