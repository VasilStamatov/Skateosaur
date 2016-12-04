using UnityEngine;

/*
 * singleton class for the container of global variables for the game stats
 */
public class GlobalControl : MonoBehaviour
{
		/*
			* the single instance of the class
			*/
		public static GlobalControl Instance;

		/*
			* the top 10 high scores
			*/
		public ushort[] highScores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

		/*
			* the unlocked levels (1 to 7)
			*/
		public byte unlockedLevels = 1;

		/*
			* the unlocked characters (1 to x)
			*/
		public byte unlockedCharacters = 1;

		/*
			* the level that was played (to be used in retry function)
			*/
		public string levelPlayed = "";

		/*
			* the time the played survived in the previous level (for endgame scene)
			*/
		public ushort timeSurvived = 0;

		void Awake()
		{
				/*
					* check if an instance already exists
					*/
				if (Instance == null)
				{
						/*
						 * if not, then this must be the first one
							* so do not destroy it on load
						 */
						DontDestroyOnLoad(gameObject);

						/*
						 * and set the static instance variable to this
						 */
						Instance = this;
				}
				else if (Instance != this)
				{
						/*
						 * if an instance already exists(and it's not the main one), destroy this one and keep using the original instance
						 */
						Destroy(gameObject);
				}
		}
}
