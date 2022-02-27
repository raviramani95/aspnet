using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Extensions;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActivity { get; set; } = DateTime.Now;
        public String Gender { get; set; }
        public String Introduction { get; set; }
        public String LookingFor { get; set; }
        public String Interests { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public ICollection<Photo> Photos { get; set; }

        public ICollection<UserLike> LikeByUsers { get; set; }
        public ICollection<UserLike> LikedUsers { get; set; }

        public ICollection<Message> MessageSent { get; set; }
        public ICollection<Message> MessageReceived { get; set; }
        

        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}


        // public int Id { get; set; }
        // public String UserName { get; set; }

        // public byte[] PasswordHash { get; set; }

        // public byte[] PasswordSalt { get; set; }  