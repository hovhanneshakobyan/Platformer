using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{




    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<Player>().keys >= 2)
                    Destroy(gameObject);

        }








    }
}
