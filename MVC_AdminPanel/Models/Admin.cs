﻿// Models/Admin.cs
using System.ComponentModel.DataAnnotations;

namespace MVC_AdminPanel.Models
{
    public class Admin
    {
        public int IDAdmin { get; set; }

        [Required(ErrorMessage = "Логин обязателен")]
        public string AdminLogin { get; set; }

        [Required(ErrorMessage = "Имя обязательно")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "Фамилия обязательна")]
        public string AdminSurname { get; set; }

        public string? AdminMiddleName { get; set; }

        [Required(ErrorMessage = "Пароль обязателен")]
        public string AdminHashedPassword { get; set; } // Хранить нужно закодированный пароль

        //[Required(ErrorMessage = "Роль администратора обязательна")]
        //public string AdminRole { get; set; }

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Неверный формат Email")]
        public string AdminEmail { get; set; }
    }
}