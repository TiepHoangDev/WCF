using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IMIC.EntityObjects;

namespace WCFServiceHoaBanFood
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

      

        [OperationContract]
        MetaData<List<SPEntity>> getDSSPBYIDDMSDP(string sMADMSP);

        [OperationContract]
        MetaData<List<DMSPEntity>> getAllDMSPAPI();

        [OperationContract]
        MetaData<DMSPEntity> getDMSPById(string sMADMSP);
        [OperationContract]
        MetaData<List<LoaiKmEntity>> GetAllLoaiKm();

        [OperationContract]
        MetaData<List<SPEntity>> getAllSP_API();

        [OperationContract]
        MetaData<SPEntity> getSPByID(string sMASP);

        [OperationContract]
        MetaData<List<ChitietKmEntity>> GetAllChitietKm();

        [OperationContract]
        MetaData<LoaiKmEntity> getLoaiKmById(string MaLoaiKm);

        [OperationContract]
        MetaData<ChitietKmEntity> getChitietKmByMaspMaKm(string MaLoaiKm, string MaSp);

        [OperationContract]
        MetaData<List<ANHSPEntity>> getAllANHSP();

        [OperationContract]
        MetaData<ANHSPEntity> getANHSPByID(string sMAANH);

        [OperationContract]
        MetaData<List<BAIVIETSPEntity>> getAllBAIVIETSP();

        [OperationContract]
        MetaData<BAIVIETSPEntity> getBAIVIETSPByMASP(string sMASP);

        [OperationContract]
        MetaData<List<VIDEOSPEntity>> getAllVIDEOSP();
        [OperationContract]
        MetaData<VIDEOSPEntity> getVIDEOSPByMASP(string sMASP);

        [OperationContract]
        MetaData<List<DDHEntity>> getAllDDHAPI();

        [OperationContract]
        MetaData<List<CTDHEntity>> getAllCTDHAPI();

        [OperationContract]
        MetaData<List<ThichSPEntity>> getAllSPTHICHSP();
        [OperationContract]
        MetaData<List<ThichSPEntity>> getAllSPNV_THICH(string sMANV);
        [OperationContract]
        MetaData<List<ThichSPEntity>> getAllSP_DUOC_THICH(string sMASP);

        [OperationContract]
        MetaData<List<ANHSPEntity>> getAllANHBYSP(string sMASP);
    }
}
