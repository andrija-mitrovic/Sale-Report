using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleReportApp.Core.Data;
using SaleReportApp.Core.Models;
using SaleReportApp.WebUI.Models;

namespace SaleReportApp.WebUI.Controllers
{
    public class RetailController : Controller
    {
        private readonly IRetailRepository _repo;

        public RetailController(IRetailRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            IEnumerable<RetailModel> productsRepo = await _repo.GetAllAsync(Convert.ToDateTime("1/1/2018"),
                Convert.ToDateTime("1/1/2020"), 1, 1, 1000);

            var products = productsRepo.Select(product => new RetailIndexViewModel()
            {
                sifra = product.sifra,
                naziv = product.naziv,
                mpcij = Math.Round(product.mpcij,2),
                ukoli = Math.Round(product.ukoli,2),
                unavr = Math.Round(product.unavr,2),
                unacj = Math.Round(product.unacj,2),
                uprcj = Math.Round(product.uprcj,2),
                uprvr = Math.Round(product.uprvr,2),
                urucn = Math.Round(product.urucn,2),
                ikoli = Math.Round(product.ikoli,2),
                inavr = Math.Round(product.inavr,2),
                iprcj = Math.Round(product.iprcj,2),
                iprvr = Math.Round(product.iprvr,2),
                irucn = Math.Round(product.irucn,2),
                okoli = Math.Round(product.okoli,2),
                oprvr = Math.Round(product.oprvr,2),
                nivvr = Math.Round(product.nivvr,2),
                skoli = Math.Round(product.skoli,2),
                sprvr = Math.Round(product.sprvr,2)
            }).ToList();

            int pageSize = 8;

            return View(ProductListPagination<RetailIndexViewModel>.Create(products,pageNumber??1,pageSize));
        }
    }
}