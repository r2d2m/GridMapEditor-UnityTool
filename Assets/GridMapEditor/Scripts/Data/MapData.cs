﻿using UnityEngine;
using UnityEditor;

namespace GridMapEditor
{
    [CreateAssetMenu(fileName = "New MapData", menuName = "Data/MapData", order = 1)]
    public class MapData : ScriptableObject
    {
        public MatrixLayout map;
    }
}