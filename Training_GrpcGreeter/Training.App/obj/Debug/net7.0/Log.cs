// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: log.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Training.App {

  /// <summary>Holder for reflection information generated from log.proto</summary>
  public static partial class LogReflection {

    #region Descriptor
    /// <summary>File descriptor for log.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cglsb2cucHJvdG8SA0xvZxoMY29tbW9uLnByb3RvImIKDkxvZ0xpc3RSZXF1",
            "ZXN0EhEKBWxvZ0lkGAEgAygFQgIQARIXCg9hY2NvbW1vZGF0aW9uSWQYAiAD",
            "KAUSEgoKc2VuZFR5cGVJZBgDIAMoBRIQCghjbGllbnRJZBgEIAMoBSJ2Cg9M",
            "b2dMaXN0UmVzcG9uc2USHgoEbG9ncxgBIAMoCzIQLkxvZy5Mb2dSZXNwb25z",
            "ZRIOCgZmYWlsZWQYAiABKAgSMwoRYXBwbGljYXRpb25FcnJvcnMYAyADKAsy",
            "GC5Db21tb24uQXBwbGljYXRpb25FcnJvciJsCgtMb2dSZXNwb25zZRINCgVs",
            "b2dJZBgBIAEoBRIXCg9hY2NvbW1vZGF0aW9uSWQYAiABKAUSEgoKc2VuZFR5",
            "cGVJZBgDIAEoBRIQCghjbGllbnRJZBgEIAEoBRIPCgdtZXNzYWdlGAUgASgJ",
            "Qg+qAgxUcmFpbmluZy5BcHBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Training.App.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.LogListRequest), global::Training.App.LogListRequest.Parser, new[]{ "LogId", "AccommodationId", "SendTypeId", "ClientId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.LogListResponse), global::Training.App.LogListResponse.Parser, new[]{ "Logs", "Failed", "ApplicationErrors" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Training.App.LogResponse), global::Training.App.LogResponse.Parser, new[]{ "LogId", "AccommodationId", "SendTypeId", "ClientId", "Message" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LogListRequest : pb::IMessage<LogListRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogListRequest> _parser = new pb::MessageParser<LogListRequest>(() => new LogListRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogListRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.LogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogListRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogListRequest(LogListRequest other) : this() {
      logId_ = other.logId_.Clone();
      accommodationId_ = other.accommodationId_.Clone();
      sendTypeId_ = other.sendTypeId_.Clone();
      clientId_ = other.clientId_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogListRequest Clone() {
      return new LogListRequest(this);
    }

    /// <summary>Field number for the "logId" field.</summary>
    public const int LogIdFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_logId_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> logId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> LogId {
      get { return logId_; }
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

    /// <summary>Field number for the "sendTypeId" field.</summary>
    public const int SendTypeIdFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_sendTypeId_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> sendTypeId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> SendTypeId {
      get { return sendTypeId_; }
    }

    /// <summary>Field number for the "clientId" field.</summary>
    public const int ClientIdFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_clientId_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> clientId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> ClientId {
      get { return clientId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LogListRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogListRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!logId_.Equals(other.logId_)) return false;
      if(!accommodationId_.Equals(other.accommodationId_)) return false;
      if(!sendTypeId_.Equals(other.sendTypeId_)) return false;
      if(!clientId_.Equals(other.clientId_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= logId_.GetHashCode();
      hash ^= accommodationId_.GetHashCode();
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
      logId_.WriteTo(output, _repeated_logId_codec);
      accommodationId_.WriteTo(output, _repeated_accommodationId_codec);
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
      logId_.WriteTo(ref output, _repeated_logId_codec);
      accommodationId_.WriteTo(ref output, _repeated_accommodationId_codec);
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
      size += logId_.CalculateSize(_repeated_logId_codec);
      size += accommodationId_.CalculateSize(_repeated_accommodationId_codec);
      size += sendTypeId_.CalculateSize(_repeated_sendTypeId_codec);
      size += clientId_.CalculateSize(_repeated_clientId_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LogListRequest other) {
      if (other == null) {
        return;
      }
      logId_.Add(other.logId_);
      accommodationId_.Add(other.accommodationId_);
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
            logId_.AddEntriesFrom(input, _repeated_logId_codec);
            break;
          }
          case 18:
          case 16: {
            accommodationId_.AddEntriesFrom(input, _repeated_accommodationId_codec);
            break;
          }
          case 26:
          case 24: {
            sendTypeId_.AddEntriesFrom(input, _repeated_sendTypeId_codec);
            break;
          }
          case 34:
          case 32: {
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
            logId_.AddEntriesFrom(ref input, _repeated_logId_codec);
            break;
          }
          case 18:
          case 16: {
            accommodationId_.AddEntriesFrom(ref input, _repeated_accommodationId_codec);
            break;
          }
          case 26:
          case 24: {
            sendTypeId_.AddEntriesFrom(ref input, _repeated_sendTypeId_codec);
            break;
          }
          case 34:
          case 32: {
            clientId_.AddEntriesFrom(ref input, _repeated_clientId_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class LogListResponse : pb::IMessage<LogListResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogListResponse> _parser = new pb::MessageParser<LogListResponse>(() => new LogListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.LogReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogListResponse(LogListResponse other) : this() {
      logs_ = other.logs_.Clone();
      failed_ = other.failed_;
      applicationErrors_ = other.applicationErrors_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogListResponse Clone() {
      return new LogListResponse(this);
    }

    /// <summary>Field number for the "logs" field.</summary>
    public const int LogsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Training.App.LogResponse> _repeated_logs_codec
        = pb::FieldCodec.ForMessage(10, global::Training.App.LogResponse.Parser);
    private readonly pbc::RepeatedField<global::Training.App.LogResponse> logs_ = new pbc::RepeatedField<global::Training.App.LogResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Training.App.LogResponse> Logs {
      get { return logs_; }
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
      return Equals(other as LogListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!logs_.Equals(other.logs_)) return false;
      if (Failed != other.Failed) return false;
      if(!applicationErrors_.Equals(other.applicationErrors_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= logs_.GetHashCode();
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
      logs_.WriteTo(output, _repeated_logs_codec);
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
      logs_.WriteTo(ref output, _repeated_logs_codec);
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
      size += logs_.CalculateSize(_repeated_logs_codec);
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
    public void MergeFrom(LogListResponse other) {
      if (other == null) {
        return;
      }
      logs_.Add(other.logs_);
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
            logs_.AddEntriesFrom(input, _repeated_logs_codec);
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
            logs_.AddEntriesFrom(ref input, _repeated_logs_codec);
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

  public sealed partial class LogResponse : pb::IMessage<LogResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogResponse> _parser = new pb::MessageParser<LogResponse>(() => new LogResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Training.App.LogReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogResponse(LogResponse other) : this() {
      logId_ = other.logId_;
      accommodationId_ = other.accommodationId_;
      sendTypeId_ = other.sendTypeId_;
      clientId_ = other.clientId_;
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogResponse Clone() {
      return new LogResponse(this);
    }

    /// <summary>Field number for the "logId" field.</summary>
    public const int LogIdFieldNumber = 1;
    private int logId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LogId {
      get { return logId_; }
      set {
        logId_ = value;
      }
    }

    /// <summary>Field number for the "accommodationId" field.</summary>
    public const int AccommodationIdFieldNumber = 2;
    private int accommodationId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AccommodationId {
      get { return accommodationId_; }
      set {
        accommodationId_ = value;
      }
    }

    /// <summary>Field number for the "sendTypeId" field.</summary>
    public const int SendTypeIdFieldNumber = 3;
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
    public const int ClientIdFieldNumber = 4;
    private int clientId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ClientId {
      get { return clientId_; }
      set {
        clientId_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 5;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LogResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LogId != other.LogId) return false;
      if (AccommodationId != other.AccommodationId) return false;
      if (SendTypeId != other.SendTypeId) return false;
      if (ClientId != other.ClientId) return false;
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LogId != 0) hash ^= LogId.GetHashCode();
      if (AccommodationId != 0) hash ^= AccommodationId.GetHashCode();
      if (SendTypeId != 0) hash ^= SendTypeId.GetHashCode();
      if (ClientId != 0) hash ^= ClientId.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
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
      if (LogId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(LogId);
      }
      if (AccommodationId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(AccommodationId);
      }
      if (SendTypeId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SendTypeId);
      }
      if (ClientId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ClientId);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Message);
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
      if (LogId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(LogId);
      }
      if (AccommodationId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(AccommodationId);
      }
      if (SendTypeId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SendTypeId);
      }
      if (ClientId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ClientId);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Message);
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
      if (LogId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LogId);
      }
      if (AccommodationId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AccommodationId);
      }
      if (SendTypeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SendTypeId);
      }
      if (ClientId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ClientId);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LogResponse other) {
      if (other == null) {
        return;
      }
      if (other.LogId != 0) {
        LogId = other.LogId;
      }
      if (other.AccommodationId != 0) {
        AccommodationId = other.AccommodationId;
      }
      if (other.SendTypeId != 0) {
        SendTypeId = other.SendTypeId;
      }
      if (other.ClientId != 0) {
        ClientId = other.ClientId;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
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
            LogId = input.ReadInt32();
            break;
          }
          case 16: {
            AccommodationId = input.ReadInt32();
            break;
          }
          case 24: {
            SendTypeId = input.ReadInt32();
            break;
          }
          case 32: {
            ClientId = input.ReadInt32();
            break;
          }
          case 42: {
            Message = input.ReadString();
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
            LogId = input.ReadInt32();
            break;
          }
          case 16: {
            AccommodationId = input.ReadInt32();
            break;
          }
          case 24: {
            SendTypeId = input.ReadInt32();
            break;
          }
          case 32: {
            ClientId = input.ReadInt32();
            break;
          }
          case 42: {
            Message = input.ReadString();
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