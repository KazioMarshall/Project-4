using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Project_3_library;

namespace Project_4___API.Controllers
{
    public class MyController : ApiController
    {
        [HttpGet]
        [Route("api/My/GetCellPhoneNumber")]
        public IHttpActionResult GetCellPhoneNumber()
        {
            try
            {
                // Instantiate the Student class from the DLL
                Student student = new Student
                {
                    Name = "John Doe",
                    Age = 20,
                    StudentId = "12345"
                };

                // Call the GetCellPhoneNumber() method with name and number parameters
                string cellPhoneNumber = student.GetCellPhoneNumber();

                return Ok(cellPhoneNumber);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}