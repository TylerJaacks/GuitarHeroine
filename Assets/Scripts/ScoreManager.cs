using UnityEngine;

public class ScoreManager : MonoBehaviour 
{
	public int WRONG_NOTE_PENALTY = 25;
	public int CORRECT_NOTE_BONUS = 50;
	public int ALL_NOTES_CORRECT_BONUS = 1500;
	public int currentScore;
	public int finalScore;
	public int totalNotesPassed = 0;
	public int totalCorrectNotes = 0;
	public int totalWrongNotes = 0;

	public void SetFinalScore()
	{
		finalScore = currentScore;

		if (totalWrongNotes == 0) 
		{
			finalScore += ALL_NOTES_CORRECT_BONUS;
		}

		PlayerPrefs.SetInt("FINAL_SCORE" , finalScore);
	}

	public int GetCurrentScore()
	{
		return currentScore;
	}
}
