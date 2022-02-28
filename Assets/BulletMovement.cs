using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update

    
    
    public float bulletSpeed;
    float time;
    private AudioSource source;
    public AudioClip explosionSound;
    void Start()
    {
        source = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(bulletSpeed, 0, 0); // Giving bullet a movement in forward direction
        time = time + Time.deltaTime;
        if(time>2f)          //Destroying bullet after 2s
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(collision.gameObject);
            source.clip = explosionSound;
            source.Play();
        }
    }
}
