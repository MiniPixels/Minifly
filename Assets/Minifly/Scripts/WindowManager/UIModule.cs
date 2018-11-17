using UnityEngine;

namespace Assets.Minifly.Scripts.WindowManager
{
    public class UIModule
    {
        public void CloseWindow(GameObject window)
        {
            window.SetActive(false);
        }
        public void OpenWindow(GameObject window)
        {
            window.SetActive(true);
        }
    }
}
