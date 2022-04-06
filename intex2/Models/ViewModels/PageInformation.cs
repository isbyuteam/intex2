﻿using System;

namespace intex2.Models.ViewModels
{
    public class PageInformation
    {
        public int NumOfCrashes { get; set; }
        public int CrashesPerPage { get; set; }
        public int CurrrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(((double)NumOfCrashes / CrashesPerPage));
    }
}
