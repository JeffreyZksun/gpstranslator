﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GPSProxy.GPSService
{
    // NOTE: If you change the interface name "IGPSManager" here, you must also update the reference to "IGPSManager" in App.config.
    [ServiceContract]
    public interface IGPSManager
    {
        [OperationContract]
        bool CreateNewPath(PathInfo path, UserInfo user);

        [OperationContract]
        List<PathInfo> GetPathList(String searchString, UserInfo user);

        [OperationContract]
        bool UploadGPSData(GPSUploadData data);

        [OperationContract]
        List<GPSDownloadData> GetGPSData(GPSDataRequestParameter para);

        [OperationContract]
        Int32 GetPathID(PathInfo path);

        [OperationContract]
        bool IsServiceAvailable(String msg); // Used to test the connection.
    }

    [DataContract]
    public class PathInfo
    {
        private String mName = "";
        private String mPassword = "";
        private Int32 mID = -1;

        [DataMember]
        public String Name
        {
            get { return mName; }
            set { mName = value; }
        }

        [DataMember]
        public String Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        [DataMember]
        public Int32 ID
        {
            get { return mID; }
            set { mID = value; }
        }
    }

    [DataContract]
    public class GPSDataRequestParameter
    {
        private Int32 mPathID = -1;
        private String mPathPassword = "";
        private bool mbIsLatestDataOnly = true;
        private Int32 mMaxLines = 10;
        private Int32 mLastDataID = -1;

        [DataMember]
        public Int32 PathID
        {
            get { return mPathID; }
            set { mPathID = value; }
        }

        [DataMember]
        public bool LatestDataOnly
        {
            get { return mbIsLatestDataOnly; }
            set { mbIsLatestDataOnly = value; }
        }

        [DataMember]
        public String PathPassword
        {
            get { return mPathPassword; }
            set { mPathPassword = value; }
        }

        [DataMember]
        public Int32 MaxLines
        {
            get { return mMaxLines; }
            set { mMaxLines = value; }
        }

        [DataMember]
        public Int32 LastDataID
        {
            get { return mLastDataID; }
            set { mLastDataID = value; }
        }
    }

    [DataContract]
    public class UserInfo
    {
        private String mName = "anonymous";
        private String mPassword = "";

        [DataMember]
        public String Name
        {
            get { return mName; }
            set { mName = value; }
        }

        [DataMember]
        public String Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
    }

    [DataContract]
    public class GPSUploadData
    {
        private String mNMEASentence = "";
        private String mProvider = "anonymous";
        private Int32 mPathID;
        private String mPathPassword;

        [DataMember]
        public String NMEASentence
        {
            get { return mNMEASentence; }
            set { mNMEASentence = value; }
        }

        [DataMember]
        public string Provider
        {
            get { return mProvider; }
            set { mProvider = value; }
        }

        [DataMember]
        public Int32 PathID
        {
            get { return mPathID; }
            set { mPathID = value; }
        }

        [DataMember]
        public String PathPassword
        {
            get { return mPathPassword; }
            set { mPathPassword = value; }
        }
    }

    [DataContract]
    public class GPSDownloadData
    {
        private String mNMEASentence = "";
        private Int32 mID = -1; // ToDo - maybe we need a large number to avoid overflow if there are many many data.

        [DataMember]
        public String NMEASentence
        {
            get { return mNMEASentence; }
            set { mNMEASentence = value; }
        }

        [DataMember]
        public Int32 ID
        {
            get { return mID; }
            set { mID = value; }
        }
    }
}
