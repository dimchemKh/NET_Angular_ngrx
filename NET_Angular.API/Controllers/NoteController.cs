using Microsoft.AspNetCore.Mvc;
using NET_Angular.BLL.Models;
using NET_Angular.BLL.Services.Interfaces;
using System.Threading.Tasks;

namespace NET_Angular_Aionys.Web.Controllers
{
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get(string noteId = null)
        {
            var response = await _noteService.GetNotesAsync(noteId);
            return Ok(response);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateUpdateNoteModel model)
        {
            await _noteService.CreateNoteAsync(model);
            return Ok();
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(CreateUpdateNoteModel model)
        {
            await _noteService.UpdateNoteAsync(model);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(string noteId)
        {
            await _noteService.RemoveAsync(noteId);
            return Ok();
        }
    }
}
