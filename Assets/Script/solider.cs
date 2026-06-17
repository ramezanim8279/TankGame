using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solider : MonoBehaviour
{
    private Animator animator;
    private bool isDead = false;

    public int scoreValue = 10;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isDead) return;

        if (other.CompareTag("bullet"))
        {
            Die();
        }
    }

    public void Die()
    {
        isDead = true;

        // امتیاز دادن
        scoremanager.instance.AddScore(scoreValue);

        // اجرای انیمیشن مرگ
        animator.SetTrigger("Die");

        // قطع برخورد مجدد
        GetComponent<Collider>().enabled = false;

        // اگر AI داری خاموش کن
        // GetComponent<EnemyAI>().enabled = false;

        // حذف بعد از انیمیشن
        Destroy(gameObject, 2.5f);
    }
}
