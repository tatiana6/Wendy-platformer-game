﻿using UnityEngine;
using System.Collections;

public class PoluprigScript : MonoBehaviour {

    public bool trigger = false;
    //обращ к скрипту с глобальной перем
    public imaVoronaScript ima;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "voron")
        {
            if (Random.value < 0.5)
            {
                //воронномер=получаем имя ворона
                ima.imaVorona = other.name;
                trigger = true;
            }
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "voron")
        {
            ima.imaVorona = "";
            trigger = false;
        }

    }
}
