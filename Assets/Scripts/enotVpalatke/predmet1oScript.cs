﻿using UnityEngine;
using System.Collections;

public class predmet1oScript : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;

    private void OnMouseDown()
    {
        if (enotVpalatke.predmet10enot == 1)
        {
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
