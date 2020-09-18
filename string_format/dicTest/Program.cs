using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicTest
{
    public class FmsModTable
    {
        public static Dictionary<string, List<DBFieldInfo>> DicTableInfo = new Dictionary<string, List<DBFieldInfo>>
        {
                        #region : A
                        { "T_ABIREQDET",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_ABIREQHDID", "N20", true),
                                new DBFieldInfo("F_MESSAGE", "N4000")
                            }
                        },
                        { "T_ABIREQHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBNAME", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_ABIID", "I"),
                                new DBFieldInfo("F_CARRIER", "N4"),
                                new DBFieldInfo("F_VESSEL", "N20"),
                                new DBFieldInfo("F_VOYAGE", "N5"),
                                new DBFieldInfo("F_ARRIVE", "D"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "I")
                            }
                        },
                        { "T_ADSLIPDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_HDID", "I",true),
                                new DBFieldInfo("F_GLNo", "N10",true),
                                new DBFieldInfo("F_Decription", "N100"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_Type", "N2",true),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_Entity", "I",true),
                                new DBFieldInfo("F_PostDate", "D"),
                                new DBFieldInfo("F_Branch", "N3")
                            }
                        },
                        {"T_ADSLIPHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Branch", "N3",true),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_Vendor", "I",true),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_TBNAME", "N20"),
                                new DBFieldInfo("F_TBID", "I"),
                                new DBFieldInfo("F_Remark", "U200"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_VoidInputID", "N10"),
                                new DBFieldInfo("F_VoidInputDate", "T"),
                                new DBFieldInfo("F_Bank", "N10",true)
                            }
                        },
                        { "T_AESCOMMODITY",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_AESMAINID", "I",true),
                                new DBFieldInfo("F_QUALIFIER", "N1"),
                                new DBFieldInfo("F_CODE", "N30"),
                                new DBFieldInfo("F_UNIT1", "N3"),
                                new DBFieldInfo("F_QTY1", "I"),
                                new DBFieldInfo("F_UNIT2", "N3"),
                                new DBFieldInfo("F_QTY2", "I"),
                                new DBFieldInfo("F_PRICE", "F"),
                                new DBFieldInfo("F_KGS", "F"),
                                new DBFieldInfo("F_FD", "N1"),
                                new DBFieldInfo("F_MARKS", "N100")
                            }
                        },
                        { "T_AESMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_TBname","N20",true),
                                new DBFieldInfo("F_TBID","I",true),
                                new DBFieldInfo("F_INDICATION", "N1"),
                                new DBFieldInfo("F_TMODE", "N4"),
                                new DBFieldInfo("F_DESTCOUNTRY", "N2"),
                                new DBFieldInfo("F_VESSELFLAG", "N2"),
                                new DBFieldInfo("F_ORIGINSTATE", "N2"),
                                new DBFieldInfo("F_CARRIER", "I"),
                                new DBFieldInfo("F_VESSELNAME", "N30"),
                                new DBFieldInfo("F_RZ", "N1"),
                                new DBFieldInfo("F_QQ", "N1"),
                                new DBFieldInfo("F_ETD", "D"),
                                new DBFieldInfo("F_LCODE", "I"),
                                new DBFieldInfo("F_DCODE", "I"),
                                new DBFieldInfo("F_REFNO", "N20"),
                                new DBFieldInfo("F_BONDTYPE", "N4"),
                                new DBFieldInfo("F_LOCATIONID", "N30"),
                                new DBFieldInfo("F_TFLAG", "N1"),
                                new DBFieldInfo("F_ENTRYNO", "N15"),
                                new DBFieldInfo("F_EXNAME", "N50"),
                                new DBFieldInfo("F_EXIDTYPE", "N2"),
                                new DBFieldInfo("F_EXID", "N20"),
                                new DBFieldInfo("F_EXCONTACT", "N20"),
                                new DBFieldInfo("F_EXPHONE", "N20"),
                                new DBFieldInfo("F_EXADDR", "N100"),
                                new DBFieldInfo("F_EXCITY", "N20"),
                                new DBFieldInfo("F_EXSTATE", "N2"),
                                new DBFieldInfo("F_EXZIPCODE", "N10"),
                                new DBFieldInfo("F_EXCOUNTRY", "N4"),
                                new DBFieldInfo("F_CNNAME", "N50"),
                                new DBFieldInfo("F_CNADDR", "N100"),
                                new DBFieldInfo("F_CNCITY", "N20"),
                                new DBFieldInfo("F_CNSTATE", "N2"),
                                new DBFieldInfo("F_CNCOUNTRY", "N4"),
                                new DBFieldInfo("F_ICNAME", "N50"),
                                new DBFieldInfo("F_ICADDR", "N100"),
                                new DBFieldInfo("F_ICCITY", "N20"),
                                new DBFieldInfo("F_ICSTATE", "N2"),
                                new DBFieldInfo("F_ICCOUNTRY", "N4"),
                                new DBFieldInfo("F_EIC", "N2"),
                                new DBFieldInfo("F_EXPORTNO", "N12"),
                                new DBFieldInfo("F_EXPORTCODE", "N3"),
                                new DBFieldInfo("F_ECCNNO", "N80"),
                                new DBFieldInfo("F_VINNO", "N25"),
                                new DBFieldInfo("F_TITLENO", "N30"),
                                new DBFieldInfo("F_TITLESTATE", "N2"),
                                new DBFieldInfo("F_SEGMENT", "N4"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_StateName", "N30")
                            }
                        },
                        { "T_AESVEH",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_AESMAINID", "I",true),
                                new DBFieldInfo("F_VEHID", "N50"),
                                new DBFieldInfo("F_VEHIDQUAL", "N1"),
                                new DBFieldInfo("F_TITLENO", "N50"),
                                new DBFieldInfo("F_TITLESTATE", "N2")
                            }
                        },
                        { "T_AESVID",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_AESMAINID", "I",true),
                                new DBFieldInfo("F_INITIAL", "N4"),
                                new DBFieldInfo("F_EQNO", "N10"),
                                new DBFieldInfo("F_SEALNO", "N15")
                            }
                        },
                        { "T_AIHMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_AIMBLID", "I",true),
                                new DBFieldInfo("F_HawbNo", "N15",true),
                                new DBFieldInfo("F_Agent", "I",true),
                                new DBFieldInfo("F_AgentRefNo", "N30"),
                                new DBFieldInfo("F_Customer", "I",true),
                                new DBFieldInfo("F_CustRefNo", "N30"),
                                new DBFieldInfo("F_Shipper", "I"),
                                new DBFieldInfo("F_SName", "N250"),
                                new DBFieldInfo("F_Consignee", "I"),
                                new DBFieldInfo("F_CName", "N250"),
                                new DBFieldInfo("F_Notify", "I"),
                                new DBFieldInfo("F_NName", "N250"),
                                new DBFieldInfo("F_Broker", "I"),
                                new DBFieldInfo("F_BName", "N100"),
                                new DBFieldInfo("F_BFax", "N20"),
                                new DBFieldInfo("F_BTel", "N20"),
                                new DBFieldInfo("F_BContact", "N20"),
                                new DBFieldInfo("F_BEMail", "N100"),
                                new DBFieldInfo("F_FCode", "N3"),
                                new DBFieldInfo("F_FinalDest", "N24"),
                                new DBFieldInfo("F_ForeignDest", "N25"),
                                new DBFieldInfo("F_CFSLocation", "I"),
                                new DBFieldInfo("F_Pkgs", "F"),
                                new DBFieldInfo("F_PUnit", "N10"),
                                new DBFieldInfo("F_GrossWeight", "F"),
                                new DBFieldInfo("F_LGrossWeight", "F"),
                                new DBFieldInfo("F_ChgWeight", "F"),
                                new DBFieldInfo("F_LChgWeight", "F"),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_PPCC", "N2"),
                                new DBFieldInfo("F_Nomi", "N1"),
                                new DBFieldInfo("F_DocPickupBy", "N10"),
                                new DBFieldInfo("F_DocPickupDate", "D"),
                                new DBFieldInfo("F_Profit", "F"),
                                new DBFieldInfo("F_Mark", "N800"),
                                new DBFieldInfo("F_Description", "N1000"),
                                new DBFieldInfo("F_GODate", "D"),
                                new DBFieldInfo("F_StorageDate", "D"),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_Operator", "N10"),
                                new DBFieldInfo("F_SManID", "N10"),
                                new DBFieldInfo("F_ITClass", "N5"),
                                new DBFieldInfo("F_PickupDate", "D"),
                                new DBFieldInfo("F_ITCarrier", "I"),
                                new DBFieldInfo("F_ITNo", "N12"),
                                new DBFieldInfo("F_ITPlace", "N20"),
                                new DBFieldInfo("F_ITDate", "D"),
                                new DBFieldInfo("F_DCodeCustom", "N5"),
                                new DBFieldInfo("F_FCodeCustom", "N5"),
                                new DBFieldInfo("F_OtherDescript", "N30"),
                                new DBFieldInfo("F_IMemo", "N800"),
                                new DBFieldInfo("F_PMemo", "N800"),
                                new DBFieldInfo("F_FETA", "T"),
                                new DBFieldInfo("F_INVOICETO", "I"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_MultiNameID", "I"),
                                new DBFieldInfo("F_Released_By", "N50"),
                                new DBFieldInfo("F_WH_Arrival", "D"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_IncoTerms", "N10"),
                                new DBFieldInfo("F_AMSBLNO", "N16"),
                                new DBFieldInfo("F_PROJECTNO", "N20"),
                                new DBFieldInfo("F_SONO", "N20"),
                                new DBFieldInfo("F_PIMSPOID", "I"),
                                new DBFieldInfo("F_SHIPMENTID", "N20"),
                                new DBFieldInfo("F_NOTICEDATE", "D"),
                                new DBFieldInfo("F_CompleteBill", "N1"),
                                new DBFieldInfo("F_CompleteInvo", "N1"),
                                new DBFieldInfo("F_CompleteCrDb", "N1"),
                                new DBFieldInfo("F_Exrate1", "F"),
                                new DBFieldInfo("F_Exrate2", "F"),
                                new DBFieldInfo("F_ITDESTINATION", "N25"),
                                new DBFieldInfo("F_CARGONO", "N50"),
                                new DBFieldInfo("F_ACQUITTALNO", "N50"),
                                new DBFieldInfo("F_PREVCARGONO", "N50"),
                                new DBFieldInfo("F_MANIFESTFROM", "N50"),
                                new DBFieldInfo("F_TOA", "N50"),
                                new DBFieldInfo("F_VehicleNo", "N50"),
                                new DBFieldInfo("F_MANIFESTDATE", "D"),
                                new DBFieldInfo("F_SENTTO", "I"),
                                new DBFieldInfo("F_CLEARANCEBY", "I"),
                                new DBFieldInfo("F_CARTAGEBY", "I"),
                                new DBFieldInfo("X_PAIDDATE", "D"),
                                new DBFieldInfo("F_ShipmentType", "N1"),
                                new DBFieldInfo("F_Currency1", "N3"),
                                new DBFieldInfo("F_Currency2", "N3"),
                                new DBFieldInfo("F_Agent2", "I"),
                                new DBFieldInfo("F_Agent3", "I"),
                                new DBFieldInfo("F_DutyCustomer", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3"),
                                new DBFieldInfo("F_StatusCrDb", "N3"),
                                new DBFieldInfo("F_CloseDate", "D")
                                    }
                        },
                        { "T_AIHPONO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_AIHBLID", "I",true),
                                new DBFieldInfo("F_PONO", "N20"),
                                new DBFieldInfo("F_SKUNO", "N20"),
                                new DBFieldInfo("F_HTSCODE", "N20"),
                                new DBFieldInfo("F_description", "N50"),
                                new DBFieldInfo("F_STYLENO", "N20"),
                                new DBFieldInfo("F_ITEMNO", "N20"),
                                new DBFieldInfo("F_ShipQty", "I"),
                                new DBFieldInfo("F_kgs", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_CKGS", "F"),
                                new DBFieldInfo("F_CLBS", "F"),
                                new DBFieldInfo("F_ShipUnit", "N10"),
                                new DBFieldInfo("F_COO", "N2"),
                                new DBFieldInfo("F_UPRICE", "F"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_PimsPOHDLinkID", "I"),
                                new DBFieldInfo("F_PimsPODETLinkID", "I")
                            }
                        },
                        { "T_AIMMAIN",
                            new List<DBFieldInfo>
                                                {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_RefNo", "N20",true),
                                new DBFieldInfo("F_MawbNo", "N12",true),
                                new DBFieldInfo("F_SMawbNo", "N15"),
                                new DBFieldInfo("F_ManifestNo", "N12"),
                                new DBFieldInfo("F_Carrier", "I"),
                                new DBFieldInfo("F_Agent", "I",true),
                                new DBFieldInfo("F_AgentRefNo", "N30"),
                                new DBFieldInfo("F_FLTno", "N15"),
                                new DBFieldInfo("F_FLocation", "I"),
                                new DBFieldInfo("F_ETA", "T"),
                                new DBFieldInfo("F_ETD", "T"),
                                new DBFieldInfo("F_LCode", "N3"),
                                new DBFieldInfo("F_LoadingPort", "N50"),
                                new DBFieldInfo("F_DCode", "N3"),
                                new DBFieldInfo("F_Discharge", "N50"),
                                new DBFieldInfo("F_PPCC", "N2"),
                                new DBFieldInfo("F_Pkgs", "I"),
                                new DBFieldInfo("F_GrossWeight", "F"),
                                new DBFieldInfo("F_LGrossWeight", "F"),
                                new DBFieldInfo("F_ChgWeight", "F"),
                                new DBFieldInfo("F_LChgWeight", "F"),
                                new DBFieldInfo("F_Currency", "N10"),
                                new DBFieldInfo("F_StorageDate", "D"),
                                new DBFieldInfo("F_GODate", "D"),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_VesselFlag", "N10"),
                                new DBFieldInfo("F_Country", "N10"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_PICKUPDATE", "D"),
                                new DBFieldInfo("F_PICKUPLOC", "N60"),
                                new DBFieldInfo("F_ATD", "D"),
                                new DBFieldInfo("F_ATDLOC", "N60"),
                                new DBFieldInfo("F_CUSTOMRLS", "D"),
                                new DBFieldInfo("F_CUSTMRLSLOC", "N60"),
                                new DBFieldInfo("F_ATA", "D"),
                                new DBFieldInfo("F_ATALOC", "N60"),
                                new DBFieldInfo("F_AVAIL", "D"),
                                new DBFieldInfo("F_AVAILLOC", "N60"),
                                new DBFieldInfo("F_DELIVERY", "D"),
                                new DBFieldInfo("F_DELVLOC", "N60"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_Operator", "N10"),
                                new DBFieldInfo("F_PimsLinkUserID", "N70"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_PimsAgentName", "N50"),
                                new DBFieldInfo("F_PICKUPNO", "N15"),
                                new DBFieldInfo("F_CUR1", "N3"),
                                new DBFieldInfo("F_CUR2", "N3"),
                                new DBFieldInfo("F_EXRATE1", "F"),
                                new DBFieldInfo("F_EXRATE2", "F"),
                                new DBFieldInfo("F_CompleteBill", "N1"),
                                new DBFieldInfo("F_CompleteInvo", "N1"),
                                new DBFieldInfo("F_CompleteCrDb", "N1"),
                                new DBFieldInfo("F_FirstCode", "N3"),
                                new DBFieldInfo("F_FirstPort", "N50"),
                                new DBFieldInfo("F_FirstPortETA", "D"),
                                new DBFieldInfo("F_LastPort", "N50"),
                                new DBFieldInfo("F_MANIFESTFROM", "N12"),
                                new DBFieldInfo("F_TOAgent", "N20"),
                                new DBFieldInfo("F_DirectBL", "N1"),
                                new DBFieldInfo("F_ProfitShare", "F"),
                                new DBFieldInfo("F_Line", "N5"),
                                new DBFieldInfo("F_ConfirmDate", "D",true),
                                new DBFieldInfo("F_ConfirmedBy", "N10"),
                                new DBFieldInfo("F_ShipmentType", "N1"),
                                new DBFieldInfo("F_Agent2", "I"),
                                new DBFieldInfo("F_Agent3", "I"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3"),
                                new DBFieldInfo("F_StatusCrDb", "N3"),
                                new DBFieldInfo("F_MSManID", "N10"),
                                new DBFieldInfo("F_ConfirmActionDate", "D"),
                                new DBFieldInfo("F_DutyCustomer", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_MBLCustomer", "I"),
                                new DBFieldInfo("F_CloseDate", "D")
                            }
                        },
                        { "T_AMEMO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_SEQ", "I",true),
                                new DBFieldInfo("F_TYPE", "I",true),
                                new DBFieldInfo("F_Contents", "U3800"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_AOHACCT",
                            new List<DBFieldInfo>
                                                {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_AOHBLID", "I",true),
                                new DBFieldInfo("F_ChgCode", "N50",true),
                                new DBFieldInfo("F_Description", "U110"),
                                new DBFieldInfo("F_PreCost", "F"),
                                new DBFieldInfo("F_PreRevenue", "F"),
                                new DBFieldInfo("F_ColCost", "F"),
                                new DBFieldInfo("F_ColRevenue", "F"),
                                new DBFieldInfo("F_AgentShow", "N1"),
                                new DBFieldInfo("F_Seq", "I")
                            }
                        },
                        { "T_AOHMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_AOMBLID", "I",true),
                                new DBFieldInfo("F_HAWBNo", "N15",true),
                                new DBFieldInfo("F_BLDate", "D"),
                                new DBFieldInfo("F_BLType", "N1"),
                                new DBFieldInfo("F_Agent", "I",true),
                                new DBFieldInfo("F_ThirdParty", "I"),
                                new DBFieldInfo("F_Customer", "I",true),
                                new DBFieldInfo("F_ExpRefNo", "N100"),
                                new DBFieldInfo("F_Shipper", "I"),
                                new DBFieldInfo("F_SName", "N250"),
                                new DBFieldInfo("F_Consignee", "I"),
                                new DBFieldInfo("F_CName", "N250"),
                                new DBFieldInfo("F_Notify", "I"),
                                new DBFieldInfo("F_NName", "N250"),
                                new DBFieldInfo("F_PPCC", "N2"),
                                new DBFieldInfo("F_Nomi", "N1"),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_Pkgs", "I"),
                                new DBFieldInfo("F_PUnit", "N10"),
                                new DBFieldInfo("F_GrossWeight", "F"),
                                new DBFieldInfo("F_LGrossWeight", "F"),
                                new DBFieldInfo("F_ChgWeight", "F"),
                                new DBFieldInfo("F_LChgWeight", "F"),
                                new DBFieldInfo("F_CGrossWeight", "F"),
                                new DBFieldInfo("F_CLGrossWeight", "F"),
                                new DBFieldInfo("F_CChgWeight", "F"),
                                new DBFieldInfo("F_CLChgWeight", "F"),
                                new DBFieldInfo("F_KL", "N1"),
                                new DBFieldInfo("F_ARate", "F"),
                                new DBFieldInfo("F_ACurr", "N10"),
                                new DBFieldInfo("F_AKL", "N1"),
                                new DBFieldInfo("F_AAmount", "F"),
                                new DBFieldInfo("F_CRate", "F"),
                                new DBFieldInfo("F_CKL", "N1"),
                                new DBFieldInfo("F_CCurr", "N10"),
                                new DBFieldInfo("F_CAmount", "F"),
                                new DBFieldInfo("F_CarVal", "N15"),
                                new DBFieldInfo("F_CusVal", "N15"),
                                new DBFieldInfo("F_IAmount", "F"),
                                new DBFieldInfo("F_PWTChg", "F"),
                                new DBFieldInfo("F_PVALChg", "F"),
                                new DBFieldInfo("F_PTAX", "F"),
                                new DBFieldInfo("F_PAGTChg", "F"),
                                new DBFieldInfo("F_PCARChg", "F"),
                                new DBFieldInfo("F_PTotal", "F"),
                                new DBFieldInfo("F_CWTChg", "F"),
                                new DBFieldInfo("F_CVALChg", "F"),
                                new DBFieldInfo("F_CTAX", "F"),
                                new DBFieldInfo("F_CAGTChg", "F"),
                                new DBFieldInfo("F_CCARChg", "F"),
                                new DBFieldInfo("F_CTotal", "F"),
                                new DBFieldInfo("F_ProfitShare", "F"),
                                new DBFieldInfo("F_Mark", "N800"),
                                new DBFieldInfo("F_Description", "N1000"),
                                new DBFieldInfo("F_AccountInfo", "N800"),
                                new DBFieldInfo("F_HandInfo", "N800"),
                                new DBFieldInfo("F_OtherInfo", "N800"),
                                new DBFieldInfo("F_Rider", "N2000"),
                                new DBFieldInfo("F_ShowCharge", "N1"),
                                new DBFieldInfo("F_ShowOther", "N1"),
                                new DBFieldInfo("F_ShowOtherAmt", "N1"),
                                new DBFieldInfo("F_ShowToBy", "N1"),
                                new DBFieldInfo("F_ShowPrepaid", "N1"),
                                new DBFieldInfo("F_ShowKL", "N1"),
                                new DBFieldInfo("F_IssuedBy", "N10"),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_SManID", "N10"),
                                new DBFieldInfo("F_DefaultRate", "F"),
                                new DBFieldInfo("F_Remark", "N50"),
                                new DBFieldInfo("F_Hloadingport", "N50"),
                                new DBFieldInfo("F_Hdischarge", "N50"),
                                new DBFieldInfo("F_INVOICETO", "I"),
                                new DBFieldInfo("F_QuoteID", "I"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_OOHBLID", "I"),
                                new DBFieldInfo("F_RecInvoice", "N50"),
                                new DBFieldInfo("F_COrigin", "N50"),
                                new DBFieldInfo("F_UKShipper", "I"),
                                new DBFieldInfo("F_UKSName", "N250"),
                                new DBFieldInfo("F_OPERATOR", "N10"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_IncoTerms", "N10"),
                                new DBFieldInfo("F_PimsImporterID", "I"),
                                new DBFieldInfo("f_PimsShipperID", "I"),
                                new DBFieldInfo("F_PimsConsigneeID", "I"),
                                new DBFieldInfo("F_PROJECTNO", "N20"),
                                new DBFieldInfo("F_SONO", "N20"),
                                new DBFieldInfo("F_PIMSPOID", "I"),
                                new DBFieldInfo("F_SHIPMENTID", "N20"),
                                new DBFieldInfo("F_NOTICEDATE", "D"),
                                new DBFieldInfo("F_CompleteBill", "N1"),
                                new DBFieldInfo("F_CompleteInvo", "N1"),
                                new DBFieldInfo("F_CompleteCrDb", "N1"),
                                new DBFieldInfo("F_EXRATE1", "F"),
                                new DBFieldInfo("F_EXRATE2", "F"),
                                new DBFieldInfo("F_ShipmentType", "N1"),
                                new DBFieldInfo("F_Currency1", "N3"),
                                new DBFieldInfo("F_Currency2", "N3"),
                                new DBFieldInfo("F_Agent2", "I"),
                                new DBFieldInfo("F_Agent3", "I"),
                                new DBFieldInfo("F_DutyCustomer", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3"),
                                new DBFieldInfo("F_StatusCrDb", "N3"),
                                new DBFieldInfo("F_ForwardAgent", "I"),
                                new DBFieldInfo("F_CloseDate", "D")
                            }
                        },
                        { "T_AOHPONO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_AOHBLID", "I",true),
                                new DBFieldInfo("F_PONO", "N20"),
                                new DBFieldInfo("F_SKUNO", "N20"),
                                new DBFieldInfo("F_HTSCODE", "N20"),
                                new DBFieldInfo("F_description", "N50"),
                                new DBFieldInfo("F_STYLENO", "N20"),
                                new DBFieldInfo("F_ITEMNO", "N20"),
                                new DBFieldInfo("F_ShipQty", "I"),
                                new DBFieldInfo("F_kgs", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_CKGS", "F"),
                                new DBFieldInfo("F_CLBS", "F"),
                                new DBFieldInfo("F_ShipUnit", "N10"),
                                new DBFieldInfo("F_COO", "N2"),
                                new DBFieldInfo("F_UPRICE", "F"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_PimsPOHDLinkID", "I"),
                                new DBFieldInfo("F_PimsPODETLinkID", "I")
                            }
                        },
                        { "T_AOHQUODETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_QuoteHDID", "I",true),
                                new DBFieldInfo("F_Mode", "N5"),
                                new DBFieldInfo("F_TT", "N2"),
                                new DBFieldInfo("F_Carrier", "N15"),
                                new DBFieldInfo("F_CarQuote", "N15"),
                                new DBFieldInfo("F_ChargeDesc", "N50"),
                                new DBFieldInfo("F_Unit", "N10"),
                                new DBFieldInfo("F_Qty", "F"),
                                new DBFieldInfo("F_Buying", "F"),
                                new DBFieldInfo("F_Selling", "F"),
                                new DBFieldInfo("F_Seq", "I")
                            }
                        },
                        { "T_AOHQUOTATION",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_QuoteNO", "N20",true),
                                new DBFieldInfo("F_Customer", "I",true),
                                new DBFieldInfo("F_Agent", "I",true),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_PLOFREC", "N25"),
                                new DBFieldInfo("F_PLOFDEL", "N25"),
                                new DBFieldInfo("F_LCode", "I"),
                                new DBFieldInfo("F_LoadingPort", "N50"),
                                new DBFieldInfo("F_DCode", "I"),
                                new DBFieldInfo("F_DisCharge", "N50"),
                                new DBFieldInfo("F_FinalDest", "N30"),
                                new DBFieldInfo("F_Pkgs", "F"),
                                new DBFieldInfo("F_PUnit", "N10"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_KGS", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_QuoteDate", "D"),
                                new DBFieldInfo("F_SManID", "N10"),
                                new DBFieldInfo("F_Operator", "N10"),
                                new DBFieldInfo("F_MoveType", "N10"),
                                new DBFieldInfo("F_ServiceType", "N10"),
                                new DBFieldInfo("F_ValidityDate", "D"),
                                new DBFieldInfo("F_OChargeDesc1", "N100"),
                                new DBFieldInfo("F_OChargeDesc2", "N100"),
                                new DBFieldInfo("F_OChargeDesc3", "N100"),
                                new DBFieldInfo("F_OChargeDesc4", "N100"),
                                new DBFieldInfo("F_OChargeDesc5", "N100"),
                                new DBFieldInfo("F_OChargeDesc6", "N100"),
                                new DBFieldInfo("F_OChargeAmt1", "F"),
                                new DBFieldInfo("F_OChargeAmt2", "F"),
                                new DBFieldInfo("F_OChargeAmt3", "F"),
                                new DBFieldInfo("F_OChargeAmt4", "F"),
                                new DBFieldInfo("F_OChargeAmt5", "F"),
                                new DBFieldInfo("F_OChargeAmt6", "F"),
                                new DBFieldInfo("F_Remark", "N1000"),
                                new DBFieldInfo("F_Remark2", "N1000"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_FreeFormChk", "N1"),
                                new DBFieldInfo("F_FreeFormText", "N4100"),
                                new DBFieldInfo("F_RateQuoteText", "N50")
                            }
                        },
                        { "T_AOINV",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_Seq", "I",true),
                                new DBFieldInfo("F_Length", "F"),
                                new DBFieldInfo("F_Width", "F"),
                                new DBFieldInfo("F_Height", "F"),
                                new DBFieldInfo("F_Pcs", "I"),
                                new DBFieldInfo("F_ChgWeight", "F"),
                                new DBFieldInfo("F_LChgWeight", "F")
                            }
                        },
                        { "T_AOMMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_MawbNo", "N12",true),
                                new DBFieldInfo("F_RefNo", "N20",true),
                                new DBFieldInfo("F_BLDate", "D"),
                                new DBFieldInfo("F_Agent", "I",true),
                                new DBFieldInfo("F_ETA", "T"),
                                new DBFieldInfo("F_ETD", "T"),
                                new DBFieldInfo("F_BLType", "N1"),
                                new DBFieldInfo("F_Shipper", "I"),
                                new DBFieldInfo("F_FLTNo", "N15"),
                                new DBFieldInfo("F_LCode", "N3"),
                                new DBFieldInfo("F_LoadingPort", "N50"),
                                new DBFieldInfo("F_Dcode", "N3"),
                                new DBFieldInfo("F_Discharge", "N50"),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_To1", "N3"),
                                new DBFieldInfo("F_By1", "N15"),
                                new DBFieldInfo("F_To2", "N3"),
                                new DBFieldInfo("F_By2", "N15"),
                                new DBFieldInfo("F_Carrier", "I"),
                                new DBFieldInfo("F_IssuingCarrier", "I"),
                                new DBFieldInfo("F_IATACode", "N15"),
                                new DBFieldInfo("F_AccountNo", "N15"),
                                new DBFieldInfo("F_CarrierSpotNo", "N20"),
                                new DBFieldInfo("F_BRate", "F"),
                                new DBFieldInfo("F_BCurr", "N3"),
                                new DBFieldInfo("F_BKL", "N1"),
                                new DBFieldInfo("F_BAmount", "F"),
                                new DBFieldInfo("F_IATArate", "F"),
                                new DBFieldInfo("F_IATAcurr", "N3"),
                                new DBFieldInfo("F_IATAKL", "N1"),
                                new DBFieldInfo("F_IATAAmount", "F"),
                                new DBFieldInfo("F_CarVal", "N15"),
                                new DBFieldInfo("F_CusVal", "N15"),
                                new DBFieldInfo("F_IAmount", "F"),
                                new DBFieldInfo("F_Pkgs", "I"),
                                new DBFieldInfo("F_GrossWeight", "F"),
                                new DBFieldInfo("F_LGrossWeight", "F"),
                                new DBFieldInfo("F_ChgWeight", "F"),
                                new DBFieldInfo("F_LChgWeight", "F"),
                                new DBFieldInfo("F_KL", "N1"),
                                new DBFieldInfo("F_PPCC", "N2"),
                                new DBFieldInfo("F_Mark", "N800"),
                                new DBFieldInfo("F_Description", "N1000"),
                                new DBFieldInfo("F_AccountInfo", "N800"),
                                new DBFieldInfo("F_HandInfo", "N800"),
                                new DBFieldInfo("F_OtherInfo", "N800"),
                                new DBFieldInfo("F_PWTChg", "F"),
                                new DBFieldInfo("F_PVALChg", "F"),
                                new DBFieldInfo("F_PTAXChg", "F"),
                                new DBFieldInfo("F_PAGTChg", "F"),
                                new DBFieldInfo("F_PCARChg", "F"),
                                new DBFieldInfo("F_PTotal", "F"),
                                new DBFieldInfo("F_CWTChg", "F"),
                                new DBFieldInfo("F_CVALChg", "F"),
                                new DBFieldInfo("F_CTAXChg", "F"),
                                new DBFieldInfo("F_CAGTChg", "F"),
                                new DBFieldInfo("F_CCarChg", "F"),
                                new DBFieldInfo("F_CTotal", "F"),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_RATECLASS", "N1"),
                                new DBFieldInfo("F_PICKUPDATE", "D"),
                                new DBFieldInfo("F_PICKUPLOC", "N60"),
                                new DBFieldInfo("F_ATD", "D"),
                                new DBFieldInfo("F_ATDLOC", "N60"),
                                new DBFieldInfo("F_CUSTOMRLS", "D"),
                                new DBFieldInfo("F_CUSTMRLSLOC", "N60"),
                                new DBFieldInfo("F_ATA", "D"),
                                new DBFieldInfo("F_ATALOC", "N60"),
                                new DBFieldInfo("F_AVAIL", "D"),
                                new DBFieldInfo("F_AVAILLOC", "N60"),
                                new DBFieldInfo("F_DELIVERY", "D"),
                                new DBFieldInfo("F_DELVLOC", "N60"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_CutOff", "T"),
                                new DBFieldInfo("F_Remark", "N800"),
                                new DBFieldInfo("F_Operator", "N10"),
                                new DBFieldInfo("F_PimsLinkUserID", "N70"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_PimsAgentName", "N50"),
                                new DBFieldInfo("F_PICKUPNO", "N15"),
                                new DBFieldInfo("F_CUR1", "N3"),
                                new DBFieldInfo("F_CUR2", "N3"),
                                new DBFieldInfo("F_EXRATE1", "F"),
                                new DBFieldInfo("F_EXRATE2", "F"),
                                new DBFieldInfo("F_CompleteBill", "N1"),
                                new DBFieldInfo("F_CompleteInvo", "N1"),
                                new DBFieldInfo("F_CompleteCrDb", "N1"),
                                new DBFieldInfo("F_ProfitShare", "F"),
                                new DBFieldInfo("F_SentAgentEDI", "N1"),
                                new DBFieldInfo("F_Line", "N5"),
                                new DBFieldInfo("F_ConfirmDate", "D",true),
                                new DBFieldInfo("F_ConfirmedBy", "N10"),
                                new DBFieldInfo("F_ShipmentType", "N1"),
                                new DBFieldInfo("F_Agent2", "I"),
                                new DBFieldInfo("F_Agent3", "I"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3"),
                                new DBFieldInfo("F_StatusCrDb", "N3"),
                                new DBFieldInfo("F_MSManID", "N10"),
                                new DBFieldInfo("F_PayableTo", "I",true),
                                new DBFieldInfo("F_ConfirmActionDate", "D"),
                                new DBFieldInfo("F_DutyCustomer", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_MBLCustomer", "I"),
                                new DBFieldInfo("F_CloseDate", "D")
                                    }
                        },
                        { "T_AOTHERINFO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_TBNAME", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_TYPE", "I",true),
                                new DBFieldInfo("F_C1", "N250"),
                                new DBFieldInfo("F_C2", "N250"),
                                new DBFieldInfo("F_C3", "N250"),
                                new DBFieldInfo("F_C4", "N250"),
                                new DBFieldInfo("F_C5", "N250"),
                                new DBFieldInfo("F_C6", "N3500"),
                                new DBFieldInfo("F_C7", "N250"),
                                new DBFieldInfo("F_C8", "N250"),
                                new DBFieldInfo("F_C9", "N250"),
                                new DBFieldInfo("F_C10", "N3500"),
                                new DBFieldInfo("F_N1", "I"),
                                new DBFieldInfo("F_N2", "I"),
                                new DBFieldInfo("F_N3", "I"),
                                new DBFieldInfo("F_N4", "I"),
                                new DBFieldInfo("F_N5", "I"),
                                new DBFieldInfo("F_N6", "I"),
                                new DBFieldInfo("F_N7", "I"),
                                new DBFieldInfo("F_N8", "I"),
                                new DBFieldInfo("F_N9", "I"),
                                new DBFieldInfo("F_N10", "I"),
                                new DBFieldInfo("F_D1", "D"),
                                new DBFieldInfo("F_D2", "D"),
                                new DBFieldInfo("F_D3", "D"),
                                new DBFieldInfo("F_D4", "D"),
                                new DBFieldInfo("F_D5", "D"),
                                new DBFieldInfo("F_D6", "D"),
                                new DBFieldInfo("F_D7", "D"),
                                new DBFieldInfo("F_D8", "D"),
                                new DBFieldInfo("F_D9", "D"),
                                new DBFieldInfo("F_D10", "D"),
                                new DBFieldInfo("F_F1", "F"),
                                new DBFieldInfo("F_F2", "F"),
                                new DBFieldInfo("F_F3", "F"),
                                new DBFieldInfo("F_F4", "F"),
                                new DBFieldInfo("F_F5", "F"),
                                new DBFieldInfo("F_F6", "F"),
                                new DBFieldInfo("F_F7", "F"),
                                new DBFieldInfo("F_F8", "F"),
                                new DBFieldInfo("F_F9", "F"),
                                new DBFieldInfo("F_F10", "F"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_AOTHERLOCAL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_TBNAME", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_TYPE", "I",true),
                                new DBFieldInfo("F_C1", "U600"),
                                new DBFieldInfo("F_C2", "U600"),
                                new DBFieldInfo("F_C3", "U600"),
                                new DBFieldInfo("F_C4", "U600"),
                                new DBFieldInfo("F_C5", "U600"),
                                new DBFieldInfo("F_C6", "U600"),
                                new DBFieldInfo("F_C7", "U600"),
                                new DBFieldInfo("F_C8", "U600"),
                                new DBFieldInfo("F_C9", "U600"),
                                new DBFieldInfo("F_C10", "U600")
                            }
                        },
                        { "T_APDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_APHDID", "I",true),
                                new DBFieldInfo("F_STBName", "N20",true),
                                new DBFieldInfo("F_STBID", "I",true),
                                new DBFieldInfo("F_BillingCode", "N30",true),
                                new DBFieldInfo("F_Description", "L100"),
                                new DBFieldInfo("F_Rate", "F"),
                                new DBFieldInfo("F_Qty", "F"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_Cur", "N3"),
                                new DBFieldInfo("F_Exrate", "F"),
                                new DBFieldInfo("F_LAmount", "F"),
                                new DBFieldInfo("F_UseVat", "N1"),
                                new DBFieldInfo("F_VatAmount", "F"),
                                new DBFieldInfo("F_AgtAmount", "F"),
                                new DBFieldInfo("F_LAgtAmount", "F"),
                                new DBFieldInfo("F_AgtCur", "N3"),
                                new DBFieldInfo("F_AgtExRate", "F"),
                                new DBFieldInfo("F_VATGLNO", "N10"),
                                new DBFieldInfo("F_CurAmount", "F"),
                                new DBFieldInfo("F_ChgType", "I"),
                                new DBFieldInfo("F_PS", "N1"),
                                new DBFieldInfo("F_DBRANCH", "N3",true),
                                new DBFieldInfo("F_ENTITY", "I",true),
                                new DBFieldInfo("F_SubCode", "U20"),
                                new DBFieldInfo("F_Agent", "I")
                            }
                        },
                        { "T_APHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_PayTo", "I",true),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_Descript", "L100"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_Invoiced", "N1"),
                                new DBFieldInfo("F_InvoiceDate", "D",true),
                                new DBFieldInfo("F_InvoiceNo", "N30"),
                                new DBFieldInfo("F_DueDate", "D"),
                                new DBFieldInfo("F_InvoiceAmt", "F"),
                                new DBFieldInfo("F_PaidAmt", "F"),
                                new DBFieldInfo("F_CheckNo", "N35"),
                                new DBFieldInfo("F_PaidDate", "D"),
                                new DBFieldInfo("F_Terms", "I"),
                                new DBFieldInfo("F_Block", "N1"),
                                new DBFieldInfo("F_Hold", "N1"),
                                new DBFieldInfo("F_HoldUser", "N10"),
                                new DBFieldInfo("F_HoldReason", "U30"),
                                new DBFieldInfo("F_RemarksYN", "N1"),
                                new DBFieldInfo("F_Remarks", "U30"),
                                new DBFieldInfo("F_RemkUser", "N10"),
                                new DBFieldInfo("F_Approved", "N1"),
                                new DBFieldInfo("F_ApprovedUser", "N10"),
                                new DBFieldInfo("F_AppPaidDate", "D"),
                                new DBFieldInfo("F_Cur1", "N3"),
                                new DBFieldInfo("F_Cur2", "N3"),
                                new DBFieldInfo("F_Exrate1", "F"),
                                new DBFieldInfo("F_Exrate2", "F"),
                                new DBFieldInfo("F_TVatAmt", "F"),
                                new DBFieldInfo("F_TLAmount", "F"),
                                new DBFieldInfo("F_PAYGLNO", "N10"),
                                new DBFieldInfo("F_Agent", "I"),
                                new DBFieldInfo("F_CONTAINERID", "I"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_UseLocalLanguage", "I"),
                                new DBFieldInfo("F_APBranch", "N3",true),
                                new DBFieldInfo("F_JobName", "N20"),
                                new DBFieldInfo("F_UseAdvRec", "I",true),
                                new DBFieldInfo("F_AdvRecAmount", "F"),
                                new DBFieldInfo("F_DutyAmt", "F"),
                                new DBFieldInfo("F_DutyLAmt", "F"),
                                new DBFieldInfo("F_DutyPaidAmt", "F"),
                                new DBFieldInfo("F_DutyEntity", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_Memo", "U600"),
                                new DBFieldInfo("F_OriginInvId", "I"),
                                new DBFieldInfo("F_IsCredit", "I"),
                                new DBFieldInfo("F_CreditINVOHDId", "I"),
                                new DBFieldInfo("F_YourRef", "N100"),
                                new DBFieldInfo("F_PrepaidExStatus", "N1")
                            }
                        },
                        { "T_AUTOCHGDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_HDID", "I"),
                                new DBFieldInfo("F_Origin", "N10"),
                                new DBFieldInfo("F_OriginAgentID", "I"),
                                new DBFieldInfo("F_ChgCode", "N15"),
                                new DBFieldInfo("F_ChgType", "N1"),
                                new DBFieldInfo("F_MinCharge", "F"),
                                new DBFieldInfo("F_Level1", "F"),
                                new DBFieldInfo("F_Rate1", "F"),
                                new DBFieldInfo("F_Level2", "F"),
                                new DBFieldInfo("F_Rate2", "F"),
                                new DBFieldInfo("F_Level3", "F"),
                                new DBFieldInfo("F_Rate3", "F"),
                                new DBFieldInfo("F_Level4", "F"),
                                new DBFieldInfo("F_Rate4", "F"),
                                new DBFieldInfo("F_Level5", "F"),
                                new DBFieldInfo("F_Rate5", "F"),
                                new DBFieldInfo("F_Level6", "F"),
                                new DBFieldInfo("F_Rate6", "F"),
                                new DBFieldInfo("F_Level7", "F"),
                                new DBFieldInfo("F_Rate7", "F"),
                                new DBFieldInfo("F_Level8", "F"),
                                new DBFieldInfo("F_Rate8", "F")
                            }
                        },
                        { "T_AUTOCHGHD",
                                new List<DBFieldInfo>
                                {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CustomerID", "I"),
                                new DBFieldInfo("F_Incoterms", "N4"),
                                new DBFieldInfo("F_EffectDate", "D"),
                                new DBFieldInfo("F_ExpireDate", "D"),
                                new DBFieldInfo("F_Destination", "N10"),
                                new DBFieldInfo("F_Import", "N1"),
                                new DBFieldInfo("F_PayType", "N1"),
                                new DBFieldInfo("F_WgtType","N1"),
                                new DBFieldInfo("F_ShipType", "N1")
                                }
                        },
                        #endregion
                        #region:B
                        { "T_BankRecon",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Date", "D",true),
                                new DBFieldInfo("F_BankId", "I",true),
                                new DBFieldInfo("F_BookValue", "E12,2"),
                                new DBFieldInfo("F_BankValue", "E12,2"),
                                new DBFieldInfo("F_Difference", "E12,2"),
                                new DBFieldInfo("F_Remark", "L500"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_BANKTRANSFER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_PostDate", "D"),
                                new DBFieldInfo("F_Remark", "N200"),
                                new DBFieldInfo("F_TransferFrom", "I"),
                                new DBFieldInfo("F_FCurrency", "N3"),
                                new DBFieldInfo("F_FBalance", "F"),
                                new DBFieldInfo("F_FExRate", "F"),
                                new DBFieldInfo("F_FLBalance", "F"),
                                new DBFieldInfo("F_TransferTo", "I"),
                                new DBFieldInfo("F_TCurrency", "N3"),
                                new DBFieldInfo("F_TBalance", "F"),
                                new DBFieldInfo("F_TExRate", "F"),
                                new DBFieldInfo("F_TLBalance", "F"),
                                new DBFieldInfo("F_TransferAmount", "F"),
                                new DBFieldInfo("F_ExRate", "F"),
                                new DBFieldInfo("F_FBankCharge", "F"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_TBankCharge", "F"),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_VoidInputID", "N10"),
                                new DBFieldInfo("F_VoidInputDate", "T")
                            }
                        },
                        { "T_BLHistory",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_RefNo", "N20"),
                                new DBFieldInfo("F_BLNo", "N20"),
                                new DBFieldInfo("F_LoadingPort", "N50"),
                                new DBFieldInfo("F_ETD", "D"),
                                new DBFieldInfo("F_Discharge", "N50"),
                                new DBFieldInfo("F_ETA", "D"),
                                new DBFieldInfo("F_Customer", "I"),
                                new DBFieldInfo("F_Agent", "I"),
                                new DBFieldInfo("F_ActionType", "N5"),
                                new DBFieldInfo("F_ActionBy", "N10"),
                                new DBFieldInfo("F_ActionDate", "T"),
                                new DBFieldInfo("F_Type", "N10")
                            }
                        },
                        { "T_BLINFO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_TBNAME", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_SIGSHIPPER", "N150"),
                                new DBFieldInfo("F_SIGCARRIER", "N150"),
                                new DBFieldInfo("F_FIRSTCARRIER", "N150")
                            }
                        },
                        { "T_BNXBLDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_STBName", "N20",true),
                                new DBFieldInfo("F_STBID", "I",true),
                                new DBFieldInfo("F_Description", "N100"),
                                new DBFieldInfo("F_Rate", "F"),
                                new DBFieldInfo("F_Qty", "F"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_COD", "F"),
                                new DBFieldInfo("F_Advances", "F")
                            }
                        },
                        #endregion
                        #region:C
                        { "T_CABKREQ",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OOMID", "I",true),
                                new DBFieldInfo("F_SID", "N30",true),
                                new DBFieldInfo("F_Action", "N1"),
                                new DBFieldInfo("F_PickupDate", "T"),
                                new DBFieldInfo("F_DeliverDate", "T"),
                                new DBFieldInfo("F_Scac", "N4"),
                                new DBFieldInfo("F_SvcType", "N2"),
                                new DBFieldInfo("F_ExpDeclare", "N2"),
                                new DBFieldInfo("F_Splited", "N1"),
                                new DBFieldInfo("F_CargoNature", "N2"),
                                new DBFieldInfo("F_SpecialHandle", "N180"),
                                new DBFieldInfo("F_ContactName", "N60"),
                                new DBFieldInfo("F_ContactEM", "N80"),
                                new DBFieldInfo("F_ContactTE", "N80"),
                                new DBFieldInfo("F_ContactFX", "N80"),
                                new DBFieldInfo("F_Reefer", "N1"),
                                new DBFieldInfo("F_Cel", "F"),
                                new DBFieldInfo("F_Fah", "F"),
                                new DBFieldInfo("F_Humidity", "I"),
                                new DBFieldInfo("F_CallSign", "N8"),
                                new DBFieldInfo("F_Remark", "N60"),
                                new DBFieldInfo("F_U1ID", "N15"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_Requested", "T"),
                                new DBFieldInfo("F_DeclineCode", "N3"),
                                new DBFieldInfo("F_PLORCode", "N30"),
                                new DBFieldInfo("F_PLORName", "N24"),
                                new DBFieldInfo("F_PLODCode", "N30"),
                                new DBFieldInfo("F_PLODName", "N24"),
                                new DBFieldInfo("F_Status", "N3"),
                                new DBFieldInfo("F_ICControlNo", "N14")
                            }
                        },
                        { "T_CABKRSP",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_SID", "N30",true),
                                new DBFieldInfo("F_Scac", "N4"),
                                new DBFieldInfo("F_Response", "N3"),
                                new DBFieldInfo("F_CACName", "N60"),
                                new DBFieldInfo("F_CACEM", "N80"),
                                new DBFieldInfo("F_CACTE", "N80"),
                                new DBFieldInfo("F_CACFX", "N80"),
                                new DBFieldInfo("F_BookingNo", "N17",true),
                                new DBFieldInfo("F_ETD", "D"),
                                new DBFieldInfo("F_ETA", "D"),
                                new DBFieldInfo("F_CutoffDate", "T"),
                                new DBFieldInfo("F_PickupDate", "T"),
                                new DBFieldInfo("F_DeliverDate", "T"),
                                new DBFieldInfo("F_SvcType", "N8"),
                                new DBFieldInfo("F_PLORCode", "N30"),
                                new DBFieldInfo("F_PLORName", "N24"),
                                new DBFieldInfo("F_PLORCountry", "N3"),
                                new DBFieldInfo("F_POLCode", "N30"),
                                new DBFieldInfo("F_POLName", "N24"),
                                new DBFieldInfo("F_POLCountry", "N3"),
                                new DBFieldInfo("F_PODCode", "N30"),
                                new DBFieldInfo("F_PODName", "N24"),
                                new DBFieldInfo("F_PODCountry", "N3"),
                                new DBFieldInfo("F_PLODCode", "N30"),
                                new DBFieldInfo("F_PLODName", "N24"),
                                new DBFieldInfo("F_PLODCountry", "N3"),
                                new DBFieldInfo("F_SpecialHandle", "N180"),
                                new DBFieldInfo("F_Reefer", "N1"),
                                new DBFieldInfo("F_Cel", "F"),
                                new DBFieldInfo("F_Fah", "F"),
                                new DBFieldInfo("F_Humidity", "I"),
                                new DBFieldInfo("F_VesselName", "N28"),
                                new DBFieldInfo("F_Lloyds", "N8"),
                                new DBFieldInfo("F_CallSign", "N8"),
                                new DBFieldInfo("F_Voyage", "N10"),
                                new DBFieldInfo("F_Remark", "N600"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_RspDate", "T")
                            }
                        },
                        { "T_CACLAUSE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N30",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_Code", "N4"),
                                new DBFieldInfo("F_Text", "N60"),
                                new DBFieldInfo("F_SeqNo", "I")
                            }
                        },
                        { "T_CACNTR",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N30",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_ReqType", "N1"),
                                new DBFieldInfo("F_FSType", "N5"),
                                new DBFieldInfo("F_ISOType", "N4"),
                                new DBFieldInfo("F_Qty", "I"),
                                new DBFieldInfo("F_TrafficMode", "N2"),
                                new DBFieldInfo("F_CntrNo", "N15"),
                                new DBFieldInfo("F_SealNo", "N15"),
                                new DBFieldInfo("F_GrossKGS", "F"),
                                new DBFieldInfo("F_GrossLBS", "F"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_CFT", "F"),
                                new DBFieldInfo("F_Reefer", "N1"),
                                new DBFieldInfo("F_MinCel", "F"),
                                new DBFieldInfo("F_MinFah", "F"),
                                new DBFieldInfo("F_MaxCel", "F"),
                                new DBFieldInfo("F_MaxFah", "F"),
                                new DBFieldInfo("F_Humidity", "I"),
                                new DBFieldInfo("F_Airflow", "F"),
                                new DBFieldInfo("F_Vent", "N1"),
                                new DBFieldInfo("F_Pickup", "D")
                            }
                        },
                        { "T_CAHZ",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_LIID", "I",true),
                                new DBFieldInfo("F_UNDGNo", "N10"),
                                new DBFieldInfo("F_IMDGCLass", "N4"),
                                new DBFieldInfo("F_HMPage", "N6"),
                                new DBFieldInfo("F_CFlashPoint", "I"),
                                new DBFieldInfo("F_FFlashPoint", "I"),
                                new DBFieldInfo("F_PackGroup", "N3"),
                                new DBFieldInfo("F_ContactName", "N30"),
                                new DBFieldInfo("F_ContactPhone", "N24"),
                                new DBFieldInfo("F_ProperName", "N90"),
                                new DBFieldInfo("F_Placard", "N30"),
                                new DBFieldInfo("F_HMComment", "N480")
                            }
                        },
                        { "T_CALI",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N30",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_GrossKGS", "F"),
                                new DBFieldInfo("F_GrossLBS", "F"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_CFT", "F"),
                                new DBFieldInfo("F_Pkgs", "I"),
                                new DBFieldInfo("F_PUnit", "N3"),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_CommDesc", "N800"),
                                new DBFieldInfo("F_Mark", "N800"),
                                new DBFieldInfo("F_NLength", "F"),
                                new DBFieldInfo("F_CLength", "F"),
                                new DBFieldInfo("F_NWidth", "F"),
                                new DBFieldInfo("F_CWidth", "F"),
                                new DBFieldInfo("F_NHeight", "F"),
                                new DBFieldInfo("F_CHeight", "F"),
                                new DBFieldInfo("F_HBLNo", "N20",true),
                                new DBFieldInfo("F_OHID", "I",true)
                            }
                        },
                        { "T_CAPARTY",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N30",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_Type", "N3",true),
                                new DBFieldInfo("F_Name", "N60"),
                                new DBFieldInfo("F_IDBySndr", "N80"),
                                new DBFieldInfo("F_IDByRcvr", "N80"),
                                new DBFieldInfo("F_Addr1", "N110"),
                                new DBFieldInfo("F_Addr2", "N110"),
                                new DBFieldInfo("F_City", "N30"),
                                new DBFieldInfo("F_State", "N2"),
                                new DBFieldInfo("F_Zip", "N15"),
                                new DBFieldInfo("F_Country", "N3"),
                                new DBFieldInfo("F_LocCode", "N30"),
                                new DBFieldInfo("F_CFunc", "N2"),
                                new DBFieldInfo("F_CName", "N60"),
                                new DBFieldInfo("F_CEM", "N80"),
                                new DBFieldInfo("F_CTE", "N80"),
                                new DBFieldInfo("F_CFX", "N80")
                            }
                        },
                        { "T_CAREF",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N30",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_Code", "N4"),
                                new DBFieldInfo("F_Number", "N30"),
                                new DBFieldInfo("F_SeqNo", "I")
                            }
                        },
                        { "T_CASIREQ",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OOMID", "I",true),
                                new DBFieldInfo("F_SID", "N30",true),
                                new DBFieldInfo("F_Action", "N2"),
                                new DBFieldInfo("F_CallSign", "N8"),
                                new DBFieldInfo("F_LCNo", "N40"),
                                new DBFieldInfo("F_LCIssue", "D"),
                                new DBFieldInfo("F_LCExpire", "D"),
                                new DBFieldInfo("F_CurCountry", "N3"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_BLDate", "D"),
                                new DBFieldInfo("F_SpecialHandle", "N180"),
                                new DBFieldInfo("F_TotalKGS", "F"),
                                new DBFieldInfo("F_TotalLBS", "F"),
                                new DBFieldInfo("F_TotalCBM", "F"),
                                new DBFieldInfo("F_TotalCFT", "F"),
                                new DBFieldInfo("F_BLCopy", "I"),
                                new DBFieldInfo("F_BLOriginal", "I"),
                                new DBFieldInfo("F_SeaWayBill", "I"),
                                new DBFieldInfo("F_DraftBL", "I"),
                                new DBFieldInfo("F_Remark", "N300"),
                                new DBFieldInfo("F_U1ID", "N15"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_Requested", "T"),
                                new DBFieldInfo("F_ContactName", "N60"),
                                new DBFieldInfo("F_ContactEM", "N80"),
                                new DBFieldInfo("F_ContactTE", "N80"),
                                new DBFieldInfo("F_ContactFX", "N80"),
                                new DBFieldInfo("F_HBL", "I"),
                                new DBFieldInfo("F_BLCopy2","I"),
                                new DBFieldInfo("F_BLOriginal2", "I"),
                                new DBFieldInfo("F_SeaWayBill2", "I" ),
                                new DBFieldInfo("F_PLORCode", "N30"),
                                new DBFieldInfo("F_PLORName", "N24"),
                                new DBFieldInfo("F_PLODCode", "N30"),
                                new DBFieldInfo("F_PLODName", "N24"),
                                new DBFieldInfo("F_Status", "N3"),
                                new DBFieldInfo("F_ICControlNo", "N14")
                            }
                        },
                        { "T_CASIRSP",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_SID", "N30",true),
                                new DBFieldInfo("F_Response", "N3"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_RspDate", "T")
                            }
                        },
                        { "T_CFSCHGDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_HDID", "I",true),
                                new DBFieldInfo("F_Destination", "I"),
                                new DBFieldInfo("F_FinalWhse", "I"),
                                new DBFieldInfo("F_Company", "I"),
                                new DBFieldInfo("F_CostRate", "F"),
                                new DBFieldInfo("F_ChargeRate", "F")
                            }
                        },
                        { "T_CFSCHGHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CfsLocation", "I"),
                                new DBFieldInfo("F_EffectDate", "D"),
                                new DBFieldInfo("F_ExpireDate", "D"),
                                new DBFieldInfo("F_RateType", "N1")
                            }
                        },
                        { "T_CODEAIRLINE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Name", "N65"),
                                new DBFieldInfo("F_Country", "N30"),
                                new DBFieldInfo("F_Prefix", "N3",true),
                                new DBFieldInfo("F_Abbr", "N2"),
                                new DBFieldInfo("F_CompanyID", "I"),
                                new DBFieldInfo("F_NextBLNo", "N7"),
                                new DBFieldInfo("F_EndBLNo", "N7"),
                                new DBFieldInfo("F_AccountNo", "N15"),
                                new DBFieldInfo("F_AEFSCRATE", "F"),
                                new DBFieldInfo("F_AESSCRATE", "F"),
                                new DBFieldInfo("F_AEFSCMIN", "F"),
                                new DBFieldInfo("F_AESSCMIN", "F"),
                                new DBFieldInfo("F_Abbr3", "N3")
                            }
                        },
                        { "T_CODEAIRPORT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Code", "N3P"),
                                new DBFieldInfo("F_PortName", "N50"),
                                new DBFieldInfo("F_USCode", "N10")
                            }
                        },
                        { "T_CODEAIRRATE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Customer", "I"),
                                new DBFieldInfo("F_Airline", "I",true),
                                new DBFieldInfo("F_LCODE", "N3"),
                                new DBFieldInfo("F_DCODE", "N3"),
                                new DBFieldInfo("F_MIN", "F"),
                                new DBFieldInfo("F_UNDER45", "F"),
                                new DBFieldInfo("F_OVER45", "F"),
                                new DBFieldInfo("F_OVER100", "F"),
                                new DBFieldInfo("F_OVER300", "F"),
                                new DBFieldInfo("F_OVER500", "F"),
                                new DBFieldInfo("F_OVER1000", "F")
                            }
                        },
                        { "T_CODEANTITLE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ANTitle", "N100P"),
                                new DBFieldInfo("F_ANTitle1", "N1"),
                                new DBFieldInfo("F_ANTitle2", "N1"),
                                new DBFieldInfo("F_ANTitle3", "N1"),
                                new DBFieldInfo("F_ANTitle4", "N1"),
                                new DBFieldInfo("F_ANTitle5", "N1")
                            }
                        },
                        { "T_CODEBANK",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_BankName", "N30"),
                                new DBFieldInfo("F_GLNo", "N10"),
                                new DBFieldInfo("F_BankAcc", "N15"),
                                new DBFieldInfo("F_StDate", "D"),
                                new DBFieldInfo("F_BankBal", "F"),
                                new DBFieldInfo("F_BendDate", "D"),
                                new DBFieldInfo("F_BendBal", "F"),
                                new DBFieldInfo("F_BendBook", "F"),
                                new DBFieldInfo("F_Bank", "N1"),
                                new DBFieldInfo("F_NextCheckNo", "N10"),
                                new DBFieldInfo("F_EndCheckNo", "N10"),
                                new DBFieldInfo("F_CheckForm", "N20"),
                                new DBFieldInfo("F_PLANGUAGE", "N10"),
                                new DBFieldInfo("F_EDIType", "N10"),
                                new DBFieldInfo("F_EdiDateFormat", "N20"),
                                new DBFieldInfo("F_EDIChkCondi", "N20"),
                                new DBFieldInfo("F_RGLNO", "N10"),
                                new DBFieldInfo("F_PGLNO", "N10"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_PEDI_TYPE", "N10"),
                                new DBFieldInfo("F_PEDI_ID", "N20"),
                                new DBFieldInfo("F_InActDate", "D"),
                                new DBFieldInfo("F_NoListBank", "N1"),
                                new DBFieldInfo("F_EDIDateColumn", "I"),
                                new DBFieldInfo("F_EDIAmtColumn", "I"),
                                new DBFieldInfo("F_EDIChkNegative", "N1"),
                                new DBFieldInfo("F_EDIStartRow", "I"),
                                new DBFieldInfo("F_EDIChkNoColumn", "I"),
                                new DBFieldInfo("F_EDIChkCondiCol", "I"),
                                new DBFieldInfo("F_EDIRemoveZero", "N1"),
                                new DBFieldInfo("F_NoDuplicate", "N1"),
                                new DBFieldInfo("F_DefaultBank", "N1"),
                                new DBFieldInfo("F_CURRENCY", "N3"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_CODEBLTYPE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_MBLType", "N30P")
                            }
                        },
                        { "T_CODEBRANCH",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_Name","N50"),
                                new DBFieldInfo("F_Address", "N200"),
                                new DBFieldInfo("F_Phone", "N20"),
                                new DBFieldInfo("F_Fax", "N20"),
                                new DBFieldInfo("F_AreaCode", "N3"),
                                new DBFieldInfo("F_IssuePlace", "N20"),
                                new DBFieldInfo("F_InvoicePrefix", "N10"),
                                new DBFieldInfo("F_InvoiceNo", "N10"),
                                new DBFieldInfo("F_CrDbPrefix", "N10"),
                                new DBFieldInfo("F_CrDbNo", "N10"),
                                new DBFieldInfo("F_OIRefPrefix", "N10"),
                                new DBFieldInfo("F_OIRefNo", "N10"),
                                new DBFieldInfo("F_OORefPrefix", "N10"),
                                new DBFieldInfo("F_OORefNo", "N10"),
                                new DBFieldInfo("F_AIRefPrefix", "N10"),
                                new DBFieldInfo("F_AIRefNo", "N10"),
                                new DBFieldInfo("F_AORefPrefix", "N10"),
                                new DBFieldInfo("F_AORefNo", "N10"),
                                new DBFieldInfo("F_AOHawbPreFix", "N10"),
                                new DBFieldInfo("F_AOHawbNo", "N10"),
                                new DBFieldInfo("F_OOHBLPreFix", "N10"),
                                new DBFieldInfo("F_OOHBLNo", "N10"),
                                new DBFieldInfo("F_OOBookPreFix", "N10"),
                                new DBFieldInfo("F_OOBookNo", "N10"),
                                new DBFieldInfo("F_OOQuotePreFix", "N10"),
                                new DBFieldInfo("F_OOQuoteNo", "N10"),
                                new DBFieldInfo("F_WHRcptPreFix", "N10"),
                                new DBFieldInfo("F_WHRcptNo", "N10"),
                                new DBFieldInfo("F_TLoadPreFix", "N10"),
                                new DBFieldInfo("F_TLoadNo", "N10"),
                                new DBFieldInfo("F_IATANo", "N15"),
                                new DBFieldInfo("F_LocalAddress", "U200"),
                                new DBFieldInfo("F_LocalBankInfo", "U200"),
                                new DBFieldInfo("F_BillNo", "N10"),
                                new DBFieldInfo("F_BillPrefix", "N10"),
                                new DBFieldInfo("F_GeneralBillNo", "N10"),
                                new DBFieldInfo("F_GeneralBillPrefix", "N10"),
                                new DBFieldInfo("F_DefaultBranch", "N1"),
                                new DBFieldInfo("F_PayrollPreFix", "N10"),
                                new DBFieldInfo("F_PayrollNo", "N10"),
                                new DBFieldInfo("F_GeneralInvoPrefix", "N10"),
                                new DBFieldInfo("F_GeneralInvoNo", "N10"),
                                new DBFieldInfo("F_StorageInvoPrefix", "N10"),
                                new DBFieldInfo("F_StorageInvoNo", "N10")
                            }
                        },
                        { "T_CODEBRANCHBANK",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_BankID", "I"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_NextCheckNo", "N10"),
                                new DBFieldInfo("F_EndCheckNo", "N10")
                            }
                        },
                        { "T_CODECARGOSTATUS",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Code", "N20"),
                                new DBFieldInfo("F_Description", "N200"),
                            }
                        },
                        { "T_CODECOMMODITY",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Description", "N100")
                            }
                        },
                        { "T_CODECONTAINER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Type", "N10P")
                            }
                        },
                        { "T_CODECOUNTRY",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_CountryName", "N50P"),
                                new DBFieldInfo("F_USCode", "N6U"),
                                new DBFieldInfo("F_ISOCode", "N2U")
                            }
                        },
                        { "T_CODECURRENCY",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CURRENCY", "N10",true),
                                new DBFieldInfo("F_COUNTRY", "N2")
                            }
                        },
                        { "T_CODEDATA",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Name", "N50"),
                                new DBFieldInfo("F_SName", "N50"),
                                new DBFieldInfo("F_Address", "N200"),
                                new DBFieldInfo("F_SAddress", "N50"),
                                new DBFieldInfo("F_Phone", "N20"),
                                new DBFieldInfo("F_Fax", "N20"),
                                new DBFieldInfo("F_URL", "N35"),
                                new DBFieldInfo("F_AreaCode", "N3"),
                                new DBFieldInfo("F_AcmeID", "N10"),
                                new DBFieldInfo("F_IATANo", "N15"),
                                new DBFieldInfo("F_IssuePlace", "N20"),
                                new DBFieldInfo("F_EarningGLNo", "N10"),
                                new DBFieldInfo("F_ARGLNo", "N10"),
                                new DBFieldInfo("F_APGLNo", "N10"),
                                new DBFieldInfo("F_AgentGLNo", "N10"),
                                new DBFieldInfo("F_INVORemarks", "U600"),
                                new DBFieldInfo("F_CRDRRemarks", "N600"),
                                new DBFieldInfo("F_OIANRemarks", "N1000"),
                                new DBFieldInfo("F_AIANRemarks", "N1000"),
                                new DBFieldInfo("F_FMCNo", "N20"),
                                new DBFieldInfo("F_InvoiceNo", "N10"),
                                new DBFieldInfo("F_CrDbNo", "N10"),
                                new DBFieldInfo("F_OIRefPrefix", "N10"),
                                new DBFieldInfo("F_OIRefNo", "N10"),
                                new DBFieldInfo("F_OORefPrefix", "N10"),
                                new DBFieldInfo("F_OORefNo", "N10"),
                                new DBFieldInfo("F_AIRefPrefix", "N10"),
                                new DBFieldInfo("F_AIRefNo", "N10"),
                                new DBFieldInfo("F_AORefPrefix", "N10"),
                                new DBFieldInfo("F_AORefNo", "N10"),
                                new DBFieldInfo("F_CloseDate", "D"),
                                new DBFieldInfo("F_NextITNo", "F"),
                                new DBFieldInfo("F_EndITNo", "F"),
                                new DBFieldInfo("F_Mpword", "N10"),
                                new DBFieldInfo("F_Spword", "N10"),
                                new DBFieldInfo("F_AOHawbPreFix", "N10"),
                                new DBFieldInfo("F_AOHawbNo", "N10"),
                                new DBFieldInfo("F_OOHBLPreFix", "N10"),
                                new DBFieldInfo("F_OOHBLNo", "N10"),
                                new DBFieldInfo("F_MaxUser", "I"),
                                new DBFieldInfo("F_OtherFlag1", "N15"),
                                new DBFieldInfo("F_OtherFlag2", "N15"),
                                new DBFieldInfo("F_OtherFlag3", "N15"),
                                new DBFieldInfo("F_OtherFlag4", "N15"),
                                new DBFieldInfo("F_OtherFlag5", "N15"),
                                new DBFieldInfo("F_HblBodyVsl", "N1"),
                                new DBFieldInfo("F_HblBodyLport", "N1"),
                                new DBFieldInfo("F_HblBodyDesc1", "N40"),
                                new DBFieldInfo("F_HblBodyDesc2", "N20"),
                                new DBFieldInfo("F_AgentRevGLno", "N10"),
                                new DBFieldInfo("F_OohOfrtCode", "N10"),
                                new DBFieldInfo("F_IRSNo", "N20"),
                                new DBFieldInfo("F_IRSType", "N5"),
                                new DBFieldInfo("F_Contact", "N20"),
                                new DBFieldInfo("F_City", "N20"),
                                new DBFieldInfo("F_State", "N2"),
                                new DBFieldInfo("F_ZipCode", "N10"),
                                new DBFieldInfo("F_Country", "N50"),
                                new DBFieldInfo("F_PartyType", "N2"),
                                new DBFieldInfo("F_OOBookPreFix", "N10"),
                                new DBFieldInfo("F_OOBookNo", "N10"),
                                new DBFieldInfo("F_OOQuotePreFix", "N10"),
                                new DBFieldInfo("F_OOQuoteNo", "N10"),
                                new DBFieldInfo("F_AGR1", "I"),
                                new DBFieldInfo("F_AGR2", "I"),
                                new DBFieldInfo("F_AGR3", "I"),
                                new DBFieldInfo("F_HAWBPSize", "I"),
                                new DBFieldInfo("F_EmailSignature", "N2000"),
                                new DBFieldInfo("F_EmailSMTPServer", "N50"),
                                new DBFieldInfo("F_Email", "N100"),
                                new DBFieldInfo("F_FileServer", "N50"),
                                new DBFieldInfo("F_FaxServer", "N50"),
                                new DBFieldInfo("F_OOHBLForm", "N20"),
                                new DBFieldInfo("F_OIHChg", "N50"),
                                new DBFieldInfo("F_AIHChg", "N50"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_International", "N1"),
                                new DBFieldInfo("F_WHRcptPreFix", "N10"),
                                new DBFieldInfo("F_WHRcptNo", "N10"),
                                new DBFieldInfo("F_TLoadPreFix", "N10"),
                                new DBFieldInfo("F_TLoadNo", "N10"),
                                new DBFieldInfo("F_UseFCR", "N1"),
                                new DBFieldInfo("F_AOMChg", "N50"),
                                new DBFieldInfo("F_AOHChg", "N50"),
                                new DBFieldInfo("F_EURRATE", "F"),
                                new DBFieldInfo("F_OIANFontSize", "F"),
                                new DBFieldInfo("F_AIANFontSize", "F"),
                                new DBFieldInfo("F_PaperSize", "N10"),
                                new DBFieldInfo("F_InvoiceFontSize", "F"),
                                new DBFieldInfo("F_CRDRFontSize", "F"),
                                new DBFieldInfo("F_LocalStmtFontSize", "F"),
                                new DBFieldInfo("F_AgentStmtFontSize", "F"),
                                new DBFieldInfo("F_LocalStmtRemarks", "U600"),
                                new DBFieldInfo("F_AgentStmtRemarks", "N600"),
                                new DBFieldInfo("F_CheckForm", "N20"),
                                new DBFieldInfo("F_InvoicePrefix", "N10"),
                                new DBFieldInfo("F_CrDbPrefix", "N10"),
                                new DBFieldInfo("F_PODORemarks", "N2000"),
                                new DBFieldInfo("F_PODOFontSize", "F"),
                                new DBFieldInfo("F_OIHFrtChg", "N50"),
                                new DBFieldInfo("F_MultipleName", "N1"),
                                new DBFieldInfo("F_COMID1", "I"),
                                new DBFieldInfo("F_COMID2", "I"),
                                new DBFieldInfo("F_COMID3", "I"),
                                new DBFieldInfo("F_COMID4", "I"),
                                new DBFieldInfo("F_COMID5", "I"),
                                new DBFieldInfo("F_OOHBLCopyForm", "N20"),
                                new DBFieldInfo("F_HEADTYPE", "N1"),
                                new DBFieldInfo("F_NotifyLoc", "N1"),
                                new DBFieldInfo("F_UseBranch", "N1"),
                                new DBFieldInfo("F_LabelForm", "N20"),
                                new DBFieldInfo("F_OIMFrtChg", "N50"),
                                new DBFieldInfo("F_FCOUNTRY", "N20"),
                                new DBFieldInfo("F_OOHBOOKREMARK", "N1000"),
                                new DBFieldInfo("F_CheckPrintDate", "D"),
                                new DBFieldInfo("F_LocalAddress", "U100"),
                                new DBFieldInfo("F_BLRemarks", "U600"),
                                new DBFieldInfo("F_EDISenderID", "N20"),
                                new DBFieldInfo("F_PayrollPreFix", "N10"),
                                new DBFieldInfo("F_PayrollNo", "N10"),
                                new DBFieldInfo("F_BillNo", "N10"),
                                new DBFieldInfo("F_BillPrefix", "N10"),
                                new DBFieldInfo("F_GeneralBillNo", "N10"),
                                new DBFieldInfo("F_GeneralBillPrefix", "N10"),
                                new DBFieldInfo("F_GeneralInvoPrefix", "N10"),
                                new DBFieldInfo("F_GeneralInvoNo", "N10"),
                                new DBFieldInfo("F_StorageInvoPrefix", "N10"),
                                new DBFieldInfo("F_StorageInvoNo", "N10")

                            }
                        },
                        { "T_CODEEIC",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Code", "N2P"),
                                new DBFieldInfo("F_Description", "N1000")
                            }
                        },
                        { "T_CODEGLNO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_GLNo", "N10",true),
                                new DBFieldInfo("F_GLType", "N2",true),
                                new DBFieldInfo("F_GLGroup", "N2",true),
                                new DBFieldInfo("F_GLSubGroup", "N25"),
                                new DBFieldInfo("F_GLDescription", "N100"),
                                new DBFieldInfo("F_LocalDesc", "U100"),
                                new DBFieldInfo("F_Inactive", "N1"),
                                new DBFieldInfo("F_CashFlowType", "N2"),
                                new DBFieldInfo("F_CashFlowGroup", "N50"),
                                new DBFieldInfo("F_Remark", "N300"),
                                new DBFieldInfo("F_InactiveDate", "D")
                            }
                        },
                        { "T_CODEGROUP",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_GroupID", "N10P"),
                                new DBFieldInfo("F_GroupName", "N30")
                            }
                        },
                        { "T_CODELIC",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Code", "N3P"),
                                new DBFieldInfo("F_Description", "N1000")
                            }
                        },
                        { "T_CODELINE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Code", "N5"),
                                new DBFieldInfo("F_Point1", "N20"),
                                new DBFieldInfo("F_Point2", "N20"),
                                new DBFieldInfo("F_Desc", "N50"),
                                new DBFieldInfo("F_LocalDesc", "U50"),
                                new DBFieldInfo("F_Division", "N2"),
                                new DBFieldInfo("F_InActive", "N1")
                            }
                        },
                        { "T_CODEMOVETYPE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_MoveType", "N15"),
                                new DBFieldInfo("F_InActive", "N1")
                            }
                        },
                        { "T_CODEOCEANPORT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Code", "N10",true),
                                new DBFieldInfo("F_PortName", "N50"),
                                new DBFieldInfo("F_CFS", "I"),
                                new DBFieldInfo("F_CY", "I"),
                                new DBFieldInfo("F_UNLOC", "N5"),
                                new DBFieldInfo("F_PortSearchName", "N50",true)
                            }
                        },
                        { "T_CODEOCEANUNPORT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_UNCode", "N5",true),
                                new DBFieldInfo("F_UNPortName", "N100",true),
                                new DBFieldInfo("F_UNCOUNTRY", "N2"),
                                new DBFieldInfo("F_UNCityName", "N50"),
                                new DBFieldInfo("F_SUBDIV", "N5"),
                                new DBFieldInfo("F_USCODE", "N10",true)
                            }
                        },
                        { "T_CODEOTHERTYPE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Type", "N10P"),
                                new DBFieldInfo("F_Description", "N30"),
                                new DBFieldInfo("F_OtherPrefix", "N10"),
                                new DBFieldInfo("F_OtherNo", "N10")
                            }
                        },
                        { "T_CODEPKG",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Desc", "N120"),
                                new DBFieldInfo("F_X12", "N5"),
                                new DBFieldInfo("F_Edifact", "N5")
                            }
                        },
                        { "T_CODESCAC",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Code", "N4",true),
                                new DBFieldInfo("F_CarrierName", "N60"),
                                new DBFieldInfo("F_CompanyID", "I")
                            }
                        },
                        { "T_CODESCHDB",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Code", "N12P"),
                                new DBFieldInfo("F_LDescription", "N150"),
                                new DBFieldInfo("F_SDescription", "N50"),
                                new DBFieldInfo("F_Unit1", "N3"),
                                new DBFieldInfo("F_Unit2", "N3")
                            }
                        },
                        { "T_CODESMAN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_SManID", "N10P"),
                                new DBFieldInfo("F_SManName", "N30"),
                                new DBFieldInfo("F_SManGroup", "N10")
                            }
                        },
                        { "T_CODESTATE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Code", "N2P"),
                                new DBFieldInfo("F_StateName", "N30"),
                                new DBFieldInfo("F_Country", "N2P")
                            }
                        },
                        { "T_CODEVESSEL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_VesselName", "N50P"),
                                new DBFieldInfo("F_Country", "N2"),
                                new DBFieldInfo("F_VesselFlag", "N2Q"),
                                new DBFieldInfo("F_LLOYDS", "N7",true),
                                new DBFieldInfo("F_VGroup", "N7",true)
                            }
                        },
                        { "T_COMPANY",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_FFBMSID", "I"),
                                new DBFieldInfo("F_SName", "N50",true),
                                new DBFieldInfo("F_FName", "N100"),
                                new DBFieldInfo("F_Addr", "N200"),
                                new DBFieldInfo("F_City", "N20"),
                                new DBFieldInfo("F_State", "N2"),
                                new DBFieldInfo("F_ZipCode", "N10"),
                                new DBFieldInfo("F_Country", "N50"),
                                new DBFieldInfo("F_SManID", "N10"),
                                new DBFieldInfo("F_CreditLimit", "F"),
                                new DBFieldInfo("F_Terms", "I"),
                                new DBFieldInfo("F_IRSNo", "N20"),
                                new DBFieldInfo("F_IRSType", "N1"),
                                new DBFieldInfo("F_OIHChg", "F"),
                                new DBFieldInfo("F_AIHChg", "F"),
                                new DBFieldInfo("F_InActive", "N1"),
                                new DBFieldInfo("F_CreditHold", "N1"),
                                new DBFieldInfo("F_OtherFlag1", "N1"),
                                new DBFieldInfo("F_OtherFlag2", "N1"),
                                new DBFieldInfo("F_OtherFlag3", "N1"),
                                new DBFieldInfo("F_OtherFlag4", "N1"),
                                new DBFieldInfo("F_OtherFlag5", "N1"),
                                new DBFieldInfo("F_BondNo", "N50"),
                                new DBFieldInfo("F_IATANo", "N50"),
                                new DBFieldInfo("F_AccountNo", "N50"),
                                new DBFieldInfo("F_OIRefPrefix", "N10"),
                                new DBFieldInfo("F_OIRefNo", "N10"),
                                new DBFieldInfo("F_OORefPrefix", "N10"),
                                new DBFieldInfo("F_OORefNo", "N10"),
                                new DBFieldInfo("F_AIRefPrefix", "N10"),
                                new DBFieldInfo("F_AIRefNo", "N10"),
                                new DBFieldInfo("F_AORefPrefix", "N10"),
                                new DBFieldInfo("F_AORefNo", "N10"),
                                new DBFieldInfo("F_AOHawbPreFix", "N10"),
                                new DBFieldInfo("F_AOHawbNo", "N10"),
                                new DBFieldInfo("F_OOHBLPreFix", "N10"),
                                new DBFieldInfo("F_OOHBLNo", "N10"),
                                new DBFieldInfo("F_WHRcptPreFix", "N10"),
                                new DBFieldInfo("F_WHRcptNo", "N10"),
                                new DBFieldInfo("F_SchdbNo", "N12"),
                                new DBFieldInfo("F_DELFName", "N50"),
                                new DBFieldInfo("F_DELAddr", "N200"),
                                new DBFieldInfo("F_DELCity", "N20"),
                                new DBFieldInfo("F_DELState", "N2"),
                                new DBFieldInfo("F_DELZipCode", "N10"),
                                new DBFieldInfo("F_DELCountry", "N50"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_LocalName", "U100"),
                                new DBFieldInfo("F_LocalAddr", "U200"),
                                new DBFieldInfo("F_PIMSID", "I",true),
                                new DBFieldInfo("F_PIMSTYPE", "N10"),
                                new DBFieldInfo("F_PIMSRPARTY", "I"),
                                new DBFieldInfo("F_PIMSCNTRY", "N2"),
                                new DBFieldInfo("F_ALLOWEMAIL", "N1"),
                                new DBFieldInfo("F_Saddr", "N200"),
                                new DBFieldInfo("F_Scity", "N20"),
                                new DBFieldInfo("F_Sstate", "N2"),
                                new DBFieldInfo("F_SzipCode", "N10"),
                                new DBFieldInfo("F_SCountry", "N50"),
                                new DBFieldInfo("F_POA", "N1"),
                                new DBFieldInfo("F_POAExpire", "D"),
                                new DBFieldInfo("F_POAMemo", "N20"),
                                new DBFieldInfo("F_PassportCntry", "N2"),
                                new DBFieldInfo("F_PassportDOB", "D"),
                                new DBFieldInfo("F_BondActivity", "N2"),
                                new DBFieldInfo("F_BondType", "N1"),
                                new DBFieldInfo("F_EDIBrokerID", "N20")
                            }
                        },
                        { "T_COMPANYBROKER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CompanyID", "I",true),
                                new DBFieldInfo("F_BrokerID", "I",true),
                                new DBFieldInfo("F_BrokerName", "N50"),
                                new DBFieldInfo("F_BrokerAddress", "N200"),
                                new DBFieldInfo("F_Destination", "N20"),
                                new DBFieldInfo("F_Contact", "N20"),
                                new DBFieldInfo("F_Phone", "N20"),
                                new DBFieldInfo("F_Fax", "N20"),
                                new DBFieldInfo("F_EMail", "N100")
                            }
                        },
                        { "T_COMPANYCONTACT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CompanyID", "I",true),
                                new DBFieldInfo("F_Contact", "N50",true),
                                new DBFieldInfo("F_Dept", "N10"),
                                new DBFieldInfo("F_Phone", "N30",true),
                                new DBFieldInfo("F_Fax", "N30",true),
                                new DBFieldInfo("F_EMail", "N100",true),
                                new DBFieldInfo("F_Primary", "N1"),
                                new DBFieldInfo("F_EVENT", "N1")
                            }
                        },
                        { "T_COMPANYGROUP",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_CompanyID", "IP"),
                                new DBFieldInfo("F_GroupID", "N10P")
                            }
                        },
                        { "T_ConfirmCRDB",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_AgentId", "I",true),
                                new DBFieldInfo("F_Title", "N50"),
                                new DBFieldInfo("F_Date", "D"),
                                new DBFieldInfo("F_ConfirmDate", "D")
                            }
                        },
                        { "T_CONTAINERGROUP",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Type", "N10"),
                                new DBFieldInfo("F_Order", "I")
                            }
                        },
                        { "T_CORRDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_CORRHDID", "I",true),
                                new DBFieldInfo("F_ITEM", "N50"),
                                new DBFieldInfo("F_Before", "N100"),
                                new DBFieldInfo("F_After", "N100")
                            }
                        },
                        { "T_CORRHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_memoType", "N1",true),
                                new DBFieldInfo("F_REMARK", "N3500"),
                                new DBFieldInfo("F_TITLE", "N20"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_CORRDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_CORRHDID", "I",true),
                                new DBFieldInfo("F_ITEM", "N50"),
                                new DBFieldInfo("F_Before", "N100"),
                                new DBFieldInfo("F_After", "N100")
                            }
                        },
                        { "T_CRDBHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_Agent", "I",true),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_Settled", "N1"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_CrDbNo", "N30",true),
                                new DBFieldInfo("F_InvoiceDate", "D",true),
                                new DBFieldInfo("F_Terms", "I"),
                                new DBFieldInfo("F_DueDate", "D"),
                                new DBFieldInfo("F_Total", "F"),
                                new DBFieldInfo("F_PaidAmt", "F"),
                                new DBFieldInfo("F_CheckNo", "N35"),
                                new DBFieldInfo("F_PaidDate", "D"),
                                new DBFieldInfo("F_ProfitShare", "F"),
                                new DBFieldInfo("F_NotShow", "N1"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_MultiNameID", "I"),
                                new DBFieldInfo("F_YourRef", "N40"),
                                new DBFieldInfo("F_Remarks", "N100"),
                                new DBFieldInfo("F_Exrate", "F"),
                                new DBFieldInfo("F_PRINTED", "N1"),
                                new DBFieldInfo("F_RCOUNT", "I"),
                                new DBFieldInfo("F_UseLocalLanguage", "I"),
                                new DBFieldInfo("F_DutyAmt", "F"),
                                new DBFieldInfo("F_DutyPaidAmt", "F"),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_OriginId", "I"),
                                new DBFieldInfo("F_ConfirmId", "I",true),
                                new DBFieldInfo("F_IsConfirmedCheck", "I")
                            }
                        },
                        { "T_CREDITCARD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CCEntity", "I"),
                                new DBFieldInfo("F_AcctSName", "N50"),
                                new DBFieldInfo("F_CardType", "N20"),
                                new DBFieldInfo("F_CardNumber", "N20"),
                                new DBFieldInfo("F_Expiry", "N10"),
                                new DBFieldInfo("F_NameOnCard", "N50"),
                                new DBFieldInfo("F_PaymentDate", "N5"),
                                new DBFieldInfo("F_DefaultCard", "N1"),
                                new DBFieldInfo("F_Inactive", "N1"),
                                new DBFieldInfo("F_InactiveDate", "D"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_CCPrefix", "N10"),
                                new DBFieldInfo("F_CCRefNo", "N10")
                            }
                        },
                        #endregion
                        #region:D
                        { "T_DEPODETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_DEPOHDID", "I",true),
                                new DBFieldInfo("F_TBName", "N10",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_GLno", "N10"),
                                new DBFieldInfo("F_Description", "U50"),
                                new DBFieldInfo("F_Seq", "i"),
                                new DBFieldInfo("F_Branch", "N3"),
                                new DBFieldInfo("F_OthInvNo", "N20"),
                                new DBFieldInfo("F_ExrateO", "F"),
                                new DBFieldInfo("F_LAmount", "F"),
                                new DBFieldInfo("F_OAmount", "F"),
                                new DBFieldInfo("F_PayType", "N2"),
                                new DBFieldInfo("F_BadARExpenseId", "I")
                            }
                        },
                        { "T_DEPOHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_BillTo", "I",true),
                                new DBFieldInfo("F_PaidTo", "I"),
                                new DBFieldInfo("F_ReceivedFrom", "N50"),
                                new DBFieldInfo("F_DepositBank", "I"),
                                new DBFieldInfo("F_DepositDate", "D"),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_CheckNo", "N35"),
                                new DBFieldInfo("F_Remark", "U200"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_Void", "N1"),
                                new DBFieldInfo("F_VoidDate", "D"),
                                new DBFieldInfo("F_Type", "N1"),
                                new DBFieldInfo("F_Block", "N1"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_ChkPrint", "N1"),
                                new DBFieldInfo("F_ChkPrtID", "N10"),
                                new DBFieldInfo("F_ChkPrtDate", "D"),
                                new DBFieldInfo("F_Exrate", "F"),
                                new DBFieldInfo("F_ETF", "N1"),
                                new DBFieldInfo("F_VoidinPutDate", "D"),
                                new DBFieldInfo("F_DepositinPutDate", "D"),
                                new DBFieldInfo("F_VoidinPutID", "N10"),
                                new DBFieldInfo("F_DepositinPutID", "N10"),
                                new DBFieldInfo("F_ClearActionDate", "D"),
                                new DBFieldInfo("F_ClearActionID", "N10"),
                                new DBFieldInfo("F_IssueDate", "D"),
                                new DBFieldInfo("F_DepositBankDate", "D"),
                                new DBFieldInfo("F_IsAgentPayment", "I"),
                                new DBFieldInfo("F_ConfirmedCrDbId", "I",true),
                                new DBFieldInfo("F_ExrateBank", "F"),
                                new DBFieldInfo("F_CCRefNo", "N20"),
                                new DBFieldInfo("F_CCStatus", "I"),
                                new DBFieldInfo("F_CreditCardId", "I",true),
                                new DBFieldInfo("F_CCAmt", "F"),
                                new DBFieldInfo("F_PaidAmt" ,"F"),
                                new DBFieldInfo("F_BadDebtExp", "N1"),
                                new DBFieldInfo("F_IsDraft", "N1")
                            }
                        },
                        { "T_DOCATTACH",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_DocDTID", "I",true),
                                new DBFieldInfo("F_AttachType", "I"),
                                new DBFieldInfo("F_LogFileID", "I",true)
                            }
                        },
                        { "T_DOCComments",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_DocLinkID", "I",true),
                                new DBFieldInfo("F_DocLinkType", "I"),
                                new DBFieldInfo("F_CType", "I"),
                                new DBFieldInfo("F_CSubject", "U100"),
                                new DBFieldInfo("F_CMemo", "U3800"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_DOCDT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_DocHDID", "I",true),
                                new DBFieldInfo("F_Subject", "U100",true),
                                new DBFieldInfo("F_EditingBy", "N10"),
                                new DBFieldInfo("F_EditingDateTime", "D"),
                                new DBFieldInfo("F_LastSent", "I"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_DOCHD",
                                new List<DBFieldInfo>
                                {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Subject", "U100",true),
                                new DBFieldInfo("F_AssignedUserID", "N10"),
                                new DBFieldInfo("F_DefaultToID", "I",true),
                                new DBFieldInfo("F_ConfirmedBy", "N10"),
                                new DBFieldInfo("F_ConfirmedDateTime", "D"),
                                new DBFieldInfo("F_SentBy", "N10"),
                                new DBFieldInfo("F_SentType","I"),
                                new DBFieldInfo("F_SentDateTime", "D"),
                                new DBFieldInfo("F_Status", "I"),
                                new DBFieldInfo("F_DocLevel", "I"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                                    }
                        },
                        { "T_DOCMEMO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_DocDTID", "I",true),
                                new DBFieldInfo("F_MemoType", "I"),
                                new DBFieldInfo("F_SeqNo", "I",true),
                                new DBFieldInfo("F_Memo", "U3800")
                            }
                        },
                        { "T_DOCTO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_DocHDID", "I",true),
                                new DBFieldInfo("F_ContactID", "I",true),
                                new DBFieldInfo("F_ContactName", "U50"),
                                new DBFieldInfo("F_ContactCompanyID", "I",true),
                                new DBFieldInfo("F_ContactCompanyName", "U50"),
                                new DBFieldInfo("F_ContactCompanyAddress", "U150"),
                                new DBFieldInfo("F_Email", "N100"),
                                new DBFieldInfo("F_FaxNumber", "N30"),
                                new DBFieldInfo("F_OtherNumber1", "N50"),
                                new DBFieldInfo("F_OtherNumber2", "N50"),
                                new DBFieldInfo("F_OtherNumber3", "N50"),
                                new DBFieldInfo("F_SendType", "I")
                                }
                        },
                        #endregion
                        #region:E
                        { "T_eAIHMAIN",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_eAIMMAIN",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_EDIACDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_EDIHDID", "I",true),
                                new DBFieldInfo("F_SEQNo", "I"),
                                new DBFieldInfo("F_Code" , "N30"),
                                new DBFieldInfo("F_Description", "N100"),
                                new DBFieldInfo("F_AcctNo", "N20"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_ChgType", "I"),
                                new DBFieldInfo("F_Currency", "N3")
                                    }
                        },
                        { "T_EDIACHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_InvoID", "I",true),
                                new DBFieldInfo("F_InvoNo", "N30"),
                                new DBFieldInfo("F_CustID", "I"),
                                new DBFieldInfo("F_CustNo", "N10"),
                                new DBFieldInfo("F_InvoType","N1"),
                                new DBFieldInfo("F_InvoDate", "D"),
                                new DBFieldInfo("F_DueDate", "D"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_LotNo", "N15"),
                                new DBFieldInfo("F_RefNo", "N15"),
                                new DBFieldInfo("F_Terms", "N2"),
                                new DBFieldInfo("F_CompanyNo", "N2"),
                                new DBFieldInfo("F_CompanyBranch", "N2"),
                                new DBFieldInfo("F_InvoPostDate", "D"),
                                new DBFieldInfo("F_PostDate" , "D"),
                                new DBFieldInfo("F_PostID" , "N10"),
                                new DBFieldInfo("F_EdiDate", "D",true),
                                new DBFieldInfo("F_EdiID" , "N10"),
                                new DBFieldInfo("F_Currency", "N3")
                            }
                        },
                        { "T_EDIREQUEST",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TYPE", "N30"),
                                new DBFieldInfo("F_SENDERID", "N250"),
                                new DBFieldInfo("F_RECEIVERID", "N250"),
                                new DBFieldInfo("F_REQUESTDATE", "D"),
                                new DBFieldInfo("F_LASTEDITDATE", "D"),
                                new DBFieldInfo("F_USERID", "N15"),
                                new DBFieldInfo("F_STATUS", "N3"),
                                new DBFieldInfo("F_SUBIDS", "N100"),
                                new DBFieldInfo("F_DATAID", "INT")
                            }
                        },
                        { "T_eOIHCONTAINER",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_eOIHMAIN",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_eOIHPONO",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_eOIMCONTAINER",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_eOIMMAIN",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_eOPACCT",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_EXCHANGERATE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_RATE", "F"),
                                new DBFieldInfo("F_EXCHAGEDATE", "D",true),
                                new DBFieldInfo("F_Currency", "N3",true)
                            }
                        },
                        #endregion
                        #region: G ,I
                        { "T_GENCONTAINER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_GENMAINID", "I",true),
                                new DBFieldInfo("F_ContainerNo", "N11"),
                                new DBFieldInfo("F_ConType", "N10"),
                                new DBFieldInfo("F_SealNo", "N20"),
                                new DBFieldInfo("F_PKGS", "I")
                            }
                        },
                        { "T_GENMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Type", "N10",true),
                                new DBFieldInfo("F_RefNo", "N20",true),
                                new DBFieldInfo("F_Mblno", "N20",true),
                                new DBFieldInfo("F_Hblno", "N20",true),
                                new DBFieldInfo("F_Customer", "I",true),
                                new DBFieldInfo("F_CustRefNo", "N30",true),
                                new DBFieldInfo("F_ETA", "D"),
                                new DBFieldInfo("F_ETD", "D"),
                                new DBFieldInfo("F_Vessel", "N25"),
                                new DBFieldInfo("F_SmanID", "N10"),
                                new DBFieldInfo("F_USLCode", "N5"),
                                new DBFieldInfo("F_LoadingPort", "N50"),
                                new DBFieldInfo("F_USDCode", "N5"),
                                new DBFieldInfo("F_DisCharge", "N50"),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_USFCode", "N5"),
                                new DBFieldInfo("F_FinalDest", "N25"),
                                new DBFieldInfo("F_FETA", "D"),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_Pkgs", "F"),
                                new DBFieldInfo("F_Punit", "N10"),
                                new DBFieldInfo("F_Kgs", "F"),
                                new DBFieldInfo("F_Lbs", "F"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_IMemo", "N1000"),
                                new DBFieldInfo("F_PMemo", "N1000"),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_CUR1", "N3"),
                                new DBFieldInfo("F_CUR2", "N3"),
                                new DBFieldInfo("F_Exrate1", "F"),
                                new DBFieldInfo("F_Exrate2", "F"),
                                new DBFieldInfo("F_UNLcode", "N5"),
                                new DBFieldInfo("F_UNDcode", "N5"),
                                new DBFieldInfo("F_UNFcode", "N5"),
                                new DBFieldInfo("F_CompleteBill", "N1"),
                                new DBFieldInfo("F_CompleteInvo", "N1"),
                                new DBFieldInfo("F_CompleteCrDb", "N1"),
                                new DBFieldInfo("F_Shipper", "N50"),
                                new DBFieldInfo("F_Consignee", "N50"),
                                new DBFieldInfo("F_ContainerInfo", "N50"),
                                new DBFieldInfo("F_Location", "N50"),
                                new DBFieldInfo("F_ProfitShare", "F"),
                                new DBFieldInfo("F_Agent", "I"),
                                new DBFieldInfo("F_ConfirmDate", "D",true),
                                new DBFieldInfo("F_ConfirmedBy", "N10"),
                                new DBFieldInfo("F_ShipmentType", "N1"),
                                new DBFieldInfo("F_DutyCustomer", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3"),
                                new DBFieldInfo("F_StatusCrDb", "N3"),
                                new DBFieldInfo("F_ConfirmActionDate", "D"),
                                new DBFieldInfo("F_CloseDate", "D")
                            }
                        },
                        { "T_GL_SUBCODEJ",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID","I"),
                                new DBFieldInfo("F_Code", "N20",true),
                                new DBFieldInfo("F_Desc", "N100")
                            }
                        },
                        { "T_IFTMAN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID","I"),
                                new DBFieldInfo("F_TBName","N50",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_Action", "N1"),
                                new DBFieldInfo("F_Sender","N50"),
                                new DBFieldInfo("F_Receiver", "N50"),
                                new DBFieldInfo("F_CustomerCode","N50"),
                                new DBFieldInfo("F_ShowCharge","N1"),
                                new DBFieldInfo("F_Status","N3"),
                                new DBFieldInfo("F_U1ID","N20"),
                                new DBFieldInfo("F_U1Date","T"),
                                new DBFieldInfo("F_Requested","T"),
                                new DBFieldInfo("F_ICControlNo","N14")
                            }
                        },
                        { "T_INITCLIENT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_MacID", "N20",true),
                                new DBFieldInfo("F_ServerName", "N50"),
                                new DBFieldInfo("F_FileServer", "N25"),
                                new DBFieldInfo("F_FaxServer", "N25"),
                                new DBFieldInfo("F_PrintAwbM", "N50"),
                                new DBFieldInfo("F_PrintFontAwbM", "N50"),
                                new DBFieldInfo("F_PrintAwbH", "N50"),
                                new DBFieldInfo("F_PrintFontAwbH", "N50"),
                                new DBFieldInfo("F_PrintOceanBL", "N50"),
                                new DBFieldInfo("F_PrintFontOceanBL", "N50"),
                                new DBFieldInfo("F_PrintCheck", "N50"),
                                new DBFieldInfo("F_PrintFontCheck", "N50"),
                                new DBFieldInfo("F_PrintIT", "N50"),
                                new DBFieldInfo("F_PrintFontIT", "N50"),
                                new DBFieldInfo("F_PrintDO", "N50"),
                                new DBFieldInfo("F_PrintFontDO", "N50"),
                                new DBFieldInfo("F_PrintLabel", "N50"),
                                new DBFieldInfo("F_PrintFontLabel", "N50"),
                                new DBFieldInfo("F_PrintFolderLabel", "N50"),
                                new DBFieldInfo("F_PrintFontFolderLabel", "N50"),
                                new DBFieldInfo("F_PrintBankDraft", "N50"),
                                new DBFieldInfo("F_PrintFontBankDraft", "N50"),
                                new DBFieldInfo("F_PrintAirLabel", "N50"),
                                new DBFieldInfo("F_PrintFontAirLabel", "N50"),
                                new DBFieldInfo("F_PrintHawaiiBL", "N50"),
                                new DBFieldInfo("F_PrintFontHawaiiBL", "N50"),
                                new DBFieldInfo("F_PrintExtra1", "N50"),
                                new DBFieldInfo("F_PrintFontExtra1", "N50"),
                                new DBFieldInfo("F_PrintExtra2", "N50"),
                                new DBFieldInfo("F_PrintFontExtra2", "N50"),
                                new DBFieldInfo("F_PrintExtra3", "N50"),
                                new DBFieldInfo("F_PrintFontExtra3", "N50"),
                                new DBFieldInfo("F_PrintExtra4", "N50"),
                                new DBFieldInfo("F_PrintFontExtra4", "N50"),
                                new DBFieldInfo("F_PrintExtra5", "N50"),
                                new DBFieldInfo("F_PrintFontExtra5", "N50")
                            }
                        },
                        { "T_INVENDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_INVENHDID", "I",true),
                                new DBFieldInfo("F_Length", "F"),
                                new DBFieldInfo("F_Width", "F"),
                                new DBFieldInfo("F_Height", "F"),
                                new DBFieldInfo("F_PCS", "I"),
                                new DBFieldInfo("F_Unit", "N10"),
                                new DBFieldInfo("F_DimKGS", "F"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_AWeight", "F"),
                                new DBFieldInfo("F_Shipped", "N1"),
                                new DBFieldInfo("F_Mode", "N1"),
                                new DBFieldInfo("F_ShippedDate", "D"),
                                new DBFieldInfo("F_BLNo", "N20"),
                                new DBFieldInfo("F_TBName", "N20"),
                                new DBFieldInfo("F_TBID", "I"),
                                new DBFieldInfo("F_Seq", "I")
                            }
                        },
                        { "T_INVENHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_RefNo", "N20",true),
                                new DBFieldInfo("F_ReceivedDate", "T"),
                                new DBFieldInfo("F_ReceivedBy", "N10"),
                                new DBFieldInfo("F_TruckBLNo", "N20"),
                                new DBFieldInfo("F_DCarrier", "N25"),
                                new DBFieldInfo("F_DeliveredBy", "N10"),
                                new DBFieldInfo("F_Location", "N30"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_CheckNo", "N35"),
                                new DBFieldInfo("F_Maker", "N25"),
                                new DBFieldInfo("F_Shipper", "I"),
                                new DBFieldInfo("F_PONo", "N20"),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_HazGoods", "N1"),
                                new DBFieldInfo("F_Remark", "N1000"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_Consignee", "I"),
                                new DBFieldInfo("F_POL", "N20"),
                                new DBFieldInfo("F_POD", "N20"),
                                new DBFieldInfo("F_BookNo", "N20"),
                                new DBFieldInfo("F_Marking", "N20"),
                                new DBFieldInfo("F_IPIWRNo", "N20"),
                                new DBFieldInfo("F_PRONO", "N20"),
                                new DBFieldInfo("F_ReturnCargo", "N1"),
                                new DBFieldInfo("F_IE", "N1"),
                                new DBFieldInfo("F_LC", "N1"),
                                new DBFieldInfo("F_SignDate", "D")
                            }
                        },
                        { "T_INVODETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_INVOHDID", "I",true),
                                new DBFieldInfo("F_STBName", "N20",true),
                                new DBFieldInfo("F_STBID", "I",true),
                                new DBFieldInfo("F_BillingCode", "N30",true),
                                new DBFieldInfo("F_Description", "L100"),
                                new DBFieldInfo("F_Rate", "F"),
                                new DBFieldInfo("F_Qty", "F"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_Cur", "N3"),
                                new DBFieldInfo("F_Exrate", "F"),
                                new DBFieldInfo("F_LAmount", "F"),
                                new DBFieldInfo("F_UseVat", "N1"),
                                new DBFieldInfo("F_VatAmount", "F"),
                                new DBFieldInfo("F_AgtAmount", "F"),
                                new DBFieldInfo("F_LAgtAmount", "F"),
                                new DBFieldInfo("F_AgtCur", "N3"),
                                new DBFieldInfo("F_AgtExRate", "F"),
                                new DBFieldInfo("F_VATGLNO", "N10"),
                                new DBFieldInfo("F_CurAmount", "F"),
                                new DBFieldInfo("F_ChgType", "I"),
                                new DBFieldInfo("F_PS", "N1"),
                                new DBFieldInfo("F_DBRANCH", "N3"),
                                new DBFieldInfo("F_Agent", "I")
                            }
                        },
                        { "T_INVOHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_BillTo", "I",true),
                                new DBFieldInfo("F_ShipTo", "I"),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_InvoiceNo", "N30",true),
                                new DBFieldInfo("F_InvoiceDate", "D",true),
                                new DBFieldInfo("F_InvoiceAmt", "F"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_Terms", "I"),
                                new DBFieldInfo("F_DueDate", "D"),
                                new DBFieldInfo("F_PaidAmt", "F"),
                                new DBFieldInfo("F_CheckNo", "N35"),
                                new DBFieldInfo("F_PaidDate", "D"),
                                new DBFieldInfo("F_MultiNameID", "I"),
                                new DBFieldInfo("F_YourRef", "N100"),
                                new DBFieldInfo("F_Cur1", "N3"),
                                new DBFieldInfo("F_Cur2", "N3"),
                                new DBFieldInfo("F_Exrate1", "F"),
                                new DBFieldInfo("F_Exrate2", "F"),
                                new DBFieldInfo("F_TVatAmt", "F"),
                                new DBFieldInfo("F_TLAmount", "F"),
                                new DBFieldInfo("F_RCVGLNO", "N10"),
                                new DBFieldInfo("F_Invoiced", "N1"),
                                new DBFieldInfo("F_Agent", "I"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_Rcount", "I"),
                                new DBFieldInfo("F_UseLocalLanguage", "I"),
                                new DBFieldInfo("F_InvoBranch", "N3",true),
                                new DBFieldInfo("F_JobName", "N20"),
                                new DBFieldInfo("F_UseAdvRec", "I",true),
                                new DBFieldInfo("F_AdvRecAmount", "F"),
                                new DBFieldInfo("F_DutyAmt", "F"),
                                new DBFieldInfo("F_DutyLAmt", "F"),
                                new DBFieldInfo("F_DutyPaidAmt", "F"),
                                new DBFieldInfo("F_DutyEntiTy", "I"),
                                new DBFieldInfo("F_Void", "I" ),
                                new DBFieldInfo("F_OriginInvId", "I"),
                                new DBFieldInfo("F_IsCredit", "I"),
                                new DBFieldInfo("F_CreditAPHDId", "I"),
                                new DBFieldInfo("F_Branch", "N3")
                            }
                        },
                        #endregion
                        #region : M,N
                        { "T_MEMO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_memoType", "N1",true),
                                new DBFieldInfo("F_Title", "U50",true),
                                new DBFieldInfo("F_Contents", "U3500"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_PimsLinkID", "I")
                            }
                        },
                        { "T_MultiDB",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_BranchGroup", "N3",true),
                                new DBFieldInfo("F_DBServer", "N70"),
                                new DBFieldInfo("F_DBName", "N50",true),
                                new DBFieldInfo("F_DBID", "N20"),
                                new DBFieldInfo("F_DBPWD", "N20")
                            }
                        },
                        { "T_NCODECHARGE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Code", "N50",true),
                                new DBFieldInfo("F_Description", "L110",true),
                                new DBFieldInfo("F_OI", "N1"),
                                new DBFieldInfo("F_OO", "N1"),
                                new DBFieldInfo("F_AI", "N1"),
                                new DBFieldInfo("F_AO", "N1"),
                                new DBFieldInfo("F_WH", "N1"),
                                new DBFieldInfo("F_OT", "N1"),
                                new DBFieldInfo("F_Sales1", "N10"),
                                new DBFieldInfo("F_Cost1", "N10"),
                                new DBFieldInfo("F_ChgType1", "I"),
                                new DBFieldInfo("F_Sales2", "N10"),
                                new DBFieldInfo("F_Cost2", "N10"),
                                new DBFieldInfo("F_ChgType2", "I"),
                                new DBFieldInfo("F_Sales3", "N10"),
                                new DBFieldInfo("F_Cost3", "N10"),
                                new DBFieldInfo("F_ChgType3", "I"),
                                new DBFieldInfo("F_Sales4", "N10"),
                                new DBFieldInfo("F_Cost4", "N10"),
                                new DBFieldInfo("F_ChgType4", "I"),
                                new DBFieldInfo("F_Sales5", "N10"),
                                new DBFieldInfo("F_Cost5", "N10"),
                                new DBFieldInfo("F_ChgType5", "I"),
                                new DBFieldInfo("F_Sales6", "N10"),
                                new DBFieldInfo("F_Cost6", "N10"),
                                new DBFieldInfo("F_ChgType6", "I"),
                                new DBFieldInfo("F_InActive", "N1"),
                                new DBFieldInfo("F_LocalDesc", "U50"),
                                new DBFieldInfo("F_JobNumber", "I"),
                                new DBFieldInfo("F_REMARK", "N300"),
                                new DBFieldInfo("F_UseSuntek", "N1"),
                                new DBFieldInfo("F_IsUseInInvoice", "N1"),
                                new DBFieldInfo("F_IsUseInBill", "N1"),
                                new DBFieldInfo("F_InactiveDate", "D")
                            }
                        },
                        { "T_NCODECURRENCY",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Code", "N3",true),
                                new DBFieldInfo("F_Decimal", "I"),
                                new DBFieldInfo("F_Symbol", "N6"),
                                new DBFieldInfo("F_LSymbol", "L6"),
                                new DBFieldInfo("F_XSIZE", "I"),
                                new DBFieldInfo("F_HUNDRED_SEP", "L5"),
                                new DBFieldInfo("F_SUFFIX", "L30"),
                                new DBFieldInfo("F_CMODE", "N1"),
                                new DBFieldInfo("F_CENTNAME", "L20"),
                                new DBFieldInfo("F_ZEROCENT", "L20"),
                                new DBFieldInfo("F_CommaWords", "L20"),
                                new DBFieldInfo("F_SepWords", "L20"),
                                new DBFieldInfo("F_XUseSpace", "N1"),
                                new DBFieldInfo("F_UUseSpace", "N1"),
                                new DBFieldInfo("F_BUseSpace", "N1"),
                                new DBFieldInfo("F_UseHundred", "N1"),
                                new DBFieldInfo("F_LSFont", "L20"),
                                new DBFieldInfo("F_LSScript", "L20"),
                                new DBFieldInfo("F_Inactive", "N1"),
                                new DBFieldInfo("F_X0", "L20"),
                                new DBFieldInfo("F_X1", "L20"),
                                new DBFieldInfo("F_X2", "L20"),
                                new DBFieldInfo("F_X3", "L20"),
                                new DBFieldInfo("F_X4", "L20"),
                                new DBFieldInfo("F_X5", "L20"),
                                new DBFieldInfo("F_X6", "L20"),
                                new DBFieldInfo("F_X7", "L20"),
                                new DBFieldInfo("F_X8", "L20"),
                                new DBFieldInfo("F_X9", "L20"),
                                new DBFieldInfo("F_U0", "L20"),
                                new DBFieldInfo("F_U1", "L20"),
                                new DBFieldInfo("F_U2", "L20"),
                                new DBFieldInfo("F_U3", "L20"),
                                new DBFieldInfo("F_U4", "L20"),
                                new DBFieldInfo("F_U5", "L20"),
                                new DBFieldInfo("F_U6", "L20"),
                                new DBFieldInfo("F_U7", "L20"),
                                new DBFieldInfo("F_U8", "L20"),
                                new DBFieldInfo("F_U9", "L20"),
                                new DBFieldInfo("F_N0", "L20"),
                                new DBFieldInfo("F_N1", "L20"),
                                new DBFieldInfo("F_N2", "L20"),
                                new DBFieldInfo("F_N3", "L20"),
                                new DBFieldInfo("F_N4", "L20"),
                                new DBFieldInfo("F_N5", "L20"),
                                new DBFieldInfo("F_N6", "L20"),
                                new DBFieldInfo("F_N7", "L20"),
                                new DBFieldInfo("F_N8", "L20"),
                                new DBFieldInfo("F_N9", "L20"),
                                new DBFieldInfo("F_N10", "L20"),
                                new DBFieldInfo("F_N11", "L20"),
                                new DBFieldInfo("F_N12", "L20"),
                                new DBFieldInfo("F_N13", "L20"),
                                new DBFieldInfo("F_N14", "L20"),
                                new DBFieldInfo("F_N15", "L20"),
                                new DBFieldInfo("F_N16", "L20"),
                                new DBFieldInfo("F_N17", "L20"),
                                new DBFieldInfo("F_N18", "L20"),
                                new DBFieldInfo("F_N19", "L20"),
                                new DBFieldInfo("F_N20", "L20"),
                                new DBFieldInfo("F_N30", "L20"),
                                new DBFieldInfo("F_N40", "L20"),
                                new DBFieldInfo("F_N50", "L20"),
                                new DBFieldInfo("F_N60", "L20"),
                                new DBFieldInfo("F_N70", "L20"),
                                new DBFieldInfo("F_N80", "L20"),
                                new DBFieldInfo("F_N90", "L20"),
                                new DBFieldInfo("F_XD2", "L20"),
                                new DBFieldInfo("F_XD1", "L20"),
                                new DBFieldInfo("F_UseMiddleZWords", "N1"),
                                new DBFieldInfo("F_NoUseSuffixWhen", "N1"),
                                new DBFieldInfo("F_BankInfo", "N200")
                            }
                        },
                        { "T_NEWJOUR",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_KEY", "N50",true),
                                new DBFieldInfo("F_TBINDEX", "I"),
                                new DBFieldInfo("F_ORDER", "I"),
                                new DBFieldInfo("F_TBTYPE", "I"),
                                new DBFieldInfo("F_PostDate", "D"),
                                new DBFieldInfo("F_SeqNo", "I",true),
                                new DBFieldInfo("F_Branch", "N3",true),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_STBName", "N20",true),
                                new DBFieldInfo("F_STBID", "I",true),
                                new DBFieldInfo("F_ComType", "N1",true),
                                new DBFieldInfo("F_ComID", "I",true),
                                new DBFieldInfo("F_ComName", "N50"),
                                new DBFieldInfo("F_GLNo", "N10",true),
                                new DBFieldInfo("F_SubCode", "N20"),
                                new DBFieldInfo("F_Debit", "F"),
                                new DBFieldInfo("F_Credit", "F"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_ExRate", "F"),
                                new DBFieldInfo("F_FDebit", "F"),
                                new DBFieldInfo("F_FCredit", "F"),
                                new DBFieldInfo("F_MDesc", "U200"),
                                new DBFieldInfo("F_U2ID", "N15"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_MBLID", "I",true),
                                new DBFieldInfo("F_MTBName", "N20",true),
                                new DBFieldInfo("F_RTBID", "I",true)
                            }
                        },
                        { "T_NEWJOURB",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_KEY", "N50",true),
                                new DBFieldInfo("F_TBINDEX", "I"),
                                new DBFieldInfo("F_ORDER", "I"),
                                new DBFieldInfo("F_TBTYPE", "I"),
                                new DBFieldInfo("F_PostDate", "D"),
                                new DBFieldInfo("F_SeqNo", "I",true),
                                new DBFieldInfo("F_Branch", "N3",true),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_STBName", "N20",true),
                                new DBFieldInfo("F_STBID", "I",true),
                                new DBFieldInfo("F_ComType", "N1",true),
                                new DBFieldInfo("F_ComID", "I",true),
                                new DBFieldInfo("F_ComName", "N50"),
                                new DBFieldInfo("F_GLNo", "N10",true),
                                new DBFieldInfo("F_SubCode", "N20"),
                                new DBFieldInfo("F_Debit", "F"),
                                new DBFieldInfo("F_Credit", "F"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_ExRate", "F"),
                                new DBFieldInfo("F_FDebit", "F"),
                                new DBFieldInfo("F_FCredit", "F"),
                                new DBFieldInfo("F_MDesc", "U200"),
                                new DBFieldInfo("F_U2ID", "N15"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_MBLID", "I",true),
                                new DBFieldInfo("F_MTBName", "N20",true),
                                new DBFieldInfo("F_OriType", "N2"),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_RTBID", "I",true)
                            }
                        },
                        { "T_NLOGATTACH",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_IDEX", "IP"),
                                new DBFieldInfo("F_LogHDID", "I",true),
                                new DBFieldInfo("F_LogFileID", "I",true)
                            }
                        },
                        { "T_NLogBackup",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_IDEX", "IP"),
                                new DBFieldInfo("F_BackupName", "N50"),
                                new DBFieldInfo("F_Description", "N300"),
                                new DBFieldInfo("F_BackupType", "N1"),
                                new DBFieldInfo("F_DeviceType", "N1"),
                                new DBFieldInfo("F_PeriodFrom", "D"),
                                new DBFieldInfo("F_PeriodTo", "D")
                            }
                        },
                        { "T_NLOGDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_IDEX", "IP"),
                                new DBFieldInfo("F_LogHDID", "I",true),
                                new DBFieldInfo("F_Recipient", "U100"),
                                new DBFieldInfo("F_RecCompanyName", "U50"),
                                new DBFieldInfo("F_RecCompanyID", "I"),
                                new DBFieldInfo("F_RecNo", "N50"),
                                new DBFieldInfo("F_RepeatCount", "I"),
                                new DBFieldInfo("F_State", "N2",true),
                                new DBFieldInfo("F_PostDate", "T",true),
                                new DBFieldInfo("F_SType", "N1",true),
                                new DBFieldInfo("F_CoverPage", "N20"),
                                new DBFieldInfo("F_SDEID", "I",true)
                            }
                        },
                        { "T_NLOGFILE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_IDEX", "IP"),
                                new DBFieldInfo("F_FileName", "N30"),
                                new DBFieldInfo("F_FileSize", "I"),
                                new DBFieldInfo("F_OFileName", "N100"),
                                new DBFieldInfo("F_FileType", "I")
                            }
                        },
                        { "T_NLOGMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_IDEX", "IP",true),
                                new DBFieldInfo("F_Type", "N1",true),
                                new DBFieldInfo("F_SenderID", "N15"),
                                new DBFieldInfo("F_SenderInfo", "N50"),
                                new DBFieldInfo("F_Title", "U500",true),
                                new DBFieldInfo("F_Body", "U3500"),
                                new DBFieldInfo("F_LogFileID", "I",true),
                                new DBFieldInfo("F_PostDate", "T",true),
                                new DBFieldInfo("F_SID", "N30"),
                                new DBFieldInfo("F_SHDID", "I",true),
                                new DBFieldInfo("F_TBNAME", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_WAIT", "N1"),
                                new DBFieldInfo("F_Backup", "N1"),
                                new DBFieldInfo("F_BackupID", "I")
                            }
                        },
                        { "T_NSLIPKEY",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Key", "N50"),
                                new DBFieldInfo("F_TBName", "N20"),
                                new DBFieldInfo("F_TBID", "I"),
                                new DBFieldInfo("F_TBType", "I"),
                                new DBFieldInfo("F_Date", "D"),
                                new DBFieldInfo("F_Branch", "N3"),
                                new DBFieldInfo("F_Seq", "I"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_UPD", "I"),
                                new DBFieldInfo("F_RTBID", "I")
                            }
                        },
                        #endregion
                        #region : O
                        { "T_ODTC_UOM",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Code", "N5P",true),
                                new DBFieldInfo("F_Description", "N50")
                            }
                        },
                        { "T_ODTC_USMLCAT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Code", "N4P",true),
                                new DBFieldInfo("F_Description", "N200")
                            }
                        },
                        { "T_OIHCONTAINER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OIHBLID", "I",true),
                                new DBFieldInfo("F_OIMCntID", "I",true),
                                new DBFieldInfo("F_PKGS", "I"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_CFT", "F"),
                                new DBFieldInfo("F_KGS", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_AMSLinkUserID", "N10"),
                                new DBFieldInfo("F_AMSLinkID", "I",true),
                                new DBFieldInfo("F_AMSLinkDate", "D"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D")
                            }
                        },
                        { "T_OIHMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OIMBLID", "I",true),
                                new DBFieldInfo("F_HBLNo", "N20",true),
                                new DBFieldInfo("F_Customer", "I",true),
                                new DBFieldInfo("F_Shipper", "I"),
                                new DBFieldInfo("F_SName", "N250"),
                                new DBFieldInfo("F_Consignee", "I"),
                                new DBFieldInfo("F_CName", "N250"),
                                new DBFieldInfo("F_Notify", "I"),
                                new DBFieldInfo("F_NName", "N250"),
                                new DBFieldInfo("F_Broker", "I"),
                                new DBFieldInfo("F_BName", "N100"),
                                new DBFieldInfo("F_BTel", "N30"),
                                new DBFieldInfo("F_BFax", "N30"),
                                new DBFieldInfo("F_BEMail", "N100"),
                                new DBFieldInfo("F_BContact", "N50"),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_CustRefNo", "N50"),
                                new DBFieldInfo("F_PKGS", "F"),
                                new DBFieldInfo("F_Punit", "N10"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_DevanCBM", "F"),
                                new DBFieldInfo("F_KGS", "F"),
                                new DBFieldInfo("F_DevanKGS", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_DevanLBS", "F"),
                                new DBFieldInfo("F_OBLCol", "N1"),
                                new DBFieldInfo("F_OBLDate", "D"),
                                new DBFieldInfo("F_ExpRLS", "N1"),
                                new DBFieldInfo("F_RLSDate", "D"),
                                new DBFieldInfo("F_ReleaseBy", "N10"),
                                new DBFieldInfo("F_CFSLocation", "I"),
                                new DBFieldInfo("F_USFCode", "N5"),
                                new DBFieldInfo("F_FinalDest", "N25"),
                                new DBFieldInfo("F_FETA", "D",true),
                                new DBFieldInfo("F_ITClass", "N5"),
                                new DBFieldInfo("F_PickupDate", "D"),
                                new DBFieldInfo("F_ITCarrier", "I"),
                                new DBFieldInfo("F_ITNo", "N20"),
                                new DBFieldInfo("F_ITPlace", "N20"),
                                new DBFieldInfo("F_ITDate", "D"),
                                new DBFieldInfo("F_DCodeCustom", "N5"),
                                new DBFieldInfo("F_FCodeCustom", "N5"),
                                new DBFieldInfo("F_ForeignDest", "N25"),
                                new DBFieldInfo("F_PPCC", "N2"),
                                new DBFieldInfo("F_SManID", "N10"),
                                new DBFieldInfo("F_Mark", "N800"),
                                new DBFieldInfo("F_MarkPkg", "N800"),
                                new DBFieldInfo("F_Description", "N1000"),
                                new DBFieldInfo("F_MarkGross", "N800"),
                                new DBFieldInfo("F_MarkMeasure", "N800"),
                                new DBFieldInfo("F_GODate", "D"),
                                new DBFieldInfo("F_LastFreeday", "D"),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_OtherDescript", "N30"),
                                new DBFieldInfo("F_Operator", "N10"),
                                new DBFieldInfo("F_SelectContainer", "N1"),
                                new DBFieldInfo("F_MoveType", "N15"),
                                new DBFieldInfo("F_Nomi", "N1"),
                                new DBFieldInfo("F_IMemo", "U800"),
                                new DBFieldInfo("F_PMemo", "U800"),
                                new DBFieldInfo("F_DefaultRate", "F"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_MultiNameID", "I"),
                                new DBFieldInfo("F_SubMblSurFix", "N20"),
                                new DBFieldInfo("F_INVOICETO", "I"),
                                new DBFieldInfo("F_DoorMove", "N1"),
                                new DBFieldInfo("F_AvialDate", "D"),
                                new DBFieldInfo("F_PrevITno", "N12"),
                                new DBFieldInfo("F_PrevITClass", "N5"),
                                new DBFieldInfo("F_PrevITDate", "D"),
                                new DBFieldInfo("F_PrevITPort", "N5"),
                                new DBFieldInfo("F_ClearPort", "N4"),
                                new DBFieldInfo("F_ClearDate", "D"),
                                new DBFieldInfo("F_AMSBLNO", "N16"),
                                new DBFieldInfo("F_TruckLoadno", "N20"),
                                new DBFieldInfo("F_ReceiptPlace", "N20"),
                                new DBFieldInfo("F_CustomStatus", "N1"),
                                new DBFieldInfo("F_ROR", "N1"),
                                new DBFieldInfo("F_DoorDlvLocation", "N100"),
                                new DBFieldInfo("F_DoorDlvETA", "D"),
                                new DBFieldInfo("F_ForeignETA", "D"),
                                new DBFieldInfo("F_FDARlsDate", "D"),
                                new DBFieldInfo("F_FDAHold", "N1"),
                                new DBFieldInfo("F_PODRcvd", "N1"),
                                new DBFieldInfo("F_ITDestination", "N20"),
                                new DBFieldInfo("F_ISFNO", "N20"),
                                new DBFieldInfo("F_ProjectNo", "N20"),
                                new DBFieldInfo("F_SONo", "N20"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_IncoTerms", "N10"),
                                new DBFieldInfo("F_AMSLinkUserID", "N10"),
                                new DBFieldInfo("F_AMSLinkID", "I",true),
                                new DBFieldInfo("F_AMSLinkDate", "D"),
                                new DBFieldInfo("F_PIMSPOID", "I"),
                                new DBFieldInfo("F_SHIPMENTID", "N20"),
                                new DBFieldInfo("F_NOTICEDATE", "D"),
                                new DBFieldInfo("F_CompleteBill", "N1"),
                                new DBFieldInfo("F_CompleteInvo", "N1"),
                                new DBFieldInfo("F_CompleteCrDb", "N1"),
                                new DBFieldInfo("F_CARGONO", "N50"),
                                new DBFieldInfo("F_SENTTO", "I"),
                                new DBFieldInfo("F_CLEARANCEBY", "I"),
                                new DBFieldInfo("F_CARTAGEBY", "I"),
                                new DBFieldInfo("F_MANIFESTDATE", "D"),
                                new DBFieldInfo("F_ACQUITTALNO", "N50"),
                                new DBFieldInfo("F_PREVCARGONO", "N50D"),
                                new DBFieldInfo("F_MANIFESTFROM", "N50"),
                                new DBFieldInfo("F_TOA", "N50"),
                                new DBFieldInfo("F_VehicleNo", "N50"),
                                new DBFieldInfo("F_UNFcode", "N5"),
                                new DBFieldInfo("F_Exrate1", "F"),
                                new DBFieldInfo("F_Exrate2", "F"),
                                new DBFieldInfo("F_ShipmentType", "N1"),
                                new DBFieldInfo("F_Currency1", "N3"),
                                new DBFieldInfo("F_Currency2", "N3"),
                                new DBFieldInfo("F_Agent2", "I"),
                                new DBFieldInfo("F_Agent3", "I"),
                                new DBFieldInfo("F_DutyCustomer", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3"),
                                new DBFieldInfo("F_StatusCrDb", "N3"),
                                new DBFieldInfo("F_CloseDate", "D")
                            }
                        },
                        { "T_OIHPONO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OIHBLID", "I",true),
                                new DBFieldInfo("F_PONO", "N20"),
                                new DBFieldInfo("F_SKUNO", "N20"),
                                new DBFieldInfo("F_HTSCODE", "N20"),
                                new DBFieldInfo("F_description", "N50"),
                                new DBFieldInfo("F_STYLENO", "N20"),
                                new DBFieldInfo("F_ITEMNO", "N20"),
                                new DBFieldInfo("F_ShipQty", "I"),
                                new DBFieldInfo("F_kgs", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_CFT", "F"),
                                new DBFieldInfo("F_ShipUnit", "N10"),
                                new DBFieldInfo("F_COO", "N2"),
                                new DBFieldInfo("F_UPRICE", "F"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_PimsPOHDLinkID", "I"),
                                new DBFieldInfo("F_PimsPODETLinkID", "I"),
                                new DBFieldInfo("F_CNTRLinkID", "I")
                            }
                        },
                        { "T_OIMCONTAINER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OIMBLID", "I",true),
                                new DBFieldInfo("F_ContainerNo", "N11",true),
                                new DBFieldInfo("F_ConType", "N10",true),
                                new DBFieldInfo("F_SealNo", "N20"),
                                new DBFieldInfo("F_GODate", "D"),
                                new DBFieldInfo("F_LastFreeDay", "D"),
                                new DBFieldInfo("F_PickupNo", "N15"),
                                new DBFieldInfo("F_PickuplOC", "N60"),
                                new DBFieldInfo("F_Indate", "D"),
                                new DBFieldInfo("F_OutDate", "D"),
                                new DBFieldInfo("F_EmptyReturn", "D"),
                                new DBFieldInfo("F_PKGS", "I"),
                                new DBFieldInfo("F_KGS", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_ORD", "D"),
                                new DBFieldInfo("F_LoadDate", "D"),
                                new DBFieldInfo("F_ATD", "D"),
                                new DBFieldInfo("F_ATA", "D"),
                                new DBFieldInfo("F_UnloadDate", "D"),
                                new DBFieldInfo("F_CFSDATE", "D"),
                                new DBFieldInfo("F_RATD", "D"),
                                new DBFieldInfo("F_RATA", "D"),
                                new DBFieldInfo("F_PUDATE", "D"),
                                new DBFieldInfo("F_DCDate", "D"),
                                new DBFieldInfo("F_Indate_Loc", "N60"),
                                new DBFieldInfo("F_OutDate_Loc", "N60"),
                                new DBFieldInfo("F_EmptyReturn_Loc", "N60"),
                                new DBFieldInfo("F_ORD_Loc", "N60"),
                                new DBFieldInfo("F_LoadDate_Loc", "N60"),
                                new DBFieldInfo("F_ATD_Loc", "N60"),
                                new DBFieldInfo("F_ATA_Loc", "N60"),
                                new DBFieldInfo("F_UnloadDatE_Loc", "N60"),
                                new DBFieldInfo("F_CFSDATE_Loc", "N60"),
                                new DBFieldInfo("F_RATD_Loc", "N60"),
                                new DBFieldInfo("F_RATA_Loc", "N60"),
                                new DBFieldInfo("F_PUDATE_Loc", "N60"),
                                new DBFieldInfo("F_DCDate_Loc", "N60"),
                                new DBFieldInfo("F_CarrierRLS", "D"),
                                new DBFieldInfo("F_BookingDate", "D"),
                                new DBFieldInfo("F_CustomRLS", "D"),
                                new DBFieldInfo("F_CarrierRLS_Loc", "N60"),
                                new DBFieldInfo("F_Booking_Loc", "N60"),
                                new DBFieldInfo("F_CustomRLS_Loc", "N60"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_AMSLinkUserID", "N10"),
                                new DBFieldInfo("F_AMSLinkID", "I",true),
                                new DBFieldInfo("F_AMSLinkDate", "D")
                            }
                        },
                        { "T_OIMMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_MBLNo", "N20",true),
                                new DBFieldInfo("F_RefNo", "N20",true),
                                new DBFieldInfo("F_AgentRefNo", "N30"),
                                new DBFieldInfo("F_SMBLNo", "N20"),
                                new DBFieldInfo("F_mCommodity", "N100"),
                                new DBFieldInfo("F_Agent", "I"),
                                new DBFieldInfo("F_ETA", "D",true),
                                new DBFieldInfo("F_ETD", "D"),
                                new DBFieldInfo("F_Vessel", "N25",true),
                                new DBFieldInfo("F_Voyage", "N15",true),
                                new DBFieldInfo("F_SteamShip", "I"),
                                new DBFieldInfo("F_Carrier", "I"),
                                new DBFieldInfo("F_USLCode", "N5"),
                                new DBFieldInfo("F_LoadingPort", "N50"),
                                new DBFieldInfo("F_USDCode", "N5"),
                                new DBFieldInfo("F_DisCharge", "N50"),
                                new DBFieldInfo("F_CYLocation", "I"),
                                new DBFieldInfo("F_CFSLocation", "I"),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_LCLFCL", "N1"),
                                new DBFieldInfo("F_ITCarrier", "I"),
                                new DBFieldInfo("F_ITNo", "N12"),
                                new DBFieldInfo("F_ITPlace", "N20"),
                                new DBFieldInfo("F_ITClass", "N5"),
                                new DBFieldInfo("F_ITDate", "D"),
                                new DBFieldInfo("F_USFCode", "N5"),
                                new DBFieldInfo("F_FinalDest", "N25"),
                                new DBFieldInfo("F_FETA", "D",true),
                                new DBFieldInfo("F_VesselFlag", "N10"),
                                new DBFieldInfo("F_Country", "N10"),
                                new DBFieldInfo("F_PPCC", "N2"),
                                new DBFieldInfo("F_SVCCNo", "N30"),
                                new DBFieldInfo("F_EmptyRtn", "I"),
                                new DBFieldInfo("F_FeederVessel", "N25"),
                                new DBFieldInfo("F_MoveType", "N15"),
                                new DBFieldInfo("F_ExpRLS", "N1"),
                                new DBFieldInfo("F_RLSDate", "D"),
                                new DBFieldInfo("F_ShowAgent", "N1"),
                                new DBFieldInfo("F_ProfitShare", "F"),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_DevanRemark", "U2000"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_CUR1", "N3"),
                                new DBFieldInfo("F_CUR2", "N3"),
                                new DBFieldInfo("F_OfrtCfrm", "N1"),
                                new DBFieldInfo("F_OfrtHold", "N1"),
                                new DBFieldInfo("F_OBLDate", "D"),
                                new DBFieldInfo("F_PNLDate", "D"),
                                new DBFieldInfo("F_Operator", "N10"),
                                new DBFieldInfo("F_LotNo", "N20",true),
                                new DBFieldInfo("F_PimsLinkUserID", "N70"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_AMSLinkUserID", "N10"),
                                new DBFieldInfo("F_AMSLinkID", "I",true),
                                new DBFieldInfo("F_AMSLinkDate", "D"),
                                new DBFieldInfo("F_Exrate1", "F"),
                                new DBFieldInfo("F_Exrate2", "F"),
                                new DBFieldInfo("F_Cargono", "N50"),
                                new DBFieldInfo("F_ManifestFrom", "N12"),
                                new DBFieldInfo("F_ToAgent", "N20"),
                                new DBFieldInfo("F_UNLcode", "N5"),
                                new DBFieldInfo("F_UNDcode", "N5"),
                                new DBFieldInfo("F_UNFcode", "N5"),
                                new DBFieldInfo("F_CompleteBill", "N1"),
                                new DBFieldInfo("F_CompleteInvo", "N1"),
                                new DBFieldInfo("F_CompleteCrDb", "N1"),
                                new DBFieldInfo("F_DirectBL", "N1"),
                                new DBFieldInfo("F_Line", "N5"),
                                new DBFieldInfo("F_ConfirmDate", "D",true),
                                new DBFieldInfo("F_ConfirmedBy", "N10"),
                                new DBFieldInfo("F_ShipmentType", "N1"),
                                new DBFieldInfo("F_Agent2", "I"),
                                new DBFieldInfo("F_Agent3", "I"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3"),
                                new DBFieldInfo("F_StatusCrDb", "N3"),
                                new DBFieldInfo("F_MSManID", "N10"),
                                new DBFieldInfo("F_ConfirmActionDate", "D"),
                                new DBFieldInfo("F_DutyCustomer", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_CloseDate", "D"),
                                new DBFieldInfo("F_MBLCustomer", "I"),
                                new DBFieldInfo("F_EBL", "N1")
                            }
                        },
                        { "T_OOHACCT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OOHBLID", "I",true),
                                new DBFieldInfo("F_ChgCode", "N30"),
                                new DBFieldInfo("F_Description", "L100"),
                                new DBFieldInfo("F_ColCost", "F"),
                                new DBFieldInfo("F_ColRevenue", "F"),
                                new DBFieldInfo("F_Seq", "I",true)
                            }
                        },
                        { "T_OOHCONTAINER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OOHBLID", "I",true),
                                new DBFieldInfo("F_OOMCNTID", "I",true),
                                new DBFieldInfo("F_Pkgs", "I"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D")
                            }
                        },
                        { "T_OOHMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OOMBLID", "I",true),
                                new DBFieldInfo("F_HBLNo", "N20",true),
                                new DBFieldInfo("F_Customer", "I",true),
                                new DBFieldInfo("F_Shipper", "I"),
                                new DBFieldInfo("F_SName", "N250"),
                                new DBFieldInfo("F_Consignee", "I"),
                                new DBFieldInfo("F_CName", "N250"),
                                new DBFieldInfo("F_Notify", "I"),
                                new DBFieldInfo("F_NName", "N250"),
                                new DBFieldInfo("F_Agent", "I"),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_ExPref", "N100"),
                                new DBFieldInfo("F_Carrier", "I"),
                                new DBFieldInfo("F_Vessel", "N30"),
                                new DBFieldInfo("F_Voyage", "N10"),
                                new DBFieldInfo("F_PLOFREC", "N25"),
                                new DBFieldInfo("F_PLOFDEL", "N40"),
                                new DBFieldInfo("F_USLCode", "N5"),
                                new DBFieldInfo("F_UNLCode", "N5"),
                                new DBFieldInfo("F_LoadingPort", "N50"),
                                new DBFieldInfo("F_USDCode", "N5"),
                                new DBFieldInfo("F_UNDCode", "N5"),
                                new DBFieldInfo("F_DisCharge", "N50"),
                                new DBFieldInfo("F_FinalDest", "N30"),
                                new DBFieldInfo("F_Pkgs", "F"),
                                new DBFieldInfo("F_PUnit", "N10"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_KGS", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_IssueDate", "D"),
                                new DBFieldInfo("F_OnboardDate", "D"),
                                new DBFieldInfo("F_OSCode", "N3"),
                                new DBFieldInfo("F_DCCode", "N3"),
                                new DBFieldInfo("F_OriginState", "N20"),
                                new DBFieldInfo("F_DestCountry", "N20"),
                                new DBFieldInfo("F_OnwardRoute", "N150"),
                                new DBFieldInfo("F_ForwardAgent", "I"),
                                new DBFieldInfo("F_TranShipment", "N30"),
                                new DBFieldInfo("F_IssuedBy", "N15"),
                                new DBFieldInfo("F_MoveType", "N15"),
                                new DBFieldInfo("F_LCLFCL", "N1"),
                                new DBFieldInfo("F_Loaded", "I"),
                                new DBFieldInfo("F_CheckIn", "I"),
                                new DBFieldInfo("F_ShowCharge", "N1"),
                                new DBFieldInfo("F_Nobl", "N10"),
                                new DBFieldInfo("F_ProfitShare", "F"),
                                new DBFieldInfo("F_IssuePlace", "N20"),
                                new DBFieldInfo("F_PPCC", "N2"),
                                new DBFieldInfo("F_SManID", "N10"),
                                new DBFieldInfo("F_Operator", "N10"),
                                new DBFieldInfo("F_Nomi", "N1"),
                                new DBFieldInfo("F_Mark", "N800"),
                                new DBFieldInfo("F_Description", "N4000"),
                                new DBFieldInfo("F_MarkPkg", "N800"),
                                new DBFieldInfo("F_MarkGross", "N800"),
                                new DBFieldInfo("F_MarkMeasure", "N800"),
                                new DBFieldInfo("F_MarkOnboard", "N800"),
                                new DBFieldInfo("F_Rider", "N800"),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_HBookingNo", "N20",true),
                                new DBFieldInfo("F_BookedBy", "N10"),
                                new DBFieldInfo("F_BookRemark", "N800"),
                                new DBFieldInfo("F_BookETD", "D"),
                                new DBFieldInfo("F_BookETA", "D"),
                                new DBFieldInfo("F_RailCutOff", "T"),
                                new DBFieldInfo("F_PortCutOff", "T"),
                                new DBFieldInfo("F_WhseCutOff", "T"),
                                new DBFieldInfo("F_RcveWhse", "I"),
                                new DBFieldInfo("F_CbookingNo", "N20"),
                                new DBFieldInfo("F_CBookedBy", "N10"),
                                new DBFieldInfo("F_BookDate", "D"),
                                new DBFieldInfo("F_QuoteID", "I"),
                                new DBFieldInfo("F_CarrierName", "N60"),
                                new DBFieldInfo("F_SubAgentBL", "N1"),
                                new DBFieldInfo("F_ProjectNo", "N20"),
                                new DBFieldInfo("F_SONo", "N20"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_MultiNameID", "I"),
                                new DBFieldInfo("F_Doc_receiptNo", "N20"),
                                new DBFieldInfo("F_XTNNo", "N30"),
                                new DBFieldInfo("F_INVOICETO", "I"),
                                new DBFieldInfo("F_EQUIPMENT", "N100"),
                                new DBFieldInfo("F_ExpBL", "N1"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_PIMSPOID", "I"),
                                new DBFieldInfo("F_SHIPMENTID", "N20"),
                                new DBFieldInfo("F_NOTICEDATE", "D"),
                                new DBFieldInfo("F_CompleteBill", "N1"),
                                new DBFieldInfo("F_CompleteInvo", "N1"),
                                new DBFieldInfo("F_CompleteCrDb", "N1"),
                                new DBFieldInfo("F_Exrate1", "F"),
                                new DBFieldInfo("F_Exrate2", "F"),
                                new DBFieldInfo("F_PayableAt", "N30"),
                                new DBFieldInfo("F_NoOfBL", "I"),
                                new DBFieldInfo("F_ShipmentType", "N1"),
                                new DBFieldInfo("F_Currency1", "N3"),
                                new DBFieldInfo("F_Currency2", "N3"),
                                new DBFieldInfo("F_Agent2", "I"),
                                new DBFieldInfo("F_Agent3", "I"),
                                new DBFieldInfo("F_DutyCustomer", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3"),
                                new DBFieldInfo("F_StatusCrDb", "N3"),
                                new DBFieldInfo("F_CloseDate", "D")
                            }
                        },
                        { "T_OOHPONO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OOHBLID", "I",true),
                                new DBFieldInfo("F_PONO", "N20"),
                                new DBFieldInfo("F_SKUNO", "N20"),
                                new DBFieldInfo("F_HTSCODE", "N20"),
                                new DBFieldInfo("F_description", "N50"),
                                new DBFieldInfo("F_STYLENO", "N20"),
                                new DBFieldInfo("F_ITEMNO", "N20"),
                                new DBFieldInfo("F_ShipQty", "I"),
                                new DBFieldInfo("F_kgs", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_CFT", "F"),
                                new DBFieldInfo("F_ShipUnit", "N10"),
                                new DBFieldInfo("F_COO", "N2"),
                                new DBFieldInfo("F_UPRICE", "F"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_PimsPOHDLinkID", "I"),
                                new DBFieldInfo("F_PimsPODETLinkID", "I"),
                                new DBFieldInfo("F_CNTRLinkID", "I")
                            }
                        },
                        { "T_OOHQUODETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_QuoteHDID", "I",true),
                                new DBFieldInfo("F_Mode", "N5"),
                                new DBFieldInfo("F_TT", "N2"),
                                new DBFieldInfo("F_Carrier", "N15"),
                                new DBFieldInfo("F_CarQuote", "N15"),
                                new DBFieldInfo("F_ChargeDesc", "N50"),
                                new DBFieldInfo("F_Unit", "N10"),
                                new DBFieldInfo("F_Qty", "F"),
                                new DBFieldInfo("F_Buying", "F"),
                                new DBFieldInfo("F_Selling", "F"),
                                new DBFieldInfo("F_Seq", "I")
                            }
                        },
                        { "T_OOHQUOTATION",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_QuoteNO", "N20",true),
                                new DBFieldInfo("F_Customer", "I",true),
                                new DBFieldInfo("F_Agent", "I",true),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_PLOFREC", "N25"),
                                new DBFieldInfo("F_PLOFDEL", "N25"),
                                new DBFieldInfo("F_UNLCode", "N5"),
                                new DBFieldInfo("F_LoadingPort", "N50"),
                                new DBFieldInfo("F_UNDCode", "N5"),
                                new DBFieldInfo("F_DisCharge", "N50"),
                                new DBFieldInfo("F_FinalDest", "N30"),
                                new DBFieldInfo("F_Pkgs", "F"),
                                new DBFieldInfo("F_PUnit", "N10"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_KGS", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_QuoteDate", "D"),
                                new DBFieldInfo("F_SManID", "N10"),
                                new DBFieldInfo("F_Operator", "N10"),
                                new DBFieldInfo("F_ServiceType", "N10"),
                                new DBFieldInfo("F_ValidityDate", "D"),
                                new DBFieldInfo("F_OChargeDesc1", "N100"),
                                new DBFieldInfo("F_OChargeDesc2", "N100"),
                                new DBFieldInfo("F_OChargeDesc3", "N100"),
                                new DBFieldInfo("F_OChargeAmt1", "F"),
                                new DBFieldInfo("F_OChargeAmt2", "F"),
                                new DBFieldInfo("F_OChargeAmt3", "F"),
                                new DBFieldInfo("F_Remark", "N1000"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_FreeFormChk", "N1"),
                                new DBFieldInfo("F_FreeFormText", "N4100")
                            }
                        },
                        { "T_OOMCONTAINER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OOMBLID", "I"),
                                new DBFieldInfo("F_ContainerNo", "N11",true),
                                new DBFieldInfo("F_ConType", "N10"),
                                new DBFieldInfo("F_SealNo", "N20"),
                                new DBFieldInfo("F_Pkgs", "F"),
                                new DBFieldInfo("F_PickupNo", "N15"),
                                new DBFieldInfo("F_Indate", "D"),
                                new DBFieldInfo("F_OutDate", "D"),
                                new DBFieldInfo("F_EmptyReturn", "D"),
                                new DBFieldInfo("F_ORD", "D"),
                                new DBFieldInfo("F_LoadDate", "D"),
                                new DBFieldInfo("F_ATD", "D"),
                                new DBFieldInfo("F_ATA", "D"),
                                new DBFieldInfo("F_UnloadDate", "D"),
                                new DBFieldInfo("F_CFSDATE", "D"),
                                new DBFieldInfo("F_RATD", "D"),
                                new DBFieldInfo("F_RATA", "D"),
                                new DBFieldInfo("F_PUDATE", "D"),
                                new DBFieldInfo("F_DCDate", "D"),
                                new DBFieldInfo("F_Indate_Loc", "N60"),
                                new DBFieldInfo("F_OutDate_Loc", "N60"),
                                new DBFieldInfo("F_EmptyReturn_Loc", "N60"),
                                new DBFieldInfo("F_ORD_Loc", "N60"),
                                new DBFieldInfo("F_LoadDate_Loc", "N60"),
                                new DBFieldInfo("F_ATD_Loc", "N60"),
                                new DBFieldInfo("F_ATA_Loc", "N60"),
                                new DBFieldInfo("F_UnloadDatE_Loc", "N60"),
                                new DBFieldInfo("F_CFSDATE_Loc", "N60"),
                                new DBFieldInfo("F_RATD_Loc", "N60"),
                                new DBFieldInfo("F_RATA_Loc", "N60"),
                                new DBFieldInfo("F_PUDATE_Loc", "N60"),
                                new DBFieldInfo("F_DCDate_Loc", "N60"),
                                new DBFieldInfo("F_CarrierRLS", "D"),
                                new DBFieldInfo("F_BookingDate", "D"),
                                new DBFieldInfo("F_CustomRLS", "D"),
                                new DBFieldInfo("F_CarrierRLS_Loc", "N60"),
                                new DBFieldInfo("F_Booking_Loc", "N60"),
                                new DBFieldInfo("F_CustomRLS_Loc", "N60"),
                                new DBFieldInfo("F_PimsLinkUserID", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_Order", "I"),
                                new DBFieldInfo("F_Unit", "N20"),
                                new DBFieldInfo("F_GrossKgs", "F"),
                                new DBFieldInfo("F_GrossLbs", "F"),
                                new DBFieldInfo("F_IsFlexiTank", "I"),
                                new DBFieldInfo("F_TankSize", "N20"),
                                new DBFieldInfo("F_FitByDate", "D"),
                                new DBFieldInfo("F_Commodity", "N100"),
                                new DBFieldInfo("F_PUNo", "N50"),
                                new DBFieldInfo("F_FTLoadDate", "T"),
                                new DBFieldInfo("F_SealNo2", "N20"),
                                new DBFieldInfo("F_SealNo3", "N20"),
                                new DBFieldInfo("F_SerialNo", "N50"),
                                new DBFieldInfo("F_NetKgs", "F"),
                                new DBFieldInfo("F_Cbm", "F"),
                                new DBFieldInfo("F_Gallon", "F"),
                                new DBFieldInfo("F_HTS", "N20"),
                                new DBFieldInfo("F_Payload", "F"),
                                new DBFieldInfo("F_Capacity", "F")
                            }
                        },
                        { "T_OOMMAIN",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_MBLNo", "N20",true),
                                new DBFieldInfo("F_SMBLNo", "N20"),
                                new DBFieldInfo("F_RefNo", "N20",true),
                                new DBFieldInfo("F_BookingNo", "N30"),
                                new DBFieldInfo("F_Agent", "I"),
                                new DBFieldInfo("F_ETA", "D"),
                                new DBFieldInfo("F_ETD", "D"),
                                new DBFieldInfo("F_Vessel", "N25"),
                                new DBFieldInfo("F_Voyage", "N10"),
                                new DBFieldInfo("F_SteamShip", "I"),
                                new DBFieldInfo("F_Carrier", "I"),
                                new DBFieldInfo("F_USLCode", "N5"),
                                new DBFieldInfo("F_LoadingPort", "N50"),
                                new DBFieldInfo("F_USDCode", "N5"),
                                new DBFieldInfo("F_DisCharge", "N50"),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_Rstation", "I"),
                                new DBFieldInfo("F_LCLFCL", "N1"),
                                new DBFieldInfo("F_PLOFREC", "N25"),
                                new DBFieldInfo("F_PLOFDEL", "N25"),
                                new DBFieldInfo("F_BrokerAge", "F"),
                                new DBFieldInfo("F_PPCC", "N2"),
                                new DBFieldInfo("F_SVCCNo", "N30"),
                                new DBFieldInfo("F_MoveType", "N15"),
                                new DBFieldInfo("F_BLType", "N30"),
                                new DBFieldInfo("F_ShowAgent", "N1"),
                                new DBFieldInfo("F_ProfitShare", "F"),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_CutOffDate", "D"),
                                new DBFieldInfo("F_CoLoad", "N1"),
                                new DBFieldInfo("F_DirectBL", "N1"),
                                new DBFieldInfo("F_Shipper", "I"),
                                new DBFieldInfo("F_SName", "N250"),
                                new DBFieldInfo("F_Consignee", "I"),
                                new DBFieldInfo("F_CName", "N250"),
                                new DBFieldInfo("F_Notify", "I"),
                                new DBFieldInfo("F_NName", "N250"),
                                new DBFieldInfo("F_ForwardAgent", "I"),
                                new DBFieldInfo("F_FName", "N250"),
                                new DBFieldInfo("F_Mark", "N800"),
                                new DBFieldInfo("F_Description", "N4000"),
                                new DBFieldInfo("F_MarkPkg", "N800"),
                                new DBFieldInfo("F_MarkGross", "N800"),
                                new DBFieldInfo("F_MarkMeasure", "N800"),
                                new DBFieldInfo("F_MarkOnboard", "N800"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_Operator", "N10"),
                                new DBFieldInfo("F_LotNo", "N20",true),
                                new DBFieldInfo("F_PimsLinkUserID", "N70"),
                                new DBFieldInfo("F_PimsLinkID", "I",true),
                                new DBFieldInfo("F_PimsLinkDate", "D"),
                                new DBFieldInfo("F_MXTNNo", "N30"),
                                new DBFieldInfo("F_FinalDestination", "N30"),
                                new DBFieldInfo("F_Domesticinfo", "N100"),
                                new DBFieldInfo("F_UNDCode", "N5"),
                                new DBFieldInfo("F_UNLCode", "N5"),
                                new DBFieldInfo("F_CUR1", "N3"),
                                new DBFieldInfo("F_CUR2", "N3"),
                                new DBFieldInfo("F_Exrate1", "F"),
                                new DBFieldInfo("F_Exrate2", "F"),
                                new DBFieldInfo("F_CompleteBill", "N1"),
                                new DBFieldInfo("F_CompleteInvo", "N1"),
                                new DBFieldInfo("F_CompleteCrDb", "N1"),
                                new DBFieldInfo("F_SentAgentEDI", "N1"),
                                new DBFieldInfo("F_Line", "N5"),
                                new DBFieldInfo("F_ConfirmDate", "D",true),
                                new DBFieldInfo("F_ConfirmedBy", "N10"),
                                new DBFieldInfo("F_ShipmentType", "N1"),
                                new DBFieldInfo("F_Agent2", "I"),
                                new DBFieldInfo("F_Agent3", "I"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3"),
                                new DBFieldInfo("F_StatusCrDb", "N3"),
                                new DBFieldInfo("F_MSManID", "N10"),
                                new DBFieldInfo("F_ConfirmActionDate", "D"),
                                new DBFieldInfo("F_DutyCustomer", "I"),
                                new DBFieldInfo("F_DutyAgent", "I"),
                                new DBFieldInfo("F_CloseDate", "D"),
                                new DBFieldInfo("F_MBLCustomer", "I")
                            }
                        },
                        { "T_OPACCT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TBNAME", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_LOC", "I"),
                                new DBFieldInfo("F_ChgType", "I",true),
                                new DBFieldInfo("F_BillingCode", "N30",true),
                                new DBFieldInfo("F_Description", "L100"),
                                new DBFieldInfo("F_Entity", "I"),
                                new DBFieldInfo("F_Cur1", "N3"),
                                new DBFieldInfo("F_Rate", "F"),
                                new DBFieldInfo("F_Qty", "F"),
                                new DBFieldInfo("F_ActualAmt", "F"),
                                new DBFieldInfo("F_Cur2", "N3"),
                                new DBFieldInfo("F_AgentAmt", "F"),
                                new DBFieldInfo("F_USEVAT", "N1"),
                                new DBFieldInfo("F_PS", "N1"),
                                new DBFieldInfo("F_POSTED", "N1",true),
                                new DBFieldInfo("F_LActAmt", "F"),
                                new DBFieldInfo("F_LAgtAmt", "F"),
                                new DBFieldInfo("F_VATAmount", "F"),
                                new DBFieldInfo("F_ActExrate", "F"),
                                new DBFieldInfo("F_AgtExrate", "F"),
                                new DBFieldInfo("F_Invoiced", "N1",true),
                                new DBFieldInfo("F_settled", "N1",true),
                                new DBFieldInfo("F_iDate", "D",true),
                                new DBFieldInfo("F_cDate", "D",true),
                                new DBFieldInfo("F_Agent", "I")
                            }
                        },
                        { "T_OTHERINFO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_TBNAME", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_SELLER", "N250"),
                                new DBFieldInfo("F_CONSIGNEE", "N250"),
                                new DBFieldInfo("F_BUYER", "N250"),
                                new DBFieldInfo("F_VESSEL", "N40"),
                                new DBFieldInfo("F_LOADINGPORT", "N50"),
                                new DBFieldInfo("F_DISCHARGE", "N50"),
                                new DBFieldInfo("F_PLOFREC", "N25"),
                                new DBFieldInfo("F_INVOICEDATE", "N50"),
                                new DBFieldInfo("F_TERMS", "N20"),
                                new DBFieldInfo("F_DEPARTDATE", "N20"),
                                new DBFieldInfo("F_EXPREF", "N100"),
                                new DBFieldInfo("F_HBLNO", "N20"),
                                new DBFieldInfo("F_ISSUEDATE", "D"),
                                new DBFieldInfo("F_ORIGINSTATE", "N40"),
                                new DBFieldInfo("F_MARK", "N900"),
                                new DBFieldInfo("F_DESCRIPTION", "N1500"),
                                new DBFieldInfo("F_MARKPKG", "N900"),
                                new DBFieldInfo("F_MARKGROSS", "N900"),
                                new DBFieldInfo("F_MARKMEASURE", "N900"),
                                new DBFieldInfo("F_UNITPRICE", "N900"),
                                new DBFieldInfo("F_AMOUNT", "N900"),
                                new DBFieldInfo("F_TBNAME2", "N20")
                            }
                        },
                        #endregion
                        #region : P , R
                        { "T_PAYHISTORY",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_DepoHDID", "I",true),
                                new DBFieldInfo("F_HistoryDate", "D"),
                                new DBFieldInfo("F_HistoryUser", "N10"),
                                new DBFieldInfo("F_HistoryAction", "N10"),
                                new DBFieldInfo("F_BankID", "I"),
                                new DBFieldInfo("F_PostDate", "D"),
                                new DBFieldInfo("F_CheckNo", "N35"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_ExRate", "F"),
                                new DBFieldInfo("F_Block", "N1"),
                                new DBFieldInfo("F_CustID", "I",true),
                                new DBFieldInfo("F_TotalAmount", "F"),
                                new DBFieldInfo("F_Remark", "U200"),
                                new DBFieldInfo("F_Draft", "N1")
                            }
                        },
                        { "T_PAYHISTORYDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_HDID", "I",true),
                                new DBFieldInfo("F_Status", "N10"),
                                new DBFieldInfo("F_InvoiceDate", "D"),
                                new DBFieldInfo("F_InvoiceNo", "N30"),
                                new DBFieldInfo("F_GLno", "N10",true),
                                new DBFieldInfo("F_Description", "N50"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_OriginalID", "I",true),
                                new DBFieldInfo("F_DepoDetailID", "I",true),
                                new DBFieldInfo("F_CustomerID", "I"),
                                new DBFieldInfo("F_Branch", "N3"),
                                new DBFieldInfo("F_TBName", "N10"),
                                new DBFieldInfo("F_TBID", "I")
                            }
                        },
                        { "T_PAYROLL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_BRANCH", "N3",true),
                                new DBFieldInfo("F_RefNo", "N10",true),
                                new DBFieldInfo("F_Remark", "N200"),
                                new DBFieldInfo("F_PayableNetSalary", "F"),
                                new DBFieldInfo("F_PayableFedTax", "F"),
                                new DBFieldInfo("F_PayableStateTax", "F"),
                                new DBFieldInfo("F_PayableOption1", "F"),
                                new DBFieldInfo("F_PayableOption2", "F"),
                                new DBFieldInfo("F_PayableOption3", "F"),
                                new DBFieldInfo("F_PayableOption4", "F"),
                                new DBFieldInfo("F_JournalID", "I",true),
                                new DBFieldInfo("F_CreatedBy", "N70"),
                                new DBFieldInfo("F_CreatedAt", "D"),
                                new DBFieldInfo("F_ModifiedBy", "N70"),
                                new DBFieldInfo("F_ModifiedAt", "D"),
                                new DBFieldInfo("F_PayrollDate", "D"),
                                new DBFieldInfo("F_Confirmed", "N1"),
                                new DBFieldInfo("F_Entity", "I",true),
                                new DBFieldInfo("F_FederalEntity", "I",true),
                                new DBFieldInfo("F_StateEntity", "I",true),
                                new DBFieldInfo("F_AdditionOption1", "N100"),
                                new DBFieldInfo("F_AdditionOption2", "N100"),
                                new DBFieldInfo("F_AdditionOption3", "N100"),
                                new DBFieldInfo("F_AdditionOption4", "N100"),
                                new DBFieldInfo("F_Add1Entity", "I",true),
                                new DBFieldInfo("F_Add2Entity", "I",true),
                                new DBFieldInfo("F_Add3Entity", "I",true),
                                new DBFieldInfo("F_Add4Entity", "I",true),
                                new DBFieldInfo("F_PaidAmtNetSalary", "F"),
                                new DBFieldInfo("F_PaidAmtFedTax", "F"),
                                new DBFieldInfo("F_PaidAmtStateTax", "F"),
                                new DBFieldInfo("F_PaidAmtOption1", "F"),
                                new DBFieldInfo("F_PaidAmtOption2", "F"),
                                new DBFieldInfo("F_PaidAmtOption3", "F"),
                                new DBFieldInfo("F_PaidAmtOption4", "F"),
                                new DBFieldInfo("F_PaidDateNetSalary", "D"),
                                new DBFieldInfo("F_PaidDateFedTax", "D"),
                                new DBFieldInfo("F_PaidDateStateTax", "D"),
                                new DBFieldInfo("F_PaidDateOption1", "D"),
                                new DBFieldInfo("F_PaidDateOption2", "D"),
                                new DBFieldInfo("F_PaidDateOption3", "D"),
                                new DBFieldInfo("F_PaidDateOption4", "D"),
                                new DBFieldInfo("F_CheckNoNetSalary", "N20"),
                                new DBFieldInfo("F_CheckNoFedTax", "N20"),
                                new DBFieldInfo("F_CheckNoStateTax", "N20"),
                                new DBFieldInfo("F_CheckNoOption1", "N20"),
                                new DBFieldInfo("F_CheckNoOption2", "N20"),
                                new DBFieldInfo("F_CheckNoOption3", "N20"),
                                new DBFieldInfo("F_CheckNoOption4", "N20"),
                                new DBFieldInfo("F_PayableAmount1", "F"),
                                new DBFieldInfo("F_PayableAmount2", "F"),
                                new DBFieldInfo("F_AdditionPayable1", "N100"),
                                new DBFieldInfo("F_AdditionPayable2", "N100"),
                                new DBFieldInfo("F_Payable1Entity", "I"),
                                new DBFieldInfo("F_Payable2Entity", "I"),
                                new DBFieldInfo("F_PaidAmtPayable1", "F"),
                                new DBFieldInfo("F_PaidAmtPayable2", "F"),
                                new DBFieldInfo("F_PaidDatePayable1", "D"),
                                new DBFieldInfo("F_PaidDatePayable2", "D"),
                                new DBFieldInfo("F_CheckNoPayable1", "N20"),
                                new DBFieldInfo("F_CheckNoPayable2", "N20"),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_TaxPayableGLNO", "N10"),
                                new DBFieldInfo("F_VoidInputID", "N10"),
                                new DBFieldInfo("F_VoidInputDate", "T")
                            }
                        },
                        { "T_PAYROLLDEPART",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_BRANCH","N3",true),
                                new DBFieldInfo("F_Department", "N100",true),
                                new DBFieldInfo("F_ACD4Salary", "N20",true),
                                new DBFieldInfo("F_ACD4PRTax", "N20",true),
                                new DBFieldInfo("F_ACD4ExpOption1", "N20",true),
                                new DBFieldInfo("F_ACD4ExpOption2", "N20",true),
                                new DBFieldInfo("F_ACD4ExpOption3", "N20",true),
                                new DBFieldInfo("F_ACD4ExpOption4", "N20",true),
                                new DBFieldInfo("F_ACD4ExpOption5", "N20",true)
                            }
                        },
                        { "T_PAYROLLEXPDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_PayrollID", "I",true),
                                new DBFieldInfo("F_Seq", "I",true),
                                new DBFieldInfo("F_DepartmentID", "I",true),
                                new DBFieldInfo("F_GrossAmt", "F"),
                                new DBFieldInfo("F_FedPRTaxAmt", "F"),
                                new DBFieldInfo("F_StePRTaxAmt", "F"),
                                new DBFieldInfo("F_ExpOption1Amt", "F"),
                                new DBFieldInfo("F_ExpOption2Amt", "F"),
                                new DBFieldInfo("F_ExpOption3Amt", "F"),
                                new DBFieldInfo("F_ExpOption4Amt", "F"),
                                new DBFieldInfo("F_ExpOption5Amt", "F"),
                                new DBFieldInfo("F_DepartmentName", "N100"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_SalaryGLNO", "N10"),
                                new DBFieldInfo("F_PRTaxGLNO", "N10"),
                                new DBFieldInfo("F_ExpOption1GLNO", "N10"),
                                new DBFieldInfo("F_ExpOption2GLNO", "N10"),
                                new DBFieldInfo("F_ExpOption3GLNO", "N10"),
                                new DBFieldInfo("F_ExpOption4GLNO", "N10")
                            }
                        },
                        { "T_PAYROLLSETUP",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_ACD4PRtaxPayable", "N20",true),
                                new DBFieldInfo("F_AdditionOption1", "N100"),
                                new DBFieldInfo("F_AdditionOption2", "N100"),
                                new DBFieldInfo("F_AdditionOption3", "N100"),
                                new DBFieldInfo("F_AdditionOption4", "N100"),
                                new DBFieldInfo("F_AdditionOption5", "N100"),
                                new DBFieldInfo("F_Entity4Salary", "I"),
                                new DBFieldInfo("F_Entity4FedPRTax", "I",true),
                                new DBFieldInfo("F_Entity4StePRTax", "I",true),
                                new DBFieldInfo("F_Entity4Option1", "I",true),
                                new DBFieldInfo("F_Entity4Option2", "I",true),
                                new DBFieldInfo("F_Entity4Option3", "I",true),
                                new DBFieldInfo("F_Entity4Option4", "I",true),
                                new DBFieldInfo("F_Entity4Option5", "I",true),
                                new DBFieldInfo("F_AdditionPayable1", "N100"),
                                new DBFieldInfo("F_AdditionPayable2", "N100"),
                                new DBFieldInfo("F_Entity4Payable1", "I",true),
                                new DBFieldInfo("F_Entity4Payable2", "I",true)
                            }
                        },
                        { "T_PICKUPINFO",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I",true),
                                new DBFieldInfo("F_TBNAME", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_TRUCKINGCO", "N50"),
                                new DBFieldInfo("F_TRUCKINGADDR", "N200"),
                                new DBFieldInfo("F_PICKUPREF", "N20"),
                                new DBFieldInfo("F_PICKUPDATE", "N20"),
                                new DBFieldInfo("F_PICKUPAT", "N50"),
                                new DBFieldInfo("F_PICKUPADDR", "N200"),
                                new DBFieldInfo("F_DELIVERYREF", "N20"),
                                new DBFieldInfo("F_DELIVERYDATE", "N20"),
                                new DBFieldInfo("F_DELIVERYTO", "N50"),
                                new DBFieldInfo("F_DELIVERYADDR", "N200"),
                                new DBFieldInfo("F_BILLTO", "N50"),
                                new DBFieldInfo("F_BILLADDR", "N200"),
                                new DBFieldInfo("F_REMARK", "N2000"),
                                new DBFieldInfo("F_APPOINTMENT", "N200"),
                                new DBFieldInfo("F_APPOINTMENTDATE", "N20")
                            }
                        },
                        { "T_RateBuy",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CarrierID", "I"),
                                new DBFieldInfo("F_AirOcean", "N1"),
                                new DBFieldInfo("F_CarrierName", "N50"),
                                new DBFieldInfo("F_CarrierCode", "N4",true),
                                new DBFieldInfo("F_GroupCode", "N5"),
                                new DBFieldInfo("F_OriginCode", "N5"),
                                new DBFieldInfo("F_DestCode", "N5"),
                                new DBFieldInfo("F_TransCode", "N5"),
                                new DBFieldInfo("F_Routing", "N10"),
                                new DBFieldInfo("F_Transit", "N10"),
                                new DBFieldInfo("F_Note", "N30"),
                                new DBFieldInfo("F_SpotRate", "N1"),
                                new DBFieldInfo("F_SpotNo", "N20"),
                                new DBFieldInfo("F_Effective", "D"),
                                new DBFieldInfo("F_Expire", "D"),
                                new DBFieldInfo("F_SizeUnit", "N3"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_Size0", "N4"),
                                new DBFieldInfo("F_BRate0", "F"),
                                new DBFieldInfo("F_Size1", "N4"),
                                new DBFieldInfo("F_BRate1", "F"),
                                new DBFieldInfo("F_Size2", "N4"),
                                new DBFieldInfo("F_BRate2", "F"),
                                new DBFieldInfo("F_Size3", "N4"),
                                new DBFieldInfo("F_BRate3", "F"),
                                new DBFieldInfo("F_Size4", "N4"),
                                new DBFieldInfo("F_BRate4", "F"),
                                new DBFieldInfo("F_Size5", "N4"),
                                new DBFieldInfo("F_BRate5", "F"),
                                new DBFieldInfo("F_Size6", "N4"),
                                new DBFieldInfo("F_BRate6", "F"),
                                new DBFieldInfo("F_Size7", "N4"),
                                new DBFieldInfo("F_BRate7", "F"),
                                new DBFieldInfo("F_Size8", "N4"),
                                new DBFieldInfo("F_BRate8", "F"),
                                new DBFieldInfo("F_User", "N10"),
                                new DBFieldInfo("F_Date", "D")
                            }
                        },
                        { "T_RateOther",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CustomerID", "I",true),
                                new DBFieldInfo("F_AirOcean", "N1"),
                                new DBFieldInfo("F_PreCollect", "N1"),
                                new DBFieldInfo("F_ChargeCode", "N15"),
                                new DBFieldInfo("F_Description", "N30"),
                                new DBFieldInfo("F_Minimum", "F"),
                                new DBFieldInfo("F_Rate", "F"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_Unit", "N10"),
                                new DBFieldInfo("F_Remark", "N50"),
                                new DBFieldInfo("F_User", "N10"),
                                new DBFieldInfo("F_Date", "D")
                            }
                        },
                        { "T_RateSell",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_BuyRateID", "I"),
                                new DBFieldInfo("F_CustomerID", "I",true),
                                new DBFieldInfo("F_ARate0", "F"),
                                new DBFieldInfo("F_CRate0", "F"),
                                new DBFieldInfo("F_ARate1", "F"),
                                new DBFieldInfo("F_CRate1", "F"),
                                new DBFieldInfo("F_ARate2", "F"),
                                new DBFieldInfo("F_CRate2", "F"),
                                new DBFieldInfo("F_ARate3", "F"),
                                new DBFieldInfo("F_CRate3", "F"),
                                new DBFieldInfo("F_ARate4", "F"),
                                new DBFieldInfo("F_CRate4", "F"),
                                new DBFieldInfo("F_ARate5", "F"),
                                new DBFieldInfo("F_CRate5", "F"),
                                new DBFieldInfo("F_ARate6", "F"),
                                new DBFieldInfo("F_CRate6", "F"),
                                new DBFieldInfo("F_ARate7", "F"),
                                new DBFieldInfo("F_CRate7", "F"),
                                new DBFieldInfo("F_ARate8", "F"),
                                new DBFieldInfo("F_CRate8", "F"),
                                new DBFieldInfo("F_Remark", "N50"),
                                new DBFieldInfo("F_User", "N10"),
                                new DBFieldInfo("F_Date", "D")
                            }
                        },
                        { "T_RCRDBDETAIL",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_RCRDBHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_OCRDBHDID", "I",true)
                            }
                        },
                        { "T_RINVODETAIL",
                            new List<DBFieldInfo>
                            {
                            }
                        },
                        { "T_RINVOHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_OINVOHDID", "I",true)
                            }
                        },
                        #endregion
                        #region : S
                        { "T_SECURITYCONTROL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Iden", "IP"),
                                new DBFieldInfo("F_Desc", "N50"),
                                new DBFieldInfo("F_Name", "N30"),
                                new DBFieldInfo("F_TaskID", "I"),
                                new DBFieldInfo("F_Flag", "N1")
                            }
                        },
                        { "T_SECURITYGRANT",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_GroupID", "I"),
                                new DBFieldInfo("F_TaskID", "I"),
                                new DBFieldInfo("F_AttrRead", "N1"),
                                new DBFieldInfo("F_AttrAdd", "N1"),
                                new DBFieldInfo("F_AttrEdit", "N1"),
                                new DBFieldInfo("F_AttrDel", "N1")
                            }
                        },
                        { "T_SECURITYGROUP",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_Iden", "IP"),
                                new DBFieldInfo("F_Name", "N10"),
                                new DBFieldInfo("F_Desc", "N50"),
                                new DBFieldInfo("F_Flag", "N1")
                            }
                        },
                        { "T_SECURITYSTATE",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_GroupID", "I"),
                                new DBFieldInfo("F_ControlID", "I"),
                                new DBFieldInfo("F_TaskID", "I"),
                                new DBFieldInfo("F_CtrlFlag", "N1")
                            }
                        },
                        { "T_SECURITYTASK",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Desc", "N100"),
                                new DBFieldInfo("F_GridForm", "I"),
                                new DBFieldInfo("F_DetailForm", "N30"),
                                new DBFieldInfo("F_MenuName", "N50")
                            }
                        },
                        { "T_SETTINGS",
                            new List<DBFieldInfo>()
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_NAME", "N30", true),
                                new DBFieldInfo("F_VALUE", "N1000"),
                                new DBFieldInfo("F_RELNAME", "N50"),
                                new DBFieldInfo("F_RELID", "I")
                            }
                        },
                        { "T_SLIPDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_HDID", "I",true),
                                new DBFieldInfo("F_STBName", "N20",true),
                                new DBFieldInfo("F_STBID", "I",true),
                                new DBFieldInfo("F_Seq", "I"),
                                new DBFieldInfo("F_ComType", "N1",true),
                                new DBFieldInfo("F_ComID", "I",true),
                                new DBFieldInfo("F_ComName", "N50"),
                                new DBFieldInfo("F_GLNo", "N10",true),
                                new DBFieldInfo("F_SubCode", "N20",true),
                                new DBFieldInfo("F_Debit", "E16,4"),
                                new DBFieldInfo("F_Credit", "E16,4"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_ExRate", "E8,6"),
                                new DBFieldInfo("F_FDebit", "E16,4"),
                                new DBFieldInfo("F_FCredit", "E16,4"),
                                new DBFieldInfo("F_MDesc", "U100")
                            }
                        },
                        { "T_SLIPDETAILB",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_HDID", "I",true),
                                new DBFieldInfo("F_STBName", "N20",true),
                                new DBFieldInfo("F_STBID", "I",true),
                                new DBFieldInfo("F_Seq", "I"),
                                new DBFieldInfo("F_ComType", "N1",true),
                                new DBFieldInfo("F_ComID", "I",true),
                                new DBFieldInfo("F_ComName", "N50"),
                                new DBFieldInfo("F_GLNo", "N10",true),
                                new DBFieldInfo("F_SubCode", "N20",true),
                                new DBFieldInfo("F_Debit", "E16,4"),
                                new DBFieldInfo("F_Credit", "E16,4"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_ExRate", "E8,6"),
                                new DBFieldInfo("F_FDebit", "E16,4"),
                                new DBFieldInfo("F_FCredit", "E16,4"),
                                new DBFieldInfo("F_MDesc", "U100")
                            }
                        },
                        { "T_SLIPHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Type", "N2",true),
                                new DBFieldInfo("F_Branch", "N3",true),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_SeqNo", "I"),
                                new DBFieldInfo("F_GDebit", "E16,4"),
                                new DBFieldInfo("F_GCredit", "E16,4"),
                                new DBFieldInfo("F_MDesc", "U250"),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_TBType", "I",true),
                                new DBFieldInfo("F_U1ID", "N15"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N15"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_Memo", "U600")
                            }
                        },
                        { "T_SLIPHDB",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_OID", "I",true),
                                new DBFieldInfo("F_Type", "N2",true),
                                new DBFieldInfo("F_Branch", "N3",true),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_SeqNo", "I"),
                                new DBFieldInfo("F_GDebit", "E16,4"),
                                new DBFieldInfo("F_GCredit", "E16,4"),
                                new DBFieldInfo("F_MDesc", "U250"),
                                new DBFieldInfo("F_TBName", "N20",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_TBType", "I",true),
                                new DBFieldInfo("F_U1ID", "N15"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N15"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_key", "N30",true),
                                new DBFieldInfo("F_FLAG", "I",true)
                            }
                        },
                        { "T_SQLERRORLOG",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_PostDate", "D"),
                                new DBFieldInfo("F_UserID", "N10"),
                                new DBFieldInfo("F_Description", "N1000")
                            }
                        },
            #endregion

                        { "T_TaxReturnDetail",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_HDID", "I",true),
                                new DBFieldInfo("F_TBName", "N10",true),
                                new DBFieldInfo("F_TBID", "I",true),
                                new DBFieldInfo("F_Type", "N10"),
                                new DBFieldInfo("F_Amount", "F")
                            }
                        },
                        { "T_TaxReturnHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_RefNo", "N20"),
                                new DBFieldInfo("F_PostDate", "D",true),
                                new DBFieldInfo("F_TaxAgency", "I",true),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T",true),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_TaxAccountType", "N30"),
                                new DBFieldInfo("F_Currency", "N3"),
                                new DBFieldInfo("F_TaxAmount", "F"),
                                new DBFieldInfo("F_TaxPaidAmount", "F"),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_VoidInputID", "N10"),
                                new DBFieldInfo("F_VoidInputDate", "T"),
                                new DBFieldInfo("F_Branch", "N3")
                            }
                        },
                        { "T_TEMPLATEDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_Type", "I"),
                                new DBFieldInfo("F_BillingCode", "N30"),
                                new DBFieldInfo("F_Description", "L100"),
                                new DBFieldInfo("F_PrefixTemplate", "N5")
                            }
                        },
                        { "T_TEMPLATEHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_PrefixTemplate", "N5",true),
                                new DBFieldInfo("F_Inactive", "N1"),
                                new DBFieldInfo("F_InactiveDate", "D"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_TLOADDETAIL",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TLoadHDID", "I",true),
                                new DBFieldInfo("F_Stop", "I"),
                                new DBFieldInfo("F_OIHBLID", "I"),
                                new DBFieldInfo("F_PKGS", "F"),
                                new DBFieldInfo("F_CBM", "F"),
                                new DBFieldInfo("F_LBS", "F"),
                                new DBFieldInfo("F_ETA", "D")
                            }
                        },
                        { "T_TLOADHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_LoadNo", "N20",true),
                                new DBFieldInfo("F_TruckingCo", "I"),
                                new DBFieldInfo("F_Warehouse", "I"),
                                new DBFieldInfo("F_TruckingETD", "D"),
                                new DBFieldInfo("F_Amount", "F"),
                                new DBFieldInfo("F_PostDate", "D"),
                                new DBFieldInfo("F_Remark", "N1000"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_TRUKDETAIL1",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TRUKHDID", "I"),
                                new DBFieldInfo("F_INVENHDID", "I"),
                                new DBFieldInfo("F_INVENDTID", "I"),
                                new DBFieldInfo("F_Pcs", "I"),
                                new DBFieldInfo("F_PUnit", "N10"),
                                new DBFieldInfo("F_Weight", "F"),
                                new DBFieldInfo("F_HM", "N1"),
                                new DBFieldInfo("F_Description", "N50"),
                                new DBFieldInfo("F_NMFCNo", "N20"),
                                new DBFieldInfo("F_Class", "N10")
                            }
                        },
                        { "T_TRUKDETAIL2",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_TRUKHDID", "I"),
                                new DBFieldInfo("F_INVENHDID", "I"),
                                new DBFieldInfo("F_PONO", "N20"),
                                new DBFieldInfo("F_Pcs", "I"),
                                new DBFieldInfo("F_Weight", "F"),
                                new DBFieldInfo("F_Pallet", "N1"),
                                new DBFieldInfo("F_AShipper", "N50")
                            }
                        },
                        { "T_TRUKHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_BookID", "I",true),
                                new DBFieldInfo("F_TruckBL", "N20"),
                                new DBFieldInfo("F_PostDate", "D"),
                                new DBFieldInfo("F_BOOKNO", "N20"),
                                new DBFieldInfo("F_Shipper", "I"),
                                new DBFieldInfo("F_Customer", "I"),
                                new DBFieldInfo("F_Notify", "I"),
                                new DBFieldInfo("F_Carrier", "I"),
                                new DBFieldInfo("F_LoadNo", "N20"),
                                new DBFieldInfo("F_RefNo", "N20"),
                                new DBFieldInfo("F_TrailerNo", "N20"),
                                new DBFieldInfo("F_SealNo", "N20"),
                                new DBFieldInfo("F_SCACNo", "N20"),
                                new DBFieldInfo("F_ProNo", "N20"),
                                new DBFieldInfo("F_ChargeType", "N1"),
                                new DBFieldInfo("F_MasterFlag", "N1"),
                                new DBFieldInfo("F_Remark", "N400"),
                                new DBFieldInfo("F_CodAmt", "F"),
                                new DBFieldInfo("F_Pcs", "I"),
                                new DBFieldInfo("F_Weight", "F"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T")
                            }
                        },
                        { "T_USER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_UserID", "N10P",true),
                                new DBFieldInfo("F_Password", "N11"),
                                new DBFieldInfo("F_UserName", "N30"),
                                new DBFieldInfo("F_EMail", "N100"),
                                new DBFieldInfo("F_GroupID", "I"),
                                new DBFieldInfo("F_LoginFlag", "N1"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_PHONE", "N20"),
                                new DBFieldInfo("F_FAX", "N20"),
                                new DBFieldInfo("F_InactiveDate", "D"),
                                new DBFieldInfo("F_EncSubscriptionID", "N200"),
                                new DBFieldInfo("F_SubscriptionID", "N200")
                            }
                        },
                        { "T_WEB_CENTER",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CENTER_NO", "N10"),
                                new DBFieldInfo("F_CENTER_TYPE", "N1"),
                                new DBFieldInfo("F_NAME", "N100"),
                                new DBFieldInfo("F_ADDRESS", "N500"),
                                new DBFieldInfo("F_CITY", "N50"),
                                new DBFieldInfo("F_STATE", "N2"),
                                new DBFieldInfo("F_ZIP", "N10"),
                                new DBFieldInfo("F_PHONE", "N12"),
                                new DBFieldInfo("F_FAX", "N12"),
                                new DBFieldInfo("F_BOXCHARGE", "F"),
                                new DBFieldInfo("F_LABELCHARGE", "F"),
                                new DBFieldInfo("F_PICKCHARGE", "F"),
                                new DBFieldInfo("F_DOCCHARGE", "F"),
                                new DBFieldInfo("F_REMARK", "N200"),
                                new DBFieldInfo("F_PASSWORD", "N20"),
                                new DBFieldInfo("F_ATTENTION", "N50"),
                                new DBFieldInfo("F_CUSTOMER", "I"),
                                new DBFieldInfo("F_PimsLinkID", "I")
                            }
                        },
                        { "T_WITEM",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CENTER_NO", "N10",true),
                                new DBFieldInfo("F_ITEMNO", "N30",true),
                                new DBFieldInfo("F_ITEMDESCRIPTION", "N50"),
                                new DBFieldInfo("F_PCSPERBOX", "F"),
                                new DBFieldInfo("F_WTPERBOX", "F"),
                                new DBFieldInfo("F_LENGTH", "F"),
                                new DBFieldInfo("F_HEIGHT", "F"),
                                new DBFieldInfo("F_WIDTH", "F"),
                                new DBFieldInfo("F_CFTPERBOX", "F"),
                                new DBFieldInfo("F_UPCCODE", "N30",true),
                                new DBFieldInfo("F_DLOCATION", "N10"),
                                new DBFieldInfo("F_InvenBalance", "F"),
                                new DBFieldInfo("F_BOXUNIT", "N10"),
                                new DBFieldInfo("F_PimsLinkID", "I")
                            }
                        },
                        { "T_WLOCATION",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_LOCATION", "N10"),
                                new DBFieldInfo("F_ZONE", "N3"),
                                new DBFieldInfo("F_ROW", "N2"),
                                new DBFieldInfo("F_LEVEL", "N2"),
                                new DBFieldInfo("F_STORAGE", "N1")
                            }
                        },
                        { "T_WRECEIVEHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CENTER_NO", "N10",true),
                                new DBFieldInfo("F_PONO", "N30"),
                                new DBFieldInfo("F_RECEIVENO", "N20"),
                                new DBFieldInfo("F_RECEIVEDATE", "D"),
                                new DBFieldInfo("F_VENDOR", "N30"),
                                new DBFieldInfo("F_TRUCKER", "N30"),
                                new DBFieldInfo("F_REMARK", "N1000"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_PALLETREMARK", "N20"),
                                new DBFieldInfo("F_OrderDate", "D"),
                                new DBFieldInfo("F_EXPDATE", "D"),
                                new DBFieldInfo("F_Status", "I"),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_PimsLinkID", "I"),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_CloseDate", "D"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3")
                            }
                        },
                        { "T_WRECEIVEITEM",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_WRECEIVEHD", "I",true),
                                new DBFieldInfo("F_ITEMNO", "N30",true),
                                new DBFieldInfo("F_ORDQTY", "F"),
                                new DBFieldInfo("F_QTY", "F"),
                                new DBFieldInfo("F_LOCATION", "N10"),
                                new DBFieldInfo("F_BOX", "F"),
                                new DBFieldInfo("F_BOXUNIT", "N10"),
                                new DBFieldInfo("F_ITEMPONO", "N20"),
                                new DBFieldInfo("F_PimsLinkID", "I")
                            }
                        },
                        { "T_WSHIPHD",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_CENTER_NO", "N10",true),
                                new DBFieldInfo("F_SHIPTO_NO", "N10"),
                                new DBFieldInfo("F_PONO", "N30"),
                                new DBFieldInfo("F_INVONO", "N30"),
                                new DBFieldInfo("F_SHIPDATE", "D"),
                                new DBFieldInfo("F_TRUCKER", "N30"),
                                new DBFieldInfo("F_BOXCHARGE", "F"),
                                new DBFieldInfo("F_LABELCHARGE", "F"),
                                new DBFieldInfo("F_PICKCHARGE", "F"),
                                new DBFieldInfo("F_DOCCHARGE", "F"),
                                new DBFieldInfo("F_PALLETCHARGE", "F"),
                                new DBFieldInfo("F_TOTQTY", "F"),
                                new DBFieldInfo("F_TOTBOX", "F"),
                                new DBFieldInfo("F_REMARK", "N1000"),
                                new DBFieldInfo("F_BRANCH", "N3"),
                                new DBFieldInfo("F_SHIPNO", "N20",true),
                                new DBFieldInfo("F_STATUS", "N1"),
                                new DBFieldInfo("F_ORDERDATE", "D"),
                                new DBFieldInfo("F_SHIPTPONO", "N30"),
                                new DBFieldInfo("F_FileClosed", "N1"),
                                new DBFieldInfo("F_ClosedBy", "N10"),
                                new DBFieldInfo("F_PALLETREMARK", "N20"),
                                new DBFieldInfo("F_U1ID", "N10"),
                                new DBFieldInfo("F_U1Date", "T"),
                                new DBFieldInfo("F_U2ID", "N10"),
                                new DBFieldInfo("F_U2Date", "T"),
                                new DBFieldInfo("F_PimsLinkID", "I"),
                                new DBFieldInfo("F_Void", "I"),
                                new DBFieldInfo("F_CloseDate", "D"),
                                new DBFieldInfo("F_StatusInvo", "N3"),
                                new DBFieldInfo("F_StatusBill", "N3")
                            }
                        },
                        { "T_WSHIPITEM",
                            new List<DBFieldInfo>
                            {
                                new DBFieldInfo("F_ID", "I"),
                                new DBFieldInfo("F_WSHIPHD", "I",true),
                                new DBFieldInfo("F_ITEMNO", "N30",true),
                                new DBFieldInfo("F_QTY", "F"),
                                new DBFieldInfo("F_LOCATION", "N10"),
                                new DBFieldInfo("F_BOX", "F"),
                                new DBFieldInfo("F_SHIPQTY", "F"),
                                new DBFieldInfo("F_SHIPBOX", "F"),
                                new DBFieldInfo("F_ITEMREMARK", "N20"),
                                new DBFieldInfo("F_PimsLinkID", "I")
                            }
                        }
        };

        public static Dictionary<string, string> DicViewInfo = new Dictionary<string, string>
        {
            //STOTAL = 12
            //ReDim Dbary(2, STOTAL)
            //Dbary(0, 0) = "F_InvDate"
            //Dbary(0, 1) = "F_InvNo"
            //Dbary(0, 2) = "F_InvAmt"
            //Dbary(0, 3) = "F_PaidAmt"
            //Dbary(0, 4) = "F_Billto"
            //Dbary(0, 5) = "F_TBID"
            //Dbary(0, 6) = "F_TBName"
            //Dbary(0, 7) = "F_STBName"
            //Dbary(0, 8) = "F_GLNo"
            //Dbary(0, 9) = "F_Description"
            //Dbary(0, 10) = "F_BLNo"
            //Dbary(0, 11) = "F_REFNO"
            { "V_DEPOSITJ",
                @"
SELECT
    T_APHD.F_PostDate, F_InvoiceNo, F_InvoiceAmt, F_PaidAmt, F_PayTo, T_APHD.F_ID, 'T_APHD' AS F_TBName, COALESCE(F_TBName,'') As F_STBName, '' As F_GLNo, '' As F_Description, 
    CASE T_APHD.F_TBName WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_HBLNo WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_HawbNo 
    WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_HBLNo WHEN 'T_AOHMAIN' THEN T_AOHMAIN.F_HawbNo  END As F_HBLNo, 
    CASE T_APHD.F_TBName WHEN 'T_OIMMAIN' THEN tOIM.F_RefNo WHEN 'T_AIMMAIN' THEN tAIM.F_RefNo WHEN 'T_OIHMAIN' THEN tOIHM.F_RefNo WHEN 'T_AIHMAIN' THEN tAIHM.F_RefNo 
    WHEN 'T_GENMAIN' THEN TGEN.F_REFNO WHEN 'T_OOMMAIN' THEN tOOM.F_RefNo WHEN 'T_AOMMAIN' THEN tAOM.F_RefNo WHEN 'T_OOHMAIN' THEN tOOHM.F_RefNo WHEN 'T_AOHMAIN' THEN tAOHM.F_RefNo END As F_REFNo 
FROM T_APHD LEFT JOIN T_OIHMAIN ON T_OIHMAIN.F_ID = T_APHD.F_TBID AND T_APHD.F_TBNAME = 'T_OIHMAIN' 
LEFT JOIN T_OIMMAIN AS tOIHM ON T_OIHMAIN.F_OIMBLID = tOIHM.F_ID 
LEFT JOIN T_AIHMAIN ON T_AIHMAIN.F_ID = T_APHD.F_TBID AND T_APHD.F_TBNAME = 'T_AIHMAIN' 
LEFT JOIN T_AIMMAIN AS tAIHM ON T_AIHMAIN.F_AIMBLID = tAIHM.F_ID 
LEFT JOIN T_OOHMAIN ON T_OOHMAIN.F_ID = T_APHD.F_TBID AND T_APHD.F_TBNAME = 'T_OOHMAIN' 
LEFT JOIN T_OOMMAIN AS tOOHM ON T_OOHMAIN.F_OOMBLID = tOOHM.F_ID 
LEFT JOIN T_AOHMAIN ON T_AOHMAIN.F_ID = T_APHD.F_TBID AND T_APHD.F_TBNAME = 'T_AOHMAIN' 
LEFT JOIN T_AOMMAIN AS tAOHM ON T_AOHMAIN.F_AOMBLID = tAOHM.F_ID 
LEFT JOIN T_OIMMAIN AS tOIM ON tOIM.f_id = t_aphd.f_tbid AND t_aphd.f_tbname = 'T_OIMMAIN' 
LEFT JOIN T_AIMMAIN AS tAIM ON tAIM.f_id = t_aphd.f_tbid AND t_aphd.f_tbname = 'T_AIMMAIN' 
LEFT JOIN T_OOMMAIN AS tOOM ON tOOM.f_id = t_aphd.f_tbid AND t_aphd.f_tbname = 'T_OOMMAIN' 
LEFT JOIN T_GENMAIN AS TGEN ON tgen.f_id = t_aphd.f_tbid and t_aphd.f_tbname = 'T_GENMAIN' 
LEFT JOIN T_AOMMAIN AS tAOM ON tAOM.f_id = t_aphd.f_tbid AND t_aphd.f_tbname = 'T_AOMMAIN' 

Union All 
SELECT 
    T_CRDBHD.F_PostDate, F_CRDBNo, F_Total, F_PaidAmt, T_CRDBHD.F_Agent, T_CRDBHD.F_ID, 'T_CRDBHD' As F_TBName, COALESCE(F_TBName,'') As F_STBName, '' As F_GLNo, '' As F_Description, 
    CASE T_CRDBHD.f_TBNAME WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_HBLNO WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_HAWBNO 
    WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_HBLNO WHEN 'T_AOHMAIN' THEN T_AOHMAIN.F_HAWBNO END As F_HBLNo, 
    CASE T_CRDBHD.f_TBNAME WHEN 'T_OIMMAIN' THEN tOIM.F_REFNO WHEN 'T_AIMMAIN' THEN tAIM.F_REFNO WHEN 'T_OIHMAIN' THEN tOIHM.F_REFNO WHEN 'T_AIHMAIN' THEN tAIHM.F_REFNO 
    WHEN 'T_GENMAIN' THEN TGEN.F_REFNO WHEN 'T_OOMMAIN' THEN tOOM.F_REFNO WHEN 'T_AOMMAIN' THEN tAOM.F_REFNO WHEN 'T_OOHMAIN' THEN tOOHM.F_REFNO WHEN 'T_AOHMAIN' THEN tAOHM.F_REFNO END As F_REFNo 
FROM T_CRDBHD 
LEFT JOIN T_OIHMAIN ON T_OIHMAIN.F_ID = T_CRDBHD.F_TBID AND T_CRDBHD.F_TBNAME = 'T_OIHMAIN' 
LEFT JOIN T_OIMMAIN AS tOIHM ON T_OIHMAIN.F_OIMBLID = tOIHM.F_ID 
LEFT JOIN T_AIHMAIN ON T_AIHMAIN.F_ID = T_CRDBHD.F_TBID AND T_CRDBHD.F_TBNAME = 'T_AIHMAIN' 
LEFT JOIN T_AIMMAIN AS tAIHM ON T_AIHMAIN.F_AIMBLID = tAIHM.F_ID 
LEFT JOIN T_OOHMAIN ON T_OOHMAIN.F_ID = T_CRDBHD.F_TBID AND T_CRDBHD.F_TBNAME = 'T_OOHMAIN' 
LEFT JOIN T_OOMMAIN AS tOOHM ON T_OOHMAIN.F_OOMBLID = tOOHM.F_ID 
LEFT JOIN T_AOHMAIN ON T_AOHMAIN.F_ID = T_CRDBHD.F_TBID AND T_CRDBHD.F_TBNAME = 'T_AOHMAIN' 
LEFT JOIN T_AOMMAIN AS tAOHM ON T_AOHMAIN.F_AOMBLID = tAOHM.F_ID 
LEFT JOIN T_OIMMAIN AS tOIM ON tOIM.F_ID = T_CRDBHD.F_TBID AND T_CRDBHD.F_TBNAME = 'T_OIMMAIN' 
LEFT JOIN T_AIMMAIN AS tAIM ON tAIM.F_ID = T_CRDBHD.F_TBID AND T_CRDBHD.F_TBNAME = 'T_AIMMAIN' 
LEFT JOIN T_OOMMAIN AS tOOM ON tOOM.F_ID = T_CRDBHD.F_TBID AND T_CRDBHD.F_TBNAME = 'T_OOMMAIN' 
LEFT JOIN T_GENMAIN AS TGEN ON tgen.f_id = T_CRDBHD.f_tbid and t_CRDBHD.f_tbname = 'T_GENMAIN' 
LEFT JOIN T_AOMMAIN AS tAOM ON tAOM.F_ID = T_CRDBHD.F_TBID AND T_CRDBHD.F_TBNAME = 'T_AOMMAIN' 

Union All 
SELECT 
    T_INVOHD.F_PostDate, F_InvoiceNo, F_InvoiceAmt, F_PaidAmt, F_BillTo, T_INVOHD.F_ID, 'T_INVOHD' As F_TBName, COALESCE(F_TBName,'') As F_STBName, '' As F_GLNo, '' As F_Description, 
    CASE T_INVOHD.F_TBNAME WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_HBLNO WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_HAWBNO 
    WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_HBLNO WHEN 'T_AOHMAIN' THEN T_AOHMAIN.F_HAWBNO END As F_HBLNo, 
    CASE T_INVOHD.F_TBNAME WHEN 'T_OIMMAIN' THEN tOIM.F_REFNO WHEN 'T_AIMMAIN' THEN tAIM.F_REFNO WHEN 'T_OIHMAIN' THEN tOIHM.F_REFNO WHEN 'T_AIHMAIN' THEN tAIHM.F_REFNO 
    WHEN 'T_GENMAIN' THEN TGEN.F_REFNO WHEN 'T_OOMMAIN' THEN tOOM.F_REFNO WHEN 'T_AOMMAIN' THEN tAOM.F_REFNO WHEN 'T_OOHMAIN' THEN tOOHM.F_REFNO WHEN 'T_AOHMAIN' THEN tAOHM.F_REFNO END As F_REFNo 
From T_INVOHD 
LEFT JOIN T_OIHMAIN ON T_OIHMAIN.F_ID = T_INVOHD.F_TBID AND T_INVOHD.F_TBNAME = 'T_OIHMAIN' 
LEFT JOIN T_OIMMAIN AS tOIHM ON T_OIHMAIN.F_OIMBLID = tOIHM.F_ID 
LEFT JOIN T_AIHMAIN ON T_AIHMAIN.F_ID = T_INVOHD.F_TBID AND T_INVOHD.F_TBNAME = 'T_AIHMAIN' 
LEFT JOIN T_AIMMAIN AS tAIHM ON T_AIHMAIN.F_AIMBLID = tAIHM.F_ID 
LEFT JOIN T_OOHMAIN ON T_OOHMAIN.F_ID = T_INVOHD.F_TBID AND T_INVOHD.F_TBNAME = 'T_OOHMAIN' 
LEFT JOIN T_OOMMAIN AS tOOHM ON T_OOHMAIN.F_OOMBLID = tOOHM.F_ID 
LEFT JOIN T_AOHMAIN ON T_AOHMAIN.F_ID = T_INVOHD.F_TBID AND T_INVOHD.F_TBNAME = 'T_AOHMAIN' 
LEFT JOIN T_AOMMAIN AS tAOHM ON T_AOHMAIN.F_AOMBLID = tAOHM.F_ID 
LEFT JOIN T_OIMMAIN AS tOIM ON tOIM.F_ID = T_INVOHD.F_TBID AND T_INVOHD.F_TBNAME = 'T_OIMMAIN' 
LEFT JOIN T_AIMMAIN AS tAIM ON tAIM.F_ID = T_INVOHD.F_TBID AND  T_INVOHD.F_TBNAME = 'T_AIMMAIN' 
LEFT JOIN T_OOMMAIN AS tOOM ON tOOM.F_ID = T_INVOHD.F_TBID AND T_INVOHD.F_TBNAME = 'T_OOMMAIN' 
LEFT JOIN T_GENMAIN AS TGEN ON tgen.f_id = T_INVOHD.f_tbid and t_INVOHD.f_tbname = 'T_GENMAIN' 
LEFT JOIN T_AOMMAIN AS tAOM ON tAOM.F_ID = T_INVOHD.F_TBID AND  T_INVOHD.F_TBNAME = 'T_AOMMAIN' 
" },
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_AP" ,
                @"
SELECT 
    T1.F_PostDate, SUBSTRING(F_TBName, 3, 3) AS F_Type,
    CASE T1.F_TBName WHEN '' THEN T1.F_APBRANCH WHEN 'T_WSHIPHD' THEN T_WSH.F_BRANCH WHEN 'T_WRECEIVE' THEN T_WRE.F_BRANCH WHEN 'T_GENMAIN' THEN T_GEN.F_BRANCH WHEN 'T_OIMMAIN' THEN T_OIM.F_BRANCH WHEN 'T_OIHMAIN' THEN T_OIHM.F_BRANCH WHEN 'T_OOMMAIN' THEN T_OOM.F_BRANCH WHEN 'T_OOHMAIN' THEN T_OOHM.F_BRANCH WHEN 'T_AIMMAIN' THEN T_AIM.F_BRANCH WHEN 'T_AIHMAIN' THEN T_AIHM.F_BRANCH WHEN 'T_AOMMAIN' THEN T_AOM.F_BRANCH WHEN 'T_AOHMAIN' THEN T_AOHM.F_BRANCH END AS F_BRANCH,
    CASE T1.F_TBName WHEN 'T_WSHIPHD' THEN T_WSH.F_SHIPNO WHEN 'T_WRECEIVE' THEN T_WRE.F_Receiveno WHEN 'T_GENMAIN' THEN T_GEN.F_REFNO WHEN 'T_OIMMAIN' THEN T_OIM.F_RefNo WHEN 'T_OIHMAIN' THEN T_OIHM.F_RefNo WHEN 'T_OOMMAIN' THEN T_OOM.F_RefNo WHEN 'T_OOHMAIN' THEN T_OOHM.F_RefNo WHEN 'T_AIMMAIN' THEN T_AIM.F_RefNo WHEN 'T_AIHMAIN' THEN T_AIHM.F_RefNo WHEN 'T_AOMMAIN' THEN T_AOM.F_RefNo WHEN 'T_AOHMAIN' THEN T_AOHM.F_RefNo END AS F_RefNo,
    CASE T1.F_TBName WHEN '' THEN T1.F_Memo WHEN 'T_WSHIPHD' THEN T_WSH.f_trucker WHEN 'T_WRECEIVE' THEN T_WRE.f_trucker WHEN 'T_GENMAIN' THEN T_GEN.F_HBLNO WHEN 'T_OIMMAIN' THEN T_OIM.F_MBLNo WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_HBLNO WHEN 'T_OOMMAIN' THEN T_OOM.F_MBLNo WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_HBLNO WHEN 'T_AIMMAIN' THEN T_AIM.F_MAWBNo WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_HAWBNo WHEN 'T_AOMMAIN' THEN T_AOM.F_MAWBNo WHEN 'T_AOHMAIN' THEN T_AOHMAIN.F_HAWBNo END AS F_BLNo,
    CASE T1.F_TBName WHEN 'T_WSHIPHD' THEN T_WSH.f_pono WHEN 'T_WRECEIVE' THEN T_WRE.f_pono WHEN 'T_GENMAIN' THEN T_GEN.F_CUSTREFNO WHEN 'T_OIMMAIN' THEN T_OIM.F_AgentRefno WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_ITNO WHEN 'T_OOMMAIN' THEN T_OOM.F_bookingNo WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_EXPREF WHEN 'T_AIMMAIN' THEN T_AIM.F_AGENTREFNO WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_ITNO WHEN 'T_AOMMAIN' THEN T_AOM.F_MAWBNO WHEN 'T_AOHMAIN' THEN T_AOHM.F_MAWBNO  END AS F_SREFNO,
    CASE T1.F_TBName WHEN 'T_WSHIPHD' THEN T_WSH.F_SHIPDATE WHEN 'T_WRECEIVE' THEN T_WRE.F_RECEIVEDATE WHEN 'T_GENMAIN' THEN T1.F_PostDate WHEN 'T_OIMMAIN' THEN CASE WHEN T_OIM.F_FETA <> '' THEN T_OIM.F_FETA ELSE T_OIM.F_ETA END WHEN 'T_OIHMAIN' THEN CASE WHEN T_OIHM.F_FETA <>'' THEN T_OIHM.F_FETA ELSE T_OIHM.F_ETA END WHEN 'T_OOMMAIN' THEN T_OOM.F_ETD WHEN 'T_OOHMAIN' THEN T_OOHM.F_ETD WHEN 'T_AIMMAIN' THEN T_AIM.F_ETA WHEN 'T_AIHMAIN' THEN T_AIHM.F_ETA WHEN 'T_AOMMAIN' THEN T_AOM.F_ETD WHEN 'T_AOHMAIN' THEN T_AOHM.F_ETD END AS F_DEFAULTDATE,
    T1.F_U1Date,T1.F_U1ID,T1.F_InvoiceDate,
    T_Com.F_SName AS F_PayTo, F_Descript,T1.F_CURRENCY, F_InvoiceNo, F_DueDate, F_InvoiceAmt, f_AdvRecAmount+F_PaidAmt as F_PaidAmt, F_PaidAmt as F_RealPaidAmt, T1.F_ID,
    T1.F_Void, T1.F_IsCredit, T1.F_OriginInvId, T1.F_Approved AS F_ApprovedV, T1.F_AppPaidDate AS F_AppPaidDateV, T1.F_PAYGLNO AS F_PAYGLNOV, T_COM.F_ID AS F_PAYTOCOMID
FROM T_APHD AS T1

LEFT JOIN T_OIHMAIN ON T_OIHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OIHMAIN'
LEFT JOIN T_OIMMAIN AS T_OIHM ON T_OIHMAIN.F_OIMBLID = T_OIHM.F_ID
LEFT JOIN T_OIMMAIN AS T_OIM ON T_OIM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OIMMAIN'
LEFT JOIN T_OOHMAIN ON T_OOHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OOHMAIN'
LEFT JOIN T_OOMMAIN AS T_OOHM ON T_OOHMAIN.F_OOMBLID = T_OOHM.F_ID
LEFT JOIN T_OOMMAIN AS T_OOM ON T_OOM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OOMMAIN'
LEFT JOIN T_AIHMAIN ON T_AIHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AIHMAIN'
LEFT JOIN T_AIMMAIN AS T_AIHM ON T_AIHMAIN.F_AIMBLID = T_AIHM.F_ID
LEFT JOIN T_AIMMAIN AS T_AIM ON T_AIM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AIMMAIN'
LEFT JOIN T_AOHMAIN ON T_AOHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AOHMAIN'
LEFT JOIN T_AOMMAIN AS T_AOHM ON T_AOHMAIN.F_AOMBLID = T_AOHM.F_ID
LEFT JOIN T_AOMMAIN AS T_AOM ON T_AOM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AOMMAIN'
LEFT JOIN T_GENMAIN AS T_GEN ON T_GEN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_GENMAIN'
LEFT JOIN T_WRECEIVEHD AS T_WRE ON T_WRE.F_ID = T1.F_TBID AND T1.F_TBName = 'T_WRECEIVE'
LEFT JOIN T_WSHIPHD AS T_WSH ON T_WSH.F_ID = T1.F_TBID AND T1.F_TBName = 'T_WSHIPHD'
LEFT JOIN T_Company AS T_COM ON T1.F_PayTo = T_Com.F_ID
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_INVO" ,
                @"
SELECT
    T1.F_PostDate, SUBSTRING(T1.F_TBName, 3, 3) AS F_Type,
    CASE T1.F_TBName WHEN 'T_STORAGE' THEN T1.F_BRANCH WHEN '' THEN T1.F_BRANCH WHEN 'T_WSHIPHD' THEN T_WSH.F_BRANCH WHEN 'T_WRECEIVE' THEN T_WRE.F_BRANCH WHEN 'T_GENMAIN' THEN T_GEN.F_BRANCH WHEN 'T_OIMMAIN' THEN T_OIM.F_BRANCH WHEN 'T_OIHMAIN' THEN T_OIHM.F_BRANCH WHEN 'T_OOMMAIN' THEN T_OOM.F_BRANCH WHEN 'T_OOHMAIN' THEN T_OOHM.F_BRANCH WHEN 'T_AIMMAIN' THEN T_AIM.F_BRANCH WHEN 'T_AIHMAIN' THEN T_AIHM.F_BRANCH WHEN 'T_AOMMAIN' THEN T_AOM.F_BRANCH WHEN 'T_AOHMAIN' THEN T_AOHM.F_BRANCH END AS F_BRANCH,
    CASE T1.F_TBName WHEN 'T_WSHIPHD' THEN T_WSH.F_SHIPNO WHEN 'T_WRECEIVE' THEN T_WRE.F_Receiveno WHEN 'T_GENMAIN' THEN T_GEN.F_REFNO WHEN 'T_OIMMAIN' THEN T_OIM.F_RefNo WHEN 'T_OIHMAIN' THEN T_OIHM.F_RefNo WHEN 'T_OOMMAIN' THEN T_OOM.F_RefNo WHEN 'T_OOHMAIN' THEN T_OOHM.F_RefNo WHEN 'T_AIMMAIN' THEN T_AIM.F_RefNo WHEN 'T_AIHMAIN' THEN T_AIHM.F_RefNo WHEN 'T_AOMMAIN' THEN T_AOM.F_RefNo WHEN 'T_AOHMAIN' THEN T_AOHM.F_RefNo END AS F_RefNo,
    CASE T1.F_TBName WHEN 'T_STORAGE' THEN AL.F_C1 WHEN '' THEN AL.F_C1 WHEN 'T_WSHIPHD' THEN T_WSH.f_trucker WHEN 'T_WRECEIVE' THEN T_WRE.f_trucker WHEN 'T_GENMAIN' THEN T_GEN.F_HBLNO WHEN 'T_OIMMAIN' THEN T_OIM.F_MBLNo WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_HBLNO WHEN 'T_OOMMAIN' THEN T_OOM.F_MBLNo WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_HBLNO WHEN 'T_AIMMAIN' THEN T_AIM.F_MAWBNo WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_HAWBNo WHEN 'T_AOMMAIN' THEN T_AOM.F_MAWBNo WHEN 'T_AOHMAIN' THEN T_AOHMAIN.F_HAWBNo END AS F_BLNo,
    CASE T1.F_TBName WHEN 'T_WSHIPHD' THEN T_WSH.f_pono WHEN 'T_WRECEIVE' THEN T_WRE.f_pono WHEN 'T_GENMAIN' THEN T_GEN.F_CUSTREFNO WHEN 'T_OIMMAIN' THEN T_OIM.F_AgentRefno WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_ITNO WHEN 'T_OOMMAIN' THEN T_OOM.F_bookingNo WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_EXPREF WHEN 'T_AIMMAIN' THEN T_AIM.F_AGENTREFNO WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_ITNO WHEN 'T_AOMMAIN' THEN T_AOM.F_MAWBNO WHEN 'T_AOHMAIN' THEN T_AOHM.F_MAWBNO  END AS F_SREFNO,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_SMANID WHEN 'T_OIMMAIN' THEN T_COM.F_SMANID WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_SMANID WHEN 'T_OOMMAIN' THEN T_COM.F_SMANID WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_SMANID WHEN 'T_AIMMAIN' THEN T_COM.F_SMANID WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_SMANID WHEN 'T_AOMMAIN' THEN T_COM.F_SMANID WHEN 'T_AOHMAIN' THEN T_AOHMAIN.F_SMANID ELSE T_COM.F_SMANID END AS SMAN,
    CASE T1.F_TBName WHEN 'T_WSHIPHD' THEN T_WSH.F_SHIPDATE WHEN 'T_WRECEIVE' THEN T_WRE.F_RECEIVEDATE WHEN 'T_GENMAIN' THEN T1.F_PostDate WHEN 'T_OIMMAIN' THEN CASE WHEN T_OIM.F_FETA <> '' THEN T_OIM.F_FETA ELSE T_OIM.F_ETA END WHEN 'T_OIHMAIN' THEN CASE WHEN T_OIHM.F_FETA <>'' THEN T_OIHM.F_FETA ELSE T_OIHM.F_ETA END WHEN 'T_OOMMAIN' THEN T_OOM.F_ETD WHEN 'T_OOHMAIN' THEN T_OOHM.F_ETD WHEN 'T_AIMMAIN' THEN T_AIM.F_ETA WHEN 'T_AIHMAIN' THEN T_AIHM.F_ETA WHEN 'T_AOMMAIN' THEN T_AOM.F_ETD WHEN 'T_AOHMAIN' THEN T_AOHM.F_ETD END AS F_DEFAULTDATE,
    T1.F_U1Date,T1.F_U1ID,T1.F_InvoiceDate,
    T_COM.F_SName ,T1.F_CURRENCY,T1.F_YOURREF, F_InvoiceNo, F_InvoiceAmt, F_ADVRECAMOUNT+F_PaidAmt AS F_PAIDAMT, F_PaidAmt as F_RealPaidAmt, A.F_C1 AS F_INVOREMARKS,T1.F_ID,
    T1.F_Void, T1.F_IsCredit, T1.F_OriginInvId --T9.F_Void, T9.F_Credit, T9.F_OriginInvId
FROM T_INVOHD AS T1

LEFT JOIN T_OIHMAIN ON T_OIHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OIHMAIN'
LEFT JOIN T_OIMMAIN AS T_OIHM ON T_OIHMAIN.F_OIMBLID = T_OIHM.F_ID
LEFT JOIN T_OIMMAIN AS T_OIM ON T_OIM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OIMMAIN'
LEFT JOIN T_OOHMAIN ON T_OOHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OOHMAIN'
LEFT JOIN T_OOMMAIN AS T_OOHM ON T_OOHMAIN.F_OOMBLID = T_OOHM.F_ID
LEFT JOIN T_OOMMAIN AS T_OOM ON T_OOM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OOMMAIN'
LEFT JOIN T_AIHMAIN ON T_AIHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AIHMAIN'
LEFT JOIN T_AIMMAIN AS T_AIHM ON T_AIHMAIN.F_AIMBLID = T_AIHM.F_ID
LEFT JOIN T_AIMMAIN AS T_AIM ON T_AIM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AIMMAIN'
LEFT JOIN T_AOHMAIN ON T_AOHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AOHMAIN'
LEFT JOIN T_AOMMAIN AS T_AOHM ON T_AOHMAIN.F_AOMBLID = T_AOHM.F_ID
LEFT JOIN T_AOMMAIN AS T_AOM ON T_AOM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AOMMAIN'
LEFT JOIN T_GENMAIN AS T_GEN ON T_GEN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_GENMAIN'
LEFT JOIN T_WRECEIVEHD AS T_WRE ON T_WRE.F_ID = T1.F_TBID AND T1.F_TBName = 'T_WRECEIVE'
LEFT JOIN T_WSHIPHD AS T_WSH ON T_WSH.F_ID = T1.F_TBID AND T1.F_TBName = 'T_WSHIPHD'
LEFT JOIN T_Company AS T_COM ON T1.F_BillTo = T_Com.F_ID
LEFT JOIN T_AOTHERINFO AS A ON A.F_TBNAME='T_INVOHD' AND A.F_TBID=T1.F_ID AND A.F_TYPE='1'
LEFT JOIN T_AOTHERLOCAL AS AL ON AL.F_TBNAME = 'T_INVOHD' AND AL.F_TBID = T1.F_ID AND AL.F_TYPE = '1'
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)

            { "V_CRDB" ,
                @"
SELECT
    T1.F_PostDate, SUBSTRING(F_TBName, 3, 3) AS F_Type,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_BRANCH WHEN 'T_OIMMAIN' THEN T_OIM.F_BRANCH WHEN 'T_OIHMAIN' THEN T_OIHM.F_BRANCH WHEN 'T_OOMMAIN' THEN T_OOM.F_BRANCH WHEN 'T_OOHMAIN' THEN T_OOHM.F_BRANCH WHEN 'T_AIMMAIN' THEN T_AIM.F_BRANCH WHEN 'T_AIHMAIN' THEN T_AIHM.F_BRANCH WHEN 'T_AOMMAIN' THEN T_AOM.F_BRANCH WHEN 'T_AOHMAIN' THEN T_AOHM.F_BRANCH END AS F_BRANCH,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_REFNO WHEN 'T_OIMMAIN' THEN T_OIM.F_RefNo WHEN 'T_OIHMAIN' THEN T_OIHM.F_RefNo WHEN 'T_OOMMAIN' THEN T_OOM.F_RefNo WHEN 'T_OOHMAIN' THEN T_OOHM.F_RefNo WHEN 'T_AIMMAIN' THEN T_AIM.F_RefNo WHEN 'T_AIHMAIN' THEN T_AIHM.F_RefNo WHEN 'T_AOMMAIN' THEN T_AOM.F_RefNo WHEN 'T_AOHMAIN' THEN T_AOHM.F_RefNo END AS F_RefNo,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_HBLNO WHEN 'T_OIMMAIN' THEN T_OIM.F_MBLNo WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_HBLNO WHEN 'T_OOMMAIN' THEN T_OOM.F_MBLNo WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_HBLNO WHEN 'T_AIMMAIN' THEN T_AIM.F_MAWBNo WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_HAWBNo WHEN 'T_AOMMAIN' THEN T_AOM.F_MAWBNo WHEN 'T_AOHMAIN' THEN T_AOHMAIN.F_HAWBNo END AS F_BLNo,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_CUSTREFNO WHEN 'T_OIMMAIN' THEN T_OIM.F_AgentRefno WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_ITNO WHEN 'T_OOMMAIN' THEN T_OOM.F_bookingNo WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_EXPREF WHEN 'T_AIMMAIN' THEN T_AIM.F_AGENTREFNO WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_ITNO WHEN 'T_AOMMAIN' THEN T_AOM.F_MAWBNO WHEN 'T_AOHMAIN' THEN T_AOHM.F_MAWBNO END AS F_SREFNO,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T1.F_PostDate WHEN 'T_OIMMAIN' THEN CASE WHEN T_OIM.F_FETA <> '' THEN T_OIM.F_FETA ELSE T_OIM.F_ETA END WHEN 'T_OIHMAIN' THEN CASE WHEN T_OIHM.F_FETA <>'' THEN T_OIHM.F_FETA ELSE T_OIHM.F_ETA END WHEN 'T_OOMMAIN' THEN T_OOM.F_ETD WHEN 'T_OOHMAIN' THEN T_OOHM.F_ETD WHEN 'T_AIMMAIN' THEN T_AIM.F_ETA WHEN 'T_AIHMAIN' THEN T_AIHM.F_ETA WHEN 'T_AOMMAIN' THEN T_AOM.F_ETD WHEN 'T_AOHMAIN' THEN T_AOHM.F_ETD END AS F_DEFAULTDATE,
    T1.F_U1Date,T1.F_U1ID,T1.F_InvoiceDate,
    T_Com.F_SName AS F_Agent,T1.F_CURRENCY,T1.F_YOURREF,F_CRDBNO, F_Total, F_PaidAmt, F_Settled,
    IIf(dblcurrency = 1, T1.F_DefaultRate, , ) & T1.F_ID
FROM T_CRDBHD AS T1

LEFT JOIN T_OIHMAIN ON T_OIHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OIHMAIN'
LEFT JOIN T_OIMMAIN AS T_OIHM ON T_OIHMAIN.F_OIMBLID = T_OIHM.F_ID
LEFT JOIN T_OIMMAIN AS T_OIM ON T_OIM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OIMMAIN'
LEFT JOIN T_OOHMAIN ON T_OOHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OOHMAIN'
LEFT JOIN T_OOMMAIN AS T_OOHM ON T_OOHMAIN.F_OOMBLID = T_OOHM.F_ID
LEFT JOIN T_OOMMAIN AS T_OOM ON T_OOM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OOMMAIN'
LEFT JOIN T_AIHMAIN ON T_AIHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AIHMAIN'
LEFT JOIN T_AIMMAIN AS T_AIHM ON T_AIHMAIN.F_AIMBLID = T_AIHM.F_ID
LEFT JOIN T_AIMMAIN AS T_AIM ON T_AIM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AIMMAIN'
LEFT JOIN T_AOHMAIN ON T_AOHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AOHMAIN'
LEFT JOIN T_AOMMAIN AS T_AOHM ON T_AOHMAIN.F_AOMBLID = T_AOHM.F_ID
LEFT JOIN T_AOMMAIN AS T_AOM ON T_AOM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AOMMAIN'
LEFT JOIN T_GENMAIN AS T_GEN ON T_GEN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_GENMAIN'
LEFT JOIN T_Company AS T_COM ON T1.F_Agent = T_Com.F_ID
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_NEWCRDB" ,
                @"
SELECT 
    T1.F_PostDate, SUBSTRING(F_TBName, 3, 3) AS F_Type,T1.F_INVOICEDATE,T1.F_U1ID,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_ETA WHEN 'T_OIMMAIN' THEN T_OIM.F_ETA WHEN 'T_OIHMAIN' THEN T_OIHM.F_ETA WHEN 'T_OOMMAIN' THEN T_OOM.F_ETA WHEN 'T_OOHMAIN' THEN T_OOHM.F_ETA WHEN 'T_AIMMAIN' THEN T_AIM.F_ETA WHEN 'T_AIHMAIN' THEN T_AIHM.F_ETA WHEN 'T_AOMMAIN' THEN T_AOM.F_ETA WHEN 'T_AOHMAIN' THEN T_AOHM.F_ETA END AS F_ETA,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_ETD WHEN 'T_OIMMAIN' THEN T_OIM.F_ETD WHEN 'T_OIHMAIN' THEN T_OIHM.F_ETD WHEN 'T_OOMMAIN' THEN T_OOM.F_ETD WHEN 'T_OOHMAIN' THEN T_OOHM.F_ETD WHEN 'T_AIMMAIN' THEN T_AIM.F_ETD WHEN 'T_AIHMAIN' THEN T_AIHM.F_ETD WHEN 'T_AOMMAIN' THEN T_AOM.F_ETD WHEN 'T_AOHMAIN' THEN T_AOHM.F_ETD END AS F_ETD,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_BRANCH WHEN 'T_OIMMAIN' THEN T_OIM.F_BRANCH WHEN 'T_OIHMAIN' THEN T_OIHM.F_BRANCH WHEN 'T_OOMMAIN' THEN T_OOM.F_BRANCH WHEN 'T_OOHMAIN' THEN T_OOHM.F_BRANCH WHEN 'T_AIMMAIN' THEN T_AIM.F_BRANCH WHEN 'T_AIHMAIN' THEN T_AIHM.F_BRANCH WHEN 'T_AOMMAIN' THEN T_AOM.F_BRANCH WHEN 'T_AOHMAIN' THEN T_AOHM.F_BRANCH END AS F_BRANCH,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_REFNO WHEN 'T_OIMMAIN' THEN T_OIM.F_RefNo WHEN 'T_OIHMAIN' THEN T_OIHM.F_RefNo WHEN 'T_OOMMAIN' THEN T_OOM.F_RefNo WHEN 'T_OOHMAIN' THEN T_OOHM.F_RefNo WHEN 'T_AIMMAIN' THEN T_AIM.F_RefNo WHEN 'T_AIHMAIN' THEN T_AIHM.F_RefNo WHEN 'T_AOMMAIN' THEN T_AOM.F_RefNo WHEN 'T_AOHMAIN' THEN T_AOHM.F_RefNo END AS F_RefNo,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_HBLNO WHEN 'T_OIMMAIN' THEN T_OIM.F_MBLNo WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_HBLNO WHEN 'T_OOMMAIN' THEN T_OOM.F_MBLNo WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_HBLNO WHEN 'T_AIMMAIN' THEN T_AIM.F_MAWBNo WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_HAWBNo WHEN 'T_AOMMAIN' THEN T_AOM.F_MAWBNo WHEN 'T_AOHMAIN' THEN T_AOHMAIN.F_HAWBNo END AS F_BLNo,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_CUSTREFNO WHEN 'T_OIMMAIN' THEN T_OIM.F_AgentRefno WHEN 'T_OIHMAIN' THEN T_OIHMAIN.F_ITNO WHEN 'T_OOMMAIN' THEN T_OOM.F_bookingNo WHEN 'T_OOHMAIN' THEN T_OOHMAIN.F_EXPREF WHEN 'T_AIMMAIN' THEN T_AIM.F_AGENTREFNO WHEN 'T_AIHMAIN' THEN T_AIHMAIN.F_ITNO WHEN 'T_AOMMAIN' THEN T_AOM.F_MAWBNO WHEN 'T_AOHMAIN' THEN T_AOHM.F_MAWBNO END AS F_SREFNO,
    CASE T1.F_TBName WHEN 'T_GENMAIN' THEN T_GEN.F_PostDate WHEN 'T_OIMMAIN' THEN CASE WHEN T_OIM.F_FETA <> '' THEN T_OIM.F_FETA ELSE T_OIM.F_ETA END WHEN 'T_OIHMAIN' THEN CASE WHEN T_OIHM.F_FETA <>'' THEN T_OIHM.F_FETA ELSE T_OIHM.F_ETA END WHEN 'T_OOMMAIN' THEN T_OOM.F_ETD WHEN 'T_OOHMAIN' THEN T_OOHM.F_ETD WHEN 'T_AIMMAIN' THEN T_AIM.F_ETA WHEN 'T_AIHMAIN' THEN T_AIHM.F_ETA WHEN 'T_AOMMAIN' THEN T_AOM.F_ETD WHEN 'T_AOHMAIN' THEN T_AOHM.F_ETD END AS F_DEFAULTDATE,
    T1.F_U1Date,
    T_Com.F_SName AS F_Agent,T1.F_CURRENCY,T1.F_YOURREF,F_CRDBNO, F_Total, F_PaidAmt, F_Settled,
    IIf(dblcurrency = 1, T1.F_DefaultRate, , ) & T1.F_ID, T1.F_Void, T1.F_OriginId, T1.F_CheckNo, T1.F_PaidDate
FROM T_CRDBHD AS T1

LEFT JOIN T_OIHMAIN ON T_OIHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OIHMAIN'
LEFT JOIN T_OIMMAIN AS T_OIHM ON T_OIHMAIN.F_OIMBLID = T_OIHM.F_ID
LEFT JOIN T_OIMMAIN AS T_OIM ON T_OIM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OIMMAIN'
LEFT JOIN T_OOHMAIN ON T_OOHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OOHMAIN'
LEFT JOIN T_OOMMAIN AS T_OOHM ON T_OOHMAIN.F_OOMBLID = T_OOHM.F_ID
LEFT JOIN T_OOMMAIN AS T_OOM ON T_OOM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_OOMMAIN'
LEFT JOIN T_AIHMAIN ON T_AIHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AIHMAIN'
LEFT JOIN T_AIMMAIN AS T_AIHM ON T_AIHMAIN.F_AIMBLID = T_AIHM.F_ID
LEFT JOIN T_AIMMAIN AS T_AIM ON T_AIM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AIMMAIN'
LEFT JOIN T_AOHMAIN ON T_AOHMAIN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AOHMAIN'
LEFT JOIN T_AOMMAIN AS T_AOHM ON T_AOHMAIN.F_AOMBLID = T_AOHM.F_ID
LEFT JOIN T_AOMMAIN AS T_AOM ON T_AOM.F_ID = T1.F_TBID AND T1.F_TBName = 'T_AOMMAIN'
LEFT JOIN T_GENMAIN AS T_GEN ON T_GEN.F_ID = T1.F_TBID AND T1.F_TBName = 'T_GENMAIN'
LEFT JOIN T_Company AS T_COM ON T1.F_Agent = T_Com.F_ID
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_WRMMAIN" ,
                @"
SELECT 
    T_WRECEIVEHD.F_ID,'WHR' AS F_TYPE,F_RECEIVENO AS F_REFNO,''  AS F_MBLNO,'' AS F_HBLNO,W.F_CUSTOMER AS F_CUSTOMER,F_PONO AS F_CUSTREFNO,
    NULL AS F_ETA, NULL AS F_ETD,'' AS F_VESSEL,C.F_SMANID AS F_SMANID,0 AS F_LCODE,'' AS F_LOADINGPORT,0 AS F_DCODE,'' AS F_DISCHARGE,
    F_RECEIVEDATE AS F_POSTDATE,0 AS F_FCODE,'' AS F_FINALDEST,NULL AS F_FETA,'' AS F_COMMODITY,0 AS F_PKGS,'' AS F_PUNIT,0 AS F_KGS,0 AS F_CBM,
    T_WRECEIVEHD.F_REMARK AS F_IMEMO,0 AS F_FILECLOSED,'' AS F_CLOSEDBY,F_BRANCH,'' AS F_U1ID,NULL AS F_U1DATE,'' AS F_U2ID,NULL AS F_U2DATE
FROM T_WRECEIVEHD LEFT  JOIN T_WEB_CENTER W ON W.F_CENTER_NO=T_WRECEIVEHD.F_CENTER_NO LEFT JOIN T_COMPANY C ON C.F_ID=W.F_CUSTOMER
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_WSMMAIN" ,
                @"
SELECT 
    T_WSHIPHD.F_ID,'WHS' AS F_TYPE,F_SHIPNO AS F_REFNO,''  AS F_MBLNO,'' AS F_HBLNO,W.F_CUSTOMER AS F_CUSTOMER,F_PONO AS F_CUSTREFNO,
    NULL AS F_ETA, NULL AS F_ETD,'' AS F_VESSEL,C.F_SMANID AS F_SMANID,0 AS F_LCODE,'' AS F_LOADINGPORT,0 AS F_DCODE,'' AS F_DISCHARGE,
    F_SHIPDATE AS F_POSTDATE,0 AS F_FCODE,'' AS F_FINALDEST,NULL AS F_FETA,'' AS F_COMMODITY,0 AS F_PKGS,'' AS F_PUNIT,0 AS F_KGS,0 AS F_CBM,
    T_WSHIPHD.F_REMARK AS F_IMEMO,0 AS F_FILECLOSED,'' AS F_CLOSEDBY,F_BRANCH,'' AS F_U1ID,NULL AS F_U1DATE,'' AS F_U2ID,NULL AS F_U2DATE
FROM T_WSHIPHD LEFT  JOIN T_WEB_CENTER W ON W.F_CENTER_NO=T_WSHIPHD.F_CENTER_NO  LEFT JOIN T_COMPANY C ON C.F_ID=W.F_CUSTOMER
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_ARCOLLECT" ,
                @"
SELECT 
    C.F_SNAME,F_CURRENCY,CC.F_CONTACT,CC.F_PHONE,F_FOLLOWUP,F_LASTPAIDAMT,F_CHECKNO,DH.F_POSTDATE AS F_LASTPAIDDATE,F_SMANID,F_TERMS,F_AGE,F_CURR,CURDUEINVCNT,
    F_BALANCE-F_CURR AS F_PASTDUE,PASTDUEINVCNT,F_15,F_30,F_45,F_60,F_90,F_OVER90,F_BALANCE,M.F_TITLE,C.F_ID
From(SELECT F_BILLTO,F_CURRENCY,SUM(CASE WHEN datediff(d,F_DUEDATE,getdate()) <= 0 THEN 1 ELSE 0 END) AS CURDUEINVCNT,
SUM(CASE WHEN datediff(d,F_DUEDATE,getdate()) > 0 THEN 1 ELSE 0 END) AS PASTDUEINVCNT,

AVG(datediff(d,f_postdate,getdate())) AS F_AGE,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) <= 0 THEN F_INVOICEAMT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_CURR,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 0 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=15 THEN F_INVOICEAMT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_15,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 15 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=30 THEN F_INVOICEAMT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_30,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 30 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=45 THEN F_INVOICEAMT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_45,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 45 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=60 THEN F_INVOICEAMT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_60,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 60 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=90 THEN F_INVOICEAMT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_90,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 90 THEN F_INVOICEAMT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_OVER90,
SUM(F_INVOICEAMT - (IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount)) As F_BALANCE FROM T_INVOHD INV Left Join

(select 
    f_tbid,sum(case when DH.F_TYPE='D' THEN f_amount ELSE -1*F_AMOUNT END) as F_paid FROM T_DEPODETAIL D
LEFT JOIN T_DEPOHD DH ON DH.F_ID=D.F_DEPOHDID WHERE DH.F_VOID <> '1' AND D.F_TBNAME='T_INVOHD'
GROUP BY F_TBID) DP ON DP.F_TBID =INV.F_ID
Where ABS(F_INVOICEAMT - (IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount)) > 0.001
GROUP BY INV.F_BILLTO,INV.F_CURRENCY ) ARSUM

LEFT JOIN T_COMPANY C ON C.F_ID=ARSUM.F_BILLTO
LEFT JOIN T_COMPANYCONTACT CC ON CC.F_COMPANYID=C.F_ID AND CC.F_PRIMARY='1'
LEFT JOIN (SELECT F_TBID,MAX(F_U2DATE) AS F_FOLLOWUP FROM T_MEMO WHERE F_TBNAME='V_ARCOLLECT' GROUP BY F_TBID) AS MEMO ON MEMO.F_TBID=C.F_ID
LEFT JOIN (SELECT F_BILLTO,MAX(F_ID) AS LPAIDID FROM T_DEPOHD  WHERE F_VOID <> '1' AND F_TYPE ='D' GROUP BY F_BILLTO) LDEP ON LDEP.F_BILLTO=C.F_ID
LEFT JOIN (SELECT F_DEPOHDID,SUM(F_AMOUNT)AS F_LASTPAIDAMT,F_CHECKNO,F_POSTDATE FROM T_DEPODETAIL DD LEFT JOIN T_DEPOHD DH ON DH.F_ID=F_DEPOHDID
GROUP BY F_DEPOHDID,F_CHECKNO,F_POSTDATE)
DH  ON DH.F_DEPOHDID=LPAIDID LEFT JOIN T_MEMO M ON M.F_TBID=MEMO.F_TBID AND MEMO.F_FOLLOWUP=M.F_U2DATE
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_ARCOLLECT1" ,
                @"
SELECT
    C.F_SNAME,CC.F_CONTACT,CC.F_PHONE,F_FOLLOWUP,F_LASTPAIDAMT,F_CHECKNO,DH.F_POSTDATE AS F_LASTPAIDDATE,F_SMANID,F_TERMS,F_AGE,F_CURR,CURDUEINVCNT,
    F_BALANCE-F_CURR AS F_PASTDUE,PASTDUEINVCNT,F_15,F_30,F_45,F_60,F_90,F_OVER90,F_BALANCE,M.F_TITLE,C.F_ID
From(SELECT F_BILLTO,SUM(CASE WHEN datediff(d,F_DUEDATE,getdate()) <= 0 THEN 1 ELSE 0 END) AS CURDUEINVCNT,
SUM(CASE WHEN datediff(d,F_DUEDATE,getdate()) > 0 THEN 1 ELSE 0 END) AS PASTDUEINVCNT,

AVG(datediff(d,f_postdate,getdate())) AS F_AGE,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) <= 0 THEN F_TLAMOUNT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_CURR,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 0 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=15 THEN F_TLAMOUNT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_15,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 15 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=30 THEN F_TLAMOUNT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_30,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 30 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=45 THEN F_TLAMOUNT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_45,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 45 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=60 THEN F_TLAMOUNT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_60,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 60 AND datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate())<=90 THEN F_TLAMOUNT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_90,
SUM(CASE WHEN datediff(d,isnull(F_DUEDATE,F_INVOICEDATE),getdate()) > 90 THEN F_TLAMOUNT-(IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount) ELSE 0 END) AS F_OVER90,
SUM(F_TLAMOUNT - (IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount)) As F_BALANCE FROM T_INVOHD INV Left Join

(select 
    f_tbid,sum(case when DH.F_TYPE='D' THEN f_oamount ELSE -1*F_OAMOUNT END) as F_paid FROM T_DEPODETAIL D
LEFT JOIN T_DEPOHD DH ON DH.F_ID=D.F_DEPOHDID WHERE DH.F_VOID <> '1' AND D.F_TBNAME='T_INVOHD'
GROUP BY F_TBID) DP ON DP.F_TBID =INV.F_ID
Where ABS(F_TLAMOUNT - (IsNull(DP.F_PAID, 0) + INV.F_AdvRecAmount)) > 0.001
GROUP BY INV.F_BILLTO ) ARSUM

LEFT JOIN T_COMPANY C ON C.F_ID=ARSUM.F_BILLTO
LEFT JOIN T_COMPANYCONTACT CC ON CC.F_COMPANYID=C.F_ID AND CC.F_PRIMARY='1'
LEFT JOIN (SELECT F_TBID,MAX(F_U2DATE) AS F_FOLLOWUP FROM T_MEMO WHERE F_TBNAME='V_ARCOLLECT' GROUP BY F_TBID) AS MEMO ON MEMO.F_TBID=C.F_ID
LEFT JOIN (SELECT F_BILLTO,MAX(F_ID) AS LPAIDID FROM T_DEPOHD  WHERE F_VOID <> '1' AND F_TYPE ='D' GROUP BY F_BILLTO) LDEP ON LDEP.F_BILLTO=C.F_ID
LEFT JOIN (SELECT F_DEPOHDID,SUM(F_AMOUNT)AS F_LASTPAIDAMT,F_CHECKNO,F_POSTDATE FROM T_DEPODETAIL DD LEFT JOIN T_DEPOHD DH ON DH.F_ID=F_DEPOHDID
GROUP BY F_DEPOHDID,F_CHECKNO,F_POSTDATE)
DH  ON DH.F_DEPOHDID=LPAIDID LEFT JOIN T_MEMO M ON M.F_TBID=MEMO.F_TBID AND MEMO.F_FOLLOWUP=M.F_U2DATE
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_CustomerBalance" ,
                @"
select 
    t1.f_id,  t1.f_sname, t1.f_creditlimit, t1.f_smanid,
    F_LastDepositID, F_LastDepositDate, F_LastDepositAmount,
    F_LastPayID, F_LastPayDate, F_LastPayAmount, F_Currency,
    F_AR, F_AP, F_CrDr, F_Balance,
    F_OIHLastActDate , F_OOHLastActDate, F_AIHLastActDate, F_AOHLastActDate
from T_Company t1
Left Join
(
select
    x1.F_BillTo,
    x2.F_ID as F_LastDepositID,
    x2.F_PostDate as F_LastDepositDate,
    COALESCE(x4.F_Amount,0) as F_LastDepositAmount,
    x3.F_PostDate as F_LastPayID,
    x3.F_PostDate as F_LastPayDate,
    COALESCE(x5.F_Amount, 0) As F_LastPayAmount
From
(select
    F_BillTo,
    max(case F_Type when 'D' then f_id end) as F_LastD,
    max(case F_Type when 'C' then f_id end) as F_LastC
From T_DepoHD
where f_void<>'1'
group by F_BillTo) x1

left join T_DepoHD x2 on x1.F_LastD=x2.F_ID
left join T_DepoHD x3 on x1.F_LastC=x3.F_ID
Left Join
(select 
    F_DepoHDID, sum(f_amount) as f_amount
from T_DepoDetail group by F_DepoHDID) x4
on x2.F_ID=x4.F_DepoHDID
Left Join
(select 
    F_DepoHDID, sum(f_amount) as f_amount
from T_DepoDetail group by F_DepoHDID) x5
on x3.F_ID=x5.F_DepoHDID
)  t3 on t1.f_id=t3.F_BillTo

Left Join
(
select  
    F_BillTo, F_Currency,
    sum(F_AR) as F_AR,
    sum(F_AP) as F_AP,
    sum(F_CrDr) as F_CrDr,
    sum(F_Balance) As F_Balance
From
(
(select 
    F_BillTo, T_InvoHD.F_Currency,
    sum(F_InvoiceAmt-F_PaidAmt) as F_AR,
    0 as F_AP,
    0 as F_CrDr,
    sum(F_InvoiceAmt - F_PaidAmt) As F_Balance
From T_InvoHD
group by F_BillTo, T_InvoHD.F_Currency)


Union All
(select 
    F_PayTo as F_BillTo, T_ApHD.F_Currency,
    0 as F_AR,
    sum(F_InvoiceAmt-F_PaidAmt) as F_AP,
    0 as F_CrDr,
    sum(-F_InvoiceAmt + F_PaidAmt) As F_Balance
From T_ApHD
group by F_PayTo, T_ApHD.F_Currency)
Union All
(select 
    F_Agent as F_BillTo, T_CrDbHD.F_Currency,
    0 as F_AR, 0 as F_AP,
    sum(F_Total-F_PaidAmt) as F_CrDr,
    sum(F_Total - F_PaidAmt) As F_Balance
From T_CrDbHD
group by F_Agent, T_CrDbHD.f_currency)
) xx
group by F_BillTo,  F_Currency
) t4 on t1.f_id=t4.f_billto

Left Join
(
SELECT
    F_Customer,
    max(F_PostDate) As F_OIHLastActDate
FROM T_OIHMAIN t1 inner join t_oimmain t2 on t1.f_oimblid=t2.f_id
group by F_Customer
) t5 on t1.f_id=t5.f_customer
Left Join
(
SELECT 
    F_Customer,
    max(F_PostDate) As F_OOHLastActDate
FROM T_OOHMAIN  t1 inner join t_oommain t2 on t1.f_oomblid=t2.f_id
group by F_Customer
) t6 on t1.f_id=t6.f_customer
Left Join
(
SELECT 
    F_Customer,
    max(F_PostDate) As F_AIHLastActDate
FROM T_AIHMAIN  t1 inner join t_aimmain t2 on t1.f_aimblid=t2.f_id
group by F_Customer
) t7 on t1.f_id=t7.f_customer

Left Join
(
SELECT 
    F_Customer,
    max(F_PostDate) As F_AOHLastActDate
FROM T_AOHMAIN  t1 inner join t_aommain t2 on t1.f_aomblid=t2.f_id
group by F_Customer
) t8 on t1.f_id=t8.f_customer
Left Join
(
SELECT 
    F_Customer,
    max(F_PostDate) As F_GenLastActDate
From T_GenMain
group by F_Customer
) t9 on t1.f_id=t9.f_customer
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_PROFIT_H" ,
                @"
select  
    F_TBName, F_TBID,  F_Currency,
    sum(F_AR) as F_AR, sum(F_ARPaid) as F_ARPaid,
    sum(F_AP) as F_AP, sum(F_CrDr) as F_CrDr,
    sum(F_CrDrP) as F_CrDrP,
    sum(F_HouseTotal) As F_HouseTotal
From
(
(select 
    F_TBNAME, F_tbid, T_InvoHD.F_Currency,
    sum(F_InvoiceAmt) as F_AR,
    sum(f_invoiceAmt-f_paidAmt) as F_ARPaid,
    0 as F_AP, 0 as F_CrDr, 0 as F_CrDrP,
    sum(F_InvoiceAmt) As F_HouseTotal
From T_InvoHD
where F_TBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN')
group by F_TBNAME, F_tbid, T_InvoHD.F_Currency)

Union All
(select 
    F_TBName, F_tbid, T_ApHD.F_Currency,
    0 as F_AR, 0 as F_ARPaid, sum(F_InvoiceAmt) as F_AP,
    0 as F_CrDr, 0 as F_CrDrP, sum(-F_InvoiceAmt) As F_HouseTotal
From T_ApHD
where F_TBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN')
group by F_TBName, F_tbid, T_ApHD.F_Currency)

Union All
(select 
    F_TBName, F_tbid, T_CrDbHD.F_Currency,
    0 as F_AR, 0 as F_ARPaid, 0 as F_AP,
    sum(case when F_PShareField<>'1' then F_Debit - F_Credit else 0 end) as F_CrDr,
    sum(case F_PShareField when '1' then F_Debit - F_Credit else 0 end) as F_CrDrP,
    sum(F_Debit - F_Credit) As F_HouseTotal
from T_CrDbDetail inner join T_CrDbHD on T_CrDbDetail.F_CrDbHDID=T_CrDbHD.F_ID
where F_TBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN')
group by F_TBName, f_tbid, T_CrDbHD.f_currency)
) xx
group by F_TBName, F_TBID,  F_Currency
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_Profit_M_NEW" ,
                @"
select 
    F_TBNAME, F_TBID, F_Currency, sum(MAR) as F_MAR, sum(MAP) as F_MAP,& sum(MmDebit) as F_MmDebit, sum(MmCredit) as F_MmCredit, sum(MasterTotal) As F_MasterTotal 
From ((select F_TBNAME, F_Tbid, T_InvoHD.F_Currency, sum(F_InvoiceAmt) as MAR, 0 as MAP, 0 as MmDebit, 0 as MmCredit, sum(F_InvoiceAmt) As MasterTotal
From T_InvoHD
where F_TBNAME in ('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN') group by F_TBNAME, F_Tbid, T_InvoHD.F_Currency)

Union All
(select
    F_TBNAME, F_Tbid, T_ApHD.F_Currency, 0 as MAR, sum(F_InvoiceAmt) as MAP, 0 as MmDebit, 0 as MmCredit, sum(-F_InvoiceAmt) As MasterTotal 
From T_ApHD
where F_TBNAME in ('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN') group by F_TBNAME, F_tbid, T_ApHD.F_Currency)
Union All
(select 
    F_STBNAME as F_TBName, f_STbid as F_TBID, T_CrDbHD.F_Currency, 0 as MAR, 0 as MAP,sum(F_Debit) as MmDebit,  sum(F_Credit) as MmCredit,sum(F_Debit - F_Credit) As MasterTotal
From T_CrDbDetail inner join T_CrDbHD on T_CrDbDetail.F_CrDbHDID=T_CrDbHD.F_ID
where F_TBNAME=F_STBNAME and F_TBNAME in ('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN') group by F_STBNAME, F_Stbid, T_CrDbHD.F_Currency) ) xx group by F_TBNAME, F_TBID,  F_Currency
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_PROFIT_House_New" ,
                @"
select  
    F_TBName, F_TBID,  F_Currency, sum(F_AR) as F_AR,
    sum(F_ARPaid) as F_ARPaid, sum(F_AP) as F_AP, sum(F_DEBIT) as F_DEBIT, sum(F_CREDIT) as F_CREDIT,
    sum(F_HouseTotal) As F_HouseTotal From ( (select F_TBNAME, F_tbid, T_InvoHD.F_Currency, sum(F_InvoiceAmt) as F_AR,
    sum(f_invoiceAmt-f_paidAmt) as F_ARPaid, 0 as F_AP, 0 as F_DEBIT, 0 as F_CREDIT, sum(F_InvoiceAmt) As F_HouseTotal 
From T_InvoHD
where F_TBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN') group by F_TBNAME, F_tbid, T_InvoHD.F_Currency)

Union All
& (select F_TBName, F_tbid, T_ApHD.F_Currency, 0 as F_AR, 0 as F_ARPaid, sum(F_InvoiceAmt) as F_AP, 0 as F_DEBIT, 0 as F_CREDIT,
& sum(-F_InvoiceAmt) As F_HouseTotal From T_ApHD where F_TBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN') group by F_TBName, F_tbid, T_ApHD.F_Currency)
Union All (select F_TBName, F_tbid, T_CrDbHD.F_Currency, 0 as F_AR, 0 as F_ARPaid, 0 as F_AP, sum(F_Debit) as F_Debit,
sum(F_Credit) as F_Credit,sum(F_Debit - F_Credit) As F_HouseTotal from T_CrDbDetail
inner join T_CrDbHD on T_CrDbDetail.F_CrDbHDID=T_CrDbHD.F_ID where F_TBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN') group by F_TBName, f_tbid, T_CrDbHD.f_currency)

Union All
(select f_STBName as F_TBName, F_Stbid as F_TBID, T_CrDbHD.F_Currency, 0 as F_AR, 0 as F_ARPaid, 0 as F_AP,
sum(F_Debit) as F_DEBIT, SUM(F_CREDIT) as F_CREDIT, sum(F_Debit - F_Credit) As F_HouseTotal From T_CrDbDetail
inner join T_CrDbHD on T_CrDbHD.F_ID=T_CrDbDetail.F_CrDbHDID Where F_TBNAME <> f_STBName and F_STBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN')
group by f_STBName, F_stbid, T_CrDbHD.f_currency)

Union All
(select 
    v3.f_tbname, v3.f_tbid, v1.F_Currency, (case when COALESCE(v2.F_MCBM, 0)=0 then v1.F_MAR else v1.F_MAR *  (v3.F_HCBM / v2.F_MCBM) end) as F_AR, 0 as F_ARPaid,
    (case when COALESCE(v2.F_MCBMP, 0)=0 then v1.F_MAP else v1.F_MAP * (v3.F_HCBMP / v2.F_MCBMP) end) as F_AP,
    (case when COALESCE(v2.F_MCBM, 0)=0 then v1.F_MmDebit else v1.F_MmDebit * (v3.F_HCBM / v2.F_MCBM) end) as F_Debit,
    (case when COALESCE(v2.F_MCBM, 0)=0 then v1.F_MmCredit else v1.F_MmCredit * (v3.F_HCBM / v2.F_MCBM) end) as F_Credit,
    (case when COALESCE(v2.F_MCBM, 0)=0 OR COALESCE(v2.F_MCBMP, 0)=0 then (v1.F_MAR-v1.F_MAP+v1.F_MmDebit-v1.F_MmCredit) else (v1.F_MAR+v1.F_MmDebit) * (v3.F_HCBM / v2.F_MCBM) - (v1.F_MAP+v1.F_MmCredit) * (v3.F_HCBMP / v2.F_MCBMP)  end)
    as F_HouseTotal
from V_Profit_M_NEW v1
inner join V_Profit_Mwt v2 on v1.f_tbname=v2.f_tbname and v1.f_tbid=v2.f_tbid inner join
V_Profit_Hwt v3 on v1.f_tbname=v3.f_mtbname and v1.f_tbid=v3.f_mblid) ) xx group by F_TBName, F_TBID, F_Currency
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_BLRelation" ,
                @"
SELECT 
    F_OIMBLID As F_MBLID,
    T_OIHMAIN.F_ID As F_TBID,
    'T_OIMMAIN' As F_MTBName,
    'T_OIHMAIN' As F_TBName
    ,CASE WHEN F_CBM=0 THEN 1 ELSE F_CBM END AS F_VOL
From T_OIHMAIN
Union
SELECT 
    F_OOMBLID As F_MBLID,
    T_OOHMAIN.F_ID As F_TBID,
    'T_OOMMAIN' As F_MTBName,
    'T_OOHMAIN' As F_TBName
    ,CASE WHEN F_CBM=0 THEN 1 ELSE F_CBM END AS F_VOL
From T_OOHMAIN
Union
SELECT
    F_AIMBLID As F_MBLID,
    T_AIHMAIN.F_ID As F_TBID,
    'T_AIMMAIN' As F_MTBName,
    'T_AIHMAIN' As F_TBName
    ,CASE WHEN F_ChgWeight=0 THEN 1 ELSE F_ChgWeight END AS F_VOL
From T_AIHMAIN
Union
SELECT 
    F_AOMBLID As F_MBLID,
    T_AOHMAIN.F_ID As F_TBID,
    'T_AOMMAIN' As F_MTBName,
    'T_AOHMAIN' As F_TBName
    ,CASE WHEN F_ChgWeight=0 THEN 1 ELSE F_ChgWeight END AS F_VOL
From T_AOHMAIN
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_PROFIT_Master" ,
                @"
select
        F_TBNAME, F_TBID, F_Currency, 
        sum(AR) as F_AR, 
        sum(AP) as F_AP, 
        sum(f_arpaid) as F_ARPaid, 
        sum(CrDr) as F_CrDr, 
        sum(MasterTotal) As F_MasterTotal 
From 
((select F_TBNAME, F_Tbid, T_InvoHD.F_Currency, 
sum(F_InvoiceAmt) as AR, sum(f_invoiceAmt-f_paidAmt) as F_ARPaid, 
0 as AP, 0 as CrDr, sum(F_InvoiceAmt) As MasterTotal 
From T_InvoHD 
where F_TBNAME in ('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN', 'T_GENMAIN')
group by F_TBNAME, F_Tbid, T_InvoHD.F_Currency)
Union All 
(select F_TBNAME, F_Tbid, T_ApHD.F_Currency, 
0 as AR, 0 as F_ARPaid, sum(F_InvoiceAmt) as AP, 0 as CrDr, 
sum(-F_InvoiceAmt) As MasterTotal 
From T_ApHD 
where F_TBNAME in ('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN', 'T_GENMAIN') 
group by F_TBNAME, F_tbid, T_ApHD.F_Currency) 

Union All
(select F_TBName, F_TBID, T_CrDbHD.F_Currency,
0 as AR, 0 as F_ARPaid, 0 as AP, sum(F_Total) as CrDr,
sum(F_Total) As MasterTotal
From T_CrDbHD
where F_TBNAME in ('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN', 'T_GENMAIN')
group by F_TBNAME, F_tbid, T_CrDbHD.F_Currency)
Union All
(select F_MTBName as F_TBName, F_MBLID as F_TBID, F_Currency,
sum(F_AR) as AR, sum(F_ARPaid) as F_ARPaid, sum(F_AP) as AP,
sum(F_CrDr) as CrDr, sum(F_HouseTotal) As MasterTotal
From V_Profit_H
inner join V_BLRelation
on V_Profit_H.F_TBName=V_BLRelation.F_TBName and V_Profit_H.F_TBid=V_BLRelation.F_tbid
where F_MTBNAME in ('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN', 'T_GENMAIN')
group by F_MTBNAME, F_mblid, F_Currency) 
) xx
group by F_TBNAME, F_TBID,  F_Currency
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_Profit_Mwt" ,
                @"
select 
    'T_OIMMAIN' as F_TBName, f_oimblid as F_TBid,
    sum(CASE WHEN F_N2 = 0 Then Case When f_cbm * 800 >= f_lbs THEN f_cbm ELSE f_lbs / 800 END
    Else Case When F_N3 = 0 Then Case When F_CBM * F_N2 >= F_Lbs Then F_Cbm Else F_Lbs / F_N2 End
    Else Case When F_Cbm * F_N2 >= F_Kgs Then F_Cbm Else F_Kgs / F_N2 End End End) as F_MCBM,
    sum(CASE WHEN F_N2 = 0 Then Case When f_cbm * 800 >= f_lbs THEN f_cbm ELSE f_lbs / 800 END
    Else Case When F_N3 = 0 Then Case When F_CBM * F_N2 >= F_Lbs Then F_Cbm Else F_Lbs / F_N2 End
    Else Case When F_Cbm * F_N2 >= F_Kgs Then F_Cbm Else F_Kgs / F_N2 End End End) AS F_MCBMP
from t_oihmain Left Join T_AotherInfo A On A.F_Tbname = 'T_CODEDATA' And A.F_Tbid = 0 And A.F_Type = 1 group by f_oimblid
Union
select 
    'T_OOMMAIN' as F_TBName, f_oomblid as F_TBid,
    sum(CASE WHEN F_N2 = 0 Then Case When f_cbm * 800 >= f_lbs THEN f_cbm ELSE f_lbs / 800 END
    Else Case When F_N3 = 0 Then Case When F_CBM * F_N2 >= F_Lbs Then F_Cbm Else F_Lbs / F_N2 End
    Else Case When F_Cbm * F_N2 >= F_Kgs Then F_Cbm Else F_Kgs / F_N2 End End End) as F_MCBM,
    sum(CASE WHEN F_N2 = 0 Then Case When f_cbm * 800 >= f_lbs THEN f_cbm ELSE f_lbs / 800 END
    Else Case When F_N3 = 0 Then Case When F_CBM * F_N2 >= F_Lbs Then F_Cbm Else F_Lbs / F_N2 End
    Else Case When F_Cbm * F_N2 >= F_Kgs Then F_Cbm Else F_Kgs / F_N2 End End End) AS F_MCBMP
from t_oohmain Left Join T_AotherInfo A On A.F_Tbname = 'T_CODEDATA' And A.F_Tbid = 0 And A.F_Type = 1 group by f_oomblid

Union
select 
    'T_AIMMAIN' as F_TBName, f_aimblid as F_TBid,
    sum(F_ChgWeight) as F_MCBM,
    sum(F_Grossweight) As F_MCBMP
from t_aihmain group by f_aimblid

Union
select
    'T_AOMMAIN' as F_TBName, f_aomblid as F_TBid,
    sum(F_CChgWeight) as F_MCBM,
    sum(F_CGrossweight) As F_MCBMP
from t_aohmain group by f_aomblid
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_Profit_Hwt" ,
                @"
SELECT
    F_OIMBLID As F_MBLID,
    T_OIHMAIN.F_ID As F_TBID,
    'T_OIMMAIN' As F_MTBName,
    'T_OIHMAIN' As F_TBName,
    (CASE WHEN F_N2 = 0 Then Case When f_cbm * 800 >= f_lbs THEN f_cbm ELSE f_lbs / 800 END
    Else Case When F_N3 = 0 Then Case When F_CBM * F_N2 >= F_Lbs Then F_Cbm Else F_Lbs / F_N2 End
    Else Case When F_Cbm * F_N2 >= F_Kgs Then F_Cbm Else F_Kgs / F_N2 End End End) as F_HCBM,
    (CASE WHEN F_N2 = 0 Then Case When f_cbm * 800 >= f_lbs THEN f_cbm ELSE f_lbs / 800 END
    Else Case When F_N3 = 0 Then Case When F_CBM * F_N2 >= F_Lbs Then F_Cbm Else F_Lbs / F_N2 End
    Else Case When F_Cbm * F_N2 >= F_Kgs Then F_Cbm Else F_Kgs / F_N2 End End End) as F_HCBMP
From T_OIHMAIN Left Join T_AotherInfo A On A.F_Tbname = 'T_CODEDATA' And A.F_Tbid = 0 And A.F_Type = 1

Union
SELECT 
    F_OOMBLID As F_MBLID,
    T_OOHMAIN.F_ID As F_TBID,
    'T_OOMMAIN' As F_MTBName,
    'T_OOHMAIN' As F_TBName,
    (CASE WHEN F_N2 = 0 Then Case When f_cbm * 800 >= f_lbs THEN f_cbm ELSE f_lbs / 800 END
    Else Case When F_N3 = 0 Then Case When F_CBM * F_N2 >= F_Lbs Then F_Cbm Else F_Lbs / F_N2 End
    Else Case When F_Cbm * F_N2 >= F_Kgs Then F_Cbm Else F_Kgs / F_N2 End End End) as F_HCBM,
    (CASE WHEN F_N2 = 0 Then Case When f_cbm * 800 >= f_lbs THEN f_cbm ELSE f_lbs / 800 END
    Else Case When F_N3 = 0 Then Case When F_CBM * F_N2 >= F_Lbs Then F_Cbm Else F_Lbs / F_N2 End
    Else Case When F_Cbm * F_N2 >= F_Kgs Then F_Cbm Else F_Kgs / F_N2 End End End) as F_HCBMP
From T_OOHMAIN Left Join T_AotherInfo A On A.F_Tbname = 'T_CODEDATA' And A.F_Tbid = 0 And A.F_Type = 1

Union
SELECT
    F_AIMBLID As F_MBLID,
    T_AIHMAIN.F_ID As F_TBID,
    'T_AIMMAIN' As F_MTBName,
    'T_AIHMAIN' As F_TBName,
    T_AIHMAIN.F_ChgWeight as F_HCBM,
    T_AIHMAIN.F_Grossweight as F_HCBMP
From T_AIHMAIN

Union
SELECT 
    F_AOMBLID As F_MBLID,
    T_AOHMAIN.F_ID As F_TBID,
    'T_AOMMAIN' As F_MTBName,
    'T_AOHMAIN' As F_TBName,
    T_AOHMAIN.F_CChgWeight as F_HCBM,
    T_AOHMAIN.F_CGrossweight as F_HCBMP
From T_AOHMAIN
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_Profit_M" ,
                @"
select 
    F_TBNAME, F_TBID, F_Currency,
    sum(MAR) as F_MAR,
    sum(MAP) as F_MAP,
    sum(MmCrDr) as F_MmCrDr,
    sum(MmCrDrP) as F_MmCrDrP,
    sum(MasterTotal) As F_MasterTotal
From
((select F_TBNAME, F_Tbid, T_InvoHD.F_Currency,
sum(F_InvoiceAmt) as MAR,
0 as MAP, 0 as MmCrDr, 0 as MmCrDrP,
sum(F_InvoiceAmt) As MasterTotal
From T_InvoHD
where F_TBNAME in ('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN')
group by F_TBNAME, F_Tbid, T_InvoHD.F_Currency)
Union All
(select F_TBNAME, F_Tbid, T_ApHD.F_Currency,
0 as MAR,
sum(F_InvoiceAmt) as MAP,
0 as MmCrDr, 0 as MmCrDrP,
sum(-F_InvoiceAmt) As MasterTotal
From T_ApHD
where F_TBNAME in ('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN')
group by F_TBNAME, F_tbid, T_ApHD.F_Currency)

Union All
(select F_STBNAME as F_TBName, f_STbid as F_TBID, T_CrDbHD.F_Currency,
0 as MAR, 0 as MAP,
sum(case when F_PShareField<>'1' then F_Debit - F_Credit else 0 end) as MmCrDr,
sum(case F_PShareField when '1' then F_Debit - F_Credit else 0 end) as MmCrDrP,
sum(F_Debit - F_Credit) As MasterTotal
From T_CrDbDetail
inner join T_CrDbHD on T_CrDbDetail.F_CrDbHDID=T_CrDbHD.F_ID
where F_TBNAME=F_STBNAME and F_TBNAME in
('T_OIMMAIN', 'T_OOMMAIN', 'T_AIMMAIN', 'T_AOMMAIN')
group by F_STBNAME, F_Stbid, T_CrDbHD.F_Currency)
) xx
group by F_TBNAME, F_TBID,  F_Currency
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_PROFIT_House" ,
                @"
select  
    F_TBName, F_TBID,  F_Currency,
    sum(F_AR) as F_AR,
    sum(F_ARPaid) as F_ARPaid,
    sum(F_AP) as F_AP,
    sum(F_CrDr) as F_CrDr,
    sum(F_CrDrP) as F_CrDrP,
    sum(F_MHShare) as F_MHShare,
    sum(F_HouseTotal) As F_HouseTotal
From
(
(select F_TBNAME, F_tbid, T_InvoHD.F_Currency,
sum(F_InvoiceAmt) as F_AR, sum(f_invoiceAmt-f_paidAmt) as F_ARPaid,
0 as F_AP, 0 as F_CrDr, 0 as F_CrDrP, 0 as F_MHShare,
sum(F_InvoiceAmt) As F_HouseTotal
From T_InvoHD
where F_TBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN')
group by F_TBNAME, F_tbid, T_InvoHD.F_Currency)
Union All
(select F_TBName, F_tbid, T_ApHD.F_Currency, 0 as F_AR, 0 as F_ARPaid,
sum(F_InvoiceAmt) as F_AP, 0 as F_CrDr, 0 as F_CrDrP, 0 as F_MHShare,
sum(-F_InvoiceAmt) As F_HouseTotal
From T_ApHD
where F_TBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN')
group by F_TBName, F_tbid, T_ApHD.F_Currency)


Union All
(select F_TBName, F_tbid, T_CrDbHD.F_Currency,
0 as F_AR, 0 as F_ARPaid, 0 as F_AP,
sum(case when F_PShareField<>'1' then F_Debit - F_Credit else 0 end) as F_CrDr,
sum(case F_PShareField when '1' then F_Debit - F_Credit else 0 end) as F_CrDrP,
0 as F_MHShare,
sum(F_Debit - F_Credit) As F_HouseTotal
from T_CrDbDetail inner join T_CrDbHD on T_CrDbDetail.F_CrDbHDID=T_CrDbHD.F_ID
where F_TBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN')
group by F_TBName, f_tbid, T_CrDbHD.f_currency)
Union All
(select f_STBName as F_TBName, F_Stbid as F_TBID, T_CrDbHD.F_Currency,
0 as F_AR, 0 as F_ARPaid, 0 as F_AP, sum(F_Debit-F_Credit) as F_CrDr, 0 as F_CrDrP, 0 as F_MHShare,
sum(F_Debit - F_Credit) As F_HouseTotal
From T_CrDbDetail
inner join T_CrDbHD on T_CrDbHD.F_ID=T_CrDbDetail.F_CrDbHDID
Where F_TBNAME <> f_STBName
and F_STBNAME in ('T_OIHMAIN', 'T_OOHMAIN', 'T_AIHMAIN', 'T_AOHMAIN')
group by f_STBName, F_stbid, T_CrDbHD.f_currency)


Union All
(select v3.f_tbname, v3.f_tbid, v1.F_Currency,
(case when COALESCE(v2.F_MCBM, 0)=0 then v1.F_MAR
else v1.F_MAR *  (v3.F_HCBM / v2.F_MCBM) end) as F_AR,
0 as F_ARPaid,
(case when COALESCE(v2.F_MCBMP, 0)=0 then v1.F_MAP
else v1.F_MAP * (v3.F_HCBMP / v2.F_MCBMP) end) as F_AP,
(case when COALESCE(v2.F_MCBM, 0)=0 then v1.F_MmCrDr
else v1.F_MmCrDr * (v3.F_HCBM / v2.F_MCBM) end) as F_CrDr,
(case when COALESCE(v2.F_MCBM, 0)=0 then v1.F_MmCrDrP
else v1.F_MmCrDrP * (v3.F_HCBM / v2.F_MCBM) end) as F_CrDrP,
(case when COALESCE(v2.F_MCBM, 0)=0 OR COALESCE(v2.F_MCBMP, 0)=0
then (v1.F_MAR-v1.F_MAP+v1.F_MmCrDr)
else (v1.F_MAR+v1.F_MmCrDr) * (v3.F_HCBM / v2.F_MCBM) - v1.F_MAP * (v3.F_HCBMP / v2.F_MCBMP)  end) as F_MHShare,
(case when COALESCE(v2.F_MCBM, 0)=0 OR COALESCE(v2.F_MCBMP, 0)=0
then (v1.F_MAR-v1.F_MAP+v1.F_MmCrDr)
else (v1.F_MAR+v1.F_MmCrDr) * (v3.F_HCBM / v2.F_MCBM) - v1.F_MAP * (v3.F_HCBMP / v2.F_MCBMP)  end) as F_HouseTotal
from V_Profit_M v1
inner join V_Profit_Mwt v2 on v1.f_tbname=v2.f_tbname and v1.f_tbid=v2.f_tbid
inner join V_Profit_Hwt v3 on v1.f_tbname=v3.f_mtbname and v1.f_tbid=v3.f_mblid)
) xx
group by F_TBName, F_TBID, F_Currency
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_H_Memo" ,
                @" 
SELECT 
    f_title, f_contents, f_tbname, f_blno, f_type, f_tbid, f_u1date,f_u2date, f_u1id, f_u2id, hid, f_id AS f_memoid
FROM  (
(SELECT   f_title, f_contents, f_tbname, f_hblno AS f_blno, 'OOH' AS f_type, f_tbid,
t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, h.f_id AS hid, t .f_id
FROM t_oohmain AS h INNER JOIN t_memo AS t ON h.f_id = t .f_tbid AND t .f_tbname = 'T_OOHMain'
Union
SELECT 
    f_title, f_contents, f_tbname, f_mblno AS f_blno, 'OOM' AS f_type,f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, h.f_id AS hid,t .f_id
FROM t_oommain AS m INNER JOIN t_oohmain AS h ON h.f_oomblid = m.f_id
INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_OOMMain'
Union
SELECT 
    f_title, f_contents, f_tbname, '' f_blno, 'CUST' AS f_type, f_tbid,t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t .f_id
FROM t_company AS c INNER JOIN
t_oohmain AS h ON h.f_customer = c.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT 
    f_title, f_contents, f_tbname, '' f_blno, 'AGNT' AS f_type, f_tbid,t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t.f_id
FROM t_company AS c INNER JOIN
t_oohmain AS h ON h.f_agent = c.f_id INNER JOIN
t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT 
    f_title, f_contents, t.f_tbname, f_invoiceno AS f_blno, 'INVO' AS f_type,t.f_tbid, t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, i.f_tbid AS hid, t .f_id
FROM t_invohd AS i INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_INVOHD' Where i.f_tbname = 'T_OOHMAIN'
Union
SELECT 
    f_title, f_contents, t.f_tbname, f_crdbno AS f_blno, 'CRDR' AS f_type,t.f_tbid, t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, c.f_tbid AS hid,t.f_id
FROM t_crdbhd AS c INNER JOIN
t_memo AS t ON c.f_id = t.f_tbid AND t.f_tbname = 'T_CRDBHD' Where c.f_tbname = 'T_OOHMAIN'
Union
SELECT 
    f_title, f_contents, t.f_tbname, f_invoiceno AS f_blno, 'AP' AS f_type,t.f_tbid, t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, i.f_tbid AS hid,t.f_id
FROM t_aphd AS i INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_APHD' Where i.f_tbname = 'T_OOHMAIN' )
Union
(SELECT 
    f_title, f_contents, f_tbname, f_hblno AS f_blno, 'OIH' AS f_type, f_tbid,t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t.f_id
FROM t_oihmain AS h INNER JOIN t_memo AS t ON h.f_id = t.f_tbid AND t.f_tbname = 'T_OiHMain'
Union
SELECT 
    f_title, f_contents, f_tbname, f_mblno AS f_blno, 'OIM' AS f_type, f_tbid, t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t.f_id
FROM t_oimmain AS m INNER JOIN t_oihmain AS h ON h.f_oimblid = m.f_id INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_OiMMain'
Union
SELECT
    f_title, f_contents, f_tbname, '' f_blno, 'CUST' AS f_type, f_tbid, t.f_u1date,t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t.f_id
FROM t_company AS c INNER JOIN t_oihmain AS h ON h.f_customer = c.f_id INNER JOIN t_memo AS t ON c.f_id = t.f_tbid AND t.f_tbname = 'T_COMPANY'
Union
SELECT 
    f_title, f_contents, f_tbname, '' f_blno, 'AGNT' AS f_type, f_tbid, t.f_u1date,t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t.f_id
FROM  t_company AS c INNER JOIN t_oimmain AS m ON m.f_agent = c.f_id LEFT JOIN t_oihmain AS h ON h.f_oimblid = m.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT 
    f_title, f_contents, t.f_tbname, f_invoiceno AS f_blno, 'INVO' AS f_type, t.f_tbid, t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, i.f_tbid AS hid, t.f_id
FROM  t_invohd AS i INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_INVOHD' Where i.f_tbname = 'T_OIHMAIN'
Union
SELECT
    f_title, f_contents, t.f_tbname, f_crdbno AS f_blno, 'CRDR' AS f_type, t.f_tbid,t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, c.f_tbid AS hid, t.f_id
FROM t_crdbhd AS c INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_CRDBHD' Where c.f_tbname = 'T_OIHMAIN'
Union
SELECT
    f_title, f_contents, t.f_tbname, f_invoiceno AS f_blno, 'AP' AS f_type, t.f_tbid,t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, i.f_tbid AS hid, t.f_id
FROM t_aphd AS i INNER JOIN t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_APHD' Where i.f_tbname = 'T_OIHMAIN' )
Union
(SELECT 
    f_title, f_contents, f_tbname, f_hawbno AS f_blno, 'AIH' AS f_type, f_tbid,t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t.f_id
FROM t_aihmain AS h INNER JOIN t_memo AS t ON h.f_id = t .f_tbid AND t .f_tbname = 'T_AIHMain'
Union
SELECT
    f_title, f_contents, f_tbname, f_mawbno AS f_blno, 'AIM' AS f_type, f_tbid,t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t.f_id
FROM t_aimmain AS m INNER JOIN t_aihmain AS h ON h.f_aimblid = m.f_id INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_AIMMain'
Union
SELECT
    f_title, f_contents, f_tbname, '' f_blno, 'CUST' AS f_type, f_tbid, t .f_u1date,t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t.f_id
FROM t_company AS c INNER JOIN t_aihmain AS h ON h.f_customer = c.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT
    f_title, f_contents, f_tbname, '' f_blno, 'AGNT' AS f_type, f_tbid, t .f_u1date,t.f_u2date, t.f_u1id, t.f_u2id, h.f_id AS hid, t .f_id
FROM t_company AS c INNER JOIN t_aihmain AS h ON h.f_agent = c.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'INVO' AS f_type, t.f_tbid,t.f_u1date, t.f_u2date, t.f_u1id, t.f_u2id, i.f_tbid AS hid, t.f_id
FROM t_invohd AS i INNER JOIN t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_INVOHD' Where i.f_tbname = 'T_AIHMAIN'
Union
SELECT
    f_title, f_contents, t .f_tbname, f_crdbno AS f_blno, 'CRDR' AS f_type, t .f_tbid,t .f_u1date, t .f_u2date, t.f_u1id, t.f_u2id, c.f_tbid AS hid, t.f_id
FROM  t_crdbhd AS c INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_CRDBHD' Where c.f_tbname = 'T_AIHMAIN'
Union
SELECT
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'AP' AS f_type, t .f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS hid, t .f_id
FROM  t_aphd AS i INNER JOIN t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_APHD' Where i.f_tbname = 'T_AIHMAIN')
Union
(SELECT 
    f_title, f_contents, f_tbname, f_hawbno AS f_blno, 'AOH' AS f_type, f_tbid,t.f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, h.f_id AS hid, t .f_id
FROM  t_aohmain AS h INNER JOIN t_memo AS t ON h.f_id = t .f_tbid AND t .f_tbname = 'T_aoHMain'
Union
SELECT 
    f_title, f_contents, f_tbname, f_mawbno AS f_blno, 'AOM' AS f_type, f_tbid,t.f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, h.f_id AS hid, t .f_id
FROM t_aommain AS m INNER JOIN t_aohmain AS h ON h.f_aomblid = m.f_id INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_aoMMain'
Union
SELECT
    f_title, f_contents, f_tbname, '' f_blno, 'CUST' AS f_type, f_tbid, t .f_u1date,t .f_u2date, t .f_u1id, t .f_u2id, h.f_id AS hid, t .f_id
FROM t_company AS c INNER JOIN t_aohmain AS h ON h.f_customer = c.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT
    f_title, f_contents, f_tbname, '' f_blno, 'AGNT' AS f_type, f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, h.f_id AS hid, t .f_id
FROM      t_company AS c INNER JOIN t_aohmain AS h ON h.f_agent = c.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT 
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'INVO' AS f_type, t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS hid, t .f_id
FROM    t_invohd AS i INNER JOIN t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_INVOHD' Where i.f_tbname = 'T_AOHMAIN'
Union
SELECT
    f_title, f_contents, t .f_tbname, f_crdbno AS f_blno, 'CRDR' AS f_type, t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_tbid AS hid, t .f_id
FROM   t_crdbhd AS c INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_CRDBHD' Where c.f_tbname = 'T_AOHMAIN'
Union
SELECT
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'AP' AS f_type, t .f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS hid, t .f_id
FROM   t_aphd AS i INNER JOIN t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_APHD' Where i.f_tbname = 'T_AOHMAIN')) tx
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_M_OOMemo" ,
                @" 
SELECT
    f_title, f_contents, f_tbname, f_blno, f_type, f_tbid, f_u1date,f_u2date, f_u1id, f_u2id, mid, f_id AS f_memoid
FROM(
(SELECT   f_title, f_contents, f_tbname, f_mblno AS f_blno, 'OOM' AS f_type,f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid,t .f_id
FROM      t_oommain AS m INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_OOMMain'
Union
SELECT 
    f_title, f_contents, f_tbname, f_hblno AS f_blno, 'OOH' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid, t .f_id
FROM      t_oohmain AS h INNER JOIN
t_oommain AS m ON h.f_oomblid = m.f_id INNER JOIN t_memo AS t ON h.f_id = t .f_tbid AND t .f_tbname = 'T_OOHMain'
Union
SELECT  
    f_title, f_contents, f_tbname, '' AS f_blno, 'AGNT' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid, t .f_id
FROM      t_company AS c INNER JOIN
t_oommain AS m ON m.f_agent = c.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT   
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'INVO' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS mid,t .f_id
FROM      t_invohd AS i INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_INVOHD' WHERE   i.f_tbname = 'T_OOMMAIN'
Union
SELECT   
    f_title, f_contents, t .f_tbname, f_crdbno AS f_blno, 'CRDR' AS f_type, t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_tbid AS mid,t .f_id
FROM      t_crdbhd AS c INNER JOIN
t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_CRDBHD' WHERE   c.f_tbname = 'T_OOMMAIN'
Union
SELECT  
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'AP' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS mid,t .f_id
FROM      t_aphd AS i INNER JOIN t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_APHD'
WHERE   i.f_tbname = 'T_OOMMAIN')) tx
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_M_OIMemo" ,
                @" 
SELECT 
    f_title, f_contents, f_tbname, f_blno, f_type, f_tbid, f_u1date,f_u2date, f_u1id, f_u2id, mid, f_id AS f_memoid
FROM      (
(SELECT   f_title, f_contents, f_tbname, f_mblno AS f_blno, 'OIM' AS f_type,f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid,t .f_id
FROM      t_oimmain AS m INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_OIMMain'
Union
SELECT   
    f_title, f_contents, f_tbname, f_hblno AS f_blno, 'OIH' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid, t .f_id
FROM      t_oihmain AS h INNER JOIN
t_oimmain AS m ON h.f_oimblid = m.f_id INNER JOIN t_memo AS t ON h.f_id = t .f_tbid AND t .f_tbname = 'T_OIHMain'
Union
SELECT  
    f_title, f_contents, f_tbname, '' AS f_blno, 'AGNT' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid, t .f_id
FROM      t_company AS c INNER JOIN
t_oimmain AS m ON m.f_agent = c.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT 
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'INVO' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS mid,t .f_id
FROM      t_invohd AS i INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_INVOHD' WHERE   i.f_tbname = 'T_OIMMAIN'
Union
SELECT 
    f_title, f_contents, t .f_tbname, f_crdbno AS f_blno, 'CRDR' AS f_type, t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_tbid AS mid,t .f_id
FROM      t_crdbhd AS c INNER JOIN
t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_CRDBHD' WHERE   c.f_tbname = 'T_OIMMAIN'
Union
SELECT 
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'AP' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS mid,t .f_id
FROM      t_aphd AS i INNER JOIN t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_APHD'
WHERE   i.f_tbname = 'T_OIMMAIN')) tx
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_M_AOMemo" ,
                @" 
SELECT  
    f_title, f_contents, f_tbname, f_blno, f_type, f_tbid, f_u1date,f_u2date, f_u1id, f_u2id, mid, f_id AS f_memoid
FROM      (
(SELECT   f_title, f_contents, f_tbname, f_mawbno AS f_blno, 'AOM' AS f_type,f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid,t .f_id
FROM      t_aommain AS m INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_AOMMain'
Union
SELECT
    f_title, f_contents, f_tbname, f_hawbno AS f_blno, 'AOH' AS f_type,f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid,t .f_id
FROM      t_aohmain AS h INNER JOIN
t_aommain AS m ON h.f_aomblid = m.f_id INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_AOHMain'
Union
SELECT
    f_title, f_contents, f_tbname, '' f_blno, 'AGNT' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid, t .f_id
FROM      t_company AS c INNER JOIN
t_aommain AS m ON m.f_agent = c.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'INVO' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS mid,t .f_id
FROM      t_invohd AS i INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_INVOHD' WHERE   i.f_tbname = 'T_AOMMAIN'
Union
SELECT 
    f_title, f_contents, t .f_tbname, f_crdbno AS f_blno, 'CRDR' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_tbid AS mid,t .f_id
FROM      t_crdbhd AS c INNER JOIN
t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_CRDBHD' WHERE   c.f_tbname = 'T_AOMMAIN'
Union
SELECT   
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'AP' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS mid,t .f_id
FROM      t_aphd AS i INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_APHD' WHERE   i.f_tbname = 'T_AOMMAIN')) tx
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_M_AIMemo" ,
                @" 
SELECT   
    f_title, f_contents, f_tbname, f_blno, f_type, f_tbid, f_u1date,f_u2date, f_u1id, f_u2id, mid, f_id AS f_memoid
FROM      (
(SELECT
    f_title, f_contents, f_tbname, f_mawbno AS f_blno, 'AIM' AS f_type,f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid,t .f_id
FROM      t_aimmain AS m INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_AIMMain'
Union
SELECT  
    f_title, f_contents, f_tbname, f_hawbno AS f_blno, 'AIH' AS f_type,f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid,t .f_id
FROM      t_aihmain AS h INNER JOIN
t_aommain AS m ON h.f_aimblid = m.f_id INNER JOIN t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_AIHMain'
Union
SELECT 
    f_title, f_contents, f_tbname, '' f_blno, 'AGNT' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, m.f_id AS mid, t .f_id
FROM      t_company AS c INNER JOIN
t_aommain AS m ON m.f_agent = c.f_id INNER JOIN t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_COMPANY'
Union
SELECT 
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'INVO' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS mid,t .f_id
FROM      t_invohd AS i INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_INVOHD' WHERE   i.f_tbname = 'T_AIMMAIN'
Union
SELECT  
    f_title, f_contents, t .f_tbname, f_crdbno AS f_blno, 'CRDR' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_tbid AS mid,t .f_id
FROM      t_crdbhd AS c INNER JOIN
t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_CRDBHD' WHERE   c.f_tbname = 'T_AIMMAIN'
Union
SELECT
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'AP' AS f_type,t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_tbid AS mid,t .f_id
FROM      t_aphd AS i INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_APHD' WHERE   i.f_tbname = 'T_AIMMAIN')) tx
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_M_Memo" ,
                @" 
SELECT   *
From v_m_oomemo
Union
SELECT   *
From v_m_oimemo
Union
SELECT   *
From v_m_aomemo
Union
SELECT   *
From v_m_aimemo
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_C_Memo" ,
                @" 
SELECT  
    f_title, f_contents, f_tbname, f_blno, f_type, f_tbid, f_u1date,f_u2date, f_u1id, f_u2id, cid, f_id AS f_memoid
FROM      (
(SELECT   f_title, f_contents, f_tbname, f_hblno AS f_blno, 'OOH' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_id AS cid, t .f_id
FROM      t_oohmain AS h INNER JOIN
t_memo AS t ON h.f_id = t .f_tbid AND t .f_tbname = 'T_oohmain' INNER JOIN
t_company AS c ON h.f_agent = c.f_id OR h.f_customer = c.f_id
Union
SELECT   
    f_title, f_contents, f_tbname, f_mblno AS f_blno, 'OOM' AS f_type,f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_id AS cid,t .f_id
FROM      t_oommain AS m INNER JOIN
t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_oommain' INNER JOIN
t_company AS c ON m.f_agent = c.f_id)

Union
(SELECT   f_title, f_contents, f_tbname, f_hblno AS f_blno, 'OIH' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_id AS cid, t .f_id
FROM      t_oihmain AS h INNER JOIN
t_memo AS t ON h.f_id = t .f_tbid AND t .f_tbname = 'T_oihmain' INNER JOIN
t_company AS c ON h.f_customer = c.f_id
Union
SELECT   f_title, f_contents, f_tbname, f_mblno AS f_blno, 'OIM' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_id AS cid, t .f_id
FROM      t_oimmain AS m INNER JOIN
t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_oimmain' INNER JOIN
t_company AS c ON m.f_agent = c.f_id)

Union
(SELECT   f_title, f_contents, f_tbname, f_hawbno AS f_blno, 'AOH' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_id AS cid, t .f_id
FROM      t_aohmain AS h INNER JOIN
t_memo AS t ON h.f_id = t .f_tbid AND t .f_tbname = 'T_aohmain' INNER JOIN
t_company AS c ON h.f_agent = c.f_id OR h.f_customer = c.f_id
Union
SELECT  
    f_title, f_contents, f_tbname, f_mawbno AS f_blno, 'AOM' AS f_type, f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_id AS cid, t .f_id
FROM      t_aommain AS m INNER JOIN
t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_oommain' INNER JOIN
t_company AS c ON m.f_agent = c.f_id)

Union
(SELECT   f_title, f_contents, f_tbname, f_hawbno AS f_blno, 'AIH' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_id AS cid, t .f_id
FROM      t_aihmain AS h INNER JOIN
t_memo AS t ON h.f_id = t .f_tbid AND t .f_tbname = 'T_aihmain' INNER JOIN
t_company AS c ON h.f_agent = c.f_id OR h.f_customer = c.f_id
Union
SELECT  
    f_title, f_contents, f_tbname, f_mawbno AS f_blno, 'AIM' AS f_type, f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_id AS cid, t .f_id
FROM      t_aimmain AS m INNER JOIN
t_memo AS t ON m.f_id = t .f_tbid AND t .f_tbname = 'T_aimmain' INNER JOIN
t_company AS c ON m.f_agent = c.f_id)

Union
(SELECT   f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'INVO' AS f_type, t .f_tbid,t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_billto AS cid, t .f_id
FROM      t_invohd AS i INNER JOIN
t_company AS c ON i.f_billto = c.f_id INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_INVOHD'
Union
SELECT   
    f_title, f_contents, t .f_tbname, f_invoiceno AS f_blno, 'AP' AS f_type, t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_payto AS cid, t .f_id
FROM      t_aphd AS i INNER JOIN
t_company AS c ON i.f_payto = c.f_id INNER JOIN
t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_APHD'
Union
SELECT  
    f_title, f_contents, t .f_tbname, f_crdbno AS f_blno, 'CRDR' AS f_type, t .f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, i.f_agent AS cid, t .f_id
FROM      t_crdbhd AS i INNER JOIN
t_company AS c ON i.f_agent = c.f_id INNER JOIN t_memo AS t ON i.f_id = t .f_tbid AND t .f_tbname = 'T_CRDBHD')

Union
(SELECT   f_title, f_contents, f_tbname, '' AS f_blno, 'COM' AS f_type, f_tbid, t .f_u1date, t .f_u2date, t .f_u1id, t .f_u2id, c.f_id AS cid, t .f_id
FROM      t_company AS c INNER JOIN
t_memo AS t ON c.f_id = t .f_tbid AND t .f_tbname = 'T_company')) tx
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_OIM_TEU" ,
                @" 
select
    f_svccno,m.f_loadingport,m.f_discharge,m.f_finaldest,a.f_c10 as doordelivery,m.f_mcommodity,c.f_sname,m.f_etd,m.f_eta,m.f_feta,SUM(hcnt) AS HCNT,SUM(f_teu) AS F_TEU,SUM(F_20) AS F_20,SUM(F_40) AS F_40,SUM(F_40H) AS F_40H,SUM(F_45) AS F_45 
from t_oihmain h
left join t_oimmain m on m.f_id=h.f_oimblid
left join t_company c on c.f_id=h.f_customer
left join t_aotherinfo a on a.f_type=5 and a.f_tbname='T_OIHMAIN' and a.f_tbid=h.f_id

left join (select f_oimblid,count(*) as hcnt from t_oihmain group by f_oimblid) hbl on hbl.f_oimblid=m.f_id
left join (select f_oimblid,

SUM(CASE WHEN substring(F_conType, 1, 2) = '20' THEN 1 ELSE 0 END) AS F_20,
SUM(CASE WHEN substring(F_conType, 1, 2) = '40' AND substring(F_conType, 1, 3) <> '40H'   THEN 1 ELSE 0 END) AS F_40,
SUM(CASE WHEN substring(F_conType, 1, 3) = '40H' THEN 1 ELSE 0 END) AS F_40H,
SUM(CASE WHEN substring(F_conType, 1, 2) = '45' THEN 1 ELSE 0 END) AS F_45,
SUM(CASE WHEN substring(F_conType, 1, 2) = '20' THEN 1
WHEN substring(F_conType, 1, 2) = '40' AND substring(F_conType, 1, 3) <> '40H' THEN 2
WHEN substring(F_conType, 1, 3)= '40H' THEN 2.25
WHEN substring(F_conType, 1, 2)= '45' THEN 2.532  ELSE 0 END) AS F_TEU  from t_oimcontainer group by f_oimblid) mcnt on mcnt.f_oimblid=m.f_id
where  HBL.HCNT =1 group by f_svccno,f_loadingport,f_discharge,m.f_finaldest,a.f_c10,m.f_mcommodity,c.f_sname,m.f_etd,m.f_eta,m.f_feta

Union All
select
    f_svccno,m.f_loadingport,m.f_discharge,m.f_finaldest,'FAK' AS  doordelivery,m.f_mcommodity,'FAK' AS f_sname,m.f_etd,m.f_eta,m.f_feta,SUM(hcnt) AS HCNT,
    SUM(f_teu) AS F_TEU,SUM(F_20) AS F_20,SUM(F_40) AS F_40,SUM(F_40H) AS F_40H,SUM(F_45) AS F_45  from t_oiMmain M
left join (select f_oimblid,count(*) as hcnt from t_oihmain group by f_oimblid) hbl on hbl.f_oimblid=m.f_id
left join (select f_oimblid, SUM(CASE WHEN substring(F_conType, 1, 2) = '20' THEN 1 ELSE 0 END) AS F_20,
SUM(CASE WHEN substring(F_conType, 1, 2) = '40' AND substring(F_conType, 1, 3) <> '40H'   THEN 1 ELSE 0 END) AS F_40,
SUM(CASE WHEN substring(F_conType, 1, 3) = '40H' THEN 1 ELSE 0 END) AS F_40H,
SUM(CASE WHEN substring(F_conType, 1, 2) = '45' THEN 1 ELSE 0 END) AS F_45,
SUM(CASE WHEN substring(F_conType, 1, 2) = '20' THEN 1

WHEN substring(F_conType, 1, 2) = '40' AND substring(F_conType, 1, 3) <> '40H' THEN 2
WHEN substring(F_conType, 1, 3)= '40H' THEN 2.25
WHEN substring(F_conType, 1, 2)= '45' THEN 2.532  ELSE 0 END) AS F_TEU  from t_oimcontainer group by f_oimblid) mcnt on mcnt.f_oimblid=m.f_id
where HBL.HCNT > 1group by f_svccno,f_loadingport,f_discharge,m.f_finaldest,m.f_mcommodity,m.f_etd,m.f_eta,m.f_feta
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_MemoAll" ,
                @" 
SELECT  
    M.F_U1DATE,M.F_U1ID,CASE M.F_TBNAME
    WHEN 'T_COMPANY' THEN COM.F_SNAME WHEN 'T_AIHMAIN' THEN AIH.F_HAWBNO WHEN 'T_AIMMAIN' THEN AIM.F_REFNO
    WHEN 'V_ARCOLLECT' THEN COM.F_SNAME WHEN 'T_AOHMAIN' THEN AOH.F_HAWBNO
    WHEN 'T_AOMMAIN' THEN AOM.F_REFNO
    WHEN 'T_OIHMAIN' THEN OIH.F_HBLNO
    WHEN 'T_OIMMAIN' THEN OIM.F_REFNO
    WHEN 'T_OOHMAIN' THEN OOH.F_HBLNO
    WHEN 'T_OOMMAIN' THEN OOM.F_REFNO
    WHEN 'T_APHD' THEN APH.F_INVOICENO
    WHEN 'T_INVOHD' THEN INVO.F_INVOICENO
    WHEN 'T_CRDBHD' THEN CRDB.F_CRDBNO
    WHEN 'T_DEPOHD' THEN DEPO.F_TYPE + ' ' + DEPO.F_CHECKNO
    WHEN 'T_GENMAIN' THEN GEN.F_REFNO
    WHEN 'T_OOHQUOTATION' THEN OOHQ.F_Quoteno
    WHEN 'T_SLIPHD' THEN SLIP.F_MDESC
    WHEN 'T_WRECEIVEHD' THEN WREC.F_receiveno
    WHEN 'T_WSHIPHD' THEN WSHIP.F_pono END REFNO,F_TITLE,F_CONTENTS,M.F_TBNAME,M.F_TBID,M.F_ID
FROM T_MEMO M
LEFT JOIN T_COMPANY COM ON COM.F_ID=M.F_TBID
LEFT JOIN T_AIHMAIN AIH ON AIH.F_ID=M.F_TBID
LEFT JOIN T_AIMMAIN AIM ON AIM.F_ID=M.F_TBID
LEFT JOIN T_AOHMAIN AOH ON AOH.F_ID=M.F_TBID
LEFT JOIN T_AOMMAIN AOM ON AOM.F_ID=M.F_TBID
LEFT JOIN T_OIHMAIN OIH ON OIH.F_ID=M.F_TBID
LEFT JOIN T_OIMMAIN OIM ON OIM.F_ID=M.F_TBID
LEFT JOIN T_OOHMAIN OOH ON OOH.F_ID=M.F_TBID
LEFT JOIN T_OOMMAIN OOM ON OOM.F_ID=M.F_TBID
LEFT JOIN T_APHD APH ON APH.F_ID=M.F_TBID
LEFT JOIN T_INVOHD INVO ON INVO.F_ID=M.F_TBID
LEFT JOIN T_CRDBHD CRDB ON CRDB.F_ID=M.F_TBID
LEFT JOIN T_DEPOHD DEPO ON DEPO.F_ID=M.F_TBID
LEFT JOIN T_GENMAIN GEN ON GEN.F_ID=M.F_TBID
LEFT JOIN T_OOHQUOTATION OOHQ ON OOHQ.F_ID=M.F_TBID
LEFT JOIN T_SLIPHD SLIP ON SLIP.F_ID=M.F_TBID
LEFT JOIN T_WRECEIVEHD WREC ON WREC.F_ID=M.F_TBID
LEFT JOIN T_WSHIPHD WSHIP ON WSHIP.F_ID=M.F_TBID
WHERE M.F_TBNAME IN ('T_COMPANY','T_AIHMAIN','T_AIMMAIN','T_AOHMAIN','T_AOMMAIN','T_OIHMAIN','T_OIMMAIN','T_OOHMAIN','T_OOMMAIN','T_APHD',
'T_INVOHD','T_CRDBHD','T_DEPOHD','T_GENMAIN','T_OOHQUOTATION','T_WRECEIVEHD','T_WSHIPHD','T_SLIPHD','V_ARCOLLECT') AND F_TITLE <> 'Update History'
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "v_inventory" ,
                @"
SELECT
    T_WITEM.F_CENTER_NO, T_WITEM.F_ITEMNO, F_ITEMDESCRIPTION, F_UPCCODE,F_DLOCATION, F_PCSPERBOX, F_BOXUNIT, F_WTPERBOX, F_LENGTH, F_HEIGHT, F_WIDTH, F_CFTPERBOX,
    CASE WHEN ISNULL(IN_PCS,0) - ISNULL(OUT_PCS,0) =0 THEN 0 ELSE ISNULL(IN_QTY,0) - ISNULL(OUT_QTY,0) END AS ONHANDQTY,
    CASE WHEN ISNULL(ALLO_PCS,0) =0 THEN 0 ELSE  ISNULL(ALLO_QTY,0) END AS ALLQTY,
    CASE WHEN ISNULL(IN_PCS,0) - ISNULL(OUT_PCS,0) -ISNULL(ALLO_PCS,0)=0 THEN 0 ELSE  ISNULL(IN_QTY,0) - ISNULL(OUT_QTY,0) -ISNULL(ALLO_QTY,0) END AS AVAILQTY,
    ISNULL(IN_PCS,0) - ISNULL(OUT_PCS,0) AS ONHANDPCS,
    ISNULL(ALLO_PCS,0) AS ALLPCS,ISNULL(IN_PCS,0) - ISNULL(OUT_PCS,0) -ISNULL(ALLO_PCS,0) AS AVAILPCS,
    T_WITEM.F_ID, T_WITEM.F_PIMSLINKID
FROM T_WITEM
LEFT JOIN (
SELECT
    F_CENTER_NO,F_ITEMNO,
    SUM(CASE WHEN H.F_STATUS >= 2 THEN F_BOX ELSE 0 END) AS OUT_QTY,
    SUM(CASE WHEN H.F_STATUS = 1 THEN F_BOX ELSE 0 END) AS ALLO_QTY,
    SUM(CASE WHEN H.F_STATUS >= 2 THEN F_QTY ELSE 0 END) AS OUT_PCS,
    SUM(CASE WHEN H.F_STATUS = 1 THEN F_QTY ELSE 0 END) AS ALLO_PCS
FROM T_WSHIPITEM D
LEFT JOIN T_WSHIPHD H ON H.F_ID = D.F_WSHIPHD
WHERE H.F_VOID = 0
GROUP BY F_CENTER_NO, F_ITEMNO
) WW ON WW.F_ITEMNO = T_WITEM.F_ITEMNO AND WW.F_CENTER_NO = T_WITEM.F_CENTER_NO

LEFT JOIN (
SELECT
F_CENTER_NO, F_ITEMNO,
SUM(CASE WHEN H.F_STATUS >= 2 THEN F_BOX ELSE 0 END) AS IN_QTY,
SUM(CASE WHEN H.F_STATUS >= 2 THEN F_QTY ELSE 0 END) AS IN_PCS
FROM T_WRECEIVEITEM D
LEFT JOIN T_WRECEIVEHD H ON H.F_ID = D.F_WRECEIVEHD
WHERE H.F_VOID = 0
GROUP BY F_CENTER_NO, F_ITEMNO
) WR ON WR.F_ITEMNO=T_WITEM.F_ITEMNO AND WR.F_CENTER_NO=T_WITEM.F_CENTER_NO& vbCrLf
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "v_inventoryByLoc" ,
                @"
SELECT
T_WITEM.F_CENTER_NO, T_WITEM.F_ITEMNO, T_WITEM.F_ITEMDESCRIPTION, F_UPCCODE,F_LOCATION, F_PCSPERBOX, F_BOXUNIT, F_WTPERBOX, F_CFTPERBOX,
SUM(ISNULL(IN_QTY,0) - ISNULL(OUT_QTY,0)) AS ONHANDQTY, SUM(ISNULL(ALLO_QTY,0)) AS ALLQTY,
SUM(ISNULL(IN_QTY,0) - ISNULL(OUT_QTY,0) - ISNULL(ALLO_QTY,0)) AS AVAILQTY, SUM(ISNULL(IN_PCS,0) - ISNULL(OUT_PCS,0)) AS ONHANDPCS,
SUM(ISNULL(ALLO_PCS,0)) AS ALLPCS, SUM(ISNULL(IN_PCS,0) - ISNULL(OUT_PCS,0) - ISNULL(ALLO_PCS,0)) AS AVAILPCS, T_WITEM.F_ID
FROM T_WITEM
LEFT JOIN (
SELECT
F_CENTER_NO, F_ITEMNO, F_LOCATION, 0 AS IN_QTY, 0 AS IN_PCS,
SUM(CASE WHEN H.F_STATUS >=2 THEN F_BOX ELSE 0 END) AS OUT_QTY, SUM(CASE WHEN H.F_STATUS = 1 THEN F_BOX ELSE 0 END) AS ALLO_QTY,
SUM(CASE WHEN H.F_STATUS >= 2 THEN F_QTY ELSE 0 END) AS OUT_PCS, SUM(CASE WHEN H.F_STATUS = 1 THEN F_QTY ELSE 0 END) AS ALLO_PCS
FROM T_WSHIPITEM D
LEFT JOIN T_WSHIPHD H ON H.F_ID = D.F_WSHIPHD
WHERE H.F_VOID = 0
GROUP BY F_CENTER_NO, F_ITEMNO, F_LOCATION

UNION ALL
SELECT
F_CENTER_NO, F_ITEMNO, F_LOCATION, SUM(CASE WHEN H.F_STATUS >= 2 THEN F_BOX ELSE 0 END) AS IN_QTY,
SUM(CASE WHEN H.F_STATUS >= 2 THEN F_QTY ELSE 0 END) AS IN_PCS, 0 AS OUT_QTY, 0 AS ALLO_QTY, 0 AS OUT_PCS, 0 AS ALLO_PCS
FROM T_WRECEIVEITEM D
LEFT JOIN T_WRECEIVEHD H ON H.F_ID = D.F_WRECEIVEHD
WHERE H.F_VOID = 0
GROUP BY F_CENTER_NO, F_ITEMNO, F_LOCATION
) WR ON WR.F_ITEMNO = T_WITEM.F_ITEMNO AND WR.F_CENTER_NO = T_WITEM.F_CENTER_NO
WHERE ISNULL(IN_PCS,0) - ISNULL(OUT_PCS,0) - ISNULL(ALLO_PCS,0) <> 0
GROUP BY T_WITEM.F_CENTER_NO, T_WITEM.F_ITEMNO, T_WITEM.F_ITEMDESCRIPTION, F_UPCCODE, F_LOCATION, F_PCSPERBOX, F_BOXUNIT, F_WTPERBOX, F_CFTPERBOX, T_WITEM.F_ID
HAVING SUM(ISNULL(IN_PCS,0) - ISNULL(OUT_PCS,0) - ISNULL(ALLO_PCS,0)) <> 0
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_MyProfitShare" ,
                @"
SELECT
'T_OIHMAIN' AS F_TBName, F_Id As F_TbId, 'T_OIMMAIN' AS F_MTBName, F_OIMBLID As F_MTBId, F_HCount,
CASE COALESCE(TW2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE (CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) / TW2.F_MCBM END AS F_MyShare,
CASE COALESCE(TW2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE (CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) / TW2.F_MCBM END AS F_MyShareP
FROM T_OIHMAIN TW1
LEFT JOIN (
SELECT F_OIMBLID AS F_MTBId, COUNT(F_ID) AS F_HCount, SUM(CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) as F_MCBM FROM T_OIHMAIN GROUP BY F_OIMBLID
) TW2 ON TW2.F_MTBId = TW1.F_OIMBLID& vbCrLf

UNION ALL
SELECT
'T_OOHMAIN' AS F_TBName, F_Id As F_TbId, 'T_OOMMAIN' AS F_MTBName, F_OOMBLID As F_MTBId, F_HCount,
CASE COALESCE(TW2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE (CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) / TW2.F_MCBM END AS F_MyShare,
CASE COALESCE(TW2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE (CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) / TW2.F_MCBM END AS F_MyShareP
FROM T_OOHMAIN TW1
LEFT JOIN (
SELECT F_OOMBLID AS F_MTBId, COUNT(F_ID) AS F_HCount, SUM(CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) as F_MCBM FROM T_OOHMAIN GROUP BY F_OOMBLID
) TW2 ON TW2.F_MTBId = TW1.F_OOMBLID& vbCrLf

UNION ALL
SELECT
'T_AIHMAIN' AS F_TBName, F_Id As F_TbId, 'T_AIMMAIN' AS F_MTBName, F_AIMBLID As F_MTBId, F_HCount,
CASE COALESCE(TW2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE F_ChgWeight / TW2.F_MCBM END AS F_MyShare,
CASE COALESCE(TW2.F_MCBMP, 0) WHEN 0 THEN 1.0 / F_HCount ELSE F_GROSSWeight / TW2.F_MCBMP END AS F_MyShareP
FROM T_AIHMAIN TW1
LEFT JOIN (
SELECT F_AIMBLID AS F_MTBId, COUNT(F_ID) AS F_HCount, SUM(F_ChgWeight) as F_MCBM, SUM(F_GROSSWeight) AS F_MCBMP FROM T_AIHMAIN GROUP BY F_AIMBLID
) TW2 ON TW2.F_MTBId = TW1.F_AIMBLID& vbCrLf

UNION ALL
SELECT
'T_AOHMAIN' AS F_TBName, F_Id As F_TBId, 'T_AOMMAIN' AS F_MTBName, F_AOMBLID As MId, F_HCount,
CASE COALESCE(TW2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE F_ChgWeight / TW2.F_MCBM END AS F_MyShare,
CASE COALESCE(TW2.F_MCBMP, 0) WHEN 0 THEN 1.0 / F_HCount ELSE F_GROSSWeight / TW2.F_MCBMP END AS F_MyShareP
FROM T_AOHMAIN TW1
LEFT JOIN (
SELECT F_AOMBLID AS F_MTBId,COUNT(F_ID) AS F_HCount, SUM(F_CChgWeight) as F_MCBM, SUM(F_CGROSSWeight) AS F_MCBMP FROM T_AOHMAIN GROUP BY F_AOMBLID
) TW2 ON TW2.F_MTBId = TW1.F_AOMBLID& vbCrLf
"},
/////////////////////////////////////////////////////Table_NView
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_OpStatusbyTable" ,
                @"
SELECT F_TBNAME,F_TBID
, MIN(CASE WHEN F_CHGTYPE IN (1,2,3,4) AND (F_POSTED < 2 ) THEN '0' WHEN F_CHGTYPE IN (1,2,3,4) AND F_POSTED > 1 THEN '1' WHEN F_CHGTYPE IN (1,2,3,4) THEN '*' ELSE '1'  END) AS F_INVOK
, MIN(CASE WHEN F_CHGTYPE IN (11,12,13,14) AND (F_POSTED < 2 ) THEN '0' WHEN F_CHGTYPE IN (11,12,13,14) AND (F_POSTED > 1 ) THEN  '1' WHEN F_CHGTYPE IN (11,12,13,14) THEN '*' ELSE '1' END) AS F_APOK
, MIN(CASE WHEN (F_AGENTAMT <> 0 ) AND (F_POSTED > 2 )  and f_settled='1' THEN '1'  WHEN (F_AGENTAMT <> 0 ) AND (F_POSTED > 2 )  THEN '0' WHEN (F_AGENTAMT <> 0 ) THEN '*' ELSE '1' END) AS F_CrDBOK
FROM T_OPACCT GROUP BY F_TBNAME,F_TBID
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_OIMSTATUS" ,
                @"
SELECT F_ID,CASE WHEN F_MAPC='1' AND F_MINVC ='1' AND F_MCRDBC='1'AND  F_APC in ('*','1') AND F_INVC in ('*','1') AND  F_CRDBC in ('*','1') THEN 'C' ELSE 'NC'END AS F_BL,
CASE WHEN F_MAPC='1' THEN 'C' ELSE 'NC' END AS F_BI,
CASE WHEN F_MINVC='1' THEN 'C' ELSE 'NC' END AS F_IN,
CASE WHEN F_MCRDBC='1' THEN 'C' ELSE 'NC' END AS F_CD
FROM (

select M.F_ID,
CASE WHEN F_CompleteBill='1'THEN '1' ELSE '0' END AS F_MAPC,
CASE WHEN F_CompleteInvo='1'THEN '1' ELSE '0' END AS F_MINVC,
CASE WHEN F_CompleteCrDb='1'THEN '1' ELSE '0' END AS F_MCRDBC,
ISNULL(F_APC,'*') AS F_APC, ISNULL(F_INVC,'*') AS F_INVC, ISNULL(F_CRDBC,'*') AS F_CRDBC
from T_OIMMAIN M LEFT JOIN
(SELECT F_OIMBLID, MIN(CASE WHEN F_CompleteBill='1'THEN '1' ELSE '0' END) AS F_APC,
MIN(CASE WHEN F_CompleteInvo='1'THEN '1' ELSE '0' END) AS F_INVC,
MIN(CASE WHEN F_CompleteCrDb='1'THEN '1' ELSE '0' END) AS F_CRDBC
FROM T_OIHMAIN GROUP BY F_OIMBLID)
YY  ON YY.F_OIMBLID=M.F_ID ) ZZ
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_OIHSTATUS" ,
                @"
SELECT F_ID,
CASE WHEN F_CompleteBill='1' THEN 'C' ELSE 'NC' END AS F_BI,
CASE WHEN F_CompleteInvo='1' THEN 'C' ELSE 'NC' END AS F_IN,
CASE WHEN  F_CompleteCrDb ='1' THEN 'C' ELSE 'NC' END AS F_CD
FROM T_OIHMAIN
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_OOMSTATUS" ,
                @"
SELECT F_ID,CASE WHEN F_MAPC='1' AND F_MINVC ='1' AND F_MCRDBC='1'AND  F_APC in ('*','1') AND F_INVC in ('*','1') AND  F_CRDBC in ('*','1') THEN 'C' ELSE 'NC'END AS F_BL,
CASE WHEN F_MAPC='1' THEN 'C' ELSE 'NC' END AS F_BI,
CASE WHEN F_MINVC='1' THEN 'C' ELSE 'NC' END AS F_IN,
CASE WHEN F_MCRDBC='1' THEN 'C' ELSE 'NC' END AS F_CD
FROM (

select M.F_ID,
CASE WHEN F_CompleteBill='1'THEN '1' ELSE '0' END AS F_MAPC,
CASE WHEN F_CompleteInvo='1'THEN '1' ELSE '0' END AS F_MINVC,
CASE WHEN F_CompleteCrDb='1'THEN '1' ELSE '0' END AS F_MCRDBC,
ISNULL(F_APC,'*') AS F_APC, ISNULL(F_INVC,'*') AS F_INVC, ISNULL(F_CRDBC,'*') AS F_CRDBC
from T_OOMMAIN M  LEFT JOIN
(SELECT F_OOMBLID, MIN(CASE WHEN F_CompleteBill='1'THEN '1' ELSE '0' END) AS F_APC,
MIN(CASE WHEN F_CompleteInvo='1'THEN '1' ELSE '0' END) AS F_INVC,
MIN(CASE WHEN F_CompleteCrDb='1'THEN '1' ELSE '0' END) AS F_CRDBC
FROM T_OOHMAIN GROUP BY F_OOMBLID)
YY  ON YY.F_OOMBLID=M.F_ID ) ZZ
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_OOHSTATUS" ,
                @"
SELECT F_ID,
CASE WHEN F_CompleteBill='1' THEN 'C' ELSE 'NC' END AS F_BI,
CASE WHEN F_CompleteInvo='1' THEN 'C' ELSE 'NC' END AS F_IN,
CASE WHEN  F_CompleteCrDb ='1' THEN 'C' ELSE 'NC' END AS F_CD
FROM T_OOHMAIN
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_AIMSTATUS" ,
                @"
SELECT F_ID,CASE WHEN F_MAPC='1' AND F_MINVC ='1' AND F_MCRDBC='1'AND  F_APC in ('*','1') AND F_INVC in ('*','1') AND  F_CRDBC in ('*','1') THEN 'C' ELSE 'NC'END AS F_BL,
CASE WHEN F_MAPC='1' THEN 'C' ELSE 'NC' END AS F_BI,
CASE WHEN F_MINVC='1' THEN 'C' ELSE 'NC' END AS F_IN,
CASE WHEN F_MCRDBC='1' THEN 'C' ELSE 'NC' END AS F_CD
FROM (

select M.F_ID,
CASE WHEN F_CompleteBill='1'THEN '1' ELSE '0' END AS F_MAPC,
CASE WHEN F_CompleteInvo='1'THEN '1' ELSE '0' END AS F_MINVC,
CASE WHEN F_CompleteCrDb='1'THEN '1' ELSE '0' END AS F_MCRDBC,
ISNULL(F_APC,'*') AS F_APC, ISNULL(F_INVC,'*') AS F_INVC, ISNULL(F_CRDBC,'*') AS F_CRDBC
from T_AIMMAIN M LEFT JOIN
(SELECT F_AIMBLID, MIN(CASE WHEN F_CompleteBill='1'THEN '1' ELSE '0' END) AS F_APC,
MIN(CASE WHEN F_CompleteInvo='1'THEN '1' ELSE '0' END) AS F_INVC,
MIN(CASE WHEN F_CompleteCrDb='1'THEN '1' ELSE '0' END) AS F_CRDBC
FROM T_AIHMAIN GROUP BY F_AIMBLID)
YY  ON YY.F_AIMBLID=M.F_ID ) ZZ
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_AIHSTATUS" ,
                @"
SELECT F_ID,
CASE WHEN F_CompleteBill='1' THEN 'C' ELSE 'NC' END AS F_BI,
CASE WHEN F_CompleteInvo='1' THEN 'C' ELSE 'NC' END AS F_IN,
CASE WHEN  F_CompleteCrDb ='1' THEN 'C' ELSE 'NC' END AS F_CD
FROM T_AIHMAIN
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_AOMSTATUS" ,
                @"
SELECT F_ID,CASE WHEN F_MAPC='1' AND F_MINVC ='1' AND F_MCRDBC='1'AND  F_APC in ('*','1') AND F_INVC in ('*','1') AND  F_CRDBC in ('*','1') THEN 'C' ELSE 'NC'END AS F_BL,
CASE WHEN F_MAPC='1' THEN 'C' ELSE 'NC' END AS F_BI,
CASE WHEN F_MINVC='1' THEN 'C' ELSE 'NC' END AS F_IN,
CASE WHEN F_MCRDBC='1' THEN 'C' ELSE 'NC' END AS F_CD
FROM (

select M.F_ID,
CASE WHEN F_CompleteBill='1'THEN '1' ELSE '0' END AS F_MAPC,
CASE WHEN F_CompleteInvo='1'THEN '1' ELSE '0' END AS F_MINVC,
CASE WHEN F_CompleteCrDb='1'THEN '1' ELSE '0' END AS F_MCRDBC,
ISNULL(F_APC,'*') AS F_APC, ISNULL(F_INVC,'*') AS F_INVC, ISNULL(F_CRDBC,'*') AS F_CRDBC
from T_AOMMAIN M LEFT JOIN
(SELECT F_AOMBLID, MIN(CASE WHEN F_CompleteBill='1'THEN '1' ELSE '0' END) AS F_APC,
MIN(CASE WHEN F_CompleteInvo='1'THEN '1' ELSE '0' END) AS F_INVC,
MIN(CASE WHEN F_CompleteCrDb='1'THEN '1' ELSE '0' END) AS F_CRDBC
FROM T_AOHMAIN GROUP BY F_AOMBLID)
YY  ON YY.F_AOMBLID=M.F_ID ) ZZ
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_AOHSTATUS" ,
                @"
SELECT F_ID,
CASE WHEN F_CompleteBill='1' THEN 'C' ELSE 'NC' END AS F_BI,
CASE WHEN F_CompleteInvo='1' THEN 'C' ELSE 'NC' END AS F_IN,
CASE WHEN  F_CompleteCrDb ='1' THEN 'C' ELSE 'NC' END AS F_CD
FROM T_AOHMAIN
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_GENSTATUS" ,
                @"
SELECT F_ID,
CASE WHEN F_CompleteBill='1' AND F_CompleteInvo='1' AND  F_CompleteCrDb ='1' THEN 'C' ELSE 'NC' END AS F_BL,
CASE WHEN F_CompleteBill='1' THEN 'C' ELSE 'NC' END AS F_BI,
CASE WHEN F_CompleteInvo='1' THEN 'C' ELSE 'NC' END AS F_IN,
CASE WHEN  F_CompleteCrDb ='1' THEN 'C' ELSE 'NC' END AS F_CD
FROM T_GENMAIN
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_NewJour" ,
                @"
select f_tbindex,f_order,f_tbtype,f_u2id,f_u2date,f_tbname,f_tbid, F_RTBID, f_branch,F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,f_billcode,
F_SubCode,F_Currency,ROUND(F_ExRate,4) AS F_EXRATE,case when f_fdebit > 0 then f_fdebit when f_fcredit < 0 then -1*f_fcredit else 0 end as f_fdebit,
case when f_fcredit > 0 then f_fcredit when f_fdebit < 0 then -1*f_fdebit else 0 end as f_fcredit,f_glno,
round(case when f_debit > 0 then f_debit when f_credit < 0 then -1*f_credit else 0 end,  & str(g_CurrencyDecimal) & ) as f_debit,
round(case when f_credit > 0 then f_credit when f_debit < 0 then -1*f_debit else 0 end, & str(g_CurrencyDecimal) & ) as f_credit,f_key, F_Void, F_MBLID,F_MTBName from V_InvoExJour
UNION ALL
select f_tbindex,f_order,f_tbtype,f_u2id,f_u2date,f_tbname,f_tbid, F_RTBID, f_branch,F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,f_billcode,
F_SubCode,F_Currency,ROUND(F_ExRate,4) AS F_EXRATE,case when f_fdebit > 0 then f_fdebit when f_fcredit < 0 then -1*f_fcredit else 0 end as f_fdebit,
case when f_fcredit > 0 then f_fcredit when f_fdebit < 0 then -1*f_fdebit else 0 end as f_fcredit,f_glno,
round(case when f_debit > 0 then f_debit when f_credit < 0 then -1*f_credit else 0 end,  & str(g_CurrencyDecimal) & ) as f_debit,
round(case when f_credit > 0 then f_credit when f_debit < 0 then -1*f_debit else 0 end, & str(g_CurrencyDecimal) & ) as f_credit,f_key, F_Void, F_MBLID,F_MTBName from V_APExJour
UNION ALL
select f_tbindex,f_order,f_tbtype,f_u2id,f_u2date,f_tbname,f_tbid, F_RTBID, f_branch,F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,f_billcode,
F_SubCode,F_Currency,ROUND(F_ExRate,4) AS F_EXRATE,case when f_fdebit > 0 then f_fdebit when f_fcredit < 0 then -1*f_fcredit else 0 end as f_fdebit,
case when f_fcredit > 0 then f_fcredit when f_fdebit < 0 then -1*f_fdebit else 0 end as f_fcredit,f_glno,
round(case when f_debit > 0 then f_debit when f_credit < 0 then -1*f_credit else 0 end,  & str(g_CurrencyDecimal) & ) as f_debit,
round(case when f_credit > 0 then f_credit when f_debit < 0 then -1*f_debit else 0 end, & str(g_CurrencyDecimal) & ) as f_credit,f_key, F_Void, F_MBLID,F_MTBName from V_CrDbExJour
UNION ALL
select f_tbindex,f_order,f_tbtype,f_u2id,f_u2date,f_tbname,f_tbid, F_RTBID, f_branch,F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,f_billcode,
F_SubCode,F_Currency,ROUND(F_ExRate,4) AS F_EXRATE,case when f_fdebit > 0 then f_fdebit when f_fcredit < 0 then -1*f_fcredit else 0 end as f_fdebit,
case when f_fcredit > 0 then f_fcredit when f_fdebit < 0 then -1*f_fdebit else 0 end as f_fcredit,f_glno,
round(case when f_debit > 0 then f_debit when f_credit < 0 then -1*f_credit else 0 end,  & str(g_CurrencyDecimal) & ) as f_debit,
round(case when f_credit > 0 then f_credit when f_debit < 0 then -1*f_debit else 0 end, & str(g_CurrencyDecimal) & ) as f_credit,f_key, F_Void, F_MBLID,F_MTBName from V_DepoJour

& UNION ALL
& select f_tbindex,f_order,f_tbtype,f_u2id,f_u2date,f_tbname,f_tbid, F_RTBID, f_branch,F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,f_billcode, 
& F_SubCode,F_Currency,ROUND(F_ExRate,4) AS F_EXRATE,case when f_fdebit > 0 then f_fdebit when f_fcredit < 0 then -1*f_fcredit else 0 end as f_fdebit, 
& case when f_fcredit > 0 then f_fcredit when f_fdebit < 0 then -1*f_fdebit else 0 end as f_fcredit,f_glno, 
& round(case when f_debit > 0 then f_debit when f_credit < 0 then -1*f_credit else 0 end,  & str(g_CurrencyDecimal) & ) as f_debit, 
& round(case when f_credit > 0 then f_credit when f_debit < 0 then -1*f_debit else 0 end,  & str(g_CurrencyDecimal) & ) as f_credit,f_key, F_Void, F_MBLID,F_MTBName  from V_PAYROLLJOUR 

UNION ALL
select f_tbindex,f_order,f_tbtype,f_u2id,f_u2date,f_tbname,f_tbid, F_RTBID, f_branch,F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,f_billcode,
F_SubCode,F_Currency,ROUND(F_ExRate,4) AS F_EXRATE,case when f_fdebit > 0 then f_fdebit when f_fcredit < 0 then -1*f_fcredit else 0 end as f_fdebit,
case when f_fcredit > 0 then f_fcredit when f_fdebit < 0 then -1*f_fdebit else 0 end as f_fcredit,f_glno,
round(case when f_debit > 0 then f_debit when f_credit < 0 then -1*f_credit else 0 end,  & str(g_CurrencyDecimal) & ) as f_debit,
round(case when f_credit > 0 then f_credit when f_debit < 0 then -1*f_debit else 0 end,  & str(g_CurrencyDecimal) & ) as f_credit,f_key, F_Void, F_MBLID,F_MTBName  from V_AdjustJour

UNION ALL
select f_tbindex,f_order,f_tbtype,f_u2id,f_u2date,f_tbname,f_tbid, F_RTBID, f_branch,F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,f_billcode,
F_SubCode,F_Currency,ROUND(F_ExRate,4) AS F_EXRATE,case when f_fdebit > 0 then f_fdebit when f_fcredit < 0 then -1*f_fcredit else 0 end as f_fdebit,
case when f_fcredit > 0 then f_fcredit when f_fdebit < 0 then -1*f_fdebit else 0 end as f_fcredit,f_glno,
round(case when f_debit > 0 then f_debit when f_credit < 0 then -1*f_credit else 0 end,  & str(g_CurrencyDecimal) & ) as f_debit,
round(case when f_credit > 0 then f_credit when f_debit < 0 then -1*f_debit else 0 end,  & str(g_CurrencyDecimal) & ) as f_credit,f_key,F_Void,F_MBLID,F_MTBName  from V_BankTransferJour

UNION ALL
select f_tbindex,f_order,f_tbtype,f_u2id,f_u2date,f_tbname,f_tbid, F_RTBID, f_branch,F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,f_billcode,
F_SubCode,F_Currency,ROUND(F_ExRate,4) AS F_EXRATE,case when f_fdebit > 0 then f_fdebit when f_fcredit < 0 then -1*f_fcredit else 0 end as f_fdebit,
case when f_fcredit > 0 then f_fcredit when f_fdebit < 0 then -1*f_fdebit else 0 end as f_fcredit,f_glno,
round(case when f_debit > 0 then f_debit when f_credit < 0 then -1*f_credit else 0 end,  & str(g_CurrencyDecimal) & ) as f_debit,
round(case when f_credit > 0 then f_credit when f_debit < 0 then -1*f_debit else 0 end,  & str(g_CurrencyDecimal) & ) as f_credit,f_key,F_Void,F_MBLID,F_MTBName  from V_TaxReturnJour
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_Slipdetail" ,
                @"
Select 10 as f_tbindex, f_seq as f_order,f_tbtype,T1.F_U2ID,T1.F_U2DATE,T1.f_tbname,T1.f_TBid, T1.F_TBID As F_RTBID, T1.f_branch,f_postdate as f_invoicedate,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,T2.f_mdesc,'' as f_billcode,
F_SubCode,F_Currency,F_ExRate,f_fdebit,f_fcredit,f_glno,round(f_debit, & str(g_CurrencyDecimal) & ) as f_debit,round(f_credit, & str(g_CurrencyDecimal) & ) as f_credit,'10T_SLIPHD'+Ltrim(str(T1.f_id))+ T1.F_Branch AS F_KEY,0 as F_MBLID,'' as F_MTBName  from T_SLIPHD T1
LEFT JOIN T_SLIPDETAIL T2 ON T2.F_HDID=T1.F_ID WHERE T1.F_Type <> 'O'
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_NewJourHD" ,
                @"
Select 'O' as f_type,F_INVOICEDATE,F_POSTDATE,v.f_branch,N.F_SEQ as f_SEQNO,MIN(f_comname) AS f_comname,
sum(case when f_debit > 0 then f_debit when f_credit < 0 then -f_credit else 0 end) as f_gdebit,
sum(case when f_credit> 0 then f_credit when f_debit < 0 then -f_debit else 0 END ) as f_gcredit,v.f_tbname,v.f_tbid, v.F_RTBID,
min(substring(isnull(f_mdesc,''),1,50)) as f_mdesc,v.f_tbtype ,v.f_key,v.f_u2id,v.f_u2date,v.F_MBLID,v.F_MTBName
from v_Newjour v left join T_NSLIPKEY n on (n.F_KEY=v.f_key and n.f_date=v.f_postdate and n.F_RTBID = v.F_RTBID)
group by v.f_branch,v.f_tbname,v.f_tbid, v.F_RTBID, f_invoicedate,f_postdate,v.F_TBTYPE,v.f_key ,N.F_SEQ,v.f_u2id,v.f_u2date,v.F_MBLID,v.F_MTBName
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_Slip" ,
                @"
Select F_TYPE,10 as f_tbindex, f_seqno,f_seq as f_order,f_tbtype,T1.f_tbname,T1.f_TBid, T1.F_TBID As F_RTBID, T1.f_branch,f_postdate as f_invoicedate,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,T2.f_mdesc,'' as f_billcode,
F_SubCode,F_Currency,F_ExRate,f_fdebit,f_fcredit,f_glno,round(f_debit, & str(g_CurrencyDecimal) & ) as f_debit,round(f_credit, & str(g_CurrencyDecimal) & ) as f_credit,'10T_SLIPHD'+Ltrim(str(T1.f_id))+ T1.F_Branch AS F_KEY,T1.f_u2id,T1.f_u2date, 0 As F_Void, 0 as F_MBLID,'' as F_MTBName from T_SLIPHD T1
LEFT JOIN T_SLIPDETAIL T2 ON T2.F_HDID=T1.F_ID WHERE T1.F_Type <> 'O'
UNION ALL
select 'O' AS F_TYPE,  f_tbindex,f_SEQNO,f_order,v.f_tbtype,v.f_tbname,v.f_tbid, v.F_RTBID, v.f_branch,f_postdate as F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,'' as f_billcode,
F_SubCode , F_Currency, F_ExRate, f_fdebit, f_fcredit, f_glno, f_debit, f_credit, v.f_key,v.f_u2id,v.f_u2date,v.F_Void,v.F_MBLID,v.F_MTBName from t_newjour V

UNION ALL
select 'O' AS F_TYPE,  f_tbindex,f_SEQNO,f_order,v.f_tbtype,v.f_tbname,v.f_tbid, v.F_RTBID, v.f_branch,f_postdate as F_INVOICEDATE,f_postdate,case when f_comtype = '' then 'C' else f_comtype end as f_comtype,f_comname,f_comid,f_stbname,f_stbid,f_mdesc,'' as f_billcode,
F_SubCode , F_Currency, F_ExRate, f_fdebit, f_fcredit, f_glno, f_debit, f_credit, v.f_key,v.f_u2id,v.f_u2date,v.F_Void,v.F_MBLID,v.F_MTBName from t_newjourb V
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_SlipX" ,
                @"
SELECT
F_TYPE, 10 AS F_TbIndex, F_SeqNo, F_Seq AS F_Order, F_TbType, T1.F_TbName, T1.F_TBId, T1.F_TBId As F_RTBID,
T1.F_Branch, F_PostDate AS F_InvoiceDate, CAST(CONVERT(VARCHAR(10), F_PostDate, 23) AS Datetime) As F_PostDate,
CASE WHEN F_ComType = '' THEN 'C' ELSE F_ComType END AS F_ComType, F_ComName, F_ComId, 'T_SLIPDETAIL' AS F_StbName, T2.F_Id AS F_StbId, T2.F_MDesc, '' AS F_BillCode,
F_SubCode, F_Currency, F_ExRate, F_FDebit, F_FCredit, F_GLNo,
ROUND(F_Debit, & str(g_CurrencyDecimal) & ) AS F_Debit, ROUND(F_Credit, & str(g_CurrencyDecimal) & ) AS F_Credit,
'10T_SLIPHD' + Ltrim(str(T1.F_Id)) + T1.F_Branch AS F_KEY, T1.F_U2Id, T1.F_U2Date, 0 As F_Void, 0 AS F_MBLID, '' AS F_MTBName
FROM T_SLIPHD T1
LEFT JOIN T_SLIPDETAIL T2 ON T2.F_HDID = T1.F_ID
WHERE T1.F_Type <> 'O'

UNION ALL
SELECT
'O' AS F_TYPE,  F_TbIndex, F_SeqNo, F_Order, V.F_TbType, V.F_TbName, V.F_TBId,  V.F_RTBID,
V.F_Branch, F_PostDate AS F_InvoiceDate, CAST(CONVERT(VARCHAR(10), F_PostDate, 23) AS Datetime) As F_PostDate,
CASE WHEN F_ComType = '' THEN 'C' ELSE F_ComType END AS F_ComType, F_ComName, F_ComId, F_StbName, F_StbId, F_MDesc, '' as F_BillCode,
F_SubCode , F_Currency, F_ExRate, F_FDebit, F_FCredit, F_GLNo,
F_Debit, F_Credit, V.F_KEY, V.F_U2Id, V.F_U2Date, V.F_Void, V.F_MBLID, v.F_MTBName
FROM T_NewJour V

UNION ALL
SELECT
CASE WHEN T2.F_ID IS NOT NULL THEN T2.F_Type WHEN V.F_OriType <> '' THEN V.F_OriType WHEN V.F_TBNAME = 'T_SLIPHD' THEN 'T' ELSE 'O' END AS F_TYPE, F_TbIndex, V.F_SeqNo, F_Order, V.F_TbType, V.F_TbName, V.F_TBId, V.F_RTBID,
V.F_Branch, V.F_PostDate AS F_InvoiceDate, CAST(CONVERT(VARCHAR(10), V.F_PostDate, 23) AS Datetime) As F_PostDate,
CASE WHEN F_ComType = '' THEN 'C' ELSE F_ComType END AS F_ComType, F_ComName, F_ComId, F_StbName, F_StbId, V.F_MDesc, '' AS F_BillCode,
F_SubCode , F_Currency, F_ExRate, F_FDebit, F_FCredit, F_GLNo,
F_Debit, F_Credit, V.F_KEY, V.F_U2Id, V.F_U2Date, V.F_Void, V.F_MBLID, V.F_MTBName
FROM T_NewJourB V
LEFT JOIN T_SLIPHD T2 ON T2.F_ID = V.F_TBID AND V.F_TBName = 'T_SLIPHD'
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_SlipX2" ,
                @"
SELECT
T1.F_TYPE, 10 AS F_TbIndex, T1.F_SeqNo, T2.F_Seq AS F_Order, T1.F_TbType,
T1.F_TbName, T1.F_TBId, T1.F_TBId As F_RTBID,
T1.F_Branch, T1.F_PostDate AS F_InvoiceDate, CAST(CONVERT(VARCHAR(10), T1.F_PostDate, 23) AS Datetime) As F_PostDate,
CASE WHEN T2.F_ComType = '' THEN 'C' ELSE T2.F_ComType END AS F_ComType, T2.F_ComName, T2.F_ComId,
'T_SLIPDETAIL' AS F_StbName, T2.F_Id AS F_StbId, T2.F_MDesc, '' AS F_BillCode,
T2.F_SubCode, T2.F_Currency, T2.F_ExRate, T2.F_FDebit, T2.F_FCredit, T2.F_GLNo, ROUND(T2.F_Debit, 2) AS F_Debit, ROUND(T2.F_Credit, 2) AS F_Credit,
'10T_SLIPHD' + Ltrim(str(T1.F_Id)) + T1.F_Branch AS F_KEY, T1.F_U2Id, T1.F_U2Date, 0 As F_Void, 0 AS F_MBLID, '' AS F_MTBName, 'B' AS F_LineColor
FROM T_SLIPHD T1
LEFT JOIN T_SLIPDETAIL T2 ON T2.F_HDID = T1.F_ID
WHERE T1.F_Type <> 'O'

UNION ALL
SELECT
'O' AS F_TYPE, V.F_TbIndex, V.F_SeqNo, V.F_Order, V.F_TbType,
V.F_TbName, V.F_TBId,  V.F_RTBID,
V.F_Branch, V.F_PostDate AS F_InvoiceDate, CAST(CONVERT(VARCHAR(10), V.F_PostDate, 23) AS Datetime) As F_PostDate,
CASE WHEN V.F_ComType = '' THEN 'C' ELSE V.F_ComType END AS F_ComType, V.F_ComName, V.F_ComId,
V.F_StbName, V.F_StbId, V.F_MDesc, '' as F_BillCode,
V.F_SubCode , V.F_Currency, V.F_ExRate, V.F_FDebit, V.F_FCredit, V.F_GLNo, V.F_Debit, V.F_Credit,
V.F_KEY, V.F_U2Id, V.F_U2Date, V.F_Void, V.F_MBLID, v.F_MTBName,
CASE WHEN T1.F_ID IS NOT NULL THEN (CASE T1.F_VOID WHEN 1 THEN 'G' WHEN 2 THEN 'R' ELSE 'B' END)
WHEN T2.F_ID IS NOT NULL THEN (CASE T2.F_VOID WHEN 1 THEN 'G' WHEN 2 THEN 'R' ELSE 'B' END)
WHEN T3.F_ID IS NOT NULL THEN (CASE T3.F_VOID WHEN 1 THEN 'G' WHEN 2 THEN 'R' ELSE 'B' END)
WHEN T4.F_ID IS NOT NULL THEN (CASE WHEN T4.F_VOID > 0 AND V.F_ORDER >= 6 THEN 'R' WHEN T4.F_VOID > 0 AND V.F_ORDER < 6 THEN 'G' ELSE 'B' END)
WHEN T5.F_ID IS NOT NULL THEN (CASE WHEN T5.F_VOID > 0 AND (V.F_TBTYPE = 97 OR V.F_TBTYPE = 86) THEN 'R' WHEN T5.F_VOID > 0 AND (V.F_TBTYPE = 80 OR V.F_TBTYPE = 85) THEN 'G' ELSE 'B' END)
WHEN T6.F_ID IS NOT NULL THEN (CASE WHEN T6.F_VOID > 0 AND (V.F_TBTYPE = 94 OR V.F_TBTYPE = 95 OR V.F_TBTYPE = 96 OR V.F_TBTYPE = 77 OR V.F_TBTYPE = 79) THEN 'R'
WHEN T6.F_VOID > 0 AND (V.F_TBTYPE = 91 OR V.F_TBTYPE = 92 OR V.F_TBTYPE = 93 OR V.F_TBTYPE = 76 OR V.F_TBTYPE = 78) THEN 'G'
ELSE 'B' END)
WHEN T7.F_ID IS NOT NULL THEN (CASE WHEN T7.F_VOID > 0 AND V.F_TBTYPE = 84 THEN 'R' WHEN T7.F_VOID > 0 AND V.F_TBTYPE = 83 THEN 'G' ELSE 'B' END)
WHEN T8.F_ID IS NOT NULL THEN (CASE WHEN T8.F_VOID > 0 AND V.F_TBTYPE = 88 THEN 'R' WHEN T8.F_VOID > 0 AND V.F_TBTYPE = 87 THEN 'G' ELSE 'B' END)
ELSE 'B' END AS F_LineColor

FROM T_NewJour V
LEFT JOIN T_INVOHD T1 ON V.F_TBName = 'T_INVOHD' AND V.F_TBID = T1.F_ID
LEFT JOIN T_APHD T2 ON V.F_TBName = 'T_APHD' AND V.F_TBID = T2.F_ID
LEFT JOIN T_CRDBHD T3 ON V.F_TBName = 'T_CRDBHD' AND V.F_TBID = T3.F_ID
LEFT JOIN T_DEPOHD T4 ON V.F_TBName = 'T_DEPOHD' AND V.F_TBID = T4.F_ID
LEFT JOIN T_PAYROLL T5 ON V.F_TBName = 'T_PAYROLL' AND V.F_TBID = T5.F_ID
LEFT JOIN T_ADSLIPHD T6 ON V.F_TBName = 'T_ADSLIPHD' AND V.F_TBID = T6.F_ID
LEFT JOIN T_BANKTRANSFER T7 ON V.F_TBName = 'T_BANKTRANSFER' AND V.F_TBID = T7.F_ID
LEFT JOIN T_TAXRETURNHD T8 ON V.F_TBName = 'T_TAXRETURNHD' AND V.F_TBID = T8.F_ID

UNION ALL
SELECT
CASE WHEN T2.F_ID IS NOT NULL THEN T2.F_Type WHEN V.F_OriType <> '' THEN V.F_OriType WHEN V.F_TBNAME = 'T_SLIPHD' THEN 'T' ELSE 'O' END AS F_TYPE, F_TbIndex, V.F_SeqNo, F_Order, V.F_TbType, V.F_TbName, V.F_TBId, V.F_RTBID,
V.F_Branch, V.F_PostDate AS F_InvoiceDate, CAST(CONVERT(VARCHAR(10), V.F_PostDate, 23) AS Datetime) As F_PostDate,
CASE WHEN F_ComType = '' THEN 'C' ELSE F_ComType END AS F_ComType, F_ComName, F_ComId, F_StbName, F_StbId, V.F_MDesc, '' AS F_BillCode,
F_SubCode , F_Currency, F_ExRate, F_FDebit, F_FCredit, F_GLNo,
F_Debit, F_Credit, V.F_KEY, V.F_U2Id, V.F_U2Date, V.F_Void, V.F_MBLID, V.F_MTBName,
CASE WHEN V.F_TBTYPE > 200 THEN 'R' WHEN V.F_TBTYPE > 100 AND V.F_TBTYPE <= 200 THEN 'G' ELSE 'B' END AS F_LineColor
FROM T_NewJourB V
LEFT JOIN T_SLIPHD T2 ON T2.F_ID = V.F_TBID AND V.F_TBName = 'T_SLIPHD'
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_SLIPHD" ,
                @"
Select  f_type,F_POSTDATE AS F_INVOICEDATE,F_POSTDATE,f_branch, f_SEQNO,'' AS f_comname,
f_gdebit, f_gcredit,f_tbname,f_tbid,
f_mdesc,f_tbtype ,'10T_SLIPHD'+Ltrim(str(f_id))+ F_Branch AS F_KEY,f_u2id,f_u2date
from T_SLIPHD WHERE F_Type <> 'O'
UNION ALL
Select  f_type,F_INVOICEDATE,F_POSTDATE,f_branch, f_SEQNO,f_comname,
f_gdebit, f_gcredit,f_tbname,f_tbid,
f_mdesc,f_tbtype,F_KEY,f_u2id,f_u2date from v_NewJourHD
UNION ALL
Select 'O' as  f_type,f_postdate as F_INVOICEDATE,F_POSTDATE,f_branch, f_SEQNO,'' as f_comname,
sum(f_debit) as f_gdebit, sum(f_credit) f_gcredit,f_tbname,f_tbid,
'' as f_mdesc,f_tbtype,F_KEY,f_u2id,f_u2date from t_newjourb group by F_POSTDATE,f_branch, f_SEQNO,f_tbname,f_tbid,F_KEY,f_tbtype,f_u2id,f_u2date
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_NSlipComNameEx" ,
                @"
SELECT SUBSTRING((CASE WHEN COUNT(DISTINCT T5.F_ComName) > 1 THEN MIN(T5.F_ComName) + ' + ' + CAST(COUNT(DISTINCT T5.F_ComName) - 1 As VARCHAR(4)) ELSE MIN(T5.F_ComName) END), 3, 47) As F_ComName,T5.f_key As F_KeyID
FROM (
SELECT DISTINCT (CASE WHEN T1.F_ComType = 'B' THEN '-z' + T3.F_BankName ELSE '-a' + T2.F_SName END) As F_ComName, T1.f_key
FROM v_newjour As T1
LEFT JOIN T_COMPANY As T2 On (T2.F_ID = T1.F_ComID And T1.F_ComType = 'C')
LEFT JOIN T_CODEBANK As T3 On (T3.F_ID = T1.F_ComID And T1.F_ComType = 'B')
WHERE T1.F_ComID > 0 And (Len(T2.F_SName) > 0 Or Len(T3.F_BankName) > 0)
) As T5 GROUP BY T5.f_key
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_BillingSummaryByTable" ,
                @"
SELECT MIN(F_InvoiceDate) As F_InvoiceDate, F_MTBName, F_MBLID, F_TBName, F_TBID, F_BillingCode,
SUM(DefSales) AS DefRev, SUM(DefCost) AS DefCost, SUM(Sales) AS Rev, SUM(Cost) AS Cost, SUM(AgentSales) As ARev, SUM(AgentCost) As Acost
FROM (
SELECT T2.F_InvoiceDate, T1.F_MTBName, T1.F_MBLID, T2.F_TBName, T2.F_TBID, T3.F_BillingCode, T1.F_GLNo,
(CASE WHEN T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefSales,
(CASE WHEN T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefCost,
0 AS Sales, (CASE WHEN T4.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As Cost,
(CASE WHEN T4.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As AgentSales, 0 AS AgentCost
FROM T_NEWJOUR T1
INNER JOIN T_APHD T2 On (T2.F_ID = T1.F_TBID And T1.F_TBName = 'T_APHD')
INNER JOIN T_APDETAIL T3 On (T3.F_ID = T1.F_STBID And T1.F_STBName = 'T_APDETAIL')
LEFT JOIN T_CODEGLNO T4 On (T4.F_GLNo = T1.F_GLNo)
WHERE (T4.F_GLType In ('C', 'I') Or T1.F_GLNo In (dbo.uf_Slip_GetFixedGLNo('F_DefCost', ''), dbo.uf_Slip_GetFixedGLNo('F_DefSales', '')))

UNION ALL

SELECT T2.F_InvoiceDate, T1.F_MTBName, T1.F_MBLID, T2.F_TBName, T2.F_TBID, T3.F_BillingCode, T1.F_GLNo,
(CASE WHEN T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefSales,
(CASE WHEN T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefCost,
(CASE WHEN T4.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) AS Sales, 0 As Cost,
0 As AgentSales, (CASE WHEN T4.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) AS AgentCost
FROM T_NEWJOUR T1
INNER JOIN T_INVOHD T2 On (T2.F_ID = T1.F_TBID And T1.F_TBName = 'T_INVOHD')
INNER JOIN T_INVODETAIL T3 On (T3.F_ID = T1.F_STBID And T1.F_STBName = 'T_INVODETAIL')
LEFT JOIN T_CODEGLNO T4 On (T4.F_GLNo = T1.F_GLNo)
WHERE (T4.F_GLType In ('C', 'I') Or T1.F_GLNo In (dbo.uf_Slip_GetFixedGLNo('F_DefCost', ''), dbo.uf_Slip_GetFixedGLNo('F_DefSales', '')))

UNION ALL

SELECT T2.F_InvoiceDate, T1.F_MTBName, T1.F_MBLID, T2.F_TBName, T2.F_TBID, T3.F_CRDBCODE As F_BillingCode, T1.F_GLNo,
(CASE WHEN T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefSales,
(CASE WHEN T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefCost,
0 AS Sales, 0 As Cost,
(CASE WHEN T4.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As AgentSales,
(CASE WHEN T4.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) AS AgentCost
FROM T_NEWJOUR T1
INNER JOIN T_CRDBHD T2 On (T2.F_ID = T1.F_TBID And T1.F_TBName = 'T_CRDBHD')
INNER JOIN T_CRDBDETAIL T3 On (T3.F_ID = T1.F_STBID And T1.F_STBName = 'T_CRDBDETAIL')
LEFT JOIN T_CODEGLNO T4 On (T4.F_GLNo = T1.F_GLNo)
WHERE (T4.F_GLType In ('C', 'I') Or T1.F_GLNo In (dbo.uf_Slip_GetFixedGLNo('F_DefCost', ''), dbo.uf_Slip_GetFixedGLNo('F_DefSales', '')))

UNION ALL

SELECT T2.F_cDate As F_InvoiceDate, T1.F_MTBName, T1.F_MBLID, T2.F_TBName, T2.F_TBID, T2.F_BillingCode, T1.F_GLNo,
(CASE WHEN T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefSales,
(CASE WHEN T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefCost,
0 AS Sales, 0 As Cost,
(CASE WHEN T4.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As AgentSales,
(CASE WHEN T4.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) AS AgentCost
FROM T_NEWJOUR T1
INNER JOIN T_OPACCT T2 On (T2.F_ID = T1.F_STBID And T1.F_STBName = 'T_OPACCT')
LEFT JOIN T_CODEGLNO T4 On (T4.F_GLNo = T1.F_GLNo)
WHERE (T4.F_GLType In ('C', 'I') Or T1.F_GLNo In (dbo.uf_Slip_GetFixedGLNo('F_DefCost', ''), dbo.uf_Slip_GetFixedGLNo('F_DefSales', '')))
) ZZ
GROUP BY F_MTBName, F_MBLID, F_TBName, F_TBID, F_BillingCode
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_BillingSummaryDeferredByTable" ,
                @"
SELECT MIN(ZZ.F_PostDate) AS F_PostDate, MIN(ZZ.F_InvoiceDate) As F_InvoiceDate, ZZ.F_MTBName, ZZ.F_MBLID, ZZ.F_TBName, ZZ.F_TBID, ZZ.F_BillingCode,
SUM(DefSales) AS DefRev, SUM(DefCost) AS DefCost, SUM(DefAgtSales) AS DefAgtRev, SUM(DefAgtCost) AS DefAgtCost, SUM(Sales) AS Rev, SUM(Cost) AS Cost, SUM(AgentSales) As ARev, SUM(AgentCost) As Acost
FROM (
SELECT T1.F_PostDate, T2.F_InvoiceDate, T1.F_MTBName, T1.F_MBLID, T2.F_TBName, T2.F_TBID, T3.F_BillingCode, T1.F_GLNo,
(CASE WHEN T1.F_STBName <> 'T_APDETAIL' AND T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefSales,
(CASE WHEN T1.F_STBName = 'T_APDETAIL' AND T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefCost,
(CASE WHEN T1.F_STBName = 'T_APDETAIL' AND T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefAgtSales,
(CASE WHEN T1.F_STBName <> 'T_APDETAIL' AND T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefAgtCost,
0 AS Sales, (CASE WHEN T4.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As Cost,
(CASE WHEN T4.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As AgentSales, 0 AS AgentCost
FROM T_NEWJOUR T1
INNER JOIN T_APHD T2 On (T2.F_ID = T1.F_TBID And T1.F_TBName = 'T_APHD')
INNER JOIN T_APDETAIL T3 On (T3.F_ID = T1.F_STBID And T1.F_STBName = 'T_APDETAIL')
LEFT JOIN T_CODEGLNO T4 On (T4.F_GLNo = T1.F_GLNo)
WHERE (T4.F_GLType In ('C', 'I') Or T1.F_GLNo In (dbo.uf_Slip_GetFixedGLNo('F_DefCost', ''), dbo.uf_Slip_GetFixedGLNo('F_DefSales', '')))

UNION ALL

SELECT T1.F_PostDate, T2.F_InvoiceDate, T1.F_MTBName, T1.F_MBLID, T2.F_TBName, T2.F_TBID, T3.F_BillingCode, T1.F_GLNo,
(CASE WHEN T1.F_STBName = 'T_INVODETAIL' AND T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefSales,
(CASE WHEN T1.F_STBName <> 'T_INVODETAIL' AND T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefCost,
(CASE WHEN T1.F_STBName <> 'T_INVODETAIL' AND T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefAgtSales,
(CASE WHEN T1.F_STBName = 'T_INVODETAIL' AND T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefAgtCost,
(CASE WHEN T4.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) AS Sales, 0 As Cost,
0 As AgentSales, (CASE WHEN T4.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) AS AgentCost
FROM T_NEWJOUR T1
INNER JOIN T_INVOHD T2 On (T2.F_ID = T1.F_TBID And T1.F_TBName = 'T_INVOHD')
INNER JOIN T_INVODETAIL T3 On (T3.F_ID = T1.F_STBID And T1.F_STBName = 'T_INVODETAIL')
LEFT JOIN T_CODEGLNO T4 On (T4.F_GLNo = T1.F_GLNo)
WHERE (T4.F_GLType In ('C', 'I') Or T1.F_GLNo In (dbo.uf_Slip_GetFixedGLNo('F_DefCost', ''), dbo.uf_Slip_GetFixedGLNo('F_DefSales', '')))

UNION ALL

SELECT T1.F_PostDate, T2.F_InvoiceDate, T1.F_MTBName, T1.F_MBLID, T2.F_TBName, T2.F_TBID, T3.F_CRDBCODE As F_BillingCode, T1.F_GLNo,
(CASE WHEN T1.F_STBName <> 'T_CRDBDETAIL' AND T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefSales,
(CASE WHEN T1.F_STBName <> 'T_CRDBDETAIL' AND T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefCost,
(CASE WHEN T1.F_STBName = 'T_CRDBDETAIL' AND T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefAgtSales,
(CASE WHEN T1.F_STBName = 'T_CRDBDETAIL' AND T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefAgtCost,
0 AS Sales, 0 As Cost,
(CASE WHEN T4.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As AgentSales,
(CASE WHEN T4.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) AS AgentCost
FROM T_NEWJOUR T1
INNER JOIN T_CRDBHD T2 On (T2.F_ID = T1.F_TBID And T1.F_TBName = 'T_CRDBHD')
INNER JOIN T_CRDBDETAIL T3 On (T3.F_ID = T1.F_STBID And T1.F_STBName = 'T_CRDBDETAIL')
LEFT JOIN T_CODEGLNO T4 On (T4.F_GLNo = T1.F_GLNo)
WHERE (T4.F_GLType In ('C', 'I') Or T1.F_GLNo In (dbo.uf_Slip_GetFixedGLNo('F_DefCost', ''), dbo.uf_Slip_GetFixedGLNo('F_DefSales', '')))

UNION ALL

SELECT T1.F_PostDate, T2.F_cDate As F_InvoiceDate, T1.F_MTBName, T1.F_MBLID, T2.F_TBName, T2.F_TBID, T2.F_BillingCode, T1.F_GLNo,
(CASE WHEN T1.F_STBName <> 'T_OPACCT' AND T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefSales,
(CASE WHEN T1.F_STBName <> 'T_OPACCT' AND T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefCost,
(CASE WHEN T1.F_STBName = 'T_OPACCT' AND T1.F_GLNO = dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As DefAgtSales,
(CASE WHEN T1.F_STBName = 'T_OPACCT' AND T1.F_GLNo = dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As DefAgtCost,
0 AS Sales, 0 As Cost,
(CASE WHEN T4.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As AgentSales,
(CASE WHEN T4.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) AS AgentCost
FROM T_NEWJOUR T1
INNER JOIN T_OPACCT T2 On (T2.F_ID = T1.F_STBID And T1.F_STBName = 'T_OPACCT')
LEFT JOIN T_CODEGLNO T4 On (T4.F_GLNo = T1.F_GLNo)
WHERE (T4.F_GLType In ('C', 'I') Or T1.F_GLNo In (dbo.uf_Slip_GetFixedGLNo('F_DefCost', ''), dbo.uf_Slip_GetFixedGLNo('F_DefSales', '')))
) ZZ
GROUP BY ZZ.F_MTBName, ZZ.F_MBLID, ZZ.F_TBName, ZZ.F_TBID, ZZ.F_BillingCode
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_AccountByOperation" ,
                @"
WITH SettingValues(LCur) AS (
SELECT
(SELECT TOP 1 F_Currency FROM T_CODEDATA) AS LCur
)

SELECT
CASE SUBSTRING(TACT.F_TBName,3,2) WHEN 'AO' THEN 'Air Export' WHEN 'AI' THEN 'Air Import' WHEN 'OO' THEN 'Ocean Export' WHEN 'OI' THEN 'Ocean Import'
WHEN 'WR' THEN 'Warehousing'  WHEN 'WS' THEN 'Warehousing'  WHEN 'GE' THEN 'Other Shipment' ELSE 'Non-Operation' END As F_Department,
CASE SUBSTRING(TACT.F_TBName,3,2) WHEN 'AO' THEN 4 WHEN 'AI' THEN 3 WHEN 'OO' THEN 2 WHEN 'OI' THEN 1 WHEN 'WR' THEN 6 WHEN 'WS' THEN 6 WHEN 'GE' THEN 5 ELSE 7 END As F_ViewOrder,
TACT.F_PS, TBL.F_MTBName,  TBL.F_MBLID AS F_MTBId, TACT.F_TBName, TACT.F_TBId, 'T_INVOHD' AS F_HDActName, TARH.F_ID AS F_HDActId,
'T_INVODETAIL' AS F_ActName, TAR.F_ID AS F_ActId, TARH.F_CheckNo AS F_CheckNo, TARH.F_PaidDate AS F_PaidDate,
COALESCE(TACT.F_AgtExrate, TAR.F_AgtExrate) AS F_AgtExrate, COALESCE(TACT.F_ActExrate, TAR.F_Exrate) AS F_ActExrate,
TARH.F_PostDate AS F_PostDate, TACT.F_BILLINGCODE, TACT.F_Description, (CASE WHEN ISNULL(TAR.F_Cur, '') = '' THEN TSET.LCur ELSE TAR.F_Cur END) AS F_Currency, TACT.F_ActExrate AS F_ExRate,
--TACT.F_Entity AS F_ComId,
COALESCE(TARH.F_BILLTO,TACT.F_Entity) AS F_ComId, TACT.F_ChgType, TACT.F_AgentAmt, TACT.F_Posted, NULL AS F_ETF, TARH.F_InvoiceNo As F_InvNo, 1 As F_HasInvoice,
ISNULL(TAR.F_LAmount, 0) AS MAR, ISNULL((TARH.F_InvoiceAmt - TARH.F_PaidAmt) * (CASE WHEN TARH.F_InvoiceAmt > 0 THEN 1 ELSE -1 END), 0) As MARPaid,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TAR.F_Cur, '') = '' THEN TSET.LCur ELSE TAR.F_Cur END) <> TSET.LCur THEN TAR.F_CurAmount ELSE 0 END, 0) As MAR_USD,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TAR.F_Cur, '') = '' THEN TSET.LCur ELSE TAR.F_Cur END) <> TSET.LCur THEN 0 ELSE TAR.F_CurAmount END, 0) As MAR_LOC,
0 AS MAP, 0 As MAP_USD, 0 As MAP_LOC, 0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MCredit_USD, 0 As MDebit_LOC, 0 As MCredit_LOC,
CASE WHEN TACT.F_ChgType IN (8, 10, 18, 20, 40) Then 1 WHEN SUBSTRING(TACT.F_BillingCode, 1, 3) In ('GST','HST','PST','IVA') THEN 2 Else 0 END As F_IsDuty, TARH.F_InvoiceDate AS F_InvoiceDate,
(CASE WHEN ROUND(TARH.F_InvoiceAmt - TARH.F_PaidAmt,2) = 0 AND ROUND(TARH.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(TARH.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid
FROM T_OPACCT TACT
INNER JOIN SettingValues TSET ON 1=1
INNER JOIN T_INVODETAIL TAR ON TAR.F_STBName = 'T_OPACCT' AND TAR.F_STBID = TACT.F_ID
LEFT JOIN T_INVOHD TARH ON TARH.F_ID = TAR.F_INVOHDID
LEFT JOIN V_BLSUMM TBL ON TBL.F_TBName = TACT.F_TBNAME AND TBL.F_TBID = TACT.F_TBID
WHERE TACT.F_ChgType NOT IN (2,12) AND ISNULL(TARH.F_Void,0) = 0   -- And SUBSTRING(TACT.F_BillingCode, 1, 3) Not In ('GST','HST','PST','IVA')

UNION ALL SELECT
CASE SUBSTRING(TACT.F_TBName,3,2) WHEN 'AO' THEN 'Air Export' WHEN 'AI' THEN 'Air Import' WHEN 'OO' THEN 'Ocean Export' WHEN 'OI' THEN 'Ocean Import'
WHEN 'WR' THEN 'Warehousing'  WHEN 'WS' THEN 'Warehousing'  WHEN 'GE' THEN 'Other Shipment' ELSE 'Non-Operation' END As F_Department,
CASE SUBSTRING(TACT.F_TBName,3,2) WHEN 'AO' THEN 4 WHEN 'AI' THEN 3 WHEN 'OO' THEN 2 WHEN 'OI' THEN 1 WHEN 'WR' THEN 6 WHEN 'WS' THEN 6 WHEN 'GE' THEN 5 ELSE 7 END As F_ViewOrder,
TACT.F_PS, TBL.F_MTBName, TBL.F_MBLID AS F_MTBId, TACT.F_TBName, TACT.F_TBId,  'T_APHD' AS F_HDActName, TAPH.F_ID AS F_HDActId,
'T_APDETAIL' AS F_ActName, TAP.F_ID AS F_ActId, TAPH.F_CheckNo AS F_CheckNo, TAPH.F_PaidDate AS F_PaidDate,
COALESCE(TACT.F_AgtExrate, TAP.F_AgtExrate) AS F_AgtExrate, COALESCE(TACT.F_ActExrate, TAP.F_Exrate) AS F_ActExrate,
TAPH.F_PostDate AS F_PostDate, TACT.F_BILLINGCODE, TACT.F_Description, (CASE WHEN ISNULL(TAP.F_Cur, '') = '' THEN TSET.LCur ELSE TAP.F_Cur END) AS F_Currency, TACT.F_ActExrate AS F_ExRate,
--TACT.F_Entity AS F_ComId,
COALESCE(TAPH.F_PAYTO,TACT.F_Entity) AS F_ComId, TACT.F_ChgType, TACT.F_AgentAmt, TACT.F_Posted, NULL AS F_ETF, TAPH.F_InvoiceNo As F_InvNo, 0 As F_HasInvoice,
0 AS MAR, 0 As MARPaid, 0 As MAR_USD, 0 As MAR_LOC,
ISNULL(TAP.F_LAmount, 0) AS MAP,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TAP.F_Cur, '') = '' THEN TSET.LCur ELSE TAP.F_Cur END) <> TSET.LCur THEN TAP.F_CurAmount ELSE 0 END, 0) As MAP_USD,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TAP.F_Cur, '') = '' THEN TSET.LCur ELSE TAP.F_Cur END) <> TSET.LCur THEN 0 ELSE TAP.F_CurAmount END, 0) As MAP_LOC,
0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MCredit_USD, 0 As MDebit_LOC, 0 As MCredit_LOC,
CASE WHEN TACT.F_ChgType IN (8, 10, 18, 20, 40) Then 1 WHEN SUBSTRING(TACT.F_BillingCode, 1, 3) In ('GST','HST','PST','IVA') THEN 2 Else 0 END As F_IsDuty, TAPH.F_InvoiceDate AS F_InvoiceDate,
(CASE WHEN ROUND(TAPH.F_InvoiceAmt - TAPH.F_PaidAmt,2) = 0 AND ROUND(TAPH.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(TAPH.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid
FROM T_OPACCT TACT
INNER JOIN SettingValues TSET ON 1=1
INNER JOIN T_APDETAIL TAP ON TAP.F_STBName = 'T_OPACCT' AND TAP.F_STBID = TACT.F_ID
LEFT JOIN T_APHD TAPH ON TAPH.F_ID = TAP.F_APHDID
LEFT JOIN V_BLSUMM TBL ON TBL.F_TBName = TACT.F_TBNAME AND TBL.F_TBID = TACT.F_TBID
WHERE TACT.F_ChgType NOT IN (2,12) AND ISNULL(TAPH.F_Void,0) = 0   -- And SUBSTRING(TACT.F_BillingCode, 1, 3) Not In ('GST','HST','PST','IVA') 

UNION ALL SELECT
CASE SUBSTRING(TACT.F_TBName,3,2) WHEN 'AO' THEN 'Air Export' WHEN 'AI' THEN 'Air Import' WHEN 'OO' THEN 'Ocean Export' WHEN 'OI' THEN 'Ocean Import'
WHEN 'WR' THEN 'Warehousing'  WHEN 'WS' THEN 'Warehousing'  WHEN 'GE' THEN 'Other Shipment' ELSE 'Non-Operation' END As F_Department,
CASE SUBSTRING(TACT.F_TBName,3,2) WHEN 'AO' THEN 4 WHEN 'AI' THEN 3 WHEN 'OO' THEN 2 WHEN 'OI' THEN 1 WHEN 'WR' THEN 6 WHEN 'WS' THEN 6 WHEN 'GE' THEN 5 ELSE 7 END As F_ViewOrder,
TACT.F_PS, TBL.F_MTBName, TBL.F_MBLID AS F_MTBId, TACT.F_TBName, TACT.F_TBId, 'T_CRDBHD' AS F_HDActName, TCRDBH.F_ID AS F_HDActId,
'T_CRDBDETAIL' AS F_ActName, TCRDB.F_ID AS F_ActId, TCRDBH.F_CheckNo AS F_CheckNo, TCRDBH.F_PaidDate AS F_PaidDate,
COALESCE(TACT.F_AgtExrate, TCRDB.F_Exrate) AS F_AgtExrate, COALESCE(TACT.F_ActExrate, TCRDB.F_Exrate) AS F_ActExrate,
TCRDBH.F_PostDate AS F_PostDate, TACT.F_BILLINGCODE, TACT.F_Description, (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) AS F_Currency, TACT.F_ActExrate AS F_ExRate,
--TCRDBH.F_Agent AS F_ComId,
COALESCE(TCRDBH.F_Agent,TACT.F_Entity) AS F_ComId, TACT.F_ChgType, TACT.F_AgentAmt, TACT.F_Posted, NULL AS F_ETF, TCRDBH.F_CrDbNo As F_InvNo, 0 As F_HasInvoice,
0 AS MAR, 0 As MARPaid, 0 As MAR_USD, 0 As MAR_LOC, 0 AS MAP, 0 As MAP_USD,0 As MAP_LOC,
ISNULL(CASE WHEN TCRDB.F_Debit <> 0 THEN TCRDB.F_LAmount ELSE 0 END, 0) As MDebit,
ISNULL(CASE WHEN TCRDB.F_Credit <> 0 THEN TCRDB.F_LAmount ELSE 0 END, 0) As MCredit,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) <> TSET.LCur THEN TCRDB.F_Debit ELSE 0 END, 0) As MDebit_USD,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) <> TSET.LCur THEN TCRDB.F_Credit ELSE 0 END, 0) As MCredit_USD,
ISNULL(CASE WHEN TCRDB.F_Debit <> 0 AND (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) = TSET.LCur THEN 0 ELSE TCRDB.F_Debit END, 0) As MDebit_LOC,
ISNULL(CASE WHEN TCRDB.F_Credit <> 0  AND (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) = TSET.LCur THEN 0 ELSE TCRDB.F_Credit END, 0) As MCredit_LOC,
CASE WHEN TACT.F_ChgType IN (8, 10, 18, 20, 40) Then 1 WHEN SUBSTRING(TACT.F_BillingCode, 1, 3) In ('GST','HST','PST','IVA') THEN 2 Else 0 END As F_IsDuty, TCRDBH.F_InvoiceDate AS F_InvoiceDate,
(CASE WHEN ROUND(TCRDBH.F_Total - TCRDBH.F_PaidAmt,2) = 0 AND ROUND(TCRDBH.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(TCRDBH.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid

FROM T_OPACCT TACT
INNER JOIN SettingValues TSET ON 1=1
INNER JOIN T_CRDBDETAIL TCRDB ON TCRDB.F_STBName = 'T_OPACCT' AND TCRDB.F_STBID = TACT.F_ID
LEFT JOIN T_CRDBHD TCRDBH ON TCRDBH.F_ID = TCRDB.F_CrDbHDID
LEFT JOIN V_BLSUMM TBL ON TBL.F_TBName = TACT.F_TBNAME AND TBL.F_TBID = TACT.F_TBID
WHERE TACT.F_ChgType NOT IN (2,12) AND ISNULL(TCRDBH.F_Void,0) = 0     -- And SUBSTRING(TACT.F_BillingCode, 1, 3) Not In ('GST','HST','PST','IVA') 

UNION ALL SELECT
CASE SUBSTRING(TCRDBH.F_TBName,3,2) WHEN 'AO' THEN 'Air Export' WHEN 'AI' THEN 'Air Import' WHEN 'OO' THEN 'Ocean Export' WHEN 'OI' THEN 'Ocean Import'
WHEN 'WR' THEN 'Warehousing'  WHEN 'WS' THEN 'Warehousing'  WHEN 'GE' THEN 'Other Shipment' ELSE 'Non-Operation' END As F_Department,
CASE SUBSTRING(TCRDBH.F_TBName,3,2) WHEN 'AO' THEN 4 WHEN 'AI' THEN 3 WHEN 'OO' THEN 2 WHEN 'OI' THEN 1 WHEN 'WR' THEN 6 WHEN 'WS' THEN 6 WHEN 'GE' THEN 5 ELSE 7 END As F_ViewOrder,
0 AS F_PS, TBL.F_MTBName, TBL.F_MBLID AS F_MTBId, TCRDBH.F_TBName, TCRDBH.F_TBId, 'T_CRDBHD' AS F_HDActName, TCRDBH.F_ID AS F_HDActId,
'T_CRDBDETAIL' AS F_ActName, TCRDB.F_ID AS F_ActId, TCRDBH.F_CheckNo AS F_CheckNo, TCRDBH.F_PaidDate AS F_PaidDate,
TCRDB.F_Exrate AS F_AgtExrate, TCRDB.F_Exrate AS F_ActExrate,
TCRDBH.F_PostDate AS F_PostDate, TCRDB.F_CRDBCODE, TCRDB.F_Description, (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) AS F_Currency, TCRDB.F_Exrate AS F_ExRate,
TCRDBH.F_Agent AS F_ComId, NULL AS F_ChgType, 0 AS F_AgentAmt, NULL AS F_Posted, NULL AS F_ETF, TCRDBH.F_CrDbNo As F_InvNo, 0 As F_HasInvoice,
0 AS MAR, 0 As MARPaid, 0 As MAR_USD, 0 As MAR_LOC, 0 AS MAP, 0 As MAP_USD,0 As MAP_LOC,
ISNULL(CASE WHEN TCRDB.F_Debit <> 0 THEN TCRDB.F_LAmount ELSE 0 END, 0) As MDebit,
ISNULL(CASE WHEN TCRDB.F_Credit <> 0 THEN TCRDB.F_LAmount ELSE 0 END, 0) As MCredit,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) <> TSET.LCur THEN TCRDB.F_Debit ELSE 0 END, 0) As MDebit_USD,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) <> TSET.LCur THEN TCRDB.F_Credit ELSE 0 END, 0) As MCredit_USD,
ISNULL(CASE WHEN TCRDB.F_Debit <> 0 AND (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) = TSET.LCur THEN 0 ELSE TCRDB.F_Debit END, 0) As MDebit_LOC,
ISNULL(CASE WHEN TCRDB.F_Credit <> 0  AND (CASE WHEN ISNULL(TCRDBH.F_Currency, '') = '' THEN TSET.LCur ELSE TCRDBH.F_Currency END) = TSET.LCur THEN 0 ELSE TCRDB.F_Credit END, 0) As MCredit_LOC,
CASE WHEN SUBSTRING(TCRDB.F_CRDBCODE, 1, 3) In ('GST','HST','PST','IVA') THEN 2 Else 0 END As F_IsDuty, TCRDBH.F_InvoiceDate AS F_InvoiceDate,
(CASE WHEN ROUND(TCRDBH.F_Total - TCRDBH.F_PaidAmt,2) = 0 AND ROUND(TCRDBH.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(TCRDBH.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid
FROM T_CRDBDETAIL TCRDB
INNER JOIN SettingValues TSET ON 1=1
LEFT JOIN T_CRDBHD TCRDBH ON TCRDBH.F_ID = TCRDB.F_CrDbHDID
LEFT JOIN V_BLSUMM TBL ON TBL.F_TBName = TCRDBH.F_TBNAME AND TBL.F_TBID = TCRDBH.F_TBID
WHERE TCRDB.F_STBName <> 'T_OPACCT' AND ISNULL(TCRDBH.F_Void,0) = 0    -- And SUBSTRING(TCRDB.F_CrDbCode, 1, 3) Not In ('GST','HST','PST','IVA')

UNION ALL SELECT
'Warehousing' As F_Department, 6 As F_ViewOrder,
0 AS F_PS, TARH.F_TBNAME AS F_MTBName, TARH.F_ID AS F_MTBId, TARH.F_TBNAME AS F_TBNAME, TARH.F_ID, 'T_INVOHD' AS F_HDActName, TARH.F_ID AS F_HDActId,
'T_INVODETAIL' AS F_ActName, TAR.F_ID AS F_ActId, TARH.F_CheckNo AS F_CheckNo, TARH.F_PaidDate AS F_PaidDate,
TAR.F_AgtExrate AS F_AgtExrate, TAR.F_Exrate AS F_ActExrate, TARH.F_PostDate AS F_PostDate, TAR.F_BILLINGCODE, TAR.F_Description,
(CASE WHEN ISNULL(TAR.F_Cur, '') = '' THEN TSET.LCur ELSE TAR.F_Cur END) AS F_Currency, TAR.F_Exrate AS F_ExRate,
TARH.F_BILLTO AS F_ComId, TAR.F_ChgType, TAR.F_AgtAmount As F_AgentAmt, 2 As F_Posted, NULL AS F_ETF, TARH.F_InvoiceNo As F_InvNo, 1 As F_HasInvoice,
ISNULL(TAR.F_LAmount, 0) AS MAR, ISNULL((TARH.F_InvoiceAmt - TARH.F_PaidAmt) * (CASE WHEN TARH.F_InvoiceAmt > 0 THEN 1 ELSE -1 END), 0) As MARPaid,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TAR.F_Cur, '') = '' THEN TSET.LCur ELSE TAR.F_Cur END) <> TSET.LCur THEN TAR.F_CurAmount ELSE 0 END, 0) As MAR_USD,
ISNULL(CASE WHEN (CASE WHEN ISNULL(TAR.F_Cur, '') = '' THEN TSET.LCur ELSE TAR.F_Cur END) <> TSET.LCur THEN 0 ELSE TAR.F_CurAmount END, 0) As MAR_LOC,
0 AS MAP, 0 As MAP_USD, 0 As MAP_LOC, 0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MCredit_USD, 0 As MDebit_LOC, 0 As MCredit_LOC,
CASE WHEN SUBSTRING(TAR.F_BillingCode, 1, 3) In ('GST','HST','PST','IVA') THEN 2 Else 0 END As F_IsDuty, TARH.F_InvoiceDate AS F_InvoiceDate,
(CASE WHEN ROUND(TARH.F_InvoiceAmt - TARH.F_PaidAmt,2) = 0 AND ROUND(TARH.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(TARH.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid
FROM T_INVODETAIL TAR
INNER JOIN SettingValues TSET ON 1=1
LEFT JOIN T_INVOHD TARH on TARH.F_ID = TAR.F_INVOHDID
WHERE TARH.F_TBNAME = 'T_STORAGE'
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_AccountByOperation_Deferred" ,
                @"
WITH SettingValues(defSales, defCost, LCur) AS (
SELECT
(SELECT TOP 1 F_Value FROM T_SETTINGS WHERE F_NAME = 'F_DefSales') As defSales,
(SELECT TOP 1 F_Value FROM T_SETTINGS WHERE F_NAME = 'F_DefCost') AS defCost,
(SELECT TOP 1 F_Currency FROM T_CODEDATA) AS LCur
)

--Invoice
SELECT
Case subString(ISNULL(T3H.F_TBName, ''), 3, 2)
WHEN 'AO' THEN 'Air Export' WHEN 'AI' THEN 'Air Import' WHEN 'OO' THEN 'Ocean Export' WHEN 'OI' THEN 'Ocean Import'
WHEN 'WR' THEN 'Warehousing'  WHEN 'WS' THEN 'Warehousing'  WHEN 'GE' THEN 'Other Shipment' ELSE 'Non-Operation' END As F_Department,
Case subString(ISNULL(T3H.F_TBName, ''), 3, 2)
WHEN 'AO' THEN 4 WHEN 'AI' THEN 3 WHEN 'OO' THEN 2 WHEN 'OI' THEN 1 WHEN 'WR' THEN 6 WHEN 'WS' THEN 6 WHEN 'GE' THEN 5 ELSE 7 END As F_ViewOrder,
T1.F_MTBName As F_MTBName, T1.F_MBLId AS F_MTBId, ISNULL(T3H.F_TBName, '') AS F_TBNAME, ISNULL(T3H.F_TBID, 0) AS F_TBID, T1.F_TBName As F_HDActName, T1.F_TBId AS F_HDActId,
T1.F_STbName As F_ActName, T1.F_STBId As F_ActId,
ISNULL(T3H.F_CheckNo, '') AS F_CheckNo, T3H.F_PaidDate, T3H.F_InvoiceDate,
COALESCE(T3.F_AgtExrate, T1.F_ExRate) AS F_AgtExrate, COALESCE(T3.F_Exrate, T1.F_ExRate) AS F_ActExrate,

T1.F_PostDate, T1.F_GlNo, T3.F_Description, CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END AS F_Currency,
CASE WHEN T1.F_ExRate = 0 THEN 1 ELSE T1.F_ExRate END AS F_ExRate, T1.F_ComId, NULL AS F_ChgType, NULL AS F_AgentAmt, NULL AS F_Posted, NULL AS F_ETF,
T3H.F_InvoiceNo AS F_InvNo, 0 As F_HasInvoice,
(CASE WHEN T1.F_GLNo = T2.defSales THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR,
(CASE WHEN T1.F_GLNo = T2.defSales THEN ISNULL((T3H.F_InvoiceAmt - T3H.F_PaidAmt) * (CASE WHEN T3H.F_InvoiceAmt > 0 THEN 1 ELSE -1 END), 0) ELSE 0 END) As MARPaid,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) <> T2.LCur AND T1.F_GLNo = T2.defSales THEN T1.F_FCredit - T1.F_FDebit ELSE 0 END) As MAR_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) = T2.LCur AND T1.F_GLNo = T2.defSales THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR_LOC,
(CASE WHEN T1.F_GLNo = T2.defCost THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) <> T2.LCur AND T1.F_GLNo = T2.defCost THEN T1.F_FDebit - T1.F_FCredit ELSE 0 END) As MAP_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) = T2.LCur AND T1.F_GLNo = T2.defCost THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP_LOC,
0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MDebit_LOC, 0 As MCredit_USD, 0 As MCredit_LOC,
(CASE WHEN ROUND(T3H.F_InvoiceAmt - T3H.F_PaidAmt,2) = 0 AND ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid

FROM V_SLIPX T1
INNER JOIN SettingValues T2 ON 1=1
LEFT JOIN T_INVODETAIL T3 ON T1.F_STBID = T3.F_ID
LEFT JOIN T_INVOHD T3H ON T1.F_TBID = T3H.F_ID
Where
T1.F_GLNO IN (T2.defSales, T2.defCost)
AND T1.F_TBTYPE < 100 AND T1.F_Type <> 'X'
AND T1.F_TBName = 'T_INVOHD'

--Bill
UNION ALL
SELECT
Case subString(ISNULL(T3H.F_TBName, ''), 3, 2)
WHEN 'AO' THEN 'Air Export' WHEN 'AI' THEN 'Air Import' WHEN 'OO' THEN 'Ocean Export' WHEN 'OI' THEN 'Ocean Import'
WHEN 'WR' THEN 'Warehousing'  WHEN 'WS' THEN 'Warehousing'  WHEN 'GE' THEN 'Other Shipment' ELSE 'Non-Operation' END As F_Department,
Case subString(ISNULL(T3H.F_TBName, ''), 3, 2)
WHEN 'AO' THEN 4 WHEN 'AI' THEN 3 WHEN 'OO' THEN 2 WHEN 'OI' THEN 1 WHEN 'WR' THEN 6 WHEN 'WS' THEN 6 WHEN 'GE' THEN 5 ELSE 7 END As F_ViewOrder,
T1.F_MTBName As F_MTBName, T1.F_MBLId AS F_MTBId, ISNULL(T3H.F_TBName, '') AS F_TBNAME, ISNULL(T3H.F_TBID, 0) AS F_TBID, T1.F_TBName As F_HDActName, T1.F_TBId AS F_HDActId,
T1.F_STbName As F_ActName, T1.F_STBId As F_ActId,
ISNULL(T3H.F_CheckNo, '') AS F_CheckNo, T3H.F_PaidDate, T3H.F_InvoiceDate,
COALESCE(T3.F_AgtExrate, T1.F_ExRate) AS F_AgtExrate, COALESCE(T3.F_Exrate, T1.F_ExRate) AS F_ActExrate,

T1.F_PostDate, T1.F_GlNo, T3.F_Description, CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END AS F_Currency,
CASE WHEN T1.F_ExRate = 0 THEN 1 ELSE T1.F_ExRate END AS F_ExRate, T1.F_ComId, NULL AS F_ChgType, NULL AS F_AgentAmt, NULL AS F_Posted, NULL AS F_ETF,
T3H.F_InvoiceNo AS F_InvNo, 0 As F_HasInvoice,
(CASE WHEN T1.F_GLNo = T2.defSales THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR,
(CASE WHEN T1.F_GLNo = T2.defSales THEN ISNULL((T3H.F_InvoiceAmt - T3H.F_PaidAmt) * (CASE WHEN T3H.F_InvoiceAmt > 0 THEN 1 ELSE -1 END), 0) ELSE 0 END) As MARPaid,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) <> T2.LCur AND T1.F_GLNo = T2.defSales THEN T1.F_FCredit - T1.F_FDebit ELSE 0 END) As MAR_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) = T2.LCur AND T1.F_GLNo = T2.defSales THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR_LOC,
(CASE WHEN T1.F_GLNo = T2.defCost THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) <> T2.LCur AND T1.F_GLNo = T2.defCost THEN T1.F_FDebit - T1.F_FCredit ELSE 0 END) As MAP_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) = T2.LCur AND T1.F_GLNo = T2.defCost THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP_LOC,
0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MDebit_LOC, 0 As MCredit_USD, 0 As MCredit_LOC,
(CASE WHEN ROUND(T3H.F_InvoiceAmt - T3H.F_PaidAmt,2) = 0 AND ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid

FROM V_SLIPX T1
INNER JOIN SettingValues T2 ON 1=1
LEFT JOIN T_APDETAIL T3 ON T1.F_STBID = T3.F_ID
LEFT JOIN T_APHD T3H ON T1.F_TBID = T3H.F_ID
Where
T1.F_GLNO IN (T2.defSales, T2.defCost)
AND T1.F_TBTYPE < 100 AND T1.F_Type <> 'X'
AND T1.F_TBName = 'T_APHD'

--CrDb
UNION ALL
SELECT
Case subString(ISNULL(T5H.F_TBName, ''), 3, 2)
WHEN 'AO' THEN 'Air Export' WHEN 'AI' THEN 'Air Import' WHEN 'OO' THEN 'Ocean Export' WHEN 'OI' THEN 'Ocean Import'
WHEN 'WR' THEN 'Warehousing'  WHEN 'WS' THEN 'Warehousing'  WHEN 'GE' THEN 'Other Shipment' ELSE 'Non-Operation' END As F_Department,
Case subString(ISNULL(T5H.F_TBName, ''), 3, 2)
WHEN 'AO' THEN 4 WHEN 'AI' THEN 3 WHEN 'OO' THEN 2 WHEN 'OI' THEN 1 WHEN 'WR' THEN 6 WHEN 'WS' THEN 6 WHEN 'GE' THEN 5 ELSE 7 END As F_ViewOrder,
T1.F_MTBName As F_MTBName, T1.F_MBLId AS F_MTBId,
ISNULL(T5H.F_TBName, '') AS F_TBName, ISNULL(T5H.F_TBId, 0) AS F_TbID,
CASE WHEN T5H.F_ID IS NULL THEN 'ZNOTISSUED' ELSE T1.F_TBName END As F_HDActName, T1.F_TBID AS F_HDActId,
CASE WHEN T5.F_ID IS NULL THEN 'ZNOTISSUED' ELSE T1.F_STBName END As F_ActName, T1.F_STBID As F_ActId,
COALESCE(T5H.F_CheckNo, '') AS F_CheckNo, T5H.F_PaidDate AS F_PaidDate, T5H.F_InvoiceDate,
COALESCE(T5.F_Exrate, T1.F_ExRate) AS F_AgtExrate, COALESCE(T5.F_Exrate, T1.F_ExRate) AS F_ActExrate,

T1.F_PostDate, T1.F_GlNo, T5.F_Description, CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END AS F_Currency,
CASE WHEN T1.F_ExRate = 0 THEN 1 ELSE T1.F_ExRate END AS F_ExRate, T1.F_ComId, NULL AS F_ChgType, NULL AS F_AgentAmt, NULL AS F_Posted, NULL AS F_ETF,
CASE WHEN T5H.F_ID IS NULL THEN 'Not Issued' ELSE T5H.F_CrDbNo END AS F_InvNo, 0 As F_HasInvoice,
0 As MAR, 0 As MARPaid, 0 As MAR_USD, 0 As MAR_LOC, 0 As MAP, 0 As MAP_USD, 0 As MAP_LOC,
(CASE WHEN T1.F_GLNo = T2.defSales THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MDebit,
(CASE WHEN T1.F_GLNo = T2.defCost THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MCredit,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) <> T2.LCur AND T1.F_GLNo = T2.defSales THEN T1.F_FCredit - T1.F_FDebit ELSE 0 END) As MDebit_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) = T2.LCur AND T1.F_GLNo = T2.defSales THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MDebit_LOC,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) <> T2.LCur AND T1.F_GLNo = T2.defCost THEN T1.F_FDebit - T1.F_FCredit ELSE 0 END) As MCredit_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE T2.LCur END) = T2.LCur AND T1.F_GLNo = T2.defCost THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MCredit_LOC,
(CASE WHEN ROUND(T5H.F_Total - T5H.F_PaidAmt,2) = 0 AND ROUND(T5H.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(T5H.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid

FROM V_SLIPX T1
INNER JOIN SettingValues T2 ON 1=1
LEFT JOIN T_CRDBDETAIL T5 ON T1.F_STBID = T5.F_ID
LEFT JOIN T_CRDBHD T5H ON T1.F_TBID = T5H.F_ID
Where
T1.F_GLNO IN (T2.defSales, T2.defCost)
AND T1.F_TBTYPE < 100 AND T1.F_Type <> 'X'
AND T1.F_TBName = 'T_CRDBHD'
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_BeginningBalance" ,
                @"
--Setting Values
WITH SettingValues(LCur, SMonth, AcctStartDate) AS (
SELECT Top 1
F_Currency AS LCur, -- Local Currency
CASE WHEN T2.F_N2 = 12 THEN 1 ELSE T2.F_N2 + 1 END AS SMonth, --Account Start Month
Convert(DATETIME, (CASE WHEN T2.F_C3 = '000000' THEN '20000101' ELSE T2.F_C3 + '01' END)) AS AcctStartDate -- Account Beginning Date
FROM T_CODEDATA T1
LEFT JOIN T_AotherInfo T2 ON T2.F_TBNAME = 'T_CODEDATA' AND T2.F_TBID = 1 AND T2.F_Type = 27
),

UsedJournalYear(JYear) AS(
-- Journal에 사용된 모든 회계 년도
SELECT JYear
FROM (
SELECT
CASE WHEN TSET.SMonth > MONTH(F_PostDate) THEN YEAR(F_PostDate) - 1 ELSE YEAR(F_PostDate) END AS JYear
From V_SLIPX
INNER JOIN SettingValues TSET ON 1 = 1
Where F_PostDate >= TSET.acctStartDate And F_TBType < 100
) TT
GROUP BY TT.JYear
),

BeginningBalance(F_AccountYear, F_GLNo, F_ComType, F_ComId, F_Branch, F_SubCode, F_Currency, F_Debit, F_Credit, F_FDebit, F_FCredit) AS(
SELECT
CASE WHEN TSET.SMonth > MONTH(F_PostDate) THEN YEAR(F_PostDate) - 1 ELSE YEAR(F_PostDate) END AS F_AccountYear,
F_GLNo , F_ComType, F_ComId, F_Branch, F_SubCode, F_Currency, F_Debit, F_Credit, F_FDebit, F_FCredit
FROM V_SLIPX T1
INNER JOIN SettingValues TSET ON 1 = 1
WHERE
T1.F_Type IN ('X', 'B', 'DB', 'CB')
AND T1.F_TBType < 100
AND F_SeqNo = 1
AND F_PostDate >= TSET.AcctStartDate
) 

--//////////////////////////////Year End Process에 의해 발생한 Beginning Balance//////////////////////////////
SELECT
'B' AS F_JType, T2.F_AccountYear, F_GLNo, F_ComType, F_ComId, F_Branch, F_SubCode, F_Currency, F_Debit, F_Credit, F_FDebit, F_FCredit
FROM UsedJournalYear T1
INNER JOIN BeginningBalance T2 ON T1.JYear = T2.F_AccountYear

UNION ALL
--//////////////////////////////계산된 Beginning Balance//////////////////////////////////////////////////////
--// 1. Journal에 사용된 모든 회계년도중 Beginning Balance가 존재하지 않는 회계년에 대해서만 시행한다.
--// 2. (해당 년도 이전 마지막으로 시행된 Beginning Balance)
--//    + (마지막 Beginning Balance가 발생한 날짜 ~ 해당 년도 사이에 발생한 값) 을 더해준다.
--///////////////////////////////////////////////////////////////////////////////////////////////////////////
SELECT
'A' AS F_JType, T2.F_AccountYear, T2.F_GLNo, T2.F_ComType, T2.F_ComId, T2.F_Branch, T2.F_SubCode, T2.F_Currency,
CASE WHEN T2.F_Debit > T2.F_Credit THEN T2.F_Debit - T2.F_Credit ELSE 0 END AS F_Debit,
CASE WHEN T2.F_Debit > T2.F_Credit THEN 0 ELSE T2.F_Credit - F_Debit END AS F_Credit,
CASE WHEN T2.F_Debit > T2.F_Credit THEN T2.F_FDebit - T2.F_FCredit ELSE 0 END AS F_FDebit,
CASE WHEN T2.F_Debit > T2.F_Credit THEN 0 ELSE T2.F_FCredit - T2.F_FDebit END AS F_FCredit
FROM UsedJournalYear T1

LEFT JOIN ( -- Beginnging Balance가 존재하는 회계 년도
SELECT F_AccountYear FROM BeginningBalance GROUP BY F_AccountYear
) TB ON TB.F_AccountYear = T1.JYear

OUTER APPLY (
SELECT
T1.JYear AS F_AccountYear, TAC.F_GLNo, TAC.F_ComType, TAC.F_ComId, TAC.F_Branch, TAC.F_SubCode, TAC.F_Currency,
(TAC.F_Debit + ISNULL(TLB.F_Debit, 0)) AS F_Debit, (TAC.F_Credit + ISNULL(TLB.F_Credit, 0)) AS F_Credit,
(TAC.F_FDebit + ISNULL(TLB.F_FDebit, 0)) AS F_FDebit, (TAC.F_FCredit + ISNULL(TLB.F_FCredit, 0)) AS F_FCredit
FROM (
SELECT
TT.F_GLNo, TT.F_ComType, TT.F_ComId, TT.F_Branch, TT.F_SubCode, TT.F_Currency,
SUM(F_Debit) AS F_Debit, SUM(F_Credit) AS F_Credit, SUM(F_FDebit) AS F_FDebit, SUM(F_FCredit) AS F_FCredit
FROM (
SELECT
T1.* , CASE WHEN TSET.SMonth > MONTH(F_PostDate) THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) + 1 END AS F_AccountYear
FROM V_SLIPX T1
INNER JOIN SettingValues TSET ON 1 = 1
WHERE
T1.F_Type NOT IN ('X', 'B', 'DB', 'CB')
AND T1.F_TBType < 100
AND T1.F_PostDate >= TSET.AcctStartDate

)TT
OUTER APPLY ( -- 마지막 Beginnging Balance가 발생한 년도 (해당 년도 이전)
SELECT TOP 1 F_AccountYear
From BeginningBalance
Where F_AccountYear < T1.JYear
AND F_GLNo = TT.F_GlNo
AND F_ComType = TT.F_ComType
AND F_ComId = TT.F_ComId
AND F_Branch = TT.F_Branch
AND F_SubCode = TT.F_SubCode
AND F_Currency = TT.F_Currency
ORDER BY F_AccountYear DESC
) TT2
WHERE
TT.F_AccountYear > ISNULL(TT2.F_AccountYear, 0)
AND TT.F_AccountYear <= T1.JYear
GROUP BY F_GLNo, F_ComType, F_ComId, F_Branch, F_SubCode, F_Currency
) TAC

OUTER APPLY ( -- 마지막 Beginning Balance (해당 년도 이전)
SELECT Top 1
F_AccountYear , F_GLNo, F_ComType, F_ComId, F_Branch, F_SubCode, F_Currency, F_Debit, F_Credit, F_FDebit, F_FCredit
FROM BeginningBalance TTB
Where
F_AccountYear < T1.JYear
AND TTB.F_GLNo = TAC.F_GlNo
AND TTB.F_ComType = TAC.F_ComType
AND TTB.F_ComId = TAC.F_ComId
AND TTB.F_Branch = TAC.F_Branch
AND TTB.F_SubCode = TAC.F_SubCode
AND TTB.F_Currency = TAC.F_Currency
ORDER BY TTB.F_AccountYear DESC
) TLB
) T2
WHERE TB.F_AccountYear IS NULL  --Beginning Balance가 존재하지 않는 년도에 대해서만 시행.
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_AccountByOperation_JournalBase" ,
                @"
WITH SettingValues(LCur) AS (
SELECT
(SELECT TOP 1 F_Currency FROM T_CODEDATA) AS LCur
),

T_Department(GLGroup, F_Department)  AS (
SELECT  'PI' AS GLGroup, 'Air Export' AS F_Department
UNION ALL SELECT 'PC' AS GLGroup, 'Air Export' AS F_Department
UNION ALL SELECT 'AI' AS GLGroup, 'Air Import' AS F_Department
UNION ALL SELECT 'AC' AS GLGroup, 'Air Import' AS F_Department
UNION ALL SELECT 'EI' AS GLGroup, 'Ocean Export' AS F_Department
UNION ALL SELECT 'EC' AS GLGroup, 'Ocean Export' AS F_Department
UNION ALL SELECT 'II' AS GLGroup, 'Ocean Import' AS F_Department
UNION ALL SELECT 'IC' AS GLGroup, 'Ocean Import' AS F_Department
UNION ALL SELECT 'WI' AS GLGroup, 'Warehousing' AS F_Department
UNION ALL SELECT 'WC' AS GLGroup, 'Warehousing' AS F_Department
UNION ALL SELECT 'TC' AS GLGroup, 'Other Shipment' AS F_Department
UNION ALL SELECT 'TI' AS GLGroup, 'Other Shipment' AS F_Department
),

T_ViewOrder(GLGroup, F_ViewOrder)  AS (
SELECT  'PI' AS GLGroup, 4 AS F_ViewOrder
UNION ALL SELECT  'PC' AS GLGroup, 4 AS F_ViewOrder
UNION ALL SELECT  'AI' AS GLGroup, 3 AS F_ViewOrder
UNION ALL SELECT  'AC' AS GLGroup, 3 AS F_ViewOrder
UNION ALL SELECT  'EI' AS GLGroup, 2 AS F_ViewOrder
UNION ALL SELECT  'EC' AS GLGroup, 2 AS F_ViewOrder
UNION ALL SELECT  'II' AS GLGroup, 1 AS F_ViewOrder
UNION ALL SELECT  'IC' AS GLGroup, 1 AS F_ViewOrder
UNION ALL SELECT  'WI' AS GLGroup, 6 AS F_ViewOrder
UNION ALL SELECT  'WC' AS GLGroup, 6 AS F_ViewOrder
UNION ALL SELECT  'TC' AS GLGroup, 5 AS F_ViewOrder
UNION ALL SELECT  'TI' AS GLGroup, 5 AS F_ViewOrder
) 

--Invoice
SELECT
ISNULL(TDEP.F_Department, 'Non-Operation') AS F_Department, ISNULL(TVO.F_ViewOrder, 7) AS F_ViewOrder,
CASE WHEN T3H.F_TBNAME = '' THEN 'T_INVOHD' WHEN T3H.F_TBNAME = 'T_STORAGE' THEN T3H.F_TBNAME ELSE T1.F_MTBName END AS F_MTBName,
CASE WHEN T3H.F_TBNAME = '' THEN T3H.F_ID WHEN T3H.F_TBNAME = 'T_STORAGE' THEN T1.F_TBId ELSE T1.F_MBLId END AS F_MTBId,
CASE WHEN T3H.F_TBNAME = '' THEN 'T_INVOHD' ELSE T3H.F_TBNAME END AS F_TBNAME,
CASE WHEN T3H.F_TBNAME = '' THEN T3H.F_ID WHEN T3H.F_TBNAME = 'T_STORAGE' THEN T1.F_TBId ELSE T3H.F_TBID END AS F_TBID,
T1.F_TBName As F_HDActName, T1.F_TBId AS F_HDActId, T1.F_STbName As F_ActName, T1.F_STBId As F_ActId,
T1.F_ComType, T1.F_ComId, T1.F_PostDate, T1.F_GlNo,
CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END AS F_Currency, CASE WHEN T1.F_ExRate = 0 THEN 1 ELSE T1.F_ExRate END AS F_ExRate,
T3H.F_CheckNo, T3H.F_PaidDate, T3H.F_InvoiceDate, T3.F_Description,
T3H.F_InvoiceNo AS F_InvNo, (CASE WHEN T2.F_GLType = 'I' AND T3H.F_Void = 0 THEN 1 ELSE 0 END) As F_HasInvoice,

T3H.F_Void, COALESCE(T3H.F_OriginInvId, 0) AS F_OriVoid, T3.F_BillingCode,
(CASE WHEN T2.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR,
(CASE WHEN T2.F_GLType = 'I' THEN ISNULL((T3H.F_InvoiceAmt - T3H.F_PaidAmt) * (CASE WHEN T3H.F_InvoiceAmt > 0 THEN 1 ELSE -1 END),0) ELSE 0 END) As MARPaid,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur AND T2.F_GLType = 'I' THEN T1.F_FCredit - T1.F_FDebit ELSE 0 END) As MAR_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur AND T2.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR_LOC,
(CASE WHEN T2.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur AND T2.F_GLType = 'C' THEN T1.F_FDebit - T1.F_FCredit ELSE 0 END) As MAP_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur AND T2.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP_LOC,
0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MDebit_LOC, 0 As MCredit_USD, 0 As MCredit_LOC, 0 AS F_DutyAmount, 0 AS F_IsDuty,
(CASE WHEN ROUND(T3H.F_InvoiceAmt - T3H.F_PaidAmt,2) = 0 AND ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid
FROM V_SLIPX T1

INNER JOIN SettingValues TSET ON 1=1
LEFT JOIN T_CODEGLNO T2 ON T2.F_GLNo = T1.F_GLNo
LEFT JOIN T_INVODETAIL T3 ON T1.F_STBName = 'T_INVODETAIL' AND T1.F_STBID = T3.F_ID
LEFT JOIN T_INVOHD T3H ON T1.F_TBID = T3H.F_ID
LEFT JOIN T_Department TDEP ON T2.F_GLGroup = TDEP.GLGroup
LEFT JOIN T_ViewOrder TVO ON T2.F_GLGroup = TVO.GLGroup
Where
T2.F_GLType IN ('I', 'C')
AND T1.F_TBTYPE < 100 AND T1.F_Type <> 'X'
AND T1.F_TBNAME = 'T_INVOHD' 

--Bill
UNION ALL
SELECT
ISNULL(TDEP.F_Department, 'Non-Operation') AS F_Department, ISNULL(TVO.F_ViewOrder, 7) AS F_ViewOrder,
CASE WHEN T3H.F_TBNAME = '' THEN 'T_APHD' ELSE T1.F_MTBName END AS F_MTBName,
CASE WHEN T3H.F_TBNAME = '' THEN T3H.F_ID ELSE T1.F_MBLId END AS F_MTBId,
CASE WHEN T3H.F_TBNAME = '' THEN 'T_APHD' ELSE T3H.F_TBNAME END AS F_TBNAME,
CASE WHEN T3H.F_TBNAME = '' THEN T3H.F_ID ELSE T3H.F_TBID END AS F_TBID,
T1.F_TBName As F_HDActName, T1.F_TBId AS F_HDActId, T1.F_STbName As F_ActName, T1.F_STBId As F_ActId,
T1.F_ComType, T1.F_ComId, T1.F_PostDate, T1.F_GlNo,
CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END AS F_Currency, CASE WHEN T1.F_ExRate = 0 THEN 1 ELSE T1.F_ExRate END AS F_ExRate,
T3H.F_CheckNo, T3H.F_PaidDate, T3H.F_InvoiceDate, T3.F_Description,
T3H.F_InvoiceNo AS F_InvNo, (CASE WHEN T2.F_GLType = 'I' AND T3H.F_Void = 0 THEN 1 ELSE 0 END) As F_HasInvoice,

T3H.F_Void, COALESCE(T3H.F_OriginInvId, 0) AS F_OriVoid, T3.F_BillingCode,
(CASE WHEN T2.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR,
(CASE WHEN T2.F_GLType = 'I' THEN ISNULL((T3H.F_InvoiceAmt - T3H.F_PaidAmt) * (CASE WHEN T3H.F_InvoiceAmt > 0 THEN 1 ELSE -1 END),0) ELSE 0 END) As MARPaid,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur AND T2.F_GLType = 'I' THEN T1.F_FCredit - T1.F_FDebit ELSE 0 END) As MAR_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur AND T2.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR_LOC,
(CASE WHEN T2.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur AND T2.F_GLType = 'C' THEN T1.F_FDebit - T1.F_FCredit ELSE 0 END) As MAP_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur AND T2.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP_LOC,
0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MDebit_LOC, 0 As MCredit_USD, 0 As MCredit_LOC, 0 AS F_DutyAmount, 0 AS F_IsDuty,
(CASE WHEN ROUND(T3H.F_InvoiceAmt - T3H.F_PaidAmt,2) = 0 AND ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid
FROM V_SLIPX T1

INNER JOIN SettingValues TSET ON 1=1
LEFT JOIN T_CODEGLNO T2 ON T2.F_GLNo = T1.F_GLNo
LEFT JOIN T_APDETAIL T3 ON T1.F_STBName = 'T_APDETAIL' AND T1.F_STBID = T3.F_ID
LEFT JOIN T_APHD T3H ON T1.F_TBID = T3H.F_ID
LEFT JOIN T_Department TDEP ON T2.F_GLGroup = TDEP.GLGroup
LEFT JOIN T_ViewOrder TVO ON T2.F_GLGroup = TVO.GLGroup
Where
T2.F_GLType IN ('I', 'C')
AND T1.F_TBTYPE < 100 AND T1.F_Type <> 'X'
AND T1.F_TBNAME = 'T_APHD' 

--CrDb
UNION ALL
SELECT
ISNULL(TDEP.F_Department, 'Non-Operation') AS F_Department, ISNULL(TVO.F_ViewOrder, 7) AS F_ViewOrder,
T1.F_MTBName, T1.F_MBLId AS F_MTBId, T3H.F_TBNAME, T3H.F_TBID, T1.F_TBName As F_HDActName, T1.F_TBId AS F_HDActId, T1.F_STbName As F_ActName, T1.F_STBId As F_ActId,
T1.F_ComType, T1.F_ComId, T1.F_PostDate, T1.F_GlNo,
CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END AS F_Currency, CASE WHEN T1.F_ExRate = 0 THEN 1 ELSE T1.F_ExRate END AS F_ExRate,
T3H.F_CheckNo, T3H.F_PaidDate, T3H.F_InvoiceDate, T3.F_Description,
T3H.F_CrDbNo AS F_InvNo, (CASE WHEN T2.F_GLType = 'I' AND T3H.F_Void = 0 THEN 1 ELSE 0 END) As F_HasInvoice,

T3H.F_Void, 0 AS F_OriVoid, T3.F_CrDbCode AS F_BillingCode,
0 As MAR, 0 As MARPaid, 0 As MAR_USD, 0 As MAR_LOC, 0 As MAP, 0 As MAP_USD, 0 As MAP_LOC,
(CASE WHEN T2.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MDebit,
(CASE WHEN T2.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MCredit,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur AND T2.F_GLType = 'I' THEN T1.F_FCredit - T1.F_FDebit ELSE 0 END) As MDebit_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur AND T2.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MDebit_LOC,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur AND T2.F_GLType = 'C' THEN T1.F_FDebit - T1.F_FCredit ELSE 0 END) As MCredit_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur AND T2.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MCredit_LOC, 0 AS F_DutyAmount, 0 AS F_IsDuty,
(CASE WHEN ROUND(T3H.F_Total - T3H.F_PaidAmt,2) = 0 AND ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'F' WHEN ROUND(T3H.F_PaidAmt,2) <> 0 THEN 'P' ELSE '' END) AS F_IsPaid
FROM V_SLIPX T1

INNER JOIN SettingValues TSET ON 1=1
LEFT JOIN T_CODEGLNO T2 ON T2.F_GLNo = T1.F_GLNo
LEFT JOIN T_CRDBDETAIL T3 ON T1.F_STBName = 'T_CRDBDETAIL' AND T1.F_STBID = T3.F_ID
LEFT JOIN T_CRDBHD T3H ON T1.F_TBID = T3H.F_ID
LEFT JOIN T_Department TDEP ON T2.F_GLGroup = TDEP.GLGroup
LEFT JOIN T_ViewOrder TVO ON T2.F_GLGroup = TVO.GLGroup
Where
T2.F_GLType IN ('I', 'C')
AND T1.F_TBTYPE < 100 AND T1.F_Type <> 'X'
AND T1.F_TBNAME = 'T_CRDBHD' 

--Manual(Payment)
UNION ALL
SELECT
ISNULL(TDEP.F_Department, 'Non-Operation') AS F_Department, ISNULL(TVO.F_ViewOrder, 7) AS F_ViewOrder,
'T_DEPOHD' AS F_MTBName, T1.F_TBID AS F_MTBId, 'T_DEPOHD' AS F_TBName, T1.F_TBID AS F_TbID, 'T_DEPOHD' As F_HDActName, T1.F_TBID AS F_HDActId, 'T_DEPODETAIL' As F_ActName, T1.F_STBID As F_ActId,
T1.F_ComType, T1.F_ComId, T1.F_PostDate, T1.F_GlNo,
(CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) AS F_Currency, CASE WHEN T1.F_ExRate = 0 THEN 1 ELSE T1.F_ExRate END AS F_ExRate,
TDH.F_CheckNo, COALESCE(TDH.F_DepositDate, NULL) AS F_PaidDate, TDH.F_DepositDate AS F_InvoiceDate, TDH.F_CheckNo AS F_Description,
TDH.F_CheckNo AS F_InvNo, 0 As F_HasInvoice, 0 AS F_Void, 0 AS F_OriVoid, TDH.F_CheckNo As F_BillingCode,

(CASE WHEN T2.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR, 0 As MARPaid,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur THEN T1.F_FCredit ELSE 0 END) As MAR_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur THEN T1.F_Credit ELSE 0 END) As MAR_LOC,
(CASE WHEN T2.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur THEN T1.F_FDebit ELSE 0 END) As MAP_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur THEN T1.F_Debit ELSE 0 END) As MAP_LOC,
0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MDebit_LOC, 0 As MCredit_USD, 0 As MCredit_LOC, 0 AS F_DutyAmount, 0 AS F_IsDuty, '' AS F_IsPaid
FROM V_SLIPX T1

INNER JOIN SettingValues TSET ON 1=1
LEFT JOIN T_CODEGLNO T2 ON T2.F_GLNo = T1.F_GLNo
LEFT JOIN T_DEPODETAIL TD ON T1.F_STBName = 'T_DEPODETAIL' AND T1.F_STBID = TD.F_ID
LEFT JOIN T_DEPOHD TDH ON T1.F_TBID = TDH.F_ID
LEFT JOIN T_Department TDEP ON T2.F_GLGroup = TDEP.GLGroup
LEFT JOIN T_ViewOrder TVO ON T2.F_GLGroup = TVO.GLGroup
Where
T2.F_GLType IN ('I', 'C')
AND T1.F_TBTYPE < 100 AND T1.F_Type <> 'X'
AND T1.F_TBName = 'T_DEPOHD' 

--Adjust Journal
UNION ALL
SELECT
ISNULL(TDEP.F_Department, 'Non-Operation') AS F_Department, ISNULL(TVO.F_ViewOrder, 7) AS F_ViewOrder,
'T_SLIPHD' AS F_MTBName, T1.F_TBID AS F_MTBId, 'T_SLIPHD' AS F_TBName, T1.F_TBID AS F_TbID, 'T_SLIPHD' As F_HDActName, T1.F_TBID AS F_HDActId, 'T_SLIPDETAIL' As F_ActName, T1.F_STBID AS F_ActId,
T1.F_ComType, T1.F_ComId, T1.F_PostDate, T1.F_GlNo,
(CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) AS F_Currency, CASE WHEN T1.F_ExRate = 0 THEN 1 ELSE T1.F_ExRate END AS F_ExRate,
'' AS F_CheckNo, NULL AS F_PaidDate, TSH.F_PostDate As F_InvoiceDate, TSH.F_MDesc AS F_Description,
TSH.F_MDesc AS F_InvNo, 0 As F_HasInvoice, 0 AS F_Void, 0 AS F_OriVoid, TSH.F_MDesc As F_BillingCode,

(CASE WHEN T2.F_GLType = 'I' THEN T1.F_Credit - T1.F_Debit ELSE 0 END) As MAR, 0 As MARPaid,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur THEN T1.F_FCredit ELSE 0 END) As MAR_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur THEN T1.F_Credit ELSE 0 END) As MAR_LOC,
(CASE WHEN T2.F_GLType = 'C' THEN T1.F_Debit - T1.F_Credit ELSE 0 END) As MAP,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) <> TSET.LCur THEN T1.F_FDebit ELSE 0 END) As MAP_USD,
(CASE WHEN (CASE WHEN T1.F_Currency <> '' THEN T1.F_Currency ELSE TSET.LCur END) = TSET.LCur THEN T1.F_Debit ELSE 0 END) As MAP_LOC,
0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MDebit_LOC, 0 As MCredit_USD, 0 As MCredit_LOC, 0 AS F_DutyAmount, 0 AS F_IsDuty, '' AS F_IsPaid
FROM V_SLIPX T1

INNER JOIN SettingValues TSET ON 1=1
LEFT JOIN T_CODEGLNO T2 ON T2.F_GLNo = T1.F_GLNo
LEFT JOIN T_SLIPDETAIL TS ON T1.F_STBName = 'T_SLIPDETAIL' AND T1.F_STBID = TS.F_ID
LEFT JOIN T_SLIPHD TSH ON T1.F_TBID = TSH.F_ID
LEFT JOIN T_Department TDEP ON T2.F_GLGroup = TDEP.GLGroup
LEFT JOIN T_ViewOrder TVO ON T2.F_GLGroup = TVO.GLGroup
Where
T2.F_GLType IN ('I', 'C')
AND T1.F_TBTYPE < 100 AND T1.F_Type <> 'X'
AND T1.F_TBName = 'T_SLIPHD' 

--Duty
UNION ALL
SELECT
CASE
WHEN T2.F_AO = 1 THEN 'Air Export'
WHEN T2.F_AI = 1 THEN 'Air Import'
WHEN T2.F_OO = 1 THEN 'Ocean Export'
WHEN T2.F_OI = 1 THEN 'Ocean Import'
WHEN T2.F_WH = 1 THEN 'Warehousing'
WHEN T2.F_OT = 1 THEN 'Other Shipment'
Else 'Non-Operation'
END As F_Department,

CASE
WHEN T2.F_AO = 1 THEN 4
WHEN T2.F_AI = 1 THEN 3
WHEN T2.F_OO = 1 THEN 2
WHEN T2.F_OI = 1 THEN 1
WHEN T2.F_WH = 1 THEN 6
WHEN T2.F_OT = 1 THEN 5
ELSE 7
END As F_ViewOrder,

TBL.F_MTBName, TBL.F_MBLID AS F_MTBId, TBL.F_TBName, TBL.F_TBID,
CASE WHEN TAP.F_ID IS NOT NULL THEN 'T_APHD' WHEN TINV.F_ID IS NOT NULL THEN 'T_INVOHD' ELSE 'T_CRDBHD' END AS F_HDActName,
COALESCE(TAP.F_APHDID, TINV.F_INVOHDID, TCRDB.F_CRDBHDID) AS F_HDActId,
CASE WHEN TAP.F_ID IS NOT NULL THEN 'T_APDETAIL' WHEN TINV.F_ID IS NOT NULL THEN 'T_INVODETAIL' ELSE 'T_CRDBDETAIL' END AS F_ActName,
COALESCE(TAP.F_ID, TINV.F_ID, TCRDB.F_ID) AS F_ActId,
'C' AS F_ComType, --T1.F_Entity AS F_ComId,
CASE WHEN TAP.F_ID IS NOT NULL THEN TAPH.F_PAYTO
WHEN TINV.F_ID IS NOT NULL THEN TINVH.F_BILLTO
WHEN TCRDB.F_ID IS NOT NULL THEN TCRDBH.F_AGENT
ELSE T1.F_Entity END AS F_ComId,
CASE WHEN TAP.F_ID IS NOT NULL THEN T1.F_iDate WHEN TINV.F_ID IS NOT NULL THEN T1.F_iDate ELSE T1.F_cDate END AS F_PostDate, '000000' AS F_GlNo,
CASE WHEN T1.F_Cur1 <> '' THEN T1.F_Cur1 ELSE TSET.LCur END AS F_Currency, CASE WHEN T1.F_ActExrate = 0 THEN 1 ELSE T1.F_ActExrate END AS F_ExRate,
COALESCE(TAPH.F_CheckNo, TINVH.F_CheckNo, TCRDBH.F_CheckNo) AS F_CheckNo,  COALESCE(TAPH.F_PaidDate, TINVH.F_PaidDate, TCRDBH.F_PaidDate) AS F_PaidDate,
COALESCE(TAPH.F_InvoiceDate, TINVH.F_InvoiceDate, TCRDBH.F_InvoiceDate) AS F_InvoiceDate, T1.F_Description,
COALESCE(TAPH.F_InvoiceNo, TINVH.F_InvoiceNo, TCRDBH.F_CrDbNo) AS F_InvNo,
CASE WHEN TINV.F_ID IS NOT NULL THEN 1 ELSE 0 END As F_HasInvoice, 0 AS F_Void, 0 AS  F_OriVoid, T1.F_BillingCode,
(CASE WHEN TINV.F_ID IS NOT NULL THEN T1.F_ActualAmt ELSE 0 END) As MAR,
(CASE WHEN TINV.F_ID IS NOT NULL THEN ISNULL((TINVH.F_InvoiceAmt - TINVH.F_PaidAmt) * (CASE WHEN TINVH.F_InvoiceAmt > 0 THEN 1 ELSE -1 END),0) ELSE 0 END) As MARPaid,
0 As MAR_USD, 0 As MAR_LOC, 0 As MAP, 0 As MAP_USD, 0 As MAP_LOC,
0 As MDebit, 0 As MCredit, 0 As MDebit_USD, 0 As MDebit_LOC, 0 As MCredit_USD, 0 As MCredit_LOC,
(CASE WHEN T1.F_ChgType <= 10 THEN T1.F_ActualAmt ELSE -T1.F_ActualAmt END) AS F_DutyAmount, (CASE WHEN SUBSTRING(T1.F_BillingCode, 1, 3) In ('GST','HST','PST','IVA') THEN 2 ELSE 1 END) AS F_IsDuty,

(CASE WHEN (TAP.F_ID IS NOT NULL AND ROUND(TAPH.F_InvoiceAmt - TAPH.F_PaidAmt,2) = 0 AND ROUND(TAPH.F_PaidAmt,2) <> 0) OR
(TINV.F_ID IS NOT NULL AND ROUND(TINVH.F_InvoiceAmt - TINVH.F_PaidAmt,2) = 0 AND ROUND(TINVH.F_PaidAmt,2) <> 0) OR
(TCRDB.F_ID IS NOT NULL AND ROUND(TCRDBH.F_Total - TCRDBH.F_PaidAmt,2) = 0 AND ROUND(TCRDBH.F_PaidAmt,2) <> 0) THEN 'F'
WHEN (TAP.F_ID IS NOT NULL AND ROUND(TAPH.F_PaidAmt,2) <> 0) OR
(TINV.F_ID IS NOT NULL AND ROUND(TINVH.F_PaidAmt,2) <> 0) OR
(TCRDB.F_ID IS NOT NULL AND ROUND(TCRDBH.F_PaidAmt,2) <> 0) THEN 'P'
ELSE '' END) AS F_IsPaid
FROM T_OPACCT T1

INNER JOIN SettingValues TSET ON 1=1
LEFT JOIN T_NCODECHARGE T2 On T1.F_BillingCode = T2.F_Code
LEFT JOIN T_APDETAIL TAP ON TAP.F_STBNAME = 'T_OPACCT' AND TAP.F_STBID = T1.F_ID           --AND T1.F_ChgType IN (18, 20)
LEFT JOIN T_APHD TAPH ON TAP.F_APHDID = TAPH.F_ID
LEFT JOIN T_INVODETAIL TINV ON TINV.F_STBNAME = 'T_OPACCT' AND TINV.F_STBID = T1.F_ID      --AND T1.F_ChgType IN (10)
LEFT JOIN T_INVOHD TINVH ON TINV.F_INVOHDID = TINVH.F_ID
LEFT JOIN T_CRDBDETAIL TCRDB ON TCRDB.F_STBNAME = 'T_OPACCT' AND TCRDB.F_STBID = T1.F_ID   --AND T1.F_ChgType IN (8, 40)
LEFT JOIN T_CRDBHD TCRDBH ON TCRDB.F_CRDBHDID = TCRDBH.F_ID
INNER JOIN V_BLSUMM TBL ON TBL.F_TBNAME = T1.F_TBNAME AND TBL.F_TBID = T1.F_TBID
WHERE (T1.F_ChgType IN (8, 10, 18, 20, 40) Or SUBSTRING(T1.F_BillingCode, 1, 3) In ('GST','HST','PST','IVA'))
AND COALESCE(TAP.F_ID, TINV.F_ID, TCRDB.F_ID) IS NOT NULL
AND TBL.F_ConfirmDate IS NOT NULL
AND COALESCE(TAPH.F_Void, TINVH.F_Void, TCRDBH.F_Void, 0) = 0
"},
            //STOTAL = 0
            //ReDim Dbary(2, STOTAL)
            { "V_PayrollDetail" ,
                @" 
SELECT
T1.*,T2.*,
--CASE WHEN F_Type IN ('PN', 'Q1', 'Q2') THEN dbo.uf_Slip_GetFixedGLNo('F_PayGL','') ELSE T3.F_ACD4PRtaxPayable END AS F_GLNO
CASE WHEN F_Type IN ('PF', 'PS') THEN T4.F_TaxPayableGLNo ELSE dbo.uf_Slip_GetFixedGLNo('F_PayGL','') END AS F_GLNO
FROM (
SELECT
F_ID, F_BRANCH, F_REFNO, F_REMARK, F_JOURNALID, F_PAYROLLDATE, F_CONFIRMED, 'PN' As F_Type,
F_ENTITY AS F_ENTITY, F_PAYABLENETSALARY AS F_AMOUNT, F_PAIDAMTNETSALARY AS F_PAIDAMT, F_PAIDDATENETSALARY AS F_PAIDDATE, F_CHECKNONETSALARY As F_CheckNo, F_Void
FROM T_PAYROLL
UNION ALL SELECT
F_ID, F_BRANCH, F_REFNO, F_REMARK, F_JOURNALID, F_PAYROLLDATE, F_CONFIRMED, 'PF' As F_Type,
F_FEDERALENTITY AS F_ENTITY, F_PAYABLEFEDTAX AS F_AMOUNT, F_PAIDAMTFEDTAX AS F_PAIDAMT, F_PaidDateFedTax AS F_PAIDDATE, F_CheckNoFedTax As F_CheckNo, F_Void
FROM T_PAYROLL

UNION ALL SELECT
F_ID, F_BRANCH, F_REFNO, F_REMARK, F_JOURNALID, F_PAYROLLDATE, F_CONFIRMED, 'PS' As F_Type,
F_STATEENTITY AS F_ENTITY, F_PAYABLESTATETAX AS F_AMOUNT, F_PAIDAMTSTATETAX AS F_PAIDAMT, F_PaidDateStateTax AS F_PAIDDATE, F_CheckNoStateTax As F_CheckNo, F_Void
FROM T_PAYROLL
UNION ALL SELECT
F_ID, F_BRANCH, F_REFNO, F_REMARK, F_JOURNALID, F_PAYROLLDATE, F_CONFIRMED, 'P1' As F_Type,
F_Add1Entity AS F_ENTITY, F_PayableOption1 AS F_AMOUNT, F_PaidAmtOption1 AS F_PAIDAMT, F_PaidDateOption1 AS F_PAIDDATE, F_CheckNoOption1 As F_CheckNo, F_Void
FROM T_PAYROLL
UNION ALL SELECT
F_ID, F_BRANCH, F_REFNO, F_REMARK, F_JOURNALID, F_PAYROLLDATE, F_CONFIRMED, 'P2' As F_Type,
F_Add2Entity AS F_ENTITY, F_PayableOption2 AS F_AMOUNT, F_PaidAmtOption2 AS F_PAIDAMT, F_PaidDateOption2 AS F_PAIDDATE, F_CheckNoOption2 As F_CheckNo, F_Void
FROM T_PAYROLL 

UNION ALL SELECT
F_ID, F_BRANCH, F_REFNO, F_REMARK, F_JOURNALID, F_PAYROLLDATE, F_CONFIRMED, 'P3' As F_Type,
F_Add3Entity AS F_ENTITY, F_PayableOption3 AS F_AMOUNT, F_PaidAmtOption3 AS F_PAIDAMT, F_PaidDateOption3 AS F_PAIDDATE, F_CheckNoOption3 As F_CheckNo, F_Void
FROM T_PAYROLL
UNION ALL SELECT
F_ID, F_BRANCH, F_REFNO, F_REMARK, F_JOURNALID, F_PAYROLLDATE, F_CONFIRMED, 'P4' As F_Type,
F_Add4Entity AS F_ENTITY, F_PayableOption4 AS F_AMOUNT, F_PaidAmtOption4 AS F_PAIDAMT, F_PaidDateOption4 AS F_PAIDDATE, F_CheckNoOption4 As F_CheckNo, F_Void
FROM T_PAYROLL
UNION ALL SELECT
T1.F_ID, F_BRANCH, F_REFNO, F_REMARK, F_JOURNALID, F_PAYROLLDATE, F_CONFIRMED, 'Q1' As F_Type,
F_Payable1Entity AS F_ENTITY, F_PayableAmount1 AS F_AMOUNT, F_PaidAmtPayable1 AS F_PAIDAMT, F_PaidDatePayable1 AS F_PAIDDATE, F_CheckNoPayable1 As F_CheckNo, F_Void
FROM T_PAYROLL T1
UNION ALL SELECT
T1.F_ID, F_BRANCH, F_REFNO, F_REMARK, F_JOURNALID, F_PAYROLLDATE, F_CONFIRMED, 'Q2' As F_Type,
F_Payable2Entity AS F_ENTITY, F_PayableAmount2 AS F_AMOUNT, F_PaidAmtPayable2 AS F_PAIDAMT, F_PaidDatePayable2 AS F_PAIDDATE, F_CheckNoPayable2 As F_CheckNo, F_Void
FROM T_PAYROLL T1

) T1
LEFT JOIN (SELECT Top 1 F_Currency From T_CodeData) T2 on 1 = 1
LEFT JOIN (SELECT Top 1 F_ACD4PRtaxPayable From T_PAYROLLSETUP) T3 on 1 = 1
LEFT JOIN T_PAYROLL T4 On (T4.F_ID = T1.F_ID)
"}
};

        public static Dictionary<string, string> DicSPInfo = new Dictionary<string, string>
        {
            { "up_AC_BSUnion",
                @"
create  procedure   [dbo].[up_AC_BSUnion] 
            @F_StrDate          DateTime, 
            @F_EndDate          DateTime, 
            @F_PreDate          DateTime, 
            @F_Branch           varchar(3) 
as 

IF LEN(@F_Branch) > 0 
    BEGIN 
        select F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo, F_Level, 
        Sum(Amount) as Amount, Sum(Amount1) as Amount1 
        From 
        ( 
            select F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo, F_Level, F_Branch, 
            sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
           Amount else 0 end) as Amount, 
            sum(case when F_PostDate < @F_StrDate and F_PostDate >= @F_PreDate then 
            Amount  else 0 end) as Amount1 
            From V_AC_BS 
            group by F_GLType, F_GLGroup, F_GLSubGroup, F_GLNo,F_GLDescription,  F_Level, F_Branch 
         ) XX 
        Where XX.F_Branch = @F_Branch and (Amount <> 0 or Amount1 <> 0) 
        Group By F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo, F_Level 
        HAVING SUM(AMOUNT) <> 0 OR SUM(AMOUNT1) <> 0 
        order by F_GLType, F_GLGroup,F_GLSubGroup
    End 
ELSE 
    BEGIN 
        select F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo, F_Level, 
        sum(Amount) as Amount, sum(Amount1) as Amount1 
        From 
        ( 
            select F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo, F_Level, 
            sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
            Amount else 0 end) as Amount, 
            sum(case when F_PostDate < @F_StrDate and F_PostDate >= @F_PreDate then 
            Amount  else 0 end) as Amount1 
            From V_AC_BS 
            group by F_GLType, F_GLGroup, F_GLSubGroup, F_GLNo, F_GLDescription, F_Level 
        ) XX 
        Where (Amount <> 0 Or Amount1 <> 0) 
        Group by F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo, F_Level 
        HAVING SUM(AMOUNT) <> 0 OR SUM(AMOUNT1) <> 0 
        order by F_GLType, F_GLGroup, F_GLSubGroup
    END 
" },
            { "up_AC_BSUnionB",
                @"
create  procedure   [dbo].[up_AC_BSUnionB] 
            @F_StrDate          DateTime, 
            @F_EndDate          DateTime, 
            @F_PreDate          DateTime 
as 

    BEGIN 
        select F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo ,F_BRANCH , F_Level, 
        Sum(Amount) as Amount , Sum(Amount1) as Amount1 
        From 
        ( 
            select F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo, F_Level,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS  F_Branch, 
            sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
           Amount else 0 end) as Amount, 
            sum(case when F_PostDate < @F_StrDate and F_PostDate >= @F_PreDate then 
            Amount  else 0 end) as Amount1 
            From V_AC_BS 
            group by F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo, F_Level, F_Branch 
         ) XX 
        Where  (Amount <> 0 or Amount1 <> 0) 
        Group By F_GLType, F_GLGroup, F_GLSubGroup, F_GLDescription, F_GLNo,F_BRANCH, F_Level
        order by F_GLType, F_GLGroup, F_GLNo, F_GLDescription 
    End 
"},
            { "up_AC_BSUnionS",
                @"
create  procedure   [dbo].[up_AC_BSUnionS] 
            @F_StrDate          DateTime, 
            @F_EndDate          DateTime, 
            @F_PreDate          DateTime 
as 

    BEGIN 
        select F_GLType, F_GLGroup, F_GLSubGroup,F_GLSubGroup as F_GLDescription, F_Level, 
        Sum(Amount) as Amount , Sum(Amount1) as Amount1 
        From 
        ( 
            select F_GLType, F_GLGroup, F_GLSubGroup,F_Level,  
            sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
           Amount else 0 end) as Amount, 
            sum(case when F_PostDate < @F_StrDate and F_PostDate >= @F_PreDate then 
            Amount  else 0 end) as Amount1 
            From V_AC_BS 
            group by F_GLType, F_GLGroup, F_GLSubGroup, F_Level 
         ) XX 
        Where  (Amount <> 0 or Amount1 <> 0) 
        Group By F_GLType, F_GLGroup, F_GLSubGroup ,F_Level
        order by F_GLType, F_GLGroup, F_GLSubGroup ,F_Level 
    End 
"},
            { "up_AC_GLAgingUnionB",
                @"
  CREATE PROCEDURE [dbo].[up_AC_GLAgingUnionB]    
    @PARA_AsToDate nvarchar(20),                
    @PARA_GLNo nvarchar(10),                    
    @PARA_SubCode nvarchar(20)                  
 AS 
    ----------------------------------------------- 
    Declare @S_WHERE nvarchar(300) 
    set @S_WHERE='' 
    set @S_WHERE = @S_WHERE + ' AND (Datediff(Day,F_PostDate, ''' + @PARA_AsToDate + ''') >=0)'                             -- As to Date      - M 
    set @S_WHERE = @S_WHERE + ' AND V.F_GLNo = ''' + @PARA_GLNo + ''''                                      -- GLNo            - M 
    If Len(@PARA_SubCode)>0 set @S_WHERE = @S_WHERE + ' AND F_SubCode=''' + @PARA_SubCode + ''''            -- SubCode    - O 
    ----------------------------------------------- 

EXEC(  
    'SELECT F_PostDate, F_Type, F_ComID, F_ComType, F_ComName, F_GLName,F_BRANCH, 
        (CASE WHEN F_GLType IN (''L'',''Q'',''I'',''OI'') THEN sum(F_Credit) - sum(F_Debit)  
                ELSE sum(F_Debit) - sum(F_Credit) END) as F_Balance 
    From 
    ( 
        Select  F_PostDate, F_Type, F_Branch,F_ComType, F_ComID, F_ComName, F_SubCode, 
                F_GLType, F_GLName, F_GLNo, F_Debit, F_Credit 
        From V_AC_GLAging 
    ) As V  
    WHERE V.F_Type<>''X'' ' + @S_WHERE + ' AND Datediff(Day,F_PostDate, 
            convert(datetime,(SELECT (case when F_C3=''000000'' then ''20000101'' else F_C3 + ''01'' end)  FROM T_AOtherinfo WHERE F_TBName = ''T_CODEDATA'' And F_TBID = 1 And F_TYPE = 27))) <=0  
    GROUP BY F_ComID, F_ComName, F_ComType, F_PostDate, F_Type, F_GLType, F_GLName,F_BRANCH 
    ORDER BY V.F_ComName ' 
)  
"},
            { "up_AC_GLUnionB",
                @"
CREATE PROCEDURE [dbo].[up_AC_GLUnionB]     
    @PARA_DateFrom nvarchar(20),            
    @PARA_DateTo nvarchar(20),              
    @PARA_GLNoFrom nvarchar(10),            
    @PARA_GLNoTo nvarchar(10),              
    @PARA_SubCode nvarchar(20)              
 AS 
    -----------------------------------------------  
    Declare @S_WHERE nvarchar(300)  
    set @S_WHERE=''  
    set @S_WHERE = @S_WHERE + 'AND (DATEDIFF(Day,F_PostDate,''' + @PARA_DateFrom + ''') <=0 AND Datediff(Day,F_Postdate,''' + @PARA_DateTo + ''') >=0)'    -- Period      - O  
    If Len(@PARA_GLNoFrom) > 0 AND Len(@PARA_GLNoTo) > 0                                                                -- GL No Range - O  
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''' And V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
    Else If Len(@PARA_GLNoFrom) > 0 
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + '''' 
    Else If Len(@PARA_GLNoTo) > 0 
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
    If Len(@PARA_SubCode)>0 set @S_WHERE = @S_WHERE + ' AND F_SubCode=''' + @PARA_SubCode + ''''                    -- SubCode    - O 
    -----------------------------------------------  

 EXEC 
 (  
    'SELECT F_GLNo, F_GLFull, F_SubCode, F_ComName, F_PostDate, F_SeqNo,  
            F_MDesc , F_Debit, F_Credit, F_ComType, F_BRANCH 
     FROM V_AC_GL V 
     WHERE V.F_Type <> ''X'' ' + @S_WHERE + ' 
     ORDER BY F_PostDate, F_BRANCH, F_SeqNo ' 
 )  
"},
            { "up_AC_ISUnion",
                @"
create  procedure   [dbo].[up_AC_ISUnion] 
            @sType              int,    -- 1 : standard, 2:previous year, 3:ytd, 4:yearly comparison 
            @F_StrDate          DateTime, 
            @F_EndDate          DateTime, 
            @F_PreStrDate       DateTime, 
            @F_PreEndDate       DateTime, 
            @F_Branch           varchar(3) 
as 
    DECLARE @F_GLType as varchar(20) 

IF LEN(@F_Branch) > 0 
    BEGIN 
        select @F_GLType = F_GLType 
       From 
        ( 
            select 
            F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Branch, 
            sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
            Amount else 0 end) as Amount, 
            F_Sort , F_Level 
            From V_AC_IS 
            Where Datediff(Day,F_PostDate, @F_StrDate) <=0 and Datediff(Day,F_PostDate,@F_EndDate) >=0 
            Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Branch, F_Sort, F_Level 
        ) XX 
        Where XX.F_Branch = @F_Branch 
        order by F_Sort, F_GLGroup, F_GLDescription 
    End 
ELSE 
BEGIN 
select 
@F_GLType = F_GLType 
From 
( 
    select 
    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, 
    sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
    Amount else 0 end) as Amount, 
    F_Sort , F_Level 
    From V_AC_IS 
    Where Datediff(Day,F_PostDate, @F_StrDate) <=0 and Datediff(Day,F_PostDate,@F_EndDate) >=0 
    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Branch, F_Sort, F_Level 
) XX 
Where (Amount <> 0) 
END 

IF @@rowcount > 0 
BEGIN 
    IF LEN(@F_Branch) > 0 
        BEGIN 
            IF @sType = 1 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNo, Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Branch, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Branch, F_Sort, F_Level 
                ) XX 
                Where XX.F_Branch = @F_Branch And (Amount <> 0) 
                Group By F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Sort, F_Level 
                UNION ALL 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '29998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '39998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '59998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '69998' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription 
            END 

            ELSE IF @sType = 2 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNo, Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Branch, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Branch, F_Sort, F_Level 
                ) XX 
                Where XX.F_Branch = @F_Branch And (Amount <> 0 or Amount1 <> 0) 
                Group By F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Sort, F_Level 
                UNION ALL 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '29998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '39998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '59998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '69998' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription 
            END 
            ELSE IF @sType = 3 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNo, Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Branch, 
                    sum(case when F_PostDate <= @F_PreEndDate and F_PostDate >= @F_PreStrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Branch, F_Sort, F_Level 
                ) XX 
                Where XX.F_Branch = @F_Branch And (Amount <> 0 or Amount1 <> 0) 
                Group By F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Sort, F_Level 
                UNION ALL 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '29998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '39998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '59998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '69998' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription 
            END 
            ELSE 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNo, 
                sum(case when F_Month = 1 then round(Amount, 3) else 0 end) as F_A1, 
                sum(case when F_Month = 2 then round(Amount, 3) else 0 end) as F_A2, 
                sum(case when F_Month = 3 then round(Amount, 3) else 0 end) as F_A3, 
                sum(case when F_Month = 4 then round(Amount, 3) else 0 end) as F_A4, 
                sum(case when F_Month = 5 then round(Amount, 3) else 0 end) as F_A5, 
                sum(case when F_Month = 6 then round(Amount, 3) else 0 end) as F_A6, 
                sum(case when F_Month = 7 then round(Amount, 3) else 0 end) as F_A7, 
                sum(case when F_Month = 8 then round(Amount, 3) else 0 end) as F_A8, 
                sum(case when F_Month = 9 then round(Amount, 3) else 0 end) as F_A9, 
                sum(case when F_Month = 10 then round(Amount, 3) else 0 end) as F_A10, 
                sum(case when F_Month = 11 then round(Amount, 3) else 0 end) as F_A11, 
                sum(case when F_Month = 12 then round(Amount, 3) else 0 end) as F_A12, 
                F_Sort , F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Branch, 
                    Month(F_PostDate) as F_Month, sum(Amount) as Amount, 
                    F_Sort , F_Level 
                    From V_AC_ISMonth 
                    Where F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_PostDate, F_Branch, F_Sort, F_Level 
                ) XX 
                Where XX.F_Branch = @F_Branch and Amount <> 0 
                Group by F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Sort, F_Level 
                Union All 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 
                0 as F_A1, 0 as F_A2, 0 as F_A3, 0 as F_A4, 0 as F_A5, 0 as F_A6, 0 as F_A7, 0 as F_A8, 0 as F_A9, 
                0 as F_A10, 0 as F_A11, 0 as F_A12, 
                '29999' as F_Sort, 'SUM' as F_Level 
				           Union All 
                select 'OPERATING INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 
                0 as F_A1, 0 as F_A2, 0 as F_A3, 0 as F_A4, 0 as F_A5, 0 as F_A6, 0 as F_A7, 0 as F_A8, 0 as F_A9, 
                0 as F_A10, 0 as F_A11, 0 as F_A12, 
                '39999' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 
                0 as F_A1, 0 as F_A2, 0 as F_A3, 0 as F_A4, 0 as F_A5, 0 as F_A6, 0 as F_A7, 0 as F_A8, 0 as F_A9, 
                0 as F_A10, 0 as F_A11, 0 as F_A12, 
                '59999' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 
                0 as F_A1, 0 as F_A2, 0 as F_A3, 0 as F_A4, 0 as F_A5, 0 as F_A6, 0 as F_A7, 0 as F_A8, 0 as F_A9, 
                0 as F_A10, 0 as F_A11, 0 as F_A12, 
                '69999' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup 
            End 
        END 
ELSE 
        BEGIN 
            IF @sType = 1 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNO, 
                sum(Amount) as Amount, sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, 
                    sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate <= @F_PreEndDate and F_PostDate >= @F_PreStrDate then 
                    Amount else 0 end) as Amount1, F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Branch, F_Sort, F_Level 
                ) XX 
                Where (Amount <> 0) 
                Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Sort, F_Level 
                Union All 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '29998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '39998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '59998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '69998' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription 
            END 
            ELSE IF @sType = 2 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNO, 
                sum(Amount) as Amount, sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, 
                    sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate <= @F_PreEndDate and F_PostDate >= @F_PreStrDate then 
                    Amount else 0 end) as Amount1, F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Branch, F_Sort, F_Level 
                ) XX 
                Where (Amount <> 0 or Amount1 <> 0) 
                Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Sort, F_Level 
                Union All 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '29998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '39998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '59998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '69998' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription 
            END 
            ELSE IF @sType = 3 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNO, 
                sum(Amount) as Amount, sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, 
                    sum(case when F_PostDate <= @F_PreEndDate and F_PostDate >= @F_PreStrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Branch, F_Sort, F_Level 
                ) XX 
                Where (Amount <> 0 or Amount1 <> 0) 
                Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_Sort, F_Level 
                Union All 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '29998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '39998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '59998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 0 as Amount, 
                0 as Amount1, 
                '69998' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription 
            END 
            ELSE 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNo, 
                sum(case when F_Month = 1 then round(Amount, 3) else 0 end) as F_A1, 
                sum(case when F_Month = 2 then round(Amount, 3) else 0 end) as F_A2, 
                sum(case when F_Month = 3 then round(Amount, 3) else 0 end) as F_A3, 
                sum(case when F_Month = 4 then round(Amount, 3) else 0 end) as F_A4, 
                sum(case when F_Month = 5 then round(Amount, 3) else 0 end) as F_A5, 
                sum(case when F_Month = 6 then round(Amount, 3) else 0 end) as F_A6, 
                sum(case when F_Month = 7 then round(Amount, 3) else 0 end) as F_A7, 
                sum(case when F_Month = 8 then round(Amount, 3) else 0 end) as F_A8, 
                sum(case when F_Month = 9 then round(Amount, 3) else 0 end) as F_A9, 
                sum(case when F_Month = 10 then round(Amount, 3) else 0 end) as F_A10, 
                sum(case when F_Month = 11 then round(Amount, 3) else 0 end) as F_A11, 
                sum(case when F_Month = 12 then round(Amount, 3) else 0 end) as F_A12, 
                F_Sort , F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, 
                    Month(F_PostDate) as F_Month, sum(Amount) as Amount, 
                    F_Sort , F_Level 
                    From V_AC_ISMonth 
                    Where Datediff(Day,F_PostDate, @F_StrDate) <=0 and Datediff(Day,F_PostDate,@F_EndDate) >=0 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_PostDate, F_Sort, F_Level 
                ) XX 
                Where Amount <> 0 
                Group by F_GLType, F_GLGroup, F_GLDescription, F_GLNo, F_Sort, F_Level 
                UNION ALL 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 
                0 as F_A1, 0 as F_A2, 0 as F_A3, 0 as F_A4, 0 as F_A5, 0 as F_A6, 0 as F_A7, 0 as F_A8, 0 as F_A9, 
                0 as F_A10, 0 as F_A11, 0 as F_A12, 
                '29999' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 
                0 as F_A1, 0 as F_A2, 0 as F_A3, 0 as F_A4, 0 as F_A5, 0 as F_A6, 0 as F_A7, 0 as F_A8, 0 as F_A9, 
                0 as F_A10, 0 as F_A11, 0 as F_A12, 
                '39999' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 
                0 as F_A1, 0 as F_A2, 0 as F_A3, 0 as F_A4, 0 as F_A5, 0 as F_A6, 0 as F_A7, 0 as F_A8, 0 as F_A9, 
                0 as F_A10, 0 as F_A11, 0 as F_A12, 
                '59999' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, '' as F_GLNo, 
                0 as F_A1, 0 as F_A2, 0 as F_A3, 0 as F_A4, 0 as F_A5, 0 as F_A6, 0 as F_A7, 0 as F_A8, 0 as F_A9, 
                0 as F_A10, 0 as F_A11, 0 as F_A12, 
                '69999' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup 
            END 
        END 
End 
Else 
BEGIN 
    Select * from t_sliphd where f_id = -1 
END 
" },
            { "up_AC_ISUnionB",
                @"
create  procedure   [dbo].[up_AC_ISUnionB] 
            @sType              int,    -- 1 : standard, 2:Previous Year, 3:ytd, 4:yearly comparison 
            @F_StrDate          DateTime, 
            @F_EndDate          DateTime, 
            @F_PreStrDate       DateTime, 
            @F_PreEndDate       DateTime 
as 
    DECLARE @F_GLType as varchar(20) 

    BEGIN 
        select @F_GLType = F_GLType 
       From 
        ( 
            select 
            F_GLType, F_GLGroup, F_GLDescription, F_GLNo, CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END F_Branch, 
            sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
            Amount else 0 end) as Amount, 
            F_Sort , F_Level 
            From V_AC_IS 
            Where DATEDIFF(Day,F_PostDate , @F_StrDate) <=0 and DATEDIFF(Day,F_PostDate ,@F_EndDate) >=0
            Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END, F_Sort, F_Level 
        ) XX 
        order by F_Sort, F_GLGroup,F_BRANCH , F_GLDescription
    End 

IF @@rowcount > 0 
BEGIN 
        BEGIN 
            IF @sType = 1 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNo,F_BRANCH, Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo, CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS F_BRANCH, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, F_SORT, F_Level 
                    From dbo.V_AC_IS 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END, F_Sort, F_Level 
                    UNION ALL 
                    select 
                    F_GLType, F_GLGroup,'' as F_GLDescription,'' AS F_GLNo, '' as F_BRANCH, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, substring(F_Sort,1,4) + '91' as F_Sort, 'BRANCH' AS F_LEVEL 
                    From V_AC_IS where F_LEVEL='GroupTotal' 
                    Group by F_GLType, F_GLGroup,  substring(F_Sort,1,4) 
                    UNION ALL 
                    select 
                    F_GLType, '' AS F_GLGroup,CASE WHEN F_LEVEL='GroupTotal' THEN 'Branch Total' ELSE 'TOTAL' end  as F_GLDescription,'' AS F_GLNo, CASE WHEN F_LEVEL='GroupTotal' THEN F_Branch ELSE '' END F_BRANCH, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, substring(F_Sort,1,3) +  CASE WHEN F_LEVEL='GroupTotal' THEN '98' ELSE '99' END as F_Sort, 'TYPE' AS F_LEVEL 
                    From V_AC_IS 
                    Group by F_GLType, CASE WHEN F_LEVEL='GroupTotal' THEN F_Branch ELSE '' END, substring(F_Sort,1,3), F_Level 
                ) XX 
                Where  (Amount <> 0) 
                Group By F_GLType, F_GLGroup, F_GLDescription, F_GLNo,F_BRANCH, F_Sort , F_Level 
                order by F_Sort, F_GLGroup,F_BRANCH,F_GLDescription
            END 

            ELSE IF @sType = 2 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription,F_GLNo,  F_BRANCH , Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS F_Branch, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END, F_Sort, F_Level 
                    UNION ALL 
                    select 
                    F_GLType, F_GLGroup,''  as F_GLDescription,'' AS F_GLNo, '' as  F_BRANCH, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, substring(F_Sort,1,4) +  '91'  as F_Sort, 'BRANCH' AS F_LEVEL 
                    From V_AC_IS where F_LEVEL='GroupTotal' 
                    Group by F_GLType, F_GLGroup, substring(F_Sort,1,4) 
                    UNION ALL 
                    select 
                    F_GLType, '' AS F_GLGroup,CASE WHEN F_LEVEL='GroupTotal' THEN 'Branch Total' ELSE 'TOTAL' end  as F_GLDescription,'' AS F_GLNo, CASE WHEN F_LEVEL='GroupTotal' THEN F_Branch ELSE '' END F_BRANCH, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, substring(F_Sort,1,3) +  CASE WHEN F_LEVEL='GroupTotal' THEN '98' ELSE '99' END as F_Sort, 'TYPE' AS F_LEVEL
                    From V_AC_IS 
                    Group by F_GLType, CASE WHEN F_LEVEL='GroupTotal' THEN F_Branch ELSE '' END, substring(F_Sort,1,3), F_Level  
                ) XX 
                Where  (Amount <> 0 or Amount1 <> 0) 
                Group By F_GLType, F_GLGroup, F_GLDescription, F_GLNo,F_BRANCH, F_Sort, F_Level 
                order by F_Sort, F_GLGroup,F_BRANCH , F_GLDescription 
            END 
            ELSE IF @sType = 3 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNo,F_BRANCH, Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS F_Branch, 
                    sum(case when F_PostDate <= @F_PreEndDate and F_PostDate >= @F_PreStrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END, F_Sort, F_Level 
                ) XX 
                Where  (Amount <> 0 or Amount1 <> 0) 
                Group By F_GLType, F_GLGroup, F_GLDescription, F_GLNo,F_BRANCH, F_Sort, F_Level 
                order by F_Sort, F_GLGroup,F_BRANCH , F_GLDescription 
            END 
            ELSE 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_GLNo,F_BRANCH, 
                sum(case when F_Month = 1 then round(Amount, 3) else 0 end) as F_A1, 
                sum(case when F_Month = 2 then round(Amount, 3) else 0 end) as F_A2, 
                sum(case when F_Month = 3 then round(Amount, 3) else 0 end) as F_A3, 
                sum(case when F_Month = 4 then round(Amount, 3) else 0 end) as F_A4, 
                sum(case when F_Month = 5 then round(Amount, 3) else 0 end) as F_A5, 
                sum(case when F_Month = 6 then round(Amount, 3) else 0 end) as F_A6, 
                sum(case when F_Month = 7 then round(Amount, 3) else 0 end) as F_A7, 
                sum(case when F_Month = 8 then round(Amount, 3) else 0 end) as F_A8, 
                sum(case when F_Month = 9 then round(Amount, 3) else 0 end) as F_A9, 
                sum(case when F_Month = 10 then round(Amount, 3) else 0 end) as F_A10, 
                sum(case when F_Month = 11 then round(Amount, 3) else 0 end) as F_A11, 
                sum(case when F_Month = 12 then round(Amount, 3) else 0 end) as F_A12, 
                F_Sort , F_Level 
                From 
                ( 
                    select 
                    F_GLType, F_GLGroup, F_GLDescription, F_GLNo,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS F_Branch, 
                    Month(F_PostDate) as F_Month, sum(Amount) as Amount, 
                    F_Sort , F_Level 
                    From V_AC_ISMonth 
                    Where Datediff(Day,F_PostDate ,@F_StrDate ) <=0 and Datediff(Day,F_PostDate,@F_EndDate) >=0 
                    Group by F_GLType, F_GLGroup, F_GLNo, F_GLDescription, F_PostDate, F_Branch, F_Sort, F_Level 
                ) XX 
                Where  Amount <> 0 
                Group by F_GLType, F_GLGroup, F_GLDescription, F_GLNo,F_BRANCH, F_Sort, F_Level 
                order by F_Sort, F_GLGroup 
            End 
       END 
        END 
BEGIN 
    Select * from t_sliphd where f_id = -1 
END 

"},
            { "up_AC_ISUnionBS",
                @"
create  procedure   [dbo].[up_AC_ISUnionBS] 
            @sType              int,    -- 1 : standard, 2:Previous Year, 3:ytd, 4:yearly comparison 
            @F_StrDate          DateTime, 
            @F_EndDate          DateTime, 
            @F_PreStrDate       DateTime, 
            @F_PreEndDate       DateTime 
as 
    DECLARE @F_GLType as varchar(20) 

    BEGIN 
        select @F_GLType = F_GLType 
       From 
        ( 
            select 
            F_GLType,  case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription, CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS F_BRANCH,  
            sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
            Amount else 0 end) as Amount, 
             SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END AS F_SORT , F_Level 
            From V_AC_IS 
            Where Datediff(Day,F_PostDate ,@F_StrDate ) <=0 and Datediff(Day,F_PostDate,@F_EndDate) >=0 
            Group by F_GLType, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END , F_GLSUBGroup, CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END, SUBSTRING(F_Sort,1,3) , F_Level 
        ) XX 
        order by F_Sort, F_GLGroup, F_GLDescription,F_BRANCH 
    End 

IF @@rowcount > 0 
BEGIN 
        BEGIN 
            IF @sType = 1 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription,F_BRANCH, Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType,case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription, CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS F_BRANCH, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1,SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END AS  F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType,case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END , F_GLSUBGroup,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END, SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END , F_Level 
                ) XX 
                Where  (Amount <> 0) 
            Group by F_GLType, F_GLGroup, F_GLDescription,F_BRANCH, F_Sort , F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription,F_BRANCH 
            END 

            ELSE IF @sType = 2 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription,F_BRANCH , Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS F_Branch, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1,SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END AS F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType,case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END , F_GLSUBGroup,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END, SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END , F_Level 
                ) XX 
                Where  (Amount <> 0 or Amount1 <> 0) 
                Group By F_GLType, F_GLGroup, F_GLDescription, F_BRANCH, F_Sort, F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription 
            END 
            ELSE IF @sType = 3 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_BRANCH, Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS F_Branch, 
                    sum(case when F_PostDate <= @F_PreEndDate and F_PostDate >= @F_PreStrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1,SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END AS F_Sort, F_Level 
                    From V_AC_IS 
                    Group by F_GLType,case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END , F_GLSUBGroup,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END, SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END , F_Level 
                ) XX 
                Where  (Amount <> 0 or Amount1 <> 0) 
                Group By F_GLType, F_GLGroup, F_GLDescription, F_BRANCH, F_Sort, F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription,F_BRANCH 
            END 
            ELSE 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, F_BRANCH, 
                sum(case when F_Month = 1 then round(Amount, 3) else 0 end) as F_A1, 
                sum(case when F_Month = 2 then round(Amount, 3) else 0 end) as F_A2, 
                sum(case when F_Month = 3 then round(Amount, 3) else 0 end) as F_A3, 
                sum(case when F_Month = 4 then round(Amount, 3) else 0 end) as F_A4, 
                sum(case when F_Month = 5 then round(Amount, 3) else 0 end) as F_A5, 
                sum(case when F_Month = 6 then round(Amount, 3) else 0 end) as F_A6, 
                sum(case when F_Month = 7 then round(Amount, 3) else 0 end) as F_A7, 
                sum(case when F_Month = 8 then round(Amount, 3) else 0 end) as F_A8, 
                sum(case when F_Month = 9 then round(Amount, 3) else 0 end) as F_A9, 
                sum(case when F_Month = 10 then round(Amount, 3) else 0 end) as F_A10, 
                sum(case when F_Month = 11 then round(Amount, 3) else 0 end) as F_A11, 
                sum(case when F_Month = 12 then round(Amount, 3) else 0 end) as F_A12, 
                F_Sort , F_Level 
                From 
                ( 
                    select 
                    F_GLType, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription,CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END AS F_Branch, 
                    Month(F_PostDate) as F_Month, sum(Amount) as Amount, 
                    SUBSTRING(F_Sort,1,3) + case F_Level when 'GLTotal' then '00' when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END AS F_Sort , F_Level 
                    From V_AC_ISMonth 
                    Where F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate AND F_LEVEL in ('GLNO','GLTotal') 
                    Group by F_GLType, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END , F_GLSUBGroup, CASE WHEN F_LEVEL='GLNO' THEN F_Branch ELSE '' END, SUBSTRING(F_Sort,1,3) , F_Level,Month(F_PostDate) 
                ) XX 
                Where  Amount <> 0 
                Group by F_GLType, F_GLGroup, F_GLDescription, F_BRANCH, F_Sort, F_Level 
                order by F_Sort, F_GLGroup 
            End 
       END 
        END 
BEGIN 
    Select * from t_sliphd where f_id = -1 
END 
"},
            { "up_AC_ISUnionS",
                @"
create  procedure   [dbo].[up_AC_ISUnionS] 
            @sType              int,    -- 1 : standard, 2:Previous Year, 3:ytd, 4:yearly comparison 
            @F_StrDate          DateTime, 
            @F_EndDate          DateTime, 
            @F_PreStrDate       DateTime, 
            @F_PreEndDate       DateTime 
as 
    DECLARE @F_GLType as varchar(20) 

    BEGIN 
        select @F_GLType = F_GLType 
       From 
        ( 
            select 
            F_GLType, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription, 
            sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_EndDate then 
            Amount else 0 end) as Amount, 
            F_Sort , F_Level 
            From V_AC_IS 
            Where Datediff(Day,F_PostDate ,@F_StrDate ) <=0 and Datediff(Day,F_PostDate,@F_EndDate) >=0 
            Group by F_GLType, F_GLSubGroup, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END,f_sort,  F_Level 
        ) XX 
        order by  F_GLGroup, F_GLDescription 
    End 

IF @@rowcount > 0 
BEGIN 
        BEGIN 
            IF @sType = 1 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription,  Sum(Amount) as Amount, Sum(Amount1) as Amount1,F_SORT,  F_Level 
                From 
                ( 
                    select 
                    F_GLType, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription, 
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END  AS F_SORT, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLSUBGroup,  SUBSTRING(F_Sort,1,3), F_Level,case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END 
                ) XX 
                Where  (Amount <> 0) 
                Group By F_GLType, F_GLGroup, F_GLDescription,F_SORT, F_Level 
                UNION ALL 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, 0 as Amount, 
                0 as Amount1, 
                '29998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME' as F_GLType, '' as F_GLGroup, '' as F_GLDescription,  0 as Amount, 
                0 as Amount1, 
                '39998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription,  0 as Amount, 
                0 as Amount1, 
                '59998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, 0 as Amount, 
                0 as Amount1, 
                '69998' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription
            END 

            ELSE IF @sType = 2 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription,
                    sum(case when F_PostDate <= @F_EndDate and F_PostDate >= @F_StrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_PreStrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END  AS F_SORT, F_Level 
                    From V_AC_IS 
                    Group by  F_GLType, F_GLSUBGroup,  SUBSTRING(F_Sort,1,3), F_Level,case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END  
                ) XX 
                Where  (Amount <> 0 or Amount1 <> 0) 
                 Group By F_GLType, F_GLGroup, F_GLDescription,F_SORT, F_Level 
                UNION ALL 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription,  0 as Amount, 
                0 as Amount1, 
                '29998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME' as F_GLType, '' as F_GLGroup, '' as F_GLDescription,  0 as Amount, 
                0 as Amount1, 
                '39998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, 0 as Amount, 
                0 as Amount1, 
                '59998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, 0 as Amount, 
                0 as Amount1, 
                '69998' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription 
            END 
            ELSE IF @sType = 3 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, Sum(Amount) as Amount, Sum(Amount1) as Amount1, F_Sort, F_Level 
                From 
                ( 
                    select 
                    F_GLType, case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription, 
                    sum(case when F_PostDate <= @F_PreEndDate and F_PostDate >= @F_PreStrDate then 
                    Amount else 0 end) as Amount, 
                    sum(case when F_PostDate >= @F_StrDate and F_PostDate <= @F_PreEndDate then 
                    Amount else 0 end) as Amount1, SUBSTRING(F_Sort,1,3) + case F_Level when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END  AS F_SORT, F_Level 
                    From V_AC_IS 
                    Group by F_GLType, F_GLSUBGroup,  SUBSTRING(F_Sort,1,3), F_Level,case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END   
                ) XX 
                Where  (Amount <> 0 or Amount1 <> 0) 
                 Group By F_GLType, F_GLGroup, F_GLDescription,F_SORT, F_Level 
                UNION ALL 
                select 'GROSS PROFIT' as F_GLType, '' as F_GLGroup, '' as F_GLDescription,  0 as Amount, 
                0 as Amount1, 
                '29998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'OPERATING INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription, 0 as Amount, 
                0 as Amount1, 
                '39998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS BEFORE TAXES' as F_GLType, '' as F_GLGroup, '' as F_GLDescription,  0 as Amount, 
                0 as Amount1, 
                '59998' as F_Sort, 'SUM' as F_Level 
                Union All 
                select 'NET INCOME/LOSS' as F_GLType, '' as F_GLGroup, '' as F_GLDescription,  0 as Amount, 
                0 as Amount1, 
                '69998' as F_Sort, 'SUM' as F_Level 
                order by F_Sort, F_GLGroup, F_GLDescription 
            END 
            ELSE 
            BEGIN 
                select F_GLType, F_GLGroup, F_GLDescription, 
                sum(case when F_Month = 1 then round(Amount, 3) else 0 end) as F_A1, 
                sum(case when F_Month = 2 then round(Amount, 3) else 0 end) as F_A2, 
                sum(case when F_Month = 3 then round(Amount, 3) else 0 end) as F_A3, 
                sum(case when F_Month = 4 then round(Amount, 3) else 0 end) as F_A4, 
                sum(case when F_Month = 5 then round(Amount, 3) else 0 end) as F_A5, 
                sum(case when F_Month = 6 then round(Amount, 3) else 0 end) as F_A6, 
                sum(case when F_Month = 7 then round(Amount, 3) else 0 end) as F_A7, 
                sum(case when F_Month = 8 then round(Amount, 3) else 0 end) as F_A8, 
                sum(case when F_Month = 9 then round(Amount, 3) else 0 end) as F_A9, 
                sum(case when F_Month = 10 then round(Amount, 3) else 0 end) as F_A10, 
                sum(case when F_Month = 11 then round(Amount, 3) else 0 end) as F_A11, 
                sum(case when F_Month = 12 then round(Amount, 3) else 0 end) as F_A12, 
                F_Sort , F_Level 
                From 
                ( 
                    select 
                    F_GLType,case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END AS F_GLGROUP,F_GLSUBGroup AS F_GLDescription, 
                    Month(F_PostDate) as F_Month, sum(Amount) as Amount, 
                    SUBSTRING(F_Sort,1,3) + case F_Level when 'GLTotal' then '00' when 'GroupTotal' THEN  '10' WHEN 'GLNO' THEN '11' END  AS F_Sort , F_Level 
                    From V_AC_ISMonth 
                    Where Datediff(Day,F_PostDate, @F_StrDate) <=0 and Datediff(Day,F_PostDate,@F_EndDate) >=0 AND F_LEVEL in ('GLNO','GLTotal') 
                    Group by F_GLType, F_GLSUBGroup,  SUBSTRING(F_Sort,1,3), F_Level,case when F_GLSUBGroup <>'' THEN F_GLSUBGROUP ELSE F_GLGROUP END,  F_PostDate, F_Level 
                ) XX 
                Where  Amount <> 0 
                Group by F_GLType, F_GLGroup, F_GLDescription, F_Sort, F_Level 
                order by F_Sort, F_GLGroup 
            End 
        END 
        END 
BEGIN 
    Select * from t_sliphd where f_id = -1 
END 
"},
            { "up_AC_NewGLAgingUnion",
                @"
  CREATE PROCEDURE [dbo].[up_AC_NewGLAgingUnion]    
    @PARA_AsToDate nvarchar(20),                
    @PARA_GLNo nvarchar(10),                    
    @PARA_SubCode nvarchar(20),                  
    @PARA_Branch nvarchar(3)                    
 AS 
    ----------------------------------------------- 
    Declare @S_WHERE nvarchar(300) 
    DECLARE @BeginMonth INT 
    DECLARE @FiscalEndMonth INT 
    DECLARE @AcctStartDate VARCHAR(20) 
    SET @FiscalEndMonth =(SELECT F_N2 FROM T_AotherInfo WHERE F_TBNAME = 'T_CODEDATA' AND F_TBID = 1 AND F_TYPE = 27) 
    SET @BeginMonth = (CASE WHEN @FiscalEndMonth = 12 THEN 1 ELSE @FiscalEndMonth + 1 END) 
    SET @AcctStartDate = (SELECT SUBSTRING((case when F_C3='000000' then '20000101' else F_C3 + '01' end), 1, 4) + '-' + convert(varchar,@BeginMonth) + '-01' FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27) 
    set @S_WHERE= '(F_Type <>''X'' OR (F_Type = ''X'' AND F_PostDate = ''' + @AcctStartDate + '''))' 
    set @S_WHERE = @S_WHERE + ' AND (Datediff(day,F_PostDate ,''' + @PARA_AsToDate + ''') >=0) AND F_PostDate >= ''' + @AcctStartDate + ''''  -- As to Date      - M 
    set @S_WHERE = @S_WHERE + ' AND V.F_GLNo = ''' + @PARA_GLNo + ''''                                      -- GLNo            - M 
    If Len(@PARA_SubCode)>0 set @S_WHERE = @S_WHERE + ' AND F_SubCode=''' + @PARA_SubCode + ''''            -- SubCode    - O 
    If Len(@PARA_Branch)>0  set @S_WHERE = @S_WHERE + ' AND F_Branch=''' + @PARA_Branch + ''''              -- Branch     - O 
    ----------------------------------------------- 

EXEC(  
    'SELECT F_PostDate, F_Type, F_ComID, F_ComType, F_ComName, F_GLName,  
        (CASE WHEN F_GLType IN (''L'',''Q'',''I'',''OI'') THEN F_Credit - F_Debit ELSE F_Debit - F_Credit END) As F_Balance 
    From ( 
        Select  F_PostDate, F_Type, F_Branch,F_ComType, F_ComID, F_ComName, F_SubCode, 
                F_GLType, F_GLName, F_GLNo, F_Debit, F_Credit 
        From V_AC_NewGLAging 
    ) As V  
    WHERE ' + @S_WHERE + ' 
    ORDER BY V.F_ComName, F_ComID, F_PostDate ' 
)  
"},
            { "up_AC_NewGLUnion",
                @"
	 CREATE PROCEDURE [dbo].[up_AC_NewGLUnion]     
    @PARA_DateFrom nvarchar(20),            
    @PARA_DateTo nvarchar(20),              
    @PARA_GLNoFrom nvarchar(10),            
    @PARA_GLNoTo nvarchar(10),              
    @PARA_SubCode nvarchar(20),              
    @PARA_Branch nvarchar(3)                
 AS 
    -----------------------------------------------  
    Declare @S_WHERE nvarchar(300)  
    set @S_WHERE=''  
    set @S_WHERE = @S_WHERE + 'AND (Datediff(Day,F_PostDate,''' + @PARA_DateFrom + ''') <=0 AND Datediff(Day,F_Postdate,''' + @PARA_DateTo + ''') >=0)'    -- Period      - O  
    If Len(@PARA_GLNoFrom) > 0 AND Len(@PARA_GLNoTo) > 0                                                                -- GL No Range - O  
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''' And V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
    Else If Len(@PARA_GLNoFrom) > 0 
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + '''' 
    Else If Len(@PARA_GLNoTo) > 0 
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
    If Len(@PARA_SubCode)>0 set @S_WHERE = @S_WHERE + ' AND F_SubCode=''' + @PARA_SubCode + ''''                    -- SubCode    - O 
    If Len(@PARA_Branch)>0  set @S_WHERE = @S_WHERE + ' AND F_Branch=''' + @PARA_Branch + ''''                      -- Branch     - O 
    -----------------------------------------------  

 EXEC 
 (  
    ' 
    SELECT F_GLNo, F_GLFull, F_SubCode, F_ComId, F_ComName, F_PostDate, F_Type, F_SeqNo,  
            F_MDesc , F_Debit, F_Credit, F_ComType, F_BRANCH ,F_Currency,F_exrate,F_Fdebit,F_FCredit,F_U2DATE 
     FROM V_AC_NewGL V 
     WHERE V.F_Type <> ''X'' ' + @S_WHERE + ' 
      ORDER BY F_PostDate, F_BRANCH, F_SeqNo ' 
 )  
"},
            { "up_AC_NewPGLDetailUnion",
                @"
	 CREATE PROCEDURE [dbo].[up_AC_NewPGLDetailUnion]      
    @PARA_ReportType nvarchar(300),                  
    @PARA_DateBeg nvarchar(20),                    
    @PARA_DateFrom nvarchar(20),                    
    @PARA_DateTo nvarchar(20),                      
    @PARA_GLNoFrom nvarchar(10),                    
    @PARA_GLNoTo nvarchar(10),                      
    @PARA_SubCode nvarchar(20),                      
    @PARA_Branch nvarchar(3),                       
    @PARA_Customer nvarchar(50)                     
 AS 
    ----------------------------------------------- 
    Declare @S_WHERE nvarchar(500) 
    set @S_WHERE='' 
    set @S_WHERE = @S_WHERE + 'AND F_TBType IN (' +  @PARA_ReportType + ') '                                        -- Report Type - M  
    set @S_WHERE = @S_WHERE + 'AND (Datediff(Day,F_PostDate,''' + @PARA_DateFrom + ''') <=0 AND Datediff(Day,F_Postdate,''' + @PARA_DateTo + ''') >=0)'    -- Period      - O  
    If Len(@PARA_GLNoFrom) > 0 AND Len(@PARA_GLNoTo) > 0                                                            -- GL No Range - O  
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''' And V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
    Else If Len(@PARA_GLNoFrom) > 0 
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''''  
    Else If Len(@PARA_GLNoTo) > 0  
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
    If Len(@PARA_SubCode)>0 set @S_WHERE = @S_WHERE + ' AND F_SubCode=''' + @PARA_SubCode + ''''                    -- SubCode    - O  
    If Len(@PARA_Branch)>0  set @S_WHERE = @S_WHERE + ' AND F_Branch=''' + @PARA_Branch + ''''                      -- Branch     - O  
    If Len(@PARA_Customer)>0  set @S_WHERE = @S_WHERE + ' AND COMINFO=''' + @PARA_Customer + ''''                   -- Customer   - O  

 EXEC(  
    'SELECT F_GLSUBGROUP, F_GLDESCRIPTION, F_GLType, V.F_GLNo, F_SeqNo, F_BRANCH, F_SubCode,  
        F_PostDate, F_TBName, F_TBID, F_Source, F_Description, COMINFO, 
        F_Debit , F_Credit, F_BeginBal,F_U2DATE 
    From 
        ( 
        SELECT F_GLSUBGROUP, F_GLDESCRIPTION, F_Type, F_GLType, F_GLNo, F_SeqNo, F_BRANCH, F_SubCode, 
                F_PostDate, F_TBName, F_TBType, F_TBID, F_Source, F_Description, COMINFO, 
                F_Debit , F_Credit,F_U2DATE 
        From V_AC_NewPGLDetail 
        ) As V 
    Left Join 
        ( 
        select F_GLNo, sum(F_BeginBal) as F_BeginBal from 
        ( 
            Select * from dbo.uf_AC_NewGetBeginBalO(''' + @PARA_DateBeg + ''',''' + @PARA_DateFrom + ''',''' + @PARA_Customer + ''',''' + @PARA_Branch + ''')  
        )  as AA 
        group by F_GLNo 
        )as BB ON (BB.F_GLNo = V.F_GLNo) 
    WHERE V.F_Type<>''X'' ' + @S_WHERE + ' 
    ORDER BY V.F_GLSUBGROUP, V.F_GLNo, V.F_Branch, V.F_PostDate, V.F_SeqNo ' 
)
"},
            { "up_AC_NewPGLSumUnion",
                @"
CREATE PROCEDURE [dbo].[up_AC_NewPGLSumUnion] 
    @PARA_ReportType nvarchar(700),      
    @PARA_DateBeg nvarchar(20),        
    @PARA_DateFrom nvarchar(20),        
    @PARA_DateTo nvarchar(20),          
    @PARA_GLNoFrom nvarchar(10),        
    @PARA_GLNoTo nvarchar(10),          
    @PARA_SubCode nvarchar(20),          
    @PARA_Branch nvarchar(3)            
 AS
    -----------------------------------------------
    Declare @S_WHERE nvarchar(2000) 
    Declare @S_GLNoRange nvarchar(100) 
    set @S_WHERE='' 
    set @S_GLNoRange='' 
    set @S_WHERE = @S_WHERE + 'AND F_TBType IN (' +  @PARA_ReportType + ') '                                        -- Report Type - M  
    set @S_WHERE = @S_WHERE + 'AND (Datediff(Day,F_PostDate,''' + @PARA_DateFrom + ''') <=0 AND Datediff(Day,F_Postdate,''' + @PARA_DateTo + ''') >=0)'    -- Period      - O  

    If Len(@PARA_GLNoFrom) > 0 AND Len(@PARA_GLNoTo) > 0                                                            -- GL No Range - O  
      Begin
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''' And V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
        set @S_GLNoRange = @S_GLNoRange + ' AND VV.F_GLNo >= ''' + @PARA_GLNoFrom + ''' And VV.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
      End
    Else If Len(@PARA_GLNoFrom) > 0  
      Begin
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''''  
        set @S_GLNoRange = @S_GLNoRange + ' AND VV.F_GLNo >= ''' + @PARA_GLNoFrom + ''''  
      End
    Else If Len(@PARA_GLNoTo) > 0  
      Begin
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
        set @S_GLNoRange = @S_GLNoRange + ' AND VV.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
      End
    If Len(@PARA_SubCode)>0 set @S_WHERE = @S_WHERE + ' AND F_SubCode=''' + @PARA_SubCode + ''''                    -- SubCode    - O 
    If Len(@PARA_Branch)>0  set @S_WHERE = @S_WHERE + ' AND F_Branch=''' + @PARA_Branch + ''''                      -- Branch     - O 
    ----------------------------------------------- 

 EXEC( 
    'SELECT VV.F_GLNo, VV.F_GLType, VV.F_GLName,  
            SUM(F_Debit) as F_Debit , SUM( F_Credit) as F_Credit,  SUM(F_BeginBal) as F_BeginBal  
    From  
    (  
    Select F_GLNo, F_GLType, F_GLName, 0 as F_Debit, 0 as F_Credit,  sum(F_BeginBal) as F_BeginBal from  
    (  
            Select * from dbo.uf_AC_NewGetBeginBalO(''' + @PARA_DateBeg + ''',''' + @PARA_DateFrom + ''',default,''' + @PARA_Branch + ''')  
    )  as AA  
    Group by F_GLNo, F_GLType, F_GLName  
                                                 
    Union  
                                                 
    Select  F_GLNo, F_GLType, F_GLName, SUM(F_Debit) as F_Debit , Sum(F_Credit) as F_Credit, 0 as F_BeginBal  
    From V_AC_NewPGLSummary as V  
    WHERE F_Type<>''X''' + @S_WHERE + ' 
    Group By F_GLNo, F_GLType, F_GLName  

    )as VV  
    --LEFT JOIN T_CODEGLNO AS CD ON CD.F_GLNO=VV.F_GLNO  
    WHERE 1=1 ' + @S_GLNoRange + ' 
    GROUP BY VV.F_GLNo, VV.F_GLType, VV.F_GLName  
    HAVING SUM(F_DEBIT) <> 0 OR SUM(F_CREDIT) <> 0 
    ORDER BY VV.F_GLNo, VV.F_GLType, VV.F_GLName ' 
)
"},
            { "up_AC_NewTBUnion",
                @"
create  procedure   [dbo].[up_AC_NewTBUnion] 
            @F_StrDate          DateTime, 
            @F_EndDate          DateTime, 
            @F_Branch           varchar(3) 
as 

IF LEN(@F_Branch) > 0 
    BEGIN 
        select Sum(F_RemainL) as F_RemainL, Sum(F_DebitL) as F_DebitL, F_GLName, Sum(F_CreditR) as F_CreditR, Sum(F_RemainR) as F_RemainR, F_Sort, F_GLNo, F_Branch 
        From 
        ( 
            select Sum(F_RemainL) as F_RemainL, sum(F_DebitL) as F_DebitL, F_GLName, sum(F_CreditR) as F_CreditR, 
            sum(F_RemainR) as F_RemainR, F_Sort, F_GLNo, F_Branch 
            From V_AC_NewTB 
            Where F_PostDate between @F_StrDate and @F_EndDate 
            group by F_GLName, F_Sort, F_GLNo, F_Branch 
         ) XX 
        Where XX.F_Branch = @F_Branch 
        Group By F_GLName, F_Sort, F_GLNo, F_Branch 
        HAVING SUM(F_RemainL) <> 0 OR SUM(F_RemainR) <> 0 
        order by F_Sort 
    End 
ELSE 
    BEGIN 
        select sum(F_RemainL) as F_RemainL, sum(F_DebitL) as F_DebitL, F_GLName, sum(F_CreditR) as F_CreditR, 
        sum(F_RemainR) as F_RemainR, F_Sort, F_GLNo 
        From 
        ( 
            select Sum(F_RemainL) as F_RemainL, sum(F_DebitL) as F_DebitL, F_GLName, sum(F_CreditR) as F_CreditR, 
            sum(F_RemainR) as F_RemainR, F_Sort, F_GLNo 
            From V_AC_NewTB 
            Where F_PostDate between @F_StrDate and @F_EndDate 
            group by F_GLName, F_Sort, F_GLNo 
        ) XX 
        Group by F_GLName, F_Sort, F_GLNo 
        HAVING SUM(F_RemainL) <> 0 OR SUM(F_RemainR) <> 0 
        order by F_Sort 
    END 
"},
            { "up_AC_NewTBUnionB",
                @"
create  procedure   [dbo].[up_AC_NewTBUnionB] 
            @F_StrDate          DateTime, 
            @F_EndDate          DateTime 
as 

    BEGIN 
        select Sum(F_RemainL) as F_RemainL, Sum(F_DebitL) as F_DebitL, F_GLName, Sum(F_CreditR) as F_CreditR, Sum(F_RemainR) as F_RemainR, F_Sort, F_GLNo, F_Branch 
        From 
        ( 
            select Sum(F_RemainL) as F_RemainL, sum(F_DebitL) as F_DebitL, F_GLName, sum(F_CreditR) as F_CreditR, 
            sum(F_RemainR) as F_RemainR, F_Sort, F_GLNo,  CASE WHEN F_GLNo <> '' THEN F_Branch ELSE '' END AS F_BRANCH 
            From V_AC_NewTB 
            Where F_PostDate between @F_StrDate and @F_EndDate 
            group by F_GLName, F_Sort, F_GLNo, F_Branch 
         ) XX 
        Group By F_GLName, F_Sort, F_GLNo, F_Branch 
        order by F_Sort,F_GLNO,F_BRANCH 
    End 
"},
            { "up_AC_PGLDetailUnion2017",
                @"
/*                                                                                                                                             
    ** Beginning Balance, Accumulated Balance 표시                                                                                             
        1. 회계시작년도의 첫 데이터의 경우 Year End 여부와 상관없이 Beginning Balance로 표시                                                   
        2. Year End(O) : Beginning Balance / Year End(X) : Accumulated Balance                                                                 
        3. Year End(O), 회계시작월이 1월인 경우                                                                                                
            a. 당해년도 첫 데이터(2019-01-15) < 검색 시작날짜(2019-02-01) : 당해년도에 이전값이 존재하기 때문에 Accumulated Balance            
            b. 당해년도 첫 데이터(2019-01-15) < 검색 시작날짜(2019-01-01) : 당해년도에 이전값이 존재하지 않기 때문에 Beginning Balance         
                                                                                                                                               
    ** Ending Balance 표시                                                                                                                     
        1. Year End(O) : Ending Balance 표시                                                                                                   
           -> 표시는 기본적으로 당해년도 마감월에 표시되고 마감월이 아니여도 당해년도 마지막 데이터 월에 표시                                  
        2. Year End(X) : Ending Balance를 표시하지 않음                                                                                        

    <Update History>                                                                                                                           
    2019-04-19                                                                                                                                 
        1. 검색기간 내에 Transaction이 발생하지 않아도 이전 잔액이 있는 경우 계정과목을 표시하도록 적용                                        
    2019-05-14                                                                                                                                 
        1. 수입, 비용의 경우 이전년도 잔액을 누적해서 읽어오지 않고 당해 년도 금액만 누적되서 표시되도록 적용                                  
    2019-10-22 / [191010365]                                                                                                                   
        1. 수입, 비용을 출력 시 누적 금액을 표시할 때 FromDate까지 포함되서 Beginning Balance or Accumulated Balance가 표시되는 문제 수정      
*/                                                                                                                                             

CREATE PROCEDURE [dbo].[up_AC_PGLDetailUnion2017]                          
     @PARA_FromYear int,                                                   
     @PARA_ToYear int,                                                     
     @PARA_FromGLNo nvarchar(10) = '',                                     
     @PARA_ToGLNo nvarchar(10) = '',                                       
     @PARA_SubCode nvarchar(50) = '',                                      
     @PARA_CustomerType varchar(10), @PARA_Customer int,                   
     @PARA_Branch nvarchar(3)  = '',                                       
     @PARA_ReportType nvarchar(300) = '',                                  
     @PARA_DateFrom nvarchar(20) = '',                                     
     @PARA_DateTo nvarchar(20) = ''                                        
AS                                                                         
SET NOCOUNT ON                                                             
SET ANSI_WARNINGS OFF                                                      
CREATE TABLE #TEMP_SLIP                                                    

(                                                                          
     F_GLNo varchar(10) COLLATE DATABASE_DEFAULT,                          
     F_GLType varchar(4) COLLATE DATABASE_DEFAULT,                         
     F_GLName varchar(100) COLLATE DATABASE_DEFAULT,                       
     F_BeginBal decimal(16,4),                                             
     F_EndingBal decimal(16,4),                                            
     F_CurrentYear varchar(4) COLLATE DATABASE_DEFAULT                     
)                                                                          
CREATE TABLE #TEMP_POSTDATE                                                
(                                                                          
     F_GLNo varchar(10) COLLATE DATABASE_DEFAULT,                          
     F_FirstDate datetime,                                                 
     F_LastDate datetime,                                                  
     F_CurrentYear varchar(4) COLLATE DATABASE_DEFAULT                     
)                                                                          

DECLARE @FiscalEndMonth INT                                                
DECLARE @BeginMonth INT                                                    
DECLARE @BegDate varchar(20)                                               
DECLARE @PreviousBegDate varchar(20)                                       
DECLARE @EndingDate varchar(20)                                            
DECLARE @StartDate varchar(20)                                             
DECLARE @S_WHERE nvarchar(500)                                             
DECLARE @S_WHERE1 nvarchar(500)                                            
DECLARE @S_WHERE2 nvarchar(500)                                            
DECLARE @S_SELECT NVARCHAR(4000)                                           
DECLARE @S_SELECT2 NVARCHAR(4000)                                          
DECLARE @S_COMFIELD NVARCHAR(150)                                          
DECLARE @S_JOINCOMPANY NVARCHAR(200)                                       
DECLARE @S_WHERECOMPAY NVARCHAR(100)                                       
DECLARE @BeginJourId As Int           -- Beginning Data 존재 여부          
DECLARE @iMinRow int                  -- 검색 년도                         
DECLARE @RetaindEarning varchar(10)                                        

SET @RetaindEarning = (Select Top 1 RTRIM(F_EarningGLNo) FROM T_CODEDATA)  
--SET @StartDate = CONVERT(DATETIME, CONVERT(VARCHAR(6),(SELECT F_C3 FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27)) + '01') 
SET @StartDate = dbo.uf_AcctStartYearBeginDate()                                                                                    
SET @FiscalEndMonth =(SELECT F_N2 FROM T_AotherInfo WHERE F_TBNAME = 'T_CODEDATA' AND F_TBID = 1 AND F_TYPE = 27)          
SET @BeginMonth = (CASE WHEN @FiscalEndMonth = 12 THEN 1 ELSE @FiscalEndMonth + 1 END)                                     
SET @S_WHERE = ''                                                                                                          
SET @S_WHERE1 = ''                                                                                                         
SET @S_WHERE2 = ''                                                                                                         
SET @S_COMFIELD = ''                                                                                                       
SET @S_JOINCOMPANY = ''                                                                                                    
SET @S_WHERECOMPAY = ''                                                                                                    

IF Len(@PARA_FromGLNo) > 0 AND Len(@PARA_ToGLNo) > 0                                                                       
    BEGIN                                                                                                                  
    SET @S_WHERE = @S_WHERE + ' AND T1.F_GLNo >= ''' + @PARA_FromGLNo + ''' And T1.F_GLNo <= ''' + @PARA_ToGLNo + ''''     
    END                                                                                                                    
ELSE IF Len(@PARA_FromGLNo) > 0                                                                                            
    BEGIN                                                                                                                  
    SET @S_WHERE = @S_WHERE + ' AND T1.F_GLNo >= ''' + @PARA_FromGLNo + ''''                                               
    END                                                                                                                    
ELSE IF Len(@PARA_ToGLNo) > 0                                                                                              
    BEGIN                                                                                                                  
    SET @S_WHERE = @S_WHERE + ' AND T1.F_GLNo <= ''' + @PARA_ToGLNo + ''''                                                 
    END                                                                                                                    

IF Len(@PARA_SubCode) > 0 SET @S_WHERE = @S_WHERE + ' AND T1.F_SubCode=''' + @PARA_SubCode + ''''                          
IF Len(@PARA_Branch) > 0  SET @S_WHERE = @S_WHERE + ' AND T1.F_Branch=''' + @PARA_Branch + ''''                            

IF @PARA_Customer > 0 
    BEGIN 
    SET @S_JOINCOMPANY = 'LEFT JOIN T_COMPANY T5 On (T5.F_ID = T1.F_ComId And T1.F_ComType = ''C'') LEFT JOIN T_CODEBANK T6 On (T6.F_ID = T1.F_ComId And T1.F_ComType = ''B'') '   
    SET @S_COMFIELD = 'ISNULL(case when T1.F_ComType = ''C'' then T5.F_SName else T6.F_BankName end ,'''') AS COMINFO, '                                                           
    SET @S_WHERE = @S_WHERE + ' AND T1.F_ComId = ' + ltrim(str(@PARA_Customer) + ' AND T1.F_ComType = ''' + @PARA_CustomerType + '''')                                             
    SET @S_WHERECOMPAY = ' AND T1.F_ComId = ' + ltrim(str(@PARA_Customer) + ' AND T1.F_ComType = ''' + @PARA_CustomerType + '''')                                                  
    END                                                                                                                                                                            
ELSE If @PARA_Customer = -1                                                                                                                                                        
    BEGIN                                                                                                                                                                          
    SET @S_COMFIELD = ''''' AS COMINFO, '                                                                                                                                          
    SET @S_WHERE = @S_WHERE + ' AND T1.F_ComId = 0 AND T1.F_ComType = ''' + @PARA_CustomerType + ''''                                                                              
    END                                                                                                                                                                            

ELSE If @PARA_Customer = -2                                                                                                                                                        
    BEGIN                                                                                                                                                                          
    SET @S_JOINCOMPANY = 'LEFT JOIN T_COMPANY T5 On (T5.F_ID = T1.F_ComId And T1.F_ComType = ''C'') LEFT JOIN T_CODEBANK T6 On (T6.F_ID = T1.F_ComId And T1.F_ComType = ''B'') '   
    SET @S_COMFIELD = ''''' AS COMINFO, '                                                                                                                                          
    SET @S_WHERE = @S_WHERE + ' AND T1.F_ComId <> 0 AND T1.F_ComType = ''' + @PARA_CustomerType + ''''                                                                             
    SET @S_WHERE2 = ' AND T5.F_ID IS NULL '                                                                                                                                        
    END                                                                                                                                                                            
ELSE                                                                                                                                                                               
    BEGIN                                                                                                                                                                          
    SET @S_JOINCOMPANY = 'LEFT JOIN T_COMPANY T5 On (T5.F_ID = T1.F_ComId And T1.F_ComType = ''C'') LEFT JOIN T_CODEBANK T6 On (T6.F_ID = T1.F_ComId And T1.F_ComType = ''B'') '   
    SET @S_COMFIELD = 'ISNULL(case when T1.F_ComType = ''C'' then T5.F_SName else T6.F_BankName end ,'''') AS COMINFO, '                                                           
    END                                                                                                                                                                            

                                                                                                                                                           
--IF Len(@PARA_ReportType) > 0 SET @S_WHERE = @S_WHERE + 'AND F_TBType IN (''' +  @PARA_ReportType + ''') '                                                
SET @S_WHERE1 = @S_WHERE + 'AND (Datediff(Day, T1.F_PostDate,''' + @PARA_DateFrom + ''') <=0 AND Datediff(Day, T1.F_Postdate,''' + @PARA_DateTo + ''') >=0)'       
--SET @S_WHERE1 = Replace(@S_WHERE1, 'F_ComId','COMID')                                                                                                    
                                                                                                                                                           
--SET @iMinRow = @PARA_FromYear                                                                                                                            
SET @iMinRow = (CASE WHEN DateDiff(d, @PARA_DateFrom, DateAdd(month, @BeginMonth - 1, DateAdd(year, year(@PARA_DateFrom) - 1900, 0))) > 0 THEN year(@PARA_DateFrom) - 1 ELSE year(@PARA_DateFrom) END) 

IF @iMinRow < @PARA_FromYear               
    BEGIN                                      
    SET @PARA_FromYear = @iMinRow          
    END                                        

WHILE @iMinRow <= @PARA_ToYear                                                                                                                                             
    BEGIN                                                                                                                                                                  
    SET @BegDate = ltrim(str(@iMinRow)) + '-' + RIGHT('0' + CONVERT(VARCHAR(2),CASE WHEN @FiscalEndMonth = 12 THEN '01' ELSE @FiscalEndMonth + 1 END), 2) + '-01'          
    --SET @PreviousBegDate = (SELECT MAX(F_POSTDATE) FROM T_SLIPHD WHERE F_TYPE='X' AND F_POSTDATE <= CONVERT(DATETIME, @BegDate))                                         
    SET @PreviousBegDate = (SELECT MAX(F_POSTDATE) FROM T_SLIPHD WHERE F_TYPE='X'and F_SeqNo=1 AND F_POSTDATE < CONVERT(DATETIME, @BegDate))                               
    SET @EndingDate = DateAdd(Day,-1, Convert(Datetime, DateAdd(Year, 1, @BegDate)))                                                                                       
                                                                                                                                                                           
    -- Beginning Data가 없는 경우 회계 시작일 설정                                                                                                                         
    IF @PreviousBegDate is null                                                                                                                                            
        BEGIN                                                                                                                                                              
        SET @PreviousBegDate = @StartDate                                                                                                                                  
        END                                                                                                                                                                
                                                                                                                                                                           
    IF Len(@PARA_Branch) > 0                                                                                                                                               
        BEGIN                                                                                                                                                              
        SET @BeginJourId = (Select MAX(F_Id) FROM T_SLIPHD WHERE F_Type ='X' And F_PostDate = @EndingDate AND F_Branch=@PARA_Branch)                                       
        END                                                                                                                                                                
    ELSE                                                                                                                                                                   
        BEGIN                                                                                                                                                              
        SET @BeginJourId = (Select MAX(F_Id) FROM T_SLIPHD WHERE F_Type ='X' And F_PostDate = @EndingDate)                                                                 
        END                                                                                                                                                                
    

    -- End Year 처리 된 경우                                                                                                                                                                                                                                                           
    IF @BeginJourId > 0                                                                                                                                                                                                                                                                
        BEGIN                                                                                                                                                                                                                                                                          
        IF @iMinRow = @PARA_FromYear                                                                                                                                                                                                                                                   
            BEGIN                                                                                                                                                                                                                                                                      
            SELECT @S_SELECT = 'SELECT T1.F_GLNo as F_GLNo, '                                                               
            SELECT @S_SELECT = @S_SELECT + 'T3.F_GLType, MAX(T3.F_GLDescription) as F_GLName, '                                                                                                                                                                                        
            SELECT @S_SELECT = @S_SELECT + 'CASE WHEN T3.F_GLType IN (''A'',''L'',''Q'') THEN ROUND(SUM(CASE WHEN (T1.F_PostDate = CONVERT(datetime, ''' + @BegDate + ''') And T1.F_Type In (''X'', ''B'', ''DB'', ''CB'')) '                                                                          
            SELECT @S_SELECT = @S_SELECT + 'OR (T1.F_PostDate Between CONVERT(Datetime,''' + @BegDate + ''') And CONVERT(Datetime, DateAdd(Day, -1, ''' + @PARA_DateFrom + ''')) And T1.F_Type Not in (''X'',''B'', ''DB'', ''CB'')) THEN T1.F_Debit - T1.F_Credit ELSE 0 END),4) '                    
            SELECT @S_SELECT = @S_SELECT + 'WHEN T3.F_GLType NOT IN (''A'',''L'',''Q'') THEN ROUND(SUM(CASE WHEN T1.F_Type Not In (''X'', ''B'', ''DB'', ''CB'') AND T1.F_PostDate Between CONVERT(Datetime,''' + @BegDate + ''') And CONVERT(Datetime, DateAdd(Day, -1, ''' + @PARA_DateFrom + ''')) THEN T1.F_Debit - T1.F_Credit ELSE 0 END),4) ELSE 0 END AS F_BeginBal, ' 
            --SELECT @S_SELECT = @S_SELECT + 'ROUND(SUM(CASE WHEN T1.F_PostDate = CONVERT(Datetime, ''' + @EndingDate + ''') And (T1.F_Type = ''X'' And T1.f_seqno in (98, 99)) THEN -(T1.F_Debit - T1.F_Credit) ELSE 0 END),4) AS F_EndingBal, '                                      
            SELECT @S_SELECT = @S_SELECT + 'ROUND(SUM(CASE WHEN T1.F_GLNO =''' + @RetaindEarning + ''' And (T1.F_Type = ''X'' And T1.f_seqno =''99'') THEN -(T1.F_Debit - T1.F_Credit) '                                                                                               
            --SELECT @S_SELECT = @S_SELECT + 'WHEN T1.F_GLNO <> ''' + @RetaindEarning + ''' And T1.F_PostDate = CONVERT(Datetime, ''' + @EndingDate + ''') And (T1.F_Type = ''X'' And T1.f_seqno in (98, 99)) THEN -(T1.F_Debit - T1.F_Credit) ELSE 0 END),4) AS F_EndingBal, '        
            SELECT @S_SELECT = @S_SELECT + 'WHEN T1.F_GLNO <> ''' + @RetaindEarning + ''' And T3.F_GLType Not IN (''A'',''L'',''Q'') And Not T1.F_Type In (''X'', ''B'') THEN (T1.F_Debit - T1.F_Credit) '                                                                             
            SELECT @S_SELECT = @S_SELECT + 'WHEN T1.F_GLNO <> ''' + @RetaindEarning + ''' And T3.F_GLType IN (''A'',''L'',''Q'') And T1.F_PostDate = CONVERT(Datetime, ''' + @EndingDate + ''') And (T1.F_Type = ''X'' And T1.f_seqno = ''99'') THEN -(T1.F_Debit - T1.F_Credit) '     
            SELECT @S_SELECT = @S_SELECT + 'ELSE 0 END),4) AS F_EndingBal, '                                                                                                                                                                                                           
            SELECT @S_SELECT = @S_SELECT + '' + ltrim(str(@iMinRow)) + ' As F_CurrentYear '                                                                                                                                                                                            
            SELECT @S_SELECT = @S_SELECT + 'FROM V_slipX T1 '                                                                                                                                                                                                                          
            SELECT @S_SELECT = @S_SELECT + 'LEFT JOIN T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo) '                                                                                                                                                                                         
            SELECT @S_SELECT = @S_SELECT + 'WHERE T1.F_PostDate Between CONVERT(Datetime,''' + @BegDate + ''') And CONVERT(Datetime,''' + @EndingDate + ''') ' + @S_WHERE + ' '                                                                                                        
            SELECT @S_SELECT = @S_SELECT + 'GROUP BY T1.F_GLNo, T3.F_GLType, T3.F_GLGroup ORDER BY T1.F_GLNo'                                                                                                                                                                          
            END     
        ELSE                                                                                                                                                                                                                                                                           
            BEGIN                                                                                                                                                                                                                                                                      
            SELECT @S_SELECT = 'SELECT T1.F_GLNo as F_GLNo, '                                                                                                                                                                                                                          
            SELECT @S_SELECT = @S_SELECT + 'T3.F_GLType, MAX(T3.F_GLDescription) as F_GLName, '                                                                                                                                                                                        
            SELECT @S_SELECT = @S_SELECT + 'CASE WHEN T3.F_GLType IN (''A'',''L'',''Q'') THEN ROUND(SUM(CASE WHEN T1.F_PostDate = CONVERT(datetime, ''' + @BegDate + ''') And T1.F_Type In (''X'', ''B'', ''DB'', ''CB'') THEN T1.F_Debit - T1.F_Credit ELSE 0 END),4) ELSE 0 END AS F_BeginBal, '     
            --SELECT @S_SELECT = @S_SELECT + 'ROUND(SUM(CASE WHEN T1.F_PostDate = CONVERT(Datetime, ''' + @EndingDate + ''') And (T1.F_Type = ''X'' And T1.f_seqno in (98, 99)) THEN -(T1.F_Debit - T1.F_Credit) ELSE 0 END),4) AS F_EndingBal, '                                      
            SELECT @S_SELECT = @S_SELECT + 'ROUND(SUM(CASE WHEN T1.F_GLNO =''' + @RetaindEarning + ''' And (T1.F_Type = ''X'' And T1.f_seqno =''99'') THEN -(T1.F_Debit - T1.F_Credit) '                                                                                               
            --SELECT @S_SELECT = @S_SELECT + 'WHEN T1.F_GLNO <> ''' + @RetaindEarning + ''' And T1.F_PostDate = CONVERT(Datetime, ''' + @EndingDate + ''') And (T1.F_Type = ''X'' And T1.f_seqno in (98, 99)) THEN -(T1.F_Debit - T1.F_Credit) ELSE 0 END),4) AS F_EndingBal, '        
            SELECT @S_SELECT = @S_SELECT + 'WHEN T1.F_GLNO <> ''' + @RetaindEarning + ''' And T3.F_GLType Not IN (''A'',''L'',''Q'') And Not T1.F_Type In (''X'', ''B'', ''DB'', ''CB'') THEN (T1.F_Debit - T1.F_Credit) '                                                                             
            SELECT @S_SELECT = @S_SELECT + 'WHEN T1.F_GLNO <> ''' + @RetaindEarning + ''' And T3.F_GLType IN (''A'',''L'',''Q'') And T1.F_PostDate = CONVERT(Datetime, ''' + @EndingDate + ''') And (T1.F_Type = ''X'' And T1.f_seqno = ''99'') THEN -(T1.F_Debit - T1.F_Credit) '     
            SELECT @S_SELECT = @S_SELECT + 'ELSE 0 END),4) AS F_EndingBal, '                                                                                                                                                                                                           
            SELECT @S_SELECT = @S_SELECT + '' + ltrim(str(@iMinRow)) + ' As F_CurrentYear '                                                                                                                                                                                            
            SELECT @S_SELECT = @S_SELECT + 'FROM V_slipX T1 '                                                                                                                                                                                                                          
            SELECT @S_SELECT = @S_SELECT + 'LEFT JOIN T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo) '                                                                                                                                                                                         
            --SELECT @S_SELECT = @S_SELECT + 'WHERE (T1.F_PostDate = CONVERT(Datetime, ''' + @BegDate + ''') or F_PostDate = CONVERT(Datetime, ''' + @EndingDate + ''')) And T1.F_Type in (''X'',''B'', ''DB'', ''CB'')  ' + @S_WHERE + ' '                                                            
            SELECT @S_SELECT = @S_SELECT + 'WHERE T1.F_PostDate Between CONVERT(Datetime,''' + @BegDate + ''') And CONVERT(Datetime,''' + @EndingDate + ''') ' + @S_WHERE + ' '                                                                                                        
            SELECT @S_SELECT = @S_SELECT + 'GROUP BY T1.F_GLNo, T3.F_GLType, T3.F_GLGroup ORDER BY T1.F_GLNo'                                                                                                                                                                          
            END                                                                                                                                                                                                                                                                        
        END                 
    --- End Year 처리 안된 경우                                                                                                                                                                                                                                                        
    ELSE    
	                                                                                                              
        BEGIN                                                                                                                                                                                                                                                                          
        IF @iMinRow = @PARA_FromYear                                                                                                                                                                                                                                                   
            BEGIN                                                                                                                                                                                                                                                                      
            SELECT @S_SELECT = 'SELECT T1.F_GLNo as F_GLNo, '                                                                                                                                                                                                                          
            SELECT @S_SELECT = @S_SELECT + 'T3.F_GLType, MAX(T3.F_GLDescription) as F_GLName, '                                                                                                                                                                                        
            SELECT @S_SELECT = @S_SELECT + 'CASE WHEN T3.F_GLType IN (''A'',''L'',''Q'') THEN ROUND(SUM(CASE WHEN ((T1.F_PostDate Between CONVERT(Datetime, '''+@PreviousBegDate+''') And CONVERT(Datetime, DateAdd(Day, -1, ''' + @PARA_DateFrom + ''')) And T1.F_Type Not In (''X'', ''B'', ''DB'', ''CB'') or (T1.F_PostDate = CONVERT(Datetime, '''+@PreviousBegDate+''') And T1.F_Type In (''X'', ''B'', ''DB'', ''CB''))) or (T1.F_GLNO =''' + @RetaindEarning + ''' And (T1.F_Type = ''X'' And T1.f_seqno =''98''))) THEN T1.F_Debit- T1.F_Credit ELSE 0 END),4) ' 
            SELECT @S_SELECT = @S_SELECT + 'WHEN T3.F_GLType NOT IN (''A'',''L'',''Q'') THEN ROUND(SUM(CASE WHEN T1.F_Type Not In (''X'', ''B'', ''DB'', ''CB'') AND T1.F_PostDate Between CONVERT(Datetime,''' + @BegDate + ''') And CONVERT(Datetime, DateAdd(Day, -1, ''' + @PARA_DateFrom + ''')) THEN T1.F_Debit - T1.F_Credit ELSE 0 END),4) ELSE 0 END AS F_BeginBal, '            
            --SELECT @S_SELECT = @S_SELECT + 'ROUND(SUM(CASE WHEN T1.F_PostDate = CONVERT(Datetime, ''' + @EndingDate + ''') And (T1.F_Type = ''X'' And T1.f_seqno in (98, 99)) THEN -(T1.F_Debit - T1.F_Credit) ELSE 0 END),4) AS F_EndingBal, '                                      
            SELECT @S_SELECT = @S_SELECT + 'ROUND(SUM(CASE WHEN T1.F_GLNO =''' + @RetaindEarning + ''' And (T1.F_Type = ''X'' And T1.f_seqno =''99'') THEN -(T1.F_Debit - T1.F_Credit) '                                                                                               
            SELECT @S_SELECT = @S_SELECT + 'WHEN T1.F_GLNO <> ''' + @RetaindEarning + ''' And T1.F_PostDate = CONVERT(Datetime, ''' + @EndingDate + ''') And (T1.F_Type = ''X'' And T1.f_seqno in (98, 99)) THEN -(T1.F_Debit - T1.F_Credit) ELSE 0 END),4) AS F_EndingBal, '          
            SELECT @S_SELECT = @S_SELECT + '' + ltrim(str(@iMinRow)) + ' As F_CurrentYear '                                                                                                                                                                                            
            SELECT @S_SELECT = @S_SELECT + 'FROM V_slipX T1 '                                                                                                                                                                                                                          
            SELECT @S_SELECT = @S_SELECT + 'LEFT JOIN T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo) '                                                                                                                                                                                         
            SELECT @S_SELECT = @S_SELECT + 'WHERE T1.F_PostDate Between CONVERT(Datetime,''' + @PreviousBegDate + ''') And CONVERT(Datetime, ''' + @EndingDate + ''') ' + @S_WHERE + ' '                                                                                               
            SELECT @S_SELECT = @S_SELECT + 'GROUP BY T1.F_GLNo, T3.F_GLType, T3.F_GLGroup ORDER BY T1.F_GLNo'                                                                                                                                                                          
            END  
        ELSE                                                                                                                                                                                                                                                                           
            BEGIN                                                                                                                                                                                                                                                                      
            SELECT @S_SELECT = 'SELECT T1.F_GLNo as F_GLNo, '                                                                                                                                                                                                                          
            SELECT @S_SELECT = @S_SELECT + 'T3.F_GLType, MAX(T3.F_GLDescription) as F_GLName, '                                                                                                                                                                                        
            SELECT @S_SELECT = @S_SELECT + 'CASE WHEN T3.F_GLType IN (''A'',''L'',''Q'') THEN ROUND(SUM(CASE WHEN ((T1.F_PostDate Between CONVERT(Datetime, '''+@PreviousBegDate+''') And CONVERT(Datetime, DateAdd(Year, -1, ''' + @EndingDate + ''')) And T1.F_Type Not In (''X'', ''B'', ''DB'', ''CB'') or (T1.F_PostDate = CONVERT(Datetime, '''+@PreviousBegDate+''') And T1.F_Type In (''X'', ''B'', ''DB'', ''CB''))) or (T1.F_GLNO =''' + @RetaindEarning + ''' And (T1.F_Type = ''X'' And T1.f_seqno =''98''))) THEN T1.F_Debit- T1.F_Credit ELSE 0 END),4) ELSE 0 END AS F_BeginBal,'     
            SELECT @S_SELECT = @S_SELECT + '0 As F_EndingBal, '                                                                                                                                                                                                                        
            SELECT @S_SELECT = @S_SELECT + '' + ltrim(str(@iMinRow)) + ' As F_CurrentYear '                                                                                                                                                                                            
            SELECT @S_SELECT = @S_SELECT + 'FROM V_slipX T1 '                                                                                                                                                                                                                          
            SELECT @S_SELECT = @S_SELECT + 'LEFT JOIN T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo) '                                                                                                                                                                                         
            SELECT @S_SELECT = @S_SELECT + 'WHERE T1.F_PostDate Between CONVERT(Datetime,''' + @PreviousBegDate + ''') And CONVERT(Datetime, DateAdd(Year, -1, ''' + @EndingDate + ''')) ' + @S_WHERE + ' '                                                                            
            SELECT @S_SELECT = @S_SELECT + 'GROUP BY T1.F_GLNo, T3.F_GLType, T3.F_GLGroup ORDER BY T1.F_GLNo'                                                                                                                                                                          
            END                                                                                                                                                                                                                                                                        
        END     
    -- 해당 년도에 첫 데이터와 마지막 데이터를 가져오는 Query                                                                                                                                                                                                                          
    BEGIN                                                                                                                                                                                                                                                                              
    SELECT @S_SELECT2 = 'SELECT T1.F_GLNo, Min(F_PostDate) As F_FirstDate, Max(F_PostDate) As F_LastDate, ' + ltrim(str(@iMinRow)) + ' As F_CurrentYear '                                                                                                                              
    SELECT @S_SELECT2 = @S_SELECT2 + 'FROM V_slipX T1 '                                                                                                                                                                                                                                
    --SELECT @S_SELECT2 = @S_SELECT2 + 'WHERE T1.F_Type Not in (''X'',''B'', ''DB'', ''CB'') And T1.F_PostDate Between CONVERT(Datetime,''' + @BegDate + ''') And CONVERT(Datetime, ''' + @EndingDate + ''') ' + @S_WHERE + ' '                                                                        
    SELECT @S_SELECT2 = @S_SELECT2 + 'WHERE (T1.F_Type Not in (''X'',''B'', ''DB'', ''CB'') Or (T1.F_Type= ''X'' And F_SeqNo =''98'' And T1.F_GLNO = ''' + @RetaindEarning + ''')) And T1.F_PostDate Between CONVERT(Datetime,''' + @BegDate + ''') And CONVERT(Datetime, ''' + @EndingDate + ''') ' + @S_WHERE + ' '       
    SELECT @S_SELECT2 = @S_SELECT2 + 'GROUP BY T1.F_GLNo '                                                                                                                                                                                                                             
    END                                                                                                                                                                                                                                                                                
                                                                                                                                                                                                                                                                                       
    INSERT #TEMP_SLIP                                                                                                                                                                                                                                                                  
    EXEC (@S_SELECT)                                                                                                                                                                                                                                                                   
    INSERT #TEMP_POSTDATE                                                                                                                                                                                                                                                              
    EXEC (@S_SELECT2)                                                                                                                                                                                                                                                                  
    SET @iMinRow = @iMinRow + 1                                                                                                                                                                                                                                                        
END   
EXEC('                                                                                                                                                                                                                                                                              
SELECT                                                                                                                                                                                                                                                                                 
    F_STARTDATE, CD.F_GLSUBGROUP, CD.F_GLDESCRIPTION, CD.F_GLTYPE, T1.F_GLNO, T1.F_TYPE, F_SEQNO, F_BRANCH, F_SUBCODE, F_PAIDTO,                                                                                                                                                       
    F_POSTDATE, F_TBNAME, F_TBID, T1.F_TBTYPE, T1.F_KEY, F_DESCRIPTION, COMINFO, COMID, F_DEBIT, F_CREDIT, F_U2DATE,                                                                                                                                                                   
    CASE WHEN F_FIRSTDATE IS NULL AND F_SEQNO = 0 THEN ''' + @PARA_DateFrom + ''' ELSE F_FIRSTDATE END AS F_FIRSTDATE,                                                                                                                                                                 
    CASE WHEN F_LASTDATE IS NULL AND F_SEQNO = 0 THEN ''' + @PARA_DateFrom + ''' ELSE F_LASTDATE END AS F_LASTDATE,                                                                                                                                                                    
    ISNULL(T2.F_BEGINBAL,0) AS F_BEGINBAL, ISNULL(T2.F_ENDINGBAL,0) AS F_ENDINGBAL, ISNULL(T2.F_CURRENTYEAR,YEAR(T1.F_POSTDATE)) AS F_CURRENTYEAR,                                                                                                                                     
    (CASE                                                                                                                                                                                                                                                                              
        WHEN MONTH(T1.F_POSTDATE) < ' + @BeginMonth + ' THEN (CASE WHEN (SELECT MAX(F_Id) FROM T_SLIPHD WHERE F_Type In (''X'',''B'', ''DB'', ''CB'') And F_PostDate = Str(Year(T1.F_PostDate) - 1) + ''-'' + ltrim(Str(' + @BeginMonth + ')) + ''-01'') > 0 THEN 1 ELSE 0 END)                        
        ELSE (CASE WHEN (SELECT MAX(F_Id) FROM T_SLIPHD WHERE F_Type In (''X'',''B'', ''DB'', ''CB'') And F_PostDate = Str(Year(T1.F_PostDate)) + ''-'' + ltrim(Str(' + @BeginMonth + ')) + ''-01'' ) > 0 THEN 1 ELSE 0 END) 
    END) AS F_IsBeginning, 
    (CASE 
        WHEN ' + @BeginMonth + '= ''1'' THEN (CASE WHEN (SELECT MAX(F_Id) FROM T_SLIPHD WHERE F_Type =''X'' And F_PostDate = CONVERT(Datetime, Str(Year(T1.F_PostDate) + 1) + ''-'' + ltrim(Str(' + @BeginMonth + ')) + ''-01'') - 1) > 0 THEN 1 ELSE 0 END) 
        ELSE (CASE WHEN Month(T1.F_PostDate) < ' + @BeginMonth + ' THEN (CASE WHEN (SELECT MAX(F_Id) FROM T_SLIPHD WHERE F_Type =''X'' And F_PostDate = CONVERT(Datetime, Str(Year(T1.F_PostDate)) + ''-'' + ltrim(Str(' + @BeginMonth + ')) + ''-01'') - 1) > 0 THEN 1 ELSE 0 END) ELSE (CASE WHEN (SELECT MAX(F_Id) FROM T_SLIPHD WHERE F_Type =''X'' And F_PostDate = CONVERT(Datetime, Str(Year(T1.F_PostDate) + 1) + ''-'' + ltrim(Str(' + @BeginMonth + ')) + ''-01'') - 1) > 0 THEN 1 ELSE 0 END) END) 
    END) AS F_IsEnding, T1.F_LineColor 
FROM (                                                                                                                                                                                                                                                                                 

    SELECT                                                                                                                                                                                                                             
        0 As F_BeginBal, T1.F_Type, T1.F_TBType, T1.F_KEY,                                                                                                                                                                             
        (CASE                                                                                                                                                                                                                          
            WHEN F_TBNAME = ''T_BANKTRANSFER'' THEN (CASE WHEN T1.F_Credit <> 0 THEN TPAID3.F_BankName ELSE TPAID2.F_BankName END)                                                                                                     
            ELSE (CASE WHEN TPAID.F_LocalName <> '''' THEN TPAID.F_LocalName ELSE TPAID.F_SName END)                                                                                                                                   
        END) AS F_PaidTo, T1.F_LineColor,                                                                                                                                                                                              
        T1.F_GLNo, T1.F_SeqNo, T1.F_BRANCH, T1.F_SubCode, T1.F_PostDate, T1.F_TBName, T1.F_TBID as F_TBID, T1.F_MDesc AS F_Description, ' + @S_COMFIELD + ' T1.F_ComId as COMID, T1.F_ComType, T1.F_Debit, T1.F_Credit, T1.F_U2DATE    
    FROM V_SLIPX2 as T1                                                                                                                                                                                                                
        LEFT JOIN T_DEPOHD TD ON T1.F_TBNAME = ''T_DEPOHD'' AND T1.F_TBID = TD.F_ID                                                                                                                                                    
        LEFT JOIN T_COMPANY TPAID ON TD.F_PaidTo = TPAID.F_Id                                                                                                                                                                          
        LEFT JOIN T_BANKTRANSFER BT ON T1.F_TBID = BT.F_ID And T1.F_TBNAME = ''T_BANKTRANSFER''                                                                                                                                        
        LEFT JOIN T_CODEBANK TPAID2 ON BT.F_TransferFrom = TPAID2.F_Id                                                                                                                                                                 
        LEFT JOIN T_CODEBANK TPAID3 ON BT.F_TransferTo = TPAID3.F_Id                                                                                                                                                                   
        ' + @S_JOINCOMPANY + '                                                                                                                                                                                                         
        WHERE (T1.F_Type Not In (''X'',''B'', ''DB'', ''CB'') Or (T1.F_Type =''X'' And F_SeqNo =''98'' And T1.F_GLNo = ''' + @RetaindEarning + ''')) ' + @S_WHERE1 + @S_WHERE2 + ' 
                                                                                                                                                                                                                                       
    UNION ALL   -- 검색기간 이전에 잔액이 있는 계정코드를 표시하기 위해 추가                                                                                                                                                       
    SELECT                                                                                                                                                                                                                             
        F_BEGINBAL, '''' AS F_TYPE, '''' AS F_TBTYPE, '''' AS F_KEY, '''' AS F_PAIDTO, '''' AS F_LineColor, T1.F_GLNO, '''' AS F_SEQNO, '''' AS F_BRANCH, '''' AS F_SUBCODE, ''' + @PARA_DateFrom + ''' AS F_POSTDATE,                 
        '''' AS F_TBNAME, '''' AS F_TBID, '''' AS F_DESCRIPTION, '''' AS COMINFO, '''' AS  COMID, '''' AS F_COMTYPE, '''' AS F_DEBIT, '''' AS F_CREDIT, '''' AS F_U2DATE                                                               
    FROM (                                                                                                                                                                                                                             
        SELECT T1.* FROM #TEMP_SLIP T1                                                                                                                                                                                                 
        LEFT JOIN (                                                                                                                                                                                                                    
            SELECT T1.F_GLNO FROM V_SLIPX T1                                                                                                                                                                                           
            WHERE (T1.F_Type Not In (''X'',''B'', ''DB'', ''CB'') Or (T1.F_Type = ''X'' And F_SeqNo = ''98'' And T1.F_GLNo = ''' + @RetaindEarning + ''')) ' + @S_WHERE1 + @S_WHERE2 + '                                                               
        ) T2 ON T2.F_GLNO = T1.F_GLNO                                                                                                                                                                                                  
        WHERE T2.F_GLNO IS NULL AND F_CURRENTYEAR = ' + @PARA_FromYear + ' AND F_BEGINBAL <> 0                                                                                                                                         
    ) T1                                                                                                                                                                                                                               
) T1 
    LEFT JOIN (                                                                                                                                                                                                                        
        SELECT * FROM #TEMP_SLIP                                                                                                                                                                                                       
    ) T2 on T2.F_CurrentYear = (CASE WHEN DateDiff(d, T1.F_PostDate, DateAdd(month, ' + @BeginMonth + ' - 1, DateAdd(year, year(T1.F_PostDate) - 1900, 0))) > 0 THEN year(T1.F_PostDate) - 1 ELSE year(T1.F_PostDate) END) And T2.F_GLNo = T1.F_GLNo 
                                                                                                                                                                                                                                       
    LEFT JOIN (                                                                                                                                                                                                                        
        SELECT * FROM #TEMP_POSTDATE                                                                                                                                                                                                   
    ) T3 on T3.F_CurrentYear = (CASE WHEN DateDiff(d, T1.F_PostDate, DateAdd(month, ' + @BeginMonth + ' - 1, DateAdd(year, year(T1.F_PostDate) - 1900, 0))) > 0 THEN year(T1.F_PostDate) - 1 ELSE year(T1.F_PostDate) END) And T3.F_GLNo = T1.F_GLNo 
    LEFT JOIN (                                                                                                                                                                                                                        
        SELECT F_GLNO, MIN(F_POSTDATE) As F_StartDate FROM V_SLIPX as T1                                                                                                                                                               
        WHERE F_POSTDATE Between ''' + @StartDate + ''' And ''' + @PARA_DateTo + '''' + @S_WHERECOMPAY + '                                                                                                                                                   
        GROUP BY F_GLNO                                                                                                                                                                                                                
    ) T4 on T4.F_GLNo = T1.F_GLNO                                                                                                                                                                                                      
    LEFT JOIN T_CODEGLNO AS CD ON (CD.F_GLNO = T1.F_GLNO)                                                                                                                                                                              
ORDER BY T1.F_GLNo, T1.F_PostDate, T1.F_SeqNo                                                                                                                                                                                          
 ') 
"},
            { "up_AC_PGLDetailUnionB" ,
                @"
CREATE PROCEDURE [dbo].[up_AC_PGLDetailUnionB]      
    @PARA_ReportType nvarchar(300),                  
    @PARA_DateFrom nvarchar(20),                    
    @PARA_DateTo nvarchar(20),                      
    @PARA_GLNoFrom nvarchar(10),                    
    @PARA_GLNoTo nvarchar(10),                      
    @PARA_SubCode nvarchar(20),                      
    @PARA_Customer nvarchar(50)                     
 AS 
    ----------------------------------------------- 
    Declare @S_WHERE nvarchar(300), @S_COM nvarchar(60) 
    set @S_WHERE='' 
    set @S_WHERE = @S_WHERE + 'AND F_TBType IN (' +  @PARA_ReportType + ') '                                        -- Report Type - M  
    set @S_WHERE = @S_WHERE + 'AND (DATEDIFF(Day,F_PostDate,''' + @PARA_DateFrom + ''') <=0 AND Datediff(Day,F_Postdate,''' + @PARA_DateTo + ''') >=0)'    -- Period      - O  
    If Len(@PARA_GLNoFrom) > 0 AND Len(@PARA_GLNoTo) > 0                                                            -- GL No Range - O  
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''' And V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
    Else If Len(@PARA_GLNoFrom) > 0 
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''''  
    Else If Len(@PARA_GLNoTo) > 0  
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
    If Len(@PARA_SubCode)>0 set @S_WHERE = @S_WHERE + ' AND F_SubCode=''' + @PARA_SubCode + ''''                    -- SubCode    - O  

    If Len(@PARA_Customer)>0  
         begin 
         set @S_COM = REPLACE(@PARA_Customer, '''', '''''')                                      --  ' --> ''        
         set @S_WHERE = @S_WHERE + ' AND COMINFO=''' + @S_COM + ''''                             -- Customer   - O   
         End  
    -----------------------------------------------

 EXEC(  
     'SELECT F_GLSUBGROUP, F_GLDESCRIPTION, F_GLType, V.F_GLNo, F_SeqNo, F_BRANCH, F_SubCode,  
            F_PostDate, F_TBName, F_TBID, F_Source, F_Description, COMINFO, 
            F_Debit , F_Credit, F_BeginBal 
      From 
         ( 
          SELECT F_GLSUBGROUP, F_GLDESCRIPTION, F_Type, F_GLType, F_GLNo, F_SeqNo, F_BRANCH, F_SubCode, 
                 F_PostDate, F_TBName, F_TBType, F_TBID, F_Source, F_Description, COMINFO, 
                 F_Debit , F_Credit 
          From V_AC_PGLDetail 
         ) As V 
      Left Join 
         ( 
            select F_GLNo, sum(F_BeginBal) as F_BeginBal from 
            ( 
                Select * from dbo.uf_AC_GetBeginBalO(''' + @PARA_DateFrom + ''',''' + @S_COM + ''',default,default) 
            )  as AA 
            group by F_GLNo 
         )as BB ON (BB.F_GLNo = V.F_GLNo) 
      WHERE V.F_Type<>''X'' AND V.F_Type<>''DB'' AND V.F_Type<>''CB'' AND V.F_Type<>''B'' ' + @S_WHERE + ' 
      ORDER BY V.F_GLSUBGROUP, V.F_GLNo, V.F_Branch,V.F_POSTDATE, V.F_SeqNo ' 
    ) 
" },
            { "up_AC_PGLSumUnionB" ,
                @"
CREATE PROCEDURE [dbo].[up_AC_PGLSumUnionB] 
    @PARA_ReportType nvarchar(300),      
    @PARA_DateFrom nvarchar(20),        
    @PARA_DateTo nvarchar(20),          
    @PARA_GLNoFrom nvarchar(10),        
    @PARA_GLNoTo nvarchar(10),          
    @PARA_SubCode nvarchar(20)          
 AS
    -----------------------------------------------
    Declare @S_WHERE nvarchar(300) 
    Declare @S_GLNoRange nvarchar(100) 
    set @S_WHERE='' 
    set @S_GLNoRange='' 
    set @S_WHERE = @S_WHERE + 'AND F_TBType IN (' +  @PARA_ReportType + ') '                                        -- Report Type - M  
    set @S_WHERE = @S_WHERE + 'AND (DATEDIFF(Day,F_PostDate,''' + @PARA_DateFrom + ''') <=0 AND Datediff(Day,F_Postdate,''' + @PARA_DateTo + ''') >=0)'    -- Period      - O  

    If Len(@PARA_GLNoFrom) > 0 AND Len(@PARA_GLNoTo) > 0                                                            -- GL No Range - O  
      Begin
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''' And V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
        set @S_GLNoRange = @S_GLNoRange + ' AND VV.F_GLNo >= ''' + @PARA_GLNoFrom + ''' And VV.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
      End
    Else If Len(@PARA_GLNoFrom) > 0  
      Begin
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo >= ''' + @PARA_GLNoFrom + ''''  
        set @S_GLNoRange = @S_GLNoRange + ' AND VV.F_GLNo >= ''' + @PARA_GLNoFrom + ''''  
      End
    Else If Len(@PARA_GLNoTo) > 0  
      Begin
        set @S_WHERE = @S_WHERE + ' AND V.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
        set @S_GLNoRange = @S_GLNoRange + ' AND VV.F_GLNo <= ''' + @PARA_GLNoTo + ''''  
      End
    If Len(@PARA_SubCode)>0 set @S_WHERE = @S_WHERE + ' AND F_SubCode=''' + @PARA_SubCode + ''''                    -- SubCode    - O 
    ----------------------------------------------- 

 EXEC( 
     'SELECT VV.F_GLNo,YY.F_BRANCH, VV.F_GLType, VV.F_GLName,  
             SUM(F_Debit) as F_Debit , SUM( F_Credit) as F_Credit,  SUM(F_BeginBal) as F_BeginBal  
      From  
      (  
        Select F_GLNo,F_BRANCH, F_GLType, F_GLName, 0 as F_Debit, 0 as F_Credit,  sum(F_BeginBal) as F_BeginBal from  
        (  
            Select * from dbo.uf_AC_GetBeginBalO(''' + @PARA_DateFrom + ''',default,default)  
        )  as AA  
        Group by F_GLNo, F_GLType, F_GLName   
                                                 
      Union  
                                                 
        Select  F_GLNo,F_BRANCH, F_GLType, F_GLName, SUM(F_Debit) as F_Debit , Sum(F_Credit) as F_Credit, 0 as F_BeginBal  
        From V_AC_PGLSummary as V  
        WHERE F_Type<>''X'' AND F_Type<>''DB'' AND F_Type<>''CB'' AND F_Type<>''B''' + @S_WHERE + ' 
        Group By F_GLNo,F_BRANCH, F_GLType, F_GLName  
      )as VV  
      --LEFT JOIN T_CODEGLNO AS CD ON CD.F_GLNO=VV.F_GLNO  
      WHERE 1=1 ' + @S_GLNoRange + '  
      GROUP BY VV.F_GLNo, VV.F_GLType, VV.F_GLName  
      HAVING SUM(F_DEBIT) <> 0 OR SUM(F_CREDIT) <> 0 
      ORDER BY VV.F_GLNo,YY.F_BRANCH, VV.F_GLType, VV.F_GLName  '
    )
" },
            { "up_ApExJourM" ,
                @"
CREATE PROCEDURE up_ApExJourM 
            @MTBName            VARCHAR(20), 
            @MBLId              INT 
AS 
 
BEGIN 
 
-- Make Temporary Table for V_BLSUMM 
SELECT * INTO #T_TEMP_BLSUMM FROM V_BLSUMM WHERE F_MTBName = @MTBName And F_MBLID = @MBLId; 
 
 
 
-- Table Prefix ------------------------------------- 
-- T1 : T_APHD 
-- T2 : T_APDETAIL Or SUB QUERY FOR APDETAIL 
-- T3 : Payment Info. 
-- T6 : T_NCODECHARGE 
-- T7: T_COMPANY (Vendor) 
-- T8 : V_BLSUMM 
----------------------------------------------------- 
-- Used Account Code  ------------------------------- 
-- D/P                  : 212600 - DUTY PAYABLE 
-- Duty2Customer        : 212630 - ADVANCE DUTY RECEIVED (CUSTOMER) 
-- Duty2Agent           : 112630 - ADVANCE DUTY PAYMENT (AGENT) 
-- Collect4Agt          : 212500 - COLLECT SALES FOR AGENT 
-- Loan2Agt             : 112500 - LOAN TO AGENT 
-- Retained Earning     : 331100 - RETAINED EARNING 
----------------------------------------------------- 
 
 
-- Cost / Deferred Cost -------------------------------------------------------------------------------------------------------------------------------- 
-- 21/1    X : A/P                            A/P                                      11,12,13,14,19 : Always 
-- 21/2    D.Cost : X                         Deferred Cost                            11,13,14 : Not Finalized Or (Finalized & Inv.Date <= Final.Date) 
-- 21/3    Cost : X                           Cost                                     11,13,14 : Finalized & Final.Date < Inv.Date,  19 : Always 
-- 21/4    Loan2Agt : X                       Loan2Agt (Agent)                         12 : Always 
-- 21/5    VAT : X                            VAT                                      If Vat Amount is not zero. 
-- 21/6    X : Adv.Pay                        Advance Payment                          If used Advance Payment in bill 
-- 21/7    A/R : X                            Advance Payment A/P                      If used Advance Payment in bill 
-- Duty ------------------------------------------------------------------------------------------------------------------------------------------------ 
-- 21/8    X : D/P                            D/P                                                       18,20 : Always 
-- 21/9    Duty : X                           18 - Duty2Agent (Agt), 20 - Duty2Customer (Customer)      18,20 : Always 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- Finalized ------------------------------------------------------------------------------------------------------------------------------------------- 
-- 23/1    X : D.Cost                         Deferred Cost                            11,13,14 : Finalized & Inv.Date <= Final.Date 
-- 23/2    Cost : X                           Cost                                     11,13,14 : Finalized & Inv.Date <= Final.Date 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- Use Advance Payment in Payment ---------------------------------------------------------------------------------------------------------------------- 
-- 25/1    X : Adv.Pay                        Advance Payment                          If used this bill as Advance Payment in Payment 
-- 25/2    A/P : X                            A/P                                      If used this bill as Advance Payment in Payment 
-- 26/1    X : A/P                            Void - A/P                               If used this bill as Advance Payment in Payment & Void 
-- 26/2    Adv.Pay : X                        Void - Advance Payment                   If used this bill as Advance Payment in Payment & Void 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 2018-06-25 chuck     : Change where condition T2.F_ChgType In (11,13,14) --> T2.F_ChgType Not In (12,18,19,20) 
-- 2018-09-14 chuck     : Advance Received/Advance Payments are applied to Duty AR/AP. 
-- 2018-11-09 chuck     : 21/3 - F_ChgType = 19 And F_CreditINVOHDID > 0 --> Use F_Sales1 Account Code 
-- 2018-12-03 chuck     : Use G.Bill No in General Bill (Bill No --> G.Bill No) 
-- 2019-01-30 chuck     : Support GST,HST,PST BillingCode. It will not make Deferred Sales/Cost Account Code 
-- 2019-02-22 chuck     : Use Finalize Action Date when make finalize journal. 
-- 2019-03-13 chuck     : 21/4 - T7.F_ID As F_ComID --> COALESCE(T7.F_ID, 0) As F_ComID 
-- 2019-03-25 chuck     : 25/1~2, 26/1~2 - Use Payment/Void Action Date for F_U2Date 
-- 2019-04-01 chuck     : Add F_RTBID for sub key Id 
 
-- 21/1    X : A/P                            A/P                                      11,12,13,14,19 : Always 
SELECT 2 As F_TBIndex, 1 As F_Order, 21 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APHD' As F_STBName, T1.F_ID As F_STBID, 
    CASE WHEN T1.F_PAYGLNO = '211610' THEN 'DIVIDEND PAYABLE (G.Bill No: ' + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END + ' )' ) 
        ELSE (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN 'G.Bill No: ' ELSE 'Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) END As F_MDesc, 
    'OK' As F_BillCode, dbo.uf_Slip_GetHeadSubCode(T1.F_ID) As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    0 As F_FDebit, T2.F_Amount As F_FCredit, T1.F_PayGLNo As F_GLNo, 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('21T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD T1 
    INNER JOIN ( 
        SELECT T2.F_ApHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_APHD T1 
            INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
        WHERE T2.F_ChgType Not In (18,38,20) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_ApHDID 
        HAVING ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) <> 0 
    ) T2 On (T2.F_ApHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
 
UNION ALL 
 
-- 21/2    D.Cost : X                         Deferred Cost                            11,13,14 : Not Finalized Or (Finalized & Inv.Date <= Final.Date) 
SELECT 2 As F_TBIndex, 2 As F_Order, 21 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, T2.F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    T2.F_Amount As F_FDebit, 0 As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_DefCost', '')  As F_GLNo, 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('21T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD T1 
    INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType Not In (12,18,19,20) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 And (T8.F_ConfirmDate Is Null Or DATEDIFF(DAY, T8.F_ConfirmDate, T1.F_InvoiceDate) <= 0) 
    And SUBSTRING(T2.F_BillingCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
-- 21/3    Cost : X                           Cost                                     11,13,14 : Finalized & Final.Date < Inv.Date,  19 : Always 
SELECT 2 As F_TBIndex, 3 As F_Order, 21 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(CASE WHEN T6.F_Cost1 = dbo.uf_Slip_GetFixedGLNo('F_EarningGLNo', '') THEN '' ELSE T7.F_SName END, '') As F_ComName, 
    (CASE WHEN T6.F_Cost1 = dbo.uf_Slip_GetFixedGLNo('F_EarningGLNo', '') THEN 0 ELSE T1.F_PayTo END) As F_ComID, 
    'T_APDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, T2.F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    T2.F_Amount As F_FDebit, 0 As F_FCredit, 
    --(CASE T2.F_ChgType WHEN 13 THEN T6.F_Cost3 WHEN 14 THEN T6.F_Cost5 ELSE T6.F_Cost1 END) As F_GLNo, 
    (CASE T2.F_ChgType WHEN 13 THEN T6.F_Cost3 WHEN 14 THEN T6.F_Cost5 ELSE (CASE WHEN T2.F_ChgType = 19 And T1.F_CreditINVOHDId > 0 THEN T6.F_Sales1 ELSE T6.F_Cost1 END) END) As F_GLNo, 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('21T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD T1 
    INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
    LEFT JOIN T_NCODECHARGE T6 On (T6.F_Code = T2.F_BillingCode) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE (T2.F_ChgType = 19 Or SUBSTRING(T2.F_BillingCode, 1, 3) In ('GST','HST','PST','IVA') Or 
    (T2.F_ChgType Not In (12,18,19,20) And DATEDIFF(DAY, T8.F_ConfirmDate, T1.F_InvoiceDate) > 0)) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
 
UNION ALL 
 
-- 21/4    Loan2Agt : X                       Loan2Agt (Agent)                         12 : Always 
SELECT 2 As F_TBIndex, 4 As F_Order, 21 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, COALESCE(T7.F_ID, 0) As F_ComID, 'T_APDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, T2.F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    T2.F_Amount As F_FDebit, 0 As F_FCredit, '112500' As F_GLNo,    -- 112500 - LOAN TO AGENT 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('21T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD T1 
    INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = CASE WHEN T2.F_Agent > 0 THEN T2.F_Agent ELSE T1.F_Agent END) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType = 12 And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
 
UNION ALL 
 
 
-- 21/5    VAT : X                            VAT                                      If Vat Amount is not zero. 
SELECT 2 As F_TBIndex, 5 As F_Order, 21 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APHD' As F_STBName, T1.F_ID As F_STBID, 'VAT' + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    'OK' As F_BillCode, dbo.uf_Slip_GetHeadSubCode(T1.F_ID) As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    (CASE WHEN T2.F_Amount = 0 THEN 0 ELSE ROUND(T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount), 2) END) As F_FDebit, 0 As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_VATRCVGL', '')  As F_GLNo, 
    T2.F_VatAmount As F_Debit, 0 As F_Credit, 
    ('21T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD As T1 
    INNER JOIN ( 
        SELECT T2.F_ApHDID, SUM(T2.F_VatAmount) As F_VatAmount, SUM(T2.F_LAmount) As F_LAmount, SUM(T2.F_Amount) As F_Amount 
        FROM T_APHD T1 
            INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
        WHERE T2.F_ChgType Not In (18,38,20) 
        GROUP BY T2.F_ApHDID 
    ) T2 On (T2.F_ApHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_VatAmount <> 0 
 
UNION ALL 
 
-- 21/6    X : Adv.Pay                        Advance Payment                          If used Advance Payment in bill 
SELECT 2 As F_TBIndex, 6 As F_Order, 21 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APHD' As F_STBName, T1.F_ID As F_STBID, (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN 'G.Bill No: ' ELSE 'Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) As F_MDesc, 
    'OK' As F_BillCode, dbo.uf_Slip_GetHeadSubCode(T1.F_ID) As F_SubCode, T1.F_Currency, 1 As F_ExRate, 
    0 As F_FDebit, T1.F_AdvRecAmount As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_ADVPAY', '') As F_GLNo, 
    0 As F_Debit, T1.F_AdvRecAmount As F_Credit, 
    ('21T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD As T1 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T1.F_UseAdvRec = 1 And T1.F_AdvRecAmount <> 0 
 
UNION ALL 
 
-- 21/7    A/R : X                            Advance Payment A/P                      If used Advance Payment in bill 
SELECT 2 As F_TBIndex, 7 As F_Order, 21 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APHD' As F_STBName, T1.F_ID As F_STBID, (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN 'G.Bill No: ' ELSE 'Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) As F_MDesc, 
    'OK' As F_BillCode, dbo.uf_Slip_GetHeadSubCode(T1.F_ID) As F_SubCode, T1.F_Currency, 1 As F_ExRate, 
    T1.F_AdvRecAmount As F_FDebit, 0 As F_FCredit, T1.F_PayGLNo As F_GLNo, 
    T1.F_AdvRecAmount As F_Debit, 0 As F_Credit, 
    ('21T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD As T1 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T1.F_UseAdvRec = 1 And T1.F_AdvRecAmount <> 0 
 
UNION ALL 
 
 
-- Duty ------------------------------------------------------------------------------------------------------------------------------------------------ 
-- 21/8    X : D/P                            D/P                                                       18,20 : Always 
-- 21/9    Duty : X                           18 - Duty2Agent (Agt), 20 - Duty2Customer (Customer)      18,20 : Always 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 21/8    X : D/P                            D/P                                                       18,20 : Always 
SELECT 2 As F_TBIndex, 8 As F_Order, 21 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APHD' As F_STBName, T1.F_ID As F_STBID, 'DUTY' + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')'  As F_MDesc, 
    'OK' As F_BillCode, dbo.uf_Slip_GetHeadSubCode(T1.F_ID) As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    0 As F_FDebit, T2.F_Amount As F_FCredit, '212600' As F_GLNo,        -- 212600 - DUTY PAYABLE 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('21T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD T1 
    INNER JOIN ( 
        SELECT T2.F_ApHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_APHD T1 
            INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
        WHERE T2.F_ChgType In (18,20) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_ApHDID 
    ) T2 On (T2.F_ApHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
 
UNION ALL 
 
-- 21/9    Duty : X                           18 - Duty2Agent (Agt), 20 - Duty2Customer (Customer)      18,20 : Always 
SELECT 2 As F_TBIndex, 9 As F_Order, 21 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, (CASE WHEN T2.F_ChgType = 18 THEN T1.F_DutyAgent ELSE T1.F_DutyEntity END) As F_ComID, 'T_APDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, T2.F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    T2.F_Amount As F_FDebit, 0 As F_FCredit, (CASE T2.F_ChgType WHEN 20 THEN '212630' ELSE '112630' END) As F_GLNo,     -- 212630 - ADVANCE DUTY RECEIVED (CUSTOMER), 112630 - ADVANCE DUTY PAYMENT (AGENT) 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('21T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD T1 
    INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = CASE WHEN T2.F_ChgType = 18 THEN T1.F_DutyAgent ELSE T1.F_DutyEntity END) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType In (18,20) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
 
UNION ALL 
 
 
-- Finalized ------------------------------------------------------------------------------------------------------------------------------------------- 
-- 23/1    X : D.Cost                         Deferred Cost                            11,13,14 : Finalized & Inv.Date <= Final.Date 
-- 23/2    Cost : X                           Cost                                     11,13,14 : Finalized & Inv.Date <= Final.Date 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 23/1    X : D.Cost                         Deferred Cost                            11,13,14 : Finalized & Inv.Date <= Final.Date 
--SELECT 2 As F_TBIndex, 1 As F_Order, 23 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, 
SELECT 2 As F_TBIndex, 1 As F_Order, 23 As F_TBType, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmedBy ELSE T1.F_U2ID END) As F_U2ID, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmActionDate ELSE T1.F_U2Date END) As F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T8.F_ConfirmDate As F_InvoiceDate, T8.F_ConfirmDate As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, T2.F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    0 As F_FDebit, T2.F_Amount As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') As F_GLNo, 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('23T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD T1 
    INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType Not In (12,18,19,20) And DATEDIFF(DAY, T8.F_ConfirmDate, T1.F_InvoiceDate) <= 0 And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
    And SUBSTRING(T2.F_BillingCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
-- 23/2    Cost : X                           Cost                                     11,13,14 : Finalized & Inv.Date <= Final.Date 
--SELECT 2 As F_TBIndex, 2 As F_Order, 23 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, 
SELECT 2 As F_TBIndex, 2 As F_Order, 23 As F_TBType, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmedBy ELSE T1.F_U2ID END) As F_U2ID, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmActionDate ELSE T1.F_U2Date END) As F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, T8.F_ConfirmDate As F_InvoiceDate, T8.F_ConfirmDate As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, T2.F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    T2.F_Amount As F_FDebit, 0 As F_FCredit, (CASE T2.F_ChgType WHEN 13 THEN T6.F_Cost3 WHEN 14 THEN T6.F_Cost5 ELSE T6.F_Cost1 END) As F_GLNo, 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('23T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD T1 
    INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
    LEFT JOIN T_NCODECHARGE T6 On (T6.F_Code = T2.F_BillingCode) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType Not In (12,18,19,20) And DATEDIFF(DAY, T8.F_ConfirmDate, T1.F_InvoiceDate) <= 0 And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
    And SUBSTRING(T2.F_BillingCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
 
-- Use Advance Payment in Payment ---------------------------------------------------------------------------------------------------------------------- 
-- 25/1    X : Adv.Pay                        Advance Payment                          If used this bill as Advance Payment in Payment 
-- 25/2    A/P : X                            A/P                                      If used this bill as Advance Payment in Payment 
-- 26/1    X : A/P                            Void - A/P                               If used this bill as Advance Payment in Payment & Void 
-- 26/2    Adv.Pay : X                        Void - Advance Payment                   If used this bill as Advance Payment in Payment & Void 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 25/1    X : Adv.Pay                        Advance Payment                          If used this bill as Advance Payment in Payment 
SELECT 2 As F_TBIndex, 1 As F_Order, 25 As F_TBType, T3.F_PayUser As F_U2ID, T3.F_PayDate As F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch,  T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APHD' As F_STBName, T1.F_ID As F_STBID, 'Advance Payment' + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    'OK' As F_BillCode, dbo.uf_Slip_GetHeadSubCode(T1.F_ID) As F_SubCode, T1.F_Currency, (CASE WHEN T2.F_Amount = 0 THEN 1 ELSE ROUND(T2.F_LAmount/T2.F_Amount, 4) END) As F_ExRate, 
    0 As F_FDebit, T3.FPaidAmt As F_FCredit, T3.F_GLNo As F_GLNo, 
    0 As F_Debit, T3.PaidAmt As F_Credit, 
    ('25T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD As T1 
    INNER JOIN ( 
        SELECT T2.F_ApHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_APHD T1 
            INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
        --WHERE T2.F_ChgType Not In (18,38,20) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        WHERE T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_ApHDID 
    ) T2 On (T2.F_ApHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, T2.F_U2ID As F_PayUser, T2.F_U2Date As F_PayDate, 
            ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_APHD' And ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo Not In (T1.F_PayGLNo, '212600') And (T3.F_VoidDate Is Null Or DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0)  -- '212600' - DUTY PAYBALE 
 
UNION ALL 
 
-- 25/2    A/P : X                            A/P                                      If used this bill as Advance Payment in Payment 
SELECT 2 As F_TBIndex, 2 As F_Order, 25 As F_TBType, T3.F_PayUser As F_U2ID, T3.F_PayDate As F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch,  T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APHD' As F_STBName, T1.F_ID As F_STBID, 'Advance Payment' + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    'OK' As F_BillCode, dbo.uf_Slip_GetHeadSubCode(T1.F_ID) As F_SubCode, T1.F_Currency, (CASE WHEN T2.F_Amount = 0 THEN 1 ELSE ROUND(T2.F_LAmount/T2.F_Amount, 4) END) As F_ExRate, 
    T3.FPaidAmt As F_FDebit, 0 As F_FCredit, 
    --T1.F_PayGLNo As F_GLNo, 
    (CASE WHEN T3.F_PayType = 'DT' THEN '212600' ELSE T1.F_PayGLNo END) As F_GLNo, 
    T3.PaidAmt As F_Debit, 0 As F_Credit, 
    ('25T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD As T1 
    INNER JOIN ( 
        SELECT T2.F_ApHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_APHD T1 
            INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
        --WHERE T2.F_ChgType Not In (18,38,20) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        WHERE T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_ApHDID 
    ) T2 On (T2.F_ApHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, T2.F_U2ID As F_PayUser, T2.F_U2Date As F_PayDate, 
            ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_APHD' And ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo Not In (T1.F_PayGLNo, '212600') And (T3.F_VoidDate Is Null Or DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0)  -- '212600' - DUTY PAYBALE 
 
UNION ALL 
 
-- 26/1    X : A/P                            Void - A/P                               If used this bill as Advance Payment in Payment & Void 
SELECT 2 As F_TBIndex, 1 As F_Order, 26 As F_TBType, T3.F_VoidInPutID As F_U2ID, T3.F_VoidInPutDate As F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, 
    T3.F_VoidDate As F_InvoiceDate, (CASE WHEN DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) > 0 THEN T1.F_InvoiceDate ELSE T3.F_VoidDate END) As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APHD' As F_STBName, T1.F_ID As F_STBID, 'Void Advance Payment' + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    'OK' As F_BillCode, dbo.uf_Slip_GetHeadSubCode(T1.F_ID) As F_SubCode, T1.F_Currency, (CASE WHEN T2.F_Amount = 0 THEN 1 ELSE ROUND(T2.F_LAmount/T2.F_Amount, 4) END) As F_ExRate, 
    0 As F_FDebit, T3.FPaidAmt As F_FCredit, 
    --T1.F_PayGLNo As F_GLNo, 
    (CASE WHEN T3.F_PayType = 'DT' THEN '212600' ELSE T1.F_PayGLNo END) As F_GLNo, 
    0 As F_Debit, T3.PaidAmt As F_Credit, 
    ('26T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD As T1 
    INNER JOIN ( 
        SELECT T2.F_ApHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_APHD T1 
            INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
        --WHERE T2.F_ChgType Not In (18,38,20) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        WHERE T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_ApHDID 
    ) T2 On (T2.F_ApHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, (CASE WHEN LEN(T2.F_VoidinPutID) > 0 THEN T2.F_VoidinPutID ELSE T2.F_U2ID END) As F_VoidinPutID, COALESCE(T2.F_VoidinPutDate, T2.F_U2Date) As F_VoidinPutDate, 
            ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_APHD' And T2.F_Void = '1' And ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo Not In (T1.F_PayGLNo, '212600') And DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0 -- '212600' - DUTY PAYBALE 
 
UNION ALL 
 
-- 26/2    Adv.Pay : X                        Void - Advance Payment                   If used this bill as Advance Payment in Payment & Void 
SELECT 2 As F_TBIndex, 2 As F_Order, 26 As F_TBType, T3.F_VoidInPutID As F_U2ID, T3.F_VoidInPutDate As F_U2Date, 'T_APHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(T8.F_Branch, T1.F_ApBranch) As F_Branch, 
    T3.F_VoidDate As F_InvoiceDate, (CASE WHEN DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) > 0 THEN T1.F_InvoiceDate ELSE T3.F_VoidDate END) As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_PayTo As F_ComID, 'T_APHD' As F_STBName, T1.F_ID As F_STBID, 'Void Advance Payment' + (CASE WHEN T1.F_TBName = '' And (T1.F_JobName = '' or T1.F_JobName = 'ECLM') THEN ' (G.Bill No: ' ELSE ' (Bill No: ' END) + (CASE T1.F_InvoiceNo WHEN '' THEN 'N/A' ELSE T1.F_InvoiceNo END) + ')' As F_MDesc, 
    'OK' As F_BillCode, dbo.uf_Slip_GetHeadSubCode(T1.F_ID) As F_SubCode, T1.F_Currency, (CASE WHEN T2.F_Amount = 0 THEN 1 ELSE ROUND(T2.F_LAmount/T2.F_Amount, 4) END) As F_ExRate, 
    T3.FPaidAmt As F_FDebit, 0 As F_FCredit, T3.F_GLNo As F_GLNo, 
    T3.PaidAmt As F_Debit, 0 As F_Credit, 
    ('26T_APHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, T1.F_ApBranch)) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_APHD As T1 
    INNER JOIN ( 
        SELECT T2.F_ApHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_APHD T1 
            INNER JOIN T_APDETAIL T2 On (T2.F_ApHDID = T1.F_ID) 
        --WHERE T2.F_ChgType Not In (18,20) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        WHERE T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_ApHDID 
    ) T2 On (T2.F_ApHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, (CASE WHEN LEN(T2.F_VoidinPutID) > 0 THEN T2.F_VoidinPutID ELSE T2.F_U2ID END) As F_VoidinPutID, COALESCE(T2.F_VoidinPutDate, T2.F_U2Date) As F_VoidinPutDate, 
            ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_APHD' And T2.F_Void = '1' And ROUND(CASE WHEN F_Type In ('C','M') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_PayTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo Not In (T1.F_PayGLNo, '212600') And DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0 -- '212600' - DUTY PAYBALE 
 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 

DROP TABLE #T_TEMP_BLSUMM; 
 
END
" },
            { "up_ChangeGLNo" ,
                @"
create  procedure   up_ChangeGLNo 
            @FromGLNo           varchar(20), 
            @ToGLNo             varchar(20) 
As 
 
BEGIN 
 
update T1 Set F_RcvGLNo = @ToGLNo from T_INVOHD T1 where F_RcvGLNo = @FromGLNo 
update T1 Set F_VatGLNo = @ToGLNo from T_INVODetail T1 where F_VatGLNo = @FromGLNo 
update T1 Set F_PayGLNo = @ToGLNo from T_APHD T1 where F_PayGLNo = @FromGLNo 
update T1 Set F_VatGLNo = @ToGLNo from T_APDetail T1 where F_VatGLNo = @FromGLNo 
 
update T1 Set F_Sales1 = @ToGLNo from T_NCODECHARGE T1 where F_Sales1 = @FromGLNo 
update T1 Set F_Sales2 = @ToGLNo from T_NCODECHARGE T1 where F_Sales2 = @FromGLNo 
update T1 Set F_Sales3 = @ToGLNo from T_NCODECHARGE T1 where F_Sales3 = @FromGLNo 
update T1 Set F_Sales4 = @ToGLNo from T_NCODECHARGE T1 where F_Sales4 = @FromGLNo 
update T1 Set F_Sales5 = @ToGLNo from T_NCODECHARGE T1 where F_Sales5 = @FromGLNo 
update T1 Set F_Cost1 = @ToGLNo from T_NCODECHARGE T1 where F_Cost1 = @FromGLNo 
update T1 Set F_Cost2 = @ToGLNo from T_NCODECHARGE T1 where F_Cost2 = @FromGLNo 
update T1 Set F_Cost3 = @ToGLNo from T_NCODECHARGE T1 where F_Cost3 = @FromGLNo 
update T1 Set F_Cost4 = @ToGLNo from T_NCODECHARGE T1 where F_Cost4 = @FromGLNo 
update T1 Set F_Cost5 = @ToGLNo from T_NCODECHARGE T1 where F_Cost5 = @FromGLNo 
 
update T1 Set F_GLNo = @ToGLNo from T_DEPODETAIL T1 where F_GLNo = @FromGLNo 
update T1 Set F_GLNo = @ToGLNo from T_SlipDetail T1 where F_GLNo = @FromGLNo 
update T1 Set F_GLNo = @ToGLNo from T_NEWJOUR T1 where F_GLNo = @FromGLNo 
update T1 Set F_GLNo = @ToGLNo from T_NEWJOURB T1 where F_GLNo = @FromGLNo 
update T1 Set F_GLNo = @ToGLNo from T_CODEBANK T1 where F_GLNo = @FromGLNo 
update T1 Set F_RGLNo = @ToGLNo from T_CODEBANK T1 where F_RGLNo = @FromGLNo 
update T1 Set F_PGLNo = @ToGLNo from T_CODEBANK T1 where F_PGLNo = @FromGLNo 
update T1 Set F_Value = @ToGLNo from T_SETTINGS T1 where F_Value = @FromGLNo 
 
END 
" },
            { "up_CrDbExJourM" ,
                @"
CREATE PROCEDURE up_CrDbExJourM 
            @MTBName            VARCHAR(20), 
            @MBLId              INT 
AS 
 
BEGIN 
 
-- Make Temporary Table for V_BLSUMM 
SELECT * INTO #T_TEMP_BLSUMM FROM V_BLSUMM WHERE F_MTBName = @MTBName And F_MBLID = @MBLId; 
 
 
 
-- Table Prefix ------------------------------------- 
-- T1 : T_INVOHD 
-- T2 : T_INVODETAIL Or SUB QUERY FOR INVODETAIL 
-- T3 : Same Billing Code 
-- T5 : T_OPACCT 
-- T6 : T_NCODECHARGE 
-- T7 : T_COMPANY (Customer) 
-- T8 : V_BLSUMM 
----------------------------------------------------- 
-- Used Account Code  ------------------------------- 
-- D/R Agent           : 112620 - DUTY AR AGENT 
-- D/P Agent           : 212620 - DUTY AP AGENT 
-- Duty2Customer       : 212630 - ADVANCE DUTY RECEIVED (CUSTOMER) 
-- Duty2Agent          : 112630 - ADVANCE DUTY PAYMENT (AGENT) 
-- Collect4Agt         : 212500 - COLLECT SALES FOR AGENT 
-- Loan2Agt            : 112500 - LOAN TO AGENT 
----------------------------------------------------- 
 
 
-- Sales & Cost --------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
-- 31/1    A/R Agent : X                      A/R Agent                                12,13,14,5,6,PS : Always & Debit Total <> 0 
-- 31/2    X : D.Sales                        Deferred Sales                           5,6,13,14,PS : Not Finalized  Or (Finalized  & CR/DB Date <= Final.Date) 
-- 31/3    X : Sales                          Sales                                    5,6,13,14,PS : Finalized  & Final.Date < CR/DB Date 
-- 31/4    X : Loan2Agt                       Loan2Agt                                 12 : Always 
-- 31/5    D.Cost : X                         Deferred Cost                            3,4,15,16,PS : Not Finalized  Or (Finalized  & CR/DB Date <= Final.Date) 
-- 31/6    Cost : X                           Cost                                     3,4,15,16,PS : Finalized  & Final.Date < CR/DB Date 
-- 31/7    Collect4Agt : X                    Collect4Agt                              2 : Always 
-- 31/8    X : A/P Agent                      A/P Agent                                2,3,4,15,16,PS : Always & Credit Total <> 0 
-- Duty ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
-- 31/9    D/R Agent : X                      D/R Agent                                8 : Always 
-- 31/10   X : Duty2Agent                     Duty2Agent (Agt)                         8 : Always 
-- 31/11   Duty2Customer : X                  Duty2Customer (Customer)                 40 : Always 
-- 31/12   X : D/P Agent                      D/P Agent                                40 : Always 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- Finalized ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
-- 33/1    D.Sales : X                        Deferred Sales                           5,6,13,14,PS : Finalized & CR/DB Date <= Final.Date 
-- 33/2    X : Sales                          Sales                                    5,6,13,14,PS : Finalized & CR/DB Date <= Final.Date 
-- 33/3    Cost : X                           Cost                                     3,4,15,16,PS : Finalized & CR/DB Date <= Final.Date 
-- 33/4    X : D.Cost                         Deferred Cost                            3,4,15,16,PS : Finalized & CR/DB Date <= Final.Date 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
 
-- Use Advance Received in Payment -------------------------------------------------------------------------------------------------------------------------------------------------- 
-- 35/1(3) Adv.Rcv : X   or  X / Adv.Pay      Advance Received / Advance Payment       If used this invoice as Advance Received(Payment) in Payment 
-- 35/2(4) X : A/R Agent or A/P Agent : X     A/R Agent / A/P Agent                    If used this invoice as Advance Received(Payment) in Payment 
-- 36/1(3) A/R Agent : X or X : A/P Agent     A/R Agent / A/P Agent                    If used this invoice as Advance Received(Payment) in Payment & Void 
-- 36/2(4) X : Adv.Rcv   or Adv.Pay : X       Advance Received / Advance Payment       If used this invoice as Advance Received(Payment) in Payment & Void 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
 
-- 2019-01-30 chuck     : Support GST,HST,PST BillingCode. It will not make Deferred Sales/Cost Account Code 
-- 2019-02-22 chuck     : Use Finalize Action Date when make finalize journal. 
-- 2019-04-01 chuck     : Add F_RTBID for sub key Id 
-- 2019-04-16 chuck     : Support Advance Received/Payment 
-- 2020-02-18 chuck     : Use F_DutyEntity of T_CRDBDETAIL instead of B/L DutyCustomer for Duty Customer (40).
-- 2020-08-05 chuck     : Use F_DutyEntity of T_CRDBDETAIL instead of Header Agent for Duty Agent (8).
 
 
-- 31/1    A/R Agent : X                      A/R     Agent                            12,13,14,5,6,PS : Always & Debit Total <> 0 
SELECT 7 As F_TBIndex, 1 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBHD' As F_STBName, T1.F_ID As F_STBID, 'CrDb No: ' + T1.F_CRDBNO As F_MDesc, 
    'Ok' As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    T2.F_FDebit As F_FDebit, 0 As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_AgentGLNo', '') As F_GLNo, 
    T2.F_Debit As F_Debit, 0 As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    INNER JOIN ( 
        SELECT F_CrDbHDID, SUM(F_Debit) As F_FDebit, SUM(CASE WHEN F_Debit <> 0 THEN F_LAmount ELSE 0 END) As F_Debit 
        FROM T_CRDBDETAIL 
        WHERE F_Debit <> 0 And F_ChgType Not In (8,40) 
        GROUP BY F_CrDbHDID 
    ) T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Debit <> 0 
 
UNION ALL 
 
-- 31/2    X : D.Sales                        Deferred Sales                           5,6,PS : Not Finalized Or (Finalized & CR/DB Date <= Final.Date), 13,14: Always 
SELECT 7 As F_TBIndex, 2 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    0 As F_FDebit, T2.F_Debit As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') As F_GLNo, 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Debit <> 0 And T2.F_LAmount <> 0 And T2.F_ChgType In (5,6,13,14,0) And (T8.F_ConfirmDate IS NULL Or DATEDIFF(DAY, T1.F_PostDate, T8.F_ConfirmDate) >= 0) 
    And SUBSTRING(T2.F_CrDbCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
-- 31/3    X : Sales                          Sales                                    5,6,PS : Finalized & Final.Date < CR/DB Date 
SELECT 7 As F_TBIndex, 3 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    0 As F_FDebit, T2.F_Debit As F_FCredit, (CASE T2.F_ChgType WHEN 13 THEN T6.F_Sales3 WHEN 14 THEN T6.F_Sales5 ELSE (CASE WHEN COALESCE(T4.F_ShipmentType, T8.F_ShipmentType) = 'I' THEN T6.F_Sales3 ELSE T6.F_Sales1 END) END) As F_GLNo, 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_OPACCT T3 On (T3.F_ID = T2.F_STBID And T2.F_STBName = 'T_OPACCT') 
    LEFT JOIN #T_TEMP_BLSUMM T4 On (T4.F_TBID = T3.F_TBID And T4.F_TBName = T3.F_TBName) 
    LEFT JOIN T_NCODECHARGE T6 On (T6.F_Code = T2.F_CRDBCode) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Debit <> 0 And T2.F_LAmount <> 0 And T2.F_ChgType In (5,6,13,14,0) 
    And (DATEDIFF(DAY, T1.F_PostDate, T8.F_ConfirmDate) < 0 Or SUBSTRING(T2.F_CrDbCode, 1, 3) In ('GST','HST','PST','IVA')) 
 
UNION ALL 
 
-- 31/4    X : Loan2Agt                       Loan2Agt                                 12 : Always 
SELECT 7 As F_TBIndex, 4 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    0 As F_FDebit, T2.F_Debit As F_FCredit, '112500' As F_GLNo,         -- 112500 - LOAN TO AGENT 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Debit <> 0 And T2.F_LAmount <> 0 And T2.F_ChgType = 12 
 
UNION ALL 
 
-- 31/5    D.Cost : X                         Deferred Cost                            15,16,PS : Not Finalized Or (Finalized & CR/DB Date <= Final.Date), 3,4: Always 
SELECT 7 As F_TBIndex, 5 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
   'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    T2.F_Credit As F_FDebit, 0 As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') As F_GLNo, 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Credit <> 0 And T2.F_LAmount <> 0 And T2.F_ChgType In (3,4,15,16,0) And (T8.F_ConfirmDate IS NULL Or DATEDIFF(DAY, T1.F_PostDate, T8.F_ConfirmDate) >= 0) 
    And SUBSTRING(T2.F_CrDbCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
-- 31/6    Cost : X                           Cost                                     15,16,PS : Finalized & Final.Date < CR/DB Date 
SELECT 7 As F_TBIndex, 6 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    T2.F_Credit As F_FDebit, 0 As F_FCredit, (CASE T2.F_ChgType WHEN 3 THEN T6.F_Cost3 WHEN 4 THEN T6.F_Cost5 ELSE (CASE WHEN COALESCE(T4.F_ShipmentType, T8.F_ShipmentType) = 'I' THEN T6.F_Cost3 ELSE T6.F_Cost1 END) END) As F_GLNo, 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_OPACCT T3 On (T3.F_ID = T2.F_STBID And T2.F_STBName = 'T_OPACCT') 
    LEFT JOIN #T_TEMP_BLSUMM T4 On (T4.F_TBID = T3.F_TBID And T4.F_TBName = T3.F_TBName) 
    LEFT JOIN T_NCODECHARGE T6 On (T6.F_Code = T2.F_CRDBCode) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Credit <> 0 And T2.F_LAmount <> 0 And T2.F_ChgType In (3,4,15,16,0) 
    And (DATEDIFF(DAY, T1.F_PostDate, T8.F_ConfirmDate) < 0 Or SUBSTRING(T2.F_CrDbCode, 1, 3) In ('GST','HST','PST','IVA')) 
 
UNION ALL 
 
-- 31/7    Collect4Agt : X                    Collect4Agt                              2 : Always 
SELECT 7 As F_TBIndex, 7 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    T2.F_Credit As F_FDebit, 0 As F_FCredit, '212500' As F_GLNo,            -- 212500 - COLLECT SALES FOR AGENT 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Credit <> 0 And T2.F_LAmount <> 0 And T2.F_ChgType = 2 
 
UNION ALL 
 
-- 31/8    X : A/P Agent                      A/P     Agent                            2,3,4,15,16,PS : Always & Credit Total <> 0 
SELECT 7 As F_TBIndex, 8 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBHD' As F_STBName, T1.F_ID As F_STBID, 'CrDb No: ' + T1.F_CRDBNO As F_MDesc, 
    'Ok' As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    0 As F_FDebit, T2.F_FCredit As F_FCredit, dbo.uf_Slip_GetFixedGLNo('AgentAPGLNo', '') As F_GLNo, 
    0 As F_Debit, T2.F_Credit As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    INNER JOIN ( 
        SELECT F_CrDbHDID, SUM(F_Credit) As F_FCredit, SUM(CASE WHEN F_Credit <> 0 THEN F_LAmount ELSE 0 END) As F_Credit 
        FROM T_CRDBDETAIL 
        WHERE F_Credit <> 0 And F_ChgType Not In (8,40) 
        GROUP BY F_CrDbHDID 
    ) T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Credit <> 0 
 
UNION ALL 
 
 
-- Duty ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
-- 31/9    D/R Agent : X                      D/R Agent                                8 : Always 
-- 31/10   X : Duty2Agent                     Duty2Agent (Agt)                         8 : Always 
-- 31/11   Duty2Customer : X                  Duty2Customer (Customer)                 40 : Always 
-- 31/12   X : D/P Agent                      D/P Agent                                40 : Always 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 31/9    D/R Agent : X                      D/R Agent                                8 : Always 
SELECT 7 As F_TBIndex, 9 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBHD' As F_STBName, T1.F_ID As F_STBID, 'DUTY (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    'Ok' As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    T2.F_FDebit As F_FDebit, 0 As F_FCredit, '112620' As F_GLNo,     -- 112620 - DUTY AR AGENT 
    T2.F_Debit As F_Debit, 0 As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    INNER JOIN ( 
        SELECT F_CrDbHDID, SUM(F_Debit) As F_FDebit, SUM(CASE WHEN F_Debit <> 0 THEN F_LAmount ELSE 0 END) As F_Debit 
        FROM T_CRDBDETAIL 
        WHERE F_Debit <> 0 And F_ChgType = 8 
        GROUP BY F_CrDbHDID 
    ) T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Debit <> 0 
 
UNION ALL 
 
-- 31/10   X : Duty2Agent                     Duty2Agent (Agt)                         8 : Always 
SELECT 7 As F_TBIndex, 10 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T2.F_DutyEntity As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    0 As F_FDebit, T2.F_Debit As F_FCredit, '112630' As F_GLNo,         -- 112630 - ADVANCE DUTY PAYMENT (AGENT) 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T2.F_DutyEntity) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Debit <> 0 And T2.F_LAmount <> 0 And T2.F_ChgType = 8 
 
UNION ALL 
 
-- 31/11   Duty2Customer : X                  Duty2Customer (Customer)                 40 : Always 
SELECT 7 As F_TBIndex, 11 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T2.F_DutyEntity As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    T2.F_Credit As F_FDebit, 0 As F_FCredit, '212630' As F_GLNo,            -- 212630 - ADVANCE DUTY RECEIVED (CUSTOMER) 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_OPACCT T5 On (T5.F_ID = T2.F_STBID And T2.F_STBName = 'T_OPACCT') 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T2.F_DutyEntity) 
WHERE T2.F_Credit <> 0 And T2.F_LAmount <> 0 And T2.F_ChgType = 40 
 
UNION ALL 
 
-- 31/12   X : D/P Agent                      D/P Agent                                40 : Always 
SELECT 7 As F_TBIndex, 12 As F_Order, 31 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBHD' As F_STBName, T1.F_ID As F_STBID, 'DUTY (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    'Ok' As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    0 As F_FDebit, T2.F_FCredit As F_FCredit, '212620' As F_GLNo, -- 212620 - DUTY AP AGENT 
    0 As F_Debit, T2.F_Credit As F_Credit, 
    ('31T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    INNER JOIN ( 
        SELECT F_CrDbHDID, SUM(F_Credit) As F_FCredit, SUM(CASE WHEN F_Credit <> 0 THEN F_LAmount ELSE 0 END) As F_Credit 
        FROM T_CRDBDETAIL 
        WHERE F_Credit <> 0 And F_ChgType = 40 
        GROUP BY F_CrDbHDID 
    ) T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Credit <> 0 
 
 
UNION ALL 
 
 
-- Finalized ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
-- 33/1    D.Sales : X                        Deferred Sales                           5,6,13,14,PS : Finalized & CR/DB Date <= Final.Date 
-- 33/2    X : Sales                          Sales                                    5,6,13,14,PS : Finalized & CR/DB Date <= Final.Date 
-- 33/3    Cost : X                           Cost                                     3,4,15,16,PS : Finalized & CR/DB Date <= Final.Date 
-- 33/4    X : D.Cost                         Deferred Cost                            3,4,15,16,PS : Finalized & CR/DB Date <= Final.Date 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 33/1    D.Sales : X                        Deferred Sales                           5,6,13,14,PS : Finalized & CR/DB Date <= Final.Date 
SELECT 7 As F_TBIndex, 1 As F_Order, 33 As F_TBType, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmedBy ELSE T1.F_U2ID END) As F_U2ID, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmActionDate ELSE T1.F_U2Date END) As F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, '') As F_Branch, T8.F_ConfirmDate As F_InvoiceDate, T8.F_ConfirmDate As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    T2.F_Debit As F_FDebit, 0 As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') As F_GLNo, 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('33T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Debit <> 0 And T2.F_LAmount <> 0 And T8.F_ConfirmDate Is Not Null And DATEDIFF(DAY, T1.F_PostDate, T8.F_ConfirmDate) >= 0 
    And T2.F_ChgType In (5,6,13,14,0) And SUBSTRING(T2.F_CrDbCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
-- 33/2    X : Sales                          Sales                                    5,6,13,14,PS : Finalized & CR/DB Date <= Final.Date 
SELECT 7 As F_TBIndex, 2 As F_Order, 33 As F_TBType, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmedBy ELSE T1.F_U2ID END) As F_U2ID, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmActionDate ELSE T1.F_U2Date END) As F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, '') As F_Branch, T8.F_ConfirmDate As F_InvoiceDate, T8.F_ConfirmDate As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    0 As F_FDebit, T2.F_Debit As F_FCredit, (CASE T2.F_ChgType WHEN 13 THEN T6.F_Sales3 WHEN 14 THEN T6.F_Sales5 ELSE (CASE WHEN COALESCE(T4.F_ShipmentType, T8.F_ShipmentType) = 'I' THEN T6.F_Sales3 ELSE T6.F_Sales1 END) END) As F_GLNo, 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('33T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_OPACCT T3 On (T3.F_ID = T2.F_STBID And T2.F_STBName = 'T_OPACCT') 
    LEFT JOIN #T_TEMP_BLSUMM T4 On (T4.F_TBID = T3.F_TBID And T4.F_TBName = T3.F_TBName) 
    LEFT JOIN T_NCODECHARGE T6 On (T6.F_Code = T2.F_CRDBCode) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Debit <> 0 And T2.F_LAmount <> 0 And T8.F_ConfirmDate Is Not Null And DATEDIFF(DAY, T1.F_PostDate, T8.F_ConfirmDate) >= 0 
    And T2.F_ChgType In (5,6,13,14,0) And SUBSTRING(T2.F_CrDbCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
-- 33/3    Cost : X                           Cost                                     3,4,15,16,PS : Finalized & CR/DB Date <= Final.Date 
SELECT 7 As F_TBIndex, 3 As F_Order, 33 As F_TBType, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmedBy ELSE T1.F_U2ID END) As F_U2ID, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmActionDate ELSE T1.F_U2Date END) As F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, '') As F_Branch, T8.F_ConfirmDate As F_InvoiceDate, T8.F_ConfirmDate As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    T2.F_Credit As F_FDebit, 0 As F_FCredit, (CASE T2.F_ChgType WHEN 3 THEN T6.F_Cost3 WHEN 4 THEN T6.F_Cost5 ELSE (CASE WHEN COALESCE(T4.F_ShipmentType, T8.F_ShipmentType) = 'I' THEN T6.F_Cost3 ELSE T6.F_Cost1 END) END) As F_GLNo, 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('33T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_OPACCT T3 On (T3.F_ID = T2.F_STBID And T2.F_STBName = 'T_OPACCT') 
    LEFT JOIN #T_TEMP_BLSUMM T4 On (T4.F_TBID = T3.F_TBID And T4.F_TBName = T3.F_TBName) 
    LEFT JOIN T_NCODECHARGE T6 On (T6.F_Code = T2.F_CRDBCode) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Credit <> 0 And T2.F_LAmount <> 0 And T8.F_ConfirmDate Is Not Null And DATEDIFF(DAY, T1.F_PostDate, T8.F_ConfirmDate) >= 0 
    And T2.F_ChgType In (3,4,15,16,0) And SUBSTRING(T2.F_CrDbCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
-- 33/4    X : D.Cost                         Deferred Cost                            3,4,15,16,PS : Finalized & CR/DB Date <= Final.Date 
SELECT 7 As F_TBIndex, 4 As F_Order, 33 As F_TBType, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmedBy ELSE T1.F_U2ID END) As F_U2ID, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmActionDate ELSE T1.F_U2Date END) As F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(T8.F_Branch, '') As F_Branch, T8.F_ConfirmDate As F_InvoiceDate, T8.F_ConfirmDate As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBDETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    T2.F_CRDBCODE As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    0 As F_FDebit, T2.F_Credit As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_DefCost', '') As F_GLNo, 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('33T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    LEFT JOIN T_CRDBDETAIL T2 On (T2.F_CrDbHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_Credit <> 0 And T2.F_LAmount <> 0 And T8.F_ConfirmDate Is Not Null And DATEDIFF(DAY, T1.F_PostDate, T8.F_ConfirmDate) >= 0 
    And T2.F_ChgType In (3,4,15,16,0) And SUBSTRING(T2.F_CrDbCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
 
UNION ALL 
 
 
-- Use Advance Received in Payment -------------------------------------------------------------------------------------------------------------------------------------------------- 
-- 35/1(3) Adv.Rcv : X   or  X / Adv.Pay      Advance Received / Advance Payment       If used this invoice as Advance Received(Payment) in Payment 
-- 35/2(4) X : A/R Agent or A/P Agent : X     A/R Agent / A/P Agent                    If used this invoice as Advance Received(Payment) in Payment 
-- 36/1(3) A/R Agent : X or X : A/P Agent     A/R Agent / A/P Agent                    If used this invoice as Advance Received(Payment) in Payment & Void 
-- 36/2(4) X : Adv.Rcv   or Adv.Pay : X       Advance Received / Advance Payment       If used this invoice as Advance Received(Payment) in Payment & Void 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 35/1(3) Adv.Rcv : X   or  X / Adv.Pay      Advance Received / Advance Payment       If used this invoice as Advance Received(Payment) in Payment 
SELECT 7 As F_TBIndex, (CASE WHEN T3.F_GLNo = '212100' THEN 1 ELSE 3 END) As F_Order, 35 As F_TBType, T3.F_PayUser As F_U2ID, T3.F_PayDate As F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBHD' As F_STBName, T1.F_ID As F_STBID, 
    (CASE WHEN T3.F_GLNo = '212100' THEN 'Advance Received' ELSE 'Advance Payment' END) + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    'Ok' As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    (CASE WHEN T3.F_GLNo = '212100' THEN T3.FPaidAmt ELSE 0 END) As F_FDebit, (CASE WHEN T3.F_GLNo = '212100' THEN 0 ELSE T3.FPaidAmt END) As F_FCredit, T3.F_GLNo As F_GLNo, 
    (CASE WHEN T3.F_GLNo = '212100' THEN T3.PaidAmt ELSE 0 END) As F_Debit, (CASE WHEN T3.F_GLNo = '212100' THEN 0 ELSE T3.PaidAmt END) As F_Credit, 
    ('35T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    INNER JOIN ( 
        SELECT F_CrDbHDID, SUM(CASE WHEN F_ChgType = 8 THEN 0 ELSE F_Debit END) As F_Debit, SUM(CASE WHEN F_ChgType = 40 THEN 0 ELSE F_Credit END) As F_Credit, 
            SUM(CASE WHEN F_ChgType = 8 THEN F_Debit ELSE 0 END) As F_DutyDebit, SUM(CASE WHEN F_ChgType = 40 THEN F_Credit ELSE 0 END) As F_DutyCredit 
        FROM T_CRDBDETAIL 
        WHERE F_Debit <> 0 Or F_Credit <> 0 
        GROUP BY F_CrDbHDID 
    ) T2 On (T2.F_CrDbHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, T2.F_U2ID As F_PayUser, T2.F_U2Date As F_PayDate, 
            ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_CRDBHD' And ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID And ((T2.F_Debit <> 0 And T3.F_PayType = 'DR') Or (T2.F_DutyDebit <> 0 And T3.F_PayType = 'D+') Or (T2.F_Credit <> 0 And T3.F_PayType = 'CR') Or (T2.F_DutyCredit <> 0 And T3.F_PayType = 'D-'))) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo In ('112100','212100') And (T3.F_VoidDate Is Null Or DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0) 
 
UNION ALL 
 
-- 35/2(4) X : A/R Agent or A/P Agent : X     A/R Agent / A/P Agent                    If used this invoice as Advance Received(Payment) in Payment 
SELECT 7 As F_TBIndex, (CASE WHEN T3.F_GLNo = '212100' THEN 2 ELSE 4 END) As F_Order, 35 As F_TBType, T3.F_PayUser As F_U2ID, T3.F_PayDate As F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(T8.F_Branch, '') As F_Branch, T1.F_PostDate As F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBHD' As F_STBName, T1.F_ID As F_STBID, 
    (CASE WHEN T3.F_GLNo = '212100' THEN 'Advance Received' ELSE 'Advance Payment' END) + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    'Ok' As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    (CASE WHEN T3.F_GLNo = '212100' THEN 0 ELSE T3.FPaidAmt END) As F_FDebit, (CASE WHEN T3.F_GLNo = '212100' THEN T3.FPaidAmt ELSE 0 END) As F_FCredit, 
    (CASE T3.F_PayType WHEN 'DR' THEN '111410' WHEN 'D+' THEN '112620' WHEN 'CR' THEN '211410' WHEN 'D-' THEN '212620' END) As F_GLNo, 
    (CASE WHEN T3.F_GLNo = '212100' THEN 0 ELSE T3.PaidAmt END) As F_Debit, (CASE WHEN T3.F_GLNo = '212100' THEN T3.PaidAmt ELSE 0 END) As F_Credit, 
    ('35T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    INNER JOIN ( 
        SELECT F_CrDbHDID, SUM(CASE WHEN F_ChgType = 8 THEN 0 ELSE F_Debit END) As F_Debit, SUM(CASE WHEN F_ChgType = 40 THEN 0 ELSE F_Credit END) As F_Credit, 
            SUM(CASE WHEN F_ChgType = 8 THEN F_Debit ELSE 0 END) As F_DutyDebit, SUM(CASE WHEN F_ChgType = 40 THEN F_Credit ELSE 0 END) As F_DutyCredit 
        FROM T_CRDBDETAIL 
        WHERE F_Debit <> 0 Or F_Credit <> 0 
        GROUP BY F_CrDbHDID 
    ) T2 On (T2.F_CrDbHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, T2.F_U2ID As F_PayUser, T2.F_U2Date As F_PayDate, 
            ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_CRDBHD' And ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID And ((T2.F_Debit <> 0 And T3.F_PayType = 'DR') Or (T2.F_DutyDebit <> 0 And T3.F_PayType = 'D+') Or (T2.F_Credit <> 0 And T3.F_PayType = 'CR') Or (T2.F_DutyCredit <> 0 And T3.F_PayType = 'D-'))) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo In ('112100','212100') And (T3.F_VoidDate Is Null Or DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0) 
 
UNION ALL 
 
-- 36/1(3) A/R Agent : X or X : A/P Agent     A/R Agent / A/P Agent                    If used this invoice as Advance Received(Payment) in Payment & Void 
SELECT 7 As F_TBIndex, (CASE WHEN T3.F_GLNo = '212100' THEN 1 ELSE 3 END) As F_Order, 36 As F_TBType, T3.F_VoidInPutID As F_U2ID, T3.F_VoidInPutDate As F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(T8.F_Branch, '') As F_Branch, T3.F_VoidDate As F_InvoiceDate, (CASE WHEN DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) > 0 THEN T1.F_InvoiceDate ELSE T3.F_VoidDate END) As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBHD' As F_STBName, T1.F_ID As F_STBID, 
    (CASE WHEN T3.F_GLNo = '212100' THEN 'Void Advance Received' ELSE 'Void Advance Payment' END) + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    'Ok' As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    (CASE WHEN T3.F_GLNo = '212100' THEN T3.FPaidAmt ELSE 0 END) As F_FDebit, (CASE WHEN T3.F_GLNo = '212100' THEN 0 ELSE T3.FPaidAmt END) As F_FCredit, 
    (CASE T3.F_PayType WHEN 'DR' THEN '111410' WHEN 'D+' THEN '112620' WHEN 'CR' THEN '211410' WHEN 'D-' THEN '212620' END) As F_GLNo, 
    (CASE WHEN T3.F_GLNo = '212100' THEN T3.PaidAmt ELSE 0 END) As F_Debit, (CASE WHEN T3.F_GLNo = '212100' THEN 0 ELSE T3.PaidAmt END) As F_Credit, 
    ('36T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    INNER JOIN ( 
        SELECT F_CrDbHDID, SUM(CASE WHEN F_ChgType =8 THEN 0 ELSE F_Debit END) As F_Debit, SUM(CASE WHEN F_ChgType = 40 THEN 0 ELSE F_Credit END) As F_Credit, 
            SUM(CASE WHEN F_ChgType = 8 THEN F_Debit ELSE 0 END) As F_DutyDebit, SUM(CASE WHEN F_ChgType = 40 THEN F_Credit ELSE 0 END) As F_DutyCredit 
        FROM T_CRDBDETAIL 
        WHERE F_Debit <> 0 Or F_Credit <> 0 
        GROUP BY F_CrDbHDID 
    ) T2 On (T2.F_CrDbHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, (CASE WHEN LEN(T2.F_VoidinPutID) > 0 THEN T2.F_VoidinPutID ELSE T2.F_U2ID END) As F_VoidinPutID, COALESCE(T2.F_VoidinPutDate, T2.F_U2Date) As F_VoidinPutDate, 
            ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_CRDBHD' And T2.F_Void = '1' And ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID And ((T2.F_Debit <> 0 And T3.F_PayType = 'DR') Or (T2.F_DutyDebit <> 0 And T3.F_PayType = 'D+') Or (T2.F_Credit <> 0 And T3.F_PayType = 'CR') Or (T2.F_DutyCredit <> 0 And T3.F_PayType = 'D-'))) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo In ('112100','212100') And DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0 
 
UNION ALL 
 
-- 36/2(4) X : Adv.Rcv   or Adv.Pay : X       Advance Received / Advance Payment       If used this invoice as Advance Received(Payment) in Payment & Void 
SELECT 7 As F_TBIndex, (CASE WHEN T3.F_GLNo = '212100' THEN 2 ELSE 4 END) As F_Order, 36 As F_TBType, T3.F_VoidInPutID As F_U2ID, T3.F_VoidInPutDate As F_U2Date, 'T_CRDBHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(T8.F_Branch, '') As F_Branch, T3.F_VoidDate As F_InvoiceDate, (CASE WHEN DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) > 0 THEN T1.F_InvoiceDate ELSE T3.F_VoidDate END) As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_Agent As F_ComID, 'T_CRDBHD' As F_STBName, T1.F_ID As F_STBID, 
    (CASE WHEN T3.F_GLNo = '212100' THEN 'Void Advance Received' ELSE 'Void Advance Payment' END) + ' (CrDb No: ' + T1.F_CRDBNO + ')' As F_MDesc, 
    'Ok' As F_BillCode, '' As F_SubCode, T1.F_Currency, T1.F_ExRate, 
    (CASE WHEN T3.F_GLNo = '212100' THEN 0 ELSE T3.FPaidAmt END) As F_FDebit, (CASE WHEN T3.F_GLNo = '212100' THEN T3.FPaidAmt ELSE 0 END) As F_FCredit, T3.F_GLNo As F_GLNo, 
    (CASE WHEN T3.F_GLNo = '212100' THEN 0 ELSE T3.PaidAmt END) As F_Debit, (CASE WHEN T3.F_GLNo = '212100' THEN T3.PaidAmt ELSE 0 END) As F_Credit, 
    ('36T_CRDBHD' + LTRIM(STR(T1.F_ID)) + COALESCE(T8.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_CRDBHD T1 
    INNER JOIN ( 
        SELECT F_CrDbHDID, SUM(CASE WHEN F_ChgType = 8 THEN 0 ELSE F_Debit END) As F_Debit, SUM(CASE WHEN F_ChgType = 40 THEN 0 ELSE F_Credit END) As F_Credit, 
            SUM(CASE WHEN F_ChgType = 8 THEN F_Debit ELSE 0 END) As F_DutyDebit, SUM(CASE WHEN F_ChgType = 40 THEN F_Credit ELSE 0 END) As F_DutyCredit 
        FROM T_CRDBDETAIL 
        WHERE F_Debit <> 0 Or F_Credit <> 0 
        GROUP BY F_CrDbHDID 
    ) T2 On (T2.F_CrDbHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, (CASE WHEN LEN(T2.F_VoidinPutID) > 0 THEN T2.F_VoidinPutID ELSE T2.F_U2ID END) As F_VoidinPutID, COALESCE(T2.F_VoidinPutDate, T2.F_U2Date) As F_VoidinPutDate, 
            ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_CRDBHD' And T2.F_Void = '1' And ROUND(CASE WHEN (T2.F_Type = 'D' And T1.F_GLNo = '212100') Or (T2.F_Type In ('C','M') And T1.F_GLNo = '112100') THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID And ((T2.F_Debit <> 0 And T3.F_PayType = 'DR') Or (T2.F_DutyDebit <> 0 And T3.F_PayType = 'D+') Or (T2.F_Credit <> 0 And T3.F_PayType = 'CR') Or (T2.F_DutyCredit <> 0 And T3.F_PayType = 'D-'))) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_Agent) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo In ('112100','212100') And DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0 
 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 

DROP TABLE #T_TEMP_BLSUMM; 
 
END
" },
            { "up_FixIssueReady" ,
                @"
CREATE PROCEDURE dbo.up_FixIssueReady 
AS 
 
BEGIN 
 
 
SET NOCOUNT ON 
DECLARE @nRecOpAcctId As INT, @nRecChgType As INT, @nRecPosted As INT, @nRecInvDTId As INT, @nRecBillDTId As INT, @nRecCrDbDTId As INT 
DECLARE @fRecActualAmt As DECIMAL, @fRecAgentAmt As DECIMAL, @nRecAgent As INT 
DECLARE @nAffectedPosted2 AS INT, @nAffectedPosted3 AS INT, @nAffectedPosted4 AS INT, @nAffectedDelete AS INT 
DECLARE @sCheckData As VARCHAR(100) 
 
SELECT @nAffectedPosted2 = 0, @nAffectedPosted3 = 0, @nAffectedPosted4 = 0, @nAffectedDelete = 0 
 
 
BEGIN TRAN 
 
DECLARE curLockedIssueReady CURSOR FAST_FORWARD FOR 
 
  -- 1. Check Locked Issue Ready Data -------------------------------------------------------------------------------- 
  select T1.F_ID, T1.F_ChgType, T1.F_Posted, COALESCE(T2.F_ID, 0), COALESCE(T3.F_ID, 0), COALESCE(T4.F_ID, 0), 
      T1.F_ActualAmt, T1.F_AgentAmt, COALESCE(T5.F_Agent, 0) 
  from T_OPACCT T1 
      left join T_INVODETAIL T2 On (T2.F_STBID = T1.F_ID And T2.F_STBName = 'T_OPACCT') 
      left join T_APDETAIL T3 On (T3.F_STBID = T1.F_ID And T3.F_STBName = 'T_OPACCT') 
      left join T_CRDBDETAIL T4 On (T4.F_STBID = T1.F_ID And T4.F_STBName = 'T_OPACCT') 
      left join T_CRDBHD T5 On (T5.F_ID = T4.F_CrDbHDID) 
  where Not ( 
      (T1.F_Posted < 2 And COALESCE(T2.F_ID, T3.F_ID, 0) = 0 And COALESCE(T4.F_ID, 0) = 0) Or 
      (T1.F_Posted = 2 And COALESCE(T2.F_ID, T3.F_ID, 0) > 0 And COALESCE(T4.F_ID, 0) = 0) Or 
      (T1.F_Posted = 3 And COALESCE(T2.F_ID, T3.F_ID, 0) = 0 And COALESCE(T4.F_ID, 0) > 0) Or 
      (T1.F_Posted = 4 And COALESCE(T2.F_ID, T3.F_ID, 0) > 0 And COALESCE(T4.F_ID, 0) > 0)) 
  order by T1.F_ID 
  --------------------------------------------------------------------------------------------------------------------- 
 
OPEN curLockedIssueReady 
FETCH NEXT FROM curLockedIssueReady INTO @nRecOpAcctId, @nRecChgType, @nRecPosted, @nRecInvDTId, @nRecBillDTId, @nRecCrDbDTId, @fRecActualAmt, @fRecAgentAmt, @nRecAgent 
 
WHILE @@FETCH_STATUS = 0 
  BEGIN 
 
  -- 2. Posted <> 3 인데 Invoice, Bill은 연결되지 않고, CR/DB만 존재하는 경우 
  IF @nRecPosted <> 3 And @nRecInvDTId = 0 And @nRecBillDTId = 0 And @nRecCrDbDTId > 0 
      BEGIN 
 
      -- 2.1: ChgType 1, 11 --> 7, 17로 변경 ------------------------------------------------------------------------------------ 
      IF @nRecChgType In (1,11) 
          BEGIN 
 
          UPDATE T1 SET F_ChgType = (CASE WHEN T1.F_ChgType <= 10 THEN 7 ELSE 17 END), F_PPCC = (CASE WHEN T1.F_PPCC = 'P' THEN 'C' ELSE 'P' END) 
          FROM T_CRDBDETAIL T1 
          WHERE T1.F_ID = @nRecCrDbDTId And T1.F_ChgType In (1,11); 
 
          UPDATE T_OPACCT SET F_ChgType = (CASE WHEN F_ChgType <= 10 THEN 7 ELSE 17 END), 
              F_Loc = (CASE WHEN F_Loc = '2' THEN '1' ELSE '2' END), F_iDate = Null, F_AgentAmt = 0, F_Agent = 0 
          WHERE F_ID = @nRecOpAcctId; 
          ---------------------------------------------------------------------------------------------------------------------- 
 
          END 
 
      -- 2.2: ChgType 3, 4, 13, 14 --> 5, 15로 변경 ----------------------------------------------------------------------------- 
      ELSE IF @nRecChgType In (3,4,13,14) 
          BEGIN 
 
          ---------------------------------------------------------------------------------------------------------------------- 
          UPDATE T_CRDBDETAIL SET F_ChgType = (CASE WHEN F_ChgType <= 10 THEN 5 ELSE 15 END), F_Revenue = 0, F_Cost = 0, F_PPCC = '' 
          WHERE F_ID = @nRecCrDbDTId; 
 
          UPDATE T1 SET F_ChgType = (CASE WHEN T1.F_ChgType <= 10 THEN 5 ELSE 15 END), F_Rate = T1.F_AgentAmt, F_Qty = 1, 
              F_ActualAmt = T1.F_AgentAmt, F_Entity = @nRecAgent, F_Agent = 0, F_AgentAmt = 0, F_iDate = Null 
          FROM T_OPACCT T1 
          WHERE T1.F_ID = @nRecOpAcctId And T1.F_ChgType In (3,4,13,14); 
          ---------------------------------------------------------------------------------------------------------------------- 
 
          END 
 
      -- 2.3: Set Posted to 3 ---------------------------------------------------------------------------------------------- 
      UPDATE T_OPACCT SET F_Posted = 3 WHERE F_ID = @nRecOpAcctId; 
      ---------------------------------------------------------------------------------------------------------------------- 
 
      SET @nAffectedPosted3 = @nAffectedPosted3 + 1 
 
      END 
 
  -- 3. Posted <> 2 인데 Invoice, Bill은 연결되어 있고, CR/DB는 연결되지 않은 경우 
  ELSE IF @nRecPosted <> 2 And (@nRecInvDTId > 0 Or @nRecBillDTId > 0) And @nRecCrDbDTId = 0 
      BEGIN 
 
      -- 3.1: Remove Agent Amount ------------------------------------------------------------------------------------------ 
      UPDATE T1 SET F_Agent = 0, F_AgentAmt = 0, F_cDate = Null 
      FROM T_OPACCT T1 
      WHERE T1.F_ID = @nRecOpAcctId And T1.F_ChgType In (1,3,4,11,13,14); 
      ---------------------------------------------------------------------------------------------------------------------- 
 
      -- 3.2: Set Posted to 2 ---------------------------------------------------------------------------------------------- 
      UPDATE T_OPACCT SET F_Posted = 2 WHERE F_ID = @nRecOpAcctId; 
      ---------------------------------------------------------------------------------------------------------------------- 
 
      SET @nAffectedPosted2 = @nAffectedPosted2 + 1 
 
      END 
 
  -- 4. Posted <> 4 인데 Invoice, Bill, CR/DB 전부 연결되어 있는 경우 
  ELSE IF @nRecPosted <> 4 And (@nRecInvDTId > 0 Or @nRecBillDTId > 0) And @nRecCrDbDTId > 0 
      BEGIN 
 
      -- 4.1: Set Posted to 4 ---------------------------------------------------------------------------------------------- 
      UPDATE T_OPACCT SET F_Posted = 4 WHERE F_ID = @nRecOpAcctId; 
      ---------------------------------------------------------------------------------------------------------------------- 
 
      SET @nAffectedPosted4 = @nAffectedPosted4 + 1 
 
      END 
 
  -- 5. 그 외의 경우에는 OPAcct를 삭제한다. 
  ELSE 
      BEGIN 
 
      -- 5.1: Delete OPAcct ------------------------------------------------------------------------------------------------ 
      DELETE FROM T_OPACCT WHERE F_ID = @nRecOpAcctId; 
      ---------------------------------------------------------------------------------------------------------------------- 
 
      SET @nAffectedDelete = @nAffectedDelete + 1 
 
      END 
 
--Fetch 
  FETCH NEXT FROM curLockedIssueReady INTO @nRecOpAcctId, @nRecChgType, @nRecPosted, @nRecInvDTId, @nRecBillDTId, @nRecCrDbDTId, @fRecActualAmt, @fRecAgentAmt, @nRecAgent 
 
  END 
 
CLOSE curLockedIssueReady 
DEALLOCATE curLockedIssueReady 
 
COMMIT TRAN 
 
SET NOCOUNT OFF 
 
-- 5: Send Result 
SELECT @nAffectedPosted2 + @nAffectedPosted3 + @nAffectedPosted4 + @nAffectedDelete As AffectedRecords, 
  @nAffectedPosted2 As AffectedRecord_ToPosted2, @nAffectedPosted3 As AffectedRecord_ToPosted3, 
  @nAffectedPosted4 As AffectedRecord_ToPosted4, @nAffectedDelete As AffectedRecord_Deleted 
 
 
END 
" },
            { "up_FixJournalByMaster" ,
                @"
CREATE PROCEDURE up_FixJournalByMaster 
            @MTBName            VARCHAR(20), 
            @MBLId              INT, 
            @RemoveCanceled     BIT = 0 
AS 
 
BEGIN 
 
SET NOCOUNT ON 
 
 
CREATE TABLE #TEMP_V_NEWJOUR ( 
    F_TBIndex       INT, 
    F_Order         INT, 
    F_TBType        INT, 
    F_U2ID          VARCHAR(70) COLLATE DATABASE_DEFAULT, 
    F_U2Date        DATETIME, 
    F_TBName        VARCHAR(20) COLLATE DATABASE_DEFAULT, 
    F_TBId          INT, 
    F_RTBId         INT, 
    F_Branch        VARCHAR(3) COLLATE DATABASE_DEFAULT, 
    F_InvoiceDate   DATETIME, 
    F_PostDate      DATETIME, 
    F_ComType       VARCHAR(1) COLLATE DATABASE_DEFAULT, 
    F_ComName       VARCHAR(50) COLLATE DATABASE_DEFAULT, 
    F_ComId         INT, 
    F_STBName       VARCHAR(20) COLLATE DATABASE_DEFAULT, 
    F_STBID         INT, 
    F_MDesc         NVARCHAR(500) COLLATE DATABASE_DEFAULT, 
    F_BillCode      VARCHAR(30) COLLATE DATABASE_DEFAULT, 
    F_SubCode       NVARCHAR(40) COLLATE DATABASE_DEFAULT, 
    F_Currency      VARCHAR(3) COLLATE DATABASE_DEFAULT, 
    F_ExRate        FLOAT, 
    F_FDebit        FLOAT, 
    F_FCredit       FLOAT, 
    F_GLNo          VARCHAR(20) COLLATE DATABASE_DEFAULT, 
    F_Debit         FLOAT, 
    F_Credit        FLOAT, 
    F_Key           VARCHAR(35) COLLATE DATABASE_DEFAULT, 
    F_Void          INT, 
    F_MBLID         INT, 
    F_MTBName       VARCHAR(10) COLLATE DATABASE_DEFAULT 
); 
 
-- Make Temporary Table for V_NewJour 
--SELECT * INTO #TEMP_V_NEWJOUR FROM V_NewJour T1 WHERE T1.F_MTBName = @MTBName And T1.F_MBLID = @MBLId; 
EXEC dbo.up_NewJourByMBLTemp @MTBName, @MBLId; 
 
 
/* Delete Old Journal */ 
 
-- 01. Delete T_NSLIPKEY 
DELETE T1 
FROM T_NSLIPKEY T1 
    INNER JOIN T_NEWJOUR T2 On (T2.F_Key = T1.F_Key) 
WHERE T2.F_MTBName = @MTBName And T2.F_MBLID = @MBLId And T1.F_TbType < (CASE WHEN @RemoveCanceled = 1 THEN 1000 ELSE 100 END); 
 
-- 02. Delete T_NEWJOUR 
DELETE T1 
FROM T_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T2.F_ID Is Null And T1.F_MTBName = @MTBName And T1.F_MBLID = @MBLId; 
 
-- 03. Delete T_NEWJOURB 
IF @RemoveCanceled = 1 
    DELETE T1 
    FROM T_NEWJOURB T1 
        LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    WHERE T2.F_ID Is Null And T1.F_MTBName = @MTBName And T1.F_MBLID = @MBLId; 
 
 
/* Insert New Journal */ 
 
-- 01. T_NewJour 
INSERT INTO T_NEWJOUR (F_Key, F_TBIndex, F_Order, F_TBType, F_PostDate, F_SeqNo, F_Branch, F_TBName, F_TBID, F_RTBID, F_STBName, F_STBID, F_ComType, F_ComID, 
    F_ComName, F_GLNo, F_SubCode, F_Debit, F_Credit, F_Currency, F_ExRate, F_FDebit, F_FCredit, F_MDesc, F_U2ID, F_U2Date, F_Void, F_MBLID, F_MTBName) 
SELECT LTRIM(STR(T1.F_TBType)) + T1.F_TBName + LTRIM(STR(T1.F_TBID)) + T1.F_Branch, T1.F_TBIndex, T1.F_Order, T1.F_TBType, T1.F_PostDate, 0, 
    T1.F_Branch, T1.F_TBName, T1.F_TBID, T1.F_RTBID, T1.F_STBName, T1.F_STBID, T1.F_ComType, ISNULL(T1.F_ComID, 0), ISNULL(T1.F_ComName, ''), ISNULL(T1.F_GLNo, ''), T1.F_SubCode, 
    CASE WHEN T1.F_Debit > 0 THEN T1.F_Debit WHEN T1.F_Credit < 0 THEN -T1.F_Credit ELSE 0 END, 
    CASE WHEN T1.F_Credit > 0 THEN T1.F_Credit WHEN T1.F_Debit < 0 THEN -T1.F_Debit ELSE 0 END, T1.F_Currency, T1.F_ExRate, 
    CASE WHEN T1.F_FDebit > 0 THEN T1.f_FDebit WHEN T1.f_FCredit < 0 THEN -T1.F_FCredit ELSE 0 END, 
    CASE WHEN T1.F_FCredit > 0 THEN T1.F_FCredit WHEN T1.f_FDebit < 0 THEN -T1.F_FDebit ELSE 0 END, T1.F_MDesc, T1.F_U2ID, T1.F_U2Date, T1.F_Void, ISNULL(T1.F_MBLID, 0), ISNULL(T1.F_MTBName, '') 
FROM #TEMP_V_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T2.F_ID Is Null 
ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBName, T1.F_TBID, T1.F_Order; 
 
 
-- 02. T_NSlipKey 
INSERT INTO T_NSLIPKEY (F_Key, F_Date, F_Branch, F_Seq, F_U1ID, F_U1Date, F_TBName, F_TBID, F_TBType, F_UPD, F_RTBID) 
SELECT T1.F_key, T1.F_PostDate, T1.F_Branch, 0, T1.F_U2ID, T1.F_U2Date, T1.F_TBName, T1.F_TBID, T1.F_TBType, 9, T1.F_RTBID 
FROM T_NEWJOUR T1 
WHERE T1.F_SeqNo = 0 And T1.F_MTBName = @MTBName And T1.F_MBLID = @MBLId 
GROUP BY T1.F_key, T1.F_PostDate, T1.F_Branch, T1.F_TBName, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date, T1.F_RTBID 
ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date; 
 
 
-- 03. Assign SeqNo 
UPDATE T1 SET F_Seq = ( 
    SELECT ISNULL(T2.MSeq, 0) + COUNT(*) 
    FROM T_NSLIPKEY T9 
    WHERE T9.F_ID <= T1.F_ID And T9.F_Date = T1.F_Date And T9.F_Branch = T1.F_Branch And T9.F_Seq = 0 
) 
FROM T_NSLIPKEY T1 
    LEFT JOIN ( 
        SELECT MAX(F_Seq) AS MSeq, F_Date, F_Branch 
        FROM T_NSlipKey 
        GROUP BY F_Date, F_Branch 
    ) T2 On (T2.F_Date = T1.F_Date And T2.F_Branch = T1.F_Branch) 
WHERE T1.F_Seq = 0; 
 
-- 
UPDATE T1 SET F_SeqNo = T2.F_Seq 
FROM T_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T1.F_SeqNo = 0 And T2.F_UPD = 9; 
 
-- 
UPDATE T_NSLIPKEY SET F_UPD = 0 WHERE F_UPD = 9; 
 
 
-- 
DROP TABLE #TEMP_V_NEWJOUR 
 
SET NOCOUNT OFF 
 
END
" },
            { "up_FixJournalByTask" ,
                @"
CREATE PROCEDURE up_FixJournalByTask 
            @TBName            VARCHAR(20), 
            @TBId              INT, 
            @RemoveCanceled    BIT = 0 
AS 
 
BEGIN 
 
SET NOCOUNT ON 
 
 
-- Make Temporary Table for V_NewJour 
SELECT * INTO #TEMP_V_NEWJOUR FROM V_NewJour T1 WHERE T1.F_TBName = @TBName And T1.F_TBID = @TBId; 
 
 
/* Delete Old Journal */ 
 
-- 01. Delete T_NSLIPKEY 
DELETE T1 FROM T_NSLIPKEY T1 WHERE T1.F_TBName = @TBName And T1.F_TBID = @TBId And T1.F_TbType < (CASE WHEN @RemoveCanceled = 1 THEN 1000 ELSE 100 END); 
 
-- 02. Delete T_NEWJOUR 
DELETE T1 
FROM T_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T2.F_ID Is Null And T1.F_TBName = @TBName And T1.F_TBID = @TBId; 
 
-- 03. Delete T_NEWJOURB 
IF @RemoveCanceled = 1 
    DELETE T1 
    FROM T_NEWJOURB T1 
        LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    WHERE T2.F_ID Is Null And T1.F_TBName = @TBName And T1.F_TBID = @TBId; 
 
 
/* Insert New Journal */ 
 
-- 01. T_NewJour 
INSERT INTO T_NEWJOUR (F_Key, F_TBIndex, F_Order, F_TBType, F_PostDate, F_SeqNo, F_Branch, F_TBName, F_TBID, F_RTBID, F_STBName, F_STBID, F_ComType, F_ComID, 
    F_ComName, F_GLNo, F_SubCode, F_Debit, F_Credit, F_Currency, F_ExRate, F_FDebit, F_FCredit, F_MDesc, F_U2ID, F_U2Date, F_Void, F_MBLID, F_MTBName) 
SELECT LTRIM(STR(T1.F_TBType)) + T1.F_TBName + LTRIM(STR(T1.F_TBID)) + T1.F_Branch, T1.F_TBIndex, T1.F_Order, T1.F_TBType, T1.F_PostDate, 0, 
    T1.F_Branch, T1.F_TBName, T1.F_TBID, T1.F_RTBID, T1.F_STBName, T1.F_STBID, T1.F_ComType, ISNULL(T1.F_ComID, 0), ISNULL(T1.F_ComName, ''), ISNULL(T1.F_GLNo, ''), T1.F_SubCode, 
    CASE WHEN T1.F_Debit > 0 THEN T1.F_Debit WHEN T1.F_Credit < 0 THEN -T1.F_Credit ELSE 0 END, 
    CASE WHEN T1.F_Credit > 0 THEN T1.F_Credit WHEN T1.F_Debit < 0 THEN -T1.F_Debit ELSE 0 END, T1.F_Currency, T1.F_ExRate, 
    CASE WHEN T1.F_FDebit > 0 THEN T1.f_FDebit WHEN T1.f_FCredit < 0 THEN -T1.F_FCredit ELSE 0 END, 
    CASE WHEN T1.F_FCredit > 0 THEN T1.F_FCredit WHEN T1.f_FDebit < 0 THEN -T1.F_FDebit ELSE 0 END, T1.F_MDesc, T1.F_U2ID, T1.F_U2Date, T1.F_Void, ISNULL(T1.F_MBLID, 0), ISNULL(T1.F_MTBName, '') 
FROM #TEMP_V_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T2.F_ID Is Null 
ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBName, T1.F_TBID, T1.F_Order; 
 
 
-- 02. T_NSlipKey 
INSERT INTO T_NSLIPKEY (F_Key, F_Date, F_Branch, F_Seq, F_U1ID, F_U1Date, F_TBName, F_TBID, F_TBType, F_UPD, F_RTBID) 
SELECT T1.F_key, T1.F_PostDate, T1.F_Branch, 0, T1.F_U2ID, T1.F_U2Date, T1.F_TBName, T1.F_TBID, T1.F_TBType, 9, T1.F_RTBID 
FROM T_NEWJOUR T1 
WHERE T1.F_SeqNo = 0 And T1.F_TBName = @TBName And T1.F_TBID = @TBId 
GROUP BY T1.F_key, T1.F_PostDate, T1.F_Branch, T1.F_TBName, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date, t1.F_RTBID 
ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date; 
 
 
-- 03. Assign SeqNo 
UPDATE T1 SET F_Seq = ( 
    SELECT ISNULL(T2.MSeq, 0) + COUNT(*) 
    FROM T_NSLIPKEY T9 
    WHERE T9.F_ID <= T1.F_ID And T9.F_Date = T1.F_Date And T9.F_Branch = T1.F_Branch And T9.F_Seq = 0 
) 
FROM T_NSLIPKEY T1 
    LEFT JOIN ( 
        SELECT MAX(F_Seq) AS MSeq, F_Date, F_Branch 
        FROM T_NSlipKey 
        GROUP BY F_Date, F_Branch 
    ) T2 On (T2.F_Date = T1.F_Date And T2.F_Branch = T1.F_Branch) 
WHERE T1.F_Seq = 0; 
 
-- 
UPDATE T1 SET F_SeqNo = T2.F_Seq 
FROM T_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T1.F_SeqNo = 0 And T2.F_UPD = 9; 
 
-- 
UPDATE T_NSLIPKEY SET F_UPD = 0 WHERE F_UPD = 9; 
 
 
-- 
DROP TABLE #TEMP_V_NEWJOUR 
 
SET NOCOUNT OFF 
 
END 
" },
            { "up_FixMismatchDutyEntity" ,
                @"
CREATE PROCEDURE dbo.up_FixMismatchDutyEntity 
AS 
 
BEGIN 
 
 
SET NOCOUNT ON 
DECLARE @sRecDutyType As VARCHAR(15), @sRecTBName As VARCHAR(10), @nRecTBId As INT, @nRecBillId As INT 
DECLARE @nRecSalesEntity As INT, @nRecCostEntity As INT, @nRecBLDutyCustomer As INT, @nRecBLDutyAgent As INT 
DECLARE @nDutyCustomerAffected As INT, @nDutyAgentAffected As INT, @nCurDecimal As INT, @nFlag As INT 
 
SELECT @nCurDecimal = F_Decimal FROM T_NCODECURRENCY WHERE F_Code = (SELECT TOP 1 F_Currency FROM T_CODEDATA) 
SELECT @nDutyCustomerAffected = 0, @nDutyAgentAffected = 0 
 
 
BEGIN TRAN 
 
DECLARE curErrorData CURSOR FAST_FORWARD FOR 
 
      -- 1: Check Mismatch Duty Entity Info. ------------------------------------------------------------------------------ 
      select 'DUTY2CUSTOMER' As DutyType, T1.F_TBName, T1.F_TBID, ISNULL(T2.F_ID, 0), T1.F_DutyEntity, ISNULL(T2.F_DutyEntity, 0), T3.F_DutyCustomer,  T3.F_DutyAgent 
      from ( 
              select T1.F_TBName, T1.F_TBID, T1.F_DutyEntity 
              from T_INVOHD T1 
                      inner join ( 
                              select F_INVOHDID, COUNT(*) As Cnt 
                              from T_INVODETAIL S1 
                                      inner join T_INVOHD S2 On (S2.F_ID = S1.F_INVOHDID) 
                              where S1.F_ChgType = 10 And S2.F_Void < 1 
                              group by F_INVOHDID 
                      ) T2 On (T2.F_INVOHDID = T1.F_ID) 
      ) T1 
              left join ( 
                      select T1.F_ID, T1.F_TBName, T1.F_TBID, T1.F_DutyEntity 
                      from T_APHD T1 
                              inner join ( 
                                      select F_APHDID, COUNT(*) As Cnt 
                                      from T_APDETAIL S1 
                                              inner join T_APHD S2 On (S2.F_ID = S1.F_APHDID) 
                                      where S1.F_ChgType = 20 And S2.F_Void < 1 
                                      group by F_APHDID 
                              ) T2 On (T2.F_APHDID = T1.F_ID) 
              ) T2 On (T2.F_TBName = T1.F_TBName And T2.F_TBID = T1.F_TBID) 
              left join V_BLSUMM T3 On (T3.F_TBName = T1.F_TBName And T3.F_TBID = T1.F_TBID) 
      where T2.F_TBID Is Not Null And (T1.F_DutyEntity <> T2.F_DutyEntity Or T1.F_DutyEntity <> T3.F_DutyCustomer) 
 
      union all 
 
      select 'DUTY2AGENT' As DutyType, T1.F_TBName, T1.F_TBID, ISNULL(T2.F_ID, 0), T1.F_DutyAgent, ISNULL(T2.F_DutyAgent, 0), T3.F_DutyCustomer,  T3.F_DutyAgent 
      from ( 
              select T1.F_TBName, T1.F_TBID, T1.F_Agent As F_DutyAgent 
              from T_CRDBHD T1 
                      inner join ( 
                              select F_CRDBHDID, COUNT(*) As Cnt 
                              from T_CRDBDETAIL S1 
                                      inner join T_CRDBHD S2 On (S2.F_ID = S1.F_CRDBHDID) 
                              where S1.F_ChgType = 8 And S2.F_Void < 1 
                              group by F_CRDBHDID 
                      ) T2 On (T2.F_CRDBHDID = T1.F_ID) 
      ) T1 
              left join ( 
                      select T1.F_ID, T1.F_TBName, T1.F_TBID, T1.F_DutyAgent 
                      from T_APHD T1 
                              inner join ( 
                                      select F_APHDID, COUNT(*) As Cnt 
                                      from T_APDETAIL S1 
                                              inner join T_APHD S2 On (S2.F_ID = S1.F_APHDID) 
                                      where S1.F_ChgType = 18 And S2.F_Void < 1 
                                      group by F_APHDID 
                              ) T2 On (T2.F_APHDID = T1.F_ID) 
              ) T2 On (T2.F_TBName = T1.F_TBName And T2.F_TBID = T1.F_TBID) 
              left join V_BLSUMM T3 On (T3.F_TBName = T1.F_TBName And T3.F_TBID = T1.F_TBID) 
      where T2.F_TBID Is Not Null And (T1.F_DutyAgent <> T2.F_DutyAgent Or T1.F_DutyAgent <> T3.F_DutyAgent) 
      --------------------------------------------------------------------------------------------------------------------- 
 
OPEN curErrorData 
FETCH NEXT FROM curErrorData INTO @sRecDutyType, @sRecTBName, @nRecTBId, @nRecBillId, @nRecSalesEntity, @nRecCostEntity, @nRecBLDutyCustomer, @nRecBLDutyAgent 
 
WHILE @@FETCH_STATUS = 0 
      BEGIN 
 
      SET @nFlag = 0; 
 
      -- 2.1: DUTY TO CUSTOMER  --------------------------------------------------------------------------- 
      IF @sRecDutyType = 'DUTY2CUSTOMER' 
              BEGIN 
 
              IF @nRecSalesEntity <> @nRecCostEntity And @nRecBillId > 0 
                      BEGIN 
                      -- 2.2.1: Sales Entity를 기준으로 Cost Entity를 변경한다. ----------------------------------------- 
                      UPDATE T_APHD SET F_DutyEntity = @nRecSalesEntity WHERE F_ID = @nRecBillId; 
                      SET @nFlag = 1; 
                      ------------------------------------------------------------------------------------------------- 
                      END 
 
              IF @nRecSalesEntity <> @nRecBLDutyCustomer And SUBSTRING(@sRecTBName, 5, 1) = 'H' 
                      BEGIN 
                      -- 2.2.2: Sales Entity를 기준으로 B/L의 Duty Customer를 변경한다. ------------------------------------- 
                      EXEC ('UPDATE ' + @sRecTBName + ' SET F_DutyCustomer = ' + @nRecSalesEntity + ' WHERE F_ID = ' + @nRecTBId); 
                      SET @nFlag = 1; 
                      ------------------------------------------------------------------------------------------------- 
                      END 
 
              IF @nFlag = 1 
                      SET @nDutyCustomerAffected = @nDutyCustomerAffected + 1 
 
              END 
 
      -- 2.2: DUTY TO AGENT ------------------------------------------------------------------------------- 
      ELSE 
              BEGIN 
 
              IF @nRecSalesEntity <> @nRecCostEntity And @nRecBillId > 0 
                      BEGIN 
                      -- 2.2.1: Sales Entity를 기준으로 Cost Entity를 변경한다. ----------------------------------------- 
                      UPDATE T_APHD SET F_DutyAgent = @nRecSalesEntity WHERE F_ID = @nRecBillId; 
                      SET @nFlag = 1; 
                      ------------------------------------------------------------------------------------------------- 
                      END 
 
              IF @nRecSalesEntity <> @nRecBLDutyAgent And SUBSTRING(@sRecTBName, 5, 1) = 'H' 
                      BEGIN 
                      -- 2.2.2: Sales Entity를 기준으로 B/L의 Duty Agent를 변경한다. ------------------------------------- 
                      EXEC ('UPDATE ' + @sRecTBName + ' SET F_DutyAgent = ' + @nRecSalesEntity + ' WHERE F_ID = ' + @nRecTBId); 
                      SET @nFlag = 1; 
                      ------------------------------------------------------------------------------------------------- 
                      END 
 
              IF @nFlag = 1 
                      SET @nDutyAgentAffected = @nDutyAgentAffected + 1 
 
              END 
 
      -- Fetch 
      FETCH NEXT FROM curErrorData INTO @sRecDutyType, @sRecTBName, @nRecTBId, @nRecBillId, @nRecSalesEntity, @nRecCostEntity, @nRecBLDutyCustomer, @nRecBLDutyAgent 
 
      END 
 
CLOSE curErrorData 
DEALLOCATE curErrorData 
 
COMMIT TRAN 
 
SET NOCOUNT OFF 
 
-- 5: Send Result 
SELECT @nDutyCustomerAffected As AffectedRecord_DutyCustomer, @nDutyAgentAffected As AffectRecord_DutyAgent 
 
 
END
" },
            { "up_FixMissingMBL" ,
                @"
CREATE PROCEDURE dbo.up_FixMissingMBL 
AS 
 
BEGIN 
 
  
SET NOCOUNT ON 
DECLARE @nRowNum As INT, @sRecBLType As VARCHAR(3), @nRecBLId As INT 
DECLARE @nNewMBLId As INT, @nDummyCnt As INT 
DECLARE @nOIMAffected AS INT, @nOOMAffected AS INT, @nAIMAffected AS INT, @nAOMAffected AS INT 
 
 
SELECT @nOIMAffected = 0, @nOOMAffected = 0, @nAIMAffected = 0, @nAOMAffected = 0 
SELECT @nDummyCnt = COUNT(*) 
FROM ( 
        SELECT F_ID 
        From T_OIMMAIN 
        WHERE F_RefNo LIKE '%DUMMYMBL%' 
                             
        Union All 
 
        SELECT F_ID 
        From T_OOMMAIN 
        WHERE F_RefNo LIKE '%DUMMYMBL%' 

        Union All 
 
        SELECT F_ID 
        From T_AIMMAIN 
        WHERE F_RefNo LIKE '%DUMMYMBL%' 
 
        Union All 
 
        SELECT F_ID 
        From T_AOMMAIN 
        WHERE F_RefNo LIKE '%DUMMYMBL%' 
    ) AS DummyBL 
 
BEGIN TRAN 
 
DECLARE curMissMBLInfo CURSOR FAST_FORWARD FOR 
    ---- 1: Check Missing MBL Info. ------------------------------------------------------------------------------------ 
    SELECT ROW_NUMBER() OVER (ORDER BY tmp, BLId) AS ROWNUM, BLType, BLId 
    FROM ( 
            SELECT 'OIH' As BLType, T1.F_ID As BLId, 1 As tmp 
            FROM T_OIHMAIN T1 
            LEFT JOIN T_OIMMAIN T2 ON T1.F_OIMBLID = T2.F_ID 
            Where t2.F_ID Is Null 
 

            Union All 
 
            SELECT 'OOH' As BLType, T1.F_ID As BLId, 2 As tmp 
            FROM T_OOHMAIN T1 
            LEFT JOIN T_OOMMAIN T2 ON T1.F_OOMBLID = T2.F_ID 
            Where t2.F_ID Is Null 
 
            Union All 
 
            SELECT 'AIH' As BLType, T1.F_ID As BLId, 3 As tmp 
            FROM T_AIHMAIN T1 
            LEFT JOIN T_AIMMAIN T2 ON T1.F_AIMBLID = T2.F_ID 
            Where t2.F_ID Is Null 
 
            Union All 
 
            SELECT 'AOH' As BLType, T1.F_ID As BLId, 4 As tmp 
            FROM T_AOHMAIN T1 
            LEFT JOIN T_AOMMAIN T2 ON T1.F_AOMBLID = T2.F_ID 
            Where t2.F_ID Is Null 
        ) AS DummyHouseBL 
    ORDER BY tmp, BLId 
    --------------------------------------------------------------------------------------------------------------------- 
 

OPEN curMissMBLInfo 
FETCH NEXT FROM curMissMBLInfo INTO @nRowNum, @sRecBLType, @nRecBLId 
 
WHILE @@FETCH_STATUS = 0 
    BEGIN 
 
    -- 2: OIH, OOH, AIH, AOH에 따라 각각 새로운 Master B/L을 추가하고, 관련 정보를 Update 한다. 
    IF @sRecBLType = 'OIH' 
        BEGIN 
 
        -- 2.1.1: Add a T_OIMMAIN with T_OIHMAIN Information. --------------------------------------------------------------- 
        INSERT INTO T_OIMMAIN (F_RefNo, F_CFSLocation, F_USFCode, F_FinalDest, F_FETA, F_ETA, F_ITNo, F_ITPlace, F_ITDate, F_ShipmentType, F_U1ID, F_U1Date, F_U2ID, F_U2Date, F_Branch) 
        SELECT 'DUMMYMBL' + CONVERT(VARCHAR, @nRowNum + @nDummyCnt) As F_RefNo, 
               OIH.F_CFSLocation As F_CFSLocation, OIH.F_USFCode As F_USFCode, OIH.F_FinalDest As F_FinalDest, OIH.F_FETA As F_FETA, OIH.F_FETA AS F_ETA, OIH.F_ITNo As F_ITNo, 
               OIH.F_ITPlace As F_ITPlace, OIH.F_ITDate As F_ITDate, OIH.F_ShipmentType As F_ShipmentType, OIH.F_U1ID As F_U1ID, OIH.F_U1Date As F_U1Date, OIH.F_U2ID As F_U2ID, OIH.F_U2Date As F_U2Date, 
               COALESCE(T2.F_Branch, (SELECT TOP 1 F_C1 FROM T_AOTHERINFO WHERE F_TBName = 'T_CODEDATA' And F_Type = 27)) As F_Branch 

        FROM T_OIHMAIN OIH 
            LEFT JOIN ( 
                SELECT TOP 1 S1.F_Branch 
                FROM T_DEPODETAIL S1 
                    INNER JOIN T_DEPOHD S2 On (S2.F_ID = S1.F_DEPOHDID) 
                    LEFT JOIN T_INVOHD S3 On (S3.F_ID = S1.F_TBID And S1.F_TBName = 'T_INVOHD') 
                    LEFT JOIN T_APHD S4 On (S4.F_ID = S1.F_TBID And S1.F_TBName = 'T_APHD') 
                    LEFT JOIN T_CRDBHD S5 On (S5.F_ID = S1.F_TBID And S1.F_TBName = 'T_CRDBHD') 
                WHERE COALESCE(S3.F_TBID, S4.F_TBID, S5.F_TBID, 0) = @nRecBLId And COALESCE(S3.F_TBName, S4.F_TBName, S5.F_TBName, '') = 'T_OIHMAIN' 
                    And S1.F_Branch <> '' 
            ) T2 On (1 = 1) 
        WHERE OIH.F_ID = @nRecBLId 
 
        IF @@ROWCOUNT <= 0 
            BEGIN 
 
            Close curMissMBLInfo 
            DEALLOCATE curMissMBLInfo 
            ROLLBACK TRAN 

            Print 'Error ! - Fail to insert T_OIMMAIN'; 
            Return 
 
            End 
 
        Else 
            SELECT @nNewMBLId = SCOPE_IDENTITY() 
 
 
        -- 2.1.2: Update T_OIMMAIN.F_OIMBLID if it is different 
        UPDATE T1 SET F_OIMBLID = @nNewMBLId FROM T_OIHMAIN T1 WHERE T1.F_ID = @nRecBLId 
 
        --------------------------------------------------------------------------------------------------------------------- 
 
        SET @nOIMAffected = @nOIMAffected + 1 
 
        End 
 
    IF @sRecBLType = 'OOH' 
        BEGIN 
 

        -- 2.2.1: Add a T_OOMMAIN with T_OOHMAIN Information. --------------------------------------------------------------- 
        INSERT INTO T_OOMMAIN (F_RefNo, F_Agent, F_Vessel, F_Voyage, F_USLCode, F_USDCode, F_ProfitShare, F_ShipmentType, F_U1ID, F_U1Date, F_U2ID, F_U2Date, F_Branch) 
        SELECT 'DUMMYMBL' + CONVERT(VARCHAR, @nRowNum + @nDummyCnt) As F_RefNo, 
               OOH.F_Agent As F_Agent, OOH.F_Vessel As F_Vessel, OOH.F_Voyage As F_Voyage, OOH.F_USLCode As F_USLCode, OOH.F_USDCode As F_USDCode, OOH.F_ProfitShare As F_ProfitShare, 
               OOH.F_ShipmentType As F_ShipmentType, OOH.F_U1ID As F_U1ID, OOH.F_U1Date As F_U1Date, OOH.F_U2ID As F_U2ID, OOH.F_U2Date As F_U2Date, 
               COALESCE(T2.F_Branch, (SELECT TOP 1 F_C1 FROM T_AOTHERINFO WHERE F_TBName = 'T_CODEDATA' And F_Type = 27)) As F_Branch 
        FROM T_OOHMAIN OOH 
            LEFT JOIN ( 
                SELECT TOP 1 S1.F_Branch 
                FROM T_DEPODETAIL S1 
                    INNER JOIN T_DEPOHD S2 On (S2.F_ID = S1.F_DEPOHDID) 
                    LEFT JOIN T_INVOHD S3 On (S3.F_ID = S1.F_TBID And S1.F_TBName = 'T_INVOHD') 
                    LEFT JOIN T_APHD S4 On (S4.F_ID = S1.F_TBID And S1.F_TBName = 'T_APHD') 
                    LEFT JOIN T_CRDBHD S5 On (S5.F_ID = S1.F_TBID And S1.F_TBName = 'T_CRDBHD') 
                WHERE COALESCE(S3.F_TBID, S4.F_TBID, S5.F_TBID, 0) = @nRecBLId And COALESCE(S3.F_TBName, S4.F_TBName, S5.F_TBName, '') = 'T_OOHMAIN' 
                    And S1.F_Branch <> '' 
            ) T2 On (1 = 1) 
        WHERE OOH.F_ID = @nRecBLId 

 
        IF @@ROWCOUNT <= 0 
            BEGIN 
 
            Close curMissMBLInfo 
            DEALLOCATE curMissMBLInfo 
            ROLLBACK TRAN 
            Print 'Error ! - Fail to insert T_OOMMAIN'; 
            Return 
 
            End 
 
        Else 
            SELECT @nNewMBLId = SCOPE_IDENTITY() 
 
        -- 2.2.2: Update T_OOHMAIN.F_OOMBLID if it is different 
        UPDATE T1 SET F_OOMBLID = @nNewMBLId FROM T_OOHMAIN T1 WHERE T1.F_ID = @nRecBLId 
 
        --------------------------------------------------------------------------------------------------------------------- 
 

        SET @nOOMAffected = @nOOMAffected + 1 
 
        End 
     
    IF @sRecBLType = 'AIH' 
        BEGIN 
 
        -- 2.3.1: Add a T_AIMMAIN with T_AIHMAIN Information. --------------------------------------------------------------- 
        INSERT INTO T_AIMMAIN (F_RefNo, F_Agent, F_AgentRefNo, F_Flocation, F_GODate, F_StorageDate, F_ShipmentType, F_U1ID, F_U1Date, F_U2ID, F_U2Date, F_Branch) 
        SELECT 'DUMMYMBL' + CONVERT(VARCHAR, @nRowNum + @nDummyCnt) As F_RefNo, 
               AIH.F_Agent As F_Agent, AIH.F_AgentRefNo As F_AgentRefNo, AIH.F_CFSLocation As F_Flocation, AIH.F_GODate As F_GODate, AIH.F_StorageDate As F_StorageDate, 
               AIH.F_ShipmentType As F_ShipmentType, AIH.F_U1ID As F_U1ID, AIH.F_U1Date As F_U1Date, AIH.F_U2ID As F_U2ID, AIH.F_U2Date As F_U2Date, 
               COALESCE(T2.F_Branch, (SELECT TOP 1 F_C1 FROM T_AOTHERINFO WHERE F_TBName = 'T_CODEDATA' And F_Type = 27)) As F_Branch 

        FROM T_AIHMAIN AIH 
            LEFT JOIN ( 
                SELECT TOP 1 S1.F_Branch 
                FROM T_DEPODETAIL S1 
                    INNER JOIN T_DEPOHD S2 On (S2.F_ID = S1.F_DEPOHDID) 
                    LEFT JOIN T_INVOHD S3 On (S3.F_ID = S1.F_TBID And S1.F_TBName = 'T_INVOHD') 
                    LEFT JOIN T_APHD S4 On (S4.F_ID = S1.F_TBID And S1.F_TBName = 'T_APHD') 
                    LEFT JOIN T_CRDBHD S5 On (S5.F_ID = S1.F_TBID And S1.F_TBName = 'T_CRDBHD') 
                WHERE COALESCE(S3.F_TBID, S4.F_TBID, S5.F_TBID, 0) = @nRecBLId And COALESCE(S3.F_TBName, S4.F_TBName, S5.F_TBName, '') = 'T_AIHMAIN' 
                    And S1.F_Branch <> '' 
            ) T2 On (1 = 1) 
        WHERE AIH.F_ID = @nRecBLId 
 
        IF @@ROWCOUNT <= 0 
            BEGIN 
 
            Close curMissMBLInfo 
            DEALLOCATE curMissMBLInfo 
            ROLLBACK TRAN 
            Print 'Error ! - Fail to insert T_AIMMAIN'; 
            Return 
 

 
            End 
 
        Else 
            SELECT @nNewMBLId = SCOPE_IDENTITY() 
 
 
        -- 2.3.2: Update T_AIHMAIN.F_AIMBLID if it is different 
        UPDATE T1 SET F_AIMBLID = @nNewMBLId FROM T_AIHMAIN T1 WHERE T1.F_ID = @nRecBLId 
 
        --------------------------------------------------------------------------------------------------------------------- 
 
        SET @nAIMAffected = @nAIMAffected + 1 
 
        End 
 
    IF @sRecBLType = 'AOH' 
        BEGIN 

 
        -- 2.4.1: Add a T_AOMMAIN with T_AOHMAIN and T_AOTHERINFO Information. --------------------------------------------------------------- 
        INSERT INTO T_AOMMAIN (F_RefNo, F_Agent, F_LoadingPort, F_Discharge, F_ShipmentType, F_U1ID, F_U1Date, F_U2ID, F_U2Date, F_LCode, F_DCode, F_To1, F_By1, F_To2, F_By2, F_ETA, F_Branch) 
        SELECT 'DUMMYMBL' + CONVERT(VARCHAR, @nRowNum + @nDummyCnt) As F_RefNo, 
               AOH.F_Agent As F_Agent, AOH.F_Hloadingport As F_LoadingPort, AOH.F_Hdischarge As F_Discharge, 
               AOH.F_ShipmentType As F_ShipmentType, AOH.F_U1ID As F_U1ID, AOH.F_U1Date As F_U1Date, AOH.F_U2ID As F_U2ID, AOH.F_U2Date As F_U2Date, 
               ISNULL(OT.F_C3, '') As F_LCode, ISNULL(OT.F_C4, '') As F_DCode, ISNULL(OT.F_C5, '') As F_To1, ISNULL(OT.F_C7, '') As F_By1, 
               ISNULL(OT.F_C8, '') As F_To2, ISNULL(OT.F_C9, '') As F_By2, OT.F_D1 As F_ETA, 
               COALESCE(T2.F_Branch, (SELECT TOP 1 F_C1 FROM T_AOTHERINFO WHERE F_TBName = 'T_CODEDATA' And F_Type = 27)) As F_Branch 
        FROM T_AOHMAIN AOH 
        LEFT JOIN T_AOTHERINFO OT ON OT.F_TBNAME = 'T_AOHMAIN' AND AOH.F_ID = OT.F_TBID AND OT.F_TYPE = 2 
            LEFT JOIN ( 
                SELECT TOP 1 S1.F_Branch 
                FROM T_DEPODETAIL S1 
                    INNER JOIN T_DEPOHD S2 On (S2.F_ID = S1.F_DEPOHDID) 
                    LEFT JOIN T_INVOHD S3 On (S3.F_ID = S1.F_TBID And S1.F_TBName = 'T_INVOHD') 
                    LEFT JOIN T_APHD S4 On (S4.F_ID = S1.F_TBID And S1.F_TBName = 'T_APHD') 
                    LEFT JOIN T_CRDBHD S5 On (S5.F_ID = S1.F_TBID And S1.F_TBName = 'T_CRDBHD') 
                WHERE COALESCE(S3.F_TBID, S4.F_TBID, S5.F_TBID, 0) = @nRecBLId And COALESCE(S3.F_TBName, S4.F_TBName, S5.F_TBName, '') = 'T_AOHMAIN' 
                    And S1.F_Branch <> '' 
            ) T2 On (1 = 1) 
        WHERE AOH.F_ID = @nRecBLId 

 
        IF @@ROWCOUNT <= 0 
            BEGIN 
 
            Close curMissMBLInfo 
            DEALLOCATE curMissMBLInfo 
            ROLLBACK TRAN 
            Print 'Error ! - Fail to insert T_AOMMAIN'; 
            Return 
 
            End 
 
        Else 
            SELECT @nNewMBLId = SCOPE_IDENTITY() 
 
 
        -- 2.4.2: Update T_AOHMAIN.F_AOMBLID if it is different 
        UPDATE T1 SET F_AOMBLID = @nNewMBLId FROM T_AOHMAIN T1 WHERE T1.F_ID = @nRecBLId 
 
        -- 2.4.3: Add a T_AOTHERINFO with T_AOTHERINFO Information. --------------------------------------------------------------- 

        INSERT INTO T_AOTHERINFO (F_TBNAME, F_TBID, F_TYPE, F_C3, F_D1, F_D2) 
        SELECT 'T_AOMMAIN', @nNewMBLId, 2, OT.F_C10 As F_C3, OT.F_D2 As F_D1, OT.F_D3 As F_D2 
        FROM T_AOTHERINFO OT 
        WHERE OT.F_TYPE = 2 AND OT.F_TBNAME = 'T_AOHMAIN' AND OT.F_TBID = @nRecBLId 
 
        --IF @@ROWCOUNT <= 0 
        --    BEGIN 
 
        --    Close curMissMBLInfo 
        --    DEALLOCATE curMissMBLInfo 
        --    ROLLBACK TRAN 
        --    Print 'Error ! - Fail to insert T_AOTHERINFO'; 
        --    Return 
 
        --    End 
 
        --------------------------------------------------------------------------------------------------------------------- 
 
        SET @nAOMAffected = @nAOMAffected + 1 
 
        End 
 
 
    -- Fetch 

    FETCH NEXT FROM curMissMBLInfo INTO @nRowNum, @sRecBLType, @nRecBLId 
 
    End 
 
Close curMissMBLInfo 
DEALLOCATE curMissMBLInfo 
 
Commit TRAN 
 
--SET IDENTITY_INSERT OFF 
SET NOCOUNT OFF 
 
-- 5: Send Result 
SELECT @nOIMAffected + @nOOMAffected + @nAIMAffected + @nAOMAffected As AffectedRecords, 
       @nOIMAffected As AffectedRecord_OIM, @nOOMAffected As AffectRecord_OOM, 
       @nAIMAffected As AffectedRecord_AIM, @nAOMAffected As AffectRecord_AOM 
End 
" },
            { "up_GetAccumulatedBal" ,
                @"
CREATE PROCEDURE [dbo].[up_GetAccumulatedBal]( 
    @F_TBID INT, 
    @F_ACCRUALDATE VARCHAR(10), 
    @F_FROMDATE VARCHAR(10), 
    @F_TODATE VARCHAR(10), 
    @F_PAIDAMOUNT DECIMAL(16,4), 
    @F_GLNO VARCHAR(10), 
    @F_BANKCUR VARCHAR(3), 
    @F_ENTITY INT 
) 
AS 
BEGIN 
SET NOCOUNT ON 
 
IF OBJECT_ID('tempdb..#TEMP_ACCBAL') IS NOT NULL DROP TABLE #TEMP_ACCBAL 
IF OBJECT_ID('tempdb..#TEMP_DAILYJOUR') IS NOT NULL DROP TABLE #TEMP_DAILYJOUR 

CREATE TABLE #TEMP_ACCBAL 
(    
    F_GLNO varchar(10) COLLATE DATABASE_DEFAULT, 
    F_CURRENCY varchar(3) COLLATE DATABASE_DEFAULT, 
    F_BALANCE decimal(16,4)      
) 
CREATE TABLE #TEMP_DAILYJOUR  
(            
    F_POSTDATE datetime,     
    F_GLNO varchar(10) COLLATE DATABASE_DEFAULT, 
    F_GLDescription varchar(100) COLLATE DATABASE_DEFAULT,  
    F_CURRENCY varchar(3) COLLATE DATABASE_DEFAULT,  
    F_BALANCE decimal(16,4)   
)   
 
DECLARE @S_SELECT NVARCHAR(2000) 
DECLARE @S_WHERE NVARCHAR(500) 
DECLARE @F_POSTDATE Datetime 
DECLARE @F_GLDescription VARCHAR(100) 
DECLARE @F_BALANCE decimal(16,4) 
DECLARE @BASECUR VARCHAR(3) 
DECLARE @ACCBAL decimal(16,4) 

SET @ACCBAL = 0 
SET @S_WHERE = '' 
SET @BASECUR = (SELECT F_Currency FROM T_CODEDATA) 
 
IF @F_TBID > 0 
BEGIN 
    SET @S_WHERE ='And Not (T1.F_TBID = ' + ltrim(str(@F_TBID)) + ' And T1.F_TBName = ''T_DEPOHD'') ' 
END 

SELECT @S_SELECT = ' 
    SELECT 
        T1.F_GLNO, T1.F_CURRENCY, 
        ROUND(SUM(CASE WHEN ''' + @BASECUR + ''' = ''' + @F_BANKCUR + ''' THEN 
                (CASE WHEN T1.F_GLNO In (''212100'',''211200'',''212110'',''211210'',''211220'') THEN F_CREDIT - F_DEBIT ELSE F_DEBIT - F_CREDIT END) 
                ELSE (CASE WHEN T1.F_GLNO In (''212100'',''211200'',''212110'',''211210'',''211220'') THEN F_FCREDIT - F_FDEBIT ELSE F_FDEBIT - F_FCREDIT END) END), 2) AS F_Balance 
    FROM V_SLIPX T1 
        LEFT JOIN T_DEPODETAIL T2 ON T1.F_STBID = T2.F_ID AND T1.F_STBNAME = ''T_DEPODETAIL'' 
    WHERE T1.F_GLNO = ''' + @F_GLNO + '''
        AND T1.F_COMID = ' + ltrim(str(@F_ENTITY)) + ' AND T1.F_CURRENCY = ''' + @F_BANKCUR + ''' 
        AND T1.F_TBTYPE NOT IN (''15'',''16'',''25'',''26'',''35'',''36'',''85'',''86'') AND (T1.F_TBNAME <> ''T_DEPOHD'' OR (T1.F_TBNAME = ''T_DEPOHD'' AND T2.F_TBNAME = '''')) 
        AND T1.F_POSTDATE < ''' + @F_FROMDATE + ''' 
        ' + @S_WHERE + ' 
    GROUP BY T1.F_CURRENCY, T1.F_GLNO ' 

INSERT #TEMP_ACCBAL     -- Step 1 : Accrual Date 이전에 누적된 잔액     
EXEC (@S_SELECT)  

SELECT @S_SELECT = ' 
    SELECT 
        T1.F_POSTDATE, T1.F_GLNO, T3.F_GLDescription, T1.F_CURRENCY, 
        ROUND(SUM(CASE WHEN ''' + @BASECUR + ''' = ''' + @F_BANKCUR + ''' THEN 
                (CASE WHEN T1.F_GLNO In (''212100'',''211200'',''212110'',''211210'',''211220'') THEN F_CREDIT - F_DEBIT ELSE F_DEBIT - F_CREDIT END) 
                ELSE (CASE WHEN T1.F_GLNO In (''212100'',''211200'',''212110'',''211210'',''211220'') THEN F_FCREDIT - F_FDEBIT ELSE F_FDEBIT - F_FCREDIT END) END), 2) AS F_Balance 
    FROM V_SLIPX T1 
        LEFT JOIN T_DEPODETAIL T2 ON T1.F_STBID = T2.F_ID AND T1.F_STBNAME = ''T_DEPODETAIL'' 
        LEFT JOIN T_CODEGLNO T3 on T3.F_GLNo = T1.F_GLNo 
    WHERE T1.F_GLNO = ''' + @F_GLNO + ''' 
        AND T1.F_COMID = ' + ltrim(str(@F_ENTITY)) + ' AND T1.F_CURRENCY = ''' + @F_BANKCUR + ''' 
        AND T1.F_TBTYPE NOT IN (''15'',''16'',''25'',''26'',''35'',''36'',''85'',''86'') AND (T1.F_TBNAME <> ''T_DEPOHD'' OR (T1.F_TBNAME = ''T_DEPOHD'' AND T2.F_TBNAME = '''')) 
        AND T1.F_POSTDATE Between ''' + @F_FROMDATE + ''' And ''' + @F_TODATE + ''' 
        ' + @S_WHERE + ' 
    GROUP BY T1.F_POSTDATE, T1.F_CURRENCY, T1.F_GLNO, T3.F_GLDescription ' 
 
INSERT #TEMP_DAILYJOUR     -- Step 2 : Accrual Date ~ Today까지 Daily Journal     
EXEC (@S_SELECT)   
 
SET @ACCBAL = Isnull((Select F_BALANCE From #TEMP_ACCBAL),0) 

DECLARE curNewJour CURSOR FAST_FORWARD FOR 
    SELECT 
        F_PostDate, F_GLDescription, F_Balance 
    FROM #TEMP_DAILYJOUR 
    ORDER BY F_PostDate 
OPEN curNewJour 
FETCH NEXT FROM curNewJour INTO @F_PostDate, @F_GLDescription, @F_Balance 
 
WHILE @@FETCH_STATUS = 0 
    BEGIN 
    -- Step 3 : Accrual Date(04/01/2019) < 최초 PostDate(04/05/2019) 인 경우 
    IF Convert(datetime, @F_ACCRUALDATE, 101) < Convert(datetime, @F_POSTDATE, 101) And @F_PAIDAMOUNT <> 0 
        BEGIN 
            SET @ACCBAL = @ACCBAL + @F_PAIDAMOUNT   -- 입력한 Paid Amount를 누적 
            SET @F_PAIDAMOUNT = 0 
 
            IF @ACCBAL < 0 
            BEGIN 
                Break; 
            END 
        END 
    -- Step 4 : PostDate(04/01/2019) < Accrual Date(04/02/2019) < PostDate(04/05/2019) 인 경우 


    IF Convert(datetime, @F_ACCRUALDATE, 101) <= Convert(datetime, @F_POSTDATE, 101) And @F_PAIDAMOUNT <> 0 
        BEGIN 
            SET @ACCBAL = @ACCBAL + @F_PAIDAMOUNT   -- 입력한 Paid Amount를 누적 
            SET @F_PAIDAMOUNT = 0 
        END 
 
    SET @ACCBAL = @ACCBAL + @F_Balance  -- Daily로 잔액을 누적 
    --SELECT @F_PostDate As PostDate, @ACCBAL As AccumulatedBal 
 
    IF @ACCBAL < 0 
        BEGIN 
            Break; 
        END 
 
    FETCH NEXT FROM curNewJour INTO @F_PostDate, @F_GLDescription, @F_Balance 
 
    END 
CLOSE curNewJour 
DEALLOCATE curNewJour 

SELECT @F_PostDate AS F_PostDate, @F_GLDescription As F_GLDesc, @ACCBAL As F_Balance 
END
" },
            { "up_InvoExJourM" ,
                @"
CREATE PROCEDURE up_InvoExJourM 
            @MTBName            VARCHAR(20), 
            @MBLId              INT 
AS 
 
BEGIN 
 
-- Make Temporary Table for V_BLSUMM 
SELECT * INTO #T_TEMP_BLSUMM FROM V_BLSUMM WHERE F_MTBName = @MTBName And F_MBLID = @MBLId; 
 
 
 
-- Table Prefix ------------------------------------- 
-- T1 : T_INVOHD 
-- T2 : T_INVODETAIL Or SUB QUERY FOR INVODETAIL 
-- T3 : Payment Info. 
-- T6 : T_NCODECHARGE 
-- T7 : T_COMPANY (Customer) 
-- T8 : V_BLSUMM 
----------------------------------------------------- 
-- Used Account Code  ------------------------------- 
-- D/R                  : 112600 - DUTY RECEIVABLE 
-- Duty2Customer        : 212630 - ADVANCE DUTY RECEIVED (CUSTOMER) 
-- Collect4Agt          : 212500 - COLLECT SALES FOR AGENT 
-- Loan2Agt             : 112500 - LOAN TO AGENT 
----------------------------------------------------- 
 
 
-- Sales / Deferred Sales ------------------------------------------------------------------------------------------------------------------------------ 
-- 11/1     A/R : X                            A/R                                      1,2,3,4,9 : Always 
-- 11/2     X : D.Sales                        Deferred Sales                           1,3,4 : Not Finalized Or (Finalized & Inv.Date <= Final.Date) 
-- 11/3     X : Sales                          Sales                                    1,3,4 : Finalized & Final.Date < Inv.Date,  9 : Always 
-- 11/4     X : Collect4Agt                    Collect4Agt (Agent)                      2 : Always 
-- 11/5     X : VAT                            VAT                                      If Vat Amount is not zero. 
-- 11/6     Adv.Rcv : X                        Advance Received                         If used Advance Received in Invoice 
-- 11/7     X : A/R                            Advance Received A/R                     If used Advance Received in Invoice 
-- Duty ------------------------------------------------------------------------------------------------------------------------------------------------ 
-- 11/8     D/R : X                            D/R                                      10 : Always   
-- 11/9     X : Duty2Customer                  Duty2Customer                            10 : Always    
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- Finalized ------------------------------------------------------------------------------------------------------------------------------------------- 
-- 13/1     D.Sales : X                        Deferred Sales                           1,3,4 : Finalized & Inv.Date <= Final.Date 
-- 13/2     X : Sales                          Sales                                    1,3,4 : Finalized & Inv.Date <= Final.Date 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- Use Advance Received in Payment --------------------------------------------------------------------------------------------------------------------- 
-- 15/1     Adv.Rcv : X                        Advance Received                         If used this invoice as Advance Received in Payment 
-- 15/2     X : A/R                            A/R                                      If used this invoice as Advance Received in Payment 
-- 16/1     A/R : X                            Void - A/R                               If used this invoice as Advance Received in Payment & Void 
-- 16/2     X : Adv.Rcv                        Void - Advance Received                  If used this invoice as Advance Received in Payment & Void 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 2018-06-25 chuck     : Change where condition T2.F_ChgType In (1,3,4) --> T2.F_ChgType Not In (2,9,10) 
-- 2018-09-14 chuck     : Advance Received/Advance Payments are applied to Duty AR/AP. 
-- 2018-11-09 chuck     : 11/3 - F_ChgType = 9 And F_CreditAPHDID > 0 --> Use F_Cost1 Account Code 
-- 2018-12-03 chuck     : Use G.Inv No in General Invoice (Inv No --> G.Inv No) 
-- 2019-01-30 chuck     : Support GST,HST,PST BillingCode. It will not make Deferred Sales/Cost Account Code 
-- 2019-02-22 chuck     : Use Finalize Action Date when make finalize journal. 
-- 2019-03-13 chuck     : 11/4 - T7.F_ID As F_ComID --> COALESCE(T7.F_ID, 0) As F_ComID 
-- 2019-03-25 chuck     : 15/1~2, 16/1~2 - Use Payment/Void Action Date for F_U2Date 
-- 2019-04-01 chuck     : Add F_RTBID for sub key Id 
 
-- 11/1     A/R : X                            A/R                                      1,2,3,4,9 : Always 
SELECT 1 As F_TBIndex, 1 As F_Order, 11 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVOHD' As F_STBName, T1.F_ID As F_STBID, (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN 'G.Inv No: ' ELSE 'Inv No: ' END) + T1.F_InvoiceNo As F_MDesc, 
    'OK' As F_BillCode, '' As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    T2.F_Amount As F_FDebit, 0 As F_FCredit, T1.F_RcvGLNo As F_GLNo, 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('11T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD T1 
    INNER JOIN ( 
        SELECT T2.F_InvoHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_INVOHD T1 
            INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
        WHERE T2.F_ChgType Not In (10,30) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_InvoHDID 
        HAVING ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) <> 0 
    ) T2 On (T2.F_InvoHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
 
UNION ALL 
 
-- 11/2     X : D.Sales                        Deferred Sales                           1,3,4 : Not Finalized Or (Finalized & Inv.Date <= Final.Date) 
SELECT 1 As F_TBIndex, 2 As F_Order, 11 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVODETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, '' As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    0 As F_FDebit, T2.F_Amount As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_DefSales', '')  As F_GLNo, 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('11T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD T1 
    INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType Not In (2,9,10) And (T8.F_ConfirmDate Is Null Or DATEDIFF(DAY, T8.F_ConfirmDate, T1.F_InvoiceDate) <= 0) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
    And SUBSTRING(T2.F_BillingCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
-- 11/3     X : Sales                          Sales                                    1,3,4 : Finalized & Final.Date < Inv.Date,  9 : Always 
SELECT 1 As F_TBIndex, 3 As F_Order, 11 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVODETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, '' As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    0 As F_FDebit, T2.F_Amount As F_FCredit,  
    --(CASE T2.F_ChgType WHEN 3 THEN T6.F_Sales3 WHEN 4 THEN T6.F_Sales5 ELSE T6.F_Sales1 END) As F_GLNo, 
    (CASE T2.F_ChgType WHEN 3 THEN T6.F_Sales3 WHEN 4 THEN T6.F_Sales5 ELSE (CASE WHEN T2.F_ChgType = 9 And T1.F_CreditAPHDId > 0 THEN T6.F_Cost1 ELSE T6.F_Sales1 END) END) As F_GLNo, 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('11T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD T1 
    INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
    LEFT JOIN T_NCODECHARGE T6 On (T6.F_Code = T2.F_BillingCode) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE (T2.F_ChgType = 9 Or SUBSTRING(T2.F_BillingCode, 1, 3) In ('GST','HST','PST','IVA') Or 
   (T2.F_ChgType Not In (2,9,10) And DATEDIFF(DAY, T8.F_ConfirmDate, T1.F_InvoiceDate) > 0)) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
 
UNION ALL 
 
-- 11/4     X : Collect4Agt                    Collect4Agt (Agent)                      2 : Always 
SELECT 1 As F_TBIndex, 4 As F_Order, 11 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, COALESCE(T7.F_ID, 0) As F_ComID, 'T_INVODETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END)+ T1.F_InvoiceNo + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, '' As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    0 As F_FDebit, T2.F_Amount As F_FCredit, '212500' As F_GLNo,    -- 212500 - COLLECT SALES FOR AGENT 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('11T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD T1 
    INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = CASE WHEN T2.F_Agent > 0 THEN T2.F_Agent ELSE T1.F_Agent END) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType = 2 And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
 
UNION ALL 
 
-- 11/5     X : VAT                            VAT                                      If Vat Amount is not zero. 
SELECT 1 As F_TBIndex, 5 As F_Order, 11 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVOHD' As F_STBName, T1.F_ID As F_STBID, 'VAT' + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    'OK' As F_BillCode, '' As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    0 As F_FDebit, (CASE WHEN T2.F_Amount = 0 THEN 0 ELSE ROUND(T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount), 2) END) As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_VATGLNO', '')  As F_GLNo, 
    0 As F_Debit, T2.F_VatAmount As F_Credit, 
    ('11T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD As T1 
    INNER JOIN ( 
        SELECT T2.F_InvoHDID, SUM(T2.F_VatAmount) As F_VatAmount, SUM(T2.F_LAmount) As F_LAmount, SUM(T2.F_Amount) As F_Amount 
        FROM T_INVOHD T1 
            INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
        WHERE T2.F_ChgType Not In (10,30) 
        GROUP BY T2.F_InvoHDID 
    ) T2 On (T2.F_InvoHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_VatAmount <> 0 
 
UNION ALL 
 
-- 11/6     Adv.Rcv : X                        Advance Received                         If used Advance Received in Invoice 
SELECT 1 As F_TBIndex, 6 As F_Order, 11 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVOHD' As F_STBName, T1.F_ID As F_STBID, (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN 'G.Inv No: ' ELSE 'Inv No: ' END) + T1.F_InvoiceNo As F_MDesc, 
    'OK' As F_BillCode, '' As F_SubCode, T1.F_Currency, 1 As F_ExRate, 
    F_AdvRecAmount As F_FDebit, 0 As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_ADVREC', '') As F_GLNo, 
    F_AdvRecAmount As F_Debit, 0 As F_Credit, 
    ('11T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD As T1 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T1.F_UseAdvRec = 1 And T1.F_AdvRecAmount <> 0 
 
UNION ALL 
 
-- 11/7     X : A/R                            Advance Received A/R                   If used Advance Received in Invoice 
SELECT 1 As F_TBIndex, 7 As F_Order, 11 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVOHD' As F_STBName, T1.F_ID As F_STBID, (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN 'G.Inv No: ' ELSE 'Inv No: ' END) + T1.F_InvoiceNo As F_MDesc, 
    'OK' As F_BillCode, '' As F_SubCode, T1.F_Currency, 1 As F_ExRate, 
    0 As F_FDebit, F_AdvRecAmount As F_FCredit, T1.F_RcvGLNo As F_GLNo, 
    0 As F_Debit, F_AdvRecAmount As F_Credit, 
    ('11T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD As T1 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T1.F_UseAdvRec = 1 And T1.F_AdvRecAmount <> 0 
 
UNION ALL 
 
 
-- Duty ------------------------------------------------------------------------------------------------------------------------------------------------ 
-- 11/8     D/R : X                            D/R                                      10 : Always  
-- 11/9     X : Duty2Customer                  Duty2Customer                            10 : Always  
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 11/8     D/R : X                            D/R                                      10 : Always  
SELECT 1 As F_TBIndex, 8 As F_Order, 11 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVOHD' As F_STBName, T1.F_ID As F_STBID, 'DUTY' + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    'OK' As F_BillCode, '' As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    T2.F_Amount As F_FDebit, 0 As F_FCredit, '112600' As F_GLNo,        -- 112600 - DUTY RECEIVABLE 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('11T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD T1 
    INNER JOIN ( 
        SELECT T2.F_InvoHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_INVOHD T1 
            INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
        WHERE T2.F_ChgType = 10 And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_InvoHDID 
    ) T2 On (T2.F_InvoHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
 
UNION ALL 
 
-- 11/9     X : Duty2Customer                  Duty2Customer                            10 : Always 
SELECT 1 As F_TBIndex, 9 As F_Order, 11 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_DutyEntity As F_ComID, 'T_INVODETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, '' As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    0 As F_FDebit, T2.F_Amount As F_FCredit, '212630' As F_GLNo,        -- 212630 - ADVANCE DUTY RECEIVED (CUSTOMER) 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('11T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD T1 
    INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_DutyEntity) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType = 10 And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
 
UNION ALL 
 
 
-- Finalized ------------------------------------------------------------------------------------------------------------------------------------------- 
-- 13/1     D.Sales : X                        Deferred Sales                           1,3,4 : Finalized & Inv.Date <= Final.Date 
-- 13/2     X : Sales                          Sales                                    1,3,4 : Finalized & Inv.Date <= Final.Date 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 13/1     D.Sales : X                        Deferred Sales                           1,3,4 : Finalized & Inv.Date <= Final.Date 
--SELECT 1 As F_TBIndex, 1 As F_Order, 13 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, 
SELECT 1 As F_TBIndex, 1 As F_Order, 13 As F_TBType, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmedBy ELSE T1.F_U2ID END) As F_U2ID, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmActionDate ELSE T1.F_U2Date END) As F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T8.F_ConfirmDate As F_InvoiceDate, T8.F_ConfirmDate As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVODETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, '' As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    T2.F_Amount As F_FDebit, 0 As F_FCredit, dbo.uf_Slip_GetFixedGLNo('F_DefSales', '') As F_GLNo, 
    T2.F_LAmount As F_Debit, 0 As F_Credit, 
    ('13T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD T1 
    INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType Not In (2,9,10) And DATEDIFF(DAY, T8.F_ConfirmDate, T1.F_InvoiceDate) <= 0 And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
    And SUBSTRING(T2.F_BillingCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
-- 13/2     X : Sales                          Sales                                    1,3,4 : Finalized & Inv.Date <= Final.Date 
--SELECT 1 As F_TBIndex, 2 As F_Order, 13 As F_TBType, T1.F_U2ID, T1.F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, 
SELECT 1 As F_TBIndex, 2 As F_Order, 13 As F_TBType, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmedBy ELSE T1.F_U2ID END) As F_U2ID, 
    (CASE WHEN T8.F_ConfirmActionDate > T1.F_U2Date THEN T8.F_ConfirmActionDate ELSE T1.F_U2Date END) As F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T1.F_ID As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, T8.F_ConfirmDate As F_InvoiceDate, T8.F_ConfirmDate As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVODETAIL' As F_STBName, T2.F_ID As F_STBID, T2.F_Description + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    T2.F_BillingCode As F_BillCode, '' As F_SubCode, T1.F_Currency, ROUND(T2.F_LAmount/T2.F_Amount, 4) As F_ExRate, 
    0 As F_FDebit, T2.F_Amount As F_FCredit, (CASE T2.F_ChgType WHEN 3 THEN T6.F_Sales3 WHEN 4 THEN T6.F_Sales5 ELSE T6.F_Sales1 END) As F_GLNo, 
    0 As F_Debit, T2.F_LAmount As F_Credit, 
    ('13T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD T1 
    INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
    LEFT JOIN T_NCODECHARGE T6 On (T6.F_Code = T2.F_BillingCode) 
   LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T2.F_ChgType Not In (2,9,10) And DATEDIFF(DAY, T8.F_ConfirmDate, T1.F_InvoiceDate) <= 0 And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
    And SUBSTRING(T2.F_BillingCode, 1, 3) Not In ('GST','HST','PST','IVA') 
 
UNION ALL 
 
 
-- Use Advance Received in Payment --------------------------------------------------------------------------------------------------------------------- 
-- 15/1     Adv.Rcv : X                        Advance Received                         If used this invoice as Advance Received in Payment 
-- 15/2     X : A/R                            A/R                                      If used this invoice as Advance Received in Payment 
-- 16/1     A/R : X                            Void - A/R                               If used this invoice as Advance Received in Payment & Void 
-- 16/2     X : Adv.Rcv                        Void - Advance Received                  If used this invoice as Advance Received in Payment & Void 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 
-- 15/1     Adv.Rcv : X                        Advance Received                         If used this invoice as Advance Received in Payment 
SELECT 1 As F_TBIndex, 1 As F_Order, 15 As F_TBType, T3.F_PayUser As F_U2ID, T3.F_PayDate As F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch,  T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVOHD' As F_STBName, T1.F_ID As F_STBID, 'Advance Received' + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    'OK' As F_BillCode, '' As F_SubCode, T1.F_Currency, (CASE WHEN T2.F_Amount = 0 THEN 1 ELSE ROUND(T2.F_LAmount/T2.F_Amount, 4) END) As F_ExRate, 
    T3.FPaidAmt As F_FDebit, 0 As F_FCredit, T3.F_GLNo As F_GLNo, 
    T3.PaidAmt As F_Debit, 0 As F_Credit, 
    ('15T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD As T1 
    INNER JOIN ( 
        SELECT T2.F_InvoHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_INVOHD T1 
            INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
        --WHERE T2.F_ChgType Not In (10,30) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        WHERE T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_InvoHDID 
    ) T2 On (T2.F_InvoHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, T2.F_U2ID As F_PayUser, T2.F_U2Date As F_PayDate, 
            ROUND(CASE WHEN F_Type = 'D' THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN F_Type = 'D' THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_INVOHD' And ROUND(CASE WHEN F_Type = 'D' THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo Not In (T1.F_RcvGLNo, '112600') And (T3.F_VoidDate Is Null Or DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0)      -- 112600 - DUTY RECEIVABLE 
 
UNION ALL 
 
-- 15/2     X : A/R                            A/R                                      If used this invoice as Advance Received in Payment 
SELECT 1 As F_TBIndex, 2 As F_Order, 15 As F_TBType, T3.F_PayUser As F_U2ID, T3.F_PayDate As F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch,  T1.F_InvoiceDate, T1.F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVOHD' As F_STBName, T1.F_ID As F_STBID, 'Advance Received' + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    'OK' As F_BillCode, '' As F_SubCode, T1.F_Currency, (CASE WHEN T2.F_Amount = 0 THEN 1 ELSE ROUND(T2.F_LAmount/T2.F_Amount, 4) END) As F_ExRate, 
    0 As F_FDebit, T3.FPaidAmt As F_FCredit, 
    --T1.F_RcvGLNo As F_GLNo,  
    (CASE WHEN T3.F_PayType = 'DT' THEN '112600' ELSE T1.F_RcvGLNo END) As F_GLNo,     -- 112600 - DUTY A/R 
    0 As F_Debit, T3.PaidAmt As F_Credit, 
    ('15T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD As T1 
    INNER JOIN ( 
        SELECT T2.F_InvoHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_INVOHD T1 
            INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
        --WHERE T2.F_ChgType Not In (10,30) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        WHERE T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_InvoHDID 
    ) T2 On (T2.F_InvoHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, T2.F_U2ID As F_PayUser, T2.F_U2Date As F_PayDate, 
            ROUND(CASE WHEN F_Type = 'D' THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN F_Type = 'D' THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_INVOHD' And ROUND(CASE WHEN F_Type = 'D' THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo Not In (T1.F_RcvGLNo, '112600') And (T3.F_VoidDate Is Null Or DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0)      -- 112600 - DUTY A/R 
 
UNION ALL 
 
-- 16/1     A/R : X                            Void - A/R                               If used this invoice as Advance Received in Payment & Void 
SELECT 1 As F_TBIndex, 1 As F_Order, 16 As F_TBType, T3.F_VoidInPutID As F_U2ID, T3.F_VoidInPutDate As F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, 
    T3.F_VoidDate As F_InvoiceDate, (CASE WHEN DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) > 0 THEN T1.F_InvoiceDate ELSE T3.F_VoidDate END) As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVOHD' As F_STBName, T1.F_ID As F_STBID, 'Void Advance Received' + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    'OK' As F_BillCode, '' As F_SubCode, T1.F_Currency, (CASE WHEN T2.F_Amount = 0 THEN 1 ELSE ROUND(T2.F_LAmount/T2.F_Amount, 4) END) As F_ExRate, 
    T3.FPaidAmt As F_FDebit, 0 As F_FCredit, 
    --T1.F_RcvGLNo As F_GLNo, 
    (CASE WHEN T3.F_PayType = 'DT' THEN '112600' ELSE T1.F_RcvGLNo END) As F_GLNo,     -- 112600 - DUTY A/R 
    T3.PaidAmt As F_Debit, 0 As F_Credit, 
    ('16T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD As T1 
    INNER JOIN ( 
        SELECT T2.F_InvoHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_INVOHD T1 
            INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
        --WHERE T2.F_ChgType Not In (10,30) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        WHERE T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_InvoHDID 
    ) T2 On (T2.F_InvoHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, (CASE WHEN LEN(T2.F_VoidinPutID) > 0 THEN T2.F_VoidinPutID ELSE T2.F_U2ID END) As F_VoidinPutID, COALESCE(T2.F_VoidinPutDate, T2.F_U2Date) As F_VoidinPutDate, 
            ROUND(CASE WHEN F_Type = 'D' THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN F_Type = 'D' THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_INVOHD' And T2.F_Void = '1' And ROUND(CASE WHEN F_Type = 'D' THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo Not In (T1.F_RcvGLNo, '112600') And DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0    -- 112600 - DUTY RECEIVABLE 
 
UNION ALL 
 
-- 16/2     X : Adv.Rcv                        Void - Advance Received                  If used this invoice as Advance Received in Payment & Void 
SELECT 1 As F_TBIndex, 2 As F_Order, 16 As F_TBType, T3.F_VoidInPutID As F_U2ID, T3.F_VoidInPutDate As F_U2Date, 'T_INVOHD' As F_TBName, T1.F_ID As F_TBID, T3.F_PayId As F_RTBID, 
    COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '') As F_Branch, 
    T3.F_VoidDate As F_InvoiceDate, (CASE WHEN DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) > 0 THEN T1.F_InvoiceDate ELSE T3.F_VoidDate END) As F_PostDate, 
    'C' As F_ComType, COALESCE(T7.F_SName, '') As F_ComName, T1.F_BillTo As F_ComID, 'T_INVOHD' As F_STBName, T1.F_ID As F_STBID, 'Void Advance Received' + (CASE WHEN T1.F_TBName = '' And T1.F_JobName = '' THEN ' (G.Inv No: ' ELSE ' (Inv No: ' END) + T1.F_InvoiceNo + ')' As F_MDesc, 
    'OK' As F_BillCode, '' As F_SubCode, T1.F_Currency, (CASE WHEN T2.F_Amount = 0 THEN 1 ELSE ROUND(T2.F_LAmount/T2.F_Amount, 4) END) As F_ExRate, 
    0 As F_FDebit, T3.FPaidAmt As F_FCredit, T3.F_GLNo As F_GLNo, 
    0 As F_Debit, T3.PaidAmt As F_Credit, 
    ('16T_INVOHD' + LTRIM(STR(T1.F_ID)) + COALESCE(CASE WHEN T1.F_InvoBranch <> '' THEN T1.F_InvoBranch ELSE T8.F_Branch END, T1.F_Branch, '')) As F_Key, T1.F_Void, T8.F_MBLID, T8.F_MTBName 
FROM T_INVOHD As T1 
    INNER JOIN ( 
        SELECT T2.F_InvoHDID, ROUND(SUM(T2.F_LAmount + T2.F_VatAmount), 2) As F_LAmount, 
            ROUND(SUM(T2.F_Amount + CASE WHEN T2.F_VatAmount = 0 THEN 0 ELSE T2.F_VatAmount/(T2.F_LAmount/T2.F_Amount) END), 2) As F_Amount 
        FROM T_INVOHD T1 
            INNER JOIN T_INVODETAIL T2 On (T2.F_InvoHDID = T1.F_ID) 
        --WHERE T2.F_ChgType Not In (10,30) And T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        WHERE T2.F_LAmount <> 0 And T2.F_Amount <> 0 
        GROUP BY T2.F_InvoHDID 
    ) T2 On (T2.F_InvoHDID = T1.F_ID) 
    INNER JOIN ( 
        SELECT T2.F_ID As F_PayId, T1.F_TBID, T1.F_GLNo, T1.F_PayType, T2.F_VoidDate, (CASE WHEN LEN(T2.F_VoidinPutID) > 0 THEN T2.F_VoidinPutID ELSE T2.F_U2ID END) As F_VoidinPutID, COALESCE(T2.F_VoidinPutDate, T2.F_U2Date) As F_VoidinPutDate, 
            ROUND(CASE WHEN F_Type = 'D' THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) As PaidAmt, 
            ROUND(CASE WHEN F_Type = 'D' THEN T1.F_Amount ELSE - T1.F_Amount END, 2) As FPaidAmt 
        FROM T_DEPODETAIL T1 
            LEFT JOIN T_DEPOHD T2 On (T2.F_ID = T1.F_DepoHDID) 
        WHERE T1.F_TBName = 'T_INVOHD' And T2.F_Void = '1' And ROUND(CASE WHEN F_Type = 'D' THEN T1.F_OAmount ELSE - T1.F_OAmount END, 2) <> 0 
    ) T3 On (T3.F_TBID = T1.F_ID) 
    LEFT JOIN T_COMPANY T7 On (T7.F_ID = T1.F_BillTo) 
    INNER JOIN #T_TEMP_BLSUMM T8 On (T8.F_TBID = T1.F_TBID And T8.F_TBName = T1.F_TBName) 
WHERE T3.F_GLNo Not In (T1.F_RcvGLNo, '112600') And DATEDIFF(DAY, T3.F_VoidDate, T1.F_InvoiceDate) <= 0     --  112600 - DUTY RECEIVABLE 
 
-------------------------------------------------------------------------------------------------------------------------------------------------------- 
 

DROP TABLE #T_TEMP_BLSUMM; 
 
END
" },
            { "up_MatchAdvanceAcctCode" ,
                @"
CREATE PROCEDURE [dbo].[up_MatchAdvanceAcctCode] 
            @TBName            VARCHAR(20), 
            @TBId              INT, 
            @InvDate           DATETIME, 
            @GLNo              VARCHAR(10), 
            @U2Id              VARCHAR(15) 
AS 
 
BEGIN 
 
SET NOCOUNT ON 
 
DECLARE @nRecDepoId INT, @nRecDepoLineId INT 
DECLARE @sAdvGLNo VARCHAR(10) 
 
SET @sAdvGLNo = (CASE WHEN @TBName = 'T_INVOHD' THEN '212100' ELSE '112100' END); 
 

DECLARE curDepoInfo CURSOR FAST_FORWARD FOR 
    ------------------------------------------------------------------------------------------ 
    select T2.F_ID As DepoID, T1.F_ID As DepoLineId 
    from T_DEPODETAIL T1 
        inner join T_DEPOHD T2 On (T2.F_ID = T1.F_DEPOHDID) 
    where T2.F_Void = 1 And T1.F_TBID = @TBId And T1.F_TBName = @TBName 
        And T1.F_GLNo = @sAdvGLNo And T2.F_PostDate >= @InvDate 
    ------------------------------------------------------------------------------------------ 
 
OPEN curDepoInfo 
FETCH NEXT FROM curDepoInfo INTO @nRecDepoId, @nRecDepoLineId 
 

WHILE @@FETCH_STATUS = 0 
    BEGIN 
  
    -- 01. update Advance to Normal 
    update T_DEPODETAIL set F_GLNo = @GLNo where F_ID = @nRecDepoLineId; 
  
    -- 02. Call SaveNewJournalByTask 
    exec dbo.up_SaveNewJournalByTask 'T_DEPOHD', @nRecDepoId, @U2Id; 
 
    --Fetch 
    FETCH NEXT FROM curDepoInfo INTO @nRecDepoId, @nRecDepoLineId 
 
    End 
 
Close curDepoInfo 
DEALLOCATE curDepoInfo 
 
 
SET NOCOUNT OFF 
 
End
" },
            { "up_NewBS" ,
                @"
CREATE PROCEDURE up_NewBS 
            @ArgEndDate         DATETIME 
AS 
 
BEGIN 
 
SET NOCOUNT ON 
 
-- Special G/L No ---------------------------------------------- 
-- '331099' - Year End Processing Status    -1 : Yes, 0 : No 
-- '331100' - Retained Earning 
-- '399999' - Net Income 
---------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------------------------------- 
DECLARE @FiscalEndMonth INT, @BeginMonth INT 
DECLARE @ActStartDate DATETIME, @LastStartDate DATETIME 
DECLARE @FromDate3 DATETIME, @ToDate3 DATETIME, @BeginDate3 DATETIME, @ToFullDate3 DATETIME 
DECLARE @FromDate2 DATETIME, @ToDate2 DATETIME, @BeginDate2 DATETIME, @ToFullDate2 DATETIME 
DECLARE @FromDate1 DATETIME, @ToDate1 DATETIME, @BeginDate1 DATETIME, @ToFullDate1 DATETIME 
 
SET @FiscalEndMonth = (SELECT TOP 1 F_N2 FROM T_AOTHERINFO WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27) 
SET @BeginMonth = (CASE WHEN @FiscalEndMonth = 12 THEN 1 ELSE @FiscalEndMonth + 1 END) 
 
SET @ActStartDate = CONVERT(DATETIME, CONVERT(VARCHAR(6),(SELECT TOP 1 F_C3 FROM T_AOTHERINFO WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27)) + '01') 
SET @LastStartDate = (SELECT MAX(F_PostDate) As LastBeginDate FROM T_SLIPHD WHERE F_Type IN ('X', 'B', 'DB', 'CB')) 
SET @LastStartDate = (CASE WHEN @LastStartDate Is Null THEN @ActStartDate ELSE @LastStartDate END) 
 
--DATEFROMPARTS 함수는 MSSQL 2008버전에서는 오류 발생
--SET @FromDate3 = DATEFROMPARTS(CASE WHEN DATEPART(mm, @ArgEndDate) >= @BeginMonth THEN DATEPART(yyyy, @ArgEndDate) ELSE DATEPART(yyyy, @ArgEndDate) - 1 END, @BeginMonth, 1) 
SET @FromDate3 = CAST(CONVERT(VARCHAR, CASE WHEN DATEPART(mm, @ArgEndDate) >= @BeginMonth THEN DATEPART(yyyy, @ArgEndDate) ELSE DATEPART(yyyy, @ArgEndDate) - 1 END) + '-' + CONVERT(VARCHAR, @BeginMonth) + '-' + CONVERT(VARCHAR, 1) AS DATETIME)
SET @ToDate3 = DATEADD(dd, -1, DATEADD(yyyy, 1, @FromDate3)) 
SET @ToFullDate3 = DATEADD(ss, -1, DATEADD(dd, 1, @ArgEndDate)) 
SET @BeginDate3 = (CASE WHEN @LastStartDate >= @FromDate3 THEN @FromDate3 ELSE @LastStartDate END) 
 
SET @FromDate2 = DATEADD(yyyy, -1, @FromDate3) 
SET @ToDate2 = DATEADD(yyyy, -1, @ToDate3) 
SET @ToFullDate2 = DATEADD(ss, -1, @FromDate3) 
SET @BeginDate2 = (CASE WHEN @LastStartDate >= @FromDate2 THEN @FromDate2 ELSE @LastStartDate END) 
 
SET @FromDate1 = DATEADD(yyyy, -1, @FromDate2) 
SET @ToDate1 = DATEADD(yyyy, -1, @ToDate2) 
SET @ToFullDate1 = DATEADD(ss, -1, @FromDate2) 
SET @BeginDate1 = (CASE WHEN @LastStartDate >= @FromDate1 THEN @FromDate1 ELSE @LastStartDate END) 
------------------------------------------------------------------------------------------------------------------------------- 
 
 
SELECT 
    XX.F_GLNO, XX.F_GROUP1, XX.F_GROUP2, XX.F_GROUP3, XX.F_DESC, 
    SUM(XX.F_Amount3) AS F_Amount3, SUM(XX.F_Amount2) AS F_Amount2, SUM(XX.F_Amount1) AS F_Amount1 
FROM ( 
    SELECT 
        (CASE WHEN T2.F_GLType = 'A' THEN 'A' ELSE 'LQ' END) As F_GROUP1, 
        (CASE WHEN T2.F_GLGroup IN ('CA','IA','FA') THEN 'A' 
              WHEN T2.F_GLGroup = 'CL' THEN 'L' 
              WHEN T2.F_GLGroup IN ('SQ','CQ','NQ') or T1.F_GLNo = 'NETINCOME' THEN 'Q' 
              ELSE T2.F_GLGroup END) AS F_GROUP2, 
        (CASE WHEN T2.F_GLSubGroup IN ('SQ','CQ') THEN 'QQ' 
              WHEN T2.F_GLSubGroup = 'NQ' or T2.F_GLSubGroup Is Null Then 'NQ' 
              WHEN T2.F_GLSubGroup IN ('TA','GA') THEN 'FA' 
              ELSE T2.F_GLSubGroup END) AS F_GROUP3, 
        (CASE WHEN T1.F_GLNo IN ('212400','212410') THEN '212410' 
              WHEN T1.F_GLNO = 'YEAREND' THEN '331099' 
              WHEN T1.F_GLNO = 'NETINCOME' THEN '399999' 
              ELSE T1.F_GLNO END) AS F_GLNO, 
        (CASE WHEN T1.F_GLNo IN ('212400','212410') THEN 'TAX PAYABLE' 
              WHEN T1.F_GLNO = 'NETINCOME' THEN 'NET INCOME' 
              ELSE T2.F_GLDescription END) AS F_DESC, 
        SUM(CASE WHEN T2.F_GLType = 'A' THEN F_Amount3 ELSE -F_Amount3 END) As F_Amount3, 
        SUM(CASE WHEN T2.F_GLType = 'A' THEN F_Amount2 ELSE -F_Amount2 END) As F_Amount2, 
        SUM(CASE WHEN T2.F_GLType = 'A' THEN F_Amount1 ELSE -F_Amount1 END) As F_Amount1 
    FROM ( 
        SELECT 
            (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo WHEN T1.F_PostDate < @FromDate3 THEN 'RETAINED' ELSE 'NETINCOME' END) As F_GLNo, 
            ROUND(SUM(CASE WHEN T1.F_PostDate Between @BeginDate3 And @ToFullDate3 
                And Not (T1.F_PostDate = @ToDate3 And T1.F_Type = 'X' And T1.F_SeqNo In (98,99)) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount3, 
            0 As F_Amount2, 
            0 As F_Amount1 
        FROM V_SlipX T1 
            INNER JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
        WHERE T1.F_PostDate Between @BeginDate3 And @ToFullDate3 And T1.F_PostDate >= @ActStartDate 
        GROUP BY (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo WHEN T1.F_PostDate < @FromDate3 THEN 'RETAINED' ELSE 'NETINCOME' END) 
 
        UNION ALL 
 
        SELECT 
            (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo WHEN T1.F_PostDate < @FromDate2 THEN 'RETAINED' ELSE 'NETINCOME' END) As F_GLNo, 
            0 As F_Amount3, 
            ROUND(SUM(CASE WHEN T1.F_PostDate Between @BeginDate2 And @ToFullDate2 
                And Not (T1.F_PostDate = @ToDate2 And T1.F_Type = 'X' And T1.F_SeqNo In (98,99)) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount2, 
            0 As F_Amount1 
        FROM V_SlipX T1 
            INNER JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
        WHERE T1.F_PostDate Between @BeginDate2 And @ToFullDate2 And T1.F_PostDate >= @ActStartDate 
        GROUP BY (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo WHEN T1.F_PostDate < @FromDate2 THEN 'RETAINED' ELSE 'NETINCOME' END) 
 
        UNION ALL 
 
        SELECT 
            (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo WHEN T1.F_PostDate < @FromDate1 THEN 'RETAINED' ELSE 'NETINCOME' END) As F_GLNo, 
            0 As F_Amount3, 
            0 As F_Amount2, 
            ROUND(SUM(CASE WHEN T1.F_PostDate Between @BeginDate1 And @ToFullDate1 
                And Not (T1.F_PostDate = @ToDate1 And T1.F_Type = 'X' And T1.F_SeqNo In (98,99)) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount1 
        FROM V_SlipX T1 
            INNER JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
        WHERE T1.F_PostDate Between @BeginDate1 And @ToFullDate1 And T1.F_PostDate >= @ActStartDate 
        GROUP BY (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo WHEN T1.F_PostDate < @FromDate1 THEN 'RETAINED' ELSE 'NETINCOME' END) 
 
        Union ALL SELECT '331100' As F_GLNo, 0 As F_Amount3, 0 As F_Amount2, 0 As F_Amount1 
        Union ALL SELECT 'NETINCOME' As F_GLNo, 0 As F_Amount3, 0 As F_Amount2, 0 As F_Amount1 
        Union ALL 
        SELECT 'YEAREND' As F_GLNo, (CASE WHEN @FromDate3 >= @LastStartDate THEN 0 ELSE 1 END) As F_Amount3, 
            (CASE WHEN @FromDate2 >= @LastStartDate THEN 0 ELSE 1 END) As F_Amount2, 
            (CASE WHEN @FromDate1 >= @LastStartDate THEN 0 ELSE 1 END) As F_Amount1 
    ) T1 
        LEFT JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
    WHERE T1.F_GLNo <> 'RETAINED' 
    GROUP BY (CASE WHEN T2.F_GLType = 'A' THEN 'A' ELSE 'LQ' END), T2.F_GLGroup, T2.F_GLSubGroup, T1.F_GLNo, T2.F_GLDescription 
    HAVING SUM(F_Amount1) <> 0 Or SUM(F_Amount2) <> 0 Or SUM(F_Amount3) <> 0 Or T1.F_GLNO In ('YEAREND','331100','NETINCOME') 
) XX 
GROUP BY XX.F_GLNO, XX.F_GROUP1, XX.F_GROUP2, XX.F_GROUP3, XX.F_DESC 
ORDER BY XX.F_GLNO 
 
SET NOCOUNT OFF 
 
END

" },
            { "up_NewJourByMBLTemp" ,
                @"
CREATE PROCEDURE up_NewJourByMBLTemp 
            @MTBName            VARCHAR(20), 
            @MBLId              INT 
AS 
 
BEGIN 
 
INSERT INTO #TEMP_V_NEWJOUR 
EXEC (' 
    EXEC dbo.up_InvoExJourM ''' + @MTBName + ''', ' + @MBLId + '; 
    EXEC dbo.up_ApExJourM ''' + @MTBName + ''', ' + @MBLId + '; 
    EXEC dbo.up_CrDbExJourM ''' + @MTBName + ''', ' + @MBLId + '; 
'); 
 
UPDATE #TEMP_V_NEWJOUR SET 
    F_ComType = (CASE WHEN F_ComType = '' THEN 'C' ELSE F_ComType END), 
    F_ExRate = ROUND(F_ExRate, 4), 
    F_FDebit = (CASE WHEN F_FDebit > 0 THEN F_FDebit WHEN F_FCredit < 0 THEN -F_FCredit ELSE 0 END), 
    F_FCredit = (CASE WHEN F_FCredit > 0 THEN F_FCredit WHEN F_FDebit < 0 THEN -F_FDebit ELSE 0 END), 
    F_Debit = (CASE WHEN F_Debit > 0 THEN F_Debit WHEN F_Credit < 0 THEN -F_Credit ELSE 0 END), 
    F_Credit = (CASE WHEN F_Credit > 0 THEN F_Credit WHEN F_Debit < 0 THEN -F_Debit ELSE 0 END); 
 
END 
" },
            { "up_NewTB" ,
                @"
CREATE PROCEDURE up_NewTB 
            @FromDate           DATETIME, 
            @ToDate             DATETIME, 
            @bUseLocalLanguage  BIT 
AS 
 
BEGIN 
 
SET NOCOUNT ON 
 
---------------- 
--DECLARE @FromDate Datetime, @ToDate Datetime 
--SELECT @FromDate = '2019-01-01', @ToDate = '2019-11-08 23:59:59' 
---------------- 
------------------------------------------------------------------------------------------------------------------------------- 
DECLARE @ActStartDate As Datetime, @LastStartDate As Datetime 
DECLARE @BeginDate As Datetime 
 
SET @ActStartDate = CONVERT(DATETIME, CONVERT(VARCHAR(6),(SELECT TOP 1 F_C3 FROM T_AOTHERINFO WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27)) + '01') 
SET @LastStartDate = (SELECT MAX(F_PostDate) As LastBeginDate FROM T_SLIPHD WHERE F_Type IN ('X', 'B', 'DB', 'CB')) 
SET @LastStartDate = (CASE WHEN @LastStartDate Is Null THEN @ActStartDate ELSE @LastStartDate END) 
SET @BeginDate = (CASE WHEN @LastStartDate >= @FromDate THEN @FromDate ELSE @LastStartDate END) 
------------------------------------------------------------------------------------------------------------------------------- 
 
SELECT 
    (CASE WHEN (T2.F_GLType = 'E' And T2.F_GLGroup = 'OE') Or (T2.F_GLType = 'I' And T2.F_GLGroup = 'OI') THEN T2.F_GLSubGroup ELSE T2.F_GLType END) AS F_GLType, 
    T2.F_GLGroup, 
    (CASE WHEN @bUseLocalLanguage = 1 THEN (CASE WHEN T2.F_LocalDesc IS NULL Or T2.F_LocalDesc = '' THEN T2.F_GLDescription ELSE T2.F_LocalDesc END) ELSE T2.F_GLDescription END) As F_Desc, 
    T2.F_LocalDesc, T1.F_GLNo, 
    (CASE WHEN T2.F_GLType In ('L', 'Q', 'I') Or T2.F_GLGroup = 'OI' THEN 0                                                     ELSE ROUND(T1.F_Debit + T1.F_BeginBal - T1.F_Credit,4)  END) As F_DebitBal, 
    (CASE WHEN T2.F_GLType In ('L', 'Q', 'I') Or T2.F_GLGroup = 'OI' THEN ROUND(T1.F_Credit - T1.F_BeginBal - T1.F_Debit,4)     ELSE 0                                                  END) As F_CreditBal, 
    (CASE WHEN T2.F_GLType In ('L', 'Q', 'I') Or T2.F_GLGroup = 'OI' THEN T1.F_Debit                                            ELSE ROUND(T1.F_Debit + T1.F_BeginBal,4)                END) As F_Debit, 
    (CASE WHEN T2.F_GLType In ('L', 'Q', 'I') Or T2.F_GLGroup = 'OI' THEN ROUND(T1.F_Credit - T1.F_BeginBal,4)                  ELSE T1.F_Credit                                        END) As F_Credit, 
    (CASE T2.F_GLType 
        WHEN 'A' THEN (CASE T2.F_GLGroup WHEN 'CA' THEN 101 WHEN 'IA' THEN 101 WHEN 'FA' THEN 102 ELSE 189 END) 
        WHEN 'L' THEN 202 
        WHEN 'Q' THEN (CASE T2.F_GLGroup WHEN 'SQ' THEN 301 WHEN 'CQ' THEN 302 WHEN 'NQ' THEN 303 ELSE 389 END) 
        WHEN 'I' THEN (CASE T2.F_GLGroup WHEN 'II' THEN 401 WHEN 'EI' THEN 402 WHEN 'AI' THEN 403 WHEN 'PI' THEN 404 WHEN 'TI' THEN 405 WHEN 'WI' THEN 406 WHEN 'FF' THEN 407 WHEN 'CH' THEN 408 
        WHEN 'OI' THEN (CASE T2.F_GLSubGroup WHEN 'OI' THEN 701 WHEN 'SI' THEN 861 ELSE 0 END) ELSE 589 END) 
        WHEN 'C' THEN (CASE T2.F_GLGroup WHEN 'IC' THEN 501 WHEN 'EC' THEN 502 WHEN 'AC' THEN 503 WHEN 'PC' THEN 504 WHEN 'TC' THEN 505 WHEN 'WC' THEN 506 WHEN 'FF' THEN 507 WHEN 'CH' THEN 508 ELSE 689 END) 
        WHEN 'E' THEN (CASE T2.F_GLSubGroup WHEN 'GE' THEN  601 WHEN 'OE' THEN 851 WHEN 'SE' THEN 871 WHEN 'IT' THEN 881 ELSE 0 END) ELSE 901 END) As F_Order 
FROM ( 
 
    SELECT T1.F_GLNo, 
        ROUND(SUM(CASE WHEN T1.F_Type In ('X', 'B', 'DB', 'CB') And T1.F_PostDate = @FromDate THEN T1.F_Debit - T1.F_Credit 
                       WHEN @BeginDate <= T1.F_PostDate And T1.F_PostDate < @FromDate And T2.F_GLTYPE IN ('A','L','Q') THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_BeginBal, 
        ROUND(SUM(CASE WHEN T1.F_Type Not In ('X', 'B', 'DB', 'CB') And T1.F_PostDate Between @FromDate And @ToDate THEN T1.F_Debit ELSE 0 END), 4) As F_Debit, 
        ROUND(SUM(CASE WHEN T1.F_Type Not In ('X', 'B', 'DB', 'CB') And T1.F_PostDate Between @FromDate And @ToDate THEN T1.F_Credit ELSE 0 END), 4) As F_Credit 
    FROM V_SlipX T1 
        LEFT JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
    WHERE T1.F_PostDate Between @BeginDate And @ToDate 
    GROUP BY T1.F_GLNo 
 
) T1 
    LEFT JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
WHERE T1.F_BeginBal <> 0 Or T1.F_Debit <> 0 Or T1.F_Credit <> 0 
 
UNION ALL 
SELECT 'A', 'XX', '', '', '999910', 0, 0, 0, 0, 199 
UNION ALL 
SELECT 'L', 'XX', '', '', '999920', 0, 0, 0, 0, 299 
UNION ALL 
SELECT 'Q', 'XX', '', '', '999930', 0, 0, 0, 0, 399 
UNION ALL 
SELECT 'I', 'XX', '', '', '999940', 0, 0, 0, 0, 499 
UNION ALL 
SELECT 'C', 'XX', '', '', '999950', 0, 0, 0, 0, 599 
UNION ALL 
SELECT 'E', 'XX', '', '', '999960', 0, 0, 0, 0, 699 
UNION ALL 
SELECT 'OI', 'XX', '', '', '999970', 0, 0, 0, 0, 799 
UNION ALL 
SELECT 'OE', 'XX', '', '', '999980', 0, 0, 0, 0, 859 
UNION ALL 
SELECT 'SI', 'XX', '', '', '999990', 0, 0, 0, 0, 869 
UNION ALL 
SELECT 'SE', 'XX', '', '', '999991', 0, 0, 0, 0, 879 
UNION ALL 
SELECT 'IT', 'XX', '', '', '999992', 0, 0, 0, 0, 889 
 
ORDER BY F_Order, F_GLType, F_GLGroup, T1.F_GLNo 
 
SET NOCOUNT OFF 
 
END
" },
            { "up_SaveJournalByTask" ,
                @"
CREATE  PROCEDURE up_SaveJournalByTask 
            @JobName            VARCHAR(20), 
            @JobId              INT, 
            @JobType            INT 
As 
 
/* Delete Journal */ 
 
-- Step 01 : T_NSlipKey 
Delete T1 
FROM T_NSLIPKEY T1 
    LEFT JOIN V_NewJour T2 On (T2.F_Key = T1.F_Key) 
WHERE T2.F_TBName = @JobName And T2.F_TBID = @JobId 
    And T1.F_TBType < 100 And T1.F_Key Not like '10T_SLIPHD%' 
    And (T2.F_Key Is Null Or DateDiff(Day, T2.F_PostDate, T1.F_Date) <> 0) 
 
-- Step 02 : T_NEWJOUR 
Delete T1 
FROM T_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate) 
WHERE T1.F_TBName = @JobName And T1.F_TBID = @JobId And T2.F_ID Is Null 
 
 
/* Insert Journal */ 
 
-- Sub 01 : T_NEWJOUR 
INSERT INTO T_NEWJOUR (F_Key, F_TBIndex, F_Order, F_TBType, F_PostDate, F_SeqNo, F_Branch, F_TBName, F_TBID, F_STBName, 
    F_STBID, F_ComType, F_ComId, F_ComName, F_GLNo, F_SubCode, F_Debit, F_Credit, F_Currency, F_ExRate, F_FDebit, 
    F_FCredit, F_MDesc, F_U2ID, F_U2Date, F_Void, F_MBLID, F_MTBName) 
SELECT LTRIM(STR(T1.F_TBType)) + T1.F_TBName + LTRIM(STR(T1.F_TBID)) + T1.F_Branch, T1.F_TBIndex, T1.F_Order, 
    T1.F_TBType, F_PostDate, 0, T1.F_Branch, T1.F_TBName, T1.F_TBID, T1.F_STBName, 
    T1.F_STBID, T1.F_ComType, ISNULL(T1.F_ComId,0), ISNULL(T1.F_ComName,''), T1.F_GLNo, T1.F_SubCode, 
    (CASE WHEN T1.F_Credit < 0 THEN -T1.F_Credit WHEN T1.F_Debit > 0 THEN T1.F_Debit ELSE 0 END), 
    (CASE WHEN T1.F_Debit < 0 THEN -T1.F_Debit WHEN T1.F_Credit > 0 THEN T1.F_Credit ELSE 0 END), 
    F_Currency, F_ExRate, 
    (CASE WHEN T1.F_FCredit < 0 THEN -T1.F_FCredit WHEN T1.F_FDebit > 0 THEN T1.F_FDebit ELSE 0 END), 
    (CASE WHEN T1.F_FDebit < 0 THEN -T1.F_FDebit WHEN T1.F_FCredit > 0 THEN T1.F_FCredit ELSE 0 END), 
    T1.F_MDesc, T1.F_U2ID, T1.F_U2Date, T1.F_Void, ISNULL(T1.F_MBLID, 0), ISNULL(T1.F_MTBName, '') 
FROM V_NewJour T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key) 
WHERE T1.F_TBName = @JobName And T1.F_TBID = @JobId And T2.F_ID IS Null 
 
 
-- Sub 02 : T_NSlipKey 
INSERT INTO T_NSLIPKEY (F_Key, F_TBID, F_TBName, F_TBType, F_Date, F_Branch, F_Seq, F_UPD, F_U1ID, F_U1Date) 
SELECT T1.F_key, T1.F_TBID, T1.F_TBNAME, T1.F_TBType, T1.F_PostDate, T1.F_Branch, 0, 9, 'SiS', GETDATE() 
FROM T_NEWJOUR T1 
WHERE T1.F_TBName = @JobName And T1.F_TBID = @JobId And T1.F_SeqNo = 0 
GROUP BY T1.F_key, T1.F_TBID, T1.F_TBName, T1.F_TBType, T1.F_PostDate, T1.F_Branch 
 
 
-- Sub 03 : SET SeqNo of T_NSlipKey 
UPDATE T1 SET F_Seq = ( 
    SELECT ISNULL(MSEQ,0) + COUNT(*) 
    FROM T_NSLIPKEY S 
    Where s.F_ID <= t1.F_ID And s.F_Date = t1.F_Date And s.F_Branch = t1.F_Branch And s.F_SEQ = 0 
    ) 
FROM T_NSLIPKEY T1 
    LEFT JOIN ( 
        SELECT MAX(F_Seq) AS MSEQ, F_Date, F_Branch 
        From T_NSLIPKEY 
        GROUP BY F_Date, F_Branch 
    ) T2 On (T2.F_Date = T1.F_Date And T2.F_Branch = T1.F_Branch) 
WHERE T1.F_SEQ = 0 
 
 
-- Sub 04 : SET SeqNo of T_NEWJOUR 
UPDATE T1 SET F_SeqNo = T2.F_Seq 
FROM T_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_key = T1.F_key) 
WHERE T1.F_SeqNo = 0 And T2.F_UPD = 9 
 
 
-- Sub 05 : SET F_UPD of T_NSLIPKEY 
UPDATE T_NSLIPKEY SET F_UPD = 0 WHERE F_UPD = 9 

" },
            { "up_SaveNewJournalByMaster" ,
                @"
CREATE PROCEDURE up_SaveNewJournalByMaster 
            @MTBName           VARCHAR(20), 
            @MBLId             INT, 
            @U2Id              VARCHAR(15) = '' 
AS 
 
BEGIN 
 
SET NOCOUNT ON 
DECLARE @sRecKey As VARCHAR(20), @sRecPostDate As DATETIME, @nRecRTBID As INT, @dRecU2Date As DATETIME  
 
CREATE TABLE #TEMP_V_NEWJOUR ( 
    F_TBIndex       INT, 
    F_Order         INT, 
    F_TBType        INT, 
    F_U2ID          VARCHAR(70) COLLATE DATABASE_DEFAULT, 
    F_U2Date        DATETIME, 
    F_TBName        VARCHAR(20) COLLATE DATABASE_DEFAULT, 
    F_TBId          INT, 
    F_RTBId         INT, 
    F_Branch        VARCHAR(3) COLLATE DATABASE_DEFAULT, 
    F_InvoiceDate   DATETIME, 
    F_PostDate      DATETIME, 
    F_ComType       VARCHAR(1) COLLATE DATABASE_DEFAULT, 
    F_ComName       VARCHAR(50) COLLATE DATABASE_DEFAULT, 
    F_ComId         INT, 
    F_STBName       VARCHAR(20) COLLATE DATABASE_DEFAULT, 
    F_STBID         INT, 
    F_MDesc         NVARCHAR(500) COLLATE DATABASE_DEFAULT, 
    F_BillCode      VARCHAR(30) COLLATE DATABASE_DEFAULT, 
    F_SubCode       NVARCHAR(40) COLLATE DATABASE_DEFAULT, 
    F_Currency      VARCHAR(3) COLLATE DATABASE_DEFAULT, 
    F_ExRate        FLOAT, 
    F_FDebit        FLOAT, 
    F_FCredit       FLOAT, 
    F_GLNo          VARCHAR(20) COLLATE DATABASE_DEFAULT, 
    F_Debit         FLOAT, 
    F_Credit        FLOAT, 
    F_Key           VARCHAR(35) COLLATE DATABASE_DEFAULT, 
    F_Void          INT, 
    F_MBLID         INT, 
    F_MTBName       VARCHAR(10) COLLATE DATABASE_DEFAULT 
); 
 
-- Make Temporary Table for V_NewJour 
--SELECT * INTO #TEMP_V_NEWJOUR FROM V_NewJour T1 WHERE T1.F_MTBName = @MTBName And T1.F_MBLID = @MBLId; 
EXEC dbo.up_NewJourByMBLTemp @MTBName, @MBLId; 
 
 
/* Copy/Reverse/Delete Journal */ 
 
DECLARE curNewJour CURSOR FAST_FORWARD FOR 
    SELECT DISTINCT T1.F_Key, T1.F_PostDate, T1.F_RTBID, T1.F_U2Date 
    FROM T_NEWJOUR T1 
        LEFT JOIN #TEMP_V_NEWJOUR T2 On (T2.F_TBName = T1.F_TBName And T2.F_TBID = T1.F_TBID And T2.F_STBName = T1.F_STBName And T2.F_STBID = T1.F_STBID 
            And T2.F_Key = T1.F_Key And T2.F_PostDate = T1.F_PostDate And T2.F_ComId = T1.F_ComId And T2.F_ComType = T1.F_ComType And T2.F_Branch = T1.F_Branch 
            And T2.F_GLNo = T1.F_GLNo And ABS(T2.F_Debit - T1.F_Debit) < 0.0001 And ABS(T2.F_Credit - T1.F_Credit) < 0.0001 And T2.F_SubCode = T1.F_SubCode 
            And T2.F_TBIndex = T1.F_TBIndex And T2.F_TBType = T1.F_TBType And T2.F_Order = T1.F_Order And T2.F_RTBID = T1.F_RTBID And T2.F_Currency = T1.F_Currency And T2.F_ExRate = T1.F_ExRate 
            And COALESCE(T2.F_MTBName, '') = COALESCE(T1.F_MTBName, '') And COALESCE(T2.F_MBLId, 0) = COALESCE(T1.F_MBLId, 0) 
            And ((T2.F_Void = 0 And T2.F_MDesc = T1.F_MDesc) Or T2.F_Void <> 0)) 
    WHERE T1.F_MTBName = @MTBName And T1.F_MBLID = @MBLId And T2.F_Key Is Null 
 
    UNION 
 
    SELECT DISTINCT T1.F_Key, T1.F_PostDate, T1.F_RTBID, T1.F_U2Date 
    FROM T_NEWJOUR T1 
        INNER JOIN ( 
            SELECT DISTINCT T1.F_Key, T1.F_PostDate, T1.F_RTBID, T1.F_U2Date 
            FROM #TEMP_V_NEWJOUR T1 
                LEFT JOIN T_NEWJOUR T2 On (T2.F_TBName = T1.F_TBName And T2.F_TBID = T1.F_TBID And T2.F_STBName = T1.F_STBName And T2.F_STBID = T1.F_STBID 
                    And T2.F_Key = T1.F_Key And T2.F_PostDate = T1.F_PostDate And T2.F_ComId = T1.F_ComId And T2.F_ComType = T1.F_ComType And T2.F_Branch = T1.F_Branch 
                    And T2.F_GLNo = T1.F_GLNo And ABS(T2.F_Debit - T1.F_Debit) < 0.0001 And ABS(T2.F_Credit - T1.F_Credit) < 0.0001 And T2.F_SubCode = T1.F_SubCode 
                    And T2.F_TBIndex = T1.F_TBIndex And T2.F_TBType = T1.F_TBType And T2.F_Order = T1.F_Order And T2.F_RTBID = T1.F_RTBID And T2.F_Currency = T1.F_Currency And T2.F_ExRate = T1.F_ExRate 
                    And COALESCE(T2.F_MTBName, '') = COALESCE(T1.F_MTBName, '') And COALESCE(T2.F_MBLId, 0) = COALESCE(T1.F_MBLId, 0) 
                    And ((T1.F_Void = 0 And T2.F_MDesc = T1.F_MDesc) Or T1.F_Void <> 0)) 
            WHERE T1.F_MTBName = @MTBName And T1.F_MBLID = @MBLId And T2.F_Key Is Null 
        ) T2 On (T2.F_Key = T1.F_Key And T2.F_PostDate = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    ORDER BY T1.F_PostDate, T1.F_U2Date; 
 
OPEN curNewJour 
FETCH NEXT FROM curNewJour INTO @sRecKey, @sRecPostDate, @nRecRTBID, @dRecU2Date 
 
WHILE @@FETCH_STATUS = 0 
    BEGIN 
 
    -- 01. T_NewJour --> T_NewJourB 
    INSERT INTO T_NEWJOURB (F_Key, F_TBIndex, F_Order, F_TBType, F_PostDate, F_SeqNo, F_Branch, F_TBName, F_TBID, F_RTBID, F_STBName, F_STBID, F_ComType, F_ComID, 
        F_ComName, F_GLNo, F_SubCode, F_Debit, F_Credit, F_Currency, F_ExRate, F_FDebit, F_FCredit, F_MDesc, F_U2ID, F_U2Date, F_Void, F_MBLID, F_MTBName) 
 
    -- Copy 
    SELECT LTRIM(STR(100 + T1.F_TBType)) + T1.F_TBName + LTRIM(STR(T1.F_TBID)) + T1.F_Branch, T1.F_TBIndex, T1.F_Order, T1.F_TBType + 100, T1.F_PostDate, T1.F_SeqNo, 
        T1.F_Branch, T1.F_TBName, T1.F_TBID, T1.F_RTBID, T1.F_STBName, T1.F_STBID, T1.F_ComType, T1.F_ComID, T1.F_ComName, T1.F_GLNo, T1.F_SubCode, 
       CASE WHEN T1.F_Debit > 0 THEN T1.F_Debit WHEN T1.F_Credit < 0 THEN -T1.F_Credit ELSE 0 END, 
       CASE WHEN T1.F_Credit > 0 THEN T1.F_Credit WHEN T1.F_Debit < 0 THEN -T1.F_Debit ELSE 0 END, T1.F_Currency, T1.F_ExRate, 
       CASE WHEN T1.F_FDebit > 0 THEN T1.f_FDebit WHEN T1.f_FCredit < 0 THEN -T1.F_FCredit ELSE 0 END, 
       CASE WHEN T1.F_FCredit > 0 THEN T1.F_FCredit WHEN T1.f_FDebit < 0 THEN -T1.F_FDebit ELSE 0 END, T1.F_MDesc, T1.F_U2ID, T1.F_U2Date, T1.F_Void, T1.F_MBLID, T1.F_MTBName 
    FROM T_NEWJOUR T1 
       INNER JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    WHERE T1.F_Key = @sRecKey And T1.F_PostDate = @sRecPostDate And T1.F_RTBID = @nRecRTBID 
 
    UNION ALL 
 
    --Reverse 
    SELECT LTRIM(STR(200 + T1.F_TBType)) + T1.F_TBName + LTRIM(STR(T1.F_TBID)) + T1.F_Branch, T1.F_TBIndex, T1.F_Order, T1.F_TBType + 200, T1.F_PostDate, 0,   -- <-- ** 
        T1.F_Branch, T1.F_TBName, T1.F_TBID, T1.F_RTBID, T1.F_STBName, T1.F_STBID, T1.F_ComType, T1.F_ComID, T1.F_ComName, T1.F_GLNo, T1.F_SubCode, 
       CASE WHEN T1.F_Credit > 0 THEN T1.F_Credit WHEN T1.F_Debit < 0 THEN -T1.F_Debit ELSE 0 END, 
       CASE WHEN T1.F_Debit > 0 THEN T1.F_Debit WHEN T1.F_Credit < 0 THEN -T1.F_Credit ELSE 0 END, T1.F_Currency, T1.F_ExRate, 
       CASE WHEN T1.F_FCredit > 0 THEN T1.F_FCredit WHEN T1.f_FDebit < 0 THEN -T1.F_FDebit ELSE 0 END, 
       CASE WHEN T1.F_FDebit > 0 THEN T1.f_FDebit WHEN T1.f_FCredit < 0 THEN -T1.F_FCredit ELSE 0 END, T1.F_MDesc, CASE WHEN LEN(@U2Id) > 0 THEN @U2Id ELSE T1.F_U2ID END AS F_U2ID, GETDATE(), T1.F_Void, T1.F_MBLID, T1.F_MTBName 
    FROM T_NEWJOUR T1 
       INNER JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    WHERE T1.F_Key = @sRecKey And T1.F_PostDate = @sRecPostDate And T1.F_RTBID = @nRecRTBID; 
 
 
    -- 02. T_NSlipKey : Update to TBType + 100 
    UPDATE T1 SET F_TBType = T2.F_TBType, F_Key = T2.F_Key 
    FROM T_NSLIPKEY T1 
        LEFT JOIN T_NEWJOURB T2 On (T2.F_TBName = T1.F_TBName And T2.F_TBID = T1.F_TBID And T2.F_Branch = T1.F_Branch And T2.F_TBType = T1.F_TBType + 100 And T2.F_SeqNo = T1.F_Seq) 
    WHERE DATEDIFF(DAY, T1.F_Date, T2.F_PostDate) = 0; 
 
 
    -- 03. T_NSlipKey : Insert TBType + 200 
    INSERT INTO T_NSLIPKEY (F_Key, F_Date, F_Branch, F_Seq, F_U1ID, F_U1Date, F_TBName, F_TBID, F_TBType, F_UPD, F_RTBID) 
    SELECT T1.F_key, T1.F_PostDate, T1.F_Branch, 0, T1.F_U2ID, T1.F_U2Date, T1.F_TBName, T1.F_TBID, T1.F_TBType, 9, T1.F_RTBID 
    FROM T_NEWJOURB T1 
    WHERE T1.F_SeqNo = 0 
    GROUP BY T1.F_key, T1.F_PostDate, T1.F_Branch, T1.F_TBName, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date, T1.F_RTBID 
    ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date; 
 
 
    -- 04. Assign SeqNo 
    UPDATE T1 SET F_Seq = ( 
        SELECT ISNULL(T2.MSeq, 0) + COUNT(*) 
        FROM T_NSLIPKEY T9 
        WHERE T9.F_ID <= T1.F_ID And T9.F_Date = T1.F_Date And T9.F_Branch = T1.F_Branch And T9.F_Seq = 0 
    ) 
    FROM T_NSLIPKEY T1 
        LEFT JOIN ( 
            SELECT MAX(F_Seq) AS MSeq, F_Date, F_Branch 
            FROM T_NSlipKey 
            GROUP BY F_Date, F_Branch 
        ) T2 On (T2.F_Date = T1.F_Date And T2.F_Branch = T1.F_Branch) 
    WHERE T1.F_Seq = 0; 
 
    -- 
    UPDATE T1 SET F_SeqNo = T2.F_Seq 
    FROM T_NEWJOURB T1 
        LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    WHERE T1.F_SeqNo = 0 And T2.F_UPD = 9; 
 
    -- 
    UPDATE T_NSLIPKEY SET F_UPD = 0 WHERE F_UPD = 9; 
 
 
    -- 05. Delete T_NEWJOUR & T_NSLIPKEY 
    DELETE T1 
    FROM T_NEWJOUR T1 
        LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_Seq = T1.F_SeqNo) 
    WHERE T1.F_MTBName = @MTBName And T1.F_MBLID = @MBLId And T2.F_ID Is Null 
 
    /* 
    -- (!) 
    DELETE T1 
    FROM T_NSLIPKEY T1 
        LEFT JOIN T_NEWJOUR T2 On (T2.F_Key = T1.F_Key And T2.F_PostDate = T1.F_Date) 
    WHERE T1.F_Key Not Like '10T_SLIPHD%' And T1.F_TBType < 100 And T2.F_Key Is Null 
    */ 
 
    --Fetch 
    FETCH NEXT FROM curNewJour INTO @sRecKey, @sRecPostDate, @nRecRTBID, @dRecU2Date 
 
    END 
 
CLOSE curNewJour 
DEALLOCATE curNewJour 
 
 
 
/* Insert Journal */ 
 
-- 01. T_NewJour 
INSERT INTO T_NEWJOUR (F_Key, F_TBIndex, F_Order, F_TBType, F_PostDate, F_SeqNo, F_Branch, F_TBName, F_TBID, F_RTBID, F_STBName, F_STBID, F_ComType, F_ComID, 
    F_ComName, F_GLNo, F_SubCode, F_Debit, F_Credit, F_Currency, F_ExRate, F_FDebit, F_FCredit, F_MDesc, F_U2ID, F_U2Date, F_Void, F_MBLID, F_MTBName) 
SELECT LTRIM(STR(T1.F_TBType)) + T1.F_TBName + LTRIM(STR(T1.F_TBID)) + T1.F_Branch, T1.F_TBIndex, T1.F_Order, T1.F_TBType, T1.F_PostDate, 0, 
    T1.F_Branch, T1.F_TBName, T1.F_TBID, T1.F_RTBID, T1.F_STBName, T1.F_STBID, T1.F_ComType, ISNULL(T1.F_ComID, 0), ISNULL(T1.F_ComName, ''), ISNULL(T1.F_GLNo, ''), T1.F_SubCode, 
    CASE WHEN T1.F_Debit > 0 THEN T1.F_Debit WHEN T1.F_Credit < 0 THEN -T1.F_Credit ELSE 0 END, 
    CASE WHEN T1.F_Credit > 0 THEN T1.F_Credit WHEN T1.F_Debit < 0 THEN -T1.F_Debit ELSE 0 END, T1.F_Currency, T1.F_ExRate, 
    CASE WHEN T1.F_FDebit > 0 THEN T1.f_FDebit WHEN T1.f_FCredit < 0 THEN -T1.F_FCredit ELSE 0 END, 
    CASE WHEN T1.F_FCredit > 0 THEN T1.F_FCredit WHEN T1.f_FDebit < 0 THEN -T1.F_FDebit ELSE 0 END, T1.F_MDesc, T1.F_U2ID, T1.F_U2Date, T1.F_Void, ISNULL(T1.F_MBLID, 0), ISNULL(T1.F_MTBName, '') 
FROM #TEMP_V_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T1.F_MTBName = @MTBName And T1.F_MBLID = @MBLId And T2.F_ID Is Null 
ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBName, T1.F_TBID, T1.F_Order; 
 
 
-- 02. T_NSlipKey 
INSERT INTO T_NSLIPKEY (F_Key, F_Date, F_Branch, F_Seq, F_U1ID, F_U1Date, F_TBName, F_TBID, F_TBType, F_UPD, F_RTBID) 
SELECT T1.F_key, T1.F_PostDate, T1.F_Branch, 0, T1.F_U2ID, T1.F_U2Date, T1.F_TBName, T1.F_TBID, T1.F_TBType, 9, T1.F_RTBID 
FROM T_NEWJOUR T1 
WHERE T1.F_SeqNo = 0 
GROUP BY T1.F_key, T1.F_PostDate, T1.F_Branch, T1.F_TBName, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date, T1.F_RTBID 
ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date; 
 
 
-- 03. Assign SeqNo 
UPDATE T1 SET F_Seq = ( 
    SELECT ISNULL(T2.MSeq, 0) + COUNT(*) 
    FROM T_NSLIPKEY T9 
    WHERE T9.F_ID <= T1.F_ID And T9.F_Date = T1.F_Date And T9.F_Branch = T1.F_Branch And T9.F_Seq = 0 
) 
FROM T_NSLIPKEY T1 
    LEFT JOIN ( 
        SELECT MAX(F_Seq) AS MSeq, F_Date, F_Branch 
        FROM T_NSlipKey 
        GROUP BY F_Date, F_Branch 
    ) T2 On (T2.F_Date = T1.F_Date And T2.F_Branch = T1.F_Branch) 
WHERE T1.F_Seq = 0; 
 
-- 
UPDATE T1 SET F_SeqNo = T2.F_Seq 
FROM T_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T1.F_SeqNo = 0 And T2.F_UPD = 9; 
 
-- 
UPDATE T_NSLIPKEY SET F_UPD = 0 WHERE F_UPD = 9; 
 
-- 
DROP TABLE #TEMP_V_NEWJOUR 
 
SET NOCOUNT OFF 
 
END 

" },
            { "up_SaveNewJournalByTask" ,
                @"
CREATE PROCEDURE up_SaveNewJournalByTask 
            @TBName            VARCHAR(20), 
            @TBId              INT, 
            @U2Id              VARCHAR(15) = '', 
            @SeqNo             INT = 0 
AS 
 
BEGIN 
 
SET NOCOUNT ON 
DECLARE @sRecKey As VARCHAR(20), @sRecPostDate As DATETIME, @nRecRTBID As INT, @dRecU2Date As DATETIME 
 
-- Make Temporary Table for V_NewJour 
SELECT * INTO #TEMP_V_NEWJOUR FROM V_NewJour T1 WHERE T1.F_TBName = @TBName And T1.F_TBID = @TBId; 
 
 
/* Copy/Reverse/Delete Journal */ 
 
DECLARE curNewJour CURSOR FAST_FORWARD FOR 
    SELECT DISTINCT T1.F_Key, T1.F_PostDate, T1.F_RTBID, T1.F_U2Date 
    FROM T_NEWJOUR T1 
        LEFT JOIN #TEMP_V_NEWJOUR T2 On (T2.F_TBName = T1.F_TBName And T2.F_TBID = T1.F_TBID And T2.F_STBName = T1.F_STBName And T2.F_STBID = T1.F_STBID 
            And T2.F_Key = T1.F_Key And T2.F_PostDate = T1.F_PostDate And T2.F_ComId = T1.F_ComId And T2.F_ComType = T1.F_ComType And T2.F_Branch = T1.F_Branch 
            And T2.F_GLNo = T1.F_GLNo And ABS(T2.F_Debit - T1.F_Debit) < 0.0001 And ABS(T2.F_Credit - T1.F_Credit) < 0.0001 And T2.F_SubCode = T1.F_SubCode 
            And T2.F_TBIndex = T1.F_TBIndex And T2.F_TBType = T1.F_TBType And T2.F_Order = T1.F_Order And T2.F_RTBID = T1.F_RTBID And T2.F_Currency = T1.F_Currency And T2.F_ExRate = T1.F_ExRate 
            And COALESCE(T2.F_MTBName, '') = COALESCE(T1.F_MTBName, '') And COALESCE(T2.F_MBLId, 0) = COALESCE(T1.F_MBLId, 0) 
            And ((T2.F_Void = 0 And T2.F_MDesc = T1.F_MDesc) Or T2.F_Void <> 0)) 
    WHERE T1.F_TBName = @TBName And T1.F_TBID = @TBId And T2.F_Key Is Null 
 
    UNION 
 
    SELECT DISTINCT T1.F_Key, T1.F_PostDate, T1.F_RTBID, T1.F_U2Date 
    FROM T_NEWJOUR T1 
        INNER JOIN ( 
            SELECT DISTINCT T1.F_Key, T1.F_PostDate, T1.F_RTBID, T1.F_U2Date 
            FROM #TEMP_V_NEWJOUR T1 
                LEFT JOIN T_NEWJOUR T2 On (T2.F_TBName = T1.F_TBName And T2.F_TBID = T1.F_TBID And T2.F_STBName = T1.F_STBName And T2.F_STBID = T1.F_STBID 
                    And T2.F_Key = T1.F_Key And T2.F_PostDate = T1.F_PostDate And T2.F_ComId = T1.F_ComId And T2.F_ComType = T1.F_ComType And T2.F_Branch = T1.F_Branch 
                    And T2.F_GLNo = T1.F_GLNo And ABS(T2.F_Debit - T1.F_Debit) < 0.0001 And ABS(T2.F_Credit - T1.F_Credit) < 0.0001 And T2.F_SubCode = T1.F_SubCode 
                    And T2.F_TBIndex = T1.F_TBIndex And T2.F_TBType = T1.F_TBType And T2.F_Order = T1.F_Order And T2.F_RTBID = T1.F_RTBID And T2.F_Currency = T1.F_Currency And T2.F_ExRate = T1.F_ExRate 
                    And COALESCE(T2.F_MTBName, '') = COALESCE(T1.F_MTBName, '') And COALESCE(T2.F_MBLId, 0) = COALESCE(T1.F_MBLId, 0) 
                    And ((T1.F_Void = 0 And T2.F_MDesc = T1.F_MDesc) Or T1.F_Void <> 0)) 
            WHERE T1.F_TBName = @TBName And T1.F_TBID = @TBId And T2.F_Key Is Null 
        ) T2 On (T2.F_Key = T1.F_Key And T2.F_PostDate = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    ORDER BY T1.F_PostDate, T1.F_U2Date; 
 
OPEN curNewJour 
FETCH NEXT FROM curNewJour INTO @sRecKey, @sRecPostDate, @nRecRTBID, @dRecU2Date 
 
WHILE @@FETCH_STATUS = 0 
    BEGIN 
 
    -- 01. T_NewJour --> T_NewJourB 
    INSERT INTO T_NEWJOURB (F_Key, F_TBIndex, F_Order, F_TBType, F_PostDate, F_SeqNo, F_Branch, F_TBName, F_TBID, F_RTBID, F_STBName, F_STBID, F_ComType, F_ComID, 
        F_ComName, F_GLNo, F_SubCode, F_Debit, F_Credit, F_Currency, F_ExRate, F_FDebit, F_FCredit, F_MDesc, F_U2ID, F_U2Date, F_Void, F_MBLID, F_MTBName) 
 
    -- Copy 
    SELECT LTRIM(STR(100 + T1.F_TBType)) + T1.F_TBName + LTRIM(STR(T1.F_TBID)) + T1.F_Branch, T1.F_TBIndex, T1.F_Order, T1.F_TBType + 100, T1.F_PostDate, T1.F_SeqNo, 
        T1.F_Branch, T1.F_TBName, T1.F_TBID, T1.F_RTBID, T1.F_STBName, T1.F_STBID, T1.F_ComType, T1.F_ComID, T1.F_ComName, T1.F_GLNo, T1.F_SubCode, 
       CASE WHEN T1.F_Debit > 0 THEN T1.F_Debit WHEN T1.F_Credit < 0 THEN -T1.F_Credit ELSE 0 END, 
       CASE WHEN T1.F_Credit > 0 THEN T1.F_Credit WHEN T1.F_Debit < 0 THEN -T1.F_Debit ELSE 0 END, T1.F_Currency, T1.F_ExRate, 
       CASE WHEN T1.F_FDebit > 0 THEN T1.f_FDebit WHEN T1.f_FCredit < 0 THEN -T1.F_FCredit ELSE 0 END, 
       CASE WHEN T1.F_FCredit > 0 THEN T1.F_FCredit WHEN T1.f_FDebit < 0 THEN -T1.F_FDebit ELSE 0 END, T1.F_MDesc, T1.F_U2ID, T1.F_U2Date, T1.F_Void, T1.F_MBLID, T1.F_MTBName 
    FROM T_NEWJOUR T1 
       INNER JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    WHERE T1.F_Key = @sRecKey And T1.F_PostDate = @sRecPostDate And T1.F_RTBID = @nRecRTBID 
 
    UNION ALL 
 
    --Reverse 
    SELECT LTRIM(STR(200 + T1.F_TBType)) + T1.F_TBName + LTRIM(STR(T1.F_TBID)) + T1.F_Branch, T1.F_TBIndex, T1.F_Order, T1.F_TBType + 200, T1.F_PostDate, 0,   -- <-- ** 
        T1.F_Branch, T1.F_TBName, T1.F_TBID, T1.F_RTBID, T1.F_STBName, T1.F_STBID, T1.F_ComType, T1.F_ComID, T1.F_ComName, T1.F_GLNo, T1.F_SubCode, 
       CASE WHEN T1.F_Credit > 0 THEN T1.F_Credit WHEN T1.F_Debit < 0 THEN -T1.F_Debit ELSE 0 END, 
       CASE WHEN T1.F_Debit > 0 THEN T1.F_Debit WHEN T1.F_Credit < 0 THEN -T1.F_Credit ELSE 0 END, T1.F_Currency, T1.F_ExRate, 
       CASE WHEN T1.F_FCredit > 0 THEN T1.F_FCredit WHEN T1.f_FDebit < 0 THEN -T1.F_FDebit ELSE 0 END, 
       CASE WHEN T1.F_FDebit > 0 THEN T1.f_FDebit WHEN T1.f_FCredit < 0 THEN -T1.F_FCredit ELSE 0 END, T1.F_MDesc, CASE WHEN LEN(@U2Id) > 0 THEN @U2Id ELSE T1.F_U2ID END AS F_U2ID, GETDATE(), T1.F_Void, T1.F_MBLID, T1.F_MTBName 
    FROM T_NEWJOUR T1 
       INNER JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    WHERE T1.F_Key = @sRecKey And T1.F_PostDate = @sRecPostDate And T1.F_RTBID = @nRecRTBID; 
 
 
    -- 02. T_NSlipKey : Update to TBType + 100 
    UPDATE T1 SET F_TBType = T2.F_TBType, F_Key = T2.F_Key 
    FROM T_NSLIPKEY T1 
        LEFT JOIN T_NEWJOURB T2 On (T2.F_TBName = T1.F_TBName And T2.F_TBID = T1.F_TBID And T2.F_Branch = T1.F_Branch And T2.F_TBType = T1.F_TBType + 100 And T2.F_SeqNo = T1.F_Seq) 
    WHERE DATEDIFF(DAY, T1.F_Date, T2.F_PostDate) = 0; 
 
 
    -- 03. T_NSlipKey : Insert TBType + 200 
    INSERT INTO T_NSLIPKEY (F_Key, F_Date, F_Branch, F_Seq, F_U1ID, F_U1Date, F_TBName, F_TBID, F_TBType, F_UPD, F_RTBID) 
    SELECT T1.F_key, T1.F_PostDate, T1.F_Branch, 0, T1.F_U2ID, T1.F_U2Date, T1.F_TBName, T1.F_TBID, T1.F_TBType, 9, T1.F_RTBID 
    FROM T_NEWJOURB T1 
    WHERE T1.F_SeqNo = 0 
    GROUP BY T1.F_key, T1.F_PostDate, T1.F_Branch, T1.F_TBName, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date, T1.F_RTBID 
    ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date; 
 
 
    -- 04. Assign SeqNo 
    UPDATE T1 SET F_Seq = ( 
        SELECT ISNULL(T2.MSeq, 0) + COUNT(*) 
        FROM T_NSLIPKEY T9 
        WHERE T9.F_ID <= T1.F_ID And T9.F_Date = T1.F_Date And T9.F_Branch = T1.F_Branch And T9.F_Seq = 0 
    ) 
    FROM T_NSLIPKEY T1 
        LEFT JOIN ( 
            SELECT MAX(F_Seq) AS MSeq, F_Date, F_Branch 
            FROM T_NSLIPKEY 
            GROUP BY F_Date, F_Branch 
        ) T2 On (T2.F_Date = T1.F_Date And T2.F_Branch = T1.F_Branch) 
    WHERE T1.F_Seq = 0; 
 
    -- 
    UPDATE T1 SET F_SeqNo = T2.F_Seq 
    FROM T_NEWJOURB T1 
        LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
    WHERE T1.F_SeqNo = 0 And T2.F_UPD = 9; 
 
    -- 
    UPDATE T_NSLIPKEY SET F_UPD = 0 WHERE F_UPD = 9; 
 
 
    -- 05. Delete T_NEWJOUR & T_NSLIPKEY 
    DELETE T1 
    FROM T_NEWJOUR T1 
        LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_Seq = T1.F_SeqNo) 
    WHERE T1.F_TBName = @TBName And T1.F_TBID = @TBId And T2.F_ID Is Null 
 
    /* 
    -- (!) 
    DELETE T1 
    FROM T_NSLIPKEY T1 
        LEFT JOIN T_NEWJOUR T2 On (T2.F_Key = T1.F_Key And T2.F_PostDate = T1.F_Date And T2.F_SeqNo = T1.F_Seq) 
    WHERE T1.F_Key Not Like '10T_SLIPHD%' And T1.F_TBType < 100 And T2.F_Key Is Null 
    */ 
 
    --Fetch 
    FETCH NEXT FROM curNewJour INTO @sRecKey, @sRecPostDate, @nRecRTBID, @dRecU2Date 
 
    END 
 
CLOSE curNewJour 
DEALLOCATE curNewJour 
 
 
 
/* Insert Journal */ 
 
-- 01. T_NewJour 
INSERT INTO T_NEWJOUR (F_Key, F_TBIndex, F_Order, F_TBType, F_PostDate, F_SeqNo, F_Branch, F_TBName, F_TBID, F_RTBID, F_STBName, F_STBID, F_ComType, F_ComID, 
    F_ComName, F_GLNo, F_SubCode, F_Debit, F_Credit, F_Currency, F_ExRate, F_FDebit, F_FCredit, F_MDesc, F_U2ID, F_U2Date, F_Void, F_MBLID, F_MTBName) 
SELECT LTRIM(STR(T1.F_TBType)) + T1.F_TBName + LTRIM(STR(T1.F_TBID)) + T1.F_Branch, T1.F_TBIndex, T1.F_Order, T1.F_TBType, T1.F_PostDate, 0, 
    T1.F_Branch, T1.F_TBName, T1.F_TBID, T1.F_RTBID, T1.F_STBName, T1.F_STBID, T1.F_ComType, ISNULL(T1.F_ComID, 0), ISNULL(T1.F_ComName, ''), ISNULL(T1.F_GLNo, ''), T1.F_SubCode, 
    CASE WHEN T1.F_Debit > 0 THEN T1.F_Debit WHEN T1.F_Credit < 0 THEN -T1.F_Credit ELSE 0 END, 
    CASE WHEN T1.F_Credit > 0 THEN T1.F_Credit WHEN T1.F_Debit < 0 THEN -T1.F_Debit ELSE 0 END, T1.F_Currency, T1.F_ExRate, 
    CASE WHEN T1.F_FDebit > 0 THEN T1.f_FDebit WHEN T1.f_FCredit < 0 THEN -T1.F_FCredit ELSE 0 END, 
    CASE WHEN T1.F_FCredit > 0 THEN T1.F_FCredit WHEN T1.f_FDebit < 0 THEN -T1.F_FDebit ELSE 0 END, T1.F_MDesc, T1.F_U2ID, T1.F_U2Date, T1.F_Void, ISNULL(T1.F_MBLID, 0), ISNULL(T1.F_MTBName, '') 
FROM #TEMP_V_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T1.F_TBName = @TBName And T1.F_TBID = @TBId And T2.F_ID Is Null 
ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBName, T1.F_TBID, T1.F_Order; 
 
 
-- 02. T_NSlipKey 
INSERT INTO T_NSLIPKEY (F_Key, F_Date, F_Branch, F_Seq, F_U1ID, F_U1Date, F_TBName, F_TBID, F_TBType, F_UPD, F_RTBID) 
SELECT T1.F_key, T1.F_PostDate, T1.F_Branch, 0, T1.F_U2ID, T1.F_U2Date, T1.F_TBName, T1.F_TBID, T1.F_TBType, 9, T1.F_RTBID 
FROM T_NEWJOUR T1 
WHERE T1.F_SeqNo = 0 
GROUP BY T1.F_key, T1.F_PostDate, T1.F_Branch, T1.F_TBName, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date, T1.F_RTBID 
ORDER BY T1.F_PostDate, T1.F_Branch, T1.F_TBType, T1.F_TBID, T1.F_U2ID, T1.F_U2Date; 
 
 
-- 03. Assign SeqNo 
IF @SeqNo = 0 
    UPDATE T1 SET F_Seq = ( 
        SELECT ISNULL(T2.MSeq, 0) + COUNT(*) 
        FROM T_NSLIPKEY T9 
        WHERE T9.F_ID <= T1.F_ID And T9.F_Date = T1.F_Date And T9.F_Branch = T1.F_Branch And T9.F_Seq = 0 
    ) 
    FROM T_NSLIPKEY T1 
        LEFT JOIN ( 
            SELECT MAX(F_Seq) AS MSeq, F_Date, F_Branch 
            FROM T_NSLIPKEY 
            GROUP BY F_Date, F_Branch 
        ) T2 On (T2.F_Date = T1.F_Date And T2.F_Branch = T1.F_Branch) 
    WHERE T1.F_Seq = 0; 
ELSE 
    UPDATE T_NSLIPKEY SET F_Seq = @SeqNo WHERE F_Seq = 0; 
 
-- 
UPDATE T1 SET F_SeqNo = T2.F_Seq 
FROM T_NEWJOUR T1 
    LEFT JOIN T_NSLIPKEY T2 On (T2.F_Key = T1.F_Key And T2.F_Date = T1.F_PostDate And T2.F_RTBID = T1.F_RTBID) 
WHERE T1.F_SeqNo = 0 And T2.F_UPD = 9; 
 
-- 
UPDATE T_NSLIPKEY SET F_UPD = 0 WHERE F_UPD = 9; 
 
-- 
DROP TABLE #TEMP_V_NEWJOUR 
 
SET NOCOUNT OFF 
 
END 
" },
            { "up_Slip_TBInfo" ,
                @"
create  procedure   up_Slip_TBInfo 
            @F_TBName           varchar(20), 
            @F_TBID             int 
as 
 
    DECLARE @sSrcNo As VARCHAR(20), @sSrcNo2 As VARCHAR(20), @sOPName As VARCHAR(20), @nOPID As INT 
 
    -- 1. T_DEPOHD 인 경우는 그 Detail이 INVO, AP, CR/DB이기 때문에 먼저 푼다. 
    IF @F_TBName = 'T_DEPOHD' 
        BEGIN 
 
        SELECT @sSrcNo2 = F_CheckNo, @sOPName = T2.F_TBName, @nOPID = T2.F_TBID 
        FROM T_DEPOHD As T1 
            LEFT JOIN ( 
                SELECT TOP 1 F_TBName, F_TBID, F_DepoHDID FROM T_DEPODETAIL WHERE F_DepoHDID = @F_TBID ORDER BY F_Seq, F_ID 
            ) As T2 On (T2.F_DepoHDID = T1.F_ID) 
        WHERE F_ID = @F_TBID 
 
        End 
 
    Else 
        BEGIN 
 
        SET @sOPName = @F_TBName 
        SET @nOPID = @F_TBID 
 
        End 
 
    -- 2. INV, A{, CR/DB에 대한 Src Ref No, OP TBName , OP TBID를 구한다. 
    IF @sOPName = 'T_INVOHD' 
        SELECT @sSrcNo = F_InvoiceNo, @sOPName = F_TBName, @nOPID = F_TBID FROM T_INVOHD WHERE F_ID = @nOPID 
    ELSE IF @sOPName = 'T_APHD' 
        SELECT @sSrcNo = F_InvoiceNo, @sOPName = F_TBName, @nOPID = F_TBID FROM T_APHD WHERE F_ID = @nOPID 
    ELSE IF @sOPName = 'T_CRDBHD' 
        SELECT @sSrcNo = F_CrDBNo, @sOPName = F_TBName, @nOPID = F_TBID FROM T_CRDBHD WHERE F_ID = @nOPID 
    Else 
        SELECT @sSrcNo = '', @sOPName = '', @nOPID = 0 
         
    IF @F_TBName = 'T_DEPOHD' 
        SET @sSrcNo = @sSrcNo2 
 
 
    -- 위에서 구한 OP TBName, OP TBID로 Branch, Ref No, BL NO를 구하고 리턴된다. 
     
    IF @nOPID = 0 
        SELECT '' As F_Branch, @sSrcNo As F_SrcNo, '' As F_RefNo, '' As F_BLNo 
 
    ELSE IF @sOPName = 'T_WSHIPHD' 
        SELECT F_Branch, @sSrcNo As F_SrcNo, F_SHIPNO As F_RefNo, f_trucker As F_BLNo FROM T_WSHIPHD WHERE F_ID = @nOPID 
  
    ELSE IF @sOPName = 'T_WRECEIVE' 
        SELECT F_Branch, @sSrcNo As F_SrcNo, F_Receiveno As F_RefNo, f_trucker As F_BLNo FROM T_WRECEIVEHD WHERE F_ID = @nOPID 
 
    ELSE IF @sOPName = 'T_GENMAIN' 
        SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_CUSTREFNO As F_BLNo FROM T_GENMAIN WHERE F_ID = @nOPID 
 
    ELSE IF @sOPName = 'T_OIMMAIN' 
        SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_MBLNo As F_BLNo FROM T_OIMMAIN WHERE F_ID = @nOPID 
 
    ELSE IF @sOPName = 'T_OIHMAIN' 
        SELECT T1.F_Branch, @sSrcNo As F_SrcNo, T1.F_RefNo, T2.F_HBLNO As F_BLNo FROM T_OIMMAIN As T1 LEFT JOIN T_OIHMAIN As T2 On (T2.F_OIMBLID = T1.F_ID) WHERE T2.F_ID = @nOPID 
 
    ELSE IF @sOPName = 'T_OOMMAIN' 
        SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_MBLNo As F_BLNo FROM T_OOMMAIN WHERE F_ID = @nOPID 
 
    ELSE IF @sOPName = 'T_OOHMAIN' 
        SELECT T1.F_Branch, @sSrcNo As F_SrcNo, T1.F_RefNo, T2.F_HBLNO As F_BLNo FROM T_OOMMAIN As T1 LEFT JOIN T_OOHMAIN As T2 On (T2.F_OOMBLID = T1.F_ID) WHERE T2.F_ID = @nOPID 
 
    ELSE IF @sOPName = 'T_AIMMAIN' 
        SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_MawbNo As F_BLNo FROM T_AIMMAIN WHERE F_ID = @nOPID 
 
    ELSE IF @sOPName = 'T_AIHMAIN' 
        SELECT T1.F_Branch, @sSrcNo As F_SrcNo, T1.F_RefNo, T2.F_HawbNO As F_BLNo FROM T_AIMMAIN As T1 LEFT JOIN T_AIHMAIN As T2 On (T2.F_AIMBLID = T1.F_ID) WHERE T2.F_ID = @nOPID 
 
    ELSE IF @sOPName = 'T_AOMMAIN' 
        SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_MawbNo As F_BLNo FROM T_AOMMAIN WHERE F_ID = @nOPID 
 
    ELSE IF @sOPName = 'T_AOHMAIN' 
        SELECT T1.F_Branch, @sSrcNo As F_SrcNo, T1.F_RefNo, T2.F_HawbNO As F_BLNo FROM T_AOMMAIN As T1 LEFT JOIN T_AOHMAIN As T2 On (T2.F_AOMBLID = T1.F_ID) WHERE T2.F_ID = @nOPID 
 
    Else 
        SELECT '' As F_Branch, @sSrcNo As F_SrcNo, '' As F_RefNo, '' As F_BLNo 
" },
            { "up_YearAndProc" ,
                @"
create  procedure   up_Slip_TBInfo 
        @F_TBName           varchar(20), 
        @F_TBID             int 
as 
 
DECLARE @sSrcNo As VARCHAR(20), @sSrcNo2 As VARCHAR(20), @sOPName As VARCHAR(20), @nOPID As INT 
 
-- 1. T_DEPOHD 인 경우는 그 Detail이 INVO, AP, CR/DB이기 때문에 먼저 푼다. 
IF @F_TBName = 'T_DEPOHD' 
    BEGIN 
 
    SELECT @sSrcNo2 = F_CheckNo, @sOPName = T2.F_TBName, @nOPID = T2.F_TBID 
    FROM T_DEPOHD As T1 
        LEFT JOIN ( 
            SELECT TOP 1 F_TBName, F_TBID, F_DepoHDID FROM T_DEPODETAIL WHERE F_DepoHDID = @F_TBID ORDER BY F_Seq, F_ID 
        ) As T2 On (T2.F_DepoHDID = T1.F_ID) 
    WHERE F_ID = @F_TBID 
 
    End 
 
Else 
    BEGIN 
 
    SET @sOPName = @F_TBName 
    SET @nOPID = @F_TBID 
 
    End 
 
-- 2. INV, A{, CR/DB에 대한 Src Ref No, OP TBName , OP TBID를 구한다. 
IF @sOPName = 'T_INVOHD' 
    SELECT @sSrcNo = F_InvoiceNo, @sOPName = F_TBName, @nOPID = F_TBID FROM T_INVOHD WHERE F_ID = @nOPID 
ELSE IF @sOPName = 'T_APHD' 
    SELECT @sSrcNo = F_InvoiceNo, @sOPName = F_TBName, @nOPID = F_TBID FROM T_APHD WHERE F_ID = @nOPID 
ELSE IF @sOPName = 'T_CRDBHD' 
    SELECT @sSrcNo = F_CrDBNo, @sOPName = F_TBName, @nOPID = F_TBID FROM T_CRDBHD WHERE F_ID = @nOPID 
Else 
    SELECT @sSrcNo = '', @sOPName = '', @nOPID = 0 
         
IF @F_TBName = 'T_DEPOHD' 
    SET @sSrcNo = @sSrcNo2 
 
 
-- 위에서 구한 OP TBName, OP TBID로 Branch, Ref No, BL NO를 구하고 리턴된다. 
     
IF @nOPID = 0 
    SELECT '' As F_Branch, @sSrcNo As F_SrcNo, '' As F_RefNo, '' As F_BLNo 
 
ELSE IF @sOPName = 'T_WSHIPHD' 
    SELECT F_Branch, @sSrcNo As F_SrcNo, F_SHIPNO As F_RefNo, f_trucker As F_BLNo FROM T_WSHIPHD WHERE F_ID = @nOPID 
  
ELSE IF @sOPName = 'T_WRECEIVE' 
    SELECT F_Branch, @sSrcNo As F_SrcNo, F_Receiveno As F_RefNo, f_trucker As F_BLNo FROM T_WRECEIVEHD WHERE F_ID = @nOPID 
 
ELSE IF @sOPName = 'T_GENMAIN' 
    SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_CUSTREFNO As F_BLNo FROM T_GENMAIN WHERE F_ID = @nOPID 
 
ELSE IF @sOPName = 'T_OIMMAIN' 
    SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_MBLNo As F_BLNo FROM T_OIMMAIN WHERE F_ID = @nOPID 
 
ELSE IF @sOPName = 'T_OIHMAIN' 
    SELECT T1.F_Branch, @sSrcNo As F_SrcNo, T1.F_RefNo, T2.F_HBLNO As F_BLNo FROM T_OIMMAIN As T1 LEFT JOIN T_OIHMAIN As T2 On (T2.F_OIMBLID = T1.F_ID) WHERE T2.F_ID = @nOPID 
 
ELSE IF @sOPName = 'T_OOMMAIN' 
    SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_MBLNo As F_BLNo FROM T_OOMMAIN WHERE F_ID = @nOPID 
 
ELSE IF @sOPName = 'T_OOHMAIN' 
    SELECT T1.F_Branch, @sSrcNo As F_SrcNo, T1.F_RefNo, T2.F_HBLNO As F_BLNo FROM T_OOMMAIN As T1 LEFT JOIN T_OOHMAIN As T2 On (T2.F_OOMBLID = T1.F_ID) WHERE T2.F_ID = @nOPID 
 
ELSE IF @sOPName = 'T_AIMMAIN' 
    SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_MawbNo As F_BLNo FROM T_AIMMAIN WHERE F_ID = @nOPID 
 
ELSE IF @sOPName = 'T_AIHMAIN' 
    SELECT T1.F_Branch, @sSrcNo As F_SrcNo, T1.F_RefNo, T2.F_HawbNO As F_BLNo FROM T_AIMMAIN As T1 LEFT JOIN T_AIHMAIN As T2 On (T2.F_AIMBLID = T1.F_ID) WHERE T2.F_ID = @nOPID 
 
ELSE IF @sOPName = 'T_AOMMAIN' 
    SELECT F_Branch, @sSrcNo As F_SrcNo, F_RefNo, F_MawbNo As F_BLNo FROM T_AOMMAIN WHERE F_ID = @nOPID 
 
ELSE IF @sOPName = 'T_AOHMAIN' 
    SELECT T1.F_Branch, @sSrcNo As F_SrcNo, T1.F_RefNo, T2.F_HawbNO As F_BLNo FROM T_AOMMAIN As T1 LEFT JOIN T_AOHMAIN As T2 On (T2.F_AOMBLID = T1.F_ID) WHERE T2.F_ID = @nOPID 
 
Else 
    SELECT '' As F_Branch, @sSrcNo As F_SrcNo, '' As F_RefNo, '' As F_BLNo 
" }

        };

        public static Dictionary<string, string> DicUfInfo = new Dictionary<string, string>
        {
            //Talbe-Valued Function
            { "uf_AC_GetBeginBal",
                @"
CREATE FUNCTION dbo.uf_AC_GetBeginBal(@ToDate varchar(20), @Customer nvarchar(50)='') 
 RETURNS @retBeginBal TABLE  
 ( 
    F_GLNo nvarchar(10),  
    F_GLType nvarchar(2),   
    F_GLName nvarchar(50),   
    F_BeginBal decimal(16, 4)  
 )  
 AS 
  
 BEGIN 

    if @Customer=''  
        BEGIN 
            INSERT @retBeginBal  
            SELECT  MAX(T1.F_GLNo) as F_GLNo, MAX(T3.F_GLType) as F_GLType, MAX(T3.F_GLDescription) as F_GLName,   
                (CASE WHEN T3.F_GLType IN ('L','Q','I','OI') THEN sum(T1.F_Credit) - sum(T1.F_Debit)  
                                  ELSE sum(T1.F_Debit) - sum(T1.F_Credit) END) as F_BeginBal  
            from T_SlipDetail T1 
            inner join T_SlipHD as T2 on (T1.F_HDID= T2.F_ID) 
            left Join T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo)  
            where (T2.F_Type In ('X', 'B', 'DB', 'CB') and T2.F_PostDate = convert(Datetime,(select str(CASE WHEN F_N2 < MONTH(@ToDate) then YEAR(@ToDate) else year(@ToDate)-1 End,4) + right('0' + cast((case when F_N2='12' then '01' else F_N2 + 1 end) as varchar(2)), 2) + '01' 
                                                                                 from T_AOtherinfo where F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27)) 
                  Or (T2.F_Type Not In ('X', 'B', 'DB', 'CB') and T2.F_PostDate >= convert(Datetime,(select str(CASE WHEN F_N2 < MONTH(@ToDate) then YEAR(@ToDate) else year(@ToDate)-1 End,4) + right('0' + cast((case when F_N2='12' then '01' else F_N2 + 1 end) as varchar(2)), 2) + '01' 
                                                                                        from T_AOtherinfo where F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27)) 
                                                  and T2.F_PostDate < convert(Datetime,@ToDate))) 
                    AND T2.F_PostDate >=  
                        convert(datetime,(SELECT (case when F_C3='000000' then '20000101' else F_C3 + '01' end)  FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27))  
            group by T1.F_GLNo, T3.F_GLType ;  
        END;  

    Else   
        BEGIN   
            INSERT @retBeginBal   
            SELECT  MAX(T1.F_GLNo) as F_GLNo, MAX(T3.F_GLType) as F_GLType, MAX(T3.F_GLDescription) as F_GLName,   
                (CASE WHEN T3.F_GLType IN ('L','Q','I','OI') THEN sum(T1.F_Credit) - sum(T1.F_Debit)   
    
 ELSE sum(T1.F_Debit) - sum(T1.F_Credit) END) as F_BeginBal   
            from T_SlipDetail T1   
            inner join T_SlipHD as T2 on (T1.F_HDID= T2.F_ID)  
            left Join T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo)   
            where (T2.F_Type In ('X', 'B', 'DB', 'CB') and T2.F_PostDate = convert(Datetime,(select str(CASE WHEN F_N2 < MONTH(@ToDate) then YEAR(@ToDate) else year(@ToDate)-1 End,4) + right('0' + cast((case when F_N2='12' then '01' else F_N2 + 1 end) as varchar(2)), 2) + '01' 
                                                                                 from T_AOtherinfo where F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27)) 
                  Or (T2.F_Type Not In ('X', 'B', 'DB', 'CB') and T2.F_PostDate >= convert(Datetime,(select str(CASE WHEN F_N2 < MONTH(@ToDate) then YEAR(@ToDate) else year(@ToDate)-1 End,4) + right('0' + cast((case when F_N2='12' then '01' else F_N2 + 1 end) as varchar(2)), 2) + '01' 
                                                                                        from T_AOtherinfo where F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27)) 
                                                  and T2.F_PostDate < convert(Datetime,@ToDate))) 
                    AND T2.F_PostDate >=   
                        convert(datetime,(SELECT (case when F_C3='000000' then '20000101' else F_C3 + '01' end)  FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27))   
                    AND T1.F_ComName=@Customer   
            group by T1.F_GLNo, T3.F_GLType ;   
        END;   
 RETURN;   
 END 
" },
            { "uf_AC_GetBeginningBalance",
                @"
 CREATE FUNCTION dbo.uf_AC_GetBeginningBalance()            
 RETURNS @retBeginBal TABLE                                 
 (                                                          
     IsFromBeg INT NULL,                                    
     F_GLNo VARCHAR(10) NULL,                               
     F_SubCode VARCHAR(20) NULL,                            
     F_Branch VARCHAR(3) NULL,                              
     F_ComType VARCHAR(1) NULL,                             
     F_ComID INT NULL,                                      
     ActYear INT NULL,                                      
     F_Credit FLOAT NULL,                                   
     F_Debit FLOAT NULL                                     
 )                                                          
                                                            
 AS                                                         
 BEGIN                                                      
                                                            
 DECLARE @BeginMonth INT                                    
 DECLARE @FiscalEndMonth INT                                
 DECLARE @AcctStartDate DATETIME                            
 DECLARE @LastYearEnd INT                                   
 DECLARE @LastYearEndDate DATETIME                          

 DECLARE @TEMP_SUMM TABLE (                                 
     IsFromBeg INT NOT NULL,                                
     F_GLNo VARCHAR(10) NULL,                               
     F_SubCode VARCHAR(20) NULL,                            
     F_Branch VARCHAR(3) NULL,                              
     F_ComType VARCHAR(1) NULL,                             
     F_ComID INT NULL,                                      
     ActYear INT NULL,                                      
     F_Credit FLOAT NULL,                                   
     F_Debit FLOAT NULL                                     
 )                                                          

 DECLARE @TEMP_BEG TABLE (                                  
     IsFromBeg INT NOT NULL,                                
     F_GLNo VARCHAR(10) NULL,                               
     F_SubCode VARCHAR(20) NULL,                            
     F_Branch VARCHAR(3) NULL,                              
     F_ComType VARCHAR(1) NULL,                             
     F_ComID INT NULL,                                      
     ActYear INT NULL,                                      
     F_Credit FLOAT NULL,                                   
     F_Debit FLOAT NULL                                     
 )                                                          
 DECLARE @TEMP_YEAR TABLE (                                 
     F_Year INT NULL                                        
 )                                                          

 SET @FiscalEndMonth =(SELECT F_N2 FROM T_AotherInfo WHERE F_TBNAME = 'T_CODEDATA' AND F_TBID = 1 AND F_TYPE = 27)                                                                                                                                 
 SET @BeginMonth = (CASE WHEN @FiscalEndMonth = 12 THEN 1 ELSE @FiscalEndMonth + 1 END)                                                                                                                                                            
 --SET @AcctStartDate = Convert(DATETIME,(SELECT (CASE WHEN F_C3 = '000000' THEN '20000101' ELSE F_C3 + '01' END) FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27))                                                 
 SET @AcctStartDate = dbo.uf_AcctStartYearBeginDate()                                                                                                                                                                                                       
 SET @LastYearEnd = ISNULL((SELECT MAX(CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END) FROM V_SLIPX WHERE F_PostDate >= @AcctStartDate AND F_TYPE IN ('X', 'B', 'DB', 'CB') AND F_TBTYPE < 100), NULL)          
 SET @LastYearEndDate = (SELECT CASE WHEN @LastYearEnd IS NULL THEN @AcctStartDate ELSE (SELECT CONVERT(DATETIME, CONVERT(VARCHAR, @LastYearEnd) + '-' + CONVERT(VARCHAR, @BeginMonth) + '-01')) END ) 
 -- 각 분기결 합산금액 (마지막 Year End 부터 값을 가져온다)                                                                                                                                                                                        
 INSERT INTO @TEMP_SUMM SELECT                                                                                                                                                                                                                     
     0 As IsFromBeg, F_GLNo, F_SubCode, F_Branch, F_ComType, F_ComID,                                                                                                                                                                              
     CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) + 1 ELSE YEAR(F_PostDate) END As ActYear,                                                                                                                                    
     Sum(F_Credit) AS F_Credit, Sum(F_Debit) AS F_Debit                                                                                                                                                                                            
 FROM V_SLIPX T1                                                                                                                                                                                                                                   
 WHERE F_PostDate >= @LastYearEndDate AND F_Type <> 'X' AND F_TBTYPE < 100                                                                                                                                                                         
 GROUP BY F_GLNo, F_SubCode, F_Branch, F_ComType, F_ComID, (CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) + 1 ELSE YEAR(F_PostDate) END)                                                                                        
                                                                                                                                                                                                                                                   
 --각 분기별 Beginning Balance (Account Beginning Date부터 값을 가져온다)                                                                                                                                                                          
 INSERT INTO @TEMP_BEG                                                                                                                                                                                                                             
 SELECT                                                                                                                                                                                                                                            
     1 As IsFromBeg, F_GLNo, F_SubCode, F_Branch, F_ComType, F_ComID,                                                                                                                                                                              
     CASE WHEN F_PostDate = @AcctStartDate THEN (CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END) ELSE YEAR(F_PostDate) END AS ActYear,                                                             
     SUM(F_Credit) AS F_Credit, SUM(F_Debit) AS F_Debit                                                                                                                                                                                            
 FROM V_SLIPX                                                                                                                                                                                                                                      
 WHERE F_Type IN ('B', 'X', 'DB', 'CB') AND F_TBTYPE < 100 AND F_SeqNo = 1                                                                                                                                                                                     
 GROUP BY F_GLNo, F_SubCode, F_Branch, F_ComType, F_ComID, CASE WHEN F_PostDate = @AcctStartDate THEN (CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END) ELSE YEAR(F_PostDate) END                   
                                                                                                                                                                                                                                                   
 INSERT INTO @TEMP_YEAR                                                                                                                                                                                                                            
 SELECT                                                                                                                                                                                                                                            
     CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END AS F_Year                                                                                                                                      
 FROM V_SLIPX T1                                                                                                                                                                                                                                   
 GROUP BY CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END                                                                                                                                           

 INSERT INTO @retBeginBal                                                                                                                                                                                                                          
 SELECT                                                                                                                                                                                                                                            
     IsFromBeg, F_GLNo, F_SubCode, F_Branch, F_ComType, F_ComID, F_Year, F_Credit, F_Debit                                                                                                                                                        
 FROM (                                                                                                                                                                                                                                            
     SELECT *                                                                                                                                                                                                                                      
     FROM @TEMP_YEAR TT                                                                                                                                                                                                                            
     CROSS APPLY (                                                                                                                                                                                                                                 
         SELECT                                                                                                                                                                                                                                    
         0 As IsFromBeg, F_GLNo, F_SubCode, F_Branch, F_ComType, F_ComID, TT.F_Year AS ActYear,                                                                                                                                                   
         SUM(F_Credit) AS F_Credit, SUM(F_Debit) AS F_Debit                                                                                                                                                                                        
         FROM @TEMP_SUMM TACT                                                                                                                                                                                                                      
         WHERE (@LastYearEnd IS NULL OR ActYear > @LastYearEnd) AND ActYear <= TT.F_Year                                                                                                                                                                                     
         GROUP BY F_GLNo, F_SubCode, F_Branch, F_ComType, F_ComID                                                                                                                                                                                  
 ) TTT                                                                                                                                                                                                                                             

 UNION ALL                                                                                                                                                                                                                                         
 -- Year End가 처리된 데이터                                                                                                                                                                                                                       
 SELECT *                                                                                                                                                                                                                                          
 FROM @TEMP_YEAR TT                                                                                                                                                                                                                                
     LEFT JOIN @TEMP_BEG TBEG ON TBEG.ActYear = TT.F_Year                                                                                                                                                                                          
 ) TT                                                                                                                                                                                                                                              
 ORDER BY F_GLNO, F_Year                                                                                                                                                                                                                           
                                                                                                                                                                                                                                                   
 RETURN;                                                                                                                                                                                                                                           
 END
" },
            { "uf_AC_GetBeginningBalanceAll",
                @"
CREATE FUNCTION [dbo].[uf_AC_GetBeginningBalanceAll]( 
    @InDateFrom DATETIME, 
    @InDateTo DATETIME, 
    @InGlNo VARCHAR(10), 
    @InBranch VARCHAR(3), 
    @InSubCode VARCHAR(20), 
    @InComType VARCHAR(1), 
    @InComId INT, 
    @InFromExist BIT, 
    @InToExist BIT 
) 
RETURNS @retBeginBal TABLE 
( 
    F_PostDate DATETIME NOT NULL, 
    F_ActType INT NOT NULL, 
    F_ActYear INT NOT NULL, 
    F_Credit FLOAT NULL, 
    F_Debit FLOAT NULL, 
    F_BALANCE FLOAT NOT NULL 
) 
 
AS 
BEGIN 
DECLARE @BeginMonth INT 
DECLARE @FiscalEndMonth INT 
DECLARE @AcctStartDate DATETIME 
DECLARE @LastYearEnd INT 
DECLARE @LastYearEndDate DATETIME 
DECLARE @AcctStartYear INT 
DECLARE @FirstYear INT 
DECLARE @FirstYearExist INT 
DECLARE @LastYear INT 
DECLARE @LastYearExist INT 
DECLARE @tmpYear INT 
DECLARE @NextYearStartDate DATETIME 
DECLARE @nCntRemainDataInThisYear INT 
DECLARE @TEMP_SUMM TABLE ( 
    F_ActYear INT NOT NULL, 
    F_Credit FLOAT NULL, 
    F_Debit FLOAT NULL 
) 
 
DECLARE @TEMP_BEG TABLE ( 
    F_ActType INT NOT NULL, 
    F_ActYear INT NOT NULL, 
    F_Credit FLOAT NOT NULL, 
    F_Debit FLOAT NOT NULL 
) 
 
DECLARE @TEMP_YEAR TABLE ( 
    F_Year INT NOT NULL 
) 
SET @FiscalEndMonth =(SELECT F_N2 FROM T_AotherInfo WHERE F_TBNAME = 'T_CODEDATA' AND F_TBID = 1 AND F_TYPE = 27) 
SET @BeginMonth = (CASE WHEN @FiscalEndMonth = 12 THEN 1 ELSE @FiscalEndMonth + 1 END) 
--SET @AcctStartDate = Convert(DATETIME,(SELECT (CASE WHEN F_C3 = '000000' THEN '20000101' ELSE F_C3 + '01' END) FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27)) 
SET @AcctStartDate = dbo.uf_AcctStartYearBeginDate() 
SET @LastYearEnd = ISNULL((SELECT MAX(CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END) FROM V_SLIPX WHERE F_PostDate >= @AcctStartDate AND F_TYPE = 'X' AND F_TBTYPE = 99 AND F_SeqNo = 99), NULL) 
SET @LastYearEndDate = CASE WHEN @LastYearEnd IS NULL THEN @AcctStartDate ELSE (SELECT CONVERT(DATETIME, CONVERT(VARCHAR, @LastYearEnd) + '-' + CONVERT(VARCHAR, @BeginMonth) + '-01')) END 
Set @AcctStartYear = CASE WHEN MONTH(@AcctStartDate) >= @BeginMonth THEN YEAR(@AcctStartDate) ELSE YEAR(@AcctStartDate) - 1 END 
--SET @LastYearEnd = CASE WHEN @LastYearEnd IS NULL THEN @AcctStartYear ELSE @LastYearEnd END 
SET @LastYearEnd = CASE WHEN @LastYearEnd IS NULL THEN @AcctStartYear - 1 ELSE @LastYearEnd END 
SET @LastYear = CASE WHEN MONTH(@InDateTo) >= @BeginMonth THEN YEAR(@InDateTo) ELSE YEAR(@InDateTo) - 1 END 
SET @FirstYear = CASE WHEN MONTH(@InDateFrom) >= @BeginMonth THEN YEAR(@InDateFrom) ELSE YEAR(@InDateFrom) - 1 END 
SET @NextYearStartDate = CONVERT(DATETIME, (CASE WHEN MONTH(@InDateTo) >= @BeginMonth THEN CONVERT(VARCHAR, YEAR(@InDateTo)) + '-' + CONVERT(VARCHAR, @BeginMonth) + '-01' ELSE CONVERT(VARCHAR, YEAR(@InDateTo) - 1) + '-' + CONVERT(varchar, @BeginMonth) + '-01' END)) 
SET @NextYearStartDate = DATEADD(yyyy, 1, @NextYearStartDate) 
 
SET @FirstYearExist = 
    CASE 
        WHEN @InFromExist = 0 THEN @FirstYear 
        ELSE ISNULL( 
        ( 
            SELECT MIN(CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END) 
            From V_SLIPX 
            Where 
                F_PostDate >= @AcctStartDate 
                AND F_PostDate <= @InDateTo 
                AND F_TBType < 100 
                AND F_GLNO = @InGlNo 
                AND (F_Branch = @InBranch OR @InBranch = '') 
                AND (F_SubCode = @InSubCode OR @InSubCode = '') 
                AND F_ComType = @InComType 
                AND F_ComId = @InComId 
        ), @FirstYear 
    ) END 
     
SET @LastYearExist = 
    CASE 
        WHEN @InToExist = 0 THEN @LastYear 
        ELSE ISNULL( 
        ( 
            SELECT MAX(CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END) 
            From V_SLIPX 
            Where 
                F_PostDate >= @AcctStartDate 
                AND F_PostDate <= @InDateTo 
                AND F_TBType < 100 
                AND F_GLNO = @InGlNo 
                AND (F_Branch = @InBranch OR @InBranch = '') 
                AND (F_SubCode = @InSubCode OR @InSubCode = '') 
                AND F_ComType = @InComType 
                AND F_ComId = @InComId 
                AND (@InGlNo = '331100' OR F_Type NOT IN ('X', 'B', 'DB', 'CB')) 
        ), @FirstYear 
    ) END 
     
-- 회계년도 별 합산금액 
INSERT INTO @TEMP_SUMM SELECT 
    CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) -1 END As F_ActYear, 
    Sum(F_Credit) AS F_Credit, Sum(F_Debit) AS F_Debit 
FROM V_SLIPX T1 
Where 
    --F_PostDate >= @AcctStartDate AND F_PostDate <= @InDateTo AND F_Type <> 'X' AND F_TBTYPE < 100 
    F_PostDate >= @AcctStartDate AND F_PostDate <= @InDateTo AND F_Type Not In ('X', 'B', 'DB', 'CB') AND F_TBTYPE < 100 
    AND T1.F_GLNo = @InGlNo 
    AND (T1.F_Branch = @InBranch OR @InBranch = '') 
    AND (T1.F_SubCode = @InSubCode OR @InSubCode = '') 
    AND T1.F_ComType = @InComType 
    AND T1.F_ComId = @InComId 
GROUP BY (CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END) 
  
-- 해당 년도 ToDate 뒤에 데이터가 있는지 검사 
SELECT @nCntRemainDataInThisYear = Count(*) 
FROM V_SLIPX T1 
WHERE T1.F_PostDate > @InDateTo  And T1.F_PostDate < @NextYearStartDate 
    And T1.F_GLNo = @InGlNo And (T1.F_Branch = @InBranch OR @InBranch = '') And (T1.F_SubCode = @InSubCode OR @InSubCode = '') 
    And T1.F_ComType = @InComType And T1.F_ComId = @InComId 
    --And (T1.F_GLNo = '331100' Or (T1.F_GLNo <> '331100' And T1.F_Type <> 'X')) 
    And (T1.F_GLNo = '331100' Or (T1.F_GLNo <> '331100' And T1.F_Type Not In ('X', 'B', 'DB', 'CB'))) 
 
--회계년도 별 Beginning Balance, Ending Balance 
INSERT INTO @TEMP_BEG 
SELECT 
    --CASE WHEN F_SeqNo = 1 THEN 1 ELSE 5 END AS F_ActType, 
    CASE WHEN (F_Type = 'X' And F_SeqNo = 1) Or F_Type = 'B' Or F_Type = 'DB' Or F_Type = 'CB' THEN 1 ELSE 5 END AS F_ActType, 
    CASE WHEN F_PostDate >= @AcctStartDate THEN (CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END) ELSE YEAR(F_PostDate) END AS F_ActYear, 
    SUM(CASE WHEN F_SeqNo = 99 THEN F_Debit ELSE F_Credit END) AS F_Credit, SUM(CASE WHEN F_SeqNo = 99 THEN F_Credit ELSE F_Debit END) AS F_Debit 
FROM V_SLIPX T1 
Where 
    --T1.F_PostDate >= @AcctStartDate AND T1.F_PostDate <= @InDateTo 
    T1.F_PostDate >= @AcctStartDate AND T1.F_PostDate <= (CASE WHEN @nCntRemainDataInThisYear > 0 THEN @InDateTo ELSE DATEADD(d, -1, @NextYearStartDate) END) 
    --AND T1.F_Type = 'X' AND F_TBTYPE = 99 AND F_SeqNo IN (1, 99) 
    AND ((T1.F_Type = 'X' AND F_TBTYPE = 99 AND F_SeqNo IN (1, 99)) Or (T1.F_Type = 'B') Or (T1.F_Type = 'DB') Or (T1.F_Type = 'CB')) 
    AND T1.F_GLNo = @InGlNo 
    AND (T1.F_Branch = @InBranch OR @InBranch = '') 
    AND (T1.F_SubCode = @InSubCode OR @InSubCode = '') 
    AND T1.F_ComType = @InComType 
    AND T1.F_ComId = @InComId 
Group By 
    --CASE WHEN F_SeqNo = 1 THEN 1 ELSE 5 END, 
    CASE WHEN (F_Type = 'X' And F_SeqNo = 1) Or (F_Type = 'B') Or (F_Type = 'DB') Or (F_Type = 'CB') THEN 1 ELSE 5 END, 
    CASE WHEN F_PostDate >= @AcctStartDate THEN (CASE WHEN MONTH(F_PostDate) >= @BeginMonth THEN YEAR(F_PostDate) ELSE YEAR(F_PostDate) - 1 END) ELSE YEAR(F_PostDate) END 
 
--연도 (Accounting Beginning Date ~ In Date) 
Set @tmpYear = CASE WHEN @FirstYear > @AcctStartYear THEN @FirstYear ELSE @AcctStartYear END 
Set @tmpYear = CASE WHEN @FirstYearExist > @FirstYear THEN @FirstYearExist ELSE @FirstYear END 
 
WHILE @tmpYear <= @LastYear AND @tmpYear <= @LastYearExist 
BEGIN 
    BEGIN 
        INSERT INTO @TEMP_YEAR (F_Year) VALUES (@tmpYear) 
    End 
    SET @tmpYear = @tmpYear + 1 
End 
 
 
INSERT INTO @retBeginBal 
SELECT 
    CASE WHEN F_ActType IN (1,2) THEN CONVERT(DATETIME, CONVERT(VARCHAR, F_ActYear) + '-' + CONVERT(VARCHAR, @BeginMonth) + '-01') 
        WHEN F_ActType = 4 THEN (CASE WHEN @LastYear = F_ActYear THEN @InDateTo ELSE DATEADD(DAY, -1, CONVERT(DATETIME, CONVERT(VARCHAR, F_ActYear + 1) + '-' + CONVERT(VARCHAR, @BeginMonth) + '-01')) END) 
        ELSE DATEADD(DAY, -1, CONVERT(DATETIME, CONVERT(VARCHAR, F_ActYear + 1) + '-' + CONVERT(VARCHAR, @BeginMonth) + '-01'))  END AS F_PostDate, 
    F_ActType, F_ActYear, ISNULL(F_Credit, 0) AS F_Credit, ISNULL(F_Debit, 0) AS F_Debit, ISNULL(F_Debit, 0) - ISNULL(F_Credit, 0) AS F_Balance 
FROM ( 
    -- ACTTYPE 1 ==>  Beginning Balance (By Year End Process) 
    SELECT 
        1 AS F_ActType, TT.F_Year AS F_ActYear, TBEG.F_Credit, TBEG.F_Debit 
    FROM @TEMP_YEAR TT 
    LEFT JOIN @TEMP_BEG TBEG ON TBEG.F_ActYear = TT.F_Year AND TBEG.F_ActType = 1 
    WHERE TBEG.F_ActYear IS NOT NULL OR TT.F_Year <= @LastYearEnd + 1 
 
    -- ACTTYPE 2 ==>  Beginning Balance (Accumulated) 
    Union All 
    SELECT 2 AS F_ActType, T1.F_Year AS F_ActYear, ISNULL(T3.F_Credit, 0) + ISNULL(T2.F_Credit, 0) AS F_Credit, ISNULL(T3.F_Debit, 0) + ISNULL(T2.F_Debit, 0) AS F_Debit 
    FROM @TEMP_YEAR T1 
    OUTER APPLY ( 
        SELECT SUM(TACT.F_Credit) AS F_Credit, SUM(TACT.F_Debit) AS F_Debit 
        FROM @TEMP_SUMM TACT 
        WHERE TACT.F_ActYear < T1.F_Year AND @LastYearEnd + 1 <= TACT.F_ActYear 
    ) T2 
    LEFT JOIN @TEMP_BEG T3 ON T3.F_ActYear = @LastYearEnd + 1 AND T3.F_ActType = 1 
    WHERE T1.F_Year > @LastYearEnd + 1 
 
    --ACTTYPE 4 ==>  Ending Balance(Accumulated) 
    Union All 
    SELECT 4 AS F_ActType, T1.F_Year AS F_ActYear, ISNULL(T3.F_Credit, 0) + ISNULL(T2.F_Credit, 0) AS F_Credit, ISNULL(T3.F_Debit, 0) + ISNULL(T2.F_Debit, 0) AS F_Debit 
    FROM @TEMP_YEAR T1 
    OUTER APPLY ( 
        SELECT SUM(TACT.F_Credit) AS F_Credit, SUM(TACT.F_Debit) AS F_Debit 
        FROM @TEMP_SUMM TACT 
        WHERE TACT.F_ActYear <= T1.F_Year AND (CASE WHEN T1.F_Year > @LastYearEnd + 1 THEN @LastYearEnd + 1 ELSE T1.F_Year END) <= TACT.F_ActYear 
    ) T2 
    LEFT JOIN @TEMP_BEG T3 ON 
        T3.F_ActYear = (CASE WHEN T1.F_Year > @LastYearEnd + 1 THEN @LastYearEnd + 1 ELSE T1.F_Year END) AND T3.F_ActType = 1 
     
    --ACTTYPE 5 ==>  Ending Balance 
    Union All 
    SELECT 
        5 AS F_ActType, TT.F_Year AS F_ActYear, TBEG.F_Credit, TBEG.F_Debit 
    FROM @TEMP_YEAR TT 
    INNER JOIN @TEMP_BEG TBEG ON TBEG.F_ActYear = TT.F_Year AND TBEG.F_ActType = 5 
    WHERE TBEG.F_ActYear IS NOT NULL OR TT.F_Year <= @LastYearEnd 
) TT 
ORDER BY F_ActYear 
  
RETURN; 
End
" },
            { "uf_AC_NewBS2016",
                @"
CREATE FUNCTION dbo.uf_AC_NewBS2016 ( 
    @sQueryType VARCHAR(1), 
    @sShowPrevious VARCHAR(1), 
    @dFromDate3 VARCHAR(20), 
    @dEndDate3 VARCHAR(20), 
    @dFromDate2 VARCHAR(20) = '', 
    @dEndDate2 VARCHAR(20) = '', 
    @dFromDate1 VARCHAR(20) = '', 
    @dEndDate1 VARCHAR(20) = '' 
) 
RETURNS @tTempTable TABLE 
( 
    F_GLNo VARCHAR(10), 
    F_Amount3 decimal(16, 4), 
    F_Amount2 decimal(16, 4), 
    F_Amount1 decimal(16, 4) 
) 
AS 
BEGIN 
 
IF @sQueryType = 'J' 
    IF @sShowPrevious = 'Y' 
        BEGIN 
 
        INSERT @tTempTable 
        SELECT 
            --(CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE dbo.uf_Slip_GetFixedGLNo('NetIcomeGL','') END) As F_GLNo, 
            (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE 'NETINCOME' END) As F_GLNo, 
            ROUND(SUM(CASE WHEN T1.F_PostDate Between CONVERT(Datetime, @dFromDate3) And CONVERT(Datetime, @dEndDate3) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount3, 
            ROUND(SUM(CASE WHEN T1.F_PostDate Between CONVERT(Datetime, @dFromDate2) And CONVERT(Datetime, @dEndDate2) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount2, 
            ROUND(SUM(CASE WHEN T1.F_PostDate Between CONVERT(Datetime, @dFromDate1) And CONVERT(Datetime, @dEndDate1) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount1 
        FROM V_Slip T1 
            INNER JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
        WHERE Not (T1.F_Type = 'X' And T1.F_SeqNo in (98, 99)) 
            And ((DateDiff(Day, T1.F_POSTDATE, CONVERT(DATETIME,@dFromDate1)) <=0 AND DateDiff(Day, T1.F_PostDate ,convert(Datetime, @dEndDate1)) >=0) 
            Or (DateDiff(Day, T1.F_POSTDATE, CONVERT(DATETIME,@dFromDate2)) <=0 AND DateDiff(Day, T1.F_PostDate ,convert(Datetime, @dEndDate2)) >=0) 
            Or (DateDiff(Day, T1.F_POSTDATE, CONVERT(DATETIME,@dFromDate3)) <=0 AND DateDiff(Day, T1.F_PostDate ,convert(Datetime, @dEndDate3)) >=0)) 
        --GROUP BY (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE dbo.uf_Slip_GetFixedGLNo('NetIcomeGL','') END) 
        GROUP BY (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE 'NETINCOME' END) 
 
        End 
    Else 
        BEGIN 
 
        INSERT @tTempTable 
        SELECT 
            --(CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE dbo.uf_Slip_GetFixedGLNo('NetIcomeGL','') END) As F_GLNo, 
            (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE 'NETINCOME' END) As F_GLNo, 
            0 As F_Amount3, 
            0 As F_Amount2, 
            ROUND(SUM(CASE WHEN T1.F_PostDate Between CONVERT(Datetime, @dFromDate3) And CONVERT(Datetime, @dEndDate3) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount1 
        FROM V_Slip T1 
            INNER JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
        WHERE Not (T1.F_Type = 'X' And T1.F_SeqNo in (98, 99)) 
            And (DateDiff(Day, T1.F_POSTDATE, CONVERT(DATETIME,@dFromDate3)) <=0 AND DateDiff(Day, T1.F_PostDate ,convert(Datetime, @dEndDate3)) >=0) 
        --GROUP BY (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE dbo.uf_Slip_GetFixedGLNo('NetIcomeGL','') END) 
        GROUP BY (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE 'NETINCOME' END) 
 
        End 
 
ELSE IF @sQueryType = 'B' 
    IF @sShowPrevious = 'Y' 
        BEGIN 
 
        INSERT @tTempTable 
        SELECT 
            (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE dbo.uf_Slip_GetFixedGLNo('F_EarningGLNo','') END) As F_GLNo, 
            ROUND(SUM(CASE WHEN T1.F_PostDate < CONVERT(Datetime, @dFromDate3) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount3, 
            ROUND(SUM(CASE WHEN T1.F_PostDate < CONVERT(Datetime, @dFromDate2) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount2, 
            ROUND(SUM(CASE WHEN T1.F_PostDate < CONVERT(Datetime, @dFromDate1) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount1 
        FROM V_Slip T1 
            INNER JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
        WHERE DATEDIFF(Day,T1.F_PostDate,CONVERT(Datetime, @dFromDate3)) > 0 
        GROUP BY (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE dbo.uf_Slip_GetFixedGLNo('F_EarningGLNo','') END) 
 
        End 
    Else 
        BEGIN 
 
        INSERT @tTempTable 
        SELECT 
            (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE dbo.uf_Slip_GetFixedGLNo('F_EarningGLNo','') END) As F_GLNo, 
            0 As F_Amount3, 
            0 As F_Amount2, 
            ROUND(SUM(CASE WHEN T1.F_PostDate < CONVERT(Datetime, @dFromDate3) THEN T1.F_Debit - T1.F_Credit ELSE 0 END), 4) As F_Amount1 
        FROM V_Slip T1 
            INNER JOIN T_CodeGLNo T2 On (T2.F_GLNo = T1.F_GLNo) 
        WHERE DATEDIFF(Day,T1.F_PostDate,CONVERT(Datetime, @dFromDate3)) > 0 
        GROUP BY (CASE WHEN T2.F_GLType In ('A', 'L', 'Q') THEN T1.F_GLNo ELSE dbo.uf_Slip_GetFixedGLNo('F_EarningGLNo','') END) 
 
        End 
 
Return 
 
End
" },
            { "uf_AC_NewGetBeginBalO",
                @"
CREATE FUNCTION dbo.uf_AC_NewGetBeginBalO(@BegDate varchar(20),@ToDate varchar(20), @Customer nvarchar(50)='',@Branch nvarchar(3)='') 
 RETURNS @retBeginBal TABLE  
 ( 
    F_GLNo nvarchar(10),  
    F_GLType nvarchar(2),   
    F_GLName nvarchar(50),   
    F_BeginBal decimal(16, 4)  
 )  
 AS 
  
 BEGIN 

    if @Customer='' and @Branch='' 
        BEGIN 
            INSERT @retBeginBal  
            SELECT  MAX(T1.F_GLNo) as F_GLNo, MAX(T3.F_GLType) as F_GLType, MAX(T3.F_GLDescription) as F_GLName,  
                                   sum(T1.F_Debit) - sum(T1.F_Credit)  as F_BeginBal  
            from v_slip T1 
            left Join T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo)  
            where ((T1.F_Type In ('X', 'B', 'DB', 'CB') and DATEDIFF(Day,T1.F_PostDate,convert(datetime,@BegDate))=0)
                  Or (T1.F_Type Not In ('X', 'B', 'DB', 'CB') and DATEDIFF(Day,T1.F_PostDate, convert(datetime,@BegDate)) <=0 
                                                  and DATEDIFF(Day,T1.F_PostDate ,convert(Datetime,@ToDate)) > 0)) 
            group by T1.F_GLNo, T3.F_GLType ;  
        END;  

    Else  if @Customer <> '' and @Branch=''  
        BEGIN   
            INSERT @retBeginBal   
            SELECT  MAX(T1.F_GLNo) as F_GLNo, MAX(T3.F_GLType) as F_GLType, MAX(T3.F_GLDescription) as F_GLName,  
                                   sum(T1.F_Debit) - sum(T1.F_Credit)  as F_BeginBal  
            from v_slip T1 
            left Join T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo)  
            where ((T1.F_Type In ('X', 'B', 'DB', 'CB') and DATEDIFF(Day,T1.F_PostDate,convert(datetime,@BegDate))=0)
                  Or (T1.F_Type Not In ('X', 'B', 'DB', 'CB') and DATEDIFF(Day,T1.F_PostDate, convert(datetime,@BegDate)) <=0 
                                                  and DATEDIFF(Day,T1.F_PostDate ,convert(Datetime,@ToDate)) > 0)) 
                    AND T1.F_ComName=@Customer   
            group by T1.F_GLNo, T3.F_GLType ;   
        END;   

    Else if @Customer=''  and @Branch <> '' 
        BEGIN 
            INSERT @retBeginBal  
            SELECT  MAX(T1.F_GLNo) as F_GLNo, MAX(T3.F_GLType) as F_GLType, MAX(T3.F_GLDescription) as F_GLName,  
                                   sum(T1.F_Debit) - sum(T1.F_Credit)  as F_BeginBal  
            from v_slip T1 
            left Join T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo)  
            where ((T1.F_Type In ('X', 'B', 'DB', 'CB') and DATEDIFF(Day,T1.F_PostDate,convert(datetime,@BegDate))=0)
                  Or (T1.F_Type Not In ('X', 'B', 'DB', 'CB') and DATEDIFF(Day,T1.F_PostDate, convert(datetime,@BegDate)) <=0 
                                                  and DATEDIFF(Day,T1.F_PostDate ,convert(Datetime,@ToDate)) > 0)) 
                    AND T1.F_Branch = @Branch   
            group by T1.F_GLNo, T3.F_GLType ;  
        END;  

    Else   
        BEGIN   
            INSERT @retBeginBal   
            SELECT  MAX(T1.F_GLNo) as F_GLNo, MAX(T3.F_GLType) as F_GLType, MAX(T3.F_GLDescription) as F_GLName,  
                                   sum(T1.F_Debit) - sum(T1.F_Credit)  as F_BeginBal  
            from v_slip T1 
            left Join T_CodeGLNo T3 ON (T3.F_GLNo=T1.F_GLNo)  
            where ((T1.F_Type In ('X', 'B', 'DB', 'CB') and DATEDIFF(Day,T1.F_PostDate,convert(datetime,@BegDate))=0)
                  Or (T1.F_Type Not In ('X', 'B', 'DB', 'CB') and DATEDIFF(Day,T1.F_PostDate, convert(datetime,@BegDate)) <=0 
                                                  and DATEDIFF(Day,T1.F_PostDate ,convert(Datetime,@ToDate)) > 0)) 
                    AND T1.F_ComName=@Customer AND T1.F_Branch = @Branch  
            group by T1.F_GLNo, T3.F_GLType ;   
        END;   
 RETURN;   
 END 
" },
            { "uf_AC_NewIS",
                @"
CREATE FUNCTION dbo.uf_AC_NewIS(@FmDate varchar(20),@ToDate varchar(20),@Branch nvarchar(3)='') 
 RETURNS @retBeginBal TABLE  
 ( 
    F_GLNo nvarchar(10),  
    F_BRANCH nvarchar(3),  
    F_Debit decimal(16, 4),  
    F_Credit decimal(16, 4)  
 )  
 AS 
  
 BEGIN 

    if @Branch='' 
        BEGIN 
            INSERT @retBeginBal  
            SELECT T1.F_GLNo as F_GLNo,T1.F_BRANCH,   
            SUM(F_DEBIT) AS F_DEBIT,
            SUM(F_CREDIT) AS F_CREDIT

            from v_slip T1 
            Where DATEDIFF(Day,T1.F_POSTDATE,CONVERT(DATETIME,@FmDate)) <=0 AND DATEDIFF(Day,T1.F_PostDate,convert(Datetime,@ToDate)) >=0 and T1.F_Type Not In ('X', 'B', 'DB', 'CB')
            group by T1.F_GLNo,T1.F_BRANCH ;  
        END;  

    Else   
        BEGIN   
            INSERT @retBeginBal   
            SELECT T1.F_GLNo as F_GLNo, T1.F_BRANCH,   
            SUM(F_DEBIT) AS F_DEBIT,
            SUM(F_CREDIT) AS F_CREDIT

            from v_slip T1 
            Where DATEDIFF(Day,T1.F_POSTDATE,CONVERT(DATETIME,@FmDate)) <=0 AND DATEDIFF(Day,T1.F_PostDate,convert(Datetime,@ToDate)) >=0 and T1.F_Type Not In ('X', 'B', 'DB', 'CB')
                    AND T1.F_Branch = @Branch  
            group by T1.F_GLNo,T1.F_BRANCH ;   
        END;   
 RETURN;   
 END
" },
            { "uf_AC_NewISSum",
                @"
CREATE FUNCTION dbo.uf_AC_NewISSum(@FmDate varchar(20),@ToDate varchar(20)) 
 RETURNS @retBeginBal TABLE  
 ( 
    F_GLType nvarchar(5),  
    F_GLGroup nvarchar(5),  
    F_BRANCH nvarchar(3),  
    F_SUM decimal(16, 4)  
 )  
 AS 
  
 BEGIN 

            INSERT @retBeginBal  
            SELECT G.F_GLType ,G.F_GLGroup,F_BRANCH,   
            SUM(CASE WHEN G.F_GLTYPE IN ('I','OI') THEN F_CREDIT-F_DEBIT ELSE F_DEBIT-F_CREDIT END) AS F_SUM 

            from v_slip T1 LEFT JOIN T_CODEGLNO G ON G.F_GLNO=T1.F_GLNO  
            Where G.F_GLTYPE NOT IN ('A','L','Q') AND T1.F_POSTDATE >= CONVERT(DATETIME,@FmDate) AND T1.F_PostDate <= convert(Datetime,@ToDate) and T1.F_Type Not In ('X', 'B', 'DB', 'CB')
            group by G.F_GLType ,G.F_GLGroup,F_BRANCH ;  
 RETURN;   
 END
" },
            { "uf_AC_NewTB",
                @"
CREATE FUNCTION dbo.uf_AC_NewTB(@Begdate varchar(20),@FmDate varchar(20),@ToDate varchar(20), @Customer nvarchar(50)='',@Branch nvarchar(3)='') 
 RETURNS @retBeginBal TABLE  
 ( 
    F_GLNo nvarchar(10),  
    F_BeginBal decimal(16, 4),  
    F_Debit decimal(16, 4),  
    F_Credit decimal(16, 4)  
 )  
 AS 
  
 BEGIN 

    if @Customer='' and @Branch='' 
        BEGIN 
            INSERT @retBeginBal  
            SELECT T1.F_GLNo as F_GLNo,   
            SUM(CASE WHEN  T1.F_Type In ('X', 'B', 'DB', 'CB') and T1.F_PostDate =  CONVERT(DATETIME,@Begdate) and T1.F_POSTDATE <= CONVERT(DATETIME,@FmDate)  THEN T1.F_Debit -T1.F_Credit 
            WHEN   T1.F_Type Not In ('X', 'B', 'DB', 'CB') and T1.F_PostDate >= convert(Datetime,@Begdate) and T1.F_PostDate < convert(Datetime,@FmDate) 
            THEN T1.F_Debit - T1.F_Credit ELSE  0 END) as F_BeginBal,  
            SUM(CASE WHEN T1.F_POSTDATE >= CONVERT(DATETIME,@FmDate) AND T1.F_POSTDATE <= CONVERT(DATETIME,@ToDate) AND T1.F_Type Not In ('X', 'B') THEN F_DEBIT ELSE 0 END) AS F_DEBIT,
            SUM(CASE WHEN T1.F_POSTDATE >= CONVERT(DATETIME,@FmDate) AND T1.F_POSTDATE <= CONVERT(DATETIME,@ToDate) AND T1.F_Type Not In ('X', 'B') THEN F_CREDIT ELSE 0 END) AS F_CREDIT

            from v_slip T1 
            Where DATEDIFF(Day,T1.F_PostDate,convert(Datetime,@ToDate)) >=0 
            group by T1.F_GLNo ;  
        END;  

    Else  if @Customer <> '' and @Branch=''  
        BEGIN   
            INSERT @retBeginBal   
            SELECT T1.F_GLNo as F_GLNo,   
            SUM(CASE WHEN  T1.F_Type In ('X', 'B', 'DB', 'CB') and T1.F_PostDate =  CONVERT(DATETIME,@Begdate) and T1.F_POSTDATE <= CONVERT(DATETIME,@FmDate)  THEN T1.F_Debit -T1.F_Credit 
            WHEN   T1.F_Type Not In ('X', 'B', 'DB', 'CB') and T1.F_PostDate >= convert(Datetime,@Begdate) and T1.F_PostDate < convert(Datetime,@FmDate) 
            THEN T1.F_Debit - T1.F_Credit ELSE  0 END) as F_BeginBal,  
            SUM(CASE WHEN T1.F_POSTDATE >= CONVERT(DATETIME,@FmDate) AND T1.F_POSTDATE <= CONVERT(DATETIME,@ToDate) AND T1.F_Type Not In ('X', 'B') THEN F_DEBIT ELSE 0 END) AS F_DEBIT,
            SUM(CASE WHEN T1.F_POSTDATE >= CONVERT(DATETIME,@FmDate) AND T1.F_POSTDATE <= CONVERT(DATETIME,@ToDate) AND T1.F_Type Not In ('X', 'B') THEN F_CREDIT ELSE 0 END) AS F_CREDIT

            from v_slip T1 
            Where DATEDIFF(Day,T1.F_PostDate,convert(Datetime,@ToDate)) >=0 
                    AND T1.F_ComName=@Customer   
            group by T1.F_GLNo ;   
        END;   

    Else if @Customer=''  and @Branch <> '' 
        BEGIN 
            INSERT @retBeginBal  
            SELECT T1.F_GLNo as F_GLNo,   
            SUM(CASE WHEN  T1.F_Type In ('X', 'B', 'DB', 'CB') and T1.F_PostDate =  CONVERT(DATETIME,@Begdate) and T1.F_POSTDATE <= CONVERT(DATETIME,@FmDate)  THEN T1.F_Debit -T1.F_Credit 
            WHEN   T1.F_Type Not In ('X', 'B', 'DB', 'CB') and T1.F_PostDate >= convert(Datetime,@Begdate) and T1.F_PostDate < convert(Datetime,@FmDate) 
            THEN T1.F_Debit - T1.F_Credit ELSE  0 END) as F_BeginBal,  
            SUM(CASE WHEN T1.F_POSTDATE >= CONVERT(DATETIME,@FmDate) AND T1.F_POSTDATE <= CONVERT(DATETIME,@ToDate) AND T1.F_Type Not In ('X', 'B') THEN F_DEBIT ELSE 0 END) AS F_DEBIT,
            SUM(CASE WHEN T1.F_POSTDATE >= CONVERT(DATETIME,@FmDate) AND T1.F_POSTDATE <= CONVERT(DATETIME,@ToDate) AND T1.F_Type Not In ('X', 'B') THEN F_CREDIT ELSE 0 END) AS F_CREDIT

            from v_slip T1 
            Where DATEDIFF(Day,T1.F_PostDate,convert(Datetime,@ToDate)) >=0 
                    AND T1.F_Branch = @Branch   
            group by T1.F_GLNo ;  
        END;  

    Else   
        BEGIN   
            INSERT @retBeginBal   
            SELECT T1.F_GLNo as F_GLNo,   
            SUM(CASE WHEN  T1.F_Type In ('X', 'B', 'DB', 'CB') and T1.F_PostDate =  CONVERT(DATETIME,@Begdate) and T1.F_POSTDATE <= CONVERT(DATETIME,@FmDate)  THEN T1.F_Debit -T1.F_Credit 
            WHEN   T1.F_Type Not In ('X', 'B', 'DB', 'CB') and T1.F_PostDate >= convert(Datetime,@Begdate) and T1.F_PostDate < convert(Datetime,@FmDate) 
            THEN T1.F_Debit - T1.F_Credit ELSE  0 END) as F_BeginBal,  
            SUM(CASE WHEN T1.F_POSTDATE >= CONVERT(DATETIME,@FmDate) AND T1.F_POSTDATE <= CONVERT(DATETIME,@ToDate) AND T1.F_Type Not In ('X', 'B') THEN F_DEBIT ELSE 0 END) AS F_DEBIT,
            SUM(CASE WHEN T1.F_POSTDATE >= CONVERT(DATETIME,@FmDate) AND T1.F_POSTDATE <= CONVERT(DATETIME,@ToDate) AND T1.F_Type Not In ('X', 'B') THEN F_CREDIT ELSE 0 END) AS F_CREDIT

            from v_slip T1 
            Where DATEDIFF(Day,T1.F_PostDate,convert(Datetime,@ToDate)) >=0 
                    AND T1.F_ComName=@Customer AND T1.F_Branch = @Branch  
            group by T1.F_GLNo ;   
        END;   
 RETURN;   
 END
" },
            { "uf_AC_NewTBMonth",
                @"
CREATE FUNCTION dbo.uf_AC_NewTBMonth(@FmDate varchar(20),@ToDate varchar(20)) 
 RETURNS @retBeginBal TABLE  
 ( 
    F_GLNo nvarchar(10),  
    F_BRANCH nvarchar(3),  
    F_A1 decimal(16, 4),  
    F_A2 decimal(16, 4),  
    F_A3 decimal(16, 4),  
    F_A4 decimal(16, 4),  
    F_A5 decimal(16, 4),  
    F_A6 decimal(16, 4),  
    F_A7 decimal(16, 4),  
    F_A8 decimal(16, 4),  
    F_A9 decimal(16, 4),  
    F_A10 decimal(16, 4),  
    F_A11 decimal(16, 4),  
    F_A12 decimal(16, 4)  
 )  
 AS 
  
 BEGIN 

            INSERT @retBeginBal  
            SELECT T1.F_GLNO,F_BRANCH,   
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 1 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A1, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 2 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A2, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 3 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A3, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 4 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A4, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 5 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A5, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 6 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A6, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 7 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A7, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 8 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A8, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 9 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A9, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 10 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A10, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 11 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A11, 
            SUM(CASE WHEN MONTH(T1.F_POSTDATE)= 12 THEN F_CREDIT-F_DEBIT ELSE 0 END) AS F_A12 

            from v_slip T1   
            Where DATEDIFF(Day,T1.F_POSTDATE,CONVERT(DATETIME,@FmDate)) <=0 AND DATEDIFF(Day,T1.F_PostDate,convert(Datetime,@ToDate)) >=0 and T1.F_Type Not In ('X', 'B', 'DB', 'CB')
            group by F_GLNO ,F_BRANCH ;  
 RETURN;   
 END
" },        //Scarlar-Valued Function
            { "uf_AC_GetBillType",
                @"
CREATE FUNCTION uf_AC_GetBillType ( @nType VARCHAR(1)) 
RETURNS VarChar(50) 
AS 
 
BEGIN 
 
DECLARE @sRet VARCHAR(50) 
 
 if @nType='1'
   select @sRet='Our Direct Sales/Cost' 
 Else if @nType='2'
   select @sRet='Collect for Agent/Pay for Agent' 
 Else if @nType='3'
   select @sRet='Indirect Customer Sales' 
 Else if @nType='4'
   select @sRet='Cost for Agent' 
 Else if @nType='5'
   select  @sRet='Transit Sales/Cost for Transit Sales' 
RETURN (@sRet) 
 
END 
" },
            { "uf_AC_GetJourType",
                @"
CREATE FUNCTION uf_AC_GetJourType ( @nType VARCHAR(3)) 
RETURNS VarChar(50) 
AS 
 
BEGIN 
 
DECLARE @sRet VARCHAR(50) 
 
 if @nType=1
   select @sRet='Invoice' 
 Else if @nType=2
   select @sRet='Bill' 
 Else if @nType=4
   select @sRet='Customer Payment' 
 Else if @nType=5
   select  @sRet='Bill Payment' 
 Else if @nType=6
   select  @sRet='Deposit Check ' 
 Else if @nType=7
   select @sRet='Check Clear' 
 Else if @nType=8
   select @sRet='Void Deposit' 
 Else if @nType=9
   select @sRet='Void Check' 
 Else if @nType=10
   select @sRet='Adjust Journal Entry' 
 Else if @nType=11
   select  @sRet='Advance Received' 
 Else if @nType=12
   select  @sRet='Advance Payment' 
 Else if @nType=13
   select  @sRet='Deferred Sales' 
 Else if @nType=14
   select  @sRet='Cost/Deferred Cost' 
 Else if @nType=16
   select  @sRet='Cost/Deferred Cost for Indirect Shipment' 
 Else if @nType=21
   select @sRet='Void Check /Advance Payment' 
 Else if @nType=22
   select @sRet='Void Deposit/Advance Received' 
 Else if @nType=23
   select @sRet='Reverse Sales from Deferred' 
 Else if @nType=24
   select  @sRet='Reverse Cost from Deferred' 
 Else if @nType=25
   select @sRet='Agent Cost for Indirect Customer Sales' 
 Else if @nType=27
   select  @sRet='Def. Cost for Indirect Customer Sales' 
 Else if @nType=37
   select  @sRet='Def. Cost for Indirect Customer Sales' 

 Else if @nType=26
   select @sRet='Sales to Agent' 
 Else if @nType=28
   select  @sRet='Deferred Sale' 
 Else if @nType=34
   select  @sRet='Transit Sales' 
 Else if @nType=36
   select  @sRet='Refix Journal' 
 Else if @nType=38
   select  @sRet='Deferred Sales' 
 Else if @nType=40
   select  @sRet='Deferred Cost' 
 Else if @nType=46
   select  @sRet='Deferred Adjust Sales' 
 Else if @nType=48
   select  @sRet='Deferred Adjust Cost' 
 Else if @nType=51
   select  @sRet='Cr/Db Note for Agent' 
 Else if @nType=52
   select  @sRet='Cr/Db Note for Agent' 
 Else if @nType=55
   select  @sRet='Cr/Db Note Deferred Sales' 
 Else if @nType=56
   select  @sRet='Cr/Db Note Deferred Cost' 

Else if @nType=61
   select  @sRet='Cr/Db Note Deferred Sales' 
Else if @nType=62
   select  @sRet='Cr/Db Note Deferred Cost' 
Else if @nType=71
   select  @sRet='Cr/Db Note Deferred Sales P/S' 
Else if @nType=72
   select  @sRet='Cr/Db Note Deferred Cost P/S' 
Else if @nType=80
   select @sRet='Payroll'
Else if @nType=81
   select  @sRet='Cr/Db Note Reverse Sales P/S from Deferred' 
Else if @nType=82
   select  @sRet='Cr/Db Note Reverse Cost P/S from Deferred' 

ELSE if @nType=83
   select @sRet='Bank Transfer'
ELSE if @nType=84
   select @sRet='Void - Bank Transfer'

ELSE IF @nType = 91 
    SET @sRet = 'Prepaid Expense Entry' 
ELSE IF @nType = 92 
    SET @sRet = 'Depreciation Entry' 
ELSE IF @nType = 93 
    SET @sRet = 'Amortization Entry' 
ELSE IF @nType = 94 
    SET @sRet = 'Void - Prepaid Expense Entry' 
ELSE IF @nType = 95 
    SET @sRet = 'Void - Depreciation Entry' 
ELSE IF @nType = 96 
    SET @sRet = 'Void - Amortization Entry' 
Else if @nType=97
    SET @sRet = 'Void - Payroll' 
Else if @nType=99
   select  @sRet='End Year Processing' 
Else if @nType>=100 and @nType <200 
   select  @sRet='Cancelled' 
Else if @nType>=200  
   select  @sRet='Reverse for Cancel' 
RETURN (@sRet+ '('+@ntype+')') 
 
END 
" },
            { "uf_AC_GetJourTypeEx",
                @"
CREATE FUNCTION uf_AC_GetJourTypeEx ( 
    @nType      INTEGER, 
    @nOrder     INTEGER, 
    @nVoid      INTEGER, 
    @sTBName    VARCHAR(20), 
    @nTBID      INTEGER, 
    @dPostDate  DATETIME, 
    @nSeqNo     INTEGER, 
    @sSubTBName VARCHAR(20) 
) 
RETURNS VarChar(50) 
AS 
 
BEGIN 
 
DECLARE @sRet VARCHAR(50), @sTemp VARCHAR(50) 
 
SET @sRet = '' 
 
--Invoice 
 
IF @nType = 11 
    BEGIN 
 
    IF @nVoid > 1 
        IF LEN(@sSubTBName) > 0 
            SET @sRet = 'Void Invoice' 
        ELSE 
            SET @sRet = 'Void G.Invoice' 
    ELSE 
        IF LEN(@sSubTBName) > 0 
            SET @sRet = 'Invoice' 
        ELSE 
            SET @sRet = 'G.Invoice' 
 
    END 
 
ELSE IF @nType = 13 
    SET @sRet = 'Deferred Sales to Sales (Recognized)' 
 
ELSE IF @nType = 15 
    SET @sRet = 'Advance Received' 
 
ELSE IF @nType = 16 
    SET @sRet = 'Void Advance Received' 
 
 
--Bill 
 
ELSE IF @nType = 21 
    BEGIN 
 
    IF @nVoid > 1 
        IF LEN(@sSubTBName) > 0 or @sSubTBName <> 'ECLM'
            SET @sRet = 'Void Bill' 
        ELSE 
            SET @sRet = 'Void G.Bill' 
    ELSE 
        IF LEN(@sSubTBName) > 0 or @sSubTBName <> 'ECLM'
            SET @sRet = 'Bill' 
        ELSE 
            SET @sRet = 'G.Bill' 
 
    END 
 
ELSE IF @nType = 23 
    SET @sRet = 'Deferred Cost to Cost (Recognized)' 
 
ELSE IF @nType = 25 
    SET @sRet = 'Advance Payment' 
 
ELSE IF @nType = 26 
    SET @sRet = 'Void Advance Payment' 
 
 
-- Cr/Db Note 
 
ELSE IF @nType = 31 
    BEGIN 
 
    IF @nVoid > 1 
        SET @sRet = 'Void CR/DB Note' 
    ELSE 
        SET @sRet = 'CR/DB Note' 
 
    END 
 
ELSE IF @nType = 32 
    BEGIN 
 
    IF @nOrder = 1 
        SET @sRet = 'Adjust (Deferred)Sales' 
    ELSE IF @nOrder = 2 
        SET @sRet = 'Adjust (Deferred)Cost' 
 
    END 
 
ELSE IF @nType = 33 
    BEGIN 
 
    IF (@nOrder = 1 Or @nOrder = 2) 
        SET @sRet = 'Deferred Sales to Sales (Recognized)' 
    ELSE IF (@nOrder = 3 Or @nOrder = 4) 
        SET @sRet = 'Deferred Cost to Cost (Recognized)' 
 
    END 
 
ELSE IF @nType = 34 
    SET @sRet = 'Deferred Adjust Sales/Cost (Recognized)' 
 
ELSE IF @nType = 35 
    BEGIN 
 
    IF (@nOrder = 1 Or @nOrder = 2) 
        SET @sRet = 'Advance Received' 
 
    ELSE IF (@nOrder = 3 Or @nOrder = 4) 
        SET @sRet = 'Advance Payment' 
 
    END 
 
ELSE IF @nType = 36 
    BEGIN 
 
    IF (@nOrder = 1 Or @nOrder = 2) 
        SET @sRet = 'Void Advance Received' 
 
    ELSE IF (@nOrder = 3 Or @nOrder = 4) 
        SET @sRet = 'Void Advance Payment' 
 
    END 
 
--Payment 
ELSE IF @nType = 1 
    SET @sRet = 'Credit Card Payment' 
ELSE IF @nType = 2 
    SET @sRet = 'Credit Card Clear' 
ELSE IF @nType = 3 
    SET @sRet = 'Void Credit Card' 
ELSE IF @nType = 4 
    SET @sRet = 'Customer Payment' 
ELSE IF @nType = 5 
    SET @sRet = 'Bill Payment' 
ELSE IF @nType = 6 
    SET @sRet = 'Deposit Check' 
ELSE IF @nType = 7 
    SET @sRet = 'Check Clear' 
ELSE IF @nType = 8 
    SET @sRet = 'Void Deposit' 
ELSE IF @nType = 9 
    SET @sRet = 'Void Check' 
 
ELSE IF @nType = 10 
    SET @sRet = 'Adjust Journal Entry' 
 
ELSE IF @nType = 76 
    SET @sRet = 'Bad Debt Expense Adjustment ' 
ELSE IF @nType = 77 
    SET @sRet = 'Void - Bad Debt Expense Adjustment ' 
ELSE IF @nType = 78 
    SET @sRet = 'Income Tax Adjustment' 
ELSE IF @nType = 79 
    SET @sRet = 'Void - Income Tax Adjustment ' 
ELSE IF @nType = 80 
    SET @sRet = 'Payroll' 
ELSE IF @nType = 81 
    SET @sRet = 'Advance Payment' 
ELSE IF @nType = 83 
    SET @sRet = 'Bank Transfer' 
ELSE IF @nType = 84 
    SET @sRet = 'Void - Bank Transfer' 
ELSE IF @nType = 85 
    SET @sRet = 'Advance Payment' 
 
ELSE IF @nType = 86 
    SET @sRet = 'Void Advance Payment' 
 
ELSE IF @nType = 87 
    SET @sRet = 'Sales Tax Return' 
 
ELSE IF @nType = 88 
    SET @sRet = 'Void - Sales Tax Return' 
 
ELSE IF @nType = 91 
    SET @sRet = 'Prepaid Expense Entry' 
ELSE IF @nType = 92 
    SET @sRet = 'Depreciation Entry' 
ELSE IF @nType = 93 
    SET @sRet = 'Amortization Entry' 
ELSE IF @nType = 94 
    SET @sRet = 'Void - Prepaid Expense Entry' 
ELSE IF @nType = 95 
    SET @sRet = 'Void - Depreciation Entry' 
ELSE IF @nType = 96 
    SET @sRet = 'Void - Amortization Entry' 
Else IF @nType = 97
    SET @sRet = 'Void - Payroll' 
Else IF @nType = 98
    SET @sRet = 'Void Advance Payment' 
ELSE IF @nType = 99 
    SET @sRet = 'End Year Processing' 
 
ELSE IF (@nType >= 100 And @nType < 200) 
    SET @sRet = 'Cancelled' 
ELSE IF @nType >= 200 
    SET @sRet = 'Reverse' 
 
RETURN (@sRet + ' (' + CONVERT(VARCHAR(3), @nType) + ')') 
 
END
" },
            { "uf_AC_GetStaus",
                @"
CREATE FUNCTION uf_AC_GetStaus (@sTBName VARCHAR(10),@nTBname VARCHAR(10), @nTBID INT) 
RETURNS VarChar(1) 
AS 
 
BEGIN 
 
DECLARE @sRet VARCHAR(1) 
 
IF @sTBName = 'T_APHD' 
    SELECT @sRet = F_APOK FROM V_OpStatusbyTable WHERE F_TBNAME=@nTBname and F_TBID = @nTBID 
ELSE IF @sTBName = 'T_INVOHD' 
    SELECT @sRet =  F_INVOK FROM V_OpStatusbyTable WHERE F_TBNAME=@nTBname and F_TBID = @nTBID 
ELSE IF @sTBName = 'T_CRDBHD' 
    SELECT @sRet =  F_CRDBOK FROM V_OpStatusbyTable WHERE F_TBNAME=@nTBname and F_TBID = @nTBID 
 
RETURN (@sRet) 
 
END
" },
            { "uf_AcctStartDate",
                @"
CREATE FUNCTION dbo.uf_AcctStartDate() 
RETURNS DateTime 
AS 
 
BEGIN 
 
-- Account Start Date : 2017-03 을 설정한 경우, 이 함수는 2017-03-01을 반환한다. 
 
DECLARE @BeginYear INT, @BeginMonth INT     -- Account Start Date  
DECLARE @AcctStartDate DATETIME 
 
SET @BeginYear = (SELECT (CASE WHEN F_C3 = '000000' THEN '2000' ELSE SUBSTRING(F_C3, 1, 4) END) FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27) 
SET @BeginMonth = (SELECT (CASE WHEN F_C3 = '000000' THEN '01' ELSE SUBSTRING(F_C3, 5, 2) END) FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27) 
SET @AcctStartDate = CONVERT(DATETIME, CONVERT(VARCHAR(4),@BeginYear) + RIGHT('0' + CONVERT(VARCHAR(2),@BeginMonth), 2) + '01') 
 
RETURN @AcctStartDate 
 
End
" },
            { "uf_AcctStartYearBeginDate",
                @"
CREATE FUNCTION dbo.uf_AcctStartYearBeginDate() 
RETURNS DateTime 
AS 
 
BEGIN 
 
-- Account Start Date : 2017-03 을 설정한 경우, 이 함수는 2017-01-01 (Fiscal Month가 12인 경우)을 반환한다. 
 
DECLARE @FiscalEndMonth INT 
DECLARE @BeginYear INT, @BeginMonth INT     -- Account Start Date (Fiscal Base) 
DECLARE @UsingYear INT, @UsingMonth INT     -- User Start Date 
DECLARE @AcctStartDate DATETIME 
 
SET @FiscalEndMonth =(SELECT F_N2 FROM T_AotherInfo WHERE F_TBNAME = 'T_CODEDATA' AND F_TBID = 1 AND F_TYPE = 27) 
SET @UsingYear = (SELECT (CASE WHEN F_C3 = '000000' THEN '2000' ELSE SUBSTRING(F_C3, 1, 4) END) FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27) 
SET @UsingMonth = (SELECT (CASE WHEN F_C3 = '000000' THEN '01' ELSE SUBSTRING(F_C3, 5, 2) END) FROM T_AOtherinfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = 1 And F_TYPE = 27) 
SET @BeginYear = (CASE WHEN (CASE WHEN @FiscalEndMonth = 12 THEN 1 ELSE @FiscalEndMonth + 1 END) > @UsingMonth THEN @UsingYear - 1 ELSE @UsingYear END) 
SET @BeginMonth = (CASE WHEN @FiscalEndMonth = 12 THEN 1 ELSE @FiscalEndMonth + 1 END) 
SET @AcctStartDate = CONVERT(DATETIME, CONVERT(VARCHAR(4),@BeginYear) + RIGHT('0' + CONVERT(VARCHAR(2),@BeginMonth), 2) + '01') 
 
RETURN @AcctStartDate 
 
End
" },
            { "uf_CrDbInvPaid",
                @"
CREATE FUNCTION dbo.uf_CrDbInvPaid ( 
    @sTBName        VARCHAR(20), 
    @nTBID          INT, 
    @nAgent         INT 
) 
RETURNS DECIMAL(16, 2) 
AS 
 
BEGIN 
 
DECLARE @fARPaidAmt DECIMAL(16,2) 
 
SET @fARPaidAmt = 0 
 
IF @sTBName = 'T_AIMMAIN' 
    SELECT @fARPaidAmt = SUM(ROUND(COALESCE(T3.F_InvoiceAmt, T4.F_InvoiceAmt, 0) - COALESCE(T3.F_PaidAmt, T4.F_PaidAmt, 0), 2)) 
    FROM T_AIMMAIN T1 
        LEFT JOIN T_AIHMAIN T2 On (T2.F_AIMBLID = T1.F_ID And T2.F_Agent = @nAgent) 
        LEFT JOIN T_INVOHD T3 On (T3.F_TBID = T2.F_ID And T3.F_TBName = 'T_AIHMAIN') 
        LEFT JOIN T_INVOHD T4 On (T4.F_TBID = T1.F_ID And T4.F_TBName = 'T_AIMMAIN') 
    WHERE T1.F_ID = @nTBID 
 
ELSE IF @sTBName = 'T_AOMMAIN' 
    SELECT @fARPaidAmt = SUM(ROUND(COALESCE(T3.F_InvoiceAmt, T4.F_InvoiceAmt, 0) - COALESCE(T3.F_PaidAmt, T4.F_PaidAmt, 0), 2)) 
    FROM T_AOMMAIN T1 
        LEFT JOIN T_AOHMAIN T2 On (T2.F_AOMBLID = T1.F_ID And T2.F_Agent = @nAgent) 
        LEFT JOIN T_INVOHD T3 On (T3.F_TBID = T2.F_ID And T3.F_TBName = 'T_AOHMAIN') 
        LEFT JOIN T_INVOHD T4 On (T4.F_TBID = T1.F_ID And T4.F_TBName = 'T_AOMMAIN') 
    WHERE T1.F_ID = @nTBID 
 
ELSE IF @sTBName = 'T_OIMMAIN' 
    SELECT @fARPaidAmt = SUM(ROUND(COALESCE(T3.F_InvoiceAmt, T4.F_InvoiceAmt, 0) - COALESCE(T3.F_PaidAmt, T4.F_PaidAmt, 0), 2)) 
    FROM T_OIMMAIN T1 
        LEFT JOIN T_OIHMAIN T2 On (T2.F_OIMBLID = T1.F_ID) 
        LEFT JOIN T_INVOHD T3 On (T3.F_TBID = T2.F_ID And T3.F_TBName = 'T_OIHMAIN') 
        LEFT JOIN T_INVOHD T4 On (T4.F_TBID = T1.F_ID And T4.F_TBName = 'T_OIMMAIN') 
    WHERE T1.F_ID = @nTBID 
 
ELSE IF @sTBName = 'T_OOMMAIN' 
    SELECT @fARPaidAmt = SUM(ROUND(COALESCE(T3.F_InvoiceAmt, T4.F_InvoiceAmt, 0) - COALESCE(T3.F_PaidAmt, T4.F_PaidAmt, 0), 2)) 
    FROM T_OOMMAIN T1 
        LEFT JOIN T_OOHMAIN T2 On (T2.F_OOMBLID = T1.F_ID And T2.F_Agent = @nAgent) 
        LEFT JOIN T_INVOHD T3 On (T3.F_TBID = T2.F_ID And T3.F_TBName = 'T_OOHMAIN') 
        LEFT JOIN T_INVOHD T4 On (T4.F_TBID = T1.F_ID And T4.F_TBName = 'T_OOMMAIN') 
    WHERE T1.F_ID = @nTBID 
 
ELSE 
    SELECT @fARPaidAmt = SUM(ROUND(T1.F_InvoiceAmt - T1.F_PaidAmt, 2)) 
    FROM T_INVOHD T1 
    WHERE T1.F_TBID = @nTBID And T1.F_TBName = @sTBName 
 
RETURN @fARPaidAmt 
 
END 
" },
            { "uf_GetBigDate3",
                @"
CREATE FUNCTION dbo.uf_GetBigDate3 ( 
    @dValue1        DATETIME, 
    @dValue2        DATETIME, 
    @dValue3        DATETIME 
) 
RETURNS DateTime 
AS 
 
BEGIN 
 
DECLARE @dRet DATETIME 
 
 
IF @dValue1 >= @dValue2 
    IF @dValue1 >= @dValue3 
        SET @dRet = @dValue1 
    Else 
        SET @dRet = @dValue3 
Else 
    IF @dValue2 >= @dValue3 
        SET @dRet = @dValue2 
    Else 
        SET @dRet = @dValue3 
 
RETURN @dRet 
 
End 
" },
            { "uf_GetCorrectionAmount",
                @"
CREATE FUNCTION [dbo].[uf_GetCorrectionAmount] ( 
    @sTBName        VARCHAR(20), 
    @nTBID          INT, 
    @nMTBID         INT, 
   @dAmount        FLOAT, 
    @dTotal         FLOAT, 
   @nIsShare       INT, 
   @nDecimal       INT 
) 
RETURNS FLOAT 
AS 
-- Master B/L에서 금액을 분배하는 로직 사용 시, Huser B/L의 MAX(F_ID)에 맞지 않는 금액 만큼 보정 해주는 함수 

 
BEGIN 
 
DECLARE @fARPaidAmt FLOAT 
 
SET @fARPaidAmt = 0 
 
IF @nIsShare = 0 
BEGIN 
   SET @fARPaidAmt = @dAmount 
   RETURN @fARPaidAmt 
END 
 
IF @sTBName = 'T_OIHMAIN' 
 
   SELECT @fARPaidAmt = CASE WHEN @nTBID = MAXID THEN @dAmount + ROUND(F_MyShare, @nDecimal) ELSE @dAmount END 
   FROM ( 
       SELECT MAX(T1.F_ID) AS MAXID, T1.F_OIMBLID, ROUND(@dTotal - SUM(ROUND(@dTotal * CASE COALESCE(T2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE (CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) / T2.F_MCBM END, @nDecimal)), @nDecimal) AS F_MyShare 
       FROM T_OIHMAIN T1 
           LEFT JOIN ( 
               SELECT F_OIMBLID AS F_MTBId, COUNT(F_ID) AS F_HCount, SUM(CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) as F_MCBM FROM T_OIHMAIN GROUP BY F_OIMBLID 
           ) T2 ON T2.F_MTBId = T1.F_OIMBLID 
       GROUP BY F_OIMBLID 
   ) T1 
   WHERE F_OIMBLID = @nMTBID 

ELSE IF @sTBName = 'T_OOHMAIN' 
 
   SELECT @fARPaidAmt = CASE WHEN @nTBID = MAXID THEN @dAmount + ROUND(F_MyShare, @nDecimal) ELSE @dAmount END 
   FROM ( 
       SELECT MAX(T1.F_ID) AS MAXID, T1.F_OOMBLID, ROUND(@dTotal - SUM(ROUND(@dTotal * CASE COALESCE(T2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE (CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) / T2.F_MCBM END,@nDecimal)),@nDecimal) AS F_MyShare 
       FROM T_OOHMAIN T1 
           LEFT JOIN ( 
               SELECT F_OOMBLID AS F_MTBId, COUNT(F_ID) AS F_HCount, SUM(CASE WHEN F_CBM * 800 >= F_LBS THEN F_CBM ELSE F_LBS / 800 END) as F_MCBM FROM T_OOHMAIN GROUP BY F_OOMBLID 
           ) T2 ON T2.F_MTBId = T1.F_OOMBLID 
       GROUP BY F_OOMBLID 
   ) T1 
   WHERE F_OOMBLID = @nMTBID 

ELSE IF @sTBName = 'T_AIHMAIN' 
 
   SELECT @fARPaidAmt = CASE WHEN @nTBID = MAXID THEN @dAmount + ROUND(F_MyShare, @nDecimal) ELSE @dAmount END 
   FROM ( 
       SELECT MAX(T1.F_ID) AS MAXID, T1.F_AIMBLID, ROUND(@dTotal - SUM(ROUND(@dTotal * CASE COALESCE(T2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE F_ChgWeight / T2.F_MCBM END,@nDecimal)),@nDecimal) AS F_MyShare 
       FROM T_AIHMAIN T1 
           LEFT JOIN ( 
               SELECT F_AIMBLID AS F_MTBId, COUNT(F_ID) AS F_HCount, SUM(F_ChgWeight) as F_MCBM FROM T_AIHMAIN GROUP BY F_AIMBLID 
           ) T2 ON T2.F_MTBId = T1.F_AIMBLID 
       GROUP BY F_AIMBLID 
   ) T1 
   WHERE F_AIMBLID = @nMTBID 

ELSE IF @sTBName = 'T_AOHMAIN' 
 
   SELECT @fARPaidAmt = CASE WHEN @nTBID = MAXID THEN @dAmount + ROUND(F_MyShare, @nDecimal) ELSE @dAmount END 
   FROM ( 
       SELECT MAX(T1.F_ID) AS MAXID, T1.F_AOMBLID, ROUND(@dTotal - SUM(ROUND(@dTotal * CASE COALESCE(T2.F_MCBM, 0) WHEN 0 THEN 1.0 / F_HCount ELSE F_ChgWeight / T2.F_MCBM END,@nDecimal)),@nDecimal) AS F_MyShare 
       FROM T_AOHMAIN T1 
           LEFT JOIN ( 
               SELECT F_AOMBLID AS F_MTBId, COUNT(F_ID) AS F_HCount, SUM(F_CChgWeight) as F_MCBM FROM T_AOHMAIN GROUP BY F_AOMBLID 
           ) T2 ON T2.F_MTBId = T1.F_AOMBLID 
       GROUP BY F_AOMBLID 
   ) T1 
   WHERE F_AOMBLID = @nMTBID 
 
RETURN ROUND(@fARPaidAmt, @nDecimal) 
 
END
" },
            { "uf_GetDefaultBankId",
                @"
CREATE FUNCTION dbo.uf_GetDefaultBankId ( 
    @sCurrency      VARCHAR(3) 
) 
RETURNS INTEGER 
AS 
 
BEGIN 
 
DECLARE @nRet INTEGER 
 
SELECT TOP 1 @nRet = F_ID 
From T_CODEBANK 
WHERE F_Currency = @sCurrency 
ORDER BY F_DefaultBank DESC 
 
RETURN @nRet 
 
End
" },
            { "uf_GetEstFinalDate",
                @"
CREATE FUNCTION dbo.uf_GetEstFinalDate ( 
    @sTBName    VARCHAR(10), 
    @nTBId      INTEGER 
) 
RETURNS DATETIME 
AS 
 
BEGIN 
  
DECLARE @dRet DATETIME 
 
 
IF @sTBName = 'T_OIMMAIN' 
 
    SELECT TOP 1 @dRet = T1.InvDate 
    FROM ( 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_INVOHD WHERE F_Void = 0 AND ((F_TBName = 'T_OIMMAIN' And F_TBID = @nTBId) Or (F_TBName = 'T_OIHMAIN' And F_TBID In (SELECT F_ID FROM T_OIHMAIN WHERE F_OIMBLID = @nTBId))) 
        Union 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_APHD WHERE F_Void = 0 AND ((F_TBName = 'T_OIMMAIN' And F_TBID = @nTBId) Or (F_TBName = 'T_OIHMAIN' And F_TBID In (SELECT F_ID FROM T_OIHMAIN WHERE F_OIMBLID = @nTBId))) 
        Union 
        SELECT MAX(CASE WHEN OP.F_ChgType in (5,6,8,15,16) THEN F_cDate ELSE TH.F_InvoiceDate END) AS F_InvDate FROM T_CRDBHD TH 
        LEFT JOIN T_CRDBDETAIL TD ON TD.F_CrDbHDID = TH.F_ID 
        LEFT JOIN T_OPACCT OP ON OP.F_ID = TD.F_STBID AND TD.F_STBName = 'T_OPACCT' 
        LEFT JOIN V_BLSUMM BL ON BL.F_TBID = TH.F_TBID And BL.F_TBNAme = TH.F_TBName 
        WHERE TH.F_Void = 0 And BL.F_MTBName = 'T_OIMMAIN' And BL.F_MBLID = @nTBId 
    ) T1 
    ORDER BY T1.InvDate DESC 
 
ELSE IF @sTBName = 'T_OOMMAIN' 
 
    SELECT TOP 1 @dRet = T1.InvDate 
    FROM ( 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_INVOHD WHERE F_Void = 0 AND ((F_TBName = 'T_OOMMAIN' And F_TBID = @nTBId) Or (F_TBName = 'T_OOHMAIN' And F_TBID In (SELECT F_ID FROM T_OOHMAIN WHERE F_OOMBLID = @nTBId))) 
        Union 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_APHD WHERE F_Void = 0 AND ((F_TBName = 'T_OOMMAIN' And F_TBID = @nTBId) Or (F_TBName = 'T_OOHMAIN' And F_TBID In (SELECT F_ID FROM T_OOHMAIN WHERE F_OOMBLID = @nTBId))) 
        Union 
        SELECT MAX(CASE WHEN OP.F_ChgType in (5,6,8,15,16) THEN F_cDate ELSE TH.F_InvoiceDate END) AS F_InvDate FROM T_CRDBHD TH 
        LEFT JOIN T_CRDBDETAIL TD ON TD.F_CrDbHDID = TH.F_ID 
        LEFT JOIN T_OPACCT OP ON OP.F_ID = TD.F_STBID AND TD.F_STBName = 'T_OPACCT' 
        LEFT JOIN V_BLSUMM BL ON BL.F_TBID = TH.F_TBID And BL.F_TBNAme = TH.F_TBName 
        WHERE TH.F_Void = 0 And BL.F_MTBName = 'T_OOMMAIN' And BL.F_MBLID = @nTBId 
    ) T1 
    ORDER BY T1.InvDate DESC 
 

ELSE IF @sTBName = 'T_AIMMAIN' 
 
    SELECT TOP 1 @dRet = T1.InvDate 
    FROM ( 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_INVOHD WHERE F_Void = 0 AND ((F_TBName = 'T_AIMMAIN' And F_TBID = @nTBId) Or (F_TBName = 'T_AIHMAIN' And F_TBID In (SELECT F_ID FROM T_AIHMAIN WHERE F_AIMBLID = @nTBId))) 
        Union 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_APHD WHERE F_Void = 0 AND ((F_TBName = 'T_AIMMAIN' And F_TBID = @nTBId) Or (F_TBName = 'T_AIHMAIN' And F_TBID In (SELECT F_ID FROM T_AIHMAIN WHERE F_AIMBLID = @nTBId))) 
        Union 
        SELECT MAX(CASE WHEN OP.F_ChgType in (5,6,8,15,16) THEN F_cDate ELSE TH.F_InvoiceDate END) AS F_InvDate FROM T_CRDBHD TH 
        LEFT JOIN T_CRDBDETAIL TD ON TD.F_CrDbHDID = TH.F_ID 
        LEFT JOIN T_OPACCT OP ON OP.F_ID = TD.F_STBID AND TD.F_STBName = 'T_OPACCT' 
        LEFT JOIN V_BLSUMM BL ON BL.F_TBID = TH.F_TBID And BL.F_TBNAme = TH.F_TBName 
        WHERE TH.F_Void = 0 And BL.F_MTBName = 'T_AIMMAIN' And BL.F_MBLID = @nTBId 
    ) T1 
    ORDER BY T1.InvDate DESC 
 
ELSE IF @sTBName = 'T_AOMMAIN' 
 
    SELECT TOP 1 @dRet = T1.InvDate 
    FROM ( 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_INVOHD WHERE F_Void = 0 AND ((F_TBName = 'T_AOMMAIN' And F_TBID = @nTBId) Or (F_TBName = 'T_AOHMAIN' And F_TBID In (SELECT F_ID FROM T_AOHMAIN WHERE F_AOMBLID = @nTBId))) 
        Union 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_APHD WHERE F_Void = 0 AND ((F_TBName = 'T_AOMMAIN' And F_TBID = @nTBId) Or (F_TBName = 'T_AOHMAIN' And F_TBID In (SELECT F_ID FROM T_AOHMAIN WHERE F_AOMBLID = @nTBId))) 
        Union 
        SELECT MAX(CASE WHEN OP.F_ChgType in (5,6,8,15,16) THEN F_cDate ELSE TH.F_InvoiceDate END) AS F_InvDate FROM T_CRDBHD TH 
        LEFT JOIN T_CRDBDETAIL TD ON TD.F_CrDbHDID = TH.F_ID 
        LEFT JOIN T_OPACCT OP ON OP.F_ID = TD.F_STBID AND TD.F_STBName = 'T_OPACCT' 
        LEFT JOIN V_BLSUMM BL ON BL.F_TBID = TH.F_TBID And BL.F_TBNAme = TH.F_TBName 
        WHERE TH.F_Void = 0 And BL.F_MTBName = 'T_AOMMAIN' And BL.F_MBLID = @nTBId 
    ) T1 
    ORDER BY T1.InvDate DESC 
 
ELSE IF @sTBName = 'T_GENMAIN' 
 
    SELECT TOP 1 @dRet = T1.InvDate 
    FROM ( 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_INVOHD WHERE F_Void = 0 AND (F_TBName = 'T_GENMAIN' And F_TBID = @nTBId) 
        Union 
        SELECT MAX(F_InvoiceDate) As InvDate FROM T_APHD WHERE F_Void = 0 AND (F_TBName = 'T_GENMAIN' And F_TBID = @nTBId) 
        Union 
        SELECT MAX(CASE WHEN OP.F_ChgType in (5,6,8,15,16) THEN F_cDate ELSE TH.F_InvoiceDate END) AS F_InvDate FROM T_CRDBHD TH 
        LEFT JOIN T_CRDBDETAIL TD ON TD.F_CrDbHDID = TH.F_ID 
        LEFT JOIN T_OPACCT OP ON OP.F_ID = TD.F_STBID AND TD.F_STBName = 'T_OPACCT' 
        LEFT JOIN V_BLSUMM BL ON BL.F_TBID = TH.F_TBID And BL.F_TBNAme = TH.F_TBName 
        WHERE TH.F_Void = 0 And BL.F_MTBName = 'T_GENMAIN' And BL.F_MBLID = @nTBId 
    ) T1 
    ORDER BY T1.InvDate DESC 
 
 
RETURN @dRet 
 
End
" },
            { "uf_GetExistStr2",
                @"
CREATE FUNCTION dbo.uf_GetExistStr2 ( 
    @sStr1      VARCHAR(MAX), 
    @sStr2      VARCHAR(MAX) 
) 
RETURNS VarChar(Max) 
AS 
 
BEGIN 
 
IF LEN(@sStr1) > 0 RETURN @sStr1 
 
RETURN @sStr2 
 
End 
" },
            { "uf_GetExistStr3",
                @"
CREATE FUNCTION dbo.uf_GetExistStr3 ( 
    @sStr1      VARCHAR(MAX), 
    @sStr2      VARCHAR(MAX), 
    @sStr3      VARCHAR(MAX) 
) 
RETURNS VarChar(Max) 
AS 
 
BEGIN 
 
IF LEN(@sStr1) > 0 RETURN @sStr1 
IF LEN(@sStr2) > 0 RETURN @sStr2 
 
RETURN @sStr2 
 
End 
" },
            { "uf_GetFixedRound",
                @"
--소수 2자리 반올림에 경우 : 5째 자리에서 0.00001을 더해준 후 소수 2째 자리에서 반올림함.( ex) 1549.99499999999 ...999로 반복되는 값을 반올림하기 위한 함수) 
CREATE FUNCTION [dbo].[uf_GetFixedRound] ( @Value As float, @nDecimalPoint INT) 
RETURNS FLOAT 
AS 
BEGIN 
RETURN ROUND(@Value + POWER(CONVERT(FLOAT,10), -(@nDecimalPoint + 3)), @nDecimalPoint) 
END
" },
            { "uf_Slip_GetBranch",
                @"
CREATE FUNCTION uf_Slip_GetBranch (@sTBName VARCHAR(10), @nTBID INT) 
RETURNS VarChar(3) 
AS 
 
BEGIN 
 
DECLARE @sRet VARCHAR(3) 
 
IF @sTBName = 'T_WSHIPHD' 
    SELECT @sRet = F_Branch FROM T_WSHIPHD WHERE F_ID = @nTBID 
ELSE IF @sTBName = 'T_WRECEIVE' 
    SELECT @sRet = F_Branch FROM T_WRECEIVEHD WHERE F_ID = @nTBID 
ELSE IF @sTBName = 'T_GENMAIN' 
    SELECT @sRet = F_Branch FROM T_GENMAIN WHERE F_ID = @nTBID 
 
ELSE IF @sTBName = 'T_OIMMAIN' 
    SELECT @sRet = F_Branch FROM T_OIMMAIN WHERE F_ID = @nTBID 
ELSE IF @sTBName = 'T_OIHMAIN' 
    SELECT @sRet = T1.F_Branch FROM T_OIMMAIN As T1 LEFT JOIN T_OIHMAIN As T2 On (T2.F_OIMBLID = T1.F_ID) WHERE T2.F_ID = @nTBID 
 
ELSE IF @sTBName = 'T_OOMMAIN' 
    SELECT @sRet = F_Branch FROM T_OOMMAIN WHERE F_ID = @nTBID 
ELSE IF @sTBName = 'T_OOHMAIN' 
    SELECT @sRet = T1.F_Branch FROM T_OOMMAIN As T1 LEFT JOIN T_OOHMAIN As T2 On (T2.F_OOMBLID = T1.F_ID) WHERE T2.F_ID = @nTBID 
ELSE IF @sTBName = 'T_AIMMAIN' 
    SELECT @sRet = F_Branch FROM T_AIMMAIN WHERE F_ID = @nTBID 
ELSE IF @sTBName = 'T_AIHMAIN' 
    SELECT @sRet = T1.F_Branch FROM T_AIMMAIN As T1 LEFT JOIN T_AIHMAIN As T2 On (T2.F_AIMBLID = T1.F_ID) WHERE T2.F_ID = @nTBID 
ELSE IF @sTBName = 'T_AOMMAIN' 
    SELECT @sRet = F_Branch FROM T_AOMMAIN WHERE F_ID = @nTBID 
ELSE IF @sTBName = 'T_AOHMAIN' 
    SELECT @sRet = T1.F_Branch FROM T_AOMMAIN As T1 LEFT JOIN T_AOHMAIN As T2 On (T2.F_AOMBLID = T1.F_ID) WHERE T2.F_ID = @nTBID 
Else 
    SELECT @sRet = F_C1 FROM T_AOtherInfo WHERE F_TBName = 'T_CODEDATA' And F_TBID = '1' And F_Type = '27' 
 
IF Len(@sRet) = 0 
    SET @sRet = '' 
 
RETURN (ISNULL(@sRet,''))  
 
END
" },
            { "uf_Slip_GetFixedGLNo",
                @"
CREATE FUNCTION uf_Slip_GetFixedGLNo (@sGLField VARCHAR(20), @sDivision VARCHAR(2)) 
RETURNS VarChar(10) 
AS 
 
BEGIN 
 
DECLARE @sRet VARCHAR(10) 
 
SELECT @sRet = '' 
 
IF @sGLField = 'F_ARGLNo' 
    SELECT TOP 1 @sRet = F_ARGLNo FROM T_CODEDATA 
ELSE IF @sGLField = 'F_APGLNo' 
    SELECT TOP 1 @sRet = F_APGLNo FROM T_CODEDATA 
ELSE IF @sGLField = 'F_ARGLNOUS' 
    SELECT @sRet = 'F_ARGLNo' 
   -- SELECT TOP 1 @sRet = F_ARGLNOUS FROM T_CODEDATA 
ELSE IF @sGLField = 'F_PAYGL' 
    SELECT @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_PAYGL' 
ELSE IF @sGLField = 'F_RECGL' 
    SELECT @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_RECEIVEGL' 
ELSE IF @sGLField = 'F_AgentGLNo' 
    SELECT TOP 1 @sRet = F_AgentGLNo FROM T_CODEDATA 
 
ELSE IF @sGLField = 'AgentAPGLNo' 
    BEGIN 
 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'AgentAPGLNo' 
    IF @sRet = '' 
        SELECT TOP 1 @sRet = F_AgentGLNo FROM T_CODEDATA 
 
    End 
ELSE IF @sGLField = 'F_AgentRevGLNo' 
    SELECT TOP 1 @sRet = F_AgentRevGLNo FROM T_CODEDATA 
ELSE IF @sGLField = 'AgentCostGLNo' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'AgentCostGLNo' 
 
ELSE IF @sGLField = 'AgentRev' 
    BEGIN 
 
    IF @sDivision = 'OI' 
        SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_AgentOIRev' 
    ELSE IF @sDivision = 'AI' 
        SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_AgentAIRev' 
    ELSE IF @sDivision = 'OE' 
        SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_AgentOERev' 
    ELSE IF @sDivision = 'AE' 
        SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_AgentAERev' 
 
 
    IF @sRet = '' 
        SELECT TOP 1 @sRet = F_AgentRevGLNo FROM T_CODEDATA 
 
    End 
 
ELSE IF @sGLField = 'AgentCost' 
    BEGIN 
 
    IF @sDivision = 'OI' 
        SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'AgentOICost' 
    ELSE IF @sDivision = 'AI' 
        SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'AgentAICost' 
    ELSE IF @sDivision = 'OE' 
        SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'AgentOECost' 
   ELSE IF @sDivision = 'AE' 
        SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'AgentAECost' 
 
 
    IF @sRet = '' 
        SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'AgentCostGLNo' 
 
    End 
 
ELSE IF @sGLField = 'NetIcomeGL' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'NetIcomeGL' 
 
ELSE IF @sGLField = 'F_ADVREC' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_ADVREC' 
 
ELSE IF @sGLField = 'F_VATRCVGL' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_VATRCVGL' 
 
ELSE IF @sGLField = 'F_DUTYLOAN' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_DUTYLOAN' 
ELSE IF @sGLField = 'F_ADVPAY' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_ADVPAY' 
 
 
ELSE IF @sGLField = 'F_DefSales' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_DefSales' 
 
ELSE IF @sGLField = 'F_DefCost' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_DefCost' 
ELSE IF @sGLField = 'F_FCTG' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_FCTG' 
 
ELSE IF @sGLField = 'F_FCTL' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_FCTL' 
ELSE IF @sGLField = 'F_VATGLNO' 
    SELECT TOP 1 @sRet = RTRIM(F_Value) FROM T_SETTINGS WHERE F_Name = 'F_VATGLNO' 
 
ELSE IF @sGLField = 'F_EarningGLNo' 
    SELECT TOP 1 @sRet = RTRIM(F_EarningGLNo) FROM T_CODEDATA 
 
ELSE IF @sGLField = 'F_CheckRcv' 
    SELECT TOP 1 @sRet = RTRIM(F_C7) From T_AOTHERINFO Where F_TBID =1 And F_TBName='T_CODEDATA' And F_Type=27 
 
ELSE IF @sGLField = 'F_CheckPay' 
    SELECT TOP 1 @sRet = RTRIM(F_C8) From T_AOTHERINFO Where F_TBID =1 And F_TBName='T_CODEDATA' And F_Type=27 
ELSE IF @sGLField = 'F_CCPay' 
    SET @sRet = '211620' 
 
Else 
    SELECT @sRet = '' 
 
 
RETURN (@sRet) 
 
End
" },
            { "uf_Slip_GetHeadSubCode",
                @"
CREATE FUNCTION [dbo].[uf_Slip_GetHeadSubCode] (@nApHDId INT) 
RETURNS NVARCHAR(20) 
AS 
 
BEGIN 
  
DECLARE @sRet NVARCHAR(20) 
 
SELECT @sRet = COALESCE(T3.F_SubCode, '') 
FROM T_APHD T1 
    LEFT JOIN ( 
        SELECT Min(F_ID) As F_APDetailID, F_APHDID 
        FROM T_APDETAIL 
        WHERE F_APHDID = @nApHDId And F_SubCode <> '' 
        GROUP BY F_APHDID 
    ) T2 On (T2.F_APHDID = T1.F_ID) 
    LEFT JOIN T_APDETAIL T3 On (T3.F_ID = T2.F_APDetailID) 
WHERE T1.F_ID = @nApHDId 
 
RETURN (@sRet) 
 
End
" },
            { "uf_Slip_GetNextSeqNo",
                @"
CREATE FUNCTION uf_Slip_GetNextSeqNo (@dPDate DATETIME, @sBranch VARCHAR(3)) 
RETURNS  INTEGER 
AS 
 
BEGIN 
 
DECLARE @nRet INTEGER 
DECLARE @nSeqNo INTEGER 
 
 
SET @nRet = 1 
 
DECLARE curSlip CURSOR FAST_FORWARD 
FOR 
 
SELECT F_SeqNo FROM T_SLIPHD WHERE F_PostDate = @dPDate And F_Branch = @sBranch ORDER BY F_SeqNo 
OPEN curSlip 
 
FETCH NEXT FROM curSlip INTO @nSeqNo 
WHILE @nSeqNo = @nRet 
BEGIN 
    SET @nRet = @nRet + 1 
    FETCH NEXT FROM curSlip INTO @nSeqNo 
End 
 
Close curSlip 
DEALLOCATE curSlip 
 
RETURN (@nRet) 
 
End
" },
            { "uf_Slip_GetRefno",
                @"
CREATE FUNCTION uf_Slip_GetRefno (@sTBName VARCHAR(10), @nTBID INT) 
RETURNS VarChar(20) 
AS 
 
BEGIN 
 
DECLARE @sRet VARCHAR(20) 
IF @sTBName = 'T_INVOHD'
    SELECT @sRet = F_REFNO FROM V_INVO WHERE F_ID = @nTBID 
ELSE IF @sTBName = 'T_INVODETAIL'
   SELECT @sRet = F_REFNO FROM T_INVODETAIL D LEFT JOIN V_INVO H ON H.F_ID=D.F_INVOHDID WHERE D.F_ID = @nTBID 
ELSE IF @sTBName = 'T_APHD' 
    SELECT @sRet = F_REFNO FROM V_AP WHERE F_ID = @nTBID 
ELSE IF @sTBName = 'T_APDETAIL' 
    SELECT @sRet = F_REFNO FROM T_APDETAIL D LEFT JOIN V_AP H ON H.F_ID=D.F_APHDID WHERE D.F_ID = @nTBID 
ELSE IF @sTBName = 'T_CRDBHD' 
    SELECT @sRet = F_REFNO FROM V_CRDB WHERE F_ID = @nTBID 
ELSE IF @sTBName = 'T_CRDBDETAIL' 
    SELECT @sRet = F_REFNO FROM T_CRDBDETAIL D LEFT JOIN V_CRDB H ON H.F_ID=D.F_CRDBHDID WHERE D.F_ID = @nTBID 
ELSE IF @sTBName = 'T_DEPODETAIL' 
    SELECT @sRet = F_REFNO FROM (SELECT D.F_ID,CASE D.F_TBNAME WHEN 'T_INVOHD' THEN VI.F_REFNO WHEN 'T_APHD' THEN VA.F_REFNO WHEN 'T_CRDBHD' THEN VC.F_REFNO ELSE '' END AS F_REFNO FROM T_DEPODETAIL D  LEFT JOIN V_INVO VI ON VI.F_ID=D.F_TBID  LEFT JOIN V_AP VA ON VA.F_ID=D.F_TBID LEFT JOIN V_CRDB VC ON VC.F_ID=D.F_TBID) T2  WHERE T2.F_ID = @nTBID 
 
IF Len(@sRet) = 0 
    SET @sRet = NULL 
 
RETURN (@sRet) 
 
END
" }
        };


        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            List<string> list2 = new List<string>();

            foreach (string Key in DicTableInfo.Keys)
            {
                list.Add(Key);
            }
            list2 = list.Distinct().ToList();

            foreach (string Key in list)
            {
                Console.WriteLine(Key);
            }


            Console.WriteLine("**********************************************");

            foreach (string Key in list2)
            {
                Console.WriteLine(Key);
            }

        }

    }

    public class DBFieldInfo
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public bool Index { get; set; }

        public DBFieldInfo(string fieldName, string fieldType, bool index = false)
        {
            FieldName = fieldName;
            FieldType = fieldType;
            Index = index;
        }
    }
}
