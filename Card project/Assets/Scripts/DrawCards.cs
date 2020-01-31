using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject opponent_area;
    public GameObject player_area;

    List<GameObject> cards = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        cards.Add(card1);
        cards.Add(card2);
    }

    public void onClick()
    {
        for(int i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(player_area.transform, false);

            GameObject enemycard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            enemycard.transform.SetParent(opponent_area.transform, false);
        }
        
    }

}
