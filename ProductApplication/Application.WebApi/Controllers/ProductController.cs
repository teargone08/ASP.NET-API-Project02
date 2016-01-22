using Application.Data;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService productService = new ProductService();
        public List<Product> Get()
        {
            return productService.GetProducts();
        }
        public IHttpActionResult Get(int id)
        {
            var product = productService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        public IHttpActionResult Post(Product product)
        {
          var isSave=  productService.SaveProduct(product);
          if (isSave==true)
          {
              return Ok();
          }
          return BadRequest();
        }
        public IHttpActionResult Put(Product product)
        {
            var isUpdated = productService.UpdateProduct(product.Id, product);
            if (isUpdated==true)
            {
                return Ok();
            }
            return BadRequest();
        }
        public IHttpActionResult Delete(int id)
        {
            var isDeleted = productService.DeleteProduct(id);
            if (isDeleted==true)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
