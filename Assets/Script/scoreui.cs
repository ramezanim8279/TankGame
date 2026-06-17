using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using TMPro;

public class scoreui : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        
        scoreText.text = "score :" + scoremanager.instance.score;

       
    }
}
