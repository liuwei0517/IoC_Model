using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaInterFaceCode
{
    public class Code
    {
        
        public string GetEquipmentType(Enum.EquipmentType type)
        {
            string re = "";
            switch (type)
            {
                case Enum.EquipmentType.PC:
                    re = "PC";
                    break;
                case Enum.EquipmentType.IPAD:
                    re = "IPAD";
                    break;
            }
            return re;
        }
        public int[] GetVideoTypes(Enum.EquipmentType type)
        {
            int[] vt = null;
            switch (type)
            {
                case Enum.EquipmentType.PC:
                    vt =new int[]{5,6,7,8 };
                    break;
                case Enum.EquipmentType.IPAD:
                    vt = new int[] { 1, 2,3, 4 };
                    break;
            }
            return vt;
        }
        public string GetVideoType(Enum.VideoType type)
        {
            string re = "";
            switch (type)
            {
                case Enum.VideoType.全高清M3U8:
                    re = "全高清";
                    break;
                case Enum.VideoType.高清M3U8:
                    re = "高清";
                    break;
                case Enum.VideoType.标清M3U8:
                    re = "标清";
                    break;
                case Enum.VideoType.流畅M3U8:
                    re = "流畅";
                    break;
                case Enum.VideoType.全高清MP4:
                    re = "全高清";
                    break;
                case Enum.VideoType.高清MP4:
                    re = "高清";
                    break;
                case Enum.VideoType.标清MP4:
                    re = "标清";
                    break;
                case Enum.VideoType.流畅MP4:
                    re = "流畅";
                    break;

            }
            return re;
        }
    }
}
