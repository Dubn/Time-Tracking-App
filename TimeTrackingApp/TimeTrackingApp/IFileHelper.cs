using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTrackingApp
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
