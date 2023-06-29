﻿using UnityEngine;
using Xprees.Events.ScriptableObjects.Unity;

namespace Xprees.Events.MonoBehaviours.Unity
{
    public class GameObjectEventInvoker : MonoBehaviour
    {
        public GameObjectEventChannelSO gameObjectEvent;
        public GameObject target;

        public void RaiseEvent()
        {
            if (gameObjectEvent == null) return;

            gameObjectEvent.RaiseEvent(target);
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (gameObjectEvent == null) Debug.LogWarning($"{nameof(GameObjectEventInvoker)}: GameObjectEvent is not set", gameObject);
            if (target == null) Debug.LogWarning($"{nameof(GameObjectEventInvoker)}: GameObject Data is not set", gameObject);
        }
#endif
    }
}