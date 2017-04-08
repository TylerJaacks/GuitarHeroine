using System;
using UnityEngine;

public class TriggerDetection : MonoBehaviour 
{
	public Note note;
	public string buttonName;

	public ScoreManager scoreManager;

	void Start()
	{
		scoreManager = new ScoreManager();
	}

	void Update()
	{
		if (Input.GetButton(buttonName) && note != null)
		{
			// And Add Animation-thingy.

			Debug.Log("Hit!");
			scoreManager.currentScore += scoreManager.CORRECT_NOTE_BONUS;

			Destroy(note.gameObject);
			note = null;
		} else if (note != null) {
			Math.Max(scoreManager.currentScore -= scoreManager.WRONG_NOTE_PENALTY, scoreManager.currentScore);
			scoreManager.totalWrongNotes += 1;
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

			Destroy(note.gameObject);
			note = null;
		}
	}
}