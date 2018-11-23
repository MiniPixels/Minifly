using Assets.Minifly.Scripts.Helpers;
using Assets.Minifly.Scripts.WindowManager;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    private GameObjectContainer _objContainer;
    private UIModule _uiModlue;
    void Start()
    {
        _objContainer = GameObject.Find(Strings.GameobjectContainer).GetComponent<GameObjectContainer>();
        _uiModlue = new UIModule();
        GiveButtonsAction();
    }

    private void GiveButtonsAction()
    {
        GameObjectContainer.Button.ToList().ForEach(x =>
        x.Value.onClick.AddListener(
            delegate
            {
                InputController(ActionRoute.UI, x.Value.name);
            }));
         }

    private void InputController(ActionRoute actionRoute, string actionCommand)
    {
        Debug.Log(actionCommand);
        switch (actionCommand)
        {
            case "PlayButton":
                GameObjectContainer.Button[actionCommand].GetComponentInChildren<Text>().text = "Fuckign Shit";
                break;
            default:
                Debug.Log(actionCommand);
                break;
   
              
                
        }
    }

    private void DALAction(ActionCommand command)
    {
        switch (command)
        {
      
            case ActionCommand.GetUserDataFromCloud:
                break;
            case ActionCommand.GetHighScoreFromCloud:
                break;         
            case ActionCommand.About:
                break;

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

    private void UIAction(ActionCommand command,string ActionName)
    {
       
        switch (command)
        {
            case ActionCommand.OpenWindow:
                break;
            case ActionCommand.CloseWindow:
                break;
            case ActionCommand.MusicOnOff:
                break;
            case ActionCommand.SoundOnOff:
                break;
            case ActionCommand.CloudSaveOnOff:
                break;
            case ActionCommand.BuyNoAds:
                break;
            case ActionCommand.Buy50Diamonds:
                break;
            case ActionCommand.Buy200Diamonds:
                break;
            case ActionCommand.About:
                break;
                
        }

    }
}
