using UnityEngine;

public class Note : MonoBehaviour 
{	
	Note note;

	void Update () 
	{
		transform.position += transform.forward * Time.deltaTime * -5.0f;
	}
}