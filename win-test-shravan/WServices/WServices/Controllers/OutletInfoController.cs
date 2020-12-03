using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WServices.Controllers.Masters
{
    public class OutletInfoController : ApiController
    {


        WFramework.Masters.ClsOutletInfoMaster objOutletInfo = new WFramework.Masters.ClsOutletInfoMaster();


        //Get top 1000 All Outletinfo ///
        [Route("OutletInfo/readOutletinfoDetail")]
        [HttpGet]
        public string readOutletinfoDetail()
        {
            try
            {

                string readOutletinfoDetail = objOutletInfo.getOutletInfo(1,0,"","","","",0,"",0,0,"",0,0,0,"",0,"");

                if (readOutletinfoDetail == "Error")
                {
                    return "Error occured either component or strore Procedure";
                }
                else
                {
                    return readOutletinfoDetail;
                }

            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }



        //Get All OutletInfo by outlet ID///
        [Route("OutletInfo/readOutletInfobyoutletID")]
        [HttpPost]
        public string readOutletInfobyoutletID()
        {
            try
            {

                string readOutletInfobyoutletID = objOutletInfo.getOutletInfo(2, 0,"","","","",0,"",0,0,"",0,0,0,"",0,"");

                if (readOutletInfobyoutletID == "Error")
                {
                    return "Error occured either component or strore Procedure";
                }
                else
                {
                    return readOutletInfobyoutletID;
                }

            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }



        //Add OutletInfoDetail /////

        [Route("OutletInfo/createOutletInfo")]
        [HttpPost]
        public string createOutletInfo(string strOutletName, string strAddress, string strPhone, string strInvoiceFooter, int intCollectTax, string strPreOrPostPayment,int IsKitchenRequired, int intTempOne,  string strTempTwo
        , int intCreatedBy, int intModifiedBy)
        {
            try
            {

                int insertOutletInfo = objOutletInfo.manageOutletInfo(3, 0, strOutletName, strAddress, strPhone, strInvoiceFooter, intCollectTax, strPreOrPostPayment, IsKitchenRequired, intTempOne, strTempTwo,  1, 0, intCreatedBy, "", intModifiedBy, "");
                if (insertOutletInfo == 0)
                {
                    return "OutletInfoDetail added successfully";
                }
                else if (insertOutletInfo == -1)
                {
                    return "RestuarantInfoDetail already exist";
                }
                else
                {
                    return "Error occured either component or strore Procedure";
                }


            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }


        //Update OutletInfoDetail /////
        [Route("OutletInfo/updateOutletInfo")]
        [HttpPost]
        public string updateOutletInfo(int intOutletInfoID, string strOutletName, string strAddress, string strPhone, string strInvoiceFooter, int intCollectTax, string strPreOrPostPayment, int IsKitchenRequired, int intTempOne, string strTempTwo, int intCreatedBy, int intModifiedBy
        )
        {
            try
            {

                int updateOutletInfo = objOutletInfo.manageOutletInfo(4, intOutletInfoID, strOutletName, strAddress, strPhone, strInvoiceFooter, intCollectTax, strPreOrPostPayment, IsKitchenRequired, intTempOne, strTempTwo, 1, 0, intCreatedBy, "", intModifiedBy, "");
                if (updateOutletInfo == 0)
                {
                    return "OutletInfo detail updated successfully";
                }
                else
                {
                    return "Error occured either component or strore Procedure";
                }
            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }



        //Delete Outlet Info /////
        [Route("OutletInfo/deleteOutletInfo")]
        [HttpPost]
        public string deleteOutletInfo(int intOutletInfoID, int intCreatedBy, int intModifiedBy)
        {
            try
            {

                int deleteOutletInfo = objOutletInfo.manageOutletInfo(6, intOutletInfoID,"","","","",0,"",0,0,"",1,1,intCreatedBy,"",intModifiedBy,"");

                if (deleteOutletInfo == 0)
                {
                    return "Restuarant Info  deleted successfully";
                }
                else
                {
                    return "Error occured either component or strore Procedure";
                }
            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }

        //Get All OutletInfo  by ID///
        [Route("OutletInfo/editByOutletInfoID")]
        [HttpPost]
        public string editByOutletInfoID(int intOutletInfoID)
        {
            try
            {

                string editByOutletID = objOutletInfo.getOutletInfo(7, intOutletInfoID,"","","","",0,"",0,0,"",1,0,0,"",0,"");

                if (editByOutletID == "Error")
                {
                    return "Error occured either component or strore Procedure";
                }
                else
                {
                    return editByOutletID;
                }
            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }

        //deActive Status of outletInfo /////
        [Route("OutletInfo/deactiveStatusOutletInfo")]
        [HttpPost]
        public string deactiveStatusOutletInfo(int intOutletInfoID, int intCreatedBy, int intModifiedBy)
        {
            try
            {

                int DeactiveStatusOutletInfo = objOutletInfo.manageOutletInfo(9, intOutletInfoID, "","","","",0,"",0,0,"",0,0,intCreatedBy,"",intModifiedBy,"");

                if (DeactiveStatusOutletInfo == 0)
                {
                    return "OutletInfo  DeActivated successfully";
                }
                else
                {
                    return "Error occured either component or strore Procedure";
                }
            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }

        //Active Status of outletInfo /////
        [Route("OutletInfo/activeStatusOutletInfo")]
        [HttpPost]
        public string activeStatusOutletInfo(int intOutletInfoID, int intCreatedBy, int intModifiedBy)
        {
            try
            {

                int DeactiveStatusOutletInfo = objOutletInfo.manageOutletInfo(5, intOutletInfoID, "", "", "", "", 0, "", 0,0, "",1, 0, intCreatedBy, "", intModifiedBy, "");

                if (DeactiveStatusOutletInfo == 0)
                {
                    return "OutletInfo  Activated successfully";
                }
                else
                {
                    return "Error occured either component or strore Procedure";
                }
            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }

    }
}
