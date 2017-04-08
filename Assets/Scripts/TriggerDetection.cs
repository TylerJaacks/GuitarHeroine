using UnityEngine;

public class TriggerDetection : MonoBehaviour 
{
	public Note note;
	public string buttonName;

	void Update()
	{
		if (Input.GetButton(buttonName) && note != null)
		{
			// Do Stuff
			// Update Score
			// And Add Animation-thingy.

			Destroy(note.gameObject);
			note = null;
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
			Destroy(note.gameObject);
			note = null;
		}
	}
}