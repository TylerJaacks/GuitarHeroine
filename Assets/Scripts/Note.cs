using UnityEngine;

public class Note : MonoBehaviour 
{	
	Note note;

	void Update () 
	{
		transform.position += transform.forward * Time.deltaTime * -5.0f;
	}
	void OnTriggerEnter(Collider collider)
	{
		if (collider.GetComponent<Note>())
		{
			note = collider.GetComponent<Note>();
			Destroy(note);
		}
	}
}