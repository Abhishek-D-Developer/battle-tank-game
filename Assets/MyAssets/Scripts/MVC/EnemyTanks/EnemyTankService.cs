using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Enemy.View;
using Enemy.Scriptables;
using Tank.Controller;
using Enemy.Model;
using Enemy.Controller;

namespace Enemy.Service
{
    public class EnemyTankService
    {
        public EnemyView enemyView;
        public EnemyScriptableObjectList enemies

        void Start()
        {
            StartGame();
        }

        public void StartGame()
        {
            for (int i = 0; i < 3; i++)
            {
                CreateEnemies(i);
            }
        }

        private EnemyController CreateEnemies(int index)
        {
            EnemyScriptableObjectList enemyScriptableObjectList = enemies.enemyList[index];

            EnemyModel enemyModel = new EnemyModel(enemyScriptableObjectList);
            EnemyController enemyController = new EnemyController(enemyModel, enemyView);
            return enemyController;
        }
    }
}