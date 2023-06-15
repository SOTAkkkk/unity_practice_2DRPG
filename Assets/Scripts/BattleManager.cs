using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (enemy.hp > 0)
        {
            enemy.Attack(player);
        }
        else
        {
            BattleEnd();
        }

    }

    // PlayerがEnemyに攻撃する
    public void OnAttackButton()
    {
        player.Attack(enemy);
        EnemyTurn();
    }

    // EnemyがPlayerに攻撃する
    void EnemyTurn()
    {
        enemy.Attack(player);
    }
    void BattleEnd()
    {
        Debug.Log("対戦終了");
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
