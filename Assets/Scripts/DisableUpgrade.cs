using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableUpgrade : MonoBehaviour {

    public List<GameObject> Upgrades;
    public List<GameObject> Icons;
    public List<GameObject> MainPanelUpgradeButtons;
    public GameObject p;
    public List<int> Prices;
	
    public void PurchaseUpgrade(string name)
    {
        switch (name)
        {
            case "Load":
                if(Prices[0] <= p.GetComponent<NewBehaviourScript>().getMoney())
                {
                    Upgrades[0].SetActive(false);
                    Icons[0].SetActive(true);
                    p.GetComponent<NewBehaviourScript>().setMoney(p.GetComponent<NewBehaviourScript>().getMoney() - Prices[0]);
                }     
                break;
            case "ShowTime":
                if (Prices[3] <= p.GetComponent<NewBehaviourScript>().getMoney())
                {
                    Upgrades[3].SetActive(false);
                    Icons[3].SetActive(true);
                    p.GetComponent<NewBehaviourScript>().setMoney(p.GetComponent<NewBehaviourScript>().getMoney() - Prices[3]);
                }
                break;
            case "Cmd":
                if (Prices[2] <= p.GetComponent<NewBehaviourScript>().getMoney())
                {
                    Upgrades[2].SetActive(false);
                    MainPanelUpgradeButtons[0].SetActive(true);
                    p.GetComponent<NewBehaviourScript>().setMoney(p.GetComponent<NewBehaviourScript>().getMoney() - Prices[2]);
                }
                break;
            case "HalveTime":
                if (Prices[4] <= p.GetComponent<NewBehaviourScript>().getMoney())
                {
                    Upgrades[4].SetActive(false);
                    Icons[4].SetActive(true);
                    p.GetComponent<NewBehaviourScript>().setMoney(p.GetComponent<NewBehaviourScript>().getMoney() - Prices[4]);
                }
                break;
            case "Browser":
                if(Prices[1] <= p.GetComponent<NewBehaviourScript>().getMoney())
                {
                    Upgrades[1].SetActive(false);
                    MainPanelUpgradeButtons[1].SetActive(true);
                    p.GetComponent<NewBehaviourScript>().setMoney(p.GetComponent<NewBehaviourScript>().getMoney() - Prices[1]);
                }     
                break;
            case "Pong":
                if (Prices[5] <= p.GetComponent<NewBehaviourScript>().getMoney())
                {
                    Upgrades[5].SetActive(false);
                    MainPanelUpgradeButtons[2].SetActive(true);
                    p.GetComponent<NewBehaviourScript>().setMoney(p.GetComponent<NewBehaviourScript>().getMoney() - Prices[5]);
                }
                break;
        }

    }

    private void Start()
    {
        p = GameObject.Find("EmptyWithScripts");
    }

}
