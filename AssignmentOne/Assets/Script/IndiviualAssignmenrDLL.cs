using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
public class IndiviualAssignmenrDLL : MonoBehaviour
{
    const string DLL_NAME = "PROJECT1";
    [DllImport(DLL_NAME)]
    private static extern int SimpleFunction();

    [DllImport(DLL_NAME)]
    private static extern void readX(float xP);

    [DllImport(DLL_NAME)]
    private static extern void readY(float yP);

    [DllImport(DLL_NAME)]
    private static extern void readZ(float zP);

    [DllImport(DLL_NAME)]
    private static extern float reX();

    [DllImport(DLL_NAME)]
    private static extern float reY();

    [DllImport(DLL_NAME)]
    private static extern float reZ();

    [DllImport(DLL_NAME)]
    private static extern void writePosition();

    [DllImport(DLL_NAME)]
    private static extern void readPosition();
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            readX(transform.position.x);
            readY(transform.position.y);
            readZ(transform.position.z);
            writePosition();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            readPosition();
            Vector3 newposi = new Vector3(reX(), reY(), reZ());
            float step = 1000 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, newposi, step);
        }
    }
}