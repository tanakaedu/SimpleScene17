using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
        GameParams.DrawScore();
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadSceneAsync("Game");
        }
	}
}
