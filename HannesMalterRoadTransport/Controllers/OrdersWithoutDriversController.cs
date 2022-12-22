using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HannesMalterRoadTransport.Data;
using HannesMalterRoadTransport.Models;

namespace HannesMalterRoadTransport.Controllers
{
    public class OrdersWithoutDriversController : Controller
    {
        private readonly ApplicationDbContext _context;

        public async Task<IActionResult> OrdersWithoutDriversIndex()
        {
            return View(await _context.OrdersWithoutDriver.ToListAsync());
        }

        public async Task<IActionResult> OrdersWithoutDriversEdit(int? id)
        {
            if (id == null || _context.OrdersWithoutDriver == null)
            {
                return NotFound();
            }

            var ordersWithoutDriver = await _context.OrdersWithoutDriver.FindAsync(id);
            if (ordersWithoutDriver == null)
            {
                return NotFound();
            }
            return View(ordersWithoutDriver);
        }

        // POST: OrdersWithoutDrivers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrdersWithoutDriversEdit(int id, [Bind("Id,Name,StartingLocation,EndLocation,Quantity,ETA,CarNR,Driver")] OrdersWithoutDriver ordersWithoutDriver)
        {
            if (id != ordersWithoutDriver.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordersWithoutDriver);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersWithoutDriverExists(ordersWithoutDriver.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(OrdersWithoutDriversIndex));
            }
            return View(ordersWithoutDriver);
        }

        public IActionResult OrdersWithoutDriverCreate()
        {
            return View();
        }

        // POST: OrdersWithoutDrivers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrdersWithoutDriverCreate([Bind("Id,Name,StartingLocation,EndLocation,Quantity,ETA,CarNR,Driver")] OrdersWithoutDriver ordersWithoutDriver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordersWithoutDriver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(OrdersWithoutDriversIndex));
            }
            return View(ordersWithoutDriver);
        }

        public async Task<IActionResult> OrdersWithoutDriverDetails(int? id)
        {
            if (id == null || _context.OrdersWithoutDriver == null)
            {
                return NotFound();
            }

            var ordersWithoutDriver = await _context.OrdersWithoutDriver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordersWithoutDriver == null)
            {
                return NotFound();
            }

            return View(ordersWithoutDriver);
        }

        public async Task<IActionResult> OrdersWithoutDriverDelete(int? id)
        {
            if (id == null || _context.OrdersWithoutDriver == null)
            {
                return NotFound();
            }

            var ordersWithoutDriver = await _context.OrdersWithoutDriver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordersWithoutDriver == null)
            {
                return NotFound();
            }

            return View(ordersWithoutDriver);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrderDeleteConfirmed(int id)
        {
            if (_context.OrdersWithoutDriver == null)
            {
                return Problem("Entity set 'ApplicationDbContext.OrdersWithoutDriver'  is null.");
            }
            var ordersWithoutDriver = await _context.OrdersWithoutDriver.FindAsync(id);
            if (ordersWithoutDriver != null)
            {
                _context.OrdersWithoutDriver.Remove(ordersWithoutDriver);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(OrdersWithoutDriversIndex));
        }







        //   ------------------------------------------------------------------------------------------------------------------------------------------------
        public OrdersWithoutDriversController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrdersWithoutDrivers
        public async Task<IActionResult> Index()
        {
              return View(await _context.OrdersWithoutDriver.ToListAsync());
        }

        // GET: OrdersWithoutDrivers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OrdersWithoutDriver == null)
            {
                return NotFound();
            }

            var ordersWithoutDriver = await _context.OrdersWithoutDriver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordersWithoutDriver == null)
            {
                return NotFound();
            }

            return View(ordersWithoutDriver);
        }

        // GET: OrdersWithoutDrivers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdersWithoutDrivers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StartingLocation,Quantity,ETA,CarNR,Driver")] OrdersWithoutDriver ordersWithoutDriver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordersWithoutDriver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordersWithoutDriver);
        }

        // GET: OrdersWithoutDrivers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OrdersWithoutDriver == null)
            {
                return NotFound();
            }

            var ordersWithoutDriver = await _context.OrdersWithoutDriver.FindAsync(id);
            if (ordersWithoutDriver == null)
            {
                return NotFound();
            }
            return View(ordersWithoutDriver);
        }

        // POST: OrdersWithoutDrivers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StartingLocation,Quantity,ETA,CarNR,Driver")] OrdersWithoutDriver ordersWithoutDriver)
        {
            if (id != ordersWithoutDriver.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordersWithoutDriver);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersWithoutDriverExists(ordersWithoutDriver.Id))
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
            return View(ordersWithoutDriver);
        }

        // GET: OrdersWithoutDrivers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OrdersWithoutDriver == null)
            {
                return NotFound();
            }

            var ordersWithoutDriver = await _context.OrdersWithoutDriver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordersWithoutDriver == null)
            {
                return NotFound();
            }

            return View(ordersWithoutDriver);
        }

        // POST: OrdersWithoutDrivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrdersWithoutDriver == null)
            {
                return Problem("Entity set 'ApplicationDbContext.OrdersWithoutDriver'  is null.");
            }
            var ordersWithoutDriver = await _context.OrdersWithoutDriver.FindAsync(id);
            if (ordersWithoutDriver != null)
            {
                _context.OrdersWithoutDriver.Remove(ordersWithoutDriver);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdersWithoutDriverExists(int id)
        {
          return _context.OrdersWithoutDriver.Any(e => e.Id == id);
        }
    }
}
