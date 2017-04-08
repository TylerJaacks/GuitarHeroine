using UnityEngine;

public class Note : MonoBehaviour 
{	
	void Update () 
	{
		transform.position += transform.forward * Time.deltaTime * -5.0f;
	}
}
//HI!
