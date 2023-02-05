using Erised.Terminal.Commands;
using FluentAssertions;

namespace Erised.Tests.Terminal.Commands;

public class EnableLineWrapCommandTest
{
    private readonly EnableLineWrapCommand _command;

    public EnableLineWrapCommandTest()
    {
        _command = new();
    }

    [Fact]
    public void WriteAnsi_ShouldDisableLine()
    {
        var writer = new StringWriter();
        _command.WriteAnsi(writer);
        writer.ToString().Should().Be($"{AnsiCodes.CSI}?7h");
    }
}