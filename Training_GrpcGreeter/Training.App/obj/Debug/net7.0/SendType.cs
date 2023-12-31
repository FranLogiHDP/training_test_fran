// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: sendType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Training.App {

  /// <summary>Holder for reflection information generated from sendType.proto</summary>
  public static partial class SendTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for sendType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SendTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5zZW5kVHlwZS5wcm90bxIIU2VuZFR5cGUaDGNvbW1vbi5wcm90byI/ChNT",
            "ZW5kVHlwZUxpc3RSZXF1ZXN0EhYKCnNlbmRUeXBlSWQYASADKAVCAhABEhAK",
            "CGNsaWVudElkGAIgAygFIooBChRTZW5kVHlwZUxpc3RSZXNwb25zZRItCglz",
            "ZW5kVHlwZXMYASADKAsyGi5TZW5kVHlwZS5TZW5kVHlwZVJlc3BvbnNlEg4K",
            "BmZhaWxlZBgCIAEoCBIzChFhcHBsaWNhdGlvbkVycm9ycxgDIAMoCzIYLkNv",
            "bW1vbi5BcHBsaWNhdGlvbkVycm9yIk0KEFNlbmRUeXBlUmVzcG9uc2USEgoK",
            "c2VuZFR5cGVJZBgBIAEoBRITCgt0eXBlTWVzc2FnZRgCIAEoCRIQCghjbGll",
            "bnRJZBgDIAEoBUIPqgIMVHJhaW5pbmcuQXBwYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Training.App.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.SendTypeListRequest), global::Training.App.SendTypeListRequest.Parser, new[]{ "SendTypeId", "ClientId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.SendTypeListResponse), global::Training.App.SendTypeListResponse.Parser, new[]{ "SendTypes", "Failed", "ApplicationErrors" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.SendTypeResponse), global::Training.App.SendTypeResponse.Parser, new[]{ "SendTypeId", "TypeMessage", "ClientId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SendTypeListRequest : pb::IMessage<SendTypeListRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SendTypeListRequest> _parser = new pb::MessageParser<SendTypeListRequest>(() => new SendTypeListRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SendTypeListRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.SendTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendTypeListRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendTypeListRequest(SendTypeListRequest other) : this() {
      sendTypeId_ = other.sendTypeId_.Clone();
      clientId_ = other.clientId_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendTypeListRequest Clone() {
      return new SendTypeListRequest(this);
    }

    /// <summary>Field number for the "sendTypeId" field.</summary>
    public const int SendTypeIdFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_sendTypeId_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> sendTypeId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> SendTypeId {
      get { return sendTypeId_; }
    }

    /// <summary>Field number for the "clientId" field.</summary>
    public const int ClientIdFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_clientId_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> clientId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> ClientId {
      get { return clientId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SendTypeListRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SendTypeListRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sendTypeId_.Equals(other.sendTypeId_)) return false;
      if(!clientId_.Equals(other.clientId_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sendTypeId_.GetHashCode();
      hash ^= clientId_.GetHashCode();
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
      sendTypeId_.WriteTo(output, _repeated_sendTypeId_codec);
      clientId_.WriteTo(output, _repeated_clientId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      sendTypeId_.WriteTo(ref output, _repeated_sendTypeId_codec);
      clientId_.WriteTo(ref output, _repeated_clientId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += sendTypeId_.CalculateSize(_repeated_sendTypeId_codec);
      size += clientId_.CalculateSize(_repeated_clientId_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SendTypeListRequest other) {
      if (other == null) {
        return;
      }
      sendTypeId_.Add(other.sendTypeId_);
      clientId_.Add(other.clientId_);
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
            sendTypeId_.AddEntriesFrom(input, _repeated_sendTypeId_codec);
            break;
          }
          case 18:
          case 16: {
            clientId_.AddEntriesFrom(input, _repeated_clientId_codec);
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
            sendTypeId_.AddEntriesFrom(ref input, _repeated_sendTypeId_codec);
            break;
          }
          case 18:
          case 16: {
            clientId_.AddEntriesFrom(ref input, _repeated_clientId_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SendTypeListResponse : pb::IMessage<SendTypeListResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SendTypeListResponse> _parser = new pb::MessageParser<SendTypeListResponse>(() => new SendTypeListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SendTypeListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.SendTypeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendTypeListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendTypeListResponse(SendTypeListResponse other) : this() {
      sendTypes_ = other.sendTypes_.Clone();
      failed_ = other.failed_;
      applicationErrors_ = other.applicationErrors_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendTypeListResponse Clone() {
      return new SendTypeListResponse(this);
    }

    /// <summary>Field number for the "sendTypes" field.</summary>
    public const int SendTypesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Training.App.SendTypeResponse> _repeated_sendTypes_codec
        = pb::FieldCodec.ForMessage(10, global::Training.App.SendTypeResponse.Parser);
    private readonly pbc::RepeatedField<global::Training.App.SendTypeResponse> sendTypes_ = new pbc::RepeatedField<global::Training.App.SendTypeResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Training.App.SendTypeResponse> SendTypes {
      get { return sendTypes_; }
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
      return Equals(other as SendTypeListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SendTypeListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sendTypes_.Equals(other.sendTypes_)) return false;
      if (Failed != other.Failed) return false;
      if(!applicationErrors_.Equals(other.applicationErrors_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sendTypes_.GetHashCode();
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
      sendTypes_.WriteTo(output, _repeated_sendTypes_codec);
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
      sendTypes_.WriteTo(ref output, _repeated_sendTypes_codec);
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
      size += sendTypes_.CalculateSize(_repeated_sendTypes_codec);
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
    public void MergeFrom(SendTypeListResponse other) {
      if (other == null) {
        return;
      }
      sendTypes_.Add(other.sendTypes_);
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
            sendTypes_.AddEntriesFrom(input, _repeated_sendTypes_codec);
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
            sendTypes_.AddEntriesFrom(ref input, _repeated_sendTypes_codec);
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

  public sealed partial class SendTypeResponse : pb::IMessage<SendTypeResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SendTypeResponse> _parser = new pb::MessageParser<SendTypeResponse>(() => new SendTypeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SendTypeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.SendTypeReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendTypeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendTypeResponse(SendTypeResponse other) : this() {
      sendTypeId_ = other.sendTypeId_;
      typeMessage_ = other.typeMessage_;
      clientId_ = other.clientId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendTypeResponse Clone() {
      return new SendTypeResponse(this);
    }

    /// <summary>Field number for the "sendTypeId" field.</summary>
    public const int SendTypeIdFieldNumber = 1;
    private int sendTypeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SendTypeId {
      get { return sendTypeId_; }
      set {
        sendTypeId_ = value;
      }
    }

    /// <summary>Field number for the "typeMessage" field.</summary>
    public const int TypeMessageFieldNumber = 2;
    private string typeMessage_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TypeMessage {
      get { return typeMessage_; }
      set {
        typeMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "clientId" field.</summary>
    public const int ClientIdFieldNumber = 3;
    private int clientId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ClientId {
      get { return clientId_; }
      set {
        clientId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SendTypeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SendTypeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SendTypeId != other.SendTypeId) return false;
      if (TypeMessage != other.TypeMessage) return false;
      if (ClientId != other.ClientId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SendTypeId != 0) hash ^= SendTypeId.GetHashCode();
      if (TypeMessage.Length != 0) hash ^= TypeMessage.GetHashCode();
      if (ClientId != 0) hash ^= ClientId.GetHashCode();
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
      if (SendTypeId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SendTypeId);
      }
      if (TypeMessage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TypeMessage);
      }
      if (ClientId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ClientId);
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
      if (SendTypeId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SendTypeId);
      }
      if (TypeMessage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TypeMessage);
      }
      if (ClientId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ClientId);
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
      if (SendTypeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SendTypeId);
      }
      if (TypeMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TypeMessage);
      }
      if (ClientId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ClientId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SendTypeResponse other) {
      if (other == null) {
        return;
      }
      if (other.SendTypeId != 0) {
        SendTypeId = other.SendTypeId;
      }
      if (other.TypeMessage.Length != 0) {
        TypeMessage = other.TypeMessage;
      }
      if (other.ClientId != 0) {
        ClientId = other.ClientId;
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
            SendTypeId = input.ReadInt32();
            break;
          }
          case 18: {
            TypeMessage = input.ReadString();
            break;
          }
          case 24: {
            ClientId = input.ReadInt32();
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
            SendTypeId = input.ReadInt32();
            break;
          }
          case 18: {
            TypeMessage = input.ReadString();
            break;
          }
          case 24: {
            ClientId = input.ReadInt32();
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
