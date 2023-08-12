global using Microsoft.Xna.Framework;
global using Microsoft.Xna.Framework.Graphics;
global using System;
global using Terraria;
global using Terraria.ModLoader;

namespace FunnyExperienceLeaderboards
{
	public class FunnyExperienceLeaderboards : Mod
	{
		public static FunnyExperienceLeaderboards Instance;
		public static string ModName = "FunnyExperienceLeaderboards";
		public const bool Release = false;

		public FunnyExperienceLeaderboards()
		{
			Instance = this;
		}
	}
}