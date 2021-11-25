using System;
using System.ComponentModel.DataAnnotations;


namespace DatingService.Infrastructure.ViewModels
{
    public class PostViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        [StringLength(256, ErrorMessage = "The {0} must be at least {1} characters long.")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(2048, ErrorMessage = "The {0} must be at least {1} characters long.")]
        public string Content { get; set; }

        [Display(Name = "Image")]
        [StringLength(128, ErrorMessage = "The {0} must be at least {1} characters long.")]
        public string ImagePath { get; set; }
    }
}
