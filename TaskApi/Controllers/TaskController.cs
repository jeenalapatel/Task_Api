using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers
{
    public class TaskController:ControllerBase
    
    {
        [HttpPost]
        public async Task<ActionResult> CreateClothName(string clothName)
        {
            
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAllTasks(int id)
        {
            
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult>UpdateTaskInfo()
        {
            
        }
    }
}