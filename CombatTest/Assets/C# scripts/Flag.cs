using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public Transform ResetPos;
    public float speed;
    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, ResetPos.position, speed*Time.deltaTime);
    }
    public void GiveMePos(Transform Pos1)
    {
        ResetPos = Pos1;
    }
}