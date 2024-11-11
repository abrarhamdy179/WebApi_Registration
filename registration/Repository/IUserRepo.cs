using registration.Dto;
using registration.Models;

namespace registration.Repository
{
    public interface IUserRepo
    {
        public void SignUp(signupDto signupDto);
        public User Login(loginDto loginDto);
    }
}
