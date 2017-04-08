using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongPicker : MonoBehaviour 
{
	public void ValueChange(int _i) 
	{
		Debug.Log("Hello");

		if (_i == 0)
		{
			Debug.Log("0");
			PlayerPrefs.SetString("SONG", "All Star - Smash Mouth");
		}

		if (_i == 1)
		{
			Debug.Log("1");
			PlayerPrefs.SetString("SONG", "We Are Number One - Lazy Town");
		}
	}
}