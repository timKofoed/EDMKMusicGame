using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	public int health = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Denne funktion s�ttes ind i selve animationen i Animation vinduet som en "Animation Event"
	public void EndAnimation()
	{
		Debug.Log ("Health: " + health);
		health -= 5;
	}

	// Denne funktion virker n�r musen trykkes p� et GameObject som har en Collider
	public void OnMouseDown()
	{
		Debug.Log ("CLICK");
	}
}
