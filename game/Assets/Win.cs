using UnityEngine;
using System.Collections.Generic;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){

        GameObject.Find("Player").SendMessage("Finnish");
    }
}
