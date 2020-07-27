﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Artwork.Web.Models;
using Artwork.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Artwork.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductService ProductService { get; }
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService; 
        }

        //[HttpGet]
        //public IEnumerable<Product> Get()
        //{
        //    return ProductService.GetProducts();
        //}


        ////[HttpPatch]
        //[Route("Rate")]
        //[HttpGet]
        //public ActionResult Get([FromQuery]string ProductId,[FromQuery] int Rating)
        //{
        //    ProductService.AddRating(ProductId, Rating);
        //    return Ok();
        //}
       
    }
}
