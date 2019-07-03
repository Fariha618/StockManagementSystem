using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemAPP.Models;
using StockManagementSystemAPP.Repository;

namespace StockManagementSystemAPP.BLL
{
    class StockManager
    {
        StockRepository _stockRepository = new StockRepository();

        public int InsertCategory(Category category)
        {
            return _stockRepository.InsertCategory(category);
        }

        public int UpdateCategory(Category category)
        {
            return _stockRepository.UpdateCategory(category);
        }

        public DataTable ShowCategory()
        {
            return _stockRepository.ShowCategory();
        }

        public int InsertCompany(Company company)
        {
            return _stockRepository.InsertCompany(company);
        }

        public int UpdateCompany(Company company)
        {
            return _stockRepository.UpdateCompany(company);
        }

        public DataTable ShowCompany()
        {
            return _stockRepository.ShowCompany();
        }

    }
}
