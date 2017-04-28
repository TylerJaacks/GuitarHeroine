using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour 
{
	public Text score;
	public ScoreManager scoreManager;
	
	void Update () 
	{
		score.text = "Score: " + PlayerPrefs.GetInt("CURRENT_SCORE");
	}
}