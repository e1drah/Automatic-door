using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTiggerEntered : MonoBehaviour
{
    public GameObject door;
    public int speed;
    private bool open = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            open = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            open = false;

        }
    }
    private void Update()
    {
        if (open == true)
        {
            if (door.transform.position.y < (door.transform.localScale.y * 1.5))
            {
                door.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }
        if (open == false)
        {
            if (door.transform.position.y > 0)
            {
                door.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
}
