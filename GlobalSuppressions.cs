﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Migrations.InitialMigration.Up(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)")]
[assembly: SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "<Pending>")]
[assembly: SuppressMessage("Style", "IDE0005:Using directive is unnecessary.", Justification = "<Pending>")]
[assembly: SuppressMessage("Style", "IDE0008:Use explicit type", Justification = "<Pending>")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Data.AuthDBContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions)")]
[assembly: SuppressMessage("Style", "IDE0090:Use 'new(...)'", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Data.AuthDBContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)")]
[assembly: SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Data.AuthDBContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AccountController.#ctor(Microsoft.AspNetCore.Identity.UserManager{Microsoft.AspNetCore.Identity.IdentityUser})")]
[assembly: SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AccountController.Register(Bloggie.Web.Models.ViewModels.RegisterViewModel)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Data.BloggieDbContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{Bloggie.Web.Data.BloggieDbContext})")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Data.AuthDBContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{Bloggie.Web.Data.AuthDBContext})")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.HomeController.#ctor(Microsoft.Extensions.Logging.ILogger{Bloggie.Web.Controllers.HomeController},Bloggie.Web.Repositries.IBlogPostRepository,Bloggie.Web.Repositries.ITagRepository)")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Repositries.BlogPostRepository.#ctor(Bloggie.Web.Data.BloggieDbContext)")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AccountController.#ctor(Microsoft.AspNetCore.Identity.UserManager{Microsoft.AspNetCore.Identity.IdentityUser},Microsoft.AspNetCore.Identity.SignInManager{Microsoft.AspNetCore.Identity.IdentityUser})")]
[assembly: SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AccountController.Login(Bloggie.Web.Models.ViewModels.LoginViewModel)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminTagsController.#ctor(Bloggie.Web.Repositries.ITagRepository)")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminBlogPostsController.#ctor(Bloggie.Web.Repositries.ITagRepository,Bloggie.Web.Repositries.IBlogPostRepository)")]
[assembly: SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AccountController.Login(Bloggie.Web.Models.ViewModels.LoginViewModel)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Repositries.BlogPostLikeRepositorycs.#ctor(Bloggie.Web.Data.BloggieDbContext)")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.BlogsController.#ctor(Bloggie.Web.Repositries.IBlogPostRepository,Bloggie.Web.Repositries.IBlogPostLikeRepository)")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.BlogsController.#ctor(Bloggie.Web.Repositries.IBlogPostRepository,Bloggie.Web.Repositries.IBlogPostLikeRepository)")]
[assembly: SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.BlogsController.Index(System.String)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.HomeController.#ctor(Microsoft.Extensions.Logging.ILogger{Bloggie.Web.Controllers.HomeController},Bloggie.Web.Repositries.IBlogPostRepository,Bloggie.Web.Repositries.ITagRepository,Bloggie.Web.Repositries.IBlogPostLikeRepository)")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.BlogPostLikeController.#ctor(Bloggie.Web.Repositries.IBlogPostLikeRepository)")]
[assembly: SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.BlogPostLikeController.AddLike(Bloggie.Web.Models.ViewModels.AddLikeRequest)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.BlogsController.#ctor(Bloggie.Web.Repositries.IBlogPostRepository,Bloggie.Web.Repositries.IBlogPostLikeRepository,Microsoft.AspNetCore.Identity.SignInManager{Microsoft.AspNetCore.Identity.IdentityUser},Microsoft.AspNetCore.Identity.UserManager{Microsoft.AspNetCore.Identity.IdentityUser})")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Repositries.BlogPostCommentRepository.#ctor(Bloggie.Web.Data.BloggieDbContext)")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.BlogsController.#ctor(Bloggie.Web.Repositries.IBlogPostRepository,Bloggie.Web.Repositries.IBlogPostLikeRepository,Microsoft.AspNetCore.Identity.SignInManager{Microsoft.AspNetCore.Identity.IdentityUser},Microsoft.AspNetCore.Identity.UserManager{Microsoft.AspNetCore.Identity.IdentityUser},Bloggie.Web.Repositries.IBlogPostCommentRepository)")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Repositries.UserRepository.#ctor(Bloggie.Web.Data.AuthDBContext)")]
[assembly: SuppressMessage("Style", "IDE0017:Simplify object initialization", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminUsersController.List~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminUsersController.#ctor(Bloggie.Web.Repositries.IUserRepository)")]
[assembly: SuppressMessage("Style", "IDE0001:Simplify Names", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminUsersController.List~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0028:Simplify collection initialization", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminUsersController.List~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0017:Simplify object initialization", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminUsersController.List~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0028:Simplify collection initialization", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminUsersController.List~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0001:Simplify Names", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminUsersController.List~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminUsersController.#ctor(Bloggie.Web.Repositries.IUserRepository,Microsoft.AspNetCore.Identity.UserManager{Microsoft.AspNetCore.Identity.IdentityUser})")]
[assembly: SuppressMessage("Style", "IDE0100:Remove redundant equality", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Controllers.AdminTagsController.Add(Bloggie.Web.Models.ViewModels.AddTagRequest)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "<Pending>", Scope = "member", Target = "~M:Bloggie.Web.Repositries.TagRepository.#ctor(Bloggie.Web.Data.BloggieDbContext)")]
