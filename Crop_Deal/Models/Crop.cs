﻿using System.ComponentModel.DataAnnotations;

namespace Crop_Deal.Models
{
    public class Crop
    {
        [Key]
        [Required]
        public int Crop_id {get; set;}
        [Required]
        public string? Crop_name { get; set;}
        [Required]
        public string? Crop_image { get; set;}
    }
}
