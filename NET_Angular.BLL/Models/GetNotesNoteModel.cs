using System.Collections.Generic;

namespace NET_Angular.BLL.Models
{
    public class GetNotesNoteModel
    {
        public IEnumerable<GetNotesHomeModelItem> Items { get; set; }
    }
    public class GetNotesHomeModelItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
