using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InternetExplorer : MonoBehaviour {

    public GameObject IEPanel;
    public Image Toolbars;
    private float timer;
    private bool IEisActive;
    private float totalLoadingTime = 4;

	// Use this for initialization
	void Start () {
        IEisActive = false;
    }

    // Update is called once per frame
    void Update()
    {
            if (IEisActive)
            {
                totalLoadingTime -= Time.deltaTime;
                if (totalLoadingTime <= 0)
                {
                    Toolbars.enabled = true;
                }
            }
    }

    public void ShowIePanel()
    {
        IEPanel.SetActive(true);
        IEisActive = true;
    }

    public void CloseIEPanel()
    {
        totalLoadingTime = 4;
        IEPanel.SetActive(false);
        IEisActive = false;
    }
}
