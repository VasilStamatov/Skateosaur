[System.Serializable]
public class SavedStats
{
		/*
			* the top 10 high scores
			*/
		public ushort[] highScores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

		/*
			* the unlocked levels (1 to 7)
			*/
		public byte unlockedLevels = 1;
}
