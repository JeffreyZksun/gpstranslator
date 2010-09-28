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
        List<String> GetPathList(String searchString, UserInfo user);

        [OperationContract]
        bool UploadGPSData(GPSUploadData data, PathInfo path);

        [OperationContract]
        List<GPSDownloadData> GetGPSData(PathInfo path, Int32 lastID);
    }

    [DataContract]
    public class PathInfo
    {
        private String mName = "";
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
    }

    [DataContract]
    public class GPSDownloadData
    {
        private String mNMEASentence = "";
        private Int32 mID = -1;

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
