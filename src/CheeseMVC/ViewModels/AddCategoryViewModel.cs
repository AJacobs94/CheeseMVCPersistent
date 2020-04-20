﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name="Catgory Name")]
        public string Name { get; set; }
    }
}
