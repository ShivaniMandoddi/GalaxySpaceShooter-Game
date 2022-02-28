using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollScript : MonoBehaviour
{


    // Start is called before the first frame update
    //public RawImage image;
    //public float x, y;
    public float speed;
    private Renderer render;
    private Vector2 soffset;
    void Start()
    {
        render = GetComponent<Renderer>();
        //image.uvRect = new Rect(image.uvRect.position);
        //Debug.Log(image.uvRect.position.x);
        //image.uvRect = new Rect(image.uvRect.position * new Vector2(x, y) * Time.deltaTime, image.uvRect.size);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Repeat(Time.time * speed, 1);
        Vector2 offset = new Vector2(x, 0);
        render.sharedMaterial.SetTextureOffset("_MainTex", offset);
        //image.uvRect = new Rect(image.uvRect.position * new Vector2(x, y) * Time.deltaTime, image.uvRect.size);
    }
}
