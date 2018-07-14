using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {


	// Use this for initialization
	void Start () {
        Button btn = transform.GetComponent<Button>();

        btn.onClick.AddListener(onStartButtonClick);
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void onStartButtonClick()
    {
       SceneManager.LoadScene("GamePlay");
    }
}
