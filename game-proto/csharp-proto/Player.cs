// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: Player.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace com.su.msg
{

    [global::ProtoBuf.ProtoContract(Name = @"_Player")]
    public partial class Player : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public long Id
        {
            get { return __pbn__Id.GetValueOrDefault(); }
            set { __pbn__Id = value; }
        }
        public bool ShouldSerializeId() => __pbn__Id != null;
        public void ResetId() => __pbn__Id = null;
        private long? __pbn__Id;

        [global::ProtoBuf.ProtoMember(2, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name
        {
            get { return __pbn__Name ?? ""; }
            set { __pbn__Name = value; }
        }
        public bool ShouldSerializeName() => __pbn__Name != null;
        public void ResetName() => __pbn__Name = null;
        private string __pbn__Name;

        [global::ProtoBuf.ProtoMember(3, Name = @"peanut")]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int Peanut
        {
            get { return __pbn__Peanut ?? -1; }
            set { __pbn__Peanut = value; }
        }
        public bool ShouldSerializePeanut() => __pbn__Peanut != null;
        public void ResetPeanut() => __pbn__Peanut = null;
        private int? __pbn__Peanut;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int rankingScore
        {
            get { return __pbn__rankingScore ?? -1; }
            set { __pbn__rankingScore = value; }
        }
        public bool ShouldSerializerankingScore() => __pbn__rankingScore != null;
        public void ResetrankingScore() => __pbn__rankingScore = null;
        private int? __pbn__rankingScore;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int rankingStep
        {
            get { return __pbn__rankingStep ?? -1; }
            set { __pbn__rankingStep = value; }
        }
        public bool ShouldSerializerankingStep() => __pbn__rankingStep != null;
        public void ResetrankingStep() => __pbn__rankingStep = null;
        private int? __pbn__rankingStep;

    }

    [global::ProtoBuf.ProtoContract(Name = @"UpdatePlayer_")]
    public partial class UpdatePlayer : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"player")]
        public Player Player { get; set; }

    }

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
