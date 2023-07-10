using System.Text;

namespace Codewars.Break_camelCase;

public static class BreakCamelCase
{
	public static string Execute(string str)
	{
		var sb = new StringBuilder();
		foreach (var c in str)
		{
			if (IsNewWordStart(c))
			{
				sb.Append(' ');
			}

			sb.Append(c);
		}
		return sb.ToString();
		
		bool IsNewWordStart(char c)
		{
			return char.IsUpper(c);
		}
	}
}