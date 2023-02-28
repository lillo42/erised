using System.Runtime.InteropServices;
using Tutu.Exceptions;
using static Tmds.Linux.LibC;

namespace Tutu.Unix2;

public class PlatformException : TutuException 
{
    public PlatformException(int errno) :
        base(GetErrorMessage(errno))
    {
        HResult = errno;
    }

    public PlatformException() :
        this(errno)
    {
    }

    private static unsafe string? GetErrorMessage(int errno)
    {
        const int bufferLength = 1024;
        var buffer = stackalloc byte[bufferLength];

        var rv = strerror_r(errno, buffer, bufferLength);

        return rv == 0 ? Marshal.PtrToStringAnsi((nint)buffer) : $"errno {errno}";
    }

    public static void Throw()
    {
        if (errno < 0)
        {
            throw new PlatformException();
        }
    }
}