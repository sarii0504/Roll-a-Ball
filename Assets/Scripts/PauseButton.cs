using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {

    public GameObject dialog;

	// Use this for initialization
	void Start () {
        Button PauseBtn = transform.GetComponent<Button>();
        PauseBtn.onClick.AddListener(onPauseButtonClick);
	}
	
	// Update is called once per frame
	void Update () {
	    

	}


    void onPauseButtonClick()
    {
        dialog.SetActive(true);
        Time.timeScale = 0;
    }
}


