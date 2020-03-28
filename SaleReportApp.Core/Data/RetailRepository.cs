using Microsoft.Extensions.Configuration;
using SaleReportApp.Core.Helper;
using SaleReportApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SaleReportApp.Core.Data
{
    public class RetailRepository : IRetailRepository
    {
        private readonly string _connectionStrings;
        public RetailRepository(IConfiguration configuration)
        {
            _connectionStrings = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<RetailModel>> GetAllAsync(DateTime odDatuma, DateTime doDatuma, int sifOb, int odSif, int doSif)
        {
            using (SqlConnection sql = new SqlConnection(_connectionStrings))
            {
                using (SqlCommand cmd = new SqlCommand("spSintetickeKarticeMP", sql))
                {
                    try
                    {
                        await sql.OpenAsync();

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OdDatuma", odDatuma);
                        cmd.Parameters.AddWithValue("@DoDatuma", doDatuma);
                        cmd.Parameters.AddWithValue("@SifOb", sifOb);
                        cmd.Parameters.AddWithValue("@OdSif", odSif);
                        cmd.Parameters.AddWithValue("@DoSif", doSif);
                        var response = new List<RetailModel>();

                        SqlDataReader reader = await cmd.ExecuteReaderAsync();

                        while (await reader.ReadAsync())
                        {
                            response.Add(Mapper.MapToRetailModel(reader));
                        }

                        return response;
                    }
                    catch(Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
    }
}
