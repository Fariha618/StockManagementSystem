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

        public DataTable GetCompany(StockIn stockIn)
        {
            return _stockRepository.GetCompany(stockIn);
        }

        public DataTable GetCategory(StockIn stockIn)
        {
            return _stockRepository.GetCategory(stockIn);
        }

        public int GetReorderLevel(StockIn stockIn)
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

        public int InsertAvailableQuantity(StockIn stockIn)
        {
            return _stockRepository.InsertAvailableQuantity(stockIn);
        }

        public DataTable ShowStockIn()
        {
            return _stockRepository.ShowStockIn();
        }

        public int UpdateStockIn(StockIn stockIn)
        {
            return _stockRepository.UpdateStockIn(stockIn);
        }

        public int InsertSell(StockOut stockOut)
        {
            return _stockRepository.InsertSell(stockOut);
        }

        public int InsertLost(StockOut stockOut)
        {
            return _stockRepository.InsertLost(stockOut);
        }

        public int InsertDamage(StockOut stockOut)
        {
            return _stockRepository.InsertDamage(stockOut);
        }

        public DataTable GetCategoryforSearch(ItemSummary itemSummary)
        {
            return _stockRepository.GetCategoryforSearch(itemSummary);
        }

        public DataTable GetCompanyforSearch(ItemSummary itemSummary)
        {
            return _stockRepository.GetCompanyforSearch(itemSummary);
        }

        public DataTable SearchItem(ItemSummary itemSummary)
        {
            return _stockRepository.SearchItem(itemSummary);
        }

        
    }
}
