using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChangeButton : MonoBehaviour
{
    public void OnClick_NameChange()
    {
        GameLogicManager.Inst.ReQuestNameChange();
    }
}
