namespace Erised.Cursor.Commands;

/// <summary>
/// A command that disables blinking of the terminal cursor.
/// </summary>
/// <remarks>
/// - Some Unix terminals (ex: GNOME and Konsole) as well as Windows versions lower than Windows 10 do not support this functionality.
///   Use `SetCursorStyle` for better cross-compatibility.
/// - Commands must be executed/queued for execution otherwise they do nothing.
/// </remarks>
public record DisableBlinkingCursorCommand : ICommand
{
    /// <inheritdoc />
    public void WriteAnsi(TextWriter write)
        => write.Write($"{AnsiCodes.CSI}?12l");

    /// <inheritdoc /> 
    public void ExecuteWindowsApi() { }
}