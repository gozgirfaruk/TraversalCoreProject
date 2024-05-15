﻿namespace TraversalCoreProject.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Mail { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
