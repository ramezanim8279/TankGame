using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControler : MonoBehaviour
{
   public float moveSpeed = 5f;
    public float rotateSpeed = 10f;

    private AudioSource engineSound;

    void Start()
    {
        engineSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(h, 0, v).normalized;

        // کنترل صدا
        if (direction.magnitude > 0.1f)
        {
            if (!engineSound.isPlaying)
            {
                engineSound.Play();
            }

            Quaternion targetRotation = Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                targetRotation,
                rotateSpeed * Time.deltaTime
            );

            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else
        {
            if (engineSound.isPlaying)
            {
                engineSound.Stop();
            }
        }
    }
}
