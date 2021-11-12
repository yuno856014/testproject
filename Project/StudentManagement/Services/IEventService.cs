﻿using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public interface IEventService
    {
        Event Get(int eventId);
        List<Event> GetEventbyUserId(string stuId);
        bool Create(Event model);
    }
}
