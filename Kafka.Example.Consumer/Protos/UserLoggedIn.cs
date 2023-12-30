// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UserLoggedIn.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Kafka.Example.Consumer.Protos {

  /// <summary>Holder for reflection information generated from UserLoggedIn.proto</summary>
  public static partial class UserLoggedInReflection {

    #region Descriptor
    /// <summary>File descriptor for UserLoggedIn.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserLoggedInReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJVc2VyTG9nZ2VkSW4ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3Rh",
            "bXAucHJvdG8iZAoOUGVyc29uTG9nZ2VkSW4SEAoIVXNlck5hbWUYASABKAkS",
            "MAoMTG9nZ2VkSW5EYXRlGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVz",
            "dGFtcBIOCgZVc2VySWQYAyABKAVCIKoCHUthZmthLkV4YW1wbGUuQ29uc3Vt",
            "ZXIuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Kafka.Example.Consumer.Protos.PersonLoggedIn), global::Kafka.Example.Consumer.Protos.PersonLoggedIn.Parser, new[]{ "UserName", "LoggedInDate", "UserId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PersonLoggedIn : pb::IMessage<PersonLoggedIn>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PersonLoggedIn> _parser = new pb::MessageParser<PersonLoggedIn>(() => new PersonLoggedIn());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PersonLoggedIn> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Kafka.Example.Consumer.Protos.UserLoggedInReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersonLoggedIn() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersonLoggedIn(PersonLoggedIn other) : this() {
      userName_ = other.userName_;
      loggedInDate_ = other.loggedInDate_ != null ? other.loggedInDate_.Clone() : null;
      userId_ = other.userId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersonLoggedIn Clone() {
      return new PersonLoggedIn(this);
    }

    /// <summary>Field number for the "UserName" field.</summary>
    public const int UserNameFieldNumber = 1;
    private string userName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LoggedInDate" field.</summary>
    public const int LoggedInDateFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp loggedInDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LoggedInDate {
      get { return loggedInDate_; }
      set {
        loggedInDate_ = value;
      }
    }

    /// <summary>Field number for the "UserId" field.</summary>
    public const int UserIdFieldNumber = 3;
    private int userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PersonLoggedIn);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PersonLoggedIn other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserName != other.UserName) return false;
      if (!object.Equals(LoggedInDate, other.LoggedInDate)) return false;
      if (UserId != other.UserId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (loggedInDate_ != null) hash ^= LoggedInDate.GetHashCode();
      if (UserId != 0) hash ^= UserId.GetHashCode();
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
      if (UserName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserName);
      }
      if (loggedInDate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LoggedInDate);
      }
      if (UserId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(UserId);
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
      if (UserName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserName);
      }
      if (loggedInDate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LoggedInDate);
      }
      if (UserId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(UserId);
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
      if (UserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (loggedInDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LoggedInDate);
      }
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PersonLoggedIn other) {
      if (other == null) {
        return;
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.loggedInDate_ != null) {
        if (loggedInDate_ == null) {
          LoggedInDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LoggedInDate.MergeFrom(other.LoggedInDate);
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
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
          case 10: {
            UserName = input.ReadString();
            break;
          }
          case 18: {
            if (loggedInDate_ == null) {
              LoggedInDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LoggedInDate);
            break;
          }
          case 24: {
            UserId = input.ReadInt32();
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
            UserName = input.ReadString();
            break;
          }
          case 18: {
            if (loggedInDate_ == null) {
              LoggedInDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LoggedInDate);
            break;
          }
          case 24: {
            UserId = input.ReadInt32();
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
