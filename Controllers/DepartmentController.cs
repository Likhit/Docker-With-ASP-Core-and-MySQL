using System.Threading.Tasks;
using ContainerProd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContainerProd.Controllers
{
    [Route("/api/[controller]")]
    public class DepartmentController: InjectedController
    {
        public DepartmentController(StudentContext context) : base(context) { }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            var department = await db.Departments.FindAsync(id);
            if (department == default(Department))
            {
                return NotFound();
            }
            return Ok(department);
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment([FromBody] Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await db.AddAsync(department);
            await db.SaveChangesAsync();
            return Ok(department.ID);
        }

    }
}