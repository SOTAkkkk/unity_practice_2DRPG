using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 戦いを管理する
// PlayerとEnemyを戦わせる
public class BattleManager : MonoBehaviour
{
    // Playerを取得する
    public UnitManager player;

    // Enemyを取得する
    public UnitManager enemy;
    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);

    }
    // PlayerがEnemyに攻撃する
    // EnemyがPlayerに攻撃する

    // Update is called once per frame
    void Update()
    {

    }
}
