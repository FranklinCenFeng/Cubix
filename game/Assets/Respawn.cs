using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Respawn : MonoBehaviour
{
    public int Respawn1;

    void Start()
{

}
    void Update(){

    }

    void OnTriggerEnter(Collider other){
        
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Respawn1);
        }
    
    }
}
