using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject PickUp;
    private Vector3 pos;
    private Quaternion rot;
    private float min=-9.0f,max=9.0f;
    private float speed=2.0f;
    private int score=0;
    public GameObject ScoreBoard;
    private Text ScoreText;
    // Use this for initialization
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody>();
        ScoreText = ScoreBoard.GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement*speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            Destroy(other.gameObject);
            score++;

            ScoreText.text = "Score: " + score;
        }

        pos.x = Random.Range(min, max);
        pos.y = 0.5f;
        pos.z = Random.Range(min, max);

        rot = new Quaternion(0,0,0,1);

        //生成一个新的旋转体
        Instantiate(PickUp, pos, rot);
    }
}
