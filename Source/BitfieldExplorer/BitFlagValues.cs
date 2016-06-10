using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BitfieldExplorer
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
              Bit01 | Bit03 | Bit05 | Bit07
            | Bit09 | Bit11 | Bit13 | Bit15
            | Bit17 | Bit19 | Bit21 | Bit23
            | Bit25 | Bit27 | Bit29 | Bit31,

        /// <summary>
        /// Composite value of all of the even numbered bit values.
        /// </summary>
        /// <remarks>
        /// Anytime a new even value is added/removed, it needs to also be changed here as well.
        /// </remarks>
        Evens =
              Bit02 | Bit04 | Bit06 | Bit08
            | Bit10 | Bit12 | Bit14 | Bit16
            | Bit18 | Bit20 | Bit22 | Bit24
            | Bit26 | Bit28 | Bit30 | Bit32,

        /// <summary>
        /// Composite value of all of the available bit values.
        /// </summary>
        /// <remarks>
        /// As long as <see cref="Odds"/>, and <see cref="Evens"/> are kept up to date, this should also be up to date.
        /// </remarks>
        All = None | Odds | Evens,
    }
}
