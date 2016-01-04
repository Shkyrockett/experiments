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
using System.Windows.Forms;

namespace BitfieldDemo
{
    /// <summary>
    /// Bit Flag values that can be used in the bit-field.
    /// </summary>
    [Flags]
    public enum BitFlagValues
        : uint
    {
        /// <summary>
        /// The default set of bit values to use.
        /// </summary>
        /// <remarks>
        /// <para>If you set a property with a default value then the initialized value also needs to be set with that default value. </para>
        /// <para>If two enum members with Browsable(false) and EditorBrowsable(EditorBrowsableState.Never) meta-data 
        /// have the same value, the first will be the one to take on the meta-data and the second will show up in the <see cref="PropertyGrid"/>. </para>
        /// <para>If the value is 0, it will show up in the list for all other members as well, for some reason.</para>
        /// </remarks>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ListBindable(BindableSupport.No)]
        Default = None,

        /// <summary>
        /// No bits have been set.
        /// </summary>
        None = 0x00000000,

        /// <summary>
        /// First bit.
        /// </summary>
        Bit01 = 0x00000001,

        /// <summary>
        /// Second bit.
        /// </summary>
        Bit02 = 0x00000002,

        /// <summary>
        /// Third bit.
        /// </summary>
        Bit03 = 0x00000004,

        /// <summary>
        /// Fourth bit.
        /// </summary>
        Bit04 = 0x00000008,

        /// <summary>
        /// Fifth bit.
        /// </summary>
        Bit05 = 0x00000010,

        /// <summary>
        /// Sixth bit.
        /// </summary>
        Bit06 = 0x00000020,

        /// <summary>
        /// Seventh bit.
        /// </summary>
        Bit07 = 0x00000040,

        /// <summary>
        /// Eighth bit.
        /// </summary>
        Bit08 = 0x00000080,

        /// <summary>
        /// Ninth bit.
        /// </summary>
        Bit09 = 0x00000100,

        /// <summary>
        /// Tenth bit.
        /// </summary>
        Bit10 = 0x00000200,

        /// <summary>
        /// Eleventh bit.
        /// </summary>
        Bit11 = 0x00000400,

        /// <summary>
        /// Twelfth bit.
        /// </summary>
        Bit12 = 0x00000800,

        /// <summary>
        /// Thirteenth bit.
        /// </summary>
        Bit13 = 0x00001000,

        /// <summary>
        /// Fourteenth bit.
        /// </summary>
        Bit14 = 0x00002000,

        /// <summary>
        /// Fifteenth bit.
        /// </summary>
        Bit15 = 0x00004000,

        /// <summary>
        /// Sixteenth bit.
        /// </summary>
        Bit16 = 0x00008000,

        /// <summary>
        /// Seventeenth bit.
        /// </summary>
        Bit17 = 0x00010000,

        /// <summary>
        /// Eighteenth bit.
        /// </summary>
        Bit18 = 0x00020000,

        /// <summary>
        /// Nineteenth bit.
        /// </summary>
        Bit19 = 0x00040000,

        /// <summary>
        /// Twentieth bit.
        /// </summary>
        Bit20 = 0x00080000,

        /// <summary>
        /// Twenty-first bit.
        /// </summary>
        Bit21 = 0x00100000,

        /// <summary>
        /// Twenty-first bit.
        /// </summary>
        Bit22 = 0x00200000,

        /// <summary>
        /// Twenty-third bit.
        /// </summary>
        Bit23 = 0x00400000,

        /// <summary>
        /// Twenty-fourth bit.
        /// </summary>
        Bit24 = 0x00800000,

        /// <summary>
        /// Twenty-fifth bit.
        /// </summary>
        Bit25 = 0x01000000,

        /// <summary>
        /// Twenty-sixth bit.
        /// </summary>
        Bit26 = 0x02000000,

        /// <summary>
        /// Twenty-seventh bit.
        /// </summary>
        Bit27 = 0x04000000,

        /// <summary>
        /// Twenty-seventh bit.
        /// </summary>
        Bit28 = 0x08000000,

        /// <summary>
        /// Twenty-ninth bit.
        /// </summary>
        Bit29 = 0x10000000,

        /// <summary>
        /// Thirtieth bit.
        /// </summary>
        Bit30 = 0x20000000,

        /// <summary>
        /// Thirty-first bit.
        /// </summary>
        Bit31 = 0x40000000,

        /// <summary>
        /// Thirty-second bit.
        /// </summary>
        Bit32 = 0x80000000,

        /// <summary>
        /// Composite value of all of the odd numbered bit values
        /// </summary>
        /// <remarks>
        /// Anytime a new odd value is added/removed, it needs to also be changed here as well.
        /// </remarks>
        Odds =
            Bit01 | Bit03 | Bit05 | Bit07 |
            Bit09 | Bit11 | Bit13 | Bit15 |
            Bit17 | Bit19 | Bit21 | Bit23 |
            Bit25 | Bit27 | Bit29 | Bit31,

        /// <summary>
        /// Composite value of all of the even numbered bit values.
        /// </summary>
        /// <remarks>
        /// Anytime a new even value is added/removed, it needs to also be changed here as well.
        /// </remarks>
        Evens =
            Bit02 | Bit04 | Bit06 | Bit08 |
            Bit10 | Bit12 | Bit14 | Bit16 |
            Bit18 | Bit20 | Bit22 | Bit24 |
            Bit26 | Bit28 | Bit30 | Bit32,

        /// <summary>
        /// Composite value of all of the available bit values.
        /// </summary>
        /// <remarks>
        /// As long as <see cref="Odds"/>, and <see cref="Evens"/> are kept up to date, this should also be up to date.
        /// </remarks>
        All = None | Odds | Evens,
    }

    /// <summary>
    /// A class to show how to pack boolean values into a bit-field, and use them as properties.
    /// </summary>
    public partial class BitField
        : Component
    {
        /// <summary>
        /// The 32-bit field used to store boolean values as bits.
        /// </summary>
        /// <remarks>
        /// If you set a property with a default value, the initialized value also needs to be set to the default value.
        /// </remarks>
        private BitFlagValues bits = BitFlagValues.Default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool this[BitFlagValues index]
        {
            get { return (bits & index) != 0; }
            set { bits = value ? bits |= index : bits &= ~index; }
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
            get { return "0b" + Convert.ToString((uint)bits, 2).PadLeft(32, '0'); }
            set { bits = (BitFlagValues)Convert.ToUInt32(value.Substring(2), 2); }
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
            get { return "0x" + bits.ToString("x"); }
            set { bits = (BitFlagValues)uint.Parse(value, NumberStyles.AllowHexSpecifier | NumberStyles.HexNumber); }
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
            get { return "0o" + Convert.ToString((uint)bits, 8).PadLeft(11, '0'); }
            set { bits = (BitFlagValues)Convert.ToUInt32(value.Substring(2), 8); }
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
            get { return "0d" + Convert.ToString((uint)bits, 10).PadLeft(10, '0'); }
            set { bits = (BitFlagValues)Convert.ToUInt32(value.Substring(2), 10); }
        }

        /// <summary>
        /// Gets or sets the enum representation of the bit-field.
        /// </summary>
        [Category("_Values")]
        [DisplayName("Enumeration Values")]
        [Description("The enum representation of the bit-field.")]
        [DefaultValue(BitFlagValues.Default)]
        public BitFlagValues EnumBits
        {
            get { return bits; }
            set { bits = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the first bit has been set. 
        /// </summary>
        [Category("Bits")]
        [DisplayName("Bit 01")]
        [Description("A value indicating whether the first bit has been set.")]
        [DefaultValue(false)]
        public bool Bit01
        {
            get { return (bits & BitFlagValues.Bit01) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit01 : bits &= ~BitFlagValues.Bit01; }
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
            get { return (bits & BitFlagValues.Bit02) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit02 : bits &= ~BitFlagValues.Bit02; }
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
            get { return (bits & BitFlagValues.Bit03) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit03 : bits &= ~BitFlagValues.Bit03; }
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
            get { return (bits & BitFlagValues.Bit04) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit04 : bits &= ~BitFlagValues.Bit04; }
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
            get { return (bits & BitFlagValues.Bit05) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit05 : bits &= ~BitFlagValues.Bit05; }
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
            get { return (bits & BitFlagValues.Bit06) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit06 : bits &= ~BitFlagValues.Bit06; }
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
            get { return (bits & BitFlagValues.Bit07) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit07 : bits &= ~BitFlagValues.Bit07; }
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
            get { return (bits & BitFlagValues.Bit08) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit08 : bits &= ~BitFlagValues.Bit08; }
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
            get { return (bits & BitFlagValues.Bit09) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit09 : bits &= ~BitFlagValues.Bit09; }
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
            get { return (bits & BitFlagValues.Bit10) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit10 : bits &= ~BitFlagValues.Bit10; }
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
            get { return (bits & BitFlagValues.Bit11) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit11 : bits &= ~BitFlagValues.Bit11; }
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
            get { return (bits & BitFlagValues.Bit12) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit12 : bits &= ~BitFlagValues.Bit12; }
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
            get { return (bits & BitFlagValues.Bit13) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit13 : bits &= ~BitFlagValues.Bit13; }
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
            get { return (bits & BitFlagValues.Bit14) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit14 : bits &= ~BitFlagValues.Bit14; }
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
            get { return (bits & BitFlagValues.Bit15) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit15 : bits &= ~BitFlagValues.Bit15; }
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
            get { return (bits & BitFlagValues.Bit16) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit16 : bits &= ~BitFlagValues.Bit16; }
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
            get { return (bits & BitFlagValues.Bit17) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit17 : bits &= ~BitFlagValues.Bit17; }
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
            get { return (bits & BitFlagValues.Bit18) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit18 : bits &= ~BitFlagValues.Bit18; }
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
            get { return (bits & BitFlagValues.Bit19) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit19 : bits &= ~BitFlagValues.Bit19; }
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
            get { return (bits & BitFlagValues.Bit20) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit20 : bits &= ~BitFlagValues.Bit20; }
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
            get { return (bits & BitFlagValues.Bit21) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit21 : bits &= ~BitFlagValues.Bit21; }
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
            get { return (bits & BitFlagValues.Bit22) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit22 : bits &= ~BitFlagValues.Bit22; }
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
            get { return (bits & BitFlagValues.Bit23) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit23 : bits &= ~BitFlagValues.Bit23; }
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
            get { return (bits & BitFlagValues.Bit24) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit24 : bits &= ~BitFlagValues.Bit24; }
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
            get { return (bits & BitFlagValues.Bit25) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit25 : bits &= ~BitFlagValues.Bit25; }
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
            get { return (bits & BitFlagValues.Bit26) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit26 : bits &= ~BitFlagValues.Bit26; }
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
            get { return (bits & BitFlagValues.Bit27) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit27 : bits &= ~BitFlagValues.Bit27; }
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
            get { return (bits & BitFlagValues.Bit28) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit28 : bits &= ~BitFlagValues.Bit28; }
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
            get { return (bits & BitFlagValues.Bit29) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit29 : bits &= ~BitFlagValues.Bit29; }
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
            get { return (bits & BitFlagValues.Bit30) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit30 : bits &= ~BitFlagValues.Bit30; }
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
            get { return (bits & BitFlagValues.Bit31) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit31 : bits &= ~BitFlagValues.Bit31; }
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
            get { return (bits & BitFlagValues.Bit32) != 0; }
            set { bits = value ? bits |= BitFlagValues.Bit32 : bits &= ~BitFlagValues.Bit32; }
        }

        /// <summary>
        /// Helper function used to set and reset bits in the publicOptions bit-field.
        /// </summary>
        private void SetOptionField(BitFlagValues mask, bool value)
        {
            bits = value ? bits |= mask : bits &= ~mask;
        }
    }
}
