using Microsoft.EntityFrameworkCore.Diagnostics;
using registration.Data;
using registration.Dto;
using registration.Models;

namespace registration.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public User Login(loginDto loginDto)
        {
            var user = _context.Users.FirstOrDefault(i=>i.UserName==loginDto.UserNameDto && i.UserPassword==loginDto.UserPasswordDto);
            if(user != null)
            {
                return user;
            }

            throw new Exception("User Not Found ");
        }

        public void SignUp(signupDto signupDto)
        {
            if (signupDto.UserPasswordDto != signupDto.UserConfirmPasswodDto)
            {
                throw new Exception("Password and Confirm Password do not match.");
            }
            User user = new User
            {
                UserName = signupDto.UserNameDto,
                UserEmail = signupDto.UserEmailDto,
                UserPassword = signupDto.UserPasswordDto,
                UserConfirmPasswod = signupDto.UserConfirmPasswodDto,
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
