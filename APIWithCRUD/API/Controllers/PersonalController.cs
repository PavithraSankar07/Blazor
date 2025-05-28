using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
// using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonalController : ControllerBase
    {
        private static List<PersonalInfo> personalInfos = new List<PersonalInfo>();
        private static int s_id = 1;

        [HttpGet]
        public ActionResult<List<PersonalInfo>> Get()
        {
            return Ok(personalInfos);
        }
      
        [HttpPost]
        public ActionResult<PersonalInfo> Post([FromBody] PersonalInfo info)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Model validation failed.");
                foreach (var error in ModelState)
                {
                    Console.WriteLine($"{error.Key}: {string.Join(", ", error.Value.Errors.Select(e => e.ErrorMessage))}");
                }
                return BadRequest(ModelState);
            }

            info.ID = s_id++;
            personalInfos.Add(info);
            Console.WriteLine($"Added: {info.Name} with ID {info.ID}");

            return CreatedAtAction(nameof(GetById), new { id = info.ID }, info);
        }



        [HttpGet("{id}")]
        public ActionResult<PersonalInfo> GetById(int id)
        {
            var info = personalInfos.FirstOrDefault(x => x.ID == id);
            if (info == null) return NotFound();
            return Ok(info);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PersonalInfo updatedInfo)
        {
            var info = personalInfos.FirstOrDefault(x => x.ID == id);
            if (info == null) return NotFound();

            info.Name = updatedInfo.Name;
            info.MailID = updatedInfo.MailID;
            info.Mobile = updatedInfo.Mobile;
            info.Department = updatedInfo.Department;
            info.Photo = updatedInfo.Photo;
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var info = personalInfos.FirstOrDefault(x => x.ID == id);
            if (info == null) return NotFound();

            personalInfos.Remove(info);
            return NoContent();
        }
    }
}