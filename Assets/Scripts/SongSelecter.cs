
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SongSelecter : MonoBehaviour
 {
	public Dropdown songs;
	public Button backButton;
	public Button playButton;
	public List<string> songList = new List<string>();

	void Start()
    {
        Button btn1 = backButton.GetComponent<Button>();
        Button btn2 = playButton.GetComponent<Button>();
		
        btn1.onClick.AddListener(BackOnClick);
        btn2.onClick.AddListener(PlayOnClick);
    }

    void BackOnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

	void PlayOnClick()
    {
        SceneManager.LoadScene("Game");
    }
}