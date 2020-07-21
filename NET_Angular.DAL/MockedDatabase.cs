using NET_Angular.Common;
using NET_Angular.DAL.Entity;
using System.Collections.Generic;

namespace NET_Angular.DAL
{
    public class MockedDatabase
    {
        public List<Note> Notes { get; set; }
        public MockedDatabase()
        {
            Notes = new List<Note>()
            {
                    new Note { Name = AppConstants.DefaultNote1, Description = AppConstants.DefaultDescription1 },
                    new Note { Name = AppConstants.DefaultNote2, Description = AppConstants.DefaultDescription2 },
                    new Note { Name = AppConstants.DefaultNote3, Description = AppConstants.DefaultDescription3 },
            };
        }
    }
}