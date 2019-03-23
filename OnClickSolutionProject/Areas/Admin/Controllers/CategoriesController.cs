﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnClickSolution.Data;
using OnClickSolution.Models;
using OnClickSolution.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnClickSolution.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]

    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Categories.ToList());
        }

        //GET create action method
        public IActionResult Create()
        {
            return View();
        }
        //POST Create action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categories Categories)
        {
            if(ModelState.IsValid)
            {
                _db.Add(Categories);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Categories);
        }
        //GET Edit action method
        public async Task <IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var productType = await _db.Categories.FindAsync(id);
            if(productType==null)
            {
                return NotFound();
            }
            return View(productType);

        }


        //POST Cedit action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Categories Categories)
        {
            if(id!=Categories.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(Categories);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Categories);
        }


        //GET Details action method
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = await _db.Categories.FindAsync(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);

        }

        //GET Delete action method
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = await _db.Categories.FindAsync(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);

        }


        //POST Delete action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var Categories = await _db.Categories.FindAsync(id);
            _db.Categories.Remove(Categories);

           
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }
    }
}