﻿using Microsoft.EntityFrameworkCore;
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

        public bool Edit(Event model)
        {
            try
            {
                context.Attach(model);
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
            return context.Events.Include(p => p.User).Include(p => p.ListEvent).Where(p => p.UserId == stuId).OrderByDescending(m => m.EventId).ToList();
        }

        public bool Remove(int id)
        {
            try
            {
                var evt = Get(id);
                context.Remove(evt);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ChangeStatus23(int evtId)
        {
            try
            {
                var events = Get(evtId);
                if(events.Status == (Enums.EventStatus)2)
                {
                    events.Status = (Enums.EventStatus)3;
                }    
                context.Attach(events);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
