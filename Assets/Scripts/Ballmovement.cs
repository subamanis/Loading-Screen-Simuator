using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour {


    public int ballVertDirection = 1;
    public int ballHorDirection = 1;
    public GameObject PongMinigame;


    // Update is called once per frame
    void Update () {
        transform.Translate(new Vector3(70f*ballHorDirection, ballVertDirection * 160f, 0) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("LeftRightCol")){
            ballHorDirection *= -1;
        }
        else if (col.gameObject.name.Equals("UpCol") || col.gameObject.name.Equals("Line"))
        {
            ballVertDirection *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("DownCol"))
        {
            youLose();
        }
    }

    public void youLose()
    {
        gameObject.transform.position = new Vector3(452, 197, 165);
        PongMinigame.SetActive(false);
    }

    public void StartGame()
    {
        gameObject.transform.position = new Vector3(352, 117, 165);
        PongMinigame.SetActive(true);
    }
}

