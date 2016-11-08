using AutoMapper;
using MySample.Business;
using MySample.Services;
using MySample.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly IProductService productService;

        public HomeController(ICompanyService companyService, IProductService productService)
        {
            this.companyService = companyService;
            this.productService = productService;
        }

        // GET: Home
        public ActionResult Index(string company = null)
        {
            IEnumerable<CompanyViewModel> viewModelCompanies;
            IEnumerable<Company> companies;

            companies = companyService.GetCompanies(company).ToList();

            viewModelCompanies = Mapper.Map<IEnumerable<Company>, IEnumerable<CompanyViewModel>>(companies);
            return View(viewModelCompanies);
        }

        public ActionResult Filter(string company, string productName)
        {
            IEnumerable<ProductViewModel> viewModelProducts;
            IEnumerable<Product> products;

            products = productService.GetCompanyProducts(company, productName);

            viewModelProducts = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);

            return View(viewModelProducts);
        }

        [HttpPost]
        public ActionResult Create(ProductFormViewModel newProduct)
        {
            if (newProduct != null && newProduct.File != null)
            {
                var product = Mapper.Map<ProductFormViewModel, Product>(newProduct);
                productService.CreateProduct(product);

                string productPicture = System.IO.Path.GetFileName(newProduct.File.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/images/"), productPicture);
                newProduct.File.SaveAs(path);

                productService.SaveProduct();
            }

            var company = companyService.GetCompany(newProduct.ProductCompany);
            return RedirectToAction("Index", new { company = company.Name });
        }


    }
}