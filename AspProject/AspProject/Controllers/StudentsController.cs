using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProject.DAL;
using AspProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspProject.Controllers
{
    
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
        
        /*public IActionResult Index()
        {
            return View();
        }*/

        [HttpGet]
        public string GetStudent()
        {
            return "Luffy, Duffy, Tyffy";
        }
        
        /*[HttpGet]
        public string GetStudents(string orderBy)
        {
            return $"Luffy, Duffy, Tyffy sorting = {orderBy}";
        }*/
        
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Luffy");
            }else if (id == 2)
            {
                return Ok("Duffy");
            }

            return NotFound("Student not found");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 2000)}";
            return Ok(student);
        }
        
        [HttpPut("{id}")]
        public IActionResult PutMethod(int id)
        {
            return Ok("Put is completed");
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteMethod(int id)
        {
            return Ok("Delete is completed");
        }

        
    }
}
