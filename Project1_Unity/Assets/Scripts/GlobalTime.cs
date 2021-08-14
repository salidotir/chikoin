using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTime : MonoBehaviour {

	public GameObject timeDisplay;
	public int seconds = 30;
	public bool is_time_finished;

	// Update is called once per frame
	void Update () {
		if (is_time_finished == false)
        {
			is_time_finished = true;
			StartCoroutine(reduceSeconds());
        }
	}

	IEnumerator reduceSeconds()
    {
		yield return new WaitForSeconds(1);
		seconds -= 1;
		timeDisplay.GetComponent<Text>().text = "Time: " + seconds;
		is_time_finished = false;
    }
}
