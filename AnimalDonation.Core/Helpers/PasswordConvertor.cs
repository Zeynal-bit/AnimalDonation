﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalDonation.Core.Helpers
{
    public class PasswordConvertor
    {
        public static long Convert(string userName)
        {
            string str = userName + "-spasem-mir";

            var sum = str.Sum(ch => (int)ch);

            return sum;
        }
    }
}