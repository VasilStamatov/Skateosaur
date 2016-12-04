using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*
* Small behaviour to handle menu button callbacks.
*/
public class MenuController : MonoBehaviour
{
		/*
   * When the start button is pressed, load the Game scene.
   */
		public void OnStartClicked()
		{
				SceneManager.LoadScene("Game");
		}

		/*
   * When the back button is clicked, load the main menus scene.
   */
		public void OnBackClicked()
		{
				SceneManager.LoadScene("MainMenu");
		}

		/*
   * When the retry button is clicked, reload the scene.
   */
		public void OnRetryClicked()
		{
				SceneManager.LoadScene(GlobalControl.Instance.levelPlayed);
		}

		public void OnExitClicked()
		{
				Application.Quit();
		}
		public void OnLevelSelector()
		{
				SceneManager.LoadScene("LevelSelector");
		}
		public void OnCreditsClicked()
		{
				SceneManager.LoadScene("Credits");
		}
		public void OnMuteClicked()
		{
		}
		/* Level selectors */
		public void OnLevel1()
		{
				if (GlobalControl.Instance.unlockedLevels >= 1)
				{
						GlobalControl.Instance.levelPlayed = "Level1";
						SceneManager.LoadScene("Level1");
				}
		}
		public void OnLevel2()
		{
				if (GlobalControl.Instance.unlockedLevels >= 2)
				{
						GlobalControl.Instance.levelPlayed = "Level2";
						SceneManager.LoadScene("Level2");
				}
		}
		public void OnLevel3()
		{
				if (GlobalControl.Instance.unlockedLevels >= 3)
				{
						GlobalControl.Instance.levelPlayed = "Level3";
						SceneManager.LoadScene("Level3");
				}
		}
		public void OnLevel4()
		{
				if (GlobalControl.Instance.unlockedLevels >= 4)
				{
						GlobalControl.Instance.levelPlayed = "Level4";
						SceneManager.LoadScene("Level4");
				}
		}
		public void OnLevel5()
		{
				if (GlobalControl.Instance.unlockedLevels >= 5)
				{
						GlobalControl.Instance.levelPlayed = "Level5";
						SceneManager.LoadScene("Level5");
				}
		}
		public void OnLevel6()
		{
				if (GlobalControl.Instance.unlockedLevels >= 6)
				{
						GlobalControl.Instance.levelPlayed = "Level6";
						SceneManager.LoadScene("Level6");
				}
		}
		public void OnLevel7()
		{
				if (GlobalControl.Instance.unlockedLevels >= 7)
				{
						GlobalControl.Instance.levelPlayed = "Level7";
						SceneManager.LoadScene("Level7");
				}
		}
		public void OnSurvivalMode()
		{
				GlobalControl.Instance.levelPlayed = "Survival";
				SceneManager.LoadScene("Survival");
		}
}
