using UnityEngine;
using UnityEngine.UI;

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

        Debug.Log(array1[0]);
        Debug.Log(array1[3]);
        Debug.Log(array2[0]);
        Debug.Log(array2[3]);
        Debug.Log(array3[0]);
        Debug.Log(array3[6]);
        Debug.Log(array4[0]);
        Debug.Log(array4[9]);
        Debug.Log(arrayColoredImagesRed[0].name);
        Debug.Log(arrayColoredImagesRed[3].name);

        ArrayWerte();
        ArrayString();

        array1[3] = 3;
        Debug.Log(array1[3]);
        array2[2] = 203;
        Debug.Log(array2[2]);
        array3[5] = 333;
        Debug.Log(array3[5]);

        array4[2] = "heute";
        Debug.Log(array4[2]);
        arrayColoredImagesRed[2].GetComponent<Image>().color = Color.green;
    }


    private void ArrayWerte()
    {
        int[] werte = new int[5] { 1, 2, 3, 4, 5 };

        for (int i = 0; i < werte.Length; i++)
        {
            Debug.Log(werte[i]++ + "= Element" + " " + i);
        }
    }

    private void ArrayString()
    {
        int[] langerString = new int[5] { 1, 2, 3, 4, 5};

        string a = " ";
        for (int index = 0; index < langerString.Length; index++)
        {
            a += langerString[index] + " ";
        }Debug.Log(a);
    }

}
