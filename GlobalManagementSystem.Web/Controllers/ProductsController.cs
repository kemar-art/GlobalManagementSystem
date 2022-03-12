#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GlobalManagementSystem.Web.Data;
using AutoMapper;
using GlobalManagementSystem.Web.Models;

namespace GlobalManagementSystem.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public ProductsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var products = mapper.Map<List<ProductVM>> (await _context.Products.Include(p => p.Model).ToListAsync());
            return View(products);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.Include(p => p.Model).FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            var productVM = mapper.Map<ProductVM>(product);
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Id", product.ModelId);
            return View(productVM);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Id");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                var porduct = mapper.Map<Product>(productVM);
                _context.Add(porduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Id", productVM.ModelId);
            return View(productVM);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var productVM = mapper.Map<ProductVM>(product); 
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Id", product.ModelId);
            return View(productVM);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductVM productVM)
        {
            if (id != productVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var product = mapper.Map<Product>(productVM);
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(productVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Id", productVM.ModelId);
            return View(productVM);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Model)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}