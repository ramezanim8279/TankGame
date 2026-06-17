using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatmovement : MonoBehaviour
{
    [Header("Floating")]
    public float floatAmplitude = 0.2f;
    public float floatSpeed = 1.5f;

    [Header("Rocking")]
    public float rotationAmplitude = 5f;
    public float rotationSpeed = 1f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // بالا و پایین رفتن
        float newY = startPosition.y +
                     Mathf.Sin(Time.time * floatSpeed)* floatAmplitude;

        transform.position = new Vector3(
            transform.position.x,
            newY,
            transform.position.z
        );

        // تکان خوردن روی آب
        float rotZ =
            Mathf.Sin(Time.time * rotationSpeed)*rotationAmplitude;

        transform.rotation = Quaternion.Euler(
            transform.rotation.eulerAngles.x,
            transform.rotation.eulerAngles.y,
            rotZ
        );
    }
}
