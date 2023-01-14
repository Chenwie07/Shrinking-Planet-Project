using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject gameOverUI;
    //public bool GameOver { get; set; }

    void Awake ()
	{
		instance = this;
	}

	public void EndGame ()
	{
		//GameOver = true; 
		gameOverUI.SetActive(true);
	}

	public void Restart ()
	{
		//GameOver = false; 
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
