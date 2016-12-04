using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

/*
 * singleton class for the container of global variables for the game stats
 */
public class GlobalControl : MonoBehaviour
{
		/*
			* the single instance of the class
			*/
		public static GlobalControl instance;

		public SavedStats savedStats = new SavedStats();
		/*
			* the unlocked characters (1 to x)
			*/
		//public byte unlockedCharacters = 1;

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
				if (instance == null)
				{
						/*
						 * if not, then this must be the first one
							* so do not destroy it on load
						 */
						DontDestroyOnLoad(gameObject);

						/*
						 * and set the static instance variable to this
						 */
						instance = this;
				}
				else if (instance != this)
				{
						/*
						 * if an instance already exists(and it's not the main one), destroy this one and keep using the original instance
						 */
						Destroy(gameObject);
				}
		}

		void Start()
		{
				LoadData();
		}

		public void SaveData()
		{
				//check if the saves directory exists
				if (!Directory.Exists("Saves"))
				{
						//if not, then create one
						Directory.CreateDirectory("Saves");
				}

				//create the binary formatter
				BinaryFormatter formatter = new BinaryFormatter();

				//create the save file in the saves directory
				FileStream saveFile = File.Create("Saves/save.binary");

				//save the highscores
				formatter.Serialize(saveFile, savedStats);

				//Close the file
				saveFile.Close();
		}

		public void LoadData()
		{
				//Load if the saves directory exists
				if (Directory.Exists("Saves"))
				{
						//create the binary formatter
						BinaryFormatter formatter = new BinaryFormatter();

						//open the save file
						FileStream saveFile = File.Open("Saves/save.binary", FileMode.Open);

						//read the highscore
						savedStats = (SavedStats)formatter.Deserialize(saveFile);
				}
		}
}
