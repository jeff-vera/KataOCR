using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataBank_Ocr_Story1
{
	class Entry
	{
		public Entry(List<string> input)
		{
			Input = input;
		}

		public bool IsValidEntry
		{
			get
			{
				bool isValid = true;

				if (Input.Count != 4)
				{
					return false;
				}
				if (Input[3].Trim().Length != 0)
				{
					return false;
				}
				foreach (string line in Input)
				{
					if (line.Length != 27)
					{
						return false;
					}
				}

				return isValid;
			}
		}
		public List<string> Input { get; private set; }

		public List<AccountDigit> AccountNumberAsText {
			get
			{
				List<AccountDigit> accountNumber = new List<AccountDigit>();
				if (!IsValidEntry)
				{
					return accountNumber;
				}
				else
				{
					for (int i = 0; i < 9; ++i)
					{
						AccountDigit currentDigit = new AccountDigit();
						currentDigit.Add(Input[0].Substring(i * 3, 3));
						currentDigit.Add(Input[1].Substring(i * 3, 3));
						currentDigit.Add(Input[2].Substring(i * 3, 3));
						accountNumber.Add(currentDigit);
					}

					return accountNumber;
				}

			}
		}
	}
}
