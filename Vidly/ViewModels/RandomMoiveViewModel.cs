﻿using System.Collections.Generic;

using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMoiveViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}