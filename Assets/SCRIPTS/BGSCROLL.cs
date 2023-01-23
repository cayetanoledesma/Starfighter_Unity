using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSCROLL : MonoBehaviour
{
    public SpriteRenderer graphic;
    public float Speed;
    private float gfxSize;
    private float initialYPos;
    private float yLimit;






    // Start is called before the first frame update
    void Start()
    {
        gfxSize = graphic.bounds.size.y;

        initialYPos = transform.position.y;

        yLimit = initialYPos - gfxSize;
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * -Speed);

        if (transform.position.y < yLimit)
        {
            transform.position = new Vector3(transform.position.x, initialYPos, transform.position.z);
        }

    }
}
