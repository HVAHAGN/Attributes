﻿using System;

namespace ConsoleAppCurency.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class RateInfoAttribute : Attribute
    {
        public RateInfoAttribute(string cultureName)
        {
            CultureName = cultureName;
        }

        public string CultureName { get; private set; }
    }
}