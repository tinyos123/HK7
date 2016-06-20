﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSS.ViewModels
{
    public class MiscTextModel
    {
        public int AgreementNumber { get; set; }
        public int VarriantNumber { get; set; }

        [StringLength(200)]
        public string CreditNoteText { get; set; }

        [Required]
        [StringLength(200)]
        public string CommentText { get; set; }
    }
}