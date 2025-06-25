using RunTime.Enums;
using RunTime.Extentions;
using UnityEngine;
using UnityEngine.Events;

namespace RunTime.Signals
{
    public class CoreUISignals : MonoSingleton<CoreUISignals>
    {
        public UnityAction<UIPanelTypes, int> onOpenPanel = delegate { };
        public UnityAction<int> onClosePanel = delegate { };
        public UnityAction onCloseAllPanel = delegate { };
    }
}