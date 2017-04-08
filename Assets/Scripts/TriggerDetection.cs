using System;
using UnityEngine;

public class TriggerDetection : MonoBehaviour 
{
	public Note note;
	public string buttonName;

	public ScoreManager scoreManager;

	void Update()
	{
		if (Input.GetButton(buttonName) && note != null)
		{
			// Not Working
			scoreManager.currentScore += scoreManager.CORRECT_NOTE_BONUS;

			scoreManager.totalCorrectNotes++;

			Destroy(note.gameObject);
			note = null;
		}

		// Detect if the note was missed is so fucked up
		else if (!Input.GetButton(buttonName) && note != null) 
		{
			
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.GetComponent<Note>()) 
		{
			note = collider.GetComponent<Note>();
		}
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.GetComponent<Note>() == note)
		{
			scoreManager.totalNotesPassed += 1;

			scoreManager.totalWrongNotes++;
			scoreManager.currentScore -= scoreManager.WRONG_NOTE_PENALTY;
			
			if (scoreManager.currentScore < 0) 
			{
				scoreManager.currentScore = 0;
			}

			Destroy(note.gameObject);
			note = null;
		}
	}
}