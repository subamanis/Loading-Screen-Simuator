using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour {

    private int flag;
    public GameObject p;

    void Update () {
        flag = TimeManagement.getFlag();
        if (flag == 10)
        {          
            p.gameObject.SetActive(true);
        }
	}
}
