using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	public ScoreManager scoreManager;
	public MusicManager musicManager;

	void Update () 
	{
		scoreManager.SetCurrentScore();

		if (musicManager.songIsOver)
		{
			SceneManager.LoadScene("GameOver");
		}
	}
}
