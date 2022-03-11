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
    public class RestocksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public RestocksController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Restocks
        public async Task<IActionResult> Index()
        {
            var restocks = mapper.Map<List<RestockVM>> (await _context.Restocks.Include(r => r.Product).Include(r => r.Supplier).ToListAsync());
            return View(restocks);
        }

        // GET: Restocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restock = await _context.Restocks
                .Include(r => r.Product)
                .Include(r => r.Supplier)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (restock == null)
            {
                return NotFound();
            }

            return View(restock);
        }

        // GET: Restocks/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id");
            return View();
        }

        // POST: Restocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,QTY,Cost,Orderdate,Arriveddate,Orderstatus,SupplierId,Id")] Restock restock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(restock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", restock.ProductId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id", restock.SupplierId);
            return View(restock);
        }

        // GET: Restocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restock = await _context.Restocks.FindAsync(id);
            if (restock == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", restock.ProductId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id", restock.SupplierId);
            return View(restock);
        }

        // POST: Restocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,QTY,Cost,Orderdate,Arriveddate,Orderstatus,SupplierId,Id")] Restock restock)
        {
            if (id != restock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestockExists(restock.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", restock.ProductId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id", restock.SupplierId);
            return View(restock);
        }

        // GET: Restocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restock = await _context.Restocks
                .Include(r => r.Product)
                .Include(r => r.Supplier)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (restock == null)
            {
                return NotFound();
            }

            return View(restock);
        }

        // POST: Restocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restock = await _context.Restocks.FindAsync(id);
            _context.Restocks.Remove(restock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestockExists(int id)
        {
            return _context.Restocks.Any(e => e.Id == id);
        }
    }
}
