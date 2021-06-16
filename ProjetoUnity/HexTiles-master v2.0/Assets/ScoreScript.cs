using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class ScoreScript : MonoBehaviour
{
    public void test()
    {


        StreamWriter testingtest = new StreamWriter("Assets/TextFiles/scores.txt");

        testingtest.Write ("Pedro;12500 Ana;14000 Maria;11200 Carlos;10000");
        testingtest.Close();


    }
}
