﻿using System.ComponentModel.DataAnnotations;

namespace FormaaS.Entities
{
    public class Form
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<FormField> Fields { get; set; }
    }
}
