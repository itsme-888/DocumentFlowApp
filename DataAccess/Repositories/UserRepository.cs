using DataAccess;
using DocumentFlowApp.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System;

namespace DocumentFlowApp.DataAccess.Repositories
{
    public class UserRepository(AppDbContext context)
    {
        private static Random rnd = new Random();
        private const string salt = "dkjfkdjkfkjdkfjjkd_43843u8fjd";

        private static string CreateMD5(string input)
        {
            input = input + salt;
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }

        public static string GenPass()
        {
            var symb = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890_";

            var sb = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                sb.Append(symb[rnd.Next(symb.Length)]);
            }
            return sb.ToString();
        }


        public static string GetDefaultPasswordHash() => CreateMD5("password");

        public async Task<User?> LogInAsync(string login, string pass)
        {
            var user = await context.Users
                .FirstOrDefaultAsync(x => x.UserName == login 
                       && x.PasswordHash == CreateMD5(pass));
            return user;
        }

        public async Task<List<User>> GetUsersAsync() 
            => await context.Users.ToListAsync();

        public async Task AddUserAsync(string login, 
            string name, 
            string password,
            bool isAdmin)
        {
            var user = new User
            {
                Name = name,
                PasswordHash = CreateMD5(password),
                UserName = login,
                IsAdmin = isAdmin,
            };

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task ChangeUserAsync(long id,
            string login,
            string name,
            string password,
            bool isAdmin)
        {
            var user = await context.Users.SingleAsync(x => x.Id == id);

            user.IsAdmin = isAdmin;
            user.UserName = login;
            user.Name = name;
            user.PasswordHash = string.IsNullOrWhiteSpace(password) ? user.PasswordHash : CreateMD5(password);

            await context.SaveChangesAsync();
        }
    }
}
