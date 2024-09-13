using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public Transform ResetPos;
    public GameObject player;
    public float speed;
    public void DestroyMe()
    {
        Destroy(gameObject);
    }
    public void BringPlayerBack()
    {
        player = GameObject.FindWithTag("Player");
        Playermove playermove = player.GetComponent<Playermove>();
        playermove.Movement(ResetPos);
    }
}