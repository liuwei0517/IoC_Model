using KoalaInterFace.Models;
using KoalaInterFaceBLL;
using KoalaInterFaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KoalaInterFace.Controllers
{
    public class MTS_FileInfo_DetaileController : ApiController
    {

        BG_RequestMTS_FileInfo_Detaile_BLL<BG_RequestMTS_FileInfo_Detaile> bll = new BG_RequestMTS_FileInfo_Detaile_BLL<BG_RequestMTS_FileInfo_Detaile>();
        KoalaInterFaceCode.Convert convert = new KoalaInterFaceCode.Convert();
        KoalaInterFaceCode.Code code = new KoalaInterFaceCode.Code();
        /// <summary>
        /// 获取视频文件
        /// </summary>
        /// <param name="guid">视频文件唯一码</param>
        /// <param name="type">设备类型 IPAD,PC</param>
        /// <returns></returns>
        public string GetMTS_FileInfo_Detaile(string guid,string type)
        {
            int[] vt = null;
            if (type== code.GetEquipmentType(KoalaInterFaceCode.Enum.EquipmentType.IPAD))
            {
                vt = code.GetVideoTypes(KoalaInterFaceCode.Enum.EquipmentType.IPAD);
            }
            else
            {
                vt = code.GetVideoTypes(KoalaInterFaceCode.Enum.EquipmentType.PC);
            }

            List<Video> models= bll.GetList(m=>m.Guid== guid&& vt.Contains(m.TID)).Select(m=> {
                Video o= new Video();
                o.url= m.FilePath;
                o.title = code.GetVideoType((KoalaInterFaceCode.Enum.VideoType)m.TID);
                return o;
            }).ToList();
            Result<Video> re = new Result<Video>();
            re.error_code = "200";
            re.data = models;
            if (models.Count == 0)
            {
                re.error_code = "-100";
                re.error_massage = "没有转码成功的视频";
            }

            string res=convert.ObjectToJson(re);

            return res;
        }
    }
}
