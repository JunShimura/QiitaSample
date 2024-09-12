using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CautionDisplayManager))]
public class CautionDisplayTest : MonoBehaviour
{
    [SerializeField] bool flag = false;
    [SerializeField]CautionDisplayManager manager;
    void Awake()
    {
        manager = GetComponent<CautionDisplayManager>();
    }
    // Update is called once per frame
    void Update()
    {
        manager.CautionFlag = flag;        
    }
}
