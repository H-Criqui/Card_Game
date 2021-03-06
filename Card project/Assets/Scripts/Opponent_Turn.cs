﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opponent_Turn : MonoBehaviour
{
    public Text countText;
    public Text winText;
    public int Opponent_score;
    private Rigidbody2D rb;
    public bool stayed;

    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    public GameObject card7;
    public GameObject card8;
    public GameObject card9;
    public GameObject card10;
    public GameObject card11;
    public GameObject card12;
    public GameObject card13;
    public GameObject card14;
    public GameObject card15;
    public GameObject card16;
    public GameObject card17;
    public GameObject card18;
    public GameObject card19;
    public GameObject card20;
    public GameObject card21;
    public GameObject card22;
    public GameObject card23;
    public GameObject card24;
    public GameObject card25;
    public GameObject card26;
    public GameObject card27;
    public GameObject card28;
    public GameObject card29;
    public GameObject card30;
    public GameObject card31;
    public GameObject card32;
    public GameObject card33;
    public GameObject card34;
    public GameObject card35;
    public GameObject card36;
    public GameObject card37;
    public GameObject card38;
    public GameObject card39;
    public GameObject card40;
    public GameObject card41;
    public GameObject card42;
    public GameObject card43;
    public GameObject card44;
    public GameObject card45;
    public GameObject card46;
    public GameObject card47;
    public GameObject card48;
    public GameObject card49;
    public GameObject card50;
    public GameObject card51;
    public GameObject card52;
    public GameObject opponent_area;
    public GameObject player_area;
    public GameObject Hit;
    public GameObject Purse;

    List<GameObject> cards = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        cards.Add(card1);
        cards.Add(card2);
        cards.Add(card3);
        cards.Add(card4);
        cards.Add(card5);
        cards.Add(card6);
        cards.Add(card7);
        cards.Add(card8);
        cards.Add(card9);
        cards.Add(card10);
        cards.Add(card11);
        cards.Add(card12);
        cards.Add(card13);
        cards.Add(card14);
        cards.Add(card15);
        cards.Add(card16);
        cards.Add(card17);
        cards.Add(card18);
        cards.Add(card19);
        cards.Add(card20);
        cards.Add(card23);
        cards.Add(card24);
        cards.Add(card25);
        cards.Add(card26);
        cards.Add(card21);
        cards.Add(card22);
        cards.Add(card27);
        cards.Add(card28);
        cards.Add(card29);
        cards.Add(card36);
        cards.Add(card31);
        cards.Add(card32);
        cards.Add(card33);
        cards.Add(card34);
        cards.Add(card35);
        cards.Add(card37);
        cards.Add(card38);
        cards.Add(card39);
        cards.Add(card40);
        cards.Add(card41);
        cards.Add(card45);
        cards.Add(card46);
        cards.Add(card47);
        cards.Add(card42);
        cards.Add(card43);
        cards.Add(card44);
        cards.Add(card48);
        cards.Add(card49);
        cards.Add(card50);
        cards.Add(card51);
        cards.Add(card52);

        rb = GetComponent<Rigidbody2D>();
        Opponent_score = 0;
        SetCountText();
        winText.text = "";
    }



    // Update is called once per frame



    public void onClick()
    {
        while (Opponent_score < 17)
        {
            GameObject enemycard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            enemycard.transform.SetParent(opponent_area.transform, false);

            int temp = enemycard.GetComponent<Add_1>().Value;
            Opponent_score += temp;
            SetCountText();
            stayed = true;
        }

        if (Hit.GetComponent<DrawCards>().score > 21)
        {
            winText.text = "Bust! You Lose!";
        }
        else if (Opponent_score > 21)
        {
            winText.text = "Dealer Busted! You Win!";
            Purse.GetComponent<Bet_add25>().purseTotal += (2 * (Purse.GetComponent<Bet_add25>().bet_total_));
            Purse.GetComponent<Bet_add25>().setPurse();
        }
        else if (Opponent_score <= Hit.GetComponent<DrawCards>().score)
        {
            winText.text = "You Win!";
            Purse.GetComponent<Bet_add25>().purseTotal += (2 * (Purse.GetComponent<Bet_add25>().bet_total_));
            Purse.GetComponent<Bet_add25>().setPurse();
        }
        else
        {
            winText.text = "You Lose!";
        }


    }

    void SetCountText()
    {
        countText.text = "Dealer's score: " + Opponent_score.ToString();
    }

}
