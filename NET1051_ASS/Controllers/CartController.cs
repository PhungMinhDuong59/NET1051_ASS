﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NET1051_ASS.Models;
using NET1051_ASS.Services;

namespace NET1051_ASS.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IFoodService _foodService;

        public CartController(ICartService cartService, IFoodService foodService)
        {
            _cartService = cartService;
            _foodService = foodService;
        }

        public IActionResult Index()
        {
            var userRole = HttpContext.Session.GetString("UserRole");

            if (userRole != "customer")
            {
                TempData["ErrorMessage"] = "Please login with customer account to access this page.";
                return RedirectToAction("Login", "Account");
            }

            try
            {
                var userId = int.Parse(HttpContext.Session.GetString("UserID"));
                var userCart = _cartService.GetByUserID(userId);

                if (userCart == null || userCart.CartItems.Count == 0)
                {
                    ViewBag.Message = "Your cart is empty.";
                }

                return View(userCart);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Error", "Shared");
            }
        }

        [HttpPost]
        public IActionResult AddToCart(int foodItemId, int quantity)
        {
            var userRole = HttpContext.Session.GetString("UserRole");

            if (userRole != "customer")
            {
                TempData["ErrorMessage"] = "Please login with customer account to access this page.";
                return RedirectToAction("Login", "Account");
            }

            try
            {
                var userId = int.Parse(HttpContext.Session.GetString("UserID"));
                _cartService.AddToCart(userId, foodItemId, quantity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Error", "Shared");
            }
        }

        [HttpPost]
        public IActionResult AddComboToCart(int comboId, int quantity)
        {
            var userRole = HttpContext.Session.GetString("UserRole");

            if (userRole != "customer")
            {
                TempData["ErrorMessage"] = "Please login with customer account to access this page.";
                return RedirectToAction("Login", "Account");
            }

            try
            {
                var userId = int.Parse(HttpContext.Session.GetString("UserID"));
                _cartService.AddComboToCart(userId, comboId, quantity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Error", "Shared");
            }
        }

        [HttpPost]
        public IActionResult Remove(int CartItemID)
        {
            var userRole = HttpContext.Session.GetString("UserRole");

            if (userRole != "customer")
            {
                TempData["ErrorMessage"] = "Please login with customer account to access this page.";
                return RedirectToAction("Login", "Account");
            }

            try
            {
                _cartService.RemoveCartItem(CartItemID);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Error", "Shared");
            }
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int CartItemID, int Quantity)
        {
            var userRole = HttpContext.Session.GetString("UserRole");

            if (userRole != "customer")
            {
                TempData["ErrorMessage"] = "Please login with customer account to access this page.";
                return RedirectToAction("Login", "Account");
            }

            try
            {
                _cartService.UpdateCartItemQuantity(CartItemID, Quantity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Error", "Shared");
            }
        }
    }
}
