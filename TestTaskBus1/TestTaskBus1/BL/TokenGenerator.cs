﻿using System;
using System.Linq;

namespace TestTaskBus1.BL
{
    public static class TokenGenerator
    {
        public static string GenerateShortUrl()
        {
            var urlsafe = string.Empty;
            Enumerable.Range(48, 75)
                .Where(i => i < 58 || i > 64 && i < 91 || i > 96)
                .OrderBy(o => new Random().Next())
                .ToList()
                .ForEach(i => urlsafe += Convert.ToChar(i));
            var token = urlsafe.Substring(new Random().Next(0, urlsafe.Length), new Random().Next(2, 6));

            return token;
        }
    }
}