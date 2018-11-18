using Assets.Minifly.Scripts.Helpers;
using Assets.Minifly.Scripts.WindowManager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    private GameObjectContainer _objContainer;
    private UIModule _uiModlue;
	void Start ()
    {
        _objContainer = GameObject.Find(Strings.GameobjectContainer).GetComponent<GameObjectContainer>();
        _uiModlue = new UIModule();
        GiveButtonsAction(); 
	}

    private void GiveButtonsAction()
    {
        _objContainer.GetWindowsButtonByName(Strings.ShopWindow, Strings.CloseButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.CloseWindow, _objContainer.GetWindowByName(Strings.ShopWindow)); });
        _objContainer.GetWindowsButtonByName(Strings.GarageWindow, Strings.CloseButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.CloseWindow, _objContainer.GetWindowByName(Strings.GarageWindow)); });
        _objContainer.GetWindowsButtonByName(Strings.HighscoreWindow, Strings.CloseButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.CloseWindow, _objContainer.GetWindowByName(Strings.HighscoreWindow)); });
        _objContainer.GetWindowsButtonByName(Strings.ProfileWindows, Strings.CloseButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.CloseWindow, _objContainer.GetWindowByName(Strings.ProfileWindows)); });
        _objContainer.GetWindowsButtonByName(Strings.MessageWindow, Strings.CloseButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.CloseWindow, _objContainer.GetWindowByName(Strings.MessageWindow)); });
        _objContainer.GetWindowsButtonByName(Strings.SettingsWindow, Strings.CloseButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.CloseWindow, _objContainer.GetWindowByName(Strings.SettingsWindow)); });

        _objContainer.GetSubButtonByName(Strings.SecondSubWindow, Strings.ProfileButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.OpenWindow, _objContainer.GetWindowByName(Strings.ProfileWindows)); });
        _objContainer.GetSubButtonByName(Strings.SecondSubWindow, Strings.SettingsButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.OpenWindow, _objContainer.GetWindowByName(Strings.SettingsWindow)); });
        _objContainer.GetSubButtonByName(Strings.SecondSubWindow, Strings.ShopButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.OpenWindow, _objContainer.GetWindowByName(Strings.ShopWindow)); });
        _objContainer.GetSubButtonByName(Strings.SecondSubWindow, Strings.ScoreButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.OpenWindow, _objContainer.GetWindowByName(Strings.HighscoreWindow)); });
        _objContainer.GetSubButtonByName(Strings.SecondSubWindow, Strings.GarageButton).onClick.AddListener(delegate { InputController(ActionRoute.UI, ActionCommand.OpenWindow, _objContainer.GetWindowByName(Strings.GarageWindow)); });

        _objContainer.GetSubButtonByName(Strings.FirstSubWindow, Strings.QuitButton).onClick.AddListener(delegate { InputController(ActionRoute.GAME, ActionCommand.QuitGame); });
        _objContainer.GetSubButtonByName(Strings.FirstSubWindow, Strings.PlayButton).onClick.AddListener(delegate { InputController(ActionRoute.GAME, ActionCommand.PlayGame); });
        _objContainer.GetSubButtonByName(Strings.FirstSubWindow, Strings.HelpButton).onClick.AddListener(delegate { InputController(ActionRoute.GAME, ActionCommand.HelpGame); });
      

    }

    private void InputController(ActionRoute actionRoute,ActionCommand command,GameObject param=null)
    {
        switch (actionRoute)
        {
            case ActionRoute.UI:
                UIAction(command,param);
                break;
            case ActionRoute.GAME:
                GameAction(command);
                break;
            case ActionRoute.DAL:
                DALAction(command);
                break;
        }
    }

    private void DALAction(ActionCommand command)
    {
        switch (command)
        {
           

        }
    }

    private void GameAction(ActionCommand command)
    {
        switch (command)
        {
            case ActionCommand.PlayGame:
                Debug.Log("Play");
                break;
            case ActionCommand.QuitGame:
                Debug.Log("QuitGame");
                break;
            case ActionCommand.HelpGame:
                Debug.Log("HelpGame");
                break;
        }
    }

    private void UIAction(ActionCommand command, GameObject param)
    {
        switch (command)
        {
            case ActionCommand.OpenWindow:
                _uiModlue.OpenWindow(param);
                _objContainer.SetButtonInterChargeAble(false);
                break;
            case ActionCommand.CloseWindow:
                _uiModlue.CloseWindow(param);
                _objContainer.SetButtonInterChargeAble(true);
                break;
           
        }
    }
}
