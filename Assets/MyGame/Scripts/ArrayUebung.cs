using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayUebung : MonoBehaviour
{
    int[] array;

    int[] array1 = new int[4];
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    string[] array4 = new string[10];


    private void Start()
    {
        array4[0] = "array4";
        GameObject[] arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");
        Debug.Log(arrayColoredImagesRed[0].name);
    }



}
