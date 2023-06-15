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
    public void Attack(UnitManager target)
    {
        target.Damage(pt);
    }

    // ダメージ関数
    void Damage(int damage)
    {
        hp -= 10;
        Debug.Log(name + "は" + damage + "ダメージを受けた");
        Debug.Log("体力は" + this.hp + "になった");
        if (hp <= 0)
        {
            hp = 0;
            Debug.Log(name + "は戦闘不能");
        }
    }

}
