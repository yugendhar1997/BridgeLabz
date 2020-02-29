// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelModel.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model.LabelModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

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
