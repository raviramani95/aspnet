using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;

        public BuggyController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret(){
            return "secret text";
        }

        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound(){
            var thing = _context.Users.Find(-1);

            if(thing==null) return NotFound(-1);
            return Ok(thing);       
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetSereverError(){
            
            var thing = _context.Users.Find(-1);
            var thingToReturn = thing.ToString();
            return thingToReturn;
            // try{
            //     var thing = _context.Users.Find(-1);
            //     var thingToReturn = thing.ToString();
            //     return thingToReturn;
            // }
            // catch(Exception ex){
            //     return StatusCode(500,"computer say no!");
            // }
            
        }

        [HttpGet("bad-request")]
        public ActionResult<string> GetBedRequest(){
            return BadRequest("This was not a good request.");
        }
    }
}