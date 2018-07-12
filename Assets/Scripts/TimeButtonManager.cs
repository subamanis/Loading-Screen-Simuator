using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeButtonManager : MonoBehaviour {

    public List<string> Remaining;
    public GameObject textList;
    public GameObject textField;
    private int checker = 0;

    private void Start()
    {
        Remaining = new List<string>();
        Remaining.Add("Application not responding."); Remaining.Add( "99% complete");
        Remaining.Add("Estimated time 33d 13h 29m 23s"); Remaining.Add("I lost the count");
        textList.GetComponent<Text>().text = "Remaining time: " + Remaining[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (checker == 0)
        {
            StartCoroutine(ChangeTimeText());
            print(checker);
        }
    }

    IEnumerator ChangeTimeText()
    {
        checker = 1;
        yield return new WaitForSecondsRealtime(15f);
        textList.GetComponent<Text>().text = "Remaining time: " + Remaining[1];
        yield return new WaitForSecondsRealtime(15f);
        textList.GetComponent<Text>().text = "Remaining time: " + Remaining[2];
        yield return new WaitForSecondsRealtime(15f);
        textList.GetComponent<Text>().text = "Remaining time: " + Remaining[3];
        checker = 0;
    }

    public void EnableTextField()
    {
        textField.SetActive(true);
    }

}
