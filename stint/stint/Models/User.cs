using System;
using System.Collections.Generic;
using System.Text;

namespace stint.Models
{
    class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserGender { get; set; }
        public int UserDOB { get; set; }
        public string UserNationality { get; set; }
        public string UserRace { get; set; }
        public string UserNRIC { get; set; }
        public string UserAddress { get; set; }
        public string UserContact { get; set; }
        public int CompanyID { get; set; }
        public string ResumePhotoPath { get; set; }
        public string ProfilePhotoPath { get; set; }
        public string UserQualification { get; set; }
        public string UserAbout { get; set; }
        public int PunctualityScore { get; set; }
        public int PunctualityBase { get; set; }
        public int AttitudeScore { get; set; }
        public int AttitudeBase { get; set; }
        public int EfficiencyScore { get; set; }
        public int EfficiencyBase { get; set; }
        public int FastLearnerScore { get; set; }
        public int FastLearnerBase { get; set; }
        public int CommunicationScore { get; set; }
        public int CommunicationBase { get; set; }
        public int ServiceScore { get; set; }
        public int ServiceBase { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }
        public int CreatorID { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifierID { get; set; }
        public DateTime ModifyDate { get; set; }
        public string POCName { get; set; }
        public string POCEmail { get; set; }
        public bool IsHosting { get; set; }
        public bool IsBankTransfer { get; set; }
        public string PayToBank { get; set; }
        public string PayToBankAccount { get; set; }
        public string PayToAccountType { get; set; }
        public string PayToName { get; set; }
        public string PayToAddress { get; set; }
        public string UserToken { get; set; }




    }
}
