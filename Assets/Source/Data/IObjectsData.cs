using System;
using UnityEngine;

namespace Balthazariy.Data
{
    [CreateAssetMenu(fileName = "IObjectsData", menuName = "Balthazariy/IObjectsData", order = 1)]
    public class IObjectsData : ScriptableObject
    {
        public Coins[] Coins;
        public Crystals[] Crystals;

        public Coins GetCoinById(int id)
        {
            foreach (var coin in Coins)
                if (coin.id == id)
                    return coin;

            return null;
        }

        public Crystals GetCrestalById(int id)
        {
            foreach (var crystal in Crystals)
                if (crystal.id == id)
                    return crystal;

            return null;
        }
    }

    [Serializable]
    public class Coins : IObject
    {
        public uint value;
    }


    [Serializable]
    public class Crystals : IObject
    {
        public uint value;
    }

    public class IObject
    {
        public int id;
        public string name;
        public GameObject prefab;
    }
}