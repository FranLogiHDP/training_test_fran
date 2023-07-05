// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: clientSendType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Training.App {

  /// <summary>Holder for reflection information generated from clientSendType.proto</summary>
  public static partial class ClientSendTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for clientSendType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientSendTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRjbGllbnRTZW5kVHlwZS5wcm90bxIOQ2xpZW50U2VuZFR5cGUaDGNvbW1v",
            "bi5wcm90byJFChlDbGllbnRTZW5kVHlwZUxpc3RSZXF1ZXN0EhYKCnNlbmRU",
            "eXBlSWQYASADKAVCAhABEhAKCGNsaWVudElkGAIgAygFIqIBChpDbGllbnRT",
            "ZW5kVHlwZUxpc3RSZXNwb25zZRI/Cg9jbGllbnRTZW5kVHlwZXMYASADKAsy",
            "Ji5DbGllbnRTZW5kVHlwZS5DbGllbnRTZW5kVHlwZVJlc3BvbnNlEg4KBmZh",
            "aWxlZBgCIAEoCBIzChFhcHBsaWNhdGlvbkVycm9ycxgDIAMoCzIYLkNvbW1v",
            "bi5BcHBsaWNhdGlvbkVycm9yIlgKFkNsaWVudFNlbmRUeXBlUmVzcG9uc2US",
            "GAoQY2xpZW50U2VuZFR5cGVJZBgBIAEoBRISCgpzZW5kVHlwZUlkGAIgASgF",
            "EhAKCGNsaWVudElkGAMgASgFQg+qAgxUcmFpbmluZy5BcHBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Training.App.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.ClientSendTypeListRequest), global::Training.App.ClientSendTypeListRequest.Parser, new[]{ "SendTypeId", "ClientId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.ClientSendTypeListResponse), global::Training.App.ClientSendTypeListResponse.Parser, new[]{ "ClientSendTypes", "Failed", "ApplicationErrors" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.ClientSendTypeResponse), global::Training.App.ClientSendTypeResponse.Parser, new[]{ "ClientSendTypeId", "SendTypeId", "ClientId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientSendTypeListRequest : pb::IMessage<ClientSendTypeListRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientSendTypeListRequest> _parser = new pb::MessageParser<ClientSendTypeListRequest>(() => new ClientSendTypeListRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientSendTypeListRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.ClientSendTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSendTypeListRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSendTypeListRequest(ClientSendTypeListRequest other) : this() {
      sendTypeId_ = other.sendTypeId_.Clone();
      clientId_ = other.clientId_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSendTypeListRequest Clone() {
      return new ClientSendTypeListRequest(this);
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
      return Equals(other as ClientSendTypeListRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientSendTypeListRequest other) {
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
    public void MergeFrom(ClientSendTypeListRequest other) {
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

  public sealed partial class ClientSendTypeListResponse : pb::IMessage<ClientSendTypeListResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientSendTypeListResponse> _parser = new pb::MessageParser<ClientSendTypeListResponse>(() => new ClientSendTypeListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientSendTypeListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.ClientSendTypeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSendTypeListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSendTypeListResponse(ClientSendTypeListResponse other) : this() {
      clientSendTypes_ = other.clientSendTypes_.Clone();
      failed_ = other.failed_;
      applicationErrors_ = other.applicationErrors_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSendTypeListResponse Clone() {
      return new ClientSendTypeListResponse(this);
    }

    /// <summary>Field number for the "clientSendTypes" field.</summary>
    public const int ClientSendTypesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Training.App.ClientSendTypeResponse> _repeated_clientSendTypes_codec
        = pb::FieldCodec.ForMessage(10, global::Training.App.ClientSendTypeResponse.Parser);
    private readonly pbc::RepeatedField<global::Training.App.ClientSendTypeResponse> clientSendTypes_ = new pbc::RepeatedField<global::Training.App.ClientSendTypeResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Training.App.ClientSendTypeResponse> ClientSendTypes {
      get { return clientSendTypes_; }
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
      return Equals(other as ClientSendTypeListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientSendTypeListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!clientSendTypes_.Equals(other.clientSendTypes_)) return false;
      if (Failed != other.Failed) return false;
      if(!applicationErrors_.Equals(other.applicationErrors_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= clientSendTypes_.GetHashCode();
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
      clientSendTypes_.WriteTo(output, _repeated_clientSendTypes_codec);
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
      clientSendTypes_.WriteTo(ref output, _repeated_clientSendTypes_codec);
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
      size += clientSendTypes_.CalculateSize(_repeated_clientSendTypes_codec);
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
    public void MergeFrom(ClientSendTypeListResponse other) {
      if (other == null) {
        return;
      }
      clientSendTypes_.Add(other.clientSendTypes_);
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
            clientSendTypes_.AddEntriesFrom(input, _repeated_clientSendTypes_codec);
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
            clientSendTypes_.AddEntriesFrom(ref input, _repeated_clientSendTypes_codec);
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

  public sealed partial class ClientSendTypeResponse : pb::IMessage<ClientSendTypeResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientSendTypeResponse> _parser = new pb::MessageParser<ClientSendTypeResponse>(() => new ClientSendTypeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientSendTypeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.ClientSendTypeReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSendTypeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSendTypeResponse(ClientSendTypeResponse other) : this() {
      clientSendTypeId_ = other.clientSendTypeId_;
      sendTypeId_ = other.sendTypeId_;
      clientId_ = other.clientId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSendTypeResponse Clone() {
      return new ClientSendTypeResponse(this);
    }

    /// <summary>Field number for the "clientSendTypeId" field.</summary>
    public const int ClientSendTypeIdFieldNumber = 1;
    private int clientSendTypeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ClientSendTypeId {
      get { return clientSendTypeId_; }
      set {
        clientSendTypeId_ = value;
      }
    }

    /// <summary>Field number for the "sendTypeId" field.</summary>
    public const int SendTypeIdFieldNumber = 2;
    private int sendTypeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SendTypeId {
      get { return sendTypeId_; }
      set {
        sendTypeId_ = value;
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
      return Equals(other as ClientSendTypeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientSendTypeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientSendTypeId != other.ClientSendTypeId) return false;
      if (SendTypeId != other.SendTypeId) return false;
      if (ClientId != other.ClientId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientSendTypeId != 0) hash ^= ClientSendTypeId.GetHashCode();
      if (SendTypeId != 0) hash ^= SendTypeId.GetHashCode();
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
      if (ClientSendTypeId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ClientSendTypeId);
      }
      if (SendTypeId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SendTypeId);
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
      if (ClientSendTypeId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ClientSendTypeId);
      }
      if (SendTypeId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SendTypeId);
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
      if (ClientSendTypeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ClientSendTypeId);
      }
      if (SendTypeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SendTypeId);
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
    public void MergeFrom(ClientSendTypeResponse other) {
      if (other == null) {
        return;
      }
      if (other.ClientSendTypeId != 0) {
        ClientSendTypeId = other.ClientSendTypeId;
      }
      if (other.SendTypeId != 0) {
        SendTypeId = other.SendTypeId;
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
            ClientSendTypeId = input.ReadInt32();
            break;
          }
          case 16: {
            SendTypeId = input.ReadInt32();
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
            ClientSendTypeId = input.ReadInt32();
            break;
          }
          case 16: {
            SendTypeId = input.ReadInt32();
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
