﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace behlul.Models
{
    public class Etkinlikler
    {
        [Key]

        [AllowNull] public string Title { get; set; }
        [AllowNull] public string Text { get; set; }
        [AllowNull] public string Date { get; set; }
    }
}
