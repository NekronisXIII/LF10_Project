using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LF10_Project.Resources.Utils
{
    static class Extensions
    {
		public static string SwapClipboardHtmlText(this string replacementHtmlText)
		{
			string returnHtmlText = String.Empty;
			if (Clipboard.ContainsText(TextDataFormat.Html))
			{
				returnHtmlText = Clipboard.GetText(TextDataFormat.Html);
				Clipboard.SetText(replacementHtmlText, TextDataFormat.Html);
			}
			return returnHtmlText;
		}
	}
}
