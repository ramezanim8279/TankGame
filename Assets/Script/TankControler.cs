using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControler : MonoBehaviour
{
   [Header("Movement")]
    public float moveSpeed = 5f;
    public float rotateSpeed = 80f;

    public AudioSource engineSound;

    

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        float rotate = Input.GetAxis("Horizontal");

        // حرکت جلو و عقب
        transform.Translate(
            Vector3.right * move * moveSpeed * Time.deltaTime,
            Space.Self
        );

        // چرخش تانک
        transform.Rotate(
            Vector3.forward * rotate * rotateSpeed * Time.deltaTime,
            Space.Self
        );

        // کنترل صدای موتور
        bool isMoving =
            Mathf.Abs(move) > 0.1f ||
            Mathf.Abs(rotate) > 0.1f;

        if (isMoving)
        {
            if (!engineSound.isPlaying)
            {
                engineSound.Play();
            }
        }
        else
        {
            if (engineSound.isPlaying)
            {
                engineSound.Stop();
            }
        }
    }
    public GameObject winPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ganj"))
        {
            WinGame();
        }
    }

    void WinGame()
    {
        gamestate.isPlaying = false;

        winPanel.SetActive(true);

        Debug.Log("YOU WIN!");
    }
}
