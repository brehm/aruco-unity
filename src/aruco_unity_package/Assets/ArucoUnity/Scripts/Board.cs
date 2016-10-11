using System.Runtime.InteropServices;
using ArucoUnity.Utility;

namespace ArucoUnity
{
  public abstract partial class Board : HandleCvPtr
  {
    [DllImport("ArucoUnity")]
    static extern System.IntPtr au_Board_getDictionary(System.IntPtr board);

    [DllImport("ArucoUnity")]
    static extern void au_Board_setDictionary(System.IntPtr board, System.IntPtr dictionary);

    [DllImport("ArucoUnity")]
    static extern System.IntPtr au_Board_getIds(System.IntPtr board);

    [DllImport("ArucoUnity")]
    static extern void au_Board_setIds(System.IntPtr board, System.IntPtr ids);

    [DllImport("ArucoUnity")]
    static extern System.IntPtr au_Board_getObjPoints(System.IntPtr board);

    [DllImport("ArucoUnity")]
    static extern void au_Board_setObjPoints(System.IntPtr board, System.IntPtr objPoints);

    public Dictionary dictionary
    {
      get { return new Dictionary(au_Board_getDictionary(cvPtr)); }
      set { au_Board_setDictionary(cvPtr, value.cvPtr); }
    }

    public VectorInt ids
    {
      get { return new VectorInt(au_Board_getIds(cvPtr)); }
      set { au_Board_setIds(cvPtr, value.cvPtr); }
    }

    public VectorVectorPoint3f objPoints
    {
      get { return new VectorVectorPoint3f(au_Board_getObjPoints(cvPtr)); }
      set { au_Board_setObjPoints(cvPtr, value.cvPtr); }
    }
  }
}