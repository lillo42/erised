namespace Erised.Terminal.Commands;

/// <summary>
/// A command that sets the terminal title
/// </summary>
/// <param name="Title">The new title.</param>
/// <remarks>
/// * Commands must be executed/queued for execution otherwise they do nothing.
/// </remarks>
public record SetTitleCommand(string Title) : ICommand
{
    public void WriteAnsi(TextWriter write) => write.Write($"{AnsiCodes.ESC}]0;{Title}\x07");

    public void ExecuteWindowsApi() => Windows.Terminal.SetWindowTitle(Title);
}