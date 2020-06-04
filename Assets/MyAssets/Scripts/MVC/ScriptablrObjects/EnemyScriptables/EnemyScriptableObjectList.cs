using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enemy.View;

namespace Scriptables
{
    [CreateAssetMenu(fileName = "EnemyScriptableObjectList", menuName = "ScriptableObjects/NewEnemyListScriptableObject")]

    public class EnemyScriptableObjectList : ScriptableObject
    {
        public EnemyScriptableObject[] enemyList;
    }
}