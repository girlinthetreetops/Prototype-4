using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUpManager : MonoBehaviour
{
    public bool hasPowerUp = false;

    private PowerUp currentPowerUp;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            //collect a ref to this powerup class...
            currentPowerUp = collision.gameObject.GetComponent<PowerUp>();

            //update bool
            hasPowerUp = true;

            //Remove the powerup thing
            Destroy(collision.gameObject);

            //Use the function on this powerup type
            currentPowerUp.StartPowerUp();
        }
    }

}
