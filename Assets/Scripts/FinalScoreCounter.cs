using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour 
{
	public Text text;
	public ScoreManager scoreManager;
	
	void Update () 
	{
		text.text = "Score: " + scoreManager.GetCurrentScore().ToString();
	}
}