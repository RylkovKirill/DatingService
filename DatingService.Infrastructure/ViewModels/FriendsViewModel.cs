﻿using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Infrastructure.ViewModels
{
    public class FriendsViewModel
    {
        public List<ApplicationUser> Friends { get; set; }
        public List<Request> Requests { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
