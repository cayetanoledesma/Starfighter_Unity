using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int MaxHP;
    public int currentHP;
    public string DamageBulletTag;
    public string lifetimeBulletTag;
    public string Mina;
    public GameObject boom;
    public Transform SpawnPoint;
    
   




    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(DamageBulletTag))
        {
            currentHP -= 10;
            if (currentHP <= 0)
            {
                Destroy(gameObject);
            }
               

        }

        if(collision.CompareTag(Mina))
        {
            currentHP -= 50;
            GameObject explosion = Instantiate(boom, SpawnPoint.position, Quaternion.identity);
            if (currentHP <= 0)
            {
                
                Destroy(gameObject);
            }
        }
           
        
            
        if(collision.CompareTag(lifetimeBulletTag))
        {
            if(currentHP < MaxHP)
            {
                currentHP += 10;
                if(currentHP >= MaxHP)
                {
                    currentHP = MaxHP;
                }
                Destroy(collision.gameObject);
                Debug.Log("mejora de salud");
            }

        }


        
        
    
    }
}
