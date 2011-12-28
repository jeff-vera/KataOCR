using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataBank_Ocr_Story1
{
	[TestFixture]
	public class EntryTests
	{
		private List<string> _validInput;

		[TestFixtureSetUp]
		public void TestSetup()
		{
			_validInput = new List<string>
			{
				new String(' ', 27),
				new String(' ', 27),
				new String(' ', 27),
				new String(' ', 27)
			};
		}

		[Test]
		public void ValidEntryHasFourLinesTest()
		{
			Entry e = new Entry(_validInput);

			Assert.That(e.IsValidEntry, Is.True);
		}

		[Test]
		public void EntryWithLinesOtherThanFourIsInvalidTest()
		{
			List<string> invalidInput = new List<string>();
			Entry e = new Entry(invalidInput);

			Assert.That(e.IsValidEntry, Is.False);
		}

		[Test]
		public void ValidEntryHasBlankFourthLineTest()
		{
			Entry e = new Entry(_validInput);

			Assert.That(e.IsValidEntry, Is.True);
		}

		[Test]
		public void EntryWithUnblankFourthLineIsInvalidTest()
		{
			List<string> invalidInput = new List<string>
			{
				"uh",
				"yeah",
				"here",
				"ohno"
			};
			Entry e = new Entry(invalidInput);

			Assert.That(e.IsValidEntry, Is.False);			
		}

		[Test]
		public void ValidEntryHasAllLinesOf27CharactersTest()
		{
			Entry e = new Entry(_validInput);

			Assert.That(e.IsValidEntry, Is.True);
		}

		[Test]
		public void EntryWithOneOrMoreLinesNot27CharactersIsInvalidTest()
		{
			List<string> invalidInput = new List<string>
			{
				new String(' ', 27),
				new String(' ', 26),
				new String(' ', 27),
				new String(' ', 27)
			};
			Entry e = new Entry(invalidInput);

			Assert.That(e.IsValidEntry, Is.False);
		}

		[Test]
		public void CanParseOutNineAccountNumbersFromValidEntryTest()
		{
			Entry e = new Entry(_validInput);

			List<AccountDigit> accountNumber = e.AccountNumberAsText;

			Assert.That(accountNumber, Is.Not.Null);
			Assert.That(accountNumber.Count, Is.EqualTo(9));
		}

		[Test]
		public void InvalidEntryReturnsEmptyAccountNumberListTest()
		{
			Entry e = new Entry(new List<string>());

			List<AccountDigit> accountNumber = e.AccountNumberAsText;

			Assert.That(e.IsValidEntry, Is.False);
			Assert.That(accountNumber, Is.Not.Null);
			Assert.That(accountNumber.Count, Is.EqualTo(0));
		}
	}
}
