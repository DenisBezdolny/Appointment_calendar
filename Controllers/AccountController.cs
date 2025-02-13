﻿using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_calendar.Controllers
{
	[Authorize]
	public class AccountController : Controller
	{

		private readonly UserManager<User> userManager;
		private readonly SignInManager<User> signInManager;
		public AccountController(UserManager<User> userMgr, SignInManager<User> signinMgr)
		{
			userManager = userMgr;
			signInManager = signinMgr;
		}

		[AllowAnonymous]
		public IActionResult Login(string returnUrl)
		{
			ViewBag.returnUrl = returnUrl;
			return View(new LoginViewModel());
		}
		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
		{
			if (ModelState.IsValid)
			{
				User user = await userManager.FindByNameAsync(model.UserName);
				if (user != null)
				{
					await signInManager.SignOutAsync();
					Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
					if (result.Succeeded)
					{
						return Redirect(returnUrl ?? "/");
					}
				}
				ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
			}
			return View(model);
		}

		[Authorize]
		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
	}
}
