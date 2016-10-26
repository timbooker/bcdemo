using System;
using System.Text.RegularExpressions;

namespace prebcdemo
{
	public static class HtmlHelper
	{
		public static string StripHtml(this string value)
		{
			var step1 = Regex.Replace(value ?? string.Empty, @"<[^>]+>|&nbsp;", "").Trim();
			var step2 = Regex.Replace(step1 ?? string.Empty, @"\s{2,}", " ");

			return step2;
		}
	}
}

