using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float speed;
    public float force = 0;
    private Rigidbody rb;

    public Text countText;
    public Text stateText;

    private int count;

    public bool loss;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        stateText.text = "";
        loss = false;
    }

    private void Update()
    {
        if(loss == false)
        {
            if (Input.GetKey(KeyCode.Space))
        {

                force += 50*Time.deltaTime;
                if (force >= 150)
                {
                    force = 150;
                }
            
            }else if (Input.GetKeyUp(KeyCode.Space))
            {

            Vector3 jump = new Vector3(0.0f, force, 0.0f);
            rb.AddForce(jump);
            force = 0;
            }   

            if (Input.GetKeyDown(KeyCode.C))
            {
            speed = 5;
            }else if (Input.GetKeyUp(KeyCode.Z))
            {
            speed = 1;
            }
            }
       
    }

    void FixedUpdate()
    {
        if(loss == false)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");



            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }


        if (other.gameObject.CompareTag("Car"))
        {
            loss = true;
            SetL();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 15)
        {
            stateText.text = "You Win!";
        }
    }

    void SetL()
    {
        if (loss == true)
        {
            stateText.text = "You Lose";
        }
    }
}

