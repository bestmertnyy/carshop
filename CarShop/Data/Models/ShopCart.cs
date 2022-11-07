using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartid { get; set; }
        public List<ShopCartitem> listShopitems { get; set; }
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartid = session.GetString("Cartid") ?? Guid.NewGuid().ToString();
            session.SetString("Cartid",shopCartid);
            return new ShopCart(context) { ShopCartid = shopCartid };
        }
        public void AddToCart(Car car)
        {
            appDBContent.ShopCartitem.Add(new ShopCartitem { 
                ShopCartid = ShopCartid,
                car =  car,
                price=car.price
            });
            appDBContent.SaveChanges();

        }
        public List<ShopCartitem> getShopItems()
        {
            return appDBContent.ShopCartitem.Where(c => c.ShopCartid == ShopCartid).Include(s => s.car).ToList();
        }

    }
}
