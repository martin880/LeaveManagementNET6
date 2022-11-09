using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using AutoMapper;
using LeaveManagement.Web.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Web.Constants;

namespace LeaveManagement.Web.Controllers
{
    [Authorize]
    public class LeaveRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILeaveRequestRepository leaveRequestRepository;

        public LeaveRequestsController(ApplicationDbContext context,ILeaveRequestRepository leaveRequestRepository)
        {
            _context = context;
            this.leaveRequestRepository = leaveRequestRepository;
        }

        [Authorize(Roles = Roles.Administrator)]
        // GET: LeaveRequests
        public async Task<IActionResult> Index()
        {
            var model = await leaveRequestRepository.GetAdminLeaveRequestList();
            return View(model);
        }

        public async Task<ActionResult> MyLeave()
        {
            var model = await leaveRequestRepository.GetMyLeaveDetails();
            return View(model);
        }

        // GET: LeaveRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LeaveRequests == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests
                .Include(l => l.LeaveType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            return View(leaveRequest);
        }

        // GET: LeaveRequests/Create
        public IActionResult Create()
        {
            var model = new LeaveRequestCreateVM
            {
                LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name")
            };
            return View(model);
        }

        // POST: LeaveRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveRequestCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await leaveRequestRepository.CreateLeaveRequest(model);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An Error Has Occurred. Please Try Again Later");
            }
            
            model.LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name", model.LeaveTypeId);
            return View(model);
        }

        // GET: LeaveRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LeaveRequests == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
            return View(leaveRequest);
        }

        // POST: LeaveRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StartDate,EndDate,LeaveTypeId,DateRequested,RequestComments,Approved,Cancelled,RequestingEmployeeId,Id,DateCreated,DateModified")] LeaveRequest leaveRequest)
        {
            if (id != leaveRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveRequestExists(leaveRequest.Id))
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
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
            return View(leaveRequest);
        }

        // GET: LeaveRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LeaveRequests == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests
                .Include(l => l.LeaveType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            return View(leaveRequest);
        }

        // POST: LeaveRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LeaveRequests == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LeaveRequests'  is null.");
            }
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest != null)
            {
                _context.LeaveRequests.Remove(leaveRequest);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveRequestExists(int id)
        {
          return _context.LeaveRequests.Any(e => e.Id == id);
        }
    }
}
