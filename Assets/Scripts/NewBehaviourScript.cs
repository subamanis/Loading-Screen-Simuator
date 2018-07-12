using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public Text moneyText;
    private  double moneyCounter=0;
    private double randomTemp;
	
    public void IncreaseMoney()
    {
        randomTemp = Random.Range(0, 4f);
        moneyCounter+=randomTemp; 
    }

    public  void setMoney(double money)
    {
        moneyCounter = money;
    }

    public  double getMoney()
    {
        return moneyCounter;
    }

    private void Update()
    {
        moneyText.text = "Money: " + moneyCounter.ToString("0.00");
    }

}
