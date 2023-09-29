using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.ScriptableObjects.Unity
{
    [CreateAssetMenu(menuName = "Events/Unity/GameObject Event", fileName = "GameObjectEvent")]
    public class GameObjectEventChannelSO : EventChannelBaseSO<GameObject>
    {
    }
}