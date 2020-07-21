using NET_Angular.BLL.Models;
using System.Threading.Tasks;

namespace NET_Angular.BLL.Services.Interfaces
{
    public interface INoteService
    {
        Task CreateNoteAsync(CreateUpdateNoteModel noteModel);
        Task<GetNotesNoteModel> GetNotesAsync(string noteId = null);
        Task UpdateNoteAsync(CreateUpdateNoteModel noteModel);
        Task RemoveAsync(string noteId);
    }
}
