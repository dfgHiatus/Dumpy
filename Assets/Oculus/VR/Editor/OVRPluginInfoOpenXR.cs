namespace Oculus.VR.Editor
{
    public class OVRPluginInfoOpenXR : IOVRPluginInfoSupplier
    {
        public bool IsOVRPluginOpenXRActivated() => true;

        public bool IsOVRPluginUnityProvidedActivated() => false;
    }
}
