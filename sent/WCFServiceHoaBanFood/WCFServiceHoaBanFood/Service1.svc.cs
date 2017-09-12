using IMIC.Controllers;
using IMIC.EntityObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace WCFServiceHoaBanFood
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "API_GetAllDMSP")]
        public MetaData<List<DMSPEntity>> getAllDMSPAPI()
        {
            //1. Khởi tạo đối tượng để trả về
            MetaData<List<DMSPEntity>> objMetaData = new MetaData<List<DMSPEntity>>();

            //2. Ủy quyền thực thi nghiệp vụ để lấy dữ liệu về từ EF
            DMSPsController objController = new DMSPsController();
            List<DMSPEntity> lisDMSPs = objController.getAllElement();

            //3. 
            if (lisDMSPs.Count > 0)
            {
                objMetaData.Results = lisDMSPs;
            }
            objMetaData.TotalRecord = lisDMSPs.Count;
            return objMetaData;
        }

        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "API_GetDMSPById/{sMADMSP}")]
        public MetaData<DMSPEntity> getDMSPById(string sMADMSP)
        {
            MetaData<DMSPEntity> objMeta = new MetaData<DMSPEntity>();
            DMSPsController objController = new DMSPsController();
            DMSPEntity objEntity = objController.getElementById(sMADMSP);
            if (objEntity != null)
            {
                objMeta.TotalRecord = 1;
                objMeta.Results = objEntity;
            }
            return objMeta;
        }
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "API_GetAllLoaiKm")]
        public MetaData<List<LoaiKmEntity>> GetAllLoaiKm()
        {
            //1. Khởi tạo đối tượng để trả về
            MetaData<List<LoaiKmEntity>> objMetaData = new MetaData<List<LoaiKmEntity>>();

            //2. Ủy quyền thực thi nghiệp vụ để lấy dữ liệu về từ EF
            LoaiKmController objController = new LoaiKmController();
            List<LoaiKmEntity> listLoaiKm = objController.getAllElement();

            //3. 
            if (listLoaiKm.Count > 0)
            {
                objMetaData.Results = listLoaiKm;
            }
            objMetaData.TotalRecord = listLoaiKm.Count;
            return objMetaData;
        }

        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "API_GetAllChitietKm")]
        public MetaData<List<ChitietKmEntity>> GetAllChitietKm()
        {
            MetaData<List<ChitietKmEntity>> objMetaData = new MetaData<List<ChitietKmEntity>>();

            ChitietKmController objController = new ChitietKmController();
            List<ChitietKmEntity> lisChitietKm = new List<ChitietKmEntity>();
            lisChitietKm = objController.getAllElement();

            if (lisChitietKm.Count > 0)
            {
                objMetaData.Results = lisChitietKm;
            }
            objMetaData.TotalRecord = lisChitietKm.Count;
            return objMetaData;
        }

        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "API_GetLoaiKmById/{MaLoaiKm}")]
        public MetaData<LoaiKmEntity> getLoaiKmById(string MaLoaiKm)
        {
            MetaData<LoaiKmEntity> objMetadata = new MetaData<LoaiKmEntity>();
            LoaiKmController objController = new LoaiKmController();
            LoaiKmEntity objLoaiKm = new LoaiKmEntity();
            objLoaiKm = objController.getElementById(MaLoaiKm);
            if (objLoaiKm != null)
            {
                objMetadata.Results = objLoaiKm;
                objMetadata.TotalRecord = 1;
            }
            return objMetadata;
        }

        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "API_getChitietKmByMaspMaKm/{MaLoaiKm}/{MaSp}")]
        public MetaData<ChitietKmEntity> getChitietKmByMaspMaKm(string MaLoaiKm, string MaSp)
        {
            MetaData<ChitietKmEntity> objMetadata = new MetaData<ChitietKmEntity>();
            ChitietKmController objController = new ChitietKmController();
            ChitietKmEntity objChitiet = new ChitietKmEntity();
            objChitiet = objController.findElementBy_MaSp_MaKm(MaLoaiKm, MaSp);
            if (objChitiet != null)
            {
                objMetadata.Results = objChitiet;
                objMetadata.TotalRecord = 1;
            }
            return objMetadata;
        }
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_GetAllSP")]
        public MetaData<List<SPEntity>> getAllSP_API()
        {
            MetaData<List<SPEntity>> objMeta = new MetaData<List<SPEntity>>();
            SPController objController = new SPController();
            List<SPEntity> lisSP = objController.getAllElement();

            if (lisSP != null)
            {
                objMeta.TotalRecord = lisSP.Count();
                objMeta.Results = lisSP;
            }

            return objMeta;
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_getSPByID/{sMASP}")]
        public MetaData<SPEntity> getSPByID(string sMASP)
        {
            MetaData<SPEntity> objMeta = new MetaData<SPEntity>();
            SPController objController = new SPController();
            SPEntity objSP = objController.getElementById(sMASP);

            if (objSP != null)
            {
                objMeta.TotalRecord = 1;
                objMeta.Results = objSP;
            }
            return objMeta;
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_getAllANHSP")]
        public MetaData<List<ANHSPEntity>> getAllANHSP()
        {
            MetaData<List<ANHSPEntity>> objMeta = new MetaData<List<ANHSPEntity>>();
            ANHSPController objController = new ANHSPController();
            List<ANHSPEntity> lisSP = objController.getAllElement();

            if (lisSP != null)
            {
                objMeta.TotalRecord = lisSP.Count();
                objMeta.Results = lisSP;
            }

            return objMeta;
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_getANHSPByID/{sMAANH}")]
        public MetaData<ANHSPEntity> getANHSPByID(string sMAANH)
        {
            MetaData<ANHSPEntity> objMeta = new MetaData<ANHSPEntity>();
            ANHSPController objController = new ANHSPController();
            ANHSPEntity objSP = objController.getElementById(sMAANH);

            if (objSP != null)
            {
                objMeta.TotalRecord = 1;
                objMeta.Results = objSP;
            }
            return objMeta;
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_getAllBAIVIETSP")]
        public MetaData<List<BAIVIETSPEntity>> getAllBAIVIETSP()
        {
            MetaData<List<BAIVIETSPEntity>> objMeta = new MetaData<List<BAIVIETSPEntity>>();
            BAIVIETSPController objController = new BAIVIETSPController();
            List<BAIVIETSPEntity> lisBAIVIET = objController.getAllElement();

            if (lisBAIVIET != null)
            {
                objMeta.TotalRecord = lisBAIVIET.Count();
                objMeta.Results = lisBAIVIET;
            }

            return objMeta;
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_getBAIVIETSPByMASP/{sMASP}")]
        public MetaData<BAIVIETSPEntity> getBAIVIETSPByMASP(string sMASP)
        {
            MetaData<BAIVIETSPEntity> objMeta = new MetaData<BAIVIETSPEntity>();
            BAIVIETSPController objController = new BAIVIETSPController();
            BAIVIETSPEntity objBAIVIET = objController.findElementByMASP(sMASP);

            if (objBAIVIET != null)
            {
                objMeta.TotalRecord = 1;
                objMeta.Results = objBAIVIET;
            }

            return objMeta;
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_getAllVIDEOSP")]
        public MetaData<List<VIDEOSPEntity>> getAllVIDEOSP()
        {
            MetaData<List<VIDEOSPEntity>> objMeta = new MetaData<List<VIDEOSPEntity>>();
            VIDEOSPController objController = new VIDEOSPController();
            List<VIDEOSPEntity> lisVIDEO = objController.getAllElement();

            if (lisVIDEO != null)
            {
                objMeta.TotalRecord = lisVIDEO.Count();
                objMeta.Results = lisVIDEO;
            }

            return objMeta;
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_getVIDEOSPByMASP/{sMASP}")]
        public MetaData<VIDEOSPEntity> getVIDEOSPByMASP(string sMASP)
        {
            MetaData<VIDEOSPEntity> objMeta = new MetaData<VIDEOSPEntity>();
            VIDEOSPController objController = new VIDEOSPController();
            VIDEOSPEntity objVIDEO = objController.findElementByMaSP(sMASP);

            if (objVIDEO != null)
            {
                objMeta.TotalRecord = 1;
                objMeta.Results = objVIDEO;
            }

            return objMeta;
        }
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "API_GetAllDDH")]
        public MetaData<List<DDHEntity>> getAllDDHAPI()
        {
            //1. Khởi tạo đối tượng để trả về
            MetaData<List<DDHEntity>> objMetaData = new MetaData<List<DDHEntity>>();

            //2. Ủy quyền thực thi nghiệp vụ để lấy dữ liệu về từ EF
            DDHController objController = new DDHController();
            List<DDHEntity> lisDDH = objController.getAllElement();

            //3. 
            if (lisDDH.Count > 0)
            {
                objMetaData.Results = lisDDH;
            }
            objMetaData.TotalRecord = lisDDH.Count;
            return objMetaData;
        }


        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "API_GetAllCTDH")]
        public MetaData<List<CTDHEntity>> getAllCTDHAPI()
        {
            //1. Khởi tạo đối tượng để trả về
            MetaData<List<CTDHEntity>> objMetaData = new MetaData<List<CTDHEntity>>();

            //2. Ủy quyền thực thi nghiệp vụ để lấy dữ liệu về từ EF
            CTDHController objController = new CTDHController();
            List<CTDHEntity> lisCTDH = objController.getAllElement();

            //3. 
            if (lisCTDH.Count > 0)
            {
                objMetaData.Results = lisCTDH;
            }
            objMetaData.TotalRecord = lisCTDH.Count;
            return objMetaData;
        }

        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "API_GetAllTHICHSP")]
        public MetaData<List<ThichSPEntity>> getAllSPTHICHSP()
        {
            //1. Khởi tạo đối tượng để trả về
            MetaData<List<ThichSPEntity>> objMetaData = new MetaData<List<ThichSPEntity>>();

            //2. Ủy quyền thực thi nghiệp vụ để lấy dữ liệu về từ EF
            THICHSPController objController = new THICHSPController();
            List<ThichSPEntity> lisTHICHSP = objController.getAllElement();

            //3. 
            if (lisTHICHSP.Count > 0)
            {
                objMetaData.Results = lisTHICHSP;
            }
            objMetaData.TotalRecord = lisTHICHSP.Count;
            return objMetaData;
        }

        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "API_GetAllSP_NV_THICH/{sMANV}")]
        public MetaData<List<ThichSPEntity>> getAllSPNV_THICH(string sMANV)
        {
            //1. Khởi tạo đối tượng để trả về
            MetaData<List<ThichSPEntity>> objMetaData = new MetaData<List<ThichSPEntity>>();

            //2. Ủy quyền thực thi nghiệp vụ để lấy dữ liệu về từ EF
            THICHSPController objController = new THICHSPController();
            List<ThichSPEntity> lisNvThichSP = objController.getElementsNvThich(sMANV);

            //3. 
            if (lisNvThichSP.Count > 0)
            {
                objMetaData.Results = lisNvThichSP;
            }
            objMetaData.TotalRecord = lisNvThichSP.Count;
            return objMetaData;
        }

        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "API_GetAllSP_DUOC_THICH/{sMASP}")]
        public MetaData<List<ThichSPEntity>> getAllSP_DUOC_THICH(string sMASP)
        {
            //1. Khởi tạo đối tượng để trả về
            MetaData<List<ThichSPEntity>> objMetaData = new MetaData<List<ThichSPEntity>>();

            //2. Ủy quyền thực thi nghiệp vụ để lấy dữ liệu về từ EF
            THICHSPController objController = new THICHSPController();
            List<ThichSPEntity> lisSPDUOCTHICH = objController.getElementsNvThich(sMASP);

            //3. 
            if (lisSPDUOCTHICH.Count > 0)
            {
                objMetaData.Results = lisSPDUOCTHICH;
            }
            objMetaData.TotalRecord = lisSPDUOCTHICH.Count;
            return objMetaData;
        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_getDSSPBYIDDMSDP/{sMADMSP}")]

        MetaData<List<SPEntity>> IService1.getDSSPBYIDDMSDP(string sMADMSP)
        {
            MetaData<List<SPEntity>> objMeta = new MetaData<List<SPEntity>>();
            SPController objController = new SPController();
            List<SPEntity> lisSP = objController.findAllElementByMADMSP(sMADMSP);

            if (lisSP != null)
            {
                objMeta.TotalRecord = lisSP.Count();
                objMeta.Results = lisSP;
            }
            return objMeta;
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "API_getALLANHBYSP/{sMASP}")]
        public MetaData<List<ANHSPEntity>> getAllANHBYSP(string sMASP)
        {
             MetaData<List<ANHSPEntity>> objMeta = new MetaData<List<ANHSPEntity>>();
            ANHSPController objController = new ANHSPController();
            List<ANHSPEntity> lisANH = objController.getAllAnhBySP(sMASP);

            if (lisANH != null)
            {
                objMeta.TotalRecord = lisANH.Count();
                objMeta.Results = lisANH ;
            }
            return objMeta;
        }
    }
}
