using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI部品を使うために必要!

public class GameDirector : MonoBehaviour {

    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "ゴールまで" + length.ToString("F2") + "m";
        //0.1以下なら「★★★」、0.2以下なら「★★」、0.5以下なら「★」、行きすぎたら「:どくろ:」。
        if (length < 0) {
            this.distance.GetComponent<Text>().text += "\n☠";
        }
        else if (length < 0.1f) {
            this.distance.GetComponent<Text>().text += "\n★★★";
        }
        else if (length < 0.2f) {
            this.distance.GetComponent<Text>().text += "\n★★";
        }
        else if (length < 0.5f) {
            this.distance.GetComponent<Text>().text += "\n★";
        }

    }
}