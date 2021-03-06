﻿using System;
using System.Drawing.Imaging;
using System.Runtime.Serialization;

namespace Threads
{
    [DataContract]
    public class wsCommunity
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Tagline { get; set; }

        [DataMember]
        public string Link { get; set; }

        [DataMember]
        public long OwnerID { get; set; }

        [DataMember]
        public bool IsMember { get; set; }

        [DataMember]
        public DateTime CreateDate { get; set; }

        [DataMember]
        public long DefaultColumnID { get; set; }

        [DataMember]
        public string CountMembers { get; set; }
    }

    [DataContract]
    public class wsCountry
    {
        [DataMember]
        public string Code { get; set; }
        
        [DataMember]
        public string Name { get; set; }

    }

    [DataContract]
    public class wsEntrySaveState
    {
        public long ID { get; set; }
    }

    [DataContract]
    public class wsEntry
    {
        [DataMember]
        public long Community_ID { get; set; }

        [DataMember]
        public string Community_Name { get; set; }

        [DataMember]
        public long Entry_ID { get; set; }

        [DataMember]
        public long ColumnCommunity_ID { get; set; }

        [DataMember]
        public string ColumnCommunity_Name { get; set; }

        [DataMember]
        public string Entry_Text { get; set; }

        [DataMember]
        public string Entry_CreateDate { get; set; }

        [DataMember]
        public string Entry_CreateDateEst { get; set; }

        [DataMember]
        public long CreatorID { get; set; }

        [DataMember]
        public string CreatorID_Fullname { get; set; }

        [DataMember]
        public bool IsPin { get; set; }

    }

    [DataContract]
    public class wsMember
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string About { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public bool IsMale { get; set; }

        [DataMember]
        public string BirthdayDate { get; set; }
    }

    [DataContract]
    public class wsSessionReq
    {
        [DataMember]
        public string Phone { get; set; }

    }

    [DataContract]
    public class wsSessionReq_Out
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public long MemberID { get; set; }

    }

    [DataContract]
    public class wsSession
    {
        [DataMember]
        public Guid? SessionID { get; set; }

        [DataMember]
        public long MemberID { get; set; }

        [DataMember]
        public bool IsNewMember { get; set; }
    }

    [DataContract]
    public class wsLogoOut
    {
        [DataMember]
        public bool isOk { get; set; }
    }

    [DataContract]
    public class wsCommunitySaveState
    {
        [DataMember]
        public long ID { get; set; }
    }

    [DataContract]
    public class wsColumnCommunity
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}