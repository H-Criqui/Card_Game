using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Score;
    public Text DealerScore;
    public Text winText;
    public GameObject Hit;
    public GameObject Stay;
    private GameObject[] Cards;
    public Text Bets;
    public GameObject Bet;
    void Start()
    {
       
    }

    public void OnClick()
    {
        winText.text = "";
        Stay.GetComponent<Opponent_Turn>().Opponent_score = 0;
        Hit.GetComponent<DrawCards>().score = 0;
        Stay.GetComponent<Opponent_Turn>().stayed = false;
        Hit.GetComponent<DrawCards>().countText.text = "Score: 0";
        Stay.GetComponent<Opponent_Turn>().countText.text = "Dealer's score: 0";
        Bets.text = "Bet Total: ";
        Bet.GetComponent<Bet_add25>().bet_total_ = 0;
        

        Cards = GameObject.FindGameObjectsWithTag("card");
        for(int i = 0; i < Cards.Length; i ++)
        {
           Destroy(Cards[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
