using Xunit;

public class Tests {

    [Fact]
    public void TestCheckLetter()
    {
        Program.answer = "lemon";
        int answer = Program.checkLetter(Program.answer[0], 0);

        Assert.Equal(1, answer);

        answer = Program.checkLetter(Program.answer[0], 4);

        Assert.Equal(2, answer);

        answer = Program.checkLetter('x', 0);

        Assert.Equal(0, answer);
    }
}