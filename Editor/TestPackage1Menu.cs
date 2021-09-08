using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class TestPackage1Menu
{

    [MenuItem("TestPackages/Package1")]
    static void Package1MenuButton()
    {
        Debug.Log("Package 1");
    }
}
