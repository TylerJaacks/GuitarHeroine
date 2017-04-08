using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour 
{
	public Button startGame;
    public Button options;
    public Button quitGame;

    void Start()
    {
        Button btn1 = startGame.GetComponent<Button>();
        Button btn2 = options.GetComponent<Button>();
        Button btn3 = quitGame.GetComponent<Button>();

        btn1.onClick.AddListener(StartGameOnClick);
        btn2.onClick.AddListener(OptionsOnClick);
        btn3.onClick.AddListener(ExitGameOnClick);
    }

    void StartGameOnClick()
    {
        SceneManager.LoadScene("SongSelector");
    }

    void OptionsOnClick()
    {
        SceneManager.LoadScene("Options");
    }

    void ExitGameOnClick()
    {
        Application.Quit();
    }
}