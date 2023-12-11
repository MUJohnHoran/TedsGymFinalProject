﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;

public class Appointment
{
    private static int autoIncreament;
    public int Id { get; set; }
    public DateTime date { get; set; }

    public Appointment()
    {
        autoIncreament++;
        Id = autoIncreament;
    }
}
