using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button MainMenuBtn = transform.GetComponent<Button>();
        MainMenuBtn.onClick.AddListener(OnMainMenuButtonClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMainMenuButtonClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
