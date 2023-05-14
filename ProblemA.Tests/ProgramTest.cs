using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ProblemA.Tests;

public class ProgramTest
{
    [Fact]
    public void CompactName_ShouldReplaceConsecutiveLetters()
    {
        // Arrange
        string name = "bbbooobbb";
        string expectedCompactName = "bob";

        // Act
        string compactName = Program.CompactName(name);

        // Assert
        Assert.Equal(expectedCompactName, compactName);
    }

}