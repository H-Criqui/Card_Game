using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bet_add25 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bet_total_ = 0;
        purseTotal = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Text bet_total;
    public int bet_total_;
    public Text purse;
    public int purseTotal;
    public void OnClick()
    {
        bet_total_ += 25;
        setBet();
        purseTotal -= 25;
        setPurse();
    }

    public void setBet()
    {
        bet_total.text = "Bet Total: " + bet_total_;
    }

    public void setPurse()
    {
        purse.text = "Total Cash: " + purseTotal;
    }
}
