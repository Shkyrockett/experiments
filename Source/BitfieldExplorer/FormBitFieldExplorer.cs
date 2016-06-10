// <copyright file="FormBitFieldExplorer.cs">
//     Copyright (c) 2016 Shkyrockett. All rights reserved.
// </copyright>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <author id="shkyrockett">Shkyrockett</author>
// <summary>Form for interactively presenting the BitField data.</summary>

using System.Windows.Forms;

namespace BitfieldExplorer
{
    /// <summary>
    /// The <see cref="FormBitFieldExplorer"/> <see cref="Form"/> class to display changes to the <see cref="BitField"/> live.
    /// </summary>
    public partial class FormBitFieldExplorer
        : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormBitFieldExplorer"/> class.
        /// </summary>
        public FormBitFieldExplorer()
        {
            InitializeComponent();
        }
    }
}
