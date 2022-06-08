using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keys : MonoBehaviour
{
    public int key; 
    



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Player>().keys += key;
            Debug.Log(other.GetComponent<Player>().keys);
            Destroy(gameObject);
        }
    }
}












