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
        [HttpGet("GetNotes")]
        public async Task<IActionResult> GetNotes(string noteId = null)
        {
            var response = await _noteService.GetNotesAsync(noteId);
            return Ok(response);
        }
        [HttpPost("CreateNotes")]
        public async Task<IActionResult> CreateNotes(CreateUpdateNoteModel model)
        {
            await _noteService.CreateNoteAsync(model);
            return Ok();
        }
        [HttpPut("UpdateNotes")]
        public async Task<IActionResult> UpdateNotes(CreateUpdateNoteModel model)
        {
            await _noteService.UpdateNoteAsync(model);
            return Ok();
        }
        [HttpDelete("DeleteNotes")]
        public async Task<IActionResult> DeleteNotes(string noteId)
        {
            await _noteService.RemoveAsync(noteId);
            return Ok();
        }
    }
}
