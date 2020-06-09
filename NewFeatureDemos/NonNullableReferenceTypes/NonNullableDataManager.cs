using System.IO.Enumeration;

namespace NonNullableReferenceTypes
{
    public class NonNullableDataManager
    {
        private string Filename { get; }

        private int MaxFileSize { get; }

        private string Folder { get; }

        public NonNullableDataManager(string filename, int maxFileSize, string? folder)
        {
            Filename = filename;
            MaxFileSize = maxFileSize;
            Folder = folder ?? "Default";
        }
    }
}