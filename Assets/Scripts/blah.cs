using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class blah : MonoBehaviour {

	public void doShit(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
