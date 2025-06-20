using RunTime.Enums;
using RunTime.Managers;
using UnityEngine;
using UnityEngine.UIElements;

namespace RunTime.Handlers
{
    public class UIEventSubscriber : MonoBehaviour
    {
        [SerializeField] private UIEventSubscriptionTypes type;
        [SerializeField] private Button button;

        private UIManager _manager;
    }
}