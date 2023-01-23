using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simple : MonoBehaviour
{
    public GameObject bullet;
    public float Cooldown;
    public Transform spawPoint;
    private float cdCounter;
    // Start is called before the first frame update
    void Start()
    {
        cdCounter = Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        cdCounter += Time.deltaTime;
        if(Input.GetKey(KeyCode.Space) && cdCounter>Cooldown)
            {//Instanciar (crear) la bala
            GameObject bulletPrefab = Instantiate(bullet, spawPoint.position, Quaternion.identity);
            Destroy(bulletPrefab, 5);
            cdCounter = 0;
    }

    }
}
