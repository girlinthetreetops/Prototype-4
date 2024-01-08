using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShotEveryonePowerUp : PowerUp
{
    //vars specific to sub-class
    private GameObject player;

    private GameObject bulletPrefab;
    private GameObject tempBulletReference;

    private void Awake()
    {

        //inherited variable establishment
        powerUpType = PowerUpType.ShootEveryone;

        //vars specific to sub-class
        player = GameObject.Find("Player");
    }

    public override void UsePowerUp()
    {
        Debug.Log("Start continously shooting everyone");
        InvokeRepeating("Shoot", 0, 2);
    }

    public void Shoot()
    {
        foreach (var enemy in FindObjectsOfType<Enemy>())
        {
            //tempBulletReference = Instantiate(bulletPrefab, transform.position + Vector3.up, Quaternion.identity);
            //tempBulletReference.GetComponent<Bullet>().Shoot(enemy.transform);

        }
    }
}