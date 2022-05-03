using ArrayAndHashing.Main.Validanagram;
using FluentAssertions;
using NUnit.Framework;

namespace testCases
{
  public class ValidAnagram_Test
  {
     
   [Test]
    public void Test_Example_1()
    {
      // Arrange
      string s = "anagram";
      string t = "nagaram";

      // Act
      Solution solution = new Solution();
      bool testResult = solution.IsAnagram(s,t);

      // Assert
      testResult.Should().Be(true);
    }
  }
}