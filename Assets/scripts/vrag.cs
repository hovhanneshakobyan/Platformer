using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : MonoBehaviour
{
    public float speed = 5;
    public Vector3 pos;
    public int demage = 1;


    private void Update()
    {
        pos.z = speed;
        transform.Translate(pos * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        speed = speed * -1;

        if (other.tag == "Player")
        {
            other.GetComponent<Player>().health -= demage;
            Debug.Log(other.GetComponent<Player>().health);


        }
    }
}



