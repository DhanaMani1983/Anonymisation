//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Saga.GMD.Adobe.Anonymisation.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExtractCPRecipient
    {
        public long Pers_id { get; set; }
        public string Encrypted_Pers_id { get; set; }
        public Nullable<long> Hgrp_id { get; set; }
        public Nullable<long> Visitor_id { get; set; }
        public Nullable<long> CTI_id { get; set; }
        public string Encrypted_CTI_id { get; set; }
        public System.DateTime Create_Date_Customer { get; set; }
        public string Create_Media { get; set; }
        public string Create_Source { get; set; }
        public string DC_Brand { get; set; }
        public string Device { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> Age { get; set; }
        public string Email_DC { get; set; }
        public string Email_Saga { get; set; }
        public string Encrypted_Email_DC { get; set; }
        public string Encrypted_Email_Saga { get; set; }
        public string Exclusion_Zone { get; set; }
        public string firstName { get; set; }
        public string Gender { get; set; }
        public string Initials { get; set; }
        public Nullable<System.DateTime> Last_update_Customer { get; set; }
        public string lastName { get; set; }
        public long Property_ID { get; set; }
        public string location_address1 { get; set; }
        public string location_address2 { get; set; }
        public string location_address3 { get; set; }
        public string location_address4 { get; set; }
        public string location_address5 { get; set; }
        public string location_address6 { get; set; }
        public string location_address7 { get; set; }
        public string location_zipCode { get; set; }
        public string location_DPS { get; set; }
        public string Marital_Status { get; set; }
        public string Name_Suffix { get; set; }
        public string Occupation_DC { get; set; }
        public string Occupation_Saga { get; set; }
        public string Phone_Landline_DC { get; set; }
        public string Phone_Landline_Saga { get; set; }
        public string Phone_Mobile_DC { get; set; }
        public string Phone_Mobile_Saga { get; set; }
        public string Region { get; set; }
        public Nullable<System.DateTime> Retirement_Date { get; set; }
        public string Saga_Brand { get; set; }
        public string Salutation_Detail { get; set; }
        public string Salutation_Envelope { get; set; }
        public string SMS_Number_DC { get; set; }
        public bool SMS_Opt_Out_DC { get; set; }
        public string SMS_Number_Saga { get; set; }
        public bool SMS_Opt_Out_Saga { get; set; }
        public string Staff_Flag { get; set; }
        public Nullable<bool> suppressionFlag { get; set; }
        public string suppressionReason { get; set; }
        public string Title { get; set; }
        public Nullable<bool> TPS_Flag_Landline_DC { get; set; }
        public Nullable<bool> TPS_Flag_Landline_Saga { get; set; }
        public Nullable<bool> TPS_Flag_Mobile_DC { get; set; }
        public Nullable<bool> TPS_Flag_Mobile_Saga { get; set; }
        public long UPRN { get; set; }
        public string UPRN_Match_Level { get; set; }
        public Nullable<bool> Blacklist { get; set; }
        public System.DateTime GMD_Record_Creation_Date { get; set; }
        public string GMD_Created_by { get; set; }
        public Nullable<System.DateTime> GMD_Modified_Date { get; set; }
        public string GMD_Modified_by { get; set; }
        public Nullable<System.DateTime> GMD_Deletion_Date { get; set; }
        public Nullable<System.DateTime> date_sent_to_adobe { get; set; }
        public string adobe_sent_filename { get; set; }
        public Nullable<bool> received_response { get; set; }
        public Nullable<System.DateTime> received_response_date { get; set; }
        public int version { get; set; }
    }
}
