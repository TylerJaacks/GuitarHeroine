using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour 
{
	public Slider volume;
	public Toggle fullScreen;
	public Toggle vsync;
	public Button backButton;

	void Start () 
	{
		Button btn1 = backButton.GetComponent<Button>();
		btn1.onClick.AddListener(BackButtonOnClick);
	}

	void BackButtonOnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
