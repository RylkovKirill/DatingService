using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;


namespace DatingService.Infrastructure.ViewModels
{
    public class PostListViewModel
    {
        public string Filter { get; set; }

        public List<Post> Posts { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
