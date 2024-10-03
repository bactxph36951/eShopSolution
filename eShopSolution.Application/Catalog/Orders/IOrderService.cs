using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Orders
{
    public interface IOrderService
    {
        Task<CheckoutRequest> GetById(int orderId, string languageId);
    }
}
