using System.Collections;
using System.Collections.Generic;
using Events;
using UnityEngine;
using UnityEngine.UI;

public class OnClickButtonGenericsEvent : MonoBehaviour
{
    [field: SerializeField] private GameEvent gameEvent;

    private Button _button;
    
    private void Start()
    {
        _button = transform.gameObject.GetComponent<Button>();
        _button.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        gameEvent?.Invoke();
    }
}
