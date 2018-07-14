using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Button btn = transform.GetComponent<Button>();

        btn.onClick.AddListener(onQuitButtonClick);
    }
        // Update is called once per frame
        void Update () {
		
	}

    void onQuitButtonClick()
    {
        Application.Quit();
    }
}
