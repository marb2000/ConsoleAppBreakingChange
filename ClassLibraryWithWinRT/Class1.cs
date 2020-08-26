using System;

namespace ClassLibraryWithWinRT
{
    public class Class1
    {
        public string Value
        {
            get {

                var s = Windows.Storage.UserDataPaths.GetDefault().Desktop;
                return s; 
            }
        }
    }
}
