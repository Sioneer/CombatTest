using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    private Playermove player;
    public int i;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Playermove>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount<=0){
            inventory.isFull[i] = false;
        }
    }
    public void DropItem(){
        foreach(Transform child in transform){
            
            child.GetComponent<Spawn>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
            player.SubStats(child.GetComponent<ItemTest>().Damage,
            child.GetComponent<ItemTest>().Protection,
            child.GetComponent<ItemTest>().MoveDistance);
            inventory.items[i] = null;
        }
    }
}
