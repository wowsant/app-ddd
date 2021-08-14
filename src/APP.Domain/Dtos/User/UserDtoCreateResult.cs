using System;

namespace APP.Domain.Dtos.User
{
    public class UserDtoCreateResult
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateAr { get; set; }
    }
}
