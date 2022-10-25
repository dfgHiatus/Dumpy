using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using UnityEngine;

public class Dumper : MonoBehaviour
{
    [SerializeField]
    OVREyeGaze leftEyeGaze;

    [SerializeField]
    OVREyeGaze rightEyeGaze;

    [SerializeField]
    OVRFaceExpressions faceExpressions;

    private MemoryMappedFile memMapFile;
    private MemoryMappedViewAccessor accessor;
    private FBData dataFB;
    private bool Spam = false;

    void Start()
    {
        Application.runInBackground = true;

        if (!leftEyeGaze.EyeTrackingEnabled)
        {
            Debug.LogWarning("Left eye tracking is not allowed! Please enable it in the Oculus app.");
        }

        if (!leftEyeGaze.EyeTrackingEnabled)
        {
            Debug.LogWarning("Right eye tracking is not allowed! Please enable it in the Oculus app.");
        }

        Debug.Log("Eye tracking session has started!");

        if (!leftEyeGaze.EyeTrackingEnabled)
        {
            Debug.LogWarning("Face tracking is not allowed! Please enable it in the Oculus app.");
        }

        Debug.Log("Face tracking session has started!");

        dataFB = new FBData(leftEyeGaze, rightEyeGaze, faceExpressions);

        memMapFile = MemoryMappedFile.CreateNew("VarjoEyeTracking", Marshal.SizeOf(dataFB.allData));
        accessor = memMapFile.CreateViewAccessor();

        Debug.Log("Created memory mapped IO!");
    }

    void Update()
    {
        dataFB.Update();
        accessor.Write(0, ref dataFB.allData);

        if (Input.GetKeyDown(KeyCode.F1))
            Spam = !Spam;

        if (Spam)
        {
            Debug.Log(dataFB.allData.ToString());
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F2))
                Debug.Log(dataFB.allData.eyeData.ToString());
        
            if (Input.GetKeyDown(KeyCode.F3))
                Debug.Log(dataFB.allData.faceData.ToString());
        }
    }

    void OnApplicationQuit()
    {
        Debug.Log("Destroying memory mapped IO...");
        accessor.Dispose();
        memMapFile.Dispose();
        Debug.Log("Destroyed memory mapped IO!");
    }
}
