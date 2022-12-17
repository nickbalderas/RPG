using UnityEngine;

namespace RPG.Core
{
    public class ActionScheduler : MonoBehaviour
    {
        private MonoBehaviour _currentAction;
        
        public void StartAction(MonoBehaviour action)
        {
            if (_currentAction == action) return;
            if (_currentAction)
            {
                print("Canceling " + _currentAction);
            }
            _currentAction = action;
        }
    }
}