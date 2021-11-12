using Microsoft.EntityFrameworkCore;
using StudentManagement.DBContexts;
using StudentManagement.Entities;
using StudentManagement.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class EventService : IEventService
    {
        private readonly StudentManagementContext context;

        public EventService(StudentManagementContext context)
        {
            this.context = context;
        }

        public bool Create(Event model)
        {
            try
            {
                context.Add(model);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Event Get(int eventId)
        {
            return context.Events.Include(p => p.User).FirstOrDefault(p => p.EventId == eventId);
        }

        public List<Event> GetEventbyUserId(string stuId)
        {
            return context.Events.Include(p => p.User).Include(p => p.ListEvent).Where(p => p.UserId == stuId).ToList();
        }
    }
}
