using DatingService.Domain.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DatingService.Persistence.Seeds
{
    public static class DefaultUsers
    {
        public static List<ApplicationUser> GetUsers()
        {

            return new List<ApplicationUser>()
            {
                new ApplicationUser
                {
                    Id = Guid.Parse("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                    UserName = "kirill.rylkov.2001@gmail.com",
                    Email = "kirill.rylkov.2001@gmail.com",
                    FirstName = "Kirill",
                    LastName = "Rylkov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "KIRILL.RYLKOV.2001@GMAIL.COM",
                    NormalizedUserName="KIRILL.RYLKOV.2001@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2001, 2, 27)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                    UserName = "MaximSkvortsov@gmail.com",
                    Email = "MaximSkvortsov@gmail.com",
                    FirstName = "Maxim",
                    LastName = "Skvortsov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "MAXIMSKVORTSOV@GMAIL.COM",
                    NormalizedUserName="MAXIMSKVORTSOV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1985, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("19678e73-2240-43c1-bc08-726405e9810f"),
                    UserName = "TimofeyFedorov@gmail.com",
                    Email = "TimofeyFedorov@gmail.com",
                    FirstName = "Timofey",
                    LastName = "Fedorov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "TIMOFEYFEDOROV@GMAIL.COM",
                    NormalizedUserName="TIMOFEYFEDOROV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1970, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("959fad98-c404-4b2e-a4b5-2da34b051182"),
                    UserName = "NikitaSidorov@gmail.com",
                    Email = "NikitaSidorov@gmail.com",
                    FirstName = "Nikita",
                    LastName = "Sidorov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "NIKITASIDOROV@GMAIL.COM",
                    NormalizedUserName="NIKITASIDOROV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1964, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("a2c8f466-4460-46d9-a3e1-849542257eda"),
                    UserName = "AlexeyShapavalov@gmail.com",
                    Email = "AlexeyShapavalov@gmail.com",
                    FirstName = "Alexey",
                    LastName = "Shapavalov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "ALEXEYSHAPAVALOV@GMAIL.COM",
                    NormalizedUserName="ALEXEYSHAPAVALOV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1986, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                    UserName = "GeorgeKlimov@gmail.com",
                    Email = "GeorgeKlimov@gmail.com",
                    FirstName = "George",
                    LastName = "Klimov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "GEORGEKLIMOV@GMAIL.COM",
                    NormalizedUserName="GEORGEKLIMOV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1954, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                    UserName = "AlexanderBalashov@gmail.com",
                    Email = "AlexanderBalashov@gmail.com",
                    FirstName = "Alexander",
                    LastName = "Balashov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "ALEXANDERBALASHOV@GMAIL.COM",
                    NormalizedUserName="ALEXANDERBALASHOV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1980, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("424801eb-4028-47de-b02e-b2260e4adbaf"),
                    UserName = "DmitriiGusev@gmail.com",
                    Email = "DmitriiGusev@gmail.com",
                    FirstName = "Dmitrii",
                    LastName = "Gusev",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "DMITRIIGUSEV@GMAIL.COM",
                    NormalizedUserName="DMITRIIGUSEV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2005, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                    UserName = "ArtemOvchinnikov@gmail.com",
                    Email = "ArtemOvchinnikov@gmail.com",
                    FirstName = "Artem",
                    LastName = "Ovchinnikov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "ARTEMOVCHINNIKOV@GMAIL.COM",
                    NormalizedUserName="ARTEMOVCHINNIKOV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2010, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("9041f759-c64b-4320-b85b-2332fff4ed85"),
                    UserName = "LeonidTarasov@gmail.com",
                    Email = "LeonidTarasov@gmail.com",
                    FirstName = "Leonid",
                    LastName = "Tarasov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "LEONIDTARASOV@GMAIL.COM",
                    NormalizedUserName="LEONIDTARASOV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2002, 12, 31)
                },
                
                new ApplicationUser
                {
                    Id = Guid.Parse("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                    UserName = "MarkMarkov@gmail.com",
                    Email = "MarkMarkov@gmail.com",
                    FirstName = "Mark",
                    LastName = "Markov",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "MARKMARKOV@GMAIL.COM",
                    NormalizedUserName="MARKMARKOV@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2007, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                    UserName = "PolinaFilatova@gmail.com",
                    Email = "PolinaFilatova@gmail.com",
                    FirstName = "Polina",
                    LastName = "Filatova",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "POLINAFILATOVA@GMAIL.COM",
                    NormalizedUserName="POLINAFILATOVA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1964, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                    UserName = "AnnaPopova@gmail.com",
                    Email = "AnnaPopova@gmail.com",
                    FirstName = "Anna",
                    LastName = "Popova",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "ANNAPOPOVA@GMAIL.COM",
                    NormalizedUserName="ANNAPOPOVA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1984, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("abc953f6-d6ff-464b-9539-c95ee111f006"),
                    UserName = "AnnaSolovyeva@gmail.com",
                    Email = "AnnaSolovyeva@gmail.com",
                    FirstName = "Anna",
                    LastName = "Solovyeva",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "ANNASOLOVYEVA@GMAIL.COM",
                    NormalizedUserName="ANNASOLOVYEVA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1997, 12, 31)
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                    UserName = "AnnaKarenina@gmail.com",
                    Email = "AnnaKarenina@gmail.com",
                    FirstName = "Anna",
                    LastName = "Karenina",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "ANNAKARENINA@GMAIL.COM",
                    NormalizedUserName="ANNAKARENINA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1965, 12, 31)
                },
                 new ApplicationUser
                {
                    Id = Guid.Parse("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                    UserName = "PolinaGrishina@gmail.com",
                    Email = "PolinaGrishina@gmail.com",
                    FirstName = "Polina",
                    LastName = "Grishina",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "POLINAGRISHINA@GMAIL.COM",
                    NormalizedUserName="POLINAGRISHINA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1975, 12, 31)
                },
                 new ApplicationUser
                {
                    Id = Guid.Parse("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                    UserName = "DaryaNikitina@gmail.com",
                    Email = "DaryaNikitina@gmail.com",
                    FirstName = "Darya",
                    LastName = "Nikitina",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "DARYANIKITINA@GMAIL.COM",
                    NormalizedUserName="DARYANIKITINA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2000, 12, 31)
                },
                 new ApplicationUser
                {
                    Id = Guid.Parse("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                    UserName = "EvaAndreeva@gmail.com",
                    Email = "EvaAndreevaa@gmail.com",
                    FirstName = "Eva",
                    LastName = "Andreeva",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "EVAANDREEVA@GMAIL.COM",
                    NormalizedUserName="EVAANDREEVA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1991, 12, 31)
                },
                 new ApplicationUser
                {
                    Id = Guid.Parse("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                    UserName = "MilanaErmakova@gmail.com",
                    Email = "MilanaErmakova@gmail.com",
                    FirstName = "Milana",
                    LastName = "Ermakova",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "MILANAERMAKOVA@GMAIL.COM",
                    NormalizedUserName="MILANAERMAKOVA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1984, 12, 31)
                },
                 new ApplicationUser
                {
                    Id = Guid.Parse("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                    UserName = "AlisaGorbacheva@gmail.com",
                    Email = "AlisaGorbacheva@gmail.com",
                    FirstName = "Alisa",
                    LastName = "Gorbacheva",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "ALISAGORBACHEVA@GMAIL.COM",
                    NormalizedUserName="ALISAGORBACHEVA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1961, 12, 31)
                },
                 new ApplicationUser
                {
                    Id = Guid.Parse("b587585c-344b-4e35-9df0-90723c5114ba"),
                    UserName = "SofiyaIvanova@gmail.com",
                    Email = "SofiyaIvanova@gmail.com",
                    FirstName = "Sofiya",
                    LastName = "Ivanova",
                    EmailConfirmed = true,
                    GenderId = Guid.Parse("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "m8RwntY%ew"),
                    NormalizedEmail= "SOFIYAIVANOVA@GMAIL.COM",
                    NormalizedUserName="SOFIYAIVANOVA@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1999, 12, 31)
                },
            };
        }
    }
}
