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
		clip = music.GetComponent<AudioClip>();
		music.Play();
		songTotalTime = clip.length;

		Debug.Log(songTotalTime);
	}

	void Update()
	{
		// if (currentTime == songTotalTime)
		// {
		// 	songIsOver = true;
		// }

		// else 
		// {
		// 	currentTime += 1;
		// }
	}
}