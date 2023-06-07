﻿using GroupProjectApi.Modules.Products.Models;
using GroupProjectApi.Modules.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProjectApi.Modules.Products
{
    [TransientService]
    public class ProductsService
    {
        //Parsing JSON file 
        public class ReadAndParseJSONWithNewtonSoftJson
        {
            private readonly string _Hotsauce;
            public ReadAndParseJSONWithNewtonSoftJson(string jsonfilepath)
            {
                _Hotsauce = jsonfilepath;
            }
        }

        //Return a list of products from the hot sauce file
        public List<ProductDto> UseUserDefindObjectWithNewtonsoftJson()
        {
            using StreamReader reader = new(_Hotsauce);
            var json = reader.ReadToEnd();
            List<ProductDto> products = JsonConvert.DeserializeObject<List<ProductDto>>(json);
            return products;
        }
        
        // var listofprod = UseUserDefindObjectWithNewtonsoftJson(ReadAndParseJSONWithNewtonSoftJson( _Hotsauce));
//listofprod is helpful for search, use it in a search function 

        // private readonly ProductsRepository _productRepo;


        // public ProductsService(ProductsRepository productRepo)
        // {
        //     _productRepo = productRepo;
        // }
        // public ProductDto GetProduct(int productId)
        // {
        //     return _productRepo.GetProductById(productId)?.ToProductDto();
        // }
        // public ProductDto GetAllProducts(int productId)
        // {
        //     return _productRepo.GetProductById(productId)?.ToProductDto();
        // }
    }
}