using UnityEngine;
using UnityEngine.UI;

public class PowerCore : MonoBehaviour
{

	public Text PowerText;
	public PlayerMovement movment;
	public int StartPower = 0;

	//Adds +5 to start power
	void OnTriggerEnter()
	{
		StartPower += 5;
		StartPowerAdder();
	}

	//Sets Text to start power
	void StartPowerAdder()
	{
		PowerText.text = StartPower.ToString();
	}
}