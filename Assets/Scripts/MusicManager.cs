using UnityEngine;

public class MusicManager : MonoBehaviour 
{
	public AudioSource music;
	public AudioClip clip;
	public AudioClip[] songs;
	public float currentTime;
	public float songTotalTime;
	public bool songIsOver = false;

	void Start() 
	{
		if (PlayerPrefs.GetString("SONG").Equals("All Star - Smash Mouth")) 
		{
			clip = songs[0];
		}

		if (PlayerPrefs.GetString("SONG").Equals("We Are Number One - Lazy Town")) 
		{
			clip = songs[1];
		}

		music.clip = clip;

		clip = music.clip;
		currentTime = 0.0f;
		songTotalTime = clip.length;
		music.Play();
	}

	void Update()
	{
		if (currentTime > songTotalTime)
		{
			songIsOver = true;
		}

		currentTime = Time.timeSinceLevelLoad;
	}
}