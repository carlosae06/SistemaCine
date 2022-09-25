﻿using System.ComponentModel.DataAnnotations;

namespace BackEnd.DTOs.Rol
{
    public class RolUpdateDTO
    {
        [Required]
        [StringLength(10)]
        public string Cod { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        public bool? Estado { get; set; }
    }
}
