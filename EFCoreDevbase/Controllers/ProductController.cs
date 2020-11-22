using EFCoreDevbase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDevbase.Controllers
{
    public class ProductController : Controller
    {
        ProductContext db = new ProductContext();

        // Get Products
        // Sort Products according to table field
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["IdSortParm"] = sortOrder == "Id" ? "id_desc" : "Id";
            ViewData["NameSortParm"] = sortOrder == "Name" ? "name_desc" : "Name";
            ViewData["UnitPriceSortParm"] = sortOrder == "UnitPrice" ? "unitprice_desc" : "UnitPrice";
            ViewData["QuantitySortParm"] = sortOrder == "Quantity" ? "quantity_desc" : "Quantity";


            var products = from s in db.Products
                           select s;
            switch (sortOrder)
            {          
                case "Id":
                    products = products.OrderBy(s => s.productID);
                    break;
                case "id_desc":
                    products = products.OrderByDescending(s => s.productID);
                    break;
                case "Name":
                    products = products.OrderBy(s => s.productName);
                    break;
                case "name_desc":
                    products = products.OrderByDescending(s => s.productName);
                    break;
                case "UnitPrice":
                    products = products.OrderBy(s => s.productUnitPrice);
                    break;
                case "unitprice_desc":
                    products = products.OrderByDescending(s => s.productUnitPrice);
                    break;
                case "Quantity":
                    products = products.OrderBy(s => s.productStockQuantity);
                    break;
                case "quantity_desc":
                    products = products.OrderByDescending(s => s.productStockQuantity);
                    break;

                default:
                    products = db.Products;
                    break;
            }
            return View(await products.AsNoTracking().ToListAsync());
        }

        public IActionResult SearchProduct(string p)
        {
            if (!string.IsNullOrEmpty(p))  // if search textbox is not null 
            {
                var products = db.Products.Where(m => m.productName.Contains(p)).ToList();
       
                return View("Index", products);
            }
            else
            {
                var productList = db.Products.ToList();
                return View("Index", productList);
            } 
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View("AddProduct");
        }

        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    productName = model.productName,
                    productUnitPrice = model.productUnitPrice,
                    productStockQuantity = model.productStockQuantity
                
                };
                db.Products.Add(product);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model); // validation hata bilgilerini göstermek için
        }

        public IActionResult UpdateProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x=>x.productID==id);
            if (product == null)
                return NotFound();

            return View("UpdateProduct", product);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            var updateProduct = db.Products.FirstOrDefault(x=>x.productID==product.productID);
            updateProduct.productName = product.productName;
            updateProduct.productUnitPrice = product.productUnitPrice;
            updateProduct.productStockQuantity = product.productStockQuantity;

            db.Products.Update(updateProduct);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x=>x.productID==id);
            if (product == null)
                return NotFound();

            db.Products.Remove(product);
            db.SaveChanges();

            return RedirectToAction("Index");
         
        }
    }
}
