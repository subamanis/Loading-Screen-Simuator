using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopIsActive : MonoBehaviour {

    public GameObject p;
    private int counter = 0;
	
    public void IsActive()
    {
        counter++;
        if (counter % 2 == 1)  
        {
            p.gameObject.SetActive(true);
        }
        else 
        {
            p.gameObject.SetActive(false);        }
    }

}
