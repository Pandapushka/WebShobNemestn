﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using OnlineShopDB.Models;
using WebShobGleb.Servises;
using System.Threading.Tasks;

namespace WebShobGleb.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly UserManager<User> _userManager;

        public CartController(ICartService cartService, UserManager<User> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User); // Получаем Id текущего пользователя
            return View(_cartService.GetCart(userId));
        }

        public async Task<IActionResult> Add(int id)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.AddProductToCart(id, userId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.RemoveProductFromCart(id, userId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Clear()
        {
            var userId = _userManager.GetUserId(User);
            _cartService.ClearCart(userId);
            return RedirectToAction("Index");
        }
    }
}