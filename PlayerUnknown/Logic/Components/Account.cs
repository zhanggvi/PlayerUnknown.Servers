﻿namespace PlayerUnknown.Logic.Components
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using PlayerUnknown.Interfaces;

    public sealed class Account : IAccount
    {
        /// <summary>
        /// Gets or sets the account identifier.
        /// </summary>
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        public string AppId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this player is a partner.
        /// </summary>
        public bool IsPartner
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the outer source.
        /// </summary>
        public string OuterSource
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the partner identifier.
        /// </summary>
        public string PartnerId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the partner level.
        /// </summary>
        public string PartnerLevel
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the player net identifier.
        /// </summary>
        public string PlayerNetId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user serial.
        /// </summary>
        public string UserSerial
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public string Region
        {
            get;
            set;
        }

        /// <summary>
        /// Saves this instance into a json object.
        /// </summary>
        public JObject ToJson()
        {
            JObject Json = new JObject();

            Json.Add("AccountId",  this.AccountId);
            Json.Add("AppId", this.AppId);
            Json.Add("IsPartner", this.IsPartner);
            Json.Add("OuterSource", this.OuterSource);
            Json.Add("PartnerId", this.PartnerId);
            Json.Add("PartnerLevel", this.PartnerLevel);
            Json.Add("PlayerNetId", this.PlayerNetId);
            Json.Add("UserSerial", this.UserSerial);
            Json.Add("Region", this.Region);

            return Json;
        }
    }
}
