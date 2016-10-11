using System.Runtime.InteropServices;
using UnityEngine;

namespace ArucoUnity
{
  namespace Utility
  {
    public partial class Point3f : HandleCvPtr
    {
      // Constructor & Destructor
      [DllImport("ArucoUnity")]
      static extern System.IntPtr au_Point3f_new();

      [DllImport("ArucoUnity")]
      static extern void au_Point3f_delete(System.IntPtr point3f);

      // Variables
      [DllImport("ArucoUnity")]
      static extern float au_Point3f_getX(System.IntPtr point3f);

      [DllImport("ArucoUnity")]
      static extern void au_Point3f_setX(System.IntPtr point3f, float x);

      [DllImport("ArucoUnity")]
      static extern float au_Point3f_getY(System.IntPtr point3f);

      [DllImport("ArucoUnity")]
      static extern void au_Point3f_setY(System.IntPtr point3f, float y);

      [DllImport("ArucoUnity")]
      static extern float au_Point3f_getZ(System.IntPtr point3f);

      [DllImport("ArucoUnity")]
      static extern void au_Point3f_setZ(System.IntPtr point3f, float z);

      public Point3f() : base(au_Point3f_new())
      {
      }

      internal Point3f(System.IntPtr point3fPtr) : base(point3fPtr)
      {
      }

      protected override void DeleteCvPtr()
      {
        au_Point3f_delete(cvPtr);
      }

      public float x
      {
        get { return au_Point3f_getX(cvPtr); }
        set { au_Point3f_setX(cvPtr, value); }
      }

      public float y
      {
        get { return au_Point3f_getY(cvPtr); }
        set { au_Point3f_setY(cvPtr, value); }
      }

      public float z
      {
        get { return au_Point3f_getZ(cvPtr); }
        set { au_Point3f_setZ(cvPtr, value); }
      }

      public static implicit operator Vector3(Point3f point3f)
      {
        return new Vector3(point3f.x, point3f.y, point3f.z);
      }
    }
  }
}