using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWinningScreen : MonoBehaviour {

    public GameObject p;

    public void CloseButton()
    {
        p.gameObject.SetActive(false);
    }


}
