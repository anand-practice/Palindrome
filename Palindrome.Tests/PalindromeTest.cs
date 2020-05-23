
using System;
using NUnit.Framework;

public class PalindromeTest
{
    IPalindromeSut _sut;
    [SetUp]
    public void Initialise()
    {
        _sut = new PalindromeSut();
    }

    [TestCase("hannah", ExpectedResult = true)]
    [TestCase("hanna", ExpectedResult = false)]
    public bool if_string_is_palindrome(string input)
    {
        return _sut.IsStringPalindrome(input);
    }

    [TestCase("hannah is hannah", ExpectedResult = true)]
    [TestCase("hannah is not  hannah", ExpectedResult = false)]
    public bool if_phrase_is_palindrome(string input)
    {
        return _sut.IsPhrasePalindrome(input);
    }

    [Test]
    public void if_string_is_empty()
    {
        Assert.Throws<ArgumentNullException>(() => _sut.IsStringPalindrome(string.Empty));
    }

    [Test]
    public void if_phrase_is_empty()
    {
        Assert.Throws<ArgumentNullException>(() => _sut.IsPhrasePalindrome(string.Empty));
    }

}