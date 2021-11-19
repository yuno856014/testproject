using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagement.DBContexts;
using StudentManagement.Entities;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    public class MessagesController : Controller
    {
        private readonly StudentManagementContext _context;

        public MessagesController(StudentManagementContext context
                                   )
        {
            _context = context;
        }

        // GET: Messages
        [Route("/Messages/Index/{evtId}")]
        public async Task<IActionResult> Index(int evtId)
        {
            var studentManagementContext = _context.Messages.Include(m => m.Event).Include(m => m.Skill).Include(m => m.User).Where(c => c.EventId == evtId);
            return View(await studentManagementContext.ToListAsync());
        }

        // GET: Messages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await _context.Messages
                .Include(m => m.Event)
                .Include(m => m.Skill)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MessagesId == id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // GET: Messages/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId");
            ViewData["SkillId"] = new SelectList(_context.Skills, "SkillId", "SkillId");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Messages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MessagesId,Content,Timestamp,EventId,UserId,SkillId")] Message message)
        {
            if (ModelState.IsValid)
            {
                _context.Add(message);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", message.EventId);
            ViewData["SkillId"] = new SelectList(_context.Skills, "SkillId", "SkillId", message.SkillId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", message.UserId);
            return View(message);
        }

        // GET: Messages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await _context.Messages.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", message.EventId);
            ViewData["SkillId"] = new SelectList(_context.Skills, "SkillId", "SkillId", message.SkillId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", message.UserId);
            return View(message);
        }

        // POST: Messages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MessagesId,Content,Timestamp,EventId,UserId,SkillId")] Message message)
        {
            if (id != message.MessagesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(message);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MessageExists(message.MessagesId))
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
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", message.EventId);
            ViewData["SkillId"] = new SelectList(_context.Skills, "SkillId", "SkillId", message.SkillId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", message.UserId);
            return View(message);
        }

        // GET: Messages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await _context.Messages
                .Include(m => m.Event)
                .Include(m => m.Skill)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MessagesId == id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // POST: Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var message = await _context.Messages.FindAsync(id);
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MessageExists(int id)
        {
            return _context.Messages.Any(e => e.MessagesId == id);
        }
    }
}
