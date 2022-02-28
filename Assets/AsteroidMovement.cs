using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float asteroidSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * asteroidSpeed*Time.deltaTime);
        transform.Rotate(5.0f, 0f, 0f, Space.Self);
        if(transform.position.x<-12.0f)
        {
            Destroy(gameObject,3.0f);
        }
       

    }
    /*private void OnBecameInvisible()
    {
       // Destroy(gameObject);
    }*/
}
