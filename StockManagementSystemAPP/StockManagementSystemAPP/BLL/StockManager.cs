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

        public DataTable LoadCompany()
        {
            return _stockRepository.LoadCompany();
        }

        public DataTable LoadCategory()
        {
            return _stockRepository.LoadCategory();
        }

        public int InsertItem(Item item)
        {
            return _stockRepository.InsertItem(item);
        }

        public int UpdateItem(Item item)
        {
            return _stockRepository.UpdateItem(item);
        }

        public DataTable ShowItem()
        {
            return _stockRepository.ShowItem();
        }

        public DataTable LoadItem()
        {
            return _stockRepository.LoadItem();
        }
    }
}
