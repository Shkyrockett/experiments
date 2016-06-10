// <copyright file="BitTwiddler.cs" company="Shkyrockett">
//     Copyright (C) Shkyrockett. All rights reserved.
// </copyright>
// <author>Shkyrockett</author>

namespace Bit_Twiddler
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Bit Twiddler form
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
    public partial class BitTwiddler : Form
    {
        /// <summary>
        /// Integer value 1
        /// </summary>
        private int integer1;

        /// <summary>
        /// Integer value 2
        /// </summary>
        private int integer2;

        /// <summary>
        /// Integer value 3
        /// </summary>
        private int integer3;

        /// <summary>
        /// A flag instructing the bits to be output in reversed order.
        /// </summary>
        private bool ReverseBits;

        /// <summary>
        /// Initializes a new instance of the <see cref="BitTwiddler"/> class.
        /// </summary>
        public BitTwiddler()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for combo box selection changing.
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void num1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown received = (NumericUpDown)sender;
            integer1 = Convert.ToInt32(received.Value);
            Label1.Value = integer1;
            txt1.Text = toBitString(integer1, ReverseBits);
            update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void Label1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown received = (NumericUpDown)sender;
            integer1 = Convert.ToInt32(received.Value);
            num1.Value = integer1;
            txt1.Text = toBitString(integer1, ReverseBits);
            update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void num2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown received = (NumericUpDown)sender;
            integer2 = Convert.ToInt32(received.Value);
            Label2.Value = integer2;
            txt2.Text = toBitString(integer2, ReverseBits);
            update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void Label2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown received = (NumericUpDown)sender;
            integer2 = Convert.ToInt32(received.Value);
            num2.Value = integer2;
            txt2.Text = toBitString(integer2, ReverseBits);
            update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void txt1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void txt2_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void txt3_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void BitTwiddler_Load(object sender, EventArgs e)
        {
            cmbMode.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (rad1.Checked)
            {
                integer1 >>= (int)(NumShift.Value);
                num1.Value = integer1;
                txt1.Text = toBitString(integer1, ReverseBits);
                Label1.Value = integer1;
            }
            else if (rad2.Checked)
            {
                integer2 >>= (int)(NumShift.Value);
                num2.Value = integer2;
                txt2.Text = toBitString(integer2, ReverseBits);
                Label2.Value = integer2;
            }
            else if (rad3.Checked)
            {
                integer3 >>= (int)(NumShift.Value);
                num3.Text = integer3.ToString();
                txt3.Text = toBitString(integer3, ReverseBits);
                Label3.Text = $"0x{Convert.ToString(integer3, 16).ToUpper():0000000000000000}";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (rad1.Checked)
            {
                integer1 <<= (int)(NumShift.Value);
                num1.Value = integer1;
                txt1.Text = toBitString(integer1, ReverseBits);
                Label1.Value = integer1;
            }
            else if (rad2.Checked)
            {
                integer2 <<= (int)(NumShift.Value);
                num2.Value = integer2;
                txt2.Text = toBitString(integer2, ReverseBits);
                Label2.Value = integer2;
            }
            else if (rad3.Checked)
            {
                integer3 <<= (int)(NumShift.Value);
                num3.Text = integer3.ToString();
                txt3.Text = toBitString(integer3, ReverseBits);
                Label3.Text = $"0x{Convert.ToString(integer3, 16).ToUpper():0000000000000000}";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sending object of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void chkReverseBits_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox received = (CheckBox)sender;
            ReverseBits = received.Checked;
            txt1.Text = toBitString(integer1, ReverseBits);
            txt2.Text = toBitString(integer2, ReverseBits);
            txt3.Text = toBitString(integer3, ReverseBits);
        }

        /// <summary>
        /// 
        /// </summary>
        public void update()
        {
            switch (cmbMode.SelectedIndex)
            {
                case 0: // And
                    integer3 = (int)(integer1 & integer2);
                    break;
                case 1: // Or
                    integer3 = (int)(integer1 | integer2);
                    break;
                case 2: // Xor
                    integer3 = (int)(integer1 ^ integer2);
                    break;
                case 3: // Not1
                    integer3 = (int)(~integer1);
                    break;
                case 4: // Not2
                    integer3 = (int)(~integer2);
                    break;
                case 5: // AndAlso
                    integer3 = Convert.ToInt32(Convert.ToBoolean(integer1) && Convert.ToBoolean(integer2));
                    break;
                case 6: // OrElse
                    integer3 = Convert.ToInt32(Convert.ToBoolean(integer1) || Convert.ToBoolean(integer2));
                    break;
                default:
                    break;
            }
            num3.Text = integer3.ToString();
            Label3.Text = $"0x{Convert.ToString(integer3, 16).ToUpper():0000000000000000}";
            txt3.Text = toBitString(integer3, ReverseBits);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="ReverseBits"></param>
        /// <returns></returns>
        public string toBitString(int Value, bool ReverseBits)
        {
            if (!ReverseBits) return $"{Convert.ToString(Value, 2).PadLeft(32, '0'):00000000000000000000000000000000}";
            string retStr = $"{Convert.ToString(Value, 2).PadLeft(32, '0'):00000000000000000000000000000000}";
            char[] retchars = retStr.Reverse().ToArray();
            return new string(retchars);
        }
    }
}
