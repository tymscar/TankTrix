using UnityEngine;
using System.Collections;

public class TankModel : MonoBehaviour
{

    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3 AL = new Vector3(-4, -3, -7);
        Vector3 AR = new Vector3(4, -3, -7);
        Vector3 BL = new Vector3(-4, -3, 8);
        Vector3 BR = new Vector3(4, -3, 8);
        Vector3 CL = new Vector3(-5, 0, 10);
        Vector3 CR = new Vector3(5, 0, 10);
        Vector3 DL = new Vector3(-5, 0, -10);
        Vector3 DR = new Vector3(5, 0, -10);
        Vector3 EL = new Vector3(-4, 3, -5);
        Vector3 ER = new Vector3(4, 3, -5);
        Vector3 FL = new Vector3(-4, 3, 8);
        Vector3 FR = new Vector3(4, 3, 8);
        Vector3 GL = new Vector3(-3, 5.5f, -2.5f);
        Vector3 GR = new Vector3(3, 5.5f, -2.5f);
        Vector3 HL = new Vector3(-3, 5.5f, 2);
        Vector3 HR = new Vector3(3, 5.5f, 2);
        Vector3 IL = new Vector3(-1, 5, -10);
        Vector3 IR = new Vector3(1, 5, -10);
        Vector3 JL = new Vector3(-1, 5, -3);
        Vector3 JR = new Vector3(1, 5, -3);
        Vector3 KL = new Vector3(-1, 4, -10);
        Vector3 KR = new Vector3(1, 4, -10);
        Vector3 LL = new Vector3(-1, 4, -4);
        Vector3 LR = new Vector3(1, 4, -4);


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
            LL,LR //22 23
        };
        mesh.triangles = new int[]
        {
            1,7,5, 3,1,5, 7,9,11, 5,7,11, 11,9,13, 11,13,15, 23,21,17, 23,17,19, //LEFT SIDE
            4,6,0, 4,0,2, 10,8,6, 10,6,4, 12,8,10, 14,12,10, 16,20,22, 18,16,22, //RIGHT SIDE
            1,0,7, 0,6,7, 7,6,9, 6,8,9, 9,8,13, 8,12,13, 20,17,21, 20,16,17, //FRONT SIDE
            5,2,3, 5,4,2, 11,4,5, 11,10,4, 15,10,11, 15,14,10, //BACK SIDE
            13,12,15, 12,14,15, 17,16,18, 19,17,18, //TOP SIDE
            3,0,1, 3,2,0, 22,20,21, 22,21,23 //BOT SIDE 
        };
    }
}
