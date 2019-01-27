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
        Debug.LogWarning("Started the house");
        if (expected > Finish.remainingOnes)
			Finish.remainingOnes = expected;
	}

	private void OnTriggerEnter(Collider other)
	{
        Debug.LogWarning("Entered House");

		if (other.gameObject.name.Contains("Buddy")){
            Debug.LogWarning("It is Buddy");
            if (other.gameObject.name.Contains("BlueBuddy") && houseColor == BuddyColor.BLUE)
			{
                Debug.LogWarning("Blue Buddy Here");
                numberBuddy[0]--;
				remainingOnes--;
			}
			else if (other.gameObject.name.Contains("RedBuddy") && houseColor == BuddyColor.RED)
			{
                Debug.LogWarning("RED Buddy Here");
                numberBuddy[1]--;
				remainingOnes--;
			}
			else if(other.gameObject.name.Contains("GreenBuddy") && houseColor == BuddyColor.GREEN)
			{
                Debug.LogWarning("GREEN buddy here");
                numberBuddy[2]--;
				remainingOnes--;
			}
            Debug.LogWarning("Checking for victory");
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
