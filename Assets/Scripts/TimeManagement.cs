using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManagement : MonoBehaviour {

    public List<GameObject> greenBars;
    public GameObject time;
    public static int flag = 0;
    private float timer = 0;
    private float x = 0;
    private int dividetime = 1;


    void Update() {
        timer += Time.deltaTime;
        time.GetComponent<Text>().text = "Time Played: " + timer.ToString("0.00");
        if (timer >= x+5f/dividetime && flag<=10)
        {
            x += 5f/dividetime;
            greenBars[flag].SetActive(true);
            flag++;
        }
	}

    public static int getFlag()
    {
        return flag;
    }

    public void setDivideTime()
    {
        dividetime = 2;
    }

    public void EnbaleTimer()
    {
        time.SetActive(true);
    }

}
