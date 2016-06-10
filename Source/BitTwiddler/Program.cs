// <copyright file="Program.cs" company="Shkyrockett">
//     Copyright (C) Shkyrockett. All rights reserved.
// </copyright>
// <author>Shkyrockett</author>

namespace Bit_Twiddler
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main entry class of the program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BitTwiddler());
        }
    }
}
