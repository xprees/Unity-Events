using UnityEngine;
using UnityEngine.Events;
using Xprees.Core;

namespace Xprees.Events.ScriptableObjects.Base
{
    [CreateAssetMenu(menuName = "Events/Void Event", fileName = "VoidEvent", order = -1)]
    public class VoidEventChannelSO : DescriptionBaseSO
    {
        public UnityAction onEventRaised;

        public void RaiseEvent() => onEventRaised?.Invoke();
    }
}