using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuangNhaDat.Main.Domain.Interface;
using QuangNhaDat.Main.Domain.Model;
using QuangNhaDat.Main.Repository;

namespace QuangNhaDat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsCategoryControllerService : ControllerBase
    {
        IBaseRepository<ProductsCategory> repo = new ProductsCategoryRepository<ProductsCategory>();
        [HttpGet]
        public IEnumerable<ProductsCategory> GetsProductsCategory()
        {
            var result = repo.getAll();
            return result;
        }
    }
}
