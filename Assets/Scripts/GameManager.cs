using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	bool gameHasended = false;
	public float restartDelay = 1f;
	public GameObject CompleteLevelUI;
	public Scene ControlsScene;
	public Scene Level01;

	public void EndGame()
	{
		if (gameHasended == false)
		{
			gameHasended = true;
			Debug.Log("GAME OVER");
			Invoke("Restart", restartDelay);
		}
	}

	public void CompleteLevel()
	{
		CompleteLevelUI.SetActive(true);
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void Load()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Quit()
	{
		Application.Quit();
	}
}