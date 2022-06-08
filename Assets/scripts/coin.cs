using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int money=1;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Player>().score += money;
            Debug.Log(other.GetComponent<Player>().score);
            Destroy(gameObject);
        }
    }
}
