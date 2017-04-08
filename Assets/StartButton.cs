using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

	//lol go away 
    public void changeScene(int index)
    {
        Application.LoadLevel(index);
    }
}
