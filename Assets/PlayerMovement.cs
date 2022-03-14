using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{


    // Start is called before the first frame update
    public float playerSpeed;
    public GameObject bulletPrefab;
    public Vector3 offset;
    float time;
    public AudioSource bulletSound;
    public AudioClip audioClip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float xPosition = Mathf.Clamp(transform.position.x, -8.0f, +8.0f);
        float yPosition = Mathf.Clamp(transform.position.y, -4.5f, 4.5f);
        //transform.Translate(Vector3.right*speed*inputX*Time.deltaTime);
        // Giving some speed in particular direction using GetAxis
        transform.Translate(Vector3.up * playerSpeed * inputY * Time.deltaTime);
        transform.Translate(Vector3.right * playerSpeed * inputX * Time.deltaTime);
        //Checking spaceship is in the frame or not  
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

       // time = time + Time.deltaTime; //Creating a bullet for every 0.5s
        if (Input.GetButtonDown("Fire1"))
        {
            //Here, method for triple shot.Triple shot means releasing three bullets at a time 
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
            bulletSound.clip = audioClip;
            bulletSound.Play();
            //time = 0f;
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
           
            //Left wing bullet position
            Instantiate(bulletPrefab, transform.position + new Vector3(-0.05f, -0.4f, 0f), Quaternion.identity);
            // Center bullet position
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
            // Right wing bullet position
            Instantiate(bulletPrefab, transform.position + new Vector3(-0.05f, 0.4f, 0f), Quaternion.identity);

        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
