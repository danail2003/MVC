﻿namespace SharedTrip
{
    using SUS.MvcFramework;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main()
        {
            await Host.CreateHostAsync(new Startup(), 443);
        }
    }
}