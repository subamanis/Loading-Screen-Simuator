using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadButton : MonoBehaviour {

    public List<GameObject> Texts;
    public GameObject icon;
    public GameObject load;
    private float x = 0;

	
	// Update is called once per frame
	void Update () {
        if (x == 0)
        {
            StartCoroutine(ChangeText());
        }  
    }

    IEnumerator ChangeText()
    {
        x = 1;
        yield return new WaitForSecondsRealtime(1.5f);
        Texts[0].SetActive(false);
        Texts[1].SetActive(true);
        yield return new WaitForSecondsRealtime(1.5f);
        Texts[1].SetActive(false);
        Texts[2].SetActive(true);
        yield return new WaitForSecondsRealtime(1.5f);
        Texts[2].SetActive(false);
        Texts[0].SetActive(true);
        x = 0;
    }

    public void ShowLoad()
    {
        Texts[0].SetActive(true);
        load.SetActive(true);
        icon.SetActive(true);
    }
}
