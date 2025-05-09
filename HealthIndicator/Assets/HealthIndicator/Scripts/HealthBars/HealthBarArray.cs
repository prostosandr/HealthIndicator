using UnityEngine;

public class HealthBarArray : MonoBehaviour
{
    [SerializeField] private HealthBar[] _bars;

    public HealthBar[] Bars => _bars;

#if UNITY_EDITOR
    [ContextMenu("Refresh Child Array")]
    private void RefreshChildArray()
    {
        _bars = GetComponentsInChildren<HealthBar>(true);
    }
#endif
}
