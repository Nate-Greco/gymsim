using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomePanelOpener : MonoBehaviour {
    public GameObject Welcome;

    public void openWelcome(){
        if(Welcome != null) {
            bool isAlive = Welcome.activeSelf;
            Welcome.SetActive(!isAlive);
        }
    }
}    