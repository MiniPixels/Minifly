using Assets.Minifly.Scripts.Helpers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	
	void Start ()
    {
        var game = GameObject.Find(Strings.GameobjectContainer).GetComponent<GameObjectContainer>();
        var window = game.GetWindowByName(Strings.ShopWindow);
        window.SetActive(true);
	}
	
	
}
