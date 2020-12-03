using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WServices.Controllers.Masters
{
    public class RestuarantInfoMasterController : ApiController
    {


        WFramework.Masters.ClsRestuarantInfoMaster objPaymentRestInfo = new WFramework.Masters.ClsRestuarantInfoMaster();


        //Get top 1000 All Restuarantinfo ///
        [Route("readRestuarantInfoDetail")]
        [HttpGet]
        public string readRestuarantInfoDetail()
        {
            try
            {

                string readRestuarantInfoDetail = objPaymentRestInfo.getRestuarantInfo(1, 0,"","","","","","",0,0,"","",0,0,0,"",0,"");

                if (readRestuarantInfoDetail == "Error")
                {
                    return "Error occured either component or strore Procedure";
                }
                else
                {
                    return readRestuarantInfoDetail;
                }

            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }



        //Get All RestuarantInfo by outlet ID///
        [Route("readRestuarantInfobyoutletID")]
        [HttpPost]
        public string readRestuarantInfobyoutletID()
        {
            try
            {

                string readRestuarantInfobyoutletID = objPaymentRestInfo.getRestuarantInfo(2, 0, "", "","","","","",0,0,"","",0,0,0,"",0,"");

                if (readRestuarantInfobyoutletID == "Error")
                {
                    return "Error occured either component or strore Procedure";
                }
                else
                {
                    return readRestuarantInfobyoutletID;
                }

            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }



        //Add RestuarantInfoDetail /////

        [Route("createRestuarantInfo")]
        [HttpPost]
        public string createRestuarantInfo(string strRestuarantName, string strRestuarantContactPerson, string strRestuarantAddress, string strRestuarantEmail, string strRestuarantLogo, string strPoweredByText,  int intTempOne, int intTempTwo, string strTempThree, string strTempFour
       , int intCreatedBy, int intModifiedBy)
        {
            try
            {

                int insertRestuarantInfo = objPaymentRestInfo.manageRestuarantInfo(3, 0, strRestuarantName, strRestuarantContactPerson,  strRestuarantAddress,  strRestuarantEmail,  strRestuarantLogo,  strPoweredByText, intTempOne, intTempTwo, strTempThree, strTempFour,  1, 0, intCreatedBy, "", intModifiedBy, "");
                if (insertRestuarantInfo == 0)
                {
                    return "RestuarantInfoDetail added successfully";
                }
                else if (insertRestuarantInfo == -1)
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


        //Update RestuarantInfoDetail /////
        [Route("updateRestuarantInfo")]
        [HttpPost]
        public string updateRestuarantInfo(int intRestuarantID, string strRestuarantName, string strRestuarantContactPerson, string strRestuarantAddress, string strRestuarantEmail, string strRestuarantLogo, string strPoweredByText, int intTempOne, int intTempTwo, string strTempThree, string strTempFour
      , int intCreatedBy, int intModifiedBy)
        {
            try
            {

                int updateRestuarantInfo = objPaymentRestInfo.manageRestuarantInfo(4, intRestuarantID, strRestuarantName, strRestuarantContactPerson, strRestuarantAddress, strRestuarantEmail, strRestuarantLogo, strPoweredByText, intTempOne, intTempTwo, strTempThree, strTempFour,  1, 0, intCreatedBy, "", intModifiedBy, "");
                if (updateRestuarantInfo == 0)
                {
                    return "Restuarant Info detail updated successfully";
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



        //Delete Restuarant Info /////
        [Route("deleteRestuarantInfo")]
        [HttpPost]
        public string deleteRestuarantInfo(int intRestuarantID, int intCreatedBy, int intModifiedBy)
        {
            try
            {

                int deleteRestuarantInfo = objPaymentRestInfo.manageRestuarantInfo(6, intRestuarantID,"","","","","","",0,0,"","",1,1,intCreatedBy,"",intModifiedBy,"");

                if (deleteRestuarantInfo == 0)
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

        //Get All RestuarantInfo  by ID///
        [Route("editByRestuarantInfoID")]
        [HttpPost]
        public string editByRestuarantInfoID(int intRestuarantID)
        {
            try
            {

                string editByRestuarantCustomerID = objPaymentRestInfo.getRestuarantInfo(7, intRestuarantID, "","","","","","",0,0,"","",1,0,0,"",0,"");

                if (editByRestuarantCustomerID == "Error")
                {
                    return "Error occured either component or strore Procedure";
                }
                else
                {
                    return editByRestuarantCustomerID;
                }
            }

            catch (Exception ex)
            {
                return "Error occured either component or strore Procedure";
            }
        }

        //Active Status of RestuarantInfo /////
        [Route("activeStatusRestuarantInfo")]
        [HttpPost]
        public string activeStatusRestuarantInfo(int intRestuarantID, int intCreatedBy, int intModifiedBy)
        {
            try
            {

                int activeStatusRestuarantInfo = objPaymentRestInfo.manageRestuarantInfo(5, intRestuarantID,"","","","","","",0,0,"","",1,0,intCreatedBy,"",intModifiedBy,"");

                if (activeStatusRestuarantInfo == 0)
                {
                    return "RestuarantInfo  Activated successfully";
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

        //deActive Status of RestuarantInfo /////
        [Route("deactiveStatusRestuarantInfo")]
        [HttpPost]
        public string deactiveStatusRestuarantInfo(int intRestuarantID, int intCreatedBy, int intModifiedBy)
        {
            try
            {

                int deactiveStatusRestuarantInfo = objPaymentRestInfo.manageRestuarantInfo(9, intRestuarantID, "", "", "", "", "", "", 0, 0, "", "", 0, 0, intCreatedBy, "", intModifiedBy, "");

                if (deactiveStatusRestuarantInfo == 0)
                {
                    return "RestuarantInfo  DeActivated successfully";
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
