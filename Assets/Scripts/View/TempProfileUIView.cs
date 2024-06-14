using UnityEngine;
using UnityEngine.UI;

public class TempProfileUIView : MonoBehaviour
{
    [SerializeField] Text Text_Name;
    [SerializeField] Text Text_Level;

    private TempProfileUIViewModel _vm;

    private void OnEnable()
    {
        if(_vm == null)
        {
            _vm
        }
    }
}
