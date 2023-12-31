﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeamlessClient.Messages
{
    [ProtoContract]
    public class OnlinePlayerData
    {
        [ProtoMember(10)] public List<OnlineClientServer> OnlineServers = new List<OnlineClientServer>();

        [ProtoMember(12)] public int currentServerID;
    }

    [ProtoContract]
    public class OnlineClientServer
    {
        [ProtoMember(2)] public List<OnlinePlayer> Players = new List<OnlinePlayer>();

        [ProtoMember(3)] public bool ServerRunning = false;

        [ProtoMember(10)] public int ServerID;

        [ProtoMember(11)] public string ServerName;

        public OnlineClientServer()
        {
        }
    }

    [ProtoContract]
    public class OnlinePlayer
    {
        [ProtoMember(1)] public string PlayerName;

        [ProtoMember(2)] public ulong SteamID;

        [ProtoMember(3)] public long IdentityID;

        [ProtoMember(4)] public int OnServer;


        public string ServerName;

        public OnlinePlayer(string PlayerName, ulong SteamID, long IdentityID, int OnServer)
        {
            this.PlayerName = PlayerName;
            this.SteamID = SteamID;
            this.IdentityID = IdentityID;
            this.OnServer = OnServer;
        }

        public OnlinePlayer()
        {
        }
    }
}
