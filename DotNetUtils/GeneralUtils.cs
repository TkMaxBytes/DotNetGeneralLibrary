using System;
using System.Reflection;

namespace DotNetUtils
{
    public static class GeneralUtils
    {
        public static string GetApplicationName(int intReturnType)
        {
            string strVer;

            Assembly asm = Assembly.GetExecutingAssembly();
            AssemblyName asmName = asm.GetName();
            Version objVer = asmName.Version;


            string strName = asmName.Name;
            switch (intReturnType)
            {
                case 0:
                    return strName;
                case 1:
                    strVer = String.Format("{0} - {1}.{2}.{3}.{4}", strName, objVer.Major, objVer.Minor, objVer.Build, objVer.Revision);
                    return strVer;
                default:
                    return strName;
            }
        }


    }
}
