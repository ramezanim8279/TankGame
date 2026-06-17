using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycarhit : MonoBehaviour
{
    private bool hasHit = false;
    public GameObject gameoverpanel;
    private void OnCollisionEnter(Collision collision)
    {
        if (hasHit) return;
        if (collision.gameObject.CompareTag("Player"))
        {
            hasHit = true;
            Debug.Log("Game Over - Hit by car");
            gameoverpanel.SetActive(true);
            gamestate.isPlaying = false;

            collision.gameObject.GetComponent<TankControler>().enabled = false;
            collision.gameObject.GetComponent<Tankshoot>().enabled = false;
        }
    }
}
