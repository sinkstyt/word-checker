namespace Characters
{
  public class Palindrome
  {
    public string NewPalindrome;

    public Palindrome (string aPalindrome) 
    {
      NewPalindrome = aPalindrome;
    }

    public bool IsPalindrome(string test)
    {
      if (test.Length >= 1)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  }
}