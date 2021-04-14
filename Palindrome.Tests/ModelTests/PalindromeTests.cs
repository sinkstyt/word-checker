using Microsoft.VisualStudio.TestTools.UnitTesting;
using Characters;

namespace Characters.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_ChecksForOneOrMoreCharactersInExampleString_True()
    {
      Palindrome test = new Palindrome("racecar");
      Assert.AreEqual(true, test.IsPalindrome());
    }
  }
}