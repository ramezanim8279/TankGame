using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankshoot : MonoBehaviour
{
    public GameObject shellPrefab;
    public Transform firePoint;
    public float shellSpeed = 20f;
    public AudioSource shootSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
    GameObject shell = Instantiate(
        shellPrefab,
        firePoint.position,
        firePoint.rotation
    );

    Rigidbody rb = shell.GetComponent<Rigidbody>();

    rb.AddForce(
        firePoint.forward * shellSpeed,
        ForceMode.Impulse
    );
    shootSound.PlayOneShot(shootSound.clip);
    }
}
