﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DB_Sytem.Models;

public partial class course
{
    public int course_ID { get; set; }

    public string name { get; set; }

    public int? duration { get; set; }

    public int? grade { get; set; }

    public virtual ICollection<course_topic> course_topics { get; set; } = new List<course_topic>();

    public virtual ICollection<exam> exams { get; set; } = new List<exam>();

    public virtual ICollection<ins_course_dept> ins_course_depts { get; set; } = new List<ins_course_dept>();

    public virtual ICollection<question> questions { get; set; } = new List<question>();

    public virtual ICollection<student> sts { get; set; } = new List<student>();
}