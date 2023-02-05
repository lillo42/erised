using Erised.Terminal.Commands;
using FluentAssertions;

namespace Erised.Tests.Terminal.Commands;

public class EnterAlternateScreenCommandTest
{
    private readonly EnterAlternateScreenCommand _command;

    public EnterAlternateScreenCommandTest()
    {
        _command = new();
    }

    [Fact]
    public void WriteAnsi_ShouldEnterAlternate()
    {
        var writer = new StringWriter();
        _command.WriteAnsi(writer);
        writer.ToString().Should().Be($"{AnsiCodes.CSI}?1049h");
    }
}