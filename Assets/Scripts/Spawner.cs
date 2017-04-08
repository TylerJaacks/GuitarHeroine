using UnityEngine;

public class Spawner : MonoBehaviour 
{
	public GameObject redNote;
	public GameObject blueNote;
	public GameObject yellowNote;
	public GameObject greenNote;

	void Start () 
	{
		GameObject.Instantiate(redNote);
		GameObject.Instantiate(blueNote);
		GameObject.Instantiate(yellowNote);	
		GameObject.Instantiate(greenNote);
	}

	void Update () 
	{
		
	}

	void Spawn(Note note, Vector2 position)
	{
		
	}
}
