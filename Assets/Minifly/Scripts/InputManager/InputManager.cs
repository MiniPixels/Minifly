using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	
	void Start ()
    {
        var game = GameObject.Find("GameobjectContainer").GetComponent<GameObjectContainer>();
        var window = game.GetWindowByName("ShopWindow");
        window.SetActive(true);
	}
	
	
}
