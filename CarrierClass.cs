using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace iAldazUnlock.Funciones
{
    internal class CarrierClass
    {

        public static string Carrier(string Mycarrier)
        {
            if (Mycarrier.StartsWith("com.apple.Mobiland_ad"))
            {
                return "Mobiland";
            }
            else if (Mycarrier.StartsWith("com.apple.du_ae"))
            {
                return "Unknown";
            }
            else if (Mycarrier.StartsWith("com.apple.du_Virgin_ae"))
            {

                return "Virgin";
            }
            else if (Mycarrier.StartsWith("com.apple.Etisalat_ae"))
            {

                return "Etisalat";
            }
            else if (Mycarrier.StartsWith("com.apple.AWCC_af"))
            {
                return "AWCC";
            }
            else if (Mycarrier.StartsWith("com.apple.Roshan_af"))
            {

                return "Roshan";
            }
            else if (Mycarrier.StartsWith("com.apple.APUA_ag"))
            {

                return "APUA";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_ag"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_ai"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_al"))
            {
                return "TMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_al"))
            {
                return "TMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_al"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.MTS_am"))
            {
                return "MTS";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_am"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.VimpelCom_am"))
            {
                return "Vimpel Com";
            }
            else if (Mycarrier.StartsWith("com.apple.VimpelCom_am"))
            {
                return "Vimpel Com";
            }
            else if (Mycarrier.StartsWith("com.apple.Movicel_ao"))
            {
                return "Movicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Unitel_ao"))
            {
                return "Unitel";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_ar"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.movistar_ar"))
            {
                return "movistar";
            }
            else if (Mycarrier.StartsWith("com.apple.Personal_ar"))
            {
                return "Personal";
            }
            else if (Mycarrier.StartsWith("com.apple.ASTCA_as"))
            {
                return "ASTCA";
            }
            else if (Mycarrier.StartsWith("com.apple.Bluesky_as"))
            {
                return "Bluesky";
            }
            else if (Mycarrier.StartsWith("com.apple.Hutchison_at"))
            {
                return "Hutchison";
            }
            else if (Mycarrier.StartsWith("com.apple.mobilkom_at"))
            {
                return "mobilkom";
            }
            else if (Mycarrier.StartsWith("com.apple.One_at"))
            {
                return "One";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_at") || Mycarrier.StartsWith("com.apple.TMobile_telering_at"))
            {
                return "TMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Optus_au") || Mycarrier.StartsWith("com.apple.Optus_Virgin_au"))
            {
                return "Optus";
            }
            else if (Mycarrier.StartsWith("com.apple.Telstra_au"))
            {
                return "Telstra";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_au") || Mycarrier.StartsWith("com.apple.Vodafone_Lebara_au"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_aw"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Setar_aw"))
            {
                return "Setar";
            }
            else if (Mycarrier.StartsWith("com.apple.Telia_az"))
            {
                return "Telia";
            }
            else if (Mycarrier.StartsWith("com.apple.TelekomSlovenije_ba"))
            {
                return "Telekom Slovenije";
            }
            else if (Mycarrier.StartsWith("com.apple.TelekomSrbija_ba"))
            {
                return "Telekom Srbija";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_bb"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Banglalink_bd"))
            {
                return "Banglalink";
            }
            else if (Mycarrier.StartsWith("com.apple.Grameenphone_bd"))
            {
                return "Grameenphone";
            }
            else if (Mycarrier.StartsWith("com.apple.Robi_bd") || Mycarrier.StartsWith("com.apple.Robi_BhartiAirtel_bd"))
            {
                return "Robi";
            }
            else if (Mycarrier.StartsWith("com.apple.BASE_be"))
            {
                return "BASE";
            }
            else if (Mycarrier.StartsWith("com.apple.Mobistar_be"))
            {
                return "Mobistar";
            }
            else if (Mycarrier.StartsWith("com.apple.Proximus_be"))
            {
                return "Proximus";
            }
            else if (Mycarrier.StartsWith("com.apple.Telenet_be"))
            {
                return "Telenet";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_bf"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.mobilkom_bg"))
            {
                return "mobilkom";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_bg"))
            {
                return "TMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Etisalat_bj"))
            {
                return "Etisalat";
            }
            else if (Mycarrier.StartsWith("com.apple.Globacom_bj"))
            {
                return "Globacom";
            }
            else if (Mycarrier.StartsWith("com.apple.MTN_bj"))
            {
                return "MTN";
            }
            else if (Mycarrier.StartsWith("com.apple.ATN_bm"))
            {
                return "ATN";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_bm"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.DSTCom_bn"))
            {
                return "DST Com";
            }
            else if (Mycarrier.StartsWith("com.apple.Tigo_bo"))
            {
                return "Tigo";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_br") || Mycarrier.StartsWith("com.apple.Nextel_br") ||
                     Mycarrier.StartsWith("com.apple.Oi_br") || Mycarrier.StartsWith("com.apple.Oi_BrT_br") ||
                     Mycarrier.StartsWith("com.apple.TIM_br") || Mycarrier.StartsWith("com.apple.TIM_PortoSeguro_br") ||
                     Mycarrier.StartsWith("com.apple.vivo_br"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.Aliv_bs"))
            {
                return "Aliv";
            }
            else if (Mycarrier.StartsWith("com.apple.CW_bs"))
            {
                return "CW";
            }
            else if (Mycarrier.StartsWith("com.apple.BhutanTelecom_bt"))
            {
                return "Bhutan Telecom";
            }
            else if (Mycarrier.StartsWith("com.apple.Mascom_bw"))
            {
                return "Mascom";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_bw"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.life_by") || Mycarrier.StartsWith("com.apple.mobilkom_by") ||
                     Mycarrier.StartsWith("com.apple.MTS_by"))
            {
                return "life";
            }
            else if (Mycarrier.StartsWith("com.apple.BTL_bz"))
            {
                return "BTL";
            }
            else if (Mycarrier.StartsWith("com.apple.Smart_bz"))
            {
                return "Smart";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_cd"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_cd"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Tigo_cd") || Mycarrier.StartsWith("com.apple.Vodafone_cd"))
            {
                return "Tigo";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_cf"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_cg"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.MTN_cg"))
            {
                return "MTN";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_ch") || Mycarrier.StartsWith("com.apple.Sunrise_ch") ||
                     Mycarrier.StartsWith("com.apple.Swisscom_ch") || Mycarrier.StartsWith("com.apple.Swisscom_Wingo_ch") ||
                     Mycarrier.StartsWith("com.apple.UPC_ch"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Etisalat_ci") || Mycarrier.StartsWith("com.apple.MTN_ci") ||
                     Mycarrier.StartsWith("com.apple.Orange_ci"))
            {
                return "Etisalat";
            }
            else if (Mycarrier.StartsWith("com.apple.TelecomCook_ck"))
            {
                return "Telecom Cook";
            }
            else if (Mycarrier.StartsWith("com.apple.MTN_cm") || Mycarrier.StartsWith("com.apple.Orange_cm"))
            {
                return "MTN";
            }
            else if (Mycarrier.StartsWith("com.apple.ChinaTelecom_cn") || Mycarrier.StartsWith("com.apple.ChinaTelecom_USIM_cn") ||
                     Mycarrier.StartsWith("com.apple.CMCC_cn") || Mycarrier.StartsWith("com.apple.Unicom_cn"))
            {
                return "ChinaTelecom";
            }
            else if (Mycarrier.StartsWith("com.apple.Avantel_co"))
            {
                return "Avantel";
            }
            else if (Mycarrier.StartsWith("com.apple.Comcel_co"))
            {
                return "Comcel";
            }
            else if (Mycarrier.StartsWith("com.apple.ETB_co"))
            {
                return "ETB";
            }
            else if (Mycarrier.StartsWith("com.apple.movistar_co"))
            {
                return "movistar";
            }
            else if (Mycarrier.StartsWith("com.apple.Tigo_co"))
            {
                return "Tigo";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_cr"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.ICE_cr"))
            {
                return "ICE";
            }
            else if (Mycarrier.StartsWith("com.apple.movistar_cr"))
            {
                return "movistar";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_cw"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Cyta_cy"))
            {
                return "Cyta";
            }
            else if (Mycarrier.StartsWith("com.apple.MTN_cy"))
            {
                return "MTN";
            }
            else if (Mycarrier.StartsWith("com.apple.PrimeTel_cy"))
            {
                return "PrimeTel";
            }
            else if (Mycarrier.StartsWith("com.apple.O2_cz"))
            {
                return "O2";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_cz"))
            {
                return "TMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_cz"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.EPlus_de") || Mycarrier.StartsWith("com.apple.O2_1and1_de") ||
                     Mycarrier.StartsWith("com.apple.O2_Debitel_de") || Mycarrier.StartsWith("com.apple.Vodafone_1and1_de") ||
                     Mycarrier.StartsWith("com.apple.Vodafone_de"))
            {
                return "EPlus";
            }
            else if (Mycarrier.StartsWith("com.apple.Hutchison_dk"))
            {
                return "Hutchison";
            }
            else if (Mycarrier.StartsWith("com.apple.TDC_dk"))
            {
                return "TDC";
            }
            else if (Mycarrier.StartsWith("com.apple.Telenor_dk"))
            {
                return "Telenor";
            }
            else if (Mycarrier.StartsWith("com.apple.Telia_dk"))
            {
                return "Telia";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_dm"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_do"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_do"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Djezzy_dz"))
            {
                return "Djezzy";
            }
            else if (Mycarrier.StartsWith("com.apple.Mobilis_dz"))
            {
                return "Mobilis";
            }
            else if (Mycarrier.StartsWith("com.apple.Qtel_dz"))
            {
                return "Qtel";
            }
            else if (Mycarrier.StartsWith("com.apple.CNT_ec"))
            {
                return "CNT";
            }
            else if (Mycarrier.StartsWith("com.apple.movistar_ec"))
            {
                return "movistar";
            }
            else if (Mycarrier.StartsWith("com.apple.Porta_ec"))
            {
                return "Porta";
            }
            else if (Mycarrier.StartsWith("com.apple.Elisa_ee"))
            {
                return "Elisa";
            }
            else if (Mycarrier.StartsWith("com.apple.EMT_ee"))
            {
                return "EMT";
            }
            else if (Mycarrier.StartsWith("com.apple.Tele2_ee"))
            {
                return "Tele2";
            }
            else if (Mycarrier.StartsWith("com.apple.Etisalat_eg"))
            {
                return "Etisalat";
            }
            else if (Mycarrier.StartsWith("com.apple.mobinil_eg"))
            {
                return "mobinil";
            }
            else if (Mycarrier.StartsWith("com.apple.TelecomEgypt_eg"))
            {
                return "TelecomEgypt";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_eg"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.DNA_DNAPro_fi"))
            {
                return "DNA";
            }
            else if (Mycarrier.StartsWith("com.apple.DNA_fi") || Mycarrier.StartsWith("com.apple.Saunalahti_fi") ||
    Mycarrier.StartsWith("com.apple.Sonera_fi"))
            {
                return "DNA";
            }
            else if (Mycarrier.StartsWith("com.apple.elisa_fi"))
            {
                return "elisa";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_fj"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_fj"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.FSMTC_fm"))
            {
                return "FSMTC";
            }
            else if (Mycarrier.StartsWith("com.apple.FaroeseTelecom_fo"))
            {
                return "FaroeseTelecom";
            }
            else if (Mycarrier.StartsWith("com.apple.Bouygues_fr") || Mycarrier.StartsWith("com.apple.Coriolis_fr") ||
                     Mycarrier.StartsWith("com.apple.Free_fr") || Mycarrier.StartsWith("com.apple.NRJ_fr") ||
                     Mycarrier.StartsWith("com.apple.Orange_Virgin_fr") || Mycarrier.StartsWith("com.apple.SFR_fr") ||
                     Mycarrier.StartsWith("com.apple.SFR_LPM_fr") || Mycarrier.StartsWith("com.apple.Virgin_fr") ||
                     Mycarrier.StartsWith("com.apple.Orange_France"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_ga"))
            {
                return "BhartiAirtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Moov_ga"))
            {
                return "Moov";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_gd"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Telia_ge"))
            {
                return "Telia";
            }
            else if (Mycarrier.StartsWith("com.apple.VimpelCom_ge"))
            {
                return "VimpelCom";
            }
            else if (Mycarrier.StartsWith("com.apple.O2_Germany"))
            {
                return "O2";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_gh"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Globacom_gh"))
            {
                return "Globacom";
            }
            else if (Mycarrier.StartsWith("com.apple.MTN_gh"))
            {
                return "MTN";
            }
            else if (Mycarrier.StartsWith("com.apple.Tigo_gh"))
            {
                return "Tigo";
            }
            else if (Mycarrier.StartsWith("com.apple.TelekomSlovenije_gi"))
            {
                return "Telekom Slovenije";
            }
            else if (Mycarrier.StartsWith("com.apple.TELE_gl"))
            {
                return "TELE";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_gn"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_gt"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.movistar_gt"))
            {
                return "movistar";
            }
            else if (Mycarrier.StartsWith("com.apple.Tigo_gt"))
            {
                return "Tigo";
            }
            else if (Mycarrier.StartsWith("com.apple.Choice_gu") || Mycarrier.StartsWith("com.apple.Docomo_gu") ||
                     Mycarrier.StartsWith("com.apple.GTA_gu") || Mycarrier.StartsWith("com.apple.ITE_gu"))
            {
                return "Choice";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_gw"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.ATN_gy"))
            {
                return "ATN";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_gy"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.ChinaTelecom_hk"))
            {
                return "China Telecom";
            }
            else if (Mycarrier.StartsWith("com.apple.CMCC_hk"))
            {
                return "CMCC";
            }
            else if (Mycarrier.StartsWith("com.apple.CSL_hk"))
            {
                return "CSL";
            }
            else if (Mycarrier.StartsWith("com.apple.Hutchison_hk"))
            {
                return "Hutchison";
            }
            else if (Mycarrier.StartsWith("com.apple.PCCW_hk"))
            {
                return "PCCW";
            }
            else if (Mycarrier.StartsWith("com.apple.SmarTone_hk"))
            {
                return "SmarTone";
            }
            else if (Mycarrier.StartsWith("com.apple.Unicom_hk"))
            {
                return "Unicom";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_hn"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.Tigo_hn"))
            {
                return "Tigo";
            }
            else if (Mycarrier.StartsWith("com.apple.mobilkom_hr"))
            {
                return "mobilkom";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_hr"))
            {
                return "TMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_ht"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Natcom_ht"))
            {
                return "Natcom";
            }
            else if (Mycarrier.StartsWith("com.apple.Telenor_hu") || Mycarrier.StartsWith("com.apple.TMobile_hu") ||
                     Mycarrier.StartsWith("com.apple.Vodafone_hu"))
            {
                return "Telenor";
            }
            else if (Mycarrier.StartsWith("com.apple.Hutchison_iD_ie") || Mycarrier.StartsWith("com.apple.Hutchison_ie") ||
                     Mycarrier.StartsWith("com.apple.Meteor_ie") || Mycarrier.StartsWith("com.apple.O2_ie") ||
                     Mycarrier.StartsWith("com.apple.Vodafone_ie"))
            {
                return "Hutchison";
            }
            else if (Mycarrier.StartsWith("com.apple.Cellcom_il"))
            {
                return "Cellcom";
            }
            else if (Mycarrier.StartsWith("com.apple.Mirs_il"))
            {
                return "Mirs";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_il"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Pelephone_il"))
            {
                return "Pelephone";
            }
            else if (Mycarrier.StartsWith("com.apple.ManxTelecom_im"))
            {
                return "Manx Telecom";
            }
            else if (Mycarrier.StartsWith("com.apple.Sure_im"))
            {
                return "Sure";
            }
            else if (Mycarrier.StartsWith("com.apple.Aircel_in"))
            {
                return "Aircel";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_in"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Idea_in"))
            {
                return "Idea";
            }
            else if (Mycarrier.StartsWith("com.apple.RelianceJio_in"))
            {
                return "Reliance Jio";
            }
            else if (Mycarrier.StartsWith("com.apple.Reliance_RCOM_in") || Mycarrier.StartsWith("com.apple.Reliance_RTL_in"))
            {
                return "Reliance";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_in"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.Nova_is"))
            {
                return "Nova";
            }
            else if (Mycarrier.StartsWith("com.apple.Siminn_is"))
            {
                return "Siminn";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_is"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.Hutchison_it") || Mycarrier.StartsWith("com.apple.Hutchison_Wind_it") ||
                     Mycarrier.StartsWith("com.apple.Iliad_it") || Mycarrier.StartsWith("com.apple.Vodafone_it") ||
                     Mycarrier.StartsWith("com.apple.TIM_Italy"))
            {
                return "Hutchison";
            }
            else if (Mycarrier.StartsWith("com.apple.JerseyTelecom_je"))
            {
                return "Jersey Telecom";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_jm"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_jm"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_jo"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Umniah_jo"))
            {
                return "Umniah";
            }
            else if (Mycarrier.StartsWith("com.apple.Zain_jo"))
            {
                return "Zain";
            }
            else if (Mycarrier.StartsWith("com.apple.Docomo_jp") || Mycarrier.StartsWith("com.apple.KDDI_BIGLOBE_LTE_only_jp") ||
                     Mycarrier.StartsWith("com.apple.KDDI_JCOM_LTE_only_jp") || Mycarrier.StartsWith("com.apple.KDDI_LTE_jp") ||
                     Mycarrier.StartsWith("com.apple.KDDI_LTE_only_jp") || Mycarrier.StartsWith("com.apple.KDDI_UQ_LTE_only_jp") ||
                     Mycarrier.StartsWith("com.apple.Softbank_jp") || Mycarrier.StartsWith("com.apple.Softbank_YMobile_jp"))
            {
                return "Docomo";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_ke"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_ke"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Safaricom_ke"))
            {
                return "Safaricom";
            }
            else if (Mycarrier.StartsWith("com.apple.VimpelCom_kg"))
            {
                return "Vimpel Com";
            }
            else if (Mycarrier.StartsWith("com.apple.Seatel_kh"))
            {
                return "Seatel";
            }
            else if (Mycarrier.StartsWith("com.apple.Smart_kh"))
            {
                return "Smart";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_kn"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.KTF_kr"))
            {
                return "KTF";
            }
            else if (Mycarrier.StartsWith("com.apple.LGU_kr"))
            {
                return "LGU";
            }
            else if (Mycarrier.StartsWith("com.apple.SKT_kr"))
            {
                return "SKT";
            }
            else if (Mycarrier.StartsWith("com.apple.Qtel_kw"))
            {
                return "Qtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Viva_kw"))
            {
                return "Viva";
            }
            else if (Mycarrier.StartsWith("com.apple.Zain_kw"))
            {
                return "Zain";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_ky"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Telia_kz"))
            {
                return "Telia";
            }
            else if (Mycarrier.StartsWith("com.apple.Laotel_la"))
            {
                return "Laotel";
            }
            else if (Mycarrier.StartsWith("com.apple.Unitel_la"))
            {
                return "Unitel";
            }
            else if (Mycarrier.StartsWith("com.apple.Alfa_lb") || Mycarrier.StartsWith("com.apple.Zain_lb"))
            {
                return "Alfa";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_lc"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_li"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Dialog_lk") || Mycarrier.StartsWith("com.apple.Mobitel_lk"))
            {
                return "Dialog";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_lr"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_ls"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.Bite_lt") || Mycarrier.StartsWith("com.apple.Omnitel_lt") ||
                     Mycarrier.StartsWith("com.apple.Tele2_lt"))
            {
                return "Bite";
            }
            else if (Mycarrier.StartsWith("com.apple.Bite_lv") || Mycarrier.StartsWith("com.apple.LMT_lv") ||
                     Mycarrier.StartsWith("com.apple.Tele2_lv"))
            {
                return "Bite";
            }
            else if (Mycarrier.StartsWith("com.apple.Almadar_ly"))
            {
                return "Almadar";
            }
            else if (Mycarrier.StartsWith("com.apple.INWI_ma") || Mycarrier.StartsWith("com.apple.Maroc_ma") ||
                     Mycarrier.StartsWith("com.apple.Meditel_ma"))
            {
                return "INWI";
            }
            else if (Mycarrier.StartsWith("com.apple.MonacoTelecom_mc") || Mycarrier.StartsWith("com.apple.MonacoTel_mc"))
            {
                return "MonacoTelecom";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_md") || Mycarrier.StartsWith("com.apple.Telia_md"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.TelekomSrbija_me") || Mycarrier.StartsWith("com.apple.Telenor_me") ||
                     Mycarrier.StartsWith("com.apple.TMobile_me"))
            {
                return "Telekom Srbija";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_mg") || Mycarrier.StartsWith("com.apple.Orange_mg"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.mobilkom_mk") || Mycarrier.StartsWith("com.apple.TelekomSlovenije_mk") ||
                     Mycarrier.StartsWith("com.apple.TMobile_mk"))
            {
                return "mobilkom";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_ml"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Qtel_mm") || Mycarrier.StartsWith("com.apple.Telenor_mm"))
            {
                return "Qtel";
            }
            else if (Mycarrier.StartsWith("com.apple.MobiCom_mn") || Mycarrier.StartsWith("com.apple.Unitel_mn"))
            {
                return "Mobi Com";
            }
            else if (Mycarrier.StartsWith("com.apple.ChinaTelecom_mo") || Mycarrier.StartsWith("com.apple.ChinaTelecom_USIM_mo") ||
                     Mycarrier.StartsWith("com.apple.CTM_mo") || Mycarrier.StartsWith("com.apple.Hutchison_mo") ||
                     Mycarrier.StartsWith("com.apple.SmarTone_mo"))
            {
                return "China Telecom";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_mq"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_mq"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_ms"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_mt"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_mu") || Mycarrier.StartsWith("com.apple.Tigo_mu"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Dhiraagu_mv") || Mycarrier.StartsWith("com.apple.Qtel_mv"))
            {
                return "Dhiraagu";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_mw"))
            {
                return "BhartiAirtel";
            }
            else if (Mycarrier.StartsWith("com.apple.iusacell_mx") || Mycarrier.StartsWith("com.apple.iusacell_Unefon_mx") ||
                     Mycarrier.StartsWith("com.apple.movistar_mx") || Mycarrier.StartsWith("com.apple.Nextel_mx") ||
                     Mycarrier.StartsWith("com.apple.Telcel_AztecaMovil_mx") || Mycarrier.StartsWith("com.apple.Telcel_mx"))
            {
                return "iusacell";
            }
            else if (Mycarrier.StartsWith("com.apple.Celcom_my") || Mycarrier.StartsWith("com.apple.Celcom_Yoodo_my") ||
                     Mycarrier.StartsWith("com.apple.DiGi_my") || Mycarrier.StartsWith("com.apple.Maxis_my") ||
                     Mycarrier.StartsWith("com.apple.UMobile_my"))
            {
                return "Celcom";
            }
            else if (Mycarrier.StartsWith("com.apple.mcel_mz") || Mycarrier.StartsWith("com.apple.Vodafone_mz"))
            {
                return "mcel";
            }
            else if (Mycarrier.StartsWith("com.apple.MTC_na") || Mycarrier.StartsWith("com.apple.TelecomNamibia_na"))
            {
                return "MTC";
            }
            else if (Mycarrier.StartsWith("com.apple.OPT_nc"))
            {
                return "OPT";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_ne") || Mycarrier.StartsWith("com.apple.Orange_ne"))
            {
                return "BhartiAirtel";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_ng") || Mycarrier.StartsWith("com.apple.Etisalat_ng") ||
                     Mycarrier.StartsWith("com.apple.Globacom_ng") || Mycarrier.StartsWith("com.apple.MTN_ng"))
            {
                return "BhartiAirtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_ni") || Mycarrier.StartsWith("com.apple.movistar_ni"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.KPN_nl") || Mycarrier.StartsWith("com.apple.KPN_Telfort_nl") ||
                     Mycarrier.StartsWith("com.apple.Orange_nl") || Mycarrier.StartsWith("com.apple.Tele2_nl") ||
                     Mycarrier.StartsWith("com.apple.TMobile_nl") || Mycarrier.StartsWith("com.apple.Vodafone_nl"))
            {
                return "KPN";
            }
            else if (Mycarrier.StartsWith("com.apple.Ice_no") || Mycarrier.StartsWith("com.apple.NetCom_no") ||
                     Mycarrier.StartsWith("com.apple.NetworkNorway_no") || Mycarrier.StartsWith("com.apple.TDC_no"))
            {
                return "Ice";
            }
            else if (Mycarrier.StartsWith("com.apple.Tele2_no") || Mycarrier.StartsWith("com.apple.Telenor_no"))
            {
                return "Tele2";
            }
            else if (Mycarrier.StartsWith("com.apple.Ncell_np"))
            {
                return "Ncell";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_nr"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Telecom_nz") || Mycarrier.StartsWith("com.apple.Telecom_Skinny_nz") ||
                     Mycarrier.StartsWith("com.apple.Vodafone_nz"))
            {
                return "Telecom";
            }
            else if (Mycarrier.StartsWith("com.apple.Omantel_om") || Mycarrier.StartsWith("com.apple.Qtel_om"))
            {
                return "Omantel";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_pa") || Mycarrier.StartsWith("com.apple.CW_pa") ||
                     Mycarrier.StartsWith("com.apple.Digicel_pa") || Mycarrier.StartsWith("com.apple.movistar_pa"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_pe") || Mycarrier.StartsWith("com.apple.Entel_pe") ||
                     Mycarrier.StartsWith("com.apple.movistar_pe"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.Ora_pf") || Mycarrier.StartsWith("com.apple.Vini_pf"))
            {
                return "Ora";
            }
            else if (Mycarrier.StartsWith("com.apple.bMobile_pg") || Mycarrier.StartsWith("com.apple.Digicel_pg"))
            {
                return "bMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Globe_ph") || Mycarrier.StartsWith("com.apple.Smart_ph"))
            {
                return "Globe";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_pl") || Mycarrier.StartsWith("com.apple.Play_pl") ||
                     Mycarrier.StartsWith("com.apple.TMobile_pl"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_pr") || Mycarrier.StartsWith("com.apple.OpenMobile_LTE_pr"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.Jawwal_ps") || Mycarrier.StartsWith("com.apple.Qtel_ps"))
            {
                return "Jawwal";
            }
            else if (Mycarrier.StartsWith("com.apple.Optimus_pt") || Mycarrier.StartsWith("com.apple.TMN_pt") ||
                     Mycarrier.StartsWith("com.apple.Vodafone_pt"))
            {
                return "Optimus";
            }
            else if (Mycarrier.StartsWith("com.apple.PNCC_pw"))
            {
                return "PNCC";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_py") || Mycarrier.StartsWith("com.apple.Tigo_py"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.Qtel_qa") || Mycarrier.StartsWith("com.apple.Vodafone_qa"))
            {
                return "Qtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Free_re") || Mycarrier.StartsWith("com.apple.Orange_re") ||
                     Mycarrier.StartsWith("com.apple.SFR_re"))
            {
                return "Free";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_ro") || Mycarrier.StartsWith("com.apple.TMobile_ro") ||
                     Mycarrier.StartsWith("com.apple.Vodafone_ro"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.mobilkom_rs") || Mycarrier.StartsWith("com.apple.TelekomSrbija_rs") ||
                     Mycarrier.StartsWith("com.apple.Telenor_rs"))
            {
                return "mobilkom";
            }
            else if (Mycarrier.StartsWith("com.apple.MegaFon_ru") || Mycarrier.StartsWith("com.apple.MegaFon_Yota_ru") ||
                     Mycarrier.StartsWith("com.apple.MTS_ru") || Mycarrier.StartsWith("com.apple.Tele2_ru") ||
                     Mycarrier.StartsWith("com.apple.Tele2_Sberbank_ru") || Mycarrier.StartsWith("com.apple.VimpelCom_ru"))
            {
                return "Mega Fon";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_rw") || Mycarrier.StartsWith("com.apple.MTN_rw") ||
                     Mycarrier.StartsWith("com.apple.Tigo_rw"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.bMobile_sb"))
            {
                return "bMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_sc") || Mycarrier.StartsWith("com.apple.CW_sc"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Comviq_se") || Mycarrier.StartsWith("com.apple.Hutchison_se") ||
                     Mycarrier.StartsWith("com.apple.TDC_se") || Mycarrier.StartsWith("com.apple.Tele2_se") ||
                     Mycarrier.StartsWith("com.apple.Telenor_se") || Mycarrier.StartsWith("com.apple.Telenor_Vimla_se") ||
                     Mycarrier.StartsWith("com.apple.Telia_se"))
            {
                return "Comviq";
            }
            else if (Mycarrier.StartsWith("com.apple.MobileOne_sg") || Mycarrier.StartsWith("com.apple.SingTel_sg") ||
                     Mycarrier.StartsWith("com.apple.StarHub_giga_sg") || Mycarrier.StartsWith("com.apple.StarHub_sg"))
            {
                return "Mobile One";
            }
            else if (Mycarrier.StartsWith("com.apple.mobilkom_si") || Mycarrier.StartsWith("com.apple.Telekom_si"))
            {
                return "mobilkom";
            }
            else if (Mycarrier.StartsWith("com.apple.O2_sk") || Mycarrier.StartsWith("com.apple.Orange_sk") ||
                     Mycarrier.StartsWith("com.apple.TMobile_sk"))
            {
                return "O2";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_sl"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_sn") || Mycarrier.StartsWith("com.apple.Tigo_sn"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_sr") || Mycarrier.StartsWith("com.apple.Telesur_sr"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_sv") || Mycarrier.StartsWith("com.apple.Digicel_sv") ||
                     Mycarrier.StartsWith("com.apple.movistar_sv") || Mycarrier.StartsWith("com.apple.Tigo_sv"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.ATN_tc") || Mycarrier.StartsWith("com.apple.Digicel_tc"))
            {
                return "ATN";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_td") || Mycarrier.StartsWith("com.apple.Tigo_td"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.AIS_th") || Mycarrier.StartsWith("com.apple.dtac_th") ||
                     Mycarrier.StartsWith("com.apple.TrueH_th") || Mycarrier.StartsWith("com.apple.True_th"))
            {
                return "AIS";
            }
            else if (Mycarrier.StartsWith("com.apple.Telia_tj") || Mycarrier.StartsWith("com.apple.VimpelCom_tj"))
            {
                return "Telia";
            }
            else if (Mycarrier.StartsWith("com.apple.TimorTelecom_tl"))
            {
                return "Timor Telecom";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_tn") || Mycarrier.StartsWith("com.apple.Qtel_tn") ||
                     Mycarrier.StartsWith("com.apple.Tuntel_tn"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_to") || Mycarrier.StartsWith("com.apple.TCC_to"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.AVEA_tr") || Mycarrier.StartsWith("com.apple.Turkcell_KKTCELL_tr") ||
                     Mycarrier.StartsWith("com.apple.Turkcell_tr") || Mycarrier.StartsWith("com.apple.Vodafone_tr"))
            {
                return "AVEA";
            }
            else if (Mycarrier.StartsWith("com.apple.CW_tt") || Mycarrier.StartsWith("com.apple.Digicel_tt"))
            {
                return "CW";
            }
            else if (Mycarrier.StartsWith("com.apple.APT_tw") || Mycarrier.StartsWith("com.apple.Chunghwa_tw") ||
                     Mycarrier.StartsWith("com.apple.FarEasTone_tw") || Mycarrier.StartsWith("com.apple.TaiwanMobile_tw") ||
                     Mycarrier.StartsWith("com.apple.Vibo_tw"))
            {
                return "APT";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_tz") || Mycarrier.StartsWith("com.apple.Etisalat_tz") ||
                     Mycarrier.StartsWith("com.apple.Tigo_tz") || Mycarrier.StartsWith("com.apple.Vodafone_tz"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Kyivstar_ua") || Mycarrier.StartsWith("com.apple.MTS_ua") ||
                     Mycarrier.StartsWith("com.apple.Turkcell_lifecell_ua"))
            {
                return "Kyivstar";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_ug") || Mycarrier.StartsWith("com.apple.MTN_ug") ||
                     Mycarrier.StartsWith("com.apple.Orange_ug"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.BT_Business_uk") || Mycarrier.StartsWith("com.apple.BT_Consumer_uk") ||
                     Mycarrier.StartsWith("com.apple.BT_OnePhone_uk") || Mycarrier.StartsWith("com.apple.EE_Virgin_uk") ||
                     Mycarrier.StartsWith("com.apple.Hutchison_iD_uk") || Mycarrier.StartsWith("com.apple.Hutchison_uk") ||
                     Mycarrier.StartsWith("com.apple.O2_Giffgaff_UK") || Mycarrier.StartsWith("com.apple.O2_Prepaid_UK") ||
                     Mycarrier.StartsWith("com.apple.O2_Sky_uk") || Mycarrier.StartsWith("com.apple.O2_Tesco_UK") ||
                     Mycarrier.StartsWith("com.apple.O2_UK") || Mycarrier.StartsWith("com.apple.Orange_uk") ||
                     Mycarrier.StartsWith("com.apple.Talkmobile_uk") || Mycarrier.StartsWith("com.apple.TMobile_uk") ||
                     Mycarrier.StartsWith("com.apple.Vodafone_uk"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Antel_uy") || Mycarrier.StartsWith("com.apple.Claro_uy") ||
    Mycarrier.StartsWith("com.apple.movistar_uy"))
            {
                return "Antel";
            }
            else if (Mycarrier.StartsWith("com.apple.VimpelCom_uz"))
            {
                return "Vimpel Com";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_vc"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Digitel_ve") || Mycarrier.StartsWith("com.apple.movistar_ve"))
            {
                return "Digitel";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_vg") || Mycarrier.StartsWith("com.apple.ATN_vi") ||
                     Mycarrier.StartsWith("com.apple.ATN_Viya_vi"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.Mobifone_vn") || Mycarrier.StartsWith("com.apple.Viettel_vn") ||
                     Mycarrier.StartsWith("com.apple.VinaPhone_vn"))
            {
                return "Mobifone";
            }
            else if (Mycarrier.StartsWith("com.apple.Digicel_vu") || Mycarrier.StartsWith("com.apple.Orange_vu"))
            {
                return "Digicel";
            }
            else if (Mycarrier.StartsWith("com.apple.SPT_wf"))
            {
                return "SPT";
            }
            else if (Mycarrier.StartsWith("com.apple.CW_wi"))
            {
                return "CW";
            }
            else if (Mycarrier.StartsWith("com.apple.Bluesky_ws") || Mycarrier.StartsWith("com.apple.Digicel_ws"))
            {
                return "Bluesky";
            }
            else if (Mycarrier.StartsWith("com.apple.TelekomSlovenije_xk"))
            {
                return "Telekom Slovenije";
            }
            else if (Mycarrier.StartsWith("com.apple.CellC_za") || Mycarrier.StartsWith("com.apple.MTN_za") ||
                     Mycarrier.StartsWith("com.apple.Vodafone_za"))
            {
                return "CellC";
            }
            else if (Mycarrier.StartsWith("com.apple.BhartiAirtel_zm") || Mycarrier.StartsWith("com.apple.MTN_zm"))
            {
                return "Bharti Airtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Econet_zw"))
            {
                return "Econet";
            }
            else if (Mycarrier.StartsWith("com.apple.Batelco_bh") || Mycarrier.StartsWith("com.apple.Viva_bh") ||
                     Mycarrier.StartsWith("com.apple.Zain_bh"))
            {
                return "Batelco";
            }
            else if (Mycarrier.StartsWith("com.apple.Bell_ca") || Mycarrier.StartsWith("com.apple.Bell_Lucky_ca") ||
                     Mycarrier.StartsWith("com.apple.Eastlink_ca") || Mycarrier.StartsWith("com.apple.Fido_ca") ||
                     Mycarrier.StartsWith("com.apple.FreedomMobile_ca") || Mycarrier.StartsWith("com.apple.MTS_ca") ||
                     Mycarrier.StartsWith("com.apple.Rogers_ca") || Mycarrier.StartsWith("com.apple.Rogers_chatr_ca") ||
                     Mycarrier.StartsWith("com.apple.Rogers_Cityfone_ca") || Mycarrier.StartsWith("com.apple.Sasktel_ca") ||
                     Mycarrier.StartsWith("com.apple.Tbaytel_ca") || Mycarrier.StartsWith("com.apple.Telus_ca") ||
                     Mycarrier.StartsWith("com.apple.Telus_Koodo_ca") || Mycarrier.StartsWith("com.apple.Telus_PCMobile_ca") ||
                     Mycarrier.StartsWith("com.apple.Telus_PublicMobile_ca") || Mycarrier.StartsWith("com.apple.Videotron_ca") ||
                     Mycarrier.StartsWith("com.apple.Videotron_Fizz_ca") || Mycarrier.StartsWith("com.apple.Xplornet_ca"))
            {
                return "Bell";
            }
            else if (Mycarrier.StartsWith("com.apple.Claro_cl"))
            {
                return "Claro";
            }
            else if (Mycarrier.StartsWith("com.apple.EntelPCS_cl"))
            {
                return "EntelPCS";
            }
            else if (Mycarrier.StartsWith("com.apple.movistar_cl") || Mycarrier.StartsWith("com.apple.Nextel_cl") ||
    Mycarrier.StartsWith("com.apple.vtr_cl"))
            {
                return "movistar";
            }
            else if (Mycarrier.StartsWith("com.apple.RedteaMobile"))
            {
                return "Redtea Mobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Transatel"))
            {
                return "Transatel";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_Germany"))
            {
                return "TMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_gr"))
            {
                return "TMobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Vodafone_gr"))
            {
                return "Vodafone";
            }
            else if (Mycarrier.StartsWith("com.apple.Wind_gr"))
            {
                return "Wind";
            }
            else if (Mycarrier.StartsWith("com.apple.Indosat_id"))
            {
                return "Indosat";
            }
            else if (Mycarrier.StartsWith("com.apple.Smartfren_id"))
            {
                return "Smartfren";
            }
            else if (Mycarrier.StartsWith("com.apple.Telkomsel_id"))
            {
                return "Telkomsel";
            }
            else if (Mycarrier.StartsWith("com.apple.XL_id"))
            {
                return "XL";
            }
            else if (Mycarrier.StartsWith("com.apple.Korek_iq"))
            {
                return "Korek";
            }
            else if (Mycarrier.StartsWith("com.apple.Qtel_iq"))
            {
                return "Qtel";
            }
            else if (Mycarrier.StartsWith("com.apple.Zain_iq"))
            {
                return "Zain";
            }
            else if (Mycarrier.StartsWith("com.apple.Soracom"))
            {
                return "Soracom";
            }
            else if (Mycarrier.StartsWith("com.apple.LuxGSM_lu"))
            {
                return "Lux GSM";
            }
            else if (Mycarrier.StartsWith("com.apple.MTX_lu"))
            {
                return "MTX";
            }
            else if (Mycarrier.StartsWith("com.apple.Tango_lu"))
            {
                return "Tango";
            }
            else if (Mycarrier.StartsWith("com.apple.VOX_lu"))
            {
                return "VOX";
            }
            else if (Mycarrier.StartsWith("com.apple.Mobilink_pk"))
            {
                return "Mobilink";
            }
            else if (Mycarrier.StartsWith("com.apple.Telenor_pk"))
            {
                return "Telenor";
            }
            else if (Mycarrier.StartsWith("com.apple.Ufone_pk"))
            {
                return "Ufone";
            }
            else if (Mycarrier.StartsWith("com.apple.Warid_pk"))
            {
                return "Warid";
            }
            else if (Mycarrier.StartsWith("com.apple.Zong_pk"))
            {
                return "Zong";
            }
            else if (Mycarrier.StartsWith("com.apple.mobily_sa"))
            {
                return "mobily";
            }
            else if (Mycarrier.StartsWith("com.apple.STC_sa"))
            {
                return "STC";
            }
            else if (Mycarrier.StartsWith("com.apple.Zain_sa"))
            {
                return "Zain";
            }
            else if (Mycarrier.StartsWith("com.apple.Orange_es") || Mycarrier.StartsWith("com.apple.Orange_Jazztel_es") ||
                     Mycarrier.StartsWith("com.apple.Telefonica_es") || Mycarrier.StartsWith("com.apple.Vodafone_es") ||
                     Mycarrier.StartsWith("com.apple.Yoigo_es") || Mycarrier.StartsWith("com.apple.Yoigo_Masmovil_es") ||
                     Mycarrier.StartsWith("com.apple.Yoigo_Pepephone_es"))
            {
                return "Orange";
            }
            else if (Mycarrier.StartsWith("com.apple.Afrimax_ug"))
            {
                return "Afrimax";
            }
            else if (Mycarrier.StartsWith("com.apple.ACS_US"))
            {
                return "ACS";
            }
            else if (Mycarrier.StartsWith("com.apple.AlaskaWireless_US"))
            {
                return "Alaska Wireless";
            }
            else if (Mycarrier.StartsWith("com.apple.Alltel_US"))
            {
                return "Alltel";
            }
            else if (Mycarrier.StartsWith("com.apple.Altice_LTE_US"))
            {
                return "Altice";
            }
            else if (Mycarrier.StartsWith("com.apple.Appalachian_LTE_US"))
            {
                return "Appalachian";
            }
            else if (Mycarrier.StartsWith("com.apple.AppWire_LTE_US"))
            {
                return "AppWire";
            }
            else if (Mycarrier.StartsWith("com.apple.ATT_aio_US") || Mycarrier.StartsWith("com.apple.ATT_CC_US") ||
                     Mycarrier.StartsWith("com.apple.ATT_Defense_US") || Mycarrier.StartsWith("com.apple.ATT_Puretalk_US") ||
                     Mycarrier.StartsWith("com.apple.ATT_RedPocket_US") || Mycarrier.StartsWith("com.apple.ATT_TFW_US") ||
                     Mycarrier.StartsWith("com.apple.ATT_US"))
            {
                return "AT&T";
            }
            else if (Mycarrier.StartsWith("com.apple.Bluegrass_LTE_US"))
            {
                return "Bluegrass";
            }
            else if (Mycarrier.StartsWith("com.apple.BlueWireless_LTE_US"))
            {
                return "Blue Wireless";
            }
            else if (Mycarrier.StartsWith("com.apple.CarolinaWest_LTE_US"))
            {
                return "Carolina West";
            }
            else if (Mycarrier.StartsWith("com.apple.Cellcom_LTE_US"))
            {
                return "Cellcom";
            }
            else if (Mycarrier.StartsWith("com.apple.CellularSouth_LTE_US"))
            {
                return "Cellular South";
            }
            else if (Mycarrier.StartsWith("com.apple.Chariton_LTE_US"))
            {
                return "Chariton";
            }
            else if (Mycarrier.StartsWith("com.apple.Chat_LTE_US"))
            {
                return "Chat";
            }
            else if (Mycarrier.StartsWith("com.apple.CopperValley_LTE_US"))
            {
                return "Copper Valley";
            }
            else if (Mycarrier.StartsWith("com.apple.Cricket_US"))
            {
                return "Cricket";
            }
            else if (Mycarrier.StartsWith("com.apple.CrossWireless_LTE_US"))
            {
                return "Cross Wireless";
            }
            else if (Mycarrier.StartsWith("com.apple.CWW_US"))
            {
                return "CWW";
            }
            else if (Mycarrier.StartsWith("com.apple.Defense_US"))
            {
                return "Defense";
            }
            else if (Mycarrier.StartsWith("com.apple.FamilyMobile_US"))
            {
                return "Family Mobile";
            }
            else if (Mycarrier.StartsWith("com.apple.GCI_US"))
            {
                return "GCI";
            }
            else if (Mycarrier.StartsWith("com.apple.GigSky_US"))
            {
                return "GigSky";
            }
            else if (Mycarrier.StartsWith("com.apple.GoldenState_US"))
            {
                return "Golden State";
            }
            else if (Mycarrier.StartsWith("com.apple.IllinoisValley_LTE_US") || Mycarrier.StartsWith("com.apple.IllinoisValley_US"))
            {
                return "Illinois Valley";
            }
            else if (Mycarrier.StartsWith("com.apple.Inland_LTE_US") || Mycarrier.StartsWith("com.apple.Inland_US"))
            {
                return "Inland";
            }
            else if (Mycarrier.StartsWith("com.apple.iWireless_US"))
            {
                return "iWireless";
            }
            else if (Mycarrier.StartsWith("com.apple.MobileNation_LTE_US") || Mycarrier.StartsWith("com.apple.MobileNation_US"))
            {
                return "Mobile Nation";
            }
            else if (Mycarrier.StartsWith("com.apple.MTA_US"))
            {
                return "MTA";
            }
            else if (Mycarrier.StartsWith("com.apple.Nemont_LTE_US") || Mycarrier.StartsWith("com.apple.Nemont_US"))
            {
                return "Nemont";
            }
            else if (Mycarrier.StartsWith("com.apple.NexTech_LTE_US") || Mycarrier.StartsWith("com.apple.NexTech_US"))
            {
                return "NexTech";
            }
            else if (Mycarrier.StartsWith("com.apple.nTelos_LTE_US") || Mycarrier.StartsWith("com.apple.nTelos_US"))
            {
                return "nTelos";
            }
            else if (Mycarrier.StartsWith("com.apple.NWM_LTE_US"))
            {
                return "NWM";
            }
            else if (Mycarrier.StartsWith("com.apple.Panhandle_US"))
            {
                return "Panhandle";
            }
            else if (Mycarrier.StartsWith("com.apple.PioneerCellular_LTE_US"))
            {
                return "Pioneer Cellular";
            }
            else if (Mycarrier.StartsWith("com.apple.Pioneer_LTE_US"))
            {
                return "Pioneer";
            }
            else if (Mycarrier.StartsWith("com.apple.PTCI_LTE_US"))
            {
                return "PTCI";
            }
            else if (Mycarrier.StartsWith("com.apple.SilverStar_LTE_US"))
            {
                return "Silver Star";
            }
            else if (Mycarrier.StartsWith("com.apple.SilverStar_US"))
            {
                return "Silver Star";
            }
            else if (Mycarrier.StartsWith("com.apple.Sprint_Boost_ISIM_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Sprint_CSIM_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Sprint_ISIM_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Sprint_Virgin_ISIM_LTE_US"))
            {
                return "Sprint";
            }
            else if (Mycarrier.StartsWith("com.apple.SRT_LTE_US") || Mycarrier.StartsWith("com.apple.SRT_US"))
            {
                return "SRT";
            }
            else if (Mycarrier.StartsWith("com.apple.StrataNetwork_LTE_US") || Mycarrier.StartsWith("com.apple.Strata_LTE_US"))
            {
                return "Strata Network";
            }
            else if (Mycarrier.StartsWith("com.apple.Syringa_LTE_US"))
            {
                return "Syringa";
            }
            else if (Mycarrier.StartsWith("com.apple.THC_LTE_US"))
            {
                return "THC";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_CC_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_MetroPCS_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_MVNO_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_TFW_Simple_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_Ting_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_UltraMint_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_Vodafone_US"))
            {
                return "T-Mobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Tracfone_US"))
            {
                return "Tracfone";
            }
            else if (Mycarrier.StartsWith("com.apple.TriangleMobile_LTE_US"))
            {
                return "Triangle Mobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Truphone_US"))
            {
                return "Truphone";
            }
            else if (Mycarrier.StartsWith("com.apple.UnionWireless_US") ||
                     Mycarrier.StartsWith("com.apple.UnitedWireless_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.UnitedWireless_US"))
            {
                return "United Wireless";
            }
            else if (Mycarrier.StartsWith("com.apple.USCellular_LTE_US"))
            {
                return "US Cellular";
            }
            else if (Mycarrier.StartsWith("com.apple.Verizon_Charter_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Verizon_Comcast_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Verizon_Credo_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Verizon_LTE_US"))
            {
                return "Verizon";
            }
            else if (Mycarrier.StartsWith("com.apple.SilverStar_US"))
            {
                return "Silver Star";
            }
            else if (Mycarrier.StartsWith("com.apple.Sprint_Boost_ISIM_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Sprint_CSIM_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Sprint_ISIM_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Sprint_Virgin_ISIM_LTE_US"))
            {
                return "Sprint";
            }
            else if (Mycarrier.StartsWith("com.apple.SRT_LTE_US") || Mycarrier.StartsWith("com.apple.SRT_US"))
            {
                return "SRT";
            }
            else if (Mycarrier.StartsWith("com.apple.StrataNetwork_LTE_US") || Mycarrier.StartsWith("com.apple.Strata_LTE_US"))
            {
                return "Strata Network";
            }
            else if (Mycarrier.StartsWith("com.apple.Syringa_LTE_US"))
            {
                return "Syringa";
            }
            else if (Mycarrier.StartsWith("com.apple.THC_LTE_US"))
            {
                return "THC";
            }
            else if (Mycarrier.StartsWith("com.apple.TMobile_CC_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_MetroPCS_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_MVNO_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_TFW_Simple_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_Ting_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_UltraMint_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_US") ||
                     Mycarrier.StartsWith("com.apple.TMobile_Vodafone_US"))
            {
                return "T-Mobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Tracfone_US"))
            {
                return "Tracfone";
            }
            else if (Mycarrier.StartsWith("com.apple.TriangleMobile_LTE_US"))
            {
                return "Triangle Mobile";
            }
            else if (Mycarrier.StartsWith("com.apple.Truphone_US"))
            {
                return "Truphone";
            }
            else if (Mycarrier.StartsWith("com.apple.UnionWireless_US") ||
                     Mycarrier.StartsWith("com.apple.UnitedWireless_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.UnitedWireless_US"))
            {
                return "United Wireless";
            }
            else if (Mycarrier.StartsWith("com.apple.USCellular_LTE_US"))
            {
                return "US Cellular";
            }
            else if (Mycarrier.StartsWith("com.apple.Verizon_Charter_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Verizon_Comcast_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Verizon_Credo_LTE_US") ||
                     Mycarrier.StartsWith("com.apple.Verizon_LTE_US"))
            {
                return "Verizon";
            }


            return "Unknown";
        }
    }
}
