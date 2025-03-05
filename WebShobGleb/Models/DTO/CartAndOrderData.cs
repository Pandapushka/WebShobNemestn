﻿using System.ComponentModel.DataAnnotations;

namespace WebShobGleb.Models.DTO
{
    public class CartAndOrderData
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> Items { get; set; }
        public int Amount { get; set; }
        public decimal Cost { get; set; }
        [Required(ErrorMessage = "Поле ФИО должно быть заполнено")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "Имя должно содержать от 3 до 70 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле Email должно быть заполнено")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Телефон должно быть заполнено")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Поле Телефон должно содержать от 5 до 20 символов")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Поле Адрес должно быть заполнено")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Поле Адрес должно содержать от 5 до 200 символов")]
        public string Address { get; set; }
    }
}
