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
        public float powerUpDuration = 5f;

        public abstract void StartPowerUp();
        public abstract IEnumerator PowerUpCountdown(float duration);
        public abstract void EndPowerUp();
}

