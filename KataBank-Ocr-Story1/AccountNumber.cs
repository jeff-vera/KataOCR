using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataBank_Ocr_Story1
{
	public class AccountDigit : List<string>
	{
		private Dictionary<string, int> _textToIntegerConversions;

		public AccountDigit()
		{
			_textToIntegerConversions = new Dictionary<string, int> 
			{
				{"     |  |", 1},
				{" _  _||_ ", 2},
				{" _  _| _|", 3},
				{"   |_|  |", 4},
				{" _ |_  _|", 5},
				{" _ |_ |_|", 6},
				{" _   |  |", 7},
				{" _ |_||_|", 8},
				{" _ |_| _|", 9}				
			};
		}

		public bool IsValidAccountNumber
		{
			get
			{
				if (Count != 3)
				{
					return false;
				}

				return true;
			}
		}


		public int DigitAsInteger {
			get
			{
				StringBuilder sb = new StringBuilder();
				foreach (string s in this)
				{
					sb.Append(s);
				}

				if (_textToIntegerConversions.ContainsKey(sb.ToString()))
				{
					return _textToIntegerConversions[sb.ToString()];
				}
				else
				{
					return -1;
				}
					
			}
		}
	}
}
