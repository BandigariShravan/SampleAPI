﻿using BookUserAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BookAPI.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string? Full_Name { get; set; }
        public bool Enabled { get; set; }
        public DateTime Last_Login { get; set; }
        public virtual ICollection<BookUser>? bookUsers { get; set; }
    }
}