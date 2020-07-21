using NET_Angular.Common;
using NET_Angular.DAL.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NET_Angular.DAL
{
    public static class Initializer
    {
        public static void InitDefaultNotes(ref MockedDatabase mockedDatabase)
        {
            IEnumerable<Note> mockedNotes = new List<Note> {
                    new Note {  Name = AppConstants.DefaultNote1, Description = AppConstants.DefaultDescription1 },
                    new Note { Name = AppConstants.DefaultNote2, Description = AppConstants.DefaultDescription2 },
                    new Note { Name = AppConstants.DefaultNote3, Description = AppConstants.DefaultDescription3 },
            };

            mockedDatabase.Notes.AddRange(mockedNotes);
        }
    }
}
