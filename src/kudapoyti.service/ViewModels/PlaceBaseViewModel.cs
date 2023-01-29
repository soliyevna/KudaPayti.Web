﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kudapoyti.Service.ViewModels;

public class PlaceBaseViewModel
{
    public long Id { get; set; }

    public string ImageUrl { get; set; } = String.Empty;

    public string Title { get; set; } = string.Empty;

    public string Region { get; set; } = String.Empty;

    public double rank { get; set; }
}