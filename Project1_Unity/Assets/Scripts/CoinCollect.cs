using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour {

    public AudioSource collectFX;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collectFX.Play();
            GlobalCoins.coinCount += 1;
            this.gameObject.SetActive(false);
        }
    }
}
