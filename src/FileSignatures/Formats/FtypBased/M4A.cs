namespace FileSignatures.Formats.FtypBased
{
    /// <summary>
    /// Specifies the format of a Apple Lossless Audio Codec file
    /// </summary>
    public class M4A : Mp4
    {
        /// <summary>
        /// ASCII: `M4A `
        /// </summary>
        private static readonly byte[] M4ASig = { 0x4D, 0x34, 0x41, 0x20 };

        public M4A() : base(M4ASig, "m4a")
        {
        }
    }
}
