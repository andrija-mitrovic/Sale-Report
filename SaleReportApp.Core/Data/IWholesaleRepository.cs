using SaleReportApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SaleReportApp.Core.Data
{
    public interface IWholesaleRepository
    {
        Task<IEnumerable<WholesaleModel>> GetAllAsync(DateTime odDatuma, DateTime doDatuma, int sifOb, int odSif, int doSif);
    }
}
