using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIcon : MonoBehaviour {

    public bool isClicked = false;

	void Update () {
        if (isClicked)
        {
            transform.Rotate(0, 0, -140 * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, -58 * Time.deltaTime);
        }
    }

    public void Clicked()
    {
        isClicked = true;
    }
}
