using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaInterFaceCode
{
    public class Enum
    {
        public enum EquipmentType
        {
            PC,
            IPAD
        }
        public enum VideoType
        {
            全高清M3U8=1,//S00000001-100040(全高清M3U8) 
            高清M3U8=2,//S00000001-100030(高清M3U8)
            标清M3U8=3,//S00000001-100020(标清M3U8) 
            流畅M3U8=4,//S00000001-100010(流畅M3U8) 
            全高清MP4=5,//S00000001-200040（全高清MP4）
            高清MP4=6,//S00000001-200030（高清MP4）
            标清MP4=7,//S00000001-200020（标清MP4）
            流畅MP4=8//S00000001-200010（流畅MP4）
        }
        public enum FileType
        {
            视频类模板=1,
            音频类模板=2,
            图片类模板=3
        }
    }
}
