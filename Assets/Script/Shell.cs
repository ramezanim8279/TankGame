using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            solider soldier = collision.gameObject.GetComponent<solider>();

            if (soldier != null)
            {
                soldier.Die();
            }

            Destroy(gameObject);
        }
    }
}
