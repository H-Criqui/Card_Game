using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_calculator : MonoBehaviour
{
    public Text countText;
    public Text winText;
    private int score;
    private Rigidbody2D rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider other) 
        {
           if (other.gameObject.CompareTag("card"))
            {
                int temp;
                temp = other.GetComponent<Add_1>().Value;
                score += temp;
                SetCountText();
            }
        }

        if(score > 21)
        {
            winText.text = "Bust!";
        }
        
    }

    void SetCountText()
    {
        countText.text = "Score: " + score.ToString();
    }

   
}
