using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BenchTeleport : MonoBehaviour {

    public string sceneName;
    void Start(){

    }

    void Update() {

    }

    public void changeScene() {
        SceneManager.LoadScene(sceneName);
    }


}
