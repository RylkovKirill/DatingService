using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DatingService.Persistence.Seeds
{
    public static class DefaultGenders
    {
        public static List<Gender> GetGenders()
        {
            return new List<Gender>()
            {
                new Gender
                {
                    Id = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    Name = "Man"
                },
                new Gender
                {
                    Id = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    Name = "Woman"
                }
            };
        }
    }
}