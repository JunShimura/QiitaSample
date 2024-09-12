using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CautionDisplayManager : MonoBehaviour
{
    public GameObject cautionDisplay;
    private bool cautionFlag = false;
    public bool CautionFlag
    {
        get => cautionFlag;
        set
        {
            if (value != cautionFlag)
            {
                cautionFlag = value;
                cautionDisplay.SetActive(cautionFlag);
            }
        }
    }
    private void Start()
    {
        cautionDisplay.SetActive(cautionFlag);
    }
}
