using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour 
{
	public Text text;
	
	void Update () 
	{
		text.text = "Final Score: " + PlayerPrefs.GetInt("FINAL_SCORE");
	}
}