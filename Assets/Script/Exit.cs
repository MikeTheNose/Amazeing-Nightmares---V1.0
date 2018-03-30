using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    public void ClickExit()

    {
        Application.Quit();
    }

    //Added for exiting out of the game when pressing X button on phone.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }



}

