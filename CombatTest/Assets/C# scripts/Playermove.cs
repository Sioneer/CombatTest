using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Playermove : MonoBehaviour
{
    //Параметры
    public int PlayerMovesLeft = 7;
    public int maxMoves;
    public Transform Pos1;
    public float speed = 5;
    public GameObject Flag;

    //Мувмент
    
    public void Start()
    {
        Instantiate(Flag, Pos1.position, Pos1.rotation); 
    }
    public void Movement(Transform Pos2)
    {
        Pos1 = Pos2;
    }
    public void Minus()
    {
        if(PlayerMovesLeft>=0)
        {
            PlayerMovesLeft--;
        }
    }
    public void Update()
    {
        if(PlayerMovesLeft>=0)
        {
            transform.position = Vector2.MoveTowards(transform.position, Pos1.position, speed*Time.deltaTime);
        }
    }
    public void MovesUpdate()
    {
        Flag = GameObject.FindWithTag("flag");
        Flag flag = Flag.GetComponent<Flag>();
        flag.DestroyMe();
        Instantiate(Flag, Pos1.position, Pos1.rotation);
    }
    public void BringMeBack()
    {
        Flag = GameObject.FindWithTag("flag");
        Flag flag = Flag.GetComponent<Flag>();
        flag.BringPlayerBack();
    }
    //Апдейт
    public void AllUpdate()
    {
        PlayerMovesLeft = maxMoves;
    }
}
