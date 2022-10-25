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
    private FBData data;

    void Start()
    {
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

        data = new FBData(leftEyeGaze, rightEyeGaze, faceExpressions);

        memMapFile = MemoryMappedFile.CreateNew("VarjoEyeTracking", Marshal.SizeOf(data.allData));
        accessor = memMapFile.CreateViewAccessor();
    }

    void Update()
    {
        data.Update();
        accessor.Write(0, ref data.allData);
    }

    void OnApplicationQuit()
    {
        accessor.Dispose();
        memMapFile.Dispose();
    }
}
