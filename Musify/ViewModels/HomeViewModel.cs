﻿using Musify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Artist> Artists { get; set; }
        public IEnumerable<Album> Albums { get; set; }
    }
}