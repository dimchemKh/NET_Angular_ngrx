using NET_Angular.Common.Extensions;
using NET_Angular.DAL.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Angular.DAL.Repository
{
    public class NoteRepository
    {
        private MockedDatabase _mockedDatabase;
        public NoteRepository(MockedDatabase mockedDatabase)
        {
            _mockedDatabase = mockedDatabase;
        }
        public async Task<IEnumerable<Note>> GetAllAsync()
        {
            return await Task.Run(() =>
            {
                return _mockedDatabase.Notes.ToList();
            });
        }
        public async Task<Note> GetByIdAsync(string noteId)
        {
            return await Task.Run(() =>
            {
                return _mockedDatabase.Notes.FirstOrDefault(x => x.Id.Equals(noteId));
            });
        }
        public async Task UpdateAsync(Note note)
        {
            await Task.Run(() =>
            {
                Note oldNote = _mockedDatabase.Notes.FirstOrDefault(x => x.Id.Equals(note.Id));
                _mockedDatabase.Notes = _mockedDatabase.Notes.Replace(oldNote, note).ToList();
            });
        }
        public async Task CreateAsync(Note note)
        {
            await Task.Run(() =>
            {
                _mockedDatabase.Notes.Add(note);
            });
        }
        public async Task RemoveAsync(string noteId)
        {
            await Task.Run(() =>
            {
                Note note = _mockedDatabase.Notes.FirstOrDefault(x => x.Id.Equals(noteId));
                _mockedDatabase.Notes.Remove(note);
            });
        }
    }
}