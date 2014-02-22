﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAM.Admin.Controllers.ViewModels;
using RAM.Core.Domain.User;
using RAM.Admin.Controllers.ActionArguments;
using RAM.Infrastructure.Authentication;
using RAM.Services.Interfaces;
using System.Web.Mvc;
using System.Web;
using System.IO;
using RAM.Core.Domain.Blog;
using System.Configuration;

namespace RAM.Admin.Controllers.Controllers
{
    public class BlogController : BaseUserAccountController
    {
        private readonly IBlogService _blogService;
        public BlogController(ILocalAuthenticationService authenticationService,
            IUserService userService,
            IBlogService blogService,
            IExternalAuthenticationService externalAuthenticationService,
            IFormsAuthentication formsAuthentication,
            IActionArguments actionArguments)
            : base(authenticationService, userService, externalAuthenticationService, formsAuthentication, actionArguments)
        {
            _blogService = blogService;
        }

        public ActionResult Index()
        {
            HomeView view = new HomeView();
            view.NavView.SelectedMenuItem = "nav-blog";
            view.Blogs = _blogService.GetAll().BlogList;
            return View(view);

        }
    }
}