using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public Transform Spawnbullet;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletPrefab, Spawnbullet.position, Spawnbullet.rotation);
            bullet.GetComponent<Rigidbody>().velocity = Spawnbullet.forward * bulletSpeed;
        }
    }
}
