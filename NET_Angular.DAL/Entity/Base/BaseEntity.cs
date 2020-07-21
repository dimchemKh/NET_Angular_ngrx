using System;

namespace NET_Angular.DAL.Entity.Base
{
    public class BaseEntity
    {
        public string Id { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
