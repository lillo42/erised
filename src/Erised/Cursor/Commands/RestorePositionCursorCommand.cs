namespace Erised.Cursor.Commands;

/// <summary>
/// A command that restores the saved terminal cursor position.
/// </summary>
/// <remarks>
/// - The cursor position is stored globally.
/// - Commands must be executed/queued for execution otherwise they do nothing.
/// </remarks>
public record RestorePositionCursorCommand : ICommand
{
    public void WriteAnsi(TextWriter write)
        => write.Write($"{AnsiCodes.ESC}8");

    public void ExecuteWindowsApi() => Windows.RestorePosition();
}