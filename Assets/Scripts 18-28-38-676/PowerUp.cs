using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public enum PowerUpType
    {
        None,
        ShootEveryone
    }


    
    public abstract class PowerUp : MonoBehaviour
    {
        public PowerUpType powerUpType;

        public abstract void UsePowerUp();

}

