namespace Erised.Terminal.Commands;

/// <summary>
/// A command that switches back to the main screen.
/// </summary>
/// <remarks>
/// * Commands must be executed/queued for execution otherwise they do nothing.
/// * Use <see cref="EnterAlternateScreenCommand"/> to enter the alternate screen.
/// </remarks>
public record LeaveAlternateScreenCommand : ICommand
{
    public void WriteAnsi(TextWriter write) 
        => write.Write($"{AnsiCodes.CSI}?1049l");

    public void ExecuteWindowsApi()
    {
        var screenBuffer = new Windows.ScreenBuffer(Windows.Handle.CurrentOutHandle()); 
        screenBuffer.Show();
    }
}