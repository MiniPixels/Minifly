using Assets.Minifly.Scripts.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GameObjectContainer : MonoBehaviour
{

    private Dictionary<string, GameObject> _windows;

    private Dictionary<string, List<Text>> _windowtexts;
    [HideInInspector]
    public static Dictionary<string, Button> Button;

    private void Start()
    {
        _windows = new Dictionary<string, GameObject>();
        _windowtexts = new Dictionary<string, List<Text>>();
        GenerateButtonList();
        FillWindows();
      
    }

    private void GenerateButtonList()
    {
        Button = new Dictionary<string, Button>();
        var buttons = FindObjectsOfType<Button>();
        foreach (var button in buttons)
        {
            Button.Add(button.name, button);
        }
        Debug.Log(buttons.Length);
    }

    private void FillWindows() //To do Cut code
    {
        _windows.Add(Strings.ShopWindow, GameObject.Find(Strings.ShopWindow));
        _windows.Add(Strings.GarageWindow, GameObject.Find(Strings.GarageWindow));
        _windows.Add(Strings.HighscoreWindow, GameObject.Find(Strings.HighscoreWindow));
        _windows.Add(Strings.SettingsWindow, GameObject.Find(Strings.SettingsWindow));
        _windows.Add(Strings.MessageWindow, GameObject.Find(Strings.MessageWindow));
        _windows.Add(Strings.ProfileWindows, GameObject.Find(Strings.ProfileWindows));
        _windowtexts.Add(Strings.ShopWindow, GetWindowByName(Strings.ShopWindow).GetComponentsInChildren<Text>().ToList());
        _windowtexts.Add(Strings.GarageWindow, GetWindowByName(Strings.GarageWindow).GetComponentsInChildren<Text>().ToList());
        _windowtexts.Add(Strings.HighscoreWindow, GetWindowByName(Strings.HighscoreWindow).GetComponentsInChildren<Text>().ToList());
        _windowtexts.Add(Strings.SettingsWindow, GetWindowByName(Strings.SettingsWindow).GetComponentsInChildren<Text>().ToList());
        _windowtexts.Add(Strings.MessageWindow, GetWindowByName(Strings.MessageWindow).GetComponentsInChildren<Text>().ToList());
        DisableWindows();
    }


  

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void DisableWindows()
    {
       
        foreach (var window in _windows)
        {
            window.Value.SetActive(false);
        }
        
    }

  
    public GameObject GetWindowByName(string windowName)
    {
        try
        {
            return _windows.Where(x => x.Key.Contains(windowName)).SingleOrDefault().Value;
        }
        catch (System.Exception)
        {
           
            throw new KeyNotFoundException(Strings.WindowNotFound);
        }
    }
    public Text GetWindowsTextByName(string windowName, string textName)
    {
        try
        {
            return _windowtexts.SingleOrDefault(item => item.Key == windowName).Value.SingleOrDefault(but => but.name == textName);
        }
        catch (System.Exception)
        {
            throw new KeyNotFoundException(Strings.TextNotFound);
        }
    }

}
