using AutoMapper;
using NET_Angular.BLL.Models;
using NET_Angular.BLL.Services.Interfaces;
using NET_Angular.DAL.Entity;
using NET_Angular.DAL.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Angular.BLL.Services
{
    public class NoteService : INoteService
    {
        private readonly NoteRepository _homeRepository;
        private readonly IMapper _mapper;
        public NoteService(NoteRepository homeRepository, IMapper mapper)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;
        }

        public async Task CreateNoteAsync(CreateUpdateNoteModel noteModel)
        {
            var note = _mapper.Map<Note>(noteModel);
            await _homeRepository.CreateAsync(note);
        }
        public async Task<GetNotesNoteModel> GetNotesAsync(string noteId = null)
        {
            GetNotesNoteModel response = new GetNotesNoteModel();

            if (noteId is null)
            {
                var items = await _homeRepository.GetAllAsync();
                response.Items = _mapper.Map<IEnumerable<GetNotesHomeModelItem>>(items);
            }
            if (!(noteId is null))
            {
                var item = await _homeRepository.GetByIdAsync(noteId);
                response.Items = new List<GetNotesHomeModelItem>();
                response.Items = Enumerable.Append(response.Items, _mapper.Map<GetNotesHomeModelItem>(item));
            }

            return response;
        }
        public async Task RemoveAsync(string noteId)
        {
            await _homeRepository.RemoveAsync(noteId);
        }
        public async Task UpdateNoteAsync(CreateUpdateNoteModel noteModel)
        {
            var notes = _mapper.Map<Note>(noteModel);
            await _homeRepository.UpdateAsync(notes);
        }
    }
}
