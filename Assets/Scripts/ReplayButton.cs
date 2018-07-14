using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReplayButton : MonoBehaviour {

    public GameObject dialog;

    // Use this for initialization
    void Start()
    {
        Button ReplayBtn = transform.GetComponent<Button>();
        ReplayBtn.onClick.AddListener(OnReplayButtonClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnReplayButtonClick()
    {
        dialog.SetActive(false);
        SceneManager.LoadScene("GamePlay");
        Time.timeScale = 1;
    }
}
