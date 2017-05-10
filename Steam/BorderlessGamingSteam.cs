using System;
using Steamworks;

namespace BorderlessGaming.Steam
{
	public static class BorderlessGamingSteam
	{
		public static void Achievement_Unlock(int id)
		{
            if (!Program.Steam_Loaded)
                return;

            // Note: do not .Dispose()
            var manager = new AchievementManager();
            manager.enable();

            if (id == 0)
                manager.UnlockBorderlessAchievement();
		}
	}
}