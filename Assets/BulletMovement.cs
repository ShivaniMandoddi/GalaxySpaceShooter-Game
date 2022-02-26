using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update

    
    
    public float bulletSpeed;
    float time;
    void Start()
    {
       
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
}
