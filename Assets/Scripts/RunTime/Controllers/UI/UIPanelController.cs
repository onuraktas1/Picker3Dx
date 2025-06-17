using System.Collections.Generic;
using RunTime.Enums;
using RunTime.Signals;
using UnityEngine;

namespace RunTime.Controllers.UI
{
    public class UIPanelController : MonoBehaviour
    {
        [SerializeField] private List<Transform> layers = new();

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            CoreUISignals.Instance.onClosePanel += OnClosePanel;
            CoreUISignals.Instance.onOpenPanel += OnOpenPanel;
            CoreUISignals.Instance.onCloseAllPanel += OnCloseAllPanel;
        }

        private void OnCloseAllPanel()
        {
            foreach (var layer in layers)
            {
                if (layer.childCount <= 0) return;
#if UNITY_EDITOR
                DestroyImmediate(layer.GetChild(0).gameObject);
#else
                Destroy(layer.GetChild(0).gameObject);
#endif
            }
        }

        private void OnOpenPanel(UIPanelTypes panelType, int value)
        {
            OnClosePanel(value);
            Instantiate(Resources.Load<GameObject>($"Screens/{panelType}Panel/"), layers[value]);
        }

        private void OnClosePanel(int value)
        {
            if (layers[value].childCount <= 0) return;
#if UNITY_EDITOR
            DestroyImmediate(layers[value].GetChild(0).gameObject); //Sadece editörde çalışır RunTime da çalışmaz
#else
            Destroy(layers[value].GetChild(0).gameObject); //Sadece Runtime da çalışır editörde çalışmaz
#endif
        }

        private void UnSubscribeEvents()
        {
            CoreUISignals.Instance.onClosePanel -= OnClosePanel;
            CoreUISignals.Instance.onOpenPanel -= OnOpenPanel;
            CoreUISignals.Instance.onCloseAllPanel -= OnCloseAllPanel;
        }

        private void OnDisable()
        {
            UnSubscribeEvents();
        }
    }
}