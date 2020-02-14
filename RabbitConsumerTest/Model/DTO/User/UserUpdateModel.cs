using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DTO.User
{
    public class UserUpdateModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
    }
}
