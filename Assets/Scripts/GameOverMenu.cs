using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class GameOverMenu : MonoBehaviour
    {
        public Button mainMenu;

        void Start()
        {
            Button btn1 = mainMenu.GetComponent<Button>();
            btn1.onClick.AddListener(MainMenuOnClick);
        }

        void MainMenuOnClick()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}