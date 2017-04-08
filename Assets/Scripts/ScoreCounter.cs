using UnityEngine;
using UnityEngine.UI;

public class FinalScoreCounter : MonoBehaviour 
{
	public Text finalScore;
	public ScoreManager scoreManager;
	
	void Update () 
	{
		finalScore.text = "Score: " + scoreManager.GetCurrentScore().ToString();
	}
}