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
// add the data
        [HttpPost]
        public ActionResult<PersonalInfo> Post([FromBody] PersonalInfo info)
        {


            info.ID = s_id++;
            personalInfos.Add(info);
            Console.WriteLine($"Added: {info.Name} with ID {info.ID}");

           
            return Ok(info);
        }

// fetch the data

        [HttpGet("{id}")]
        public ActionResult<PersonalInfo> GetById(int id)
        {
            var info = personalInfos.FirstOrDefault(x => x.ID == id);
            if (info == null) return NotFound();
            return Ok(info);
        }
        // edit the data
        [HttpPut("{id}")]
        public IActionResult Edit(int id, [FromBody] PersonalInfo updatedInfo)
        {
            var info = personalInfos.FirstOrDefault(x => x.ID == id);
            if (info.Equals(null))
            {
                return NotFound();
            }

            
            info.Name = updatedInfo.Name;
            info.Mobile = updatedInfo.Mobile;
            info.MailID = updatedInfo.MailID;
            info.Photo = updatedInfo.Photo;
            info.Degree = updatedInfo.Degree;
            info.Department = updatedInfo.Department;
            info.DOB = updatedInfo.DOB;
            info.SelectedDepartments = updatedInfo.SelectedDepartments;
            info.Time = updatedInfo.Time;
            info.Languages = updatedInfo.Languages;
            info.DateTime = updatedInfo.DateTime;
            info.Gender = updatedInfo.Gender;
            info.Amount = updatedInfo.Amount;
            return NoContent();
        }

        // Delete the data

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {


            var info = personalInfos.Find(x => x.ID.Equals(id));
            if (info.Equals(null))
            {
                return NotFound();
            }
            personalInfos.Remove(info);
            return NoContent();


        }
    }
}