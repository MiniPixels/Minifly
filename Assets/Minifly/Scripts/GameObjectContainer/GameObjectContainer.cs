using Assets.Minifly.Scripts.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GameObjectContainer : MonoBehaviour
{

    private Dictionary<string, GameObject> _windows;

    private Dictionary<string, List<Button>> _windowbuttons;

    private Dictionary<string, List<Text>> _windowtexts;

    private Dictionary<string, List<Button>> _uiSubWindowButtons;
    private void Start()
    {
        _windows = new Dictionary<string, GameObject>();
        _windowbuttons = new Dictionary<string, List<Button>>();
        _windowtexts = new Dictionary<string, List<Text>>();
        _uiSubWindowButtons = new Dictionary<string, List<Button>>(); 
        FillWindows();
    }

   
    private void FillWindows()
    {
        _windows.Add(Strings.ShopWindow, GameObject.Find(Strings.ShopWindow));
        _windows.Add(Strings.GarageWindow, GameObject.Find(Strings.GarageWindow));
        _windows.Add(Strings.HighscoreWindow, GameObject.Find(Strings.HighscoreWindow));
        _windows.Add(Strings.SettingsWindow, GameObject.Find(Strings.SettingsWindow));
        _windows.Add(Strings.MessageWindow, GameObject.Find(Strings.MessageWindow));
        _windows.Add(Strings.ProfileWindows, GameObject.Find(Strings.ProfileWindows));

        _windowbuttons.Add(Strings.ShopWindow, GetWindowByName(Strings.ShopWindow).GetComponentsInChildren<Button>().ToList());
        _windowbuttons.Add(Strings.GarageWindow, GetWindowByName(Strings.GarageWindow).GetComponentsInChildren<Button>().ToList());
        _windowbuttons.Add(Strings.HighscoreWindow, GetWindowByName(Strings.HighscoreWindow).GetComponentsInChildren<Button>().ToList());
        _windowbuttons.Add(Strings.SettingsWindow, GetWindowByName(Strings.SettingsWindow).GetComponentsInChildren<Button>().ToList());
        _windowbuttons.Add(Strings.MessageWindow, GetWindowByName(Strings.MessageWindow).GetComponentsInChildren<Button>().ToList());
        _windowbuttons.Add(Strings.ProfileWindows, GetWindowByName(Strings.ProfileWindows).GetComponentsInChildren<Button>().ToList());

        _windowtexts.Add(Strings.ShopWindow, GetWindowByName(Strings.ShopWindow).GetComponentsInChildren<Text>().ToList());
        _windowtexts.Add(Strings.GarageWindow, GetWindowByName(Strings.GarageWindow).GetComponentsInChildren<Text>().ToList());
        _windowtexts.Add(Strings.HighscoreWindow, GetWindowByName(Strings.HighscoreWindow).GetComponentsInChildren<Text>().ToList());
        _windowtexts.Add(Strings.SettingsWindow, GetWindowByName(Strings.SettingsWindow).GetComponentsInChildren<Text>().ToList());
        _windowtexts.Add(Strings.MessageWindow, GetWindowByName(Strings.MessageWindow).GetComponentsInChildren<Text>().ToList());

        _uiSubWindowButtons.Add(Strings.FirstSubWindow, GameObject.Find(Strings.FirstSubWindow).GetComponentsInChildren<Button>().ToList());
        _uiSubWindowButtons.Add(Strings.SecondSubWindow, GameObject.Find(Strings.SecondSubWindow).GetComponentsInChildren<Button>().ToList());

        //DisableWindows();
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

    public Button GetWindowsButtonByName(string windowName, string buttonName)
    {
        try
        {
            return _windowbuttons.SingleOrDefault(item => item.Key == windowName).Value.SingleOrDefault(but => but.name == buttonName);
        }
        catch (System.Exception)
        {
            throw new KeyNotFoundException(Strings.ButtonsNotFound);
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

    public Button GetSubButtonByName(string subWindowName, string buttonName)
    {
        return _uiSubWindowButtons.SingleOrDefault(item => item.Key == subWindowName).Value.SingleOrDefault(but => but.name == buttonName);
    }
    
}
