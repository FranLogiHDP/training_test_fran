// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: accommodationTemplate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Training.App {

  /// <summary>Holder for reflection information generated from accommodationTemplate.proto</summary>
  public static partial class AccommodationTemplateReflection {

    #region Descriptor
    /// <summary>File descriptor for accommodationTemplate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccommodationTemplateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChthY2NvbW1vZGF0aW9uVGVtcGxhdGUucHJvdG8SFUFjY29tbW9kYXRpb25U",
            "ZW1wbGF0ZRoMY29tbW9uLnByb3RvImAKIEFjY29tbW9kYXRpb25UZW1wbGF0",
            "ZUxpc3RSZXF1ZXN0EiMKF2FjY29tbW9kYXRpb25UZW1wbGF0ZUlkGAEgAygF",
            "QgIQARIXCg9hY2NvbW1vZGF0aW9uSWQYAiADKAUivgEKIUFjY29tbW9kYXRp",
            "b25UZW1wbGF0ZUxpc3RSZXNwb25zZRJUChZhY2NvbW1vZGF0aW9uVGVtcGxh",
            "dGVzGAEgAygLMjQuQWNjb21tb2RhdGlvblRlbXBsYXRlLkFjY29tbW9kYXRp",
            "b25UZW1wbGF0ZVJlc3BvbnNlEg4KBmZhaWxlZBgCIAEoCBIzChFhcHBsaWNh",
            "dGlvbkVycm9ycxgDIAMoCzIYLkNvbW1vbi5BcHBsaWNhdGlvbkVycm9yImcK",
            "HUFjY29tbW9kYXRpb25UZW1wbGF0ZVJlc3BvbnNlEh8KF2FjY29tbW9kYXRp",
            "b25UZW1wbGF0ZUlkGAEgASgFEgwKBG5hbWUYAiABKAkSFwoPYWNjb21tb2Rh",
            "dGlvbklkGAMgASgFQg+qAgxUcmFpbmluZy5BcHBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Training.App.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.AccommodationTemplateListRequest), global::Training.App.AccommodationTemplateListRequest.Parser, new[]{ "AccommodationTemplateId", "AccommodationId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.AccommodationTemplateListResponse), global::Training.App.AccommodationTemplateListResponse.Parser, new[]{ "AccommodationTemplates", "Failed", "ApplicationErrors" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.AccommodationTemplateResponse), global::Training.App.AccommodationTemplateResponse.Parser, new[]{ "AccommodationTemplateId", "Name", "AccommodationId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AccommodationTemplateListRequest : pb::IMessage<AccommodationTemplateListRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccommodationTemplateListRequest> _parser = new pb::MessageParser<AccommodationTemplateListRequest>(() => new AccommodationTemplateListRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccommodationTemplateListRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.AccommodationTemplateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationTemplateListRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationTemplateListRequest(AccommodationTemplateListRequest other) : this() {
      accommodationTemplateId_ = other.accommodationTemplateId_.Clone();
      accommodationId_ = other.accommodationId_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationTemplateListRequest Clone() {
      return new AccommodationTemplateListRequest(this);
    }

    /// <summary>Field number for the "accommodationTemplateId" field.</summary>
    public const int AccommodationTemplateIdFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_accommodationTemplateId_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> accommodationTemplateId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> AccommodationTemplateId {
      get { return accommodationTemplateId_; }
    }

    /// <summary>Field number for the "accommodationId" field.</summary>
    public const int AccommodationIdFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_accommodationId_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> accommodationId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> AccommodationId {
      get { return accommodationId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccommodationTemplateListRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccommodationTemplateListRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!accommodationTemplateId_.Equals(other.accommodationTemplateId_)) return false;
      if(!accommodationId_.Equals(other.accommodationId_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= accommodationTemplateId_.GetHashCode();
      hash ^= accommodationId_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      accommodationTemplateId_.WriteTo(output, _repeated_accommodationTemplateId_codec);
      accommodationId_.WriteTo(output, _repeated_accommodationId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      accommodationTemplateId_.WriteTo(ref output, _repeated_accommodationTemplateId_codec);
      accommodationId_.WriteTo(ref output, _repeated_accommodationId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += accommodationTemplateId_.CalculateSize(_repeated_accommodationTemplateId_codec);
      size += accommodationId_.CalculateSize(_repeated_accommodationId_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AccommodationTemplateListRequest other) {
      if (other == null) {
        return;
      }
      accommodationTemplateId_.Add(other.accommodationTemplateId_);
      accommodationId_.Add(other.accommodationId_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            accommodationTemplateId_.AddEntriesFrom(input, _repeated_accommodationTemplateId_codec);
            break;
          }
          case 18:
          case 16: {
            accommodationId_.AddEntriesFrom(input, _repeated_accommodationId_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10:
          case 8: {
            accommodationTemplateId_.AddEntriesFrom(ref input, _repeated_accommodationTemplateId_codec);
            break;
          }
          case 18:
          case 16: {
            accommodationId_.AddEntriesFrom(ref input, _repeated_accommodationId_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AccommodationTemplateListResponse : pb::IMessage<AccommodationTemplateListResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccommodationTemplateListResponse> _parser = new pb::MessageParser<AccommodationTemplateListResponse>(() => new AccommodationTemplateListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccommodationTemplateListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.AccommodationTemplateReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationTemplateListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationTemplateListResponse(AccommodationTemplateListResponse other) : this() {
      accommodationTemplates_ = other.accommodationTemplates_.Clone();
      failed_ = other.failed_;
      applicationErrors_ = other.applicationErrors_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationTemplateListResponse Clone() {
      return new AccommodationTemplateListResponse(this);
    }

    /// <summary>Field number for the "accommodationTemplates" field.</summary>
    public const int AccommodationTemplatesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Training.App.AccommodationTemplateResponse> _repeated_accommodationTemplates_codec
        = pb::FieldCodec.ForMessage(10, global::Training.App.AccommodationTemplateResponse.Parser);
    private readonly pbc::RepeatedField<global::Training.App.AccommodationTemplateResponse> accommodationTemplates_ = new pbc::RepeatedField<global::Training.App.AccommodationTemplateResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Training.App.AccommodationTemplateResponse> AccommodationTemplates {
      get { return accommodationTemplates_; }
    }

    /// <summary>Field number for the "failed" field.</summary>
    public const int FailedFieldNumber = 2;
    private bool failed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Failed {
      get { return failed_; }
      set {
        failed_ = value;
      }
    }

    /// <summary>Field number for the "applicationErrors" field.</summary>
    public const int ApplicationErrorsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Training.App.ApplicationError> _repeated_applicationErrors_codec
        = pb::FieldCodec.ForMessage(26, global::Training.App.ApplicationError.Parser);
    private readonly pbc::RepeatedField<global::Training.App.ApplicationError> applicationErrors_ = new pbc::RepeatedField<global::Training.App.ApplicationError>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Training.App.ApplicationError> ApplicationErrors {
      get { return applicationErrors_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccommodationTemplateListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccommodationTemplateListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!accommodationTemplates_.Equals(other.accommodationTemplates_)) return false;
      if (Failed != other.Failed) return false;
      if(!applicationErrors_.Equals(other.applicationErrors_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= accommodationTemplates_.GetHashCode();
      if (Failed != false) hash ^= Failed.GetHashCode();
      hash ^= applicationErrors_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      accommodationTemplates_.WriteTo(output, _repeated_accommodationTemplates_codec);
      if (Failed != false) {
        output.WriteRawTag(16);
        output.WriteBool(Failed);
      }
      applicationErrors_.WriteTo(output, _repeated_applicationErrors_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      accommodationTemplates_.WriteTo(ref output, _repeated_accommodationTemplates_codec);
      if (Failed != false) {
        output.WriteRawTag(16);
        output.WriteBool(Failed);
      }
      applicationErrors_.WriteTo(ref output, _repeated_applicationErrors_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += accommodationTemplates_.CalculateSize(_repeated_accommodationTemplates_codec);
      if (Failed != false) {
        size += 1 + 1;
      }
      size += applicationErrors_.CalculateSize(_repeated_applicationErrors_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AccommodationTemplateListResponse other) {
      if (other == null) {
        return;
      }
      accommodationTemplates_.Add(other.accommodationTemplates_);
      if (other.Failed != false) {
        Failed = other.Failed;
      }
      applicationErrors_.Add(other.applicationErrors_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            accommodationTemplates_.AddEntriesFrom(input, _repeated_accommodationTemplates_codec);
            break;
          }
          case 16: {
            Failed = input.ReadBool();
            break;
          }
          case 26: {
            applicationErrors_.AddEntriesFrom(input, _repeated_applicationErrors_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            accommodationTemplates_.AddEntriesFrom(ref input, _repeated_accommodationTemplates_codec);
            break;
          }
          case 16: {
            Failed = input.ReadBool();
            break;
          }
          case 26: {
            applicationErrors_.AddEntriesFrom(ref input, _repeated_applicationErrors_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AccommodationTemplateResponse : pb::IMessage<AccommodationTemplateResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccommodationTemplateResponse> _parser = new pb::MessageParser<AccommodationTemplateResponse>(() => new AccommodationTemplateResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccommodationTemplateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.AccommodationTemplateReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationTemplateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationTemplateResponse(AccommodationTemplateResponse other) : this() {
      accommodationTemplateId_ = other.accommodationTemplateId_;
      name_ = other.name_;
      accommodationId_ = other.accommodationId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationTemplateResponse Clone() {
      return new AccommodationTemplateResponse(this);
    }

    /// <summary>Field number for the "accommodationTemplateId" field.</summary>
    public const int AccommodationTemplateIdFieldNumber = 1;
    private int accommodationTemplateId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AccommodationTemplateId {
      get { return accommodationTemplateId_; }
      set {
        accommodationTemplateId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "accommodationId" field.</summary>
    public const int AccommodationIdFieldNumber = 3;
    private int accommodationId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AccommodationId {
      get { return accommodationId_; }
      set {
        accommodationId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccommodationTemplateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccommodationTemplateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccommodationTemplateId != other.AccommodationTemplateId) return false;
      if (Name != other.Name) return false;
      if (AccommodationId != other.AccommodationId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AccommodationTemplateId != 0) hash ^= AccommodationTemplateId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (AccommodationId != 0) hash ^= AccommodationId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (AccommodationTemplateId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(AccommodationTemplateId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (AccommodationId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(AccommodationId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (AccommodationTemplateId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(AccommodationTemplateId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (AccommodationId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(AccommodationId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AccommodationTemplateId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AccommodationTemplateId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (AccommodationId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AccommodationId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AccommodationTemplateResponse other) {
      if (other == null) {
        return;
      }
      if (other.AccommodationTemplateId != 0) {
        AccommodationTemplateId = other.AccommodationTemplateId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.AccommodationId != 0) {
        AccommodationId = other.AccommodationId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            AccommodationTemplateId = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            AccommodationId = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            AccommodationTemplateId = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            AccommodationId = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code