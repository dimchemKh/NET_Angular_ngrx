using NET_Angular.DAL.Entity.Base;

namespace NET_Angular.DAL.Entity
{
    public class Note : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
