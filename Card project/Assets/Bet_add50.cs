using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bet_add50 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Text bet_total;
    
    public Text purse;
    
    public GameObject add25;
    public void OnClick()
    {
        add25.GetComponent<Bet_add25>().bet_total_ += 50;
        setBet();
        add25.GetComponent<Bet_add25>().purseTotal -= 50;
        setPurse();
    }

    private void setBet()
    {
        bet_total.text = "Bet Total: " + add25.GetComponent<Bet_add25>().bet_total_;
    }

    private void setPurse()
    {
        purse.text = "Total Cash: " + add25.GetComponent<Bet_add25>().purseTotal;
    }
}
