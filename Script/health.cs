using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] float startHealth = 10f, currentHealth = 0f;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Destroy(gameObject,1f);
        }
        
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }
}
