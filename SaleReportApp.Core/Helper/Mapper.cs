using SaleReportApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SaleReportApp.Core.Helper
{
    public static class Mapper
    {
        public static RetailModel MapToRetailModel(SqlDataReader reader)
            => new RetailModel()
            {
                sifra = (int)reader["sifra"],
                naziv = (string)reader["naziv"],
                mpcij = (decimal)reader["mpcij"],
                ukoli = (decimal)reader["ukoli"],
                unavr = (decimal)reader["unavr"],
                unacj = (decimal)reader["unacj"],
                uprcj = (decimal)reader["uprcj"],
                uprvr = (decimal)reader["uprvr"],
                urucn = (decimal)reader["urucn"],
                ikoli = (decimal)reader["ikoli"],
                inavr = (decimal)reader["inavr"],
                iprcj = (decimal)reader["iprcj"],
                iprvr = (decimal)reader["iprvr"],
                irucn = (decimal)reader["irucn"],
                okoli = (decimal)reader["okoli"],
                oprvr = (decimal)reader["oprvr"],
                nivvr = (decimal)reader["nivvr"],
                skoli = (decimal)reader["skoli"],
                sprvr = (decimal)reader["sprvr"]
            };

        public static WholesaleModel MapToWholesaleModel(SqlDataReader reader)
            => new WholesaleModel()
            {
                sifra = (int)reader["sifra"],
                naziv = (string)reader["naziv"],
                vpcij = (decimal)reader["vpcij"],
                ukoli = (decimal)reader["ukoli"],
                unavr = (decimal)reader["unavr"],
                unacj = (decimal)reader["unacj"],
                uprcj = (decimal)reader["uprcj"],
                uprvr = (decimal)reader["uprvr"],
                urucn = (decimal)reader["urucn"],
                ikoli = (decimal)reader["ikoli"],
                inavr = (decimal)reader["inavr"],
                iprcj = (decimal)reader["iprcj"],
                iprvr = (decimal)reader["iprvr"],
                irucn = (decimal)reader["irucn"],
                okoli = (decimal)reader["okoli"],
                oprvr = (decimal)reader["oprvr"],
                nivvr = (decimal)reader["nivvr"],
                skoli = (decimal)reader["skoli"],
                sprvr = (decimal)reader["sprvr"]
            };
    }
}
