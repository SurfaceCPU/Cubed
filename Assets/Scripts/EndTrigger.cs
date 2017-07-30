using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManager gameManager;
	public PlayerMovement movement;

	void OnTriggerEnter()
	{
		gameManager.CompleteLevel();
		movement.enabled = false;
	}


}