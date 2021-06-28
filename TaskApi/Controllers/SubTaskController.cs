using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers
{
    public class SubTaskController:ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> CreateMaterialType(string clothMaterialType)
        {
            
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult>UpdateSubTaskInfo()
        {
            
        }
    }
}