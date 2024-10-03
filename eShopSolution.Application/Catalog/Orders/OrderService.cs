using eShopSolution.Application.Common;
using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Sales;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Orders
{
    public class OrderService : IOrderService
    {
        private readonly EShopDbContext _context;

        public OrderService(EShopDbContext context)
        {
            _context = context;
        }

        public Task<CheckoutRequest> GetById(int orderId, string languageId)
        {
            throw new NotImplementedException();
        }
    }
}
