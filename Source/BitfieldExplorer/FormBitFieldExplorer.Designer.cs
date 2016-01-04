// <copyright file="FormBitFieldExplorer.Designer.cs">
//     Copyright (c) 2013 - 2016 Shkyrockett. All rights reserved.
// </copyright>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <author id="shkyrockett">Shkyrockett</author>
// <summary>Auto-generated code behind the form for interactively displaying the BitField data.</summary>

using System.Windows.Forms;

namespace BitfieldDemo
{
    /// <summary>
    /// The <see cref="FormBitFieldExplorer"/> <see cref="Form"/> class to display changes to the <see cref="BitField"/> live.
    /// </summary>
    partial class FormBitFieldExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// The <see cref="BitField"/> class component experiment. 
        /// </summary>
        private BitField bitField1;

        /// <summary>
        /// A <see cref="PropertyGrid"/> used to display the contents of the <see cref="BitField"/> object.
        /// </summary>
        private PropertyGrid propertyGrid1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.bitField1 = new BitfieldDemo.BitField();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.bitField1;
            this.propertyGrid1.Size = new System.Drawing.Size(478, 422);
            this.propertyGrid1.TabIndex = 0;
            // 
            // FormBitFieldExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 422);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "FormBitFieldExample";
            this.Text = "Bit-Field Explorer";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

