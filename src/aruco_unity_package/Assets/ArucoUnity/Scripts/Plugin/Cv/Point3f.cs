using System.Runtime.InteropServices;
using UnityEngine;

namespace ArucoUnity
{
  /// \addtogroup aruco_unity_package
  /// \{

  namespace Plugin
  {
    public static partial class Cv
    {
      public static partial class Core
      {
        public class Point3f : Utility.HandleCppPtr
        {
          // Constructor & Destructor
          [DllImport("ArucoUnity")]
          static extern System.IntPtr au_cv_Point3f_new();

          [DllImport("ArucoUnity")]
          static extern void au_cv_Point3f_delete(System.IntPtr point3f);

          // Variables
          [DllImport("ArucoUnity")]
          static extern float au_cv_Point3f_getX(System.IntPtr point3f);

          [DllImport("ArucoUnity")]
          static extern void au_cv_Point3f_setX(System.IntPtr point3f, float x);

          [DllImport("ArucoUnity")]
          static extern float au_cv_Point3f_getY(System.IntPtr point3f);

          [DllImport("ArucoUnity")]
          static extern void au_cv_Point3f_setY(System.IntPtr point3f, float y);

          [DllImport("ArucoUnity")]
          static extern float au_cv_Point3f_getZ(System.IntPtr point3f);

          [DllImport("ArucoUnity")]
          static extern void au_cv_Point3f_setZ(System.IntPtr point3f, float z);

          public Point3f() : base(au_cv_Point3f_new())
          {
          }

          public Point3f(System.IntPtr point3fPtr, DeleteResponsibility deleteResponsibility = DeleteResponsibility.True)
            : base(point3fPtr, deleteResponsibility)
          {
          }

          protected override void DeleteCvPtr()
          {
            au_cv_Point3f_delete(cppPtr);
          }

          public float x
          {
            get { return au_cv_Point3f_getX(cppPtr); }
            set { au_cv_Point3f_setX(cppPtr, value); }
          }

          public float y
          {
            get { return au_cv_Point3f_getY(cppPtr); }
            set { au_cv_Point3f_setY(cppPtr, value); }
          }

          public float z
          {
            get { return au_cv_Point3f_getZ(cppPtr); }
            set { au_cv_Point3f_setZ(cppPtr, value); }
          }

          public static implicit operator Vector3(Point3f point3f)
          {
            return new Vector3(point3f.x, point3f.y, point3f.z);
          }
        }
      }
    }
  }

  /// \} aruco_unity_package
}