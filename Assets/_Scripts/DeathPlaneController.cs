using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;

    void OnTriggerEnter(Collider other)
    {//check if the object that triggers a collision is the player
        if (other.gameObject.CompareTag("Player"))
        {
            //geta reference to the player's CharacterController
            var controller = other.gameObject.GetComponent<CharacterController>();
            //turn contr. off
            controller.enabled = false;
            //move the player to spawnpoint
            other.gameObject.transform.position = spawnPoint.position;
            //turn on contr.
            controller.enabled = true;
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        //geta reference to the player's CharacterController
    //        var controller = collision.gameObject.GetComponent<CharacterController>();
    //        //turn contr. off
    //        controller.enabled = false;
    //        //move the player to spawnpoint
    //        collision.gameObject.transform.position = spawnPoint.position;
    //        //turn on contr.
    //        controller.enabled = true;
    //    }
    //}
}
