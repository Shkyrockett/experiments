// <copyright file="BitfieldDemo.cs">
//     Copyright (c) 2013 - 2016 Shkyrockett. All rights reserved.
// </copyright>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <author id="shkyrockett">Shkyrockett</author>
// <summary>An experiment used to figure out best practices for manipulating Bit-fields using properties in C#.</summary>

using System;
using System.ComponentModel;
using System.Globalization;

namespace BitfieldExplorer
{
    /// <summary>
    /// A class to show how to pack boolean values into a bit-field, and use them as properties.
    /// </summary>
    public partial class BitField
        : Component
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool this[BitFlagValues index]
        {
            get { return (EnumBits & index) != 0; }
            set { EnumBits = value ? EnumBits |= index : EnumBits &= ~index; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BitField"/> class.
        /// </summary>
        public BitField()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the binary representation of the bit-field.
        /// </summary>
        /// <remarks>
        /// If a bit value default is changed, the default here also needs to be changed.
        /// </remarks>
        [Category("_Values")]
        [DisplayName("Base 2, Binary")]
        [Description("The binary representation of the bit-field.")]
        [DefaultValue("0b00000000000000000000000000000000")]
        public string Binary
        {
            get { return "0b" + Convert.ToString((uint)EnumBits, 2).PadLeft(32, '0'); }
            set { EnumBits = (BitFlagValues)Convert.ToUInt32(value.Substring(2), 2); }
        }

        /// <summary>
        /// Gets or sets the hex representation of the bit-field.
        /// </summary>
        /// <remarks>
        /// If a bit value default is changed, the default here also needs to be changed.
        /// </remarks>
        [Category("_Values")]
        [DisplayName("Base 16, Hexadecimal")]
        [Description("The hex representation of the bit-field.")]
        [DefaultValue("0x00000000")]
        public string Hexadecimal
        {
            get { return "0x" + EnumBits.ToString("x"); }
            set { EnumBits = (BitFlagValues)uint.Parse(value, NumberStyles.AllowHexSpecifier | NumberStyles.HexNumber); }
        }

        /// <summary>
        /// Gets or sets the octal representation of the bit-field.
        /// </summary>
        /// <remarks>
        /// If a bit value default is changed, the default here also needs to be changed.
        /// </remarks>
        [Category("_Values")]
        [DisplayName("Base 8, Octal")]
        [Description("The octal representation of the bit-field.")]
        [DefaultValue("0o00000000000")]
        public string Octal
        {
            get { return "0o" + Convert.ToString((uint)EnumBits, 8).PadLeft(11, '0'); }
            set { EnumBits = (BitFlagValues)Convert.ToUInt32(value.Substring(2), 8); }
        }

        /// <summary>
        /// Gets or sets the decimal representation of the bit-field.
        /// </summary>
        /// <remarks>
        /// If a bit value default is changed, the default here also needs to be changed.
        /// </remarks>
        [Category("_Values")]
        [DisplayName("Base 10, Decimal")]
        [Description("The decimal representation of the bit-field.")]
        [DefaultValue("0d0000000000")]
        public string Decimal
        {
            get { return "0d" + Convert.ToString((uint)EnumBits, 10).PadLeft(10, '0'); }
            set { EnumBits = (BitFlagValues)Convert.ToUInt32(value.Substring(2), 10); }
        }

        /// <summary>
        /// Gets or sets the enum representation of the bit-field.
        /// </summary>
        [Category("_Values")]
        [DisplayName("Enumeration Values")]
        [Description("The enum representation of the bit-field.")]
        [DefaultValue(BitFlagValues.Default)]
        public BitFlagValues EnumBits { get; set; } = BitFlagValues.Default;

        /// <summary>
        /// Gets or sets a value indicating whether the first bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 01")]
        [Description("A value indicating whether the first bit has been set.")]
        [DefaultValue(false)]
        public bool Bit01
        {
            get { return (EnumBits & BitFlagValues.Bit01) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit01 : EnumBits &= ~BitFlagValues.Bit01; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the second bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 02")]
        [Description("A value indicating whether the second bit has been set.")]
        [DefaultValue(false)]
        public bool Bit02
        {
            get { return (EnumBits & BitFlagValues.Bit02) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit02 : EnumBits &= ~BitFlagValues.Bit02; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the third bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 03")]
        [Description("A value indicating whether the third bit has been set.")]
        [DefaultValue(false)]
        public bool Bit03
        {
            get { return (EnumBits & BitFlagValues.Bit03) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit03 : EnumBits &= ~BitFlagValues.Bit03; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the fourth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 04")]
        [Description("A value indicating whether the fourth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit04
        {
            get { return (EnumBits & BitFlagValues.Bit04) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit04 : EnumBits &= ~BitFlagValues.Bit04; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the fifth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 05")]
        [Description("A value indicating whether the fifth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit05
        {
            get { return (EnumBits & BitFlagValues.Bit05) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit05 : EnumBits &= ~BitFlagValues.Bit05; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the sixth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 06")]
        [Description("A value indicating whether the sixth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit06
        {
            get { return (EnumBits & BitFlagValues.Bit06) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit06 : EnumBits &= ~BitFlagValues.Bit06; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the seventh bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 07")]
        [Description("A value indicating whether the seventh bit has been set.")]
        [DefaultValue(false)]
        public bool Bit07
        {
            get { return (EnumBits & BitFlagValues.Bit07) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit07 : EnumBits &= ~BitFlagValues.Bit07; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the eighth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 08")]
        [Description("A value indicating whether the eighth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit08
        {
            get { return (EnumBits & BitFlagValues.Bit08) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit08 : EnumBits &= ~BitFlagValues.Bit08; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the ninth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 09")]
        [Description("A value indicating whether the ninth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit09
        {
            get { return (EnumBits & BitFlagValues.Bit09) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit09 : EnumBits &= ~BitFlagValues.Bit09; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the tenth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 10")]
        [Description("A value indicating whether the tenth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit10
        {
            get { return (EnumBits & BitFlagValues.Bit10) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit10 : EnumBits &= ~BitFlagValues.Bit10; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the eleventh bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 11")]
        [Description("A value indicating whether the eleventh bit has been set.")]
        [DefaultValue(false)]
        public bool Bit11
        {
            get { return (EnumBits & BitFlagValues.Bit11) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit11 : EnumBits &= ~BitFlagValues.Bit11; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twelfth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 12")]
        [Description("A value indicating whether the twelfth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit12
        {
            get { return (EnumBits & BitFlagValues.Bit12) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit12 : EnumBits &= ~BitFlagValues.Bit12; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the thirteenth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 13")]
        [Description("A value indicating whether the thirteenth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit13
        {
            get { return (EnumBits & BitFlagValues.Bit13) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit13 : EnumBits &= ~BitFlagValues.Bit13; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the fourteenth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 14")]
        [Description("A value indicating whether the fourteenth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit14
        {
            get { return (EnumBits & BitFlagValues.Bit14) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit14 : EnumBits &= ~BitFlagValues.Bit14; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the fifteenth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 15")]
        [Description("A value indicating whether the fifteenth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit15
        {
            get { return (EnumBits & BitFlagValues.Bit15) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit15 : EnumBits &= ~BitFlagValues.Bit15; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the sixteenth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 16")]
        [Description("A value indicating whether the sixteenth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit16
        {
            get { return (EnumBits & BitFlagValues.Bit16) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit16 : EnumBits &= ~BitFlagValues.Bit16; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the seventeenth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 17")]
        [Description("A value indicating whether the seventeenth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit17
        {
            get { return (EnumBits & BitFlagValues.Bit17) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit17 : EnumBits &= ~BitFlagValues.Bit17; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the eighteenth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 18")]
        [Description("A value indicating whether the eighteenth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit18
        {
            get { return (EnumBits & BitFlagValues.Bit18) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit18 : EnumBits &= ~BitFlagValues.Bit18; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the nineteenth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 19")]
        [Description("A value indicating whether the nineteenth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit19
        {
            get { return (EnumBits & BitFlagValues.Bit19) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit19 : EnumBits &= ~BitFlagValues.Bit19; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twentieth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 20")]
        [Description("A value indicating whether the twentieth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit20
        {
            get { return (EnumBits & BitFlagValues.Bit20) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit20 : EnumBits &= ~BitFlagValues.Bit20; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twenty-first bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 21")]
        [Description("A value indicating whether the twenty-first bit has been set.")]
        [DefaultValue(false)]
        public bool Bit21
        {
            get { return (EnumBits & BitFlagValues.Bit21) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit21 : EnumBits &= ~BitFlagValues.Bit21; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twenty-second bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 22")]
        [Description("A value indicating whether the twenty-second bit has been set.")]
        [DefaultValue(false)]
        public bool Bit22
        {
            get { return (EnumBits & BitFlagValues.Bit22) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit22 : EnumBits &= ~BitFlagValues.Bit22; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twenty-second bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 23")]
        [Description("A value indicating whether the twenty-second bit has been set.")]
        [DefaultValue(false)]
        public bool Bit23
        {
            get { return (EnumBits & BitFlagValues.Bit23) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit23 : EnumBits &= ~BitFlagValues.Bit23; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twenty-fourth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 24")]
        [Description("A value indicating whether the twenty-fourth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit24
        {
            get { return (EnumBits & BitFlagValues.Bit24) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit24 : EnumBits &= ~BitFlagValues.Bit24; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twenty-fifth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 25")]
        [Description("A value indicating whether the twenty-fifth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit25
        {
            get { return (EnumBits & BitFlagValues.Bit25) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit25 : EnumBits &= ~BitFlagValues.Bit25; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twenty-sixth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 26")]
        [Description("A value indicating whether the twenty-sixth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit26
        {
            get { return (EnumBits & BitFlagValues.Bit26) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit26 : EnumBits &= ~BitFlagValues.Bit26; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twenty-seventh bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 27")]
        [Description("A value indicating whether the twenty-seventh bit has been set.")]
        [DefaultValue(false)]
        public bool Bit27
        {
            get { return (EnumBits & BitFlagValues.Bit27) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit27 : EnumBits &= ~BitFlagValues.Bit27; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twenty-eighth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 28")]
        [Description("A value indicating whether the twenty-eighth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit28
        {
            get { return (EnumBits & BitFlagValues.Bit28) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit28 : EnumBits &= ~BitFlagValues.Bit28; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the twenty-ninth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 29")]
        [Description("A value indicating whether the twenty-ninth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit29
        {
            get { return (EnumBits & BitFlagValues.Bit29) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit29 : EnumBits &= ~BitFlagValues.Bit29; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the thirtieth bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 30")]
        [Description("A value indicating whether the thirtieth bit has been set.")]
        [DefaultValue(false)]
        public bool Bit30
        {
            get { return (EnumBits & BitFlagValues.Bit30) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit30 : EnumBits &= ~BitFlagValues.Bit30; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the thirty-first bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 31")]
        [Description("A value indicating whether the thirty-first bit has been set.")]
        [DefaultValue(false)]
        public bool Bit31
        {
            get { return (EnumBits & BitFlagValues.Bit31) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit31 : EnumBits &= ~BitFlagValues.Bit31; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the thirty-second bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 32")]
        [Description("A value indicating whether the thirty-second bit has been set.")]
        [DefaultValue(false)]
        public bool Bit32
        {
            get { return (EnumBits & BitFlagValues.Bit32) != 0; }
            set { EnumBits = value ? EnumBits |= BitFlagValues.Bit32 : EnumBits &= ~BitFlagValues.Bit32; }
        }

        /// <summary>
        /// Helper function used to set and reset bits in the publicOptions bit-field.
        /// </summary>
        private void SetOptionField(BitFlagValues mask, bool value)
        {
            EnumBits = value ? EnumBits |= mask : EnumBits &= ~mask;
        }
    }
}
