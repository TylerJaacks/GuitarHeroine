using UnityEngine;

public class Spawner : MonoBehaviour 
{
	public Note blueNote;
	public Note greenNote;
	public Note redNote;
	public Note yellowNote;
	public GameObject fretBoard;

	Vector3 blueSpanwPos = new Vector3(-2.0f, 4.65f, 7.58f);
	Vector3 greenSpawnPos = new Vector3(-0.7f, 4.65f, 7.58f);
	Vector3 redNoteSpawnPos = new Vector3(0.69f, 4.65f, 7.58f);
	Vector3 yellowNoteSpawnPos = new Vector3(2.0f, 4.65f, 7.58f);

	void Start () 
	{
		GameObject.Instantiate(blueNote, blueSpanwPos, new Quaternion(0, 0, 0, 0), fretBoard.transform);
		GameObject.Instantiate(greenNote, greenSpawnPos, new Quaternion(0, 0, 0, 0), fretBoard.transform);
		GameObject.Instantiate(redNote, redNoteSpawnPos, new Quaternion(0, 0, 0, 0), fretBoard.transform);
		GameObject.Instantiate(yellowNote, yellowNoteSpawnPos, new Quaternion(0, 0, 0, 0), fretBoard.transform);

	}

	void Update () 
	{
		
	}
}
