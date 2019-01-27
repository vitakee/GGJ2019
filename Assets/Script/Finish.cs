using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

	static int[] numberBuddy = new int[3];
	static int remainingOnes = 1;

	public enum BuddyColor {BLUE,RED,GREEN };
	public BuddyColor houseColor;
	public LayerMask buddyLayer;
	public int expected;

    void Start()
    {
		if (expected > Finish.remainingOnes)
			Finish.remainingOnes = expected;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name.Contains("Buddy")){
			if (other.gameObject.name.Contains("BlueBuddy") && houseColor == BuddyColor.BLUE)
			{
				numberBuddy[0]--;
				remainingOnes--;
			}
			else if (other.gameObject.name.Contains("RedBuddy") && houseColor == BuddyColor.RED)
			{
				numberBuddy[1]--;
				remainingOnes--;
			}
			else if(other.gameObject.name.Contains("GreenBuddy") && houseColor == BuddyColor.GREEN)
			{
				numberBuddy[2]--;
				remainingOnes--;
			}
			CheckForVictory();
		}
	}


	public void CheckForVictory()
	{
		if (remainingOnes <= 0)
		{
			Debug.Log("Load new level");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
