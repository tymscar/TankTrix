using UnityEngine;
using System.Collections;

public class TreeModel : MonoBehaviour
{

    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3 AL = new Vector3(-0.5f, -1, -0.5f);
        Vector3 AR = new Vector3(-0.5f, -1, 0.5f);
        Vector3 BL = new Vector3(0.5f, -1, -0.5f);
        Vector3 BR = new Vector3(0.5f, -1, 0.5f);
        Vector3 CL = new Vector3(-0.5f, 3, -0.5f);
        Vector3 CR = new Vector3(-0.5f, 3, 0.5f);
        Vector3 DL = new Vector3(0.5f, 3, -0.5f);
        Vector3 DR = new Vector3(0.5f, 3, 0.5f);
        Vector3 EL = new Vector3(-5, 2, 0);
        Vector3 ER = new Vector3(-5, 2, 0);
        Vector3 FL = new Vector3(0, 2, -5);
        Vector3 FR = new Vector3(0, 2, 5);
        Vector3 GL = new Vector3(5, 2, 0);
        Vector3 GR = new Vector3(5, 2, 0);
        Vector3 HL = new Vector3(0, 5, -4);
        Vector3 HR = new Vector3(0, 5, 4);
        Vector3 IL = new Vector3(-4, 5, 0);
        Vector3 IR = new Vector3(-4, 5, 0);
        Vector3 JL = new Vector3(0, 6, 0);
        Vector3 JR = new Vector3(0, 6, 0);
        Vector3 KL = new Vector3(4, 5, 0);
        Vector3 KR = new Vector3(4, 5, 0);
        Vector3 LL = new Vector3(0, 8, -3);
        Vector3 LR = new Vector3(0, 8, 3);
        Vector3 ML = new Vector3(-3, 8, 0);
        Vector3 MR = new Vector3(-3, 8, 0);
        Vector3 NL = new Vector3(0, 9, 0);
        Vector3 NR = new Vector3(0, 9, 0);
        Vector3 OL = new Vector3(3, 8, 0);
        Vector3 OR = new Vector3(3, 8, 0);
        Vector3 PL = new Vector3(0, 12, 0);
        Vector3 PR = new Vector3(0, 12, 0);

        mesh.vertices = new Vector3[]
        {
            AL,AR, //0 1
            BL,BR, //2 3
            CL,CR, //4 5
            DL,DR, //6 7
            EL,ER, //8 9
            FL,FR, //10 11
            GL,GR, //12 13
            HL,HR, //14 15
            IL,IR, //16 17
            JL,JR, //18 19
            KL,KR, //20 21
            LL,LR, //22 23
            ML,MR, //24 25
            NL,NR, //26 27
            OL,OR, //28 29
            PL,PR //30 31
        };
        mesh.triangles = new int[]
        {
            2,0,4, 2,4,6, 12,10,18, 10,8,18, 20,14,26, 14,16,26, 28,22,30, 22,24,30, //front
            5,1,3, 7,5,3, 19,11,13, 19,9,11, 27,15,21, 27,17,15, 31,23,29, 31,25,23, //back
            11,10,12, 11,8,10, 15,14,20, 15,16,14, 23,22,28, 23,24,22, 2,6,7, 3,2,7, 1,5,4, 1,4,0, 1,0,2, 3,1,2 //under
        };
    }
}
