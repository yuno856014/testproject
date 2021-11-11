﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Entities
{
    public partial class Event
    {
        public Event()
        {
            Messages = new HashSet<Message>();
        }

        public int EventId { get; set; }
        public string UserId { get; set; }
        public string Activities { get; set; }
        public string Act { get; set; }
        public string PowerExerted { get; set; }
        public string PowerDev { get; set; }
        public string Think { get; set; }
        public int? ListEventId { get; set; }
        public string SchoolYear { get; set; }

        public virtual ListEvent ListEvent { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
