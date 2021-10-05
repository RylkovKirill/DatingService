﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Domain.Entities
{
    public class Message
    {
        public string Content { get; set; }

        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
    }
}
