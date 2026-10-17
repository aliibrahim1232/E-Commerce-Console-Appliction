using Bogus;
using E_Commerce_Console_Appliction.DataBase;
using E_Commerce_Console_Appliction.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Console_Appliction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplictionDbContext())
            {
                var userFaker = new Faker<User>()
                    .RuleFor(u => u.UserName, f => f.Name.FullName())
                    .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.UserName))
                    .RuleFor(u => u.UserProfile, f => new UserProfile
                    {
                        Address = f.Address.City() + ", " + f.Address.StreetName(),
                        Phone = f.Phone.PhoneNumber("010########")
                    });

                var fakeUsers = userFaker.Generate(50);

                context.Users.AddRange(fakeUsers);
                context.SaveChanges();

                Console.WriteLine($"✅ Successfully generated and saved {fakeUsers.Count} users to the database!");

            }
        }
    }
}
