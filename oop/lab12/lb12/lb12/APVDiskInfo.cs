using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb12
{
    public class APVDiskInfo
    {

        public static string GetDiskInfo()
        {
            var AllDrivers = DriveInfo.GetDrives();
            string str = "";
            foreach (var d in AllDrivers)
            {
                str+= "Disk Name: " + d.Name + '\n';
                str += "Disk space " + d.TotalSize.ToString() + '\n';
                str += "Disk free space " + d.TotalFreeSpace.ToString() + '\n';
                str += "Disk label: " + d.VolumeLabel ;
            }

            return str;
        }
    }
}
