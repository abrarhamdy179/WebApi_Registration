﻿namespace registration.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        
        public string UserConfirmPasswod { get; set; }
    }
}
