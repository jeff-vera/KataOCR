using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataBank_Ocr_Story1
{
	[TestFixture]
	public class AccountDigitTests
	{
		[Test]
		public void ValidAccountNumberHasThreeTextLinesTest()
		{
			AccountDigit a = new AccountDigit();
			a.Add("");
			a.Add("");
			a.Add("");

			bool isValid = a.IsValidAccountNumber;

			Assert.That(isValid, Is.True);
		}

		[Test]
		public void AccountNumberWithMoreThanThreeTextLinesInvalidTest()
		{
			AccountDigit a = new AccountDigit();
			a.Add("");
			a.Add("");
			a.Add("");
			a.Add("");

			bool isValid = a.IsValidAccountNumber;

			Assert.That(isValid, Is.False);
		}

		[Test]
		public void CanDetermineIfDigitIs1Test()
		{
			AccountDigit a = new AccountDigit {
						 "   ",
						 "  |",
						 "  |"
			};

			int digitAsInteger = a.DigitAsInteger;

			Assert.That(a.IsValidAccountNumber);
			Assert.That(digitAsInteger, Is.EqualTo(1));
		}

		[Test]
		public void CanDetermineIfDigitIs2Test()
		{
			AccountDigit a = new AccountDigit {
						 " _ ",
						 " _|",
						 "|_ "
			};

			int digitAsInteger = a.DigitAsInteger;

			Assert.That(a.IsValidAccountNumber);
			Assert.That(digitAsInteger, Is.EqualTo(2));
		}

		[Test]
		public void CanDetermineIfDigitIs3Test()
		{
			AccountDigit a = new AccountDigit {
						 " _ ",
						 " _|",
						 " _|"
			};

			int digitAsInteger = a.DigitAsInteger;

			Assert.That(a.IsValidAccountNumber);
			Assert.That(digitAsInteger, Is.EqualTo(3));
		}

		[Test]
		public void CanDetermineIfDigitIs4Test()
		{
			AccountDigit a = new AccountDigit {
						 "   ",
						 "|_|",
						 "  |"
			};

			int digitAsInteger = a.DigitAsInteger;

			Assert.That(a.IsValidAccountNumber);
			Assert.That(digitAsInteger, Is.EqualTo(4));
		}

		[Test]
		public void CanDetermineIfDigitIs5Test()
		{
			AccountDigit a = new AccountDigit {
						 " _ ",
						 "|_ ",
						 " _|"
			};

			int digitAsInteger = a.DigitAsInteger;

			Assert.That(a.IsValidAccountNumber);
			Assert.That(digitAsInteger, Is.EqualTo(5));
		}

		[Test]
		public void CanDetermineIfDigitIs6Test()
		{
			AccountDigit a = new AccountDigit {
						 " _ ",
						 "|_ ",
						 "|_|"
			};

			int digitAsInteger = a.DigitAsInteger;

			Assert.That(a.IsValidAccountNumber);
			Assert.That(digitAsInteger, Is.EqualTo(6));
		}

		[Test]
		public void CanDetermineIfDigitIs7Test()
		{
			AccountDigit a = new AccountDigit {
						 " _ ",
						 "  |",
						 "  |"
			};

			int digitAsInteger = a.DigitAsInteger;

			Assert.That(a.IsValidAccountNumber);
			Assert.That(digitAsInteger, Is.EqualTo(7));
		}

		[Test]
		public void CanDetermineIfDigitIs8Test()
		{
			AccountDigit a = new AccountDigit {
						 " _ ",
						 "|_|",
						 "|_|"
			};

			int digitAsInteger = a.DigitAsInteger;

			Assert.That(a.IsValidAccountNumber);
			Assert.That(digitAsInteger, Is.EqualTo(8));
		}

		[Test]
		public void CanDetermineIfDigitIs9Test()
		{
			AccountDigit a = new AccountDigit {
						 " _ ",
						 "|_|",
						 " _|"
			};

			int digitAsInteger = a.DigitAsInteger;

			Assert.That(a.IsValidAccountNumber);
			Assert.That(digitAsInteger, Is.EqualTo(9));
		}

	}
}
