﻿namespace Env.CnemcPublish.DAL
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using OpenRiaServices.DomainServices.Client;

    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/Env.CnemcPublish.DAL")]
    public sealed class ModelCityConfig : Entity
    {
        private int _cityCode;
        private string _cityName;
        private int _id;
        private bool _isPublish;
        private string[] _openAccessGenerated;
        private int? _orderId;
        private int _provinceId;

        public override object GetIdentity()
        {
            return this._id;
        }

        [ConcurrencyCheck, DataMember, RoundtripOriginal]
        public int CityCode
        {
            get
            {
                return this._cityCode;
            }
            set
            {
                if (this._cityCode != value)
                {
                    base.RaiseDataMemberChanging("CityCode");
                    base.ValidateProperty("CityCode", value);
                    this._cityCode = value;
                    base.RaiseDataMemberChanged("CityCode");
                }
            }
        }

        [ConcurrencyCheck, StringLength(50), DataMember, RoundtripOriginal]
        public string CityName
        {
            get
            {
                return this._cityName;
            }
            set
            {
                if (this._cityName != value)
                {
                    base.RaiseDataMemberChanging("CityName");
                    base.ValidateProperty("CityName", value);
                    this._cityName = value;
                    base.RaiseDataMemberChanged("CityName");
                }
            }
        }

        [DataMember, ConcurrencyCheck, Key, Editable(false, AllowInitialValue=true), RoundtripOriginal]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (this._id != value)
                {
                    base.ValidateProperty("Id", value);
                    this._id = value;
                    base.RaisePropertyChanged("Id");
                }
            }
        }

        [RoundtripOriginal, ConcurrencyCheck, DataMember]
        public bool IsPublish
        {
            get
            {
                return this._isPublish;
            }
            set
            {
                if (this._isPublish != value)
                {
                    base.RaiseDataMemberChanging("IsPublish");
                    base.ValidateProperty("IsPublish", value);
                    this._isPublish = value;
                    base.RaiseDataMemberChanged("IsPublish");
                }
            }
        }

        [Display(AutoGenerateField=false, AutoGenerateFilter=false, Description="OpenAccess Key", Name="-ID-"), DataMember, Editable(false), ReadOnly(true), RoundtripOriginal]
        public string[] OpenAccessGenerated
        {
            get
            {
                return this._openAccessGenerated;
            }
            set
            {
                if (this._openAccessGenerated != value)
                {
                    base.ValidateProperty("OpenAccessGenerated", value);
                    this._openAccessGenerated = value;
                    base.RaisePropertyChanged("OpenAccessGenerated");
                }
            }
        }

        [RoundtripOriginal, ConcurrencyCheck, DataMember]
        public int? OrderId
        {
            get
            {
                return this._orderId;
            }
            set
            {
                if (this._orderId != value)
                {
                    base.RaiseDataMemberChanging("OrderId");
                    base.ValidateProperty("OrderId", value);
                    this._orderId = value;
                    base.RaiseDataMemberChanged("OrderId");
                }
            }
        }

        [DataMember, ConcurrencyCheck, RoundtripOriginal]
        public int ProvinceId
        {
            get
            {
                return this._provinceId;
            }
            set
            {
                if (this._provinceId != value)
                {
                    base.RaiseDataMemberChanging("ProvinceId");
                    base.ValidateProperty("ProvinceId", value);
                    this._provinceId = value;
                    base.RaiseDataMemberChanged("ProvinceId");
                }
            }
        }
    }
}

