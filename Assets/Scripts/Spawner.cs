using UnityEngine;

public class Spawner : MonoBehaviour 
{
	public Note blueNote;
	public GameObject fretBoard;

	Vector3 blueSpanwPos = new Vector3(-2.0f, 4.65f, 7.58f);

	void Start () 
	{
		GameObject.Instantiate(blueNote, blueSpanwPos, new Quaternion(0, 0, 0, 0), fretBoard.transform);
	}

	void Update () 
	{
		
	}
}
