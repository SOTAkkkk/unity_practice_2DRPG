using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キャラクターを管理する
public class UnitManager : MonoBehaviour
{
    // ステータス
    public int hp;
    public int pt;

    // 攻撃関数
    public void Attack(UnitManager unitManager)
    {
        unitManager.Damage();
    }

    // ダメージ関数
    void Damage()
    {
        hp -= 10;
        Debug.Log(name + "は10ダメージを受けた");
    }

}
