using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour {

    public GameObject dialog;

	// Use this for initialization
	void Start () {
        Button ResumeBtn = transform.GetComponent<Button>();
        ResumeBtn.onClick.AddListener(OnResumeButtonClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnResumeButtonClick()
    {
        dialog.SetActive(false);
        Time.timeScale = 1;
    }
}
