﻿using Microsoft.AspNetCore.Mvc;
using OnlineShopDB.Repository;
using WebShobGleb.Const;
using WebShobGleb.Mappers;
using WebShobGleb.Repository;

namespace WebShobGleb.Views.Shared.Components.Cart
{
    public class CartViewComponent : ViewComponent
    {
        ICartRepository cartsRepository;

        public CartViewComponent(ICartRepository cartsRepository)
        {
            this.cartsRepository = cartsRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cart = CartMapper.MappingToCartVM(cartsRepository.TryGetByUserId(Constants.UserId));
            var productCounts = cart?.Amount;
            return View("Cart", productCounts);
        }
    }
}
