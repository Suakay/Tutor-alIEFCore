﻿using System;
using System.Collections.Generic;

namespace _01_DataBase.Models;

public partial class MotorVePerforman
{
    public int MotorId { get; set; }

    public int? MotorHacmi { get; set; }

    public decimal? MotorGüç { get; set; }

    public decimal? MaksimumTork { get; set; }

    public decimal? AzamiSurat { get; set; }
}
