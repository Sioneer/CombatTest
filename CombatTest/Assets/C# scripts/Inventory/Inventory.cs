using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject sin_shluhi;
    public GameObject[] slots;
    public GameObject[] items;

    public void Start(){
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = null;
        }
    }
}
