using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellScript : MonoBehaviour
{
    //Параметры
    
    public GameObject player;
    bool CanMoveHere = false;
    public bool Wall = false;
    public Transform pos2;
    public bool StayHere = false;
    //Мув
    
    void OnTriggerEnter2D (Collider2D other)
    {
        CanMoveHere = true;
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        CanMoveHere = false;
    }
    public void Click()
    {
        if(CanMoveHere==true && Wall ==false && StayHere== false)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            Playermove playermove = player.GetComponent<Playermove>();
            playermove.Movement(pos2);
            playermove.Minus();
            //Debug.Log("Click!");
            
        }
    }
    Collider2D Stay(){
        Collider2D[] Stay = Physics2D.OverlapCircleAll(pos2.position, 0.005f);
        foreach(Collider2D player in Stay)
        {
            if (player.CompareTag("Player"))
            {
                return player;
            }
            
        }
        return null;
    }
    void Update()
    {
        if (Stay() != null)
        {
            StayHere = true;
        }
        else
        {
            StayHere = false;
        }
    }
}
