using UnityEngine;
using UnityEngine.UI;

public class TempProfileUIView : MonoBehaviour
{
    [SerializeField] Text Text_Name;
    [SerializeField] Text Text_Level;

    private TempProfileViewModel _vm;

    //private void OnEnable()
    //{
    //    if(_vm == null)
    //    {
    //        _vm = new TempProfileViewModel();
    //        _vm.PropertyChanged += OnPropertyChanged;
    //        _vm.ResiterEventsOnEnable();
    //        _vm.RefreshViewModel();
    //    }
    //}

    //private void OnDisable()
    //{
    //    if(_vm != null)
    //    {
    //        _
    //    }
    //}
}
