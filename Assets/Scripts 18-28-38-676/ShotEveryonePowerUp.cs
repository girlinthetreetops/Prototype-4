using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShotEveryonePowerUp : PowerUp
{
    private void Awake()
    {
        powerUpType = PowerUpType.ShootEveryone;
        powerUpDuration = 5f;
    }

    public override void StartPowerUp()
    {
        Debug.Log("Start continously shooting everyone");
        InvokeRepeating("Shoot", 0, 2);
    }

    public void Shoot()
    {

    }

    public override IEnumerator PowerUpCountdown(float powerUpDuration)
    {
        yield return new WaitForSeconds(powerUpDuration);
        Debug.Log("And now we end it");
    }

    public override void EndPowerUp()
    {
        Debug.Log("No need for this function");
    }
}