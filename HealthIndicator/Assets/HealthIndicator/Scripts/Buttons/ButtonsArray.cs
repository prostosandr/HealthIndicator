using UnityEngine;

public class ButtonsArray : MonoBehaviour
{
    [SerializeField] private HealthButton[] _healthButtons;

    public HealthButton[] HealthButtons => _healthButtons;

#if UNITY_EDITOR
    [ContextMenu("Refresh Child Array")]
    private void RefreshChildArray()
    {
        _healthButtons = GetComponentsInChildren<HealthButton>(true);
    }
#endif
}
