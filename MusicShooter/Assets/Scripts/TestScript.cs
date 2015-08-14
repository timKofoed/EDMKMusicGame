using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	public Texture2D newImage;	//Et nyt billede som skal sættes på cursor'en. Husk at sætte den til "Cursor", og ikke "Texture"
	public Vector2 cursorHotspot;

	// Use this for initialization
	void Start () 
	{
		// Det ser ud til at der er et problem i Unity's editor, hvor hvis man prøver justere "hotspot" for billedet, så skal man gøre det et par gange:
		// En Coroutine kan "vente" til næste frame, så vi sætter funktionen derind, så vi kan lave ændringer over flere frames
		StartCoroutine( "SetCursor" );
	}
	
	IEnumerator SetCursor()
	{
		Vector2 newHotspot = new Vector2 (newImage.width / 2, newImage.height / 2);

		yield return new WaitForEndOfFrame();	//Vent til næste frame
		Cursor.visible = false;
		cursorHotspot = newHotspot;
		Cursor.SetCursor(newImage, cursorHotspot, CursorMode.Auto);
		Cursor.visible = true;

		yield return new WaitForEndOfFrame();	//Vent til næste frame
		Cursor.visible = false;
		cursorHotspot = newHotspot;
		Cursor.SetCursor(newImage, cursorHotspot, CursorMode.Auto);
		Cursor.visible = true;

	}
}
