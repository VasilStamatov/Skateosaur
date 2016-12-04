using UnityEngine;
using UnityEngine.UI;

public class TimeElapsed : MonoBehaviour
{
		private Text elapsedTime;
		// Use this for initialization
		void Start()
		{
				elapsedTime = GetComponent<Text>();
				elapsedTime.text = "Time elapsed : " + GlobalControl.instance.timeSurvived;
				switch (GlobalControl.instance.levelPlayed)
				{
						case "Level1":
								{
										if (GlobalControl.instance.timeSurvived >= 15)
										{
												GlobalControl.instance.savedStats.unlockedLevels = 2;
										}
										break;
								}
						case "Level2":
								{
										if (GlobalControl.instance.timeSurvived >= 30)
										{
												GlobalControl.instance.savedStats.unlockedLevels = 3;
										}
										break;
								}
						case "Level3":
								{
										if (GlobalControl.instance.timeSurvived >= 60)
										{
												GlobalControl.instance.savedStats.unlockedLevels = 4;
										}
										break;
								}
						case "Level4":
								{
										if (GlobalControl.instance.timeSurvived >= 120)
										{
												GlobalControl.instance.savedStats.unlockedLevels = 5;
										}
										break;
								}
						case "Level5":
								{
										if (GlobalControl.instance.timeSurvived >= 240)
										{
												GlobalControl.instance.savedStats.unlockedLevels = 6;
										}
										break;
								}
						case "Level6":
								{
										if (GlobalControl.instance.timeSurvived >= 480)
										{
												GlobalControl.instance.savedStats.unlockedLevels = 7;
										}
										break;
								}
						case "Level7":
								{
										//no more levels
										break;
								}
						case "Survival":
								{
										//save the highscore in survival mode

										//check if it's equal or lower than the lowest highscore
										if (GlobalControl.instance.timeSurvived <= GlobalControl.instance.savedStats.highScores[0])
										{
												//if so then it's not going to be saved
												break;
										}

										//Check if the score is the same as a score already in the array
										if (System.Array.IndexOf(GlobalControl.instance.savedStats.highScores, GlobalControl.instance.timeSurvived) > -1)
										{
												//don't save the same scores twice in the highscore array
												break;
										}

										//set the lowest to the new score
										GlobalControl.instance.savedStats.highScores[0] = GlobalControl.instance.timeSurvived;

										//Sort the array with the newly added value

										//(bubble sort)
										for (int i = 0; i < GlobalControl.instance.savedStats.highScores.Length - 1; i++)
										{
												for (int j = i + 1; j < GlobalControl.instance.savedStats.highScores.Length; j++)
												{
														// check if the first position (i) is higher than the next position (j)
														if (GlobalControl.instance.savedStats.highScores[i] > GlobalControl.instance.savedStats.highScores[j])
														{
																//if the element at the first position is higher, then swap it
																ushort temp = GlobalControl.instance.savedStats.highScores[j];
																GlobalControl.instance.savedStats.highScores[j] = GlobalControl.instance.savedStats.highScores[i];
																GlobalControl.instance.savedStats.highScores[i] = temp;
														}
												}
										}
										for (int i = 0; i < GlobalControl.instance.savedStats.highScores.Length; i++)
										{
												Debug.Log(GlobalControl.instance.savedStats.highScores[i]);
										}
										break;
								}
						default:
								break;
				}
				//save the data
				GlobalControl.instance.SaveData();
		}
}
