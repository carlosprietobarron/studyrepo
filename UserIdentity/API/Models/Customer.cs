﻿using Microsoft.AspNetCore.Identity;
namespace UserIdentity.Api.Models

{
    public class Customer
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }
        public string Location { get; set; }
        public string Gender { get; set; }
    }
}

