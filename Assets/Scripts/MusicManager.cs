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
		Debug.Log(PlayerPrefs.GetString("SONG").ToString());

		if (PlayerPrefs.GetString("SONG").Equals("All Star - Smash Mouth")) 
		{
			Debug.Log("Song 0");
			clip = songs[0];
		}

		if (PlayerPrefs.GetString("SONG").Equals("We Are Number One - Lazy Town")) 
		{
			Debug.Log("Song 1");
			clip = songs[1];
		}

		music.clip = clip;

		Debug.Log(music.clip.ToString());

		clip = music.clip;
		currentTime = 0.0f;
		songTotalTime = clip.length;
		music.Play();
	}

	void Update()
	{
		if (songTotalTime == currentTime)
		{
			songIsOver = true;
		}

		currentTime = Time.timeSinceLevelLoad;
	}
}