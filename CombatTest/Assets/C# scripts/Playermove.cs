using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Playermove : MonoBehaviour
{
    //Параметры
    public int maxDamage;
    public int maxMoves;
    public int maxDefence;

    public int BonusDamage;
    public int BonusMoves;
    public int BonusDefence;


    public int PlayerMovesLeft = 7;
    public Transform Pos1;
    public float speed = 5;
    public GameObject Flag;
    public Inventory inv;

    //Мувмент
    
    public void Start()
    {
        inv = GetComponent<Inventory>();
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
    /*
    0 - оружие
    1 - доп. оружие
    2 - броня
    3 - артефакт 1 (голова)
    4 - артефакт 2 (руки)
    5 - артефакт 3 (грудь)
    6 - артефакт 4 (ноги)
    */
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
