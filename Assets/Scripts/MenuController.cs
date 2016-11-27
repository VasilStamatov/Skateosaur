using UnityEngine;
using UnityEngine.SceneManagement;

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

		public void OnExitClicked()
		{
				Application.Quit();
		}
		public void OnLevelSelector()
		{
				SceneManager.LoadScene("LevelSelector");
		}

		/* Level selectors */
		public void OnLevel1()
		{
				SceneManager.LoadScene("Level1");
		}
		public void OnLevel2()
		{
				SceneManager.LoadScene("Level2");
		}
		public void OnLevel3()
		{
				SceneManager.LoadScene("Level3");
		}
		public void OnLevel4()
		{
				SceneManager.LoadScene("Level4");
		}
		public void OnLevel5()
		{
				SceneManager.LoadScene("Level5");
		}
		public void OnLevel6()
		{
				SceneManager.LoadScene("Level6");
		}
		public void OnLevel7()
		{
				SceneManager.LoadScene("Level7");
		}
}
