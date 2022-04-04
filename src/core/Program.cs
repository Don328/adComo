﻿using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.Menu;
using adComo.Data;
using adComo.Enums;
using adComo.Factories;
using adComo.Models;
using adComo.Services.MenuServices;

namespace adComo
{
    class Program
    {
        private static State state = new State();
        internal static State State { get { return state; } }

        static void Main(string[] args)
        {
            state = new State();
            MainMenuService.Show();
        }
    }
}