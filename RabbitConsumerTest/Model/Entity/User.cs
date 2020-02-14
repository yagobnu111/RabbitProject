using Model.DTO.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public string Cpf { get; protected set; }

        public User(UserRequestModel user)
        {
            Id = Guid.NewGuid();
            Name = user.Name;
            Age = user.Age;
            Cpf = user.Cpf;
        }
    }
}
