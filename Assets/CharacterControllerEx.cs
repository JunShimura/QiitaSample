using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CharacterControllerEx : MonoBehaviour
{
    public enum CharacterType {　// キャラクターのタイプ
        player, 
        monster, 
        citizen , 
        animal
    }
    private Action charactorAction=null;
    private CharacterType _characterType;
    public CharacterType type {
        get => _characterType;
        set
        {
            _characterType = value;
            SetAction();
        }
    }
    [SerializeField]CharacterType defaultType = CharacterType.player;
    private void AllAction()
    {
        //　全プレイヤーの処理
        Debug.Log("Action All Character");
    }

    private void PlayerAction()
    {
        //　全プレイヤーの処理
        Debug.Log("Action Player");
    }
    private void MonsterAction()
    {
        //　全プレイヤーの処理
        Debug.Log("Action monster");
    }
    private void HumanAction()
    {
        //　全プレイヤーの処理
        Debug.Log("Action Human");
    }
    private void SetAction()
    {
        charactorAction = AllAction;
        if (type == CharacterType.player)
        {
            //　Playerの処理
            charactorAction += PlayerAction;
        }
        else if (type == CharacterType.monster)
        {
            //　Monsterの処理
            charactorAction += MonsterAction;
        }
        if (type == CharacterType.citizen || type == CharacterType.player)
        {
            // 人型の処理
            charactorAction += HumanAction;
        }
    }

    private void Awake()
    {
        type = defaultType;
    }
    // Update is called once per frame
    void Update()
    {
        charactorAction();
    }
}
