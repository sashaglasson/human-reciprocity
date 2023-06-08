using UnityEngine;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine.UI;
public class ButtonAnimation {

    private GameObject forwards;
    private GameObject backwards;


    public ButtonAnimation(GameObject forwards, GameObject backwards) {

        this.forwards = forwards;
        this.backwards = backwards;

    }


    public void run() {
        Thread.Sleep(5000);

    }

}