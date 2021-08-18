using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTime : MonoBehaviour {

	public GameObject timeDisplay;
	public int seconds = 30;
	public bool is_time_finished;

	public GameObject TimeUpText;
	public GameObject FadeOut;
	public GameObject Player;

	// Update is called once per frame
	void Update () {
		if (seconds == 0)
		{
			Player.GetComponent<PlayerControls>().enabled = false;
			seconds = 0;
			TimeUpText.SetActive(true);
			FadeOut.SetActive(true);

			StartCoroutine(restartLevel());
		}
		else
		{
			if (is_time_finished == false)
			{
				is_time_finished = true;

				StartCoroutine(reduceSeconds());
			}
		}
	}

	IEnumerator reduceSeconds()
    {
		yield return new WaitForSeconds(1);
		seconds -= 1;
		timeDisplay.GetComponent<Text>().text = "Time: " + seconds;
		is_time_finished = false;
    }

	IEnumerator restartLevel()
    {
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(1);
	}
}
