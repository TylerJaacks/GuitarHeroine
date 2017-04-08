using UnityEngine;

public class MusicManager : MonoBehaviour 
{
	public AudioSource music;
	public AudioClip clip;
	public float currentTime;
	public float songTotalTime;
	public bool songIsOver = false;

	void Start() 
	{
		currentTime = 0.0f;
		songTotalTime = clip.length;
		music.Play();
	}

	void Update()
	{
		if (currentTime.Equals(songTotalTime))
		{
			songIsOver = true;
		}

		else 
		{
			currentTime++;
		}
	}
}