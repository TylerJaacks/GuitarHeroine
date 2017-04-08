using UnityEngine;
using UnityEngine.UI;

public class FinalScoreCounter : MonoBehaviour 
{
	public Text finalScoreText;

	void Update () 
	{
		finalScoreText.text = "Final Score: " + PlayerPrefs.GetInt("CURRENT_SCORE");
	}
}