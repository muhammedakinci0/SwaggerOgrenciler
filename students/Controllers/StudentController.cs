using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using students.Data;
using students.Models;
using System.Diagnostics.Eventing.Reader;

namespace students.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        /* [HttpGet]
         public IActionResult GetAllStudents() {
             var students = ApplicationContext.Students.ToList();
             return Ok(students);
         }

         [HttpGet("{id:int}")]
         public IActionResult GetOneStudent([FromRoute(Name = "id")]int id)
         {
             var student = ApplicationContext
                  .Students
                  .Where(s => s.Id.Equals(id))
                  .SingleOrDefault();

             if (student == null)
             {
                 return NotFound();
             }
             return Ok(student);
         }

         [HttpPost]
         public IActionResult CreateOneStudent([FromBody] Student student)
         {
             try
             {
                 if (student is null)
                 return BadRequest();

                 ApplicationContext.Students.Add(student);
                 return StatusCode(201, student);

             }
             catch (Exception ex)
             {
 return BadRequest(ex.Message);
             }
         }
        
        [HttpPut("{id:int}")]
        public IActionResult UpdateOneStudent([FromRoute(Name = "id")] int id, [FromBody] Student student )
        {
            var entity = ApplicationContext
                .Students
                .Find(s => s.Id.Equals(id));

            if (entity == null)
             return NotFound();
               

            if (id != student.Id)
                return BadRequest();

            ApplicationContext.Students.Remove(entity);
            student.Id = entity.Id;
            ApplicationContext.Students.Add(student);
            return Ok(student);
            
                
        }
       
        [HttpDelete]
        public IActionResult DeleteAllStudents()
        {
            ApplicationContext.Students.Clear();
            return NoContent();
        }
         
        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneStudent([FromRoute(Name = "id")]int id) 
        {
            var entitiy= ApplicationContext
                .Students
                .Find(s => s.Id.Equals(id));

            if(entitiy is null)
                return NotFound(new
                {
                    StatusCode = 404,
                    message = $"Girilen id: {id}, Böyle bir id Bulunamadı."
                });

            ApplicationContext.Students.Remove(entitiy);
            return NoContent();
        
        }*/
    }
}
