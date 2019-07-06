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

        public bool IsExistCategory(string name)
        {
            bool isExist = _stockRepository.IsExistCategory(name);
            return isExist;
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
        public bool IsExistCompany(string name)
        {
            bool isExist = _stockRepository.IsExistCompany(name);
            return isExist;
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
        public bool IsExistItem(string name)
        {
            bool isExist = _stockRepository.IsExistItem(name);
            return isExist;
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

        public DataTable GetCompany(StockIn stockIn)
        {
            return _stockRepository.GetCompany(stockIn);
        }

        public DataTable GetCategory(StockIn stockIn)
        {
            return _stockRepository.GetCategory(stockIn);
        }

        public string GetReorderLevel(StockIn stockIn)
        {
            return _stockRepository.GetReorderLevel(stockIn);
        }

        public int GetAvailableQuantity(StockIn stockIn, StockOut stockOut)
        {
            return _stockRepository.GetAvailableQuantity(stockIn, stockOut);
        }

        public int InsertStockIn(StockIn stockIn)
        {
            return _stockRepository.InsertStockIn(stockIn);
        }

        public DataTable ShowStockIn()
        {
            return _stockRepository.ShowStockIn();
        }
        public DataTable LoadStockOutToDataGridView(Report report)
        {
            return _stockRepository.LoadStockOutToDataGridView(report);
        }

    }
}
