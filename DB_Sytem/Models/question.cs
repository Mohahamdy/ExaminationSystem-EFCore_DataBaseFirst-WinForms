﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DB_Sytem.Models;

public partial class question
{
    public int question_ID { get; set; }

    public string text { get; set; }

    public string type { get; set; }

    public string correct_ans { get; set; }

    public int? grade { get; set; }

    public int? course_ID { get; set; }

    public virtual course course { get; set; }

    public virtual question_option question_option { get; set; }

    public virtual ICollection<st_answer> st_answers { get; set; } = new List<st_answer>();

    public virtual ICollection<exam> exams { get; set; } = new List<exam>();
}