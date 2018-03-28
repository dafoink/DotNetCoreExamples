using System;
using System.Collections.Generic;
using System.Text;

namespace catalinaTestApplication.Classes
{
	public static class ASCIIArt
	{
		public static string[] CatalinaASCIILogo =		{
			@"  _____       _______       _      _____ _   _",
			@" / ____|   /\|__   __|/\   | |    |_   _| \ | |   /\    ",
			@"| |       /  \  | |  /  \  | |      | | |  \| |  /  \   ",
			@"| |      / /\ \ | | / /\ \ | |      | | | . ` | / /\ \  ",
			@"| |____ / ____ \| |/ ____ \| |____ _| |_| |\  |/ ____ \ ",
			@" \_____/_/    \_\_/_/    \_\______|_____|_| \_/_/    \_\",
			@"",
			@"",
			@"",
			@" _______ ______ _____ _    _ _   _  ____  _      ____   _______     __",
			@"|__   __|  ____/ ____| |  | | \ | |/ __ \| |    / __ \ / ____\ \   / /",
			@"   | |  | |__ | |    | |__| |  \| | |  | | |   | |  | | |  __ \ \_/ /",
			@"   | |  |  __|| |    |  __  | . ` | |  | | |   | |  | | | |_ | \   /",
			@"   | |  | |___| |____| |  | | |\  | |__| | |___| |__| | |__| |  | |",
			@"   |_|  |______\_____|_|  |_|_| \_|\____/|______\____/ \_____|  |_|",
			@""
		};

		public static void PrintCatalina()
		{
			foreach (string s in CatalinaASCIILogo)
			{
				Console.WriteLine(s);
			}
		}
	}
}
