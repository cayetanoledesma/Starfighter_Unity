using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermover : MonoBehaviour
{
    [Range(0,100)]
    public float MaxSpeed, MaxAcceleration;
    [Header("Bounds")]
    public float HorizontalLimit;
    public float VerticalLimit;

    private float currentVelocityX, currentVelocityY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, v).normalized;



        currentVelocityX =  Mathf.MoveTowards(currentVelocityX, dir.x * MaxSpeed, MaxAcceleration * Time.deltaTime);
        currentVelocityY =  Mathf.MoveTowards(currentVelocityY, dir.y * MaxSpeed, MaxAcceleration * Time.deltaTime);


        // velocity es el vector que indica la velocidad por segundo...
        Vector3 velocity = new Vector3(currentVelocityX, currentVelocityY);

        //hay que pasarlo a movimiento por cada instante, eso es el desplazamiento
        Vector3 displacement = velocity * Time.deltaTime;

        transform.Translate(displacement);

        //Limites
        float xClamped = Mathf.Clamp(transform.position.x, -HorizontalLimit, HorizontalLimit);
        float yClamped = Mathf.Clamp(transform.position.y, -VerticalLimit, VerticalLimit);

        transform.position = new Vector3(xClamped, yClamped);



    }
}
