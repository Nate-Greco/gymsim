using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnPanelOpener : MonoBehaviour {
    public GameObject Learn;

    public void openLearn(){
        if(Learn != null) {
            Learn.SetActive(true);
        }
    }
}    
