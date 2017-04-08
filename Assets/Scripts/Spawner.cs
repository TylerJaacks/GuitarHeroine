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
	}

	void Update () 
	{
		
	}
}
