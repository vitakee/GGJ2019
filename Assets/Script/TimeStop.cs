using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeStop : MonoBehaviour
{
	Text errorText;

	private void Start()
	{
		errorText.GetComponentInChildren<Text>();
	}

	public void StopTime()
	{
		Time.timeScale = 0;

	}
}
