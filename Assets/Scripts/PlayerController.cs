using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public GUIText countText;
	public GUIText winText;
	public GUIText descText;
	public GUIText timerText;
	public bool keysEnabled;
	private int count;


	void Start ()
	{
		count = 0;
		SetCountText ();
		winText.text = "";
		timerText.text = "0" + " Seconds";
	}

	void Update ()
	{
		timerText.text = Time.deltaTime + " Seconds";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if(count >= 0)
		{
			descText.text = "C'mon Hurry Up";
			Debug.Log("Game Start");
		}
		if(count >= 1)
		{
			descText.text = "You Suck.";
		}
		if(count >= 4)
		{
			descText.text = "Okay...";
		}
		if(count >= 7)
		{
			descText.text = "Alright, You're Getting There";
		}
		if(count >= 10)
		{
			descText.text = "ALMOST THERE!";
		}
		if(count >= 13)
		{
			Application.LoadLevel(2);
		}
	}
}
