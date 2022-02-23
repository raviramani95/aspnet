using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public string PhotoUrl { get; set; }
        public int age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActivity { get; set; }  
        public String Gender { get; set; }
        public String Introduction { get; set; }
        public String LookingFor { get; set; }
        public String Interests { get; set; } 
        public String City { get; set; }
        public String Country { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
    }
}