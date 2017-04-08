using UnityEngine;

public class MusicManager : MonoBehaviour 
{
	public AudioSource music;
	public float currentTime;
	public float songTotalTime;
	public bool songIsOver = false;

	void Start() 
	{
		music.Play();
		songTotalTime = music.time;
	}

	void Update()
	{
		if (currentTime == songTotalTime)
		{
			songIsOver = true;
		}

		else 
		{
			currentTime += 1;
		}
	}
}