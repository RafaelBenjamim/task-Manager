﻿using System.Reflection.Metadata.Ecma335;

namespace TaskManager.Models.Entitys
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
