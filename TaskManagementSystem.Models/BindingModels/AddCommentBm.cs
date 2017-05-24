﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TaskManagementSystem.Models.Enums;

namespace TaskManagementSystem.Models.BindingModels
{
    public class AddCommentBm
    {
        public int TaskId { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Comment")]
        public string CommentDescription { get; set; }

        [DisplayName("Comment Type")]
        public CommentType CommentType { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Reminder Date")]
        public DateTime ReminderDate { get; set; }
    }
}