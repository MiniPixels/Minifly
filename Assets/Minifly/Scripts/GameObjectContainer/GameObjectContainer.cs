using Assets.Minifly.Scripts.Helpers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameObjectContainer : MonoBehaviour {

    private Dictionary<string, GameObject> _windows;
   

	
	private void Start ()
    {
        _windows = new Dictionary<string, GameObject>();
        FillWindows();
	}

    private void FillWindows()
    {
        _windows.Add(Strings.ShopWindow, GameObject.Find(Strings.ShopWindow));
        _windows.Add(Strings.GarageWindow, GameObject.Find(Strings.GarageWindow));
        _windows.Add(Strings.HighscoreWindow, GameObject.Find(Strings.HighscoreWindow));
        _windows.Add(Strings.SettingsWindow, GameObject.Find(Strings.SettingsWindow));
        _windows.Add(Strings.MessageWindow, GameObject.Find(Strings.MessageWindow));

        DisableWindows();
    }

    private void DisableWindows()
    {
        foreach (var window in _windows)
        {
            window.Value.SetActive(false);
        }
    }

    public GameObject GetWindowByName(string name)
    {
        return _windows.Where(x => x.Key.Contains(name)).SingleOrDefault().Value;
    }
}
