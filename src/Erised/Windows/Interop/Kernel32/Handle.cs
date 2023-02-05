using System.Runtime.InteropServices;

namespace Erised;

internal static partial class Windows
{
    public static partial class Interop
    {
        public static partial class Kernel32
        {
            public const uint STD_INPUT_HANDLE = unchecked((uint)-10);
            public const uint STD_OUTPUT_HANDLE = unchecked((uint)-11);
            public const uint STD_ERROR_HANDLE = unchecked((uint)-12);

            [LibraryImport(LibraryName, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static partial bool CloseHandle(nint hObject);

            [LibraryImport(LibraryName, SetLastError = true)]
            public static partial nint GetStdHandle(uint nStdHandle);
        }
    }
}