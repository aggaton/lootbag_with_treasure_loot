using System.Collections.Generic;
using UnityEngine;
using System;

namespace MultiplayerARPG
{
    public partial class MonsterCharacterEntity
    {
        [DevExtMethods("Awake")]
        protected void OnAwake2()
        {
            if (isLootable)
            {
                SpawnLootBag();
            }
        }
    }
}