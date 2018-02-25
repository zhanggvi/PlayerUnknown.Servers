﻿namespace PlayerUnknown.Logic.Components.Subs
{
    using Newtonsoft.Json.Linq;

    using PlayerUnknown.Interfaces;

    public sealed class Skin : ISkin
    {
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        public string Gender
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the hair.
        /// </summary>
        public string Hair
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the face.
        /// </summary>
        public string Face
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the presets.
        /// </summary>
        public string Presets
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Skin"/> class.
        /// </summary>
        public Skin()
        {
            this.SetDefault();
        }

        /// <summary>
        /// Sets the default values.
        /// </summary>
        public void SetDefault()
        {
            this.Gender     = "male";
            this.Hair       = "skindesc.male.hair.02.02";
            this.Face       = "skindesc.male.face.01.01";
            this.Presets    = "male:M_Hair_B_02:M_Face_01:M_NudeBody_01";
        }

        /// <summary>
        /// Saves this instance into a json object.
        /// </summary>
        public JObject ToJson()
        {
            JObject Json = new JObject();

            Json.Add("Gender", this.Gender);
            Json.Add("Hair", this.Hair);
            Json.Add("Face", this.Face);
            Json.Add("Presets", this.Presets);

            return Json;
        }
    }
}
