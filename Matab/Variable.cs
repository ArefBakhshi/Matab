using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matab
{
     public static class Variable
    {   
        //to show access lvl on main form.
        public static string stru;
        //data shown in userManageForm
        public static DataSet UserMngDs = new DataSet();
        public static string UserMngUserName;
        public static string UserMngPassword;
        public static string UserMngAccess;
        //data that will be taken to edit form.
        public static string userEditImport;
        public static string passwordEditImport;
        public static string accessEditImport;
        //used this id to locate the user in database
        public static string userIdEdit;
        //delete id indicator.
        public static int DeleteIdUser;
        //data from edit form that will change database.
        public static string userEditExport;
        public static string passwordEditExport;
        public static string accessEditExport;
        //login vars
        public static string userLogin;
        public static string passwordLogin;
        public static string accessLogin;
        public static int L;
        //Setting
        public static DataSet SettingDs = new DataSet();
        public static int SettingId;
        public static string SettingMatabName;
        public static string SettingDoctorName;
        public static string SettingTelephone;
        public static string SettingPhone;
        public static string SettingAddress;
        // delete setting
        public static int DeleteIdSetting;
        //edit setting that will be takon into edit form of setting form
        public static int SettingIdImport;
        public static string SettingMatabNameImport;
        public static string SettingDoctorNameImport;
        public static string SettingTelephoneImport;
        public static string SettingPhoneImport;
        public static string SettingAddressImport;
        //edit setting that will be taken to data base
        
        public static string SettingMatabNameExport;
        public static string SettingDoctorNameExport;
        public static string SettingTelephoneExport;
        public static string SettingPhoneExport;
        public static string SettingAddressExport;
        //Sec
        public static DataSet SecDs = new DataSet();
        public static int SecId;
        public static string SecName;
        public static string SecSalary;
        public static string SecSalaryDate;
        public static string SecPhone;
        public static string SecExplanation;
        // delete sec
        public static int DeleteIdSec;
        //edit sec that will be takon into edit form of sec form
        public static int SecIdEdit;
        public static string SecNameImport;
        public static string SecSalaryImport;
        public static string SecSalaryDateImport;
        public static string SecPhoneImport;
        public static string SecExplanationImport;
        //edit setting that will be taken to data base
        public static string SecNameExport;
        public static string SecSalaryExport;
        public static string SecSalaryDateExport;
        public static string SecPhoneExport;
        public static string SecExplanationExport;
        //FormSecPay
        public static string SecPayRecordNameImport;
        public static string SecPayRecordSalaryImport;
        public static string SecPayRecordSalaryDateImport;
        public static string SecPayRecordSalaryTodayImport;      
        //FormSecPay info taken to Payment List
        public static string SecPayRecordNameExport;
        public static string SecPayRecordSalaryExport;
        public static string SecPayRecordSalaryDateExport;
        public static string SecPayRecordSalaryTodayExport;
        public static string SecPayRecordTrackNum;
        //PayRecord
        public static string PayRecordName;
        public static string PayRecordSalary;
        public static string PayRecordSalaryDate;
        public static string PayRecordSalaryPayDate;
        public static string PayRecordPayNum;
        //RecordList 
        public static DataSet RecordListDs = new DataSet();
        public static string NameSearch;
        public static int DeleteIdRecord;
        //Appointment 
        public static DataSet Appointments = new DataSet();
        public static string AppointName;
        public static string AppointDate;
        public static string AppointTime;
        public static string AppointTelephone;
        public static string AppointPhone;
        public static string AppointInsur;
        //Appointment delete
        public static int DeleteIdAppoint;
        //Appoint Edit import
        public static int AppointIdEdit;
        public static string AppointNameEdit;
        public static string AppointDateEdit;
        public static string AppointTimeEdit;
        public static string AppointTelephoneEdit;
        public static string AppointPhoneEdit;
        public static string AppointInsurEdit;
        //Appoint Edit export
        public static int AppointIdEditEx;
        public static string AppointNameEditEx;
        public static string AppointDateEditEx;
        public static string AppointTimeEditEx;
        public static string AppointTelephoneEditEx;
        public static string AppointPhoneEditEx;
        public static string AppointInsurEditEx;
        //mainForm Grid
        public static DataSet TodayAppoint = new DataSet();
        public static string TodayTime;


    }

}
