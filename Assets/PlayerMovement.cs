using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        Debug.Log("Print");   
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float xPosition = Mathf.Clamp(transform.position.x, -8.0f, +8.0f);
        float yPosition = Mathf.Clamp(transform.position.y, -4.5f, 4.5f);
        //transform.Translate(Vector3.right*speed*inputX*Time.deltaTime);
        transform.Translate(Vector3.up * speed * inputY * Time.deltaTime);
        transform.Translate(Vector3.right * speed * inputX * Time.deltaTime);
        if (transform.position.y>4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.4f, transform.position.z);
        }
        if(transform.position.y < -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.4f, transform.position.z);
        }
        
        if(transform.position.x>8.0f)
        {
            transform.position = new Vector3(8.0f,transform.position.y, transform.position.z);
        }
        if(transform.position.x<-8.0f)
        {
            transform.position = new Vector3(-8.0f,transform.position.y,transform.position.z);
        }
    }
}
