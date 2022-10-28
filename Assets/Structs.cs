using System.Runtime.InteropServices;
using UnityEngine;
using static FBData;

public class FBData
{
    private OVREyeGaze ovrLeftEye;
    private OVREyeGaze ovrRightEye;
    private OVRFaceExpressions ovrFace;

    public AllData allData;

    public FBData(OVREyeGaze leftEye, OVREyeGaze rightEye, OVRFaceExpressions face)
    {
        ovrLeftEye = leftEye;
        ovrRightEye = rightEye;
        ovrFace = face;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AllData
    {
        public EyeData eyeData;
        public FaceData faceData;

        public override string ToString()
        {
            return "EyeData: " + eyeData.ToString() + " FaceData: " + faceData.ToString();
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EyeData
    {
        public Eye leftEye;
        public Eye rightEye;

        public override string ToString()
        {
            return "LeftEye: " + leftEye.ToString() + " RightData: " + rightEye.ToString();
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Eye
    {
        public float confidence;
        public Vec3 position;
        public Quat rotation;

        public override string ToString()
        {
            return "Confidence: " + confidence + ", Position: " + position.ToString() + ", Rotation: " + rotation.ToString();
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Vec3
    {
        public float x;
        public float y;
        public float z;

        public override string ToString()
        {
            return $"Vector3: X: {x}, Y: {y}, Z: {z})";
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Quat
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public override string ToString()
        {
            return $"Quaternion: X: {x}, Y: {y}, Z: {z}, W: {w})";
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FaceData
    {
        public float FaceRegionConfidenceLower;
        public float FaceRegionConfidenceUpper;
        public float BrowLowererL;
        public float BrowLowererR;
        public float CheekPuffL;
        public float CheekPuffR;
        public float CheekRaiserL;
        public float CheekRaiserR;
        public float CheekSuckL;
        public float CheekSuckR;
        public float ChinRaiserB;
        public float ChinRaiserT;
        public float DimplerL;
        public float DimplerR;
        public float EyesClosedL;
        public float EyesClosedR;
        public float EyesLookDownL;
        public float EyesLookDownR;
        public float EyesLookLeftL;
        public float EyesLookLeftR;
        public float EyesLookRightL;
        public float EyesLookRightR;
        public float EyesLookUpL;
        public float EyesLookUpR;
        public float InnerBrowRaiserL;
        public float InnerBrowRaiserR;
        public float JawDrop;
        public float JawSidewaysLeft;
        public float JawSidewaysRight;
        public float JawThrust;
        public float LidTightenerL;
        public float LidTightenerR;
        public float LipCornerDepressorL;
        public float LipCornerDepressorR;
        public float LipCornerPullerL;
        public float LipCornerPullerR;
        public float LipFunnelerLB;
        public float LipFunnelerLT;
        public float LipFunnelerRB;
        public float LipFunnelerRT;
        public float LipPressorL;
        public float LipPressorR;
        public float LipPuckerL;
        public float LipPuckerR;
        public float LipStretcherL;
        public float LipStretcherR;
        public float LipSuckLB;
        public float LipSuckLT;
        public float LipSuckRB;
        public float LipSuckRT;
        public float LipTightenerL;
        public float LipTightenerR;
        public float LipsToward;
        public float LowerLipDepressorL;
        public float LowerLipDepressorR;
        public float MouthLeft;
        public float MouthRight;
        public float NoseWrinklerL;
        public float NoseWrinklerR;
        public float OuterBrowRaiserL;
        public float OuterBrowRaiserR;
        public float UpperLidRaiserL;
        public float UpperLidRaiserR;
        public float UpperLipRaiserL;
        public float UpperLipRaiserR;

        public override string ToString()
        {
            return 
                 "FaceData: " + 
                 "\nFaceRegionConfidenceLower: " + FaceRegionConfidenceLower + 
                 "\nFaceRegionConfidenceUpper: " + FaceRegionConfidenceUpper + 
                 "\nBrowLowererL: " + BrowLowererL + 
                 "\nBrowLowererR: " + BrowLowererR + 
                 "\nCheekPuffL: " + CheekPuffL + 
                 "\nCheekPuffR: " + CheekPuffR + 
                 "\nCheekRaiserL: " + CheekRaiserL + 
                 "\nCheekRaiserR: " + CheekRaiserR + 
                 "\nCheekSuckL: " + CheekSuckL + 
                 "\nCheekSuckR: " + CheekSuckR + 
                 "\nChinRaiserB: " + ChinRaiserB + 
                 "\nChinRaiserT: " + ChinRaiserT + 
                 "\nDimplerL: " + DimplerL + 
                 "\nDimplerR: " + DimplerR + 
                 "\nEyesClosedL: " + EyesClosedL + 
                 "\nEyesClosedR: " + EyesClosedR + 
                 "\nEyesLookDownL: " + EyesLookDownL + 
                 "\nEyesLookDownR: " + EyesLookDownR + 
                 "\nEyesLookLeftL: " + EyesLookLeftL + 
                 "\nEyesLookLeftR: " + EyesLookLeftR + 
                 "\nEyesLookRightL: " + EyesLookRightL + 
                 "\nEyesLookRightR: " + EyesLookRightR + 
                 "\nEyesLookUpL: " + EyesLookUpL + 
                 "\nEyesLookUpR: " + EyesLookUpR + 
                 "\nInnerBrowRaiserL: " + InnerBrowRaiserL + 
                 "\nInnerBrowRaiserR: " + InnerBrowRaiserR + 
                 "\nJawDrop: " + JawDrop + 
                 "\nJawSidewaysLeft: " + JawSidewaysLeft + 
                 "\nJawSidewaysRight: " + JawSidewaysRight + 
                 "\nJawThrust: " + JawThrust + 
                 "\nLidTightenerL: " + LidTightenerL + 
                 "\nLidTightenerR: " + LidTightenerR + 
                 "\nLipCornerDepressorL: " + LipCornerDepressorL + 
                 "\nLipCornerDepressorR: " + LipCornerDepressorR +
                 "\nLipCornerPullerL: " + LipCornerPullerL +
                 "\nLipCornerPullerR: " + LipCornerPullerR +
                 "\nLipFunnelerLB: " + LipFunnelerLB +
                 "\nLipFunnelerLT: " + LipFunnelerLT +
                 "\nLipFunnelerRB: " + LipFunnelerRB +
                 "\nLipFunnelerRT: " + LipFunnelerRT +
                 "\nLipPressorL: " + LipPressorL +
                 "\nLipPressorR: " + LipPressorR +
                 "\nLipPuckerL: " + LipPuckerL +
                 "\nLipPuckerR: " + LipPuckerR +
                 "\nLipStretcherL: " + LipStretcherL +
                 "\nLipStretcherR: " + LipStretcherR +
                 "\nLipSuckLB: " + LipSuckLB +
                 "\nLipSuckLT: " + LipSuckLT +
                 "\nLipSuckRB: " + LipSuckRB +
                 "\nLipSuckRT: " + LipSuckRT +
                 "\nLipTightenerL: " + LipTightenerL +
                 "\nLipTightenerR: " + LipTightenerR +
                 "\nLipsToward: " + LipsToward +
                 "\nLowerLipDepressorL: " + LowerLipDepressorL +
                 "\nLowerLipDepressorR: " + LowerLipDepressorR +
                 "\nMouthLeft: " + MouthLeft +
                 "\nMouthRight: " + MouthRight +
                 "\nNoseWrinklerL: " + NoseWrinklerL +
                 "\nNoseWrinklerR: " + NoseWrinklerR +
                 "\nOuterBrowRaiserL: " + OuterBrowRaiserL +
                 "\nOuterBrowRaiserR: " + OuterBrowRaiserR +
                 "\nUpperLidRaiserL: " + UpperLidRaiserL +
                 "\nUpperLidRaiserR: " + UpperLidRaiserR +
                 "\nUpperLipRaiserL: " + UpperLipRaiserL +
                 "\nUpperLipRaiserR: " + UpperLipRaiserR;
        }
    }

    // Auto-generated
    public void Update()
    {
        #region Left Eye
        allData.eyeData.leftEye.confidence = ovrLeftEye.Confidence;
        allData.eyeData.leftEye.position.x = ovrLeftEye.gameObject.transform.localPosition.x;
        allData.eyeData.leftEye.position.y = ovrLeftEye.gameObject.transform.localPosition.y;
        allData.eyeData.leftEye.position.z = ovrLeftEye.gameObject.transform.localPosition.z;
        allData.eyeData.leftEye.rotation.x = ovrLeftEye.gameObject.transform.localRotation.x;
        allData.eyeData.leftEye.rotation.y = ovrLeftEye.gameObject.transform.localRotation.y;
        allData.eyeData.leftEye.rotation.z = ovrLeftEye.gameObject.transform.localRotation.z;
        allData.eyeData.leftEye.rotation.w = ovrLeftEye.gameObject.transform.localRotation.w;
        #endregion Left Eye

        #region Right Eye
        allData.eyeData.rightEye.confidence = ovrRightEye.Confidence;
        allData.eyeData.rightEye.position.x = ovrRightEye.gameObject.transform.localPosition.x;
        allData.eyeData.rightEye.position.y = ovrRightEye.gameObject.transform.localPosition.y;
        allData.eyeData.rightEye.position.z = ovrRightEye.gameObject.transform.localPosition.z;
        allData.eyeData.rightEye.rotation.x = ovrRightEye.gameObject.transform.localRotation.x;
        allData.eyeData.rightEye.rotation.y = ovrRightEye.gameObject.transform.localRotation.y;
        allData.eyeData.rightEye.rotation.z = ovrRightEye.gameObject.transform.localRotation.z;
        allData.eyeData.rightEye.rotation.w = ovrRightEye.gameObject.transform.localRotation.w;
        #endregion Right Eye

        float val;

        #region Face
        allData.faceData.FaceRegionConfidenceLower = ovrFace.TryGetWeightConfidence(OVRFaceExpressions.FaceRegionConfidence.Lower, out val) ? val : 0;
        allData.faceData.FaceRegionConfidenceUpper = ovrFace.TryGetWeightConfidence(OVRFaceExpressions.FaceRegionConfidence.Upper, out val) ? val : 0;
        
        allData.faceData.BrowLowererL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.BrowLowererL, out val) ? val : 0;
        allData.faceData.BrowLowererR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.BrowLowererR, out val) ? val : 0;
        allData.faceData.CheekPuffL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.CheekPuffL, out val) ? val : 0;
        allData.faceData.CheekPuffR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.CheekPuffR, out val) ? val : 0;
        allData.faceData.CheekRaiserL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.CheekRaiserL, out val) ? val : 0;
        allData.faceData.CheekRaiserR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.CheekRaiserR, out val) ? val : 0;
        allData.faceData.CheekSuckL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.CheekSuckL, out val) ? val : 0;
        allData.faceData.CheekSuckR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.CheekSuckR, out val) ? val : 0;
        allData.faceData.ChinRaiserB = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.ChinRaiserB, out val) ? val : 0;
        allData.faceData.ChinRaiserT = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.ChinRaiserT, out val) ? val : 0;
        allData.faceData.DimplerL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.DimplerL, out val) ? val : 0;
        allData.faceData.DimplerR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.DimplerR, out val) ? val : 0;
        allData.faceData.EyesClosedL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesClosedL, out val) ? val : 0;
        allData.faceData.EyesClosedR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesClosedR, out val) ? val : 0;
        allData.faceData.EyesLookDownL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesLookDownL, out val) ? val : 0;
        allData.faceData.EyesLookDownR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesLookDownR, out val) ? val : 0;
        allData.faceData.EyesLookLeftL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesLookLeftL, out val) ? val : 0;
        allData.faceData.EyesLookLeftR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesLookLeftR, out val) ? val : 0;
        allData.faceData.EyesLookRightL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesLookRightL, out val) ? val : 0;
        allData.faceData.EyesLookRightR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesLookRightR, out val) ? val : 0;
        allData.faceData.EyesLookUpL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesLookUpL, out val) ? val : 0;
        allData.faceData.EyesLookUpR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.EyesLookUpR, out val) ? val : 0;
        allData.faceData.InnerBrowRaiserL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.InnerBrowRaiserL, out val) ? val : 0;
        allData.faceData.InnerBrowRaiserR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.InnerBrowRaiserR, out val) ? val : 0;
        allData.faceData.JawDrop = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.JawDrop, out val) ? val : 0;
        allData.faceData.JawSidewaysLeft = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.JawSidewaysLeft, out val) ? val : 0;
        allData.faceData.JawSidewaysRight = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.JawSidewaysRight, out val) ? val : 0;
        allData.faceData.JawThrust = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.JawThrust, out val) ? val : 0;
        allData.faceData.LidTightenerL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LidTightenerL, out val) ? val : 0;
        allData.faceData.LidTightenerR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LidTightenerR, out val) ? val : 0;
        allData.faceData.LipCornerDepressorL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipCornerDepressorL, out val) ? val : 0;
        allData.faceData.LipCornerDepressorR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipCornerDepressorR, out val) ? val : 0;
        allData.faceData.LipCornerPullerL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipCornerPullerL, out val) ? val : 0;
        allData.faceData.LipCornerPullerR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipCornerPullerR, out val) ? val : 0;
        allData.faceData.LipFunnelerLB = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipFunnelerLB, out val) ? val : 0;
        allData.faceData.LipFunnelerLT = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipFunnelerLT, out val) ? val : 0;
        allData.faceData.LipFunnelerRB = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipFunnelerRB, out val) ? val : 0;
        allData.faceData.LipFunnelerRT = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipFunnelerRT, out val) ? val : 0;
        allData.faceData.LipPressorL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipPressorL, out val) ? val : 0;
        allData.faceData.LipPressorR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipPressorR, out val) ? val : 0;
        allData.faceData.LipPuckerL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipPuckerL, out val) ? val : 0;
        allData.faceData.LipPuckerR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipPuckerR, out val) ? val : 0;
        allData.faceData.LipStretcherL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipStretcherL, out val) ? val : 0;
        allData.faceData.LipStretcherR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipStretcherR, out val) ? val : 0;
        allData.faceData.LipSuckLB = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipSuckLB, out val) ? val : 0;
        allData.faceData.LipSuckLT = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipSuckLT, out val) ? val : 0;
        allData.faceData.LipSuckRB = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipSuckRB, out val) ? val : 0;
        allData.faceData.LipSuckRT = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipSuckRT, out val) ? val : 0;
        allData.faceData.LipTightenerL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipTightenerL, out val) ? val : 0;
        allData.faceData.LipTightenerR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipTightenerR, out val) ? val : 0;
        allData.faceData.LipsToward = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LipsToward, out val) ? val : 0;
        allData.faceData.LowerLipDepressorL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LowerLipDepressorL, out val) ? val : 0;
        allData.faceData.LowerLipDepressorR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.LowerLipDepressorR, out val) ? val : 0;
        allData.faceData.MouthLeft = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.MouthLeft, out val) ? val : 0;
        allData.faceData.MouthRight = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.MouthRight, out val) ? val : 0;
        allData.faceData.NoseWrinklerL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.NoseWrinklerL, out val) ? val : 0;
        allData.faceData.NoseWrinklerR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.NoseWrinklerR, out val) ? val : 0;
        allData.faceData.OuterBrowRaiserL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.OuterBrowRaiserL, out val) ? val : 0;
        allData.faceData.OuterBrowRaiserR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.OuterBrowRaiserR, out val) ? val : 0;
        allData.faceData.UpperLidRaiserL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.UpperLidRaiserL, out val) ? val : 0;
        allData.faceData.UpperLidRaiserR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.UpperLidRaiserR, out val) ? val : 0;
        allData.faceData.UpperLipRaiserL = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.UpperLipRaiserL, out val) ? val : 0;
        allData.faceData.UpperLipRaiserR = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.UpperLipRaiserR, out val) ? val : 0;

        #endregion Face

    }
}
