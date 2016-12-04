using UnityEngine;
using UnityEngine.UI;

public class TimeElapsed : MonoBehaviour
{
		private Text elapsedTime;
		// Use this for initialization
		void Start()
		{
				elapsedTime = GetComponent<Text>();
				elapsedTime.text = "Time elapsed : " + GlobalControl.Instance.timeSurvived;
				switch (GlobalControl.Instance.levelPlayed)
				{
						case "Level1":
								{
										if (GlobalControl.Instance.timeSurvived >= 15)
										{
												GlobalControl.Instance.unlockedLevels = 2;
										}
										break;
								}
						case "Level2":
								{
										if (GlobalControl.Instance.timeSurvived >= 30)
										{
												GlobalControl.Instance.unlockedLevels = 3;
										}
										break;
								}
						case "Level3":
								{
										if (GlobalControl.Instance.timeSurvived >= 60)
										{
												GlobalControl.Instance.unlockedLevels = 4;
										}
										break;
								}
						case "Level4":
								{
										if (GlobalControl.Instance.timeSurvived >= 120)
										{
												GlobalControl.Instance.unlockedLevels = 5;
										}
										break;
								}
						case "Level5":
								{
										if (GlobalControl.Instance.timeSurvived >= 240)
										{
												GlobalControl.Instance.unlockedLevels = 6;
										}
										break;
								}
						case "Level6":
								{
										if (GlobalControl.Instance.timeSurvived >= 480)
										{
												GlobalControl.Instance.unlockedLevels = 7;
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
										if (GlobalControl.Instance.timeSurvived <= GlobalControl.Instance.highScores[0])
										{
												//if so then it's not going to be saved
												break;
										}

										//Check if the score is the same as a score already in the array
										if (System.Array.IndexOf(GlobalControl.Instance.highScores, GlobalControl.Instance.timeSurvived) > -1)
										{
												//don't save the same scores twice in the highscore array
												break;
										}

										//set the lowest to the new score
										GlobalControl.Instance.highScores[0] = GlobalControl.Instance.timeSurvived;

										//Sort the array with the newly added value

										//(bubble sort)
										for (int i = 0; i < GlobalControl.Instance.highScores.Length - 1; i++)
										{
												for (int j = i + 1; j < GlobalControl.Instance.highScores.Length; j++)
												{
														// check if the first position (i) is higher than the next position (j)
														if (GlobalControl.Instance.highScores[i] > GlobalControl.Instance.highScores[j])
														{
																//if the element at the first position is higher, then swap it
																ushort temp = GlobalControl.Instance.highScores[j];
																GlobalControl.Instance.highScores[j] = GlobalControl.Instance.highScores[i];
																GlobalControl.Instance.highScores[i] = temp;
														}
												}
										}

										break;
								}
						default:
								break;
				}
		}
}
