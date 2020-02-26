using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.LabelModel
{
    /// <summary>
    /// Label Model
    /// </summary>
    public class LabelModel
    {
        public int Id { get; set; }

        [ForeignKey("UserModels")]
        public string Email { get; set; }
        public string Label { get; set; }
    }
}
