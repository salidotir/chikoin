using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObstackleCollide : MonoBehaviour {

    public GameObject HitObstackleText;
    public GameObject FadeOut;
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.GetComponent<PlayerControls>().enabled = false;
            HitObstackleText.SetActive(true);
            FadeOut.SetActive(true);

            StartCoroutine(restartLevel());
        }
    }

    IEnumerator restartLevel()
    {
        yield return new WaitForSeconds(3);
        GlobalCoins.coinCount = 0;
        SceneManager.LoadScene(1);
    }
}
