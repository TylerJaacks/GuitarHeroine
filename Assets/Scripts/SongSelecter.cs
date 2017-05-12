using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SongSelecter : MonoBehaviour
    {
        public Dropdown songs;
        public Button backButton;
        public Button playButton;

        void Start()
        {
            PlayerPrefs.SetString("SONG", "All Star - Smash Mouth");

            Button btn1 = backButton.GetComponent<Button>();
            Button btn2 = playButton.GetComponent<Button>();
            Dropdown dropDown = songs.GetComponent<Dropdown>();

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
}