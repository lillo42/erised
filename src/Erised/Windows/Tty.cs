namespace Erised;

internal static partial class Windows
{
    public static bool IsTty => Console.Input.Mode == 1;
}