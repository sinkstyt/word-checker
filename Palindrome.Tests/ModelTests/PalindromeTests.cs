using Microsoft.VisualStudio.TestTools.UnitTesting;
using Characters;

namespace Characters.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_DoesReturnABoolean_True()
    {
      Palindrome test = new Palindrome("racecar");
      Assert.AreEqual(true, test.IsPalindrome(test.NewPalindrome));
    }

    [TestMethod]
    public void IsPalindrome_ChecksForMinimumOfTwoCharactersInAString_True()
    {
      Palindrome test = new Palindrome("aa");
      Assert.AreEqual(true, test.IsPalindrome(test.NewPalindrome));
    }

    [TestMethod]
    public void IsPalindrome_RecognizesWhenFirstAndLastCharsAreSame_True()
    {
      Palindrome again = new Palindrome("arbitrara");
      Assert.AreEqual(true, again.IsPalindrome(again.NewPalindrome));
    }
  }
}