using UnityEngine.Events;
using Xprees.Core;

namespace Xprees.Events.ScriptableObjects.Base
{
    // TODO custom editor which will hide event logging if not allowed
    /// <summary>
    /// Base class for all events channels with one parameter that are used in the game.
    /// </summary>
    /// <typeparam name="T">Unity Serializable</typeparam>
    public class EventChannelBaseSO<T> : DescriptionBaseSO
    {
        public UnityAction<T> onEventRaised;

        public void RaiseEvent(T value) => onEventRaised?.Invoke(value);
    }

    /// <summary>
    /// Base class for all events channels with two parameters that are used in the game.
    /// </summary>
    /// <typeparam name="T1">Unity Serializable</typeparam>
    /// <typeparam name="T2">Unity Serializable</typeparam>
    public class EventChannelBaseSO<T1, T2> : DescriptionBaseSO
    {
        public UnityAction<T1, T2> onEventRaised;

        public void RaiseEvent(T1 firstValue, T2 secondValue) =>
            onEventRaised?.Invoke(firstValue, secondValue);
    }

    /// <summary>
    /// Base class for all events channels with two parameters that are used in the game.
    /// </summary>
    /// <typeparam name="T1">Unity Serializable</typeparam>
    /// <typeparam name="T2">Unity Serializable</typeparam>
    /// <typeparam name="T3">Unity Serializable</typeparam>
    public class EventChannelBaseSO<T1, T2, T3> : DescriptionBaseSO
    {
        public UnityAction<T1, T2, T3> onEventRaised;

        public void RaiseEvent(T1 firstValue, T2 secondValue, T3 thirdValue) =>
            onEventRaised?.Invoke(firstValue, secondValue, thirdValue);
    }
}