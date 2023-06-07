// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using GroupProjectApi.Modules.Common.Attributes;
// using GroupProjectApi.Modules.Products.Models;
// using GroupProjectApi.Modules.Common.Entities;
// using Microsoft.EntityFrameworkCore;

// namespace GroupProjectApi.Modules.Products
// {
//     [TransientService]
//     public class ProductsRepository
//     {
//         private readonly ILogger<ProductsRepository> _logger;
//         private readonly GroupProjectDbContext _context;
//         public ProductsRepository(ILogger<ProductsRepository> logger, GroupProjectDbContext context)
//         {
//             _logger = logger;
//             _context = context;
//         }

//         public Product GetProductById(int productId)
//         {
//             return _context.Product
//                 .Include(cart => cart.CartProducts)
//                 .ThenInclude(cartProduct => cartProduct.Product)
//                 .FirstOrDefault(cart => cart.CartId == cartId);
//         }
//         public Product GetAllProducts(int cartId)
//         {
//             return _context.Carts
//                 .Include(cart => cart.CartProducts)
//                 .ThenInclude(cartProduct => cartProduct.Product)
//                 .FirstOrDefault(cart => cart.CartId == cartId);
//         }

//     }
// }