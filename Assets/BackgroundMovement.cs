using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * 2.5f*Time.deltaTime);
        if (transform.position.x <= -19.50f)
           transform.position = new Vector3(20f, transform.position.y, transform.position.z);
    }
}
