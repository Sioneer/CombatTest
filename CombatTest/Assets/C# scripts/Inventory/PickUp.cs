using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
        void OnTriggerEnter2D(Collider2D other){
            if(other.CompareTag("Player")){
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    switch(gameObject.tag){
                        case "Weapon":
                            if(inventory.isFull[0] == false){
                                Adder(0);
                            }
                        break;
                        case "SecondaryWeapon":
                            if(inventory.isFull[1] == false){
                                Adder(1);
                            }
                        break;
                        case "Armor":
                            if(inventory.isFull[2] == false){
                                Adder(2);
                            }
                        break;
                    }
                }
            }
        }
        public void Adder(int i ){
            inventory.isFull[i] = true;
            inventory.items[i] = itemButton;
            Instantiate(itemButton, inventory.slots[i].transform, false);
            Destroy(gameObject);
        
        }
}
