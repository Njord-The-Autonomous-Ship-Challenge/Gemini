// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: force_control/force_control.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Gemini.Forcecontrol {

  /// <summary>Holder for reflection information generated from force_control/force_control.proto</summary>
  public static partial class ForceControlReflection {

    #region Descriptor
    /// <summary>File descriptor for force_control/force_control.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForceControlReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFmb3JjZV9jb250cm9sL2ZvcmNlX2NvbnRyb2wucHJvdG8SE2dlbWluaS5m",
            "b3JjZWNvbnRyb2wiVAoQR2VuZXJhbGl6ZWRGb3JjZRIJCgF4GAEgASgCEgkK",
            "AXkYAiABKAISCQoBehgDIAEoAhIJCgFrGAQgASgCEgkKAW0YBSABKAISCQoB",
            "bhgGIAEoAiJhCgxGb3JjZVJlcXVlc3QSEAoIdmVzc2VsSWQYASABKAkSPwoQ",
            "Z2VuZXJhbGl6ZWRGb3JjZRgCIAEoCzIlLmdlbWluaS5mb3JjZWNvbnRyb2wu",
            "R2VuZXJhbGl6ZWRGb3JjZSIgCg1Gb3JjZVJlc3BvbnNlEg8KB3N1Y2Nlc3MY",
            "ASABKAgyZQoMRm9yY2VDb250cm9sElUKCkFwcGx5Rm9yY2USIS5nZW1pbmku",
            "Zm9yY2Vjb250cm9sLkZvcmNlUmVxdWVzdBoiLmdlbWluaS5mb3JjZWNvbnRy",
            "b2wuRm9yY2VSZXNwb25zZSIAQi4KFmlvLmdlbWluaS5mb3JjZWNvbnRyb2xC",
            "DEZvcmNlQ29udHJvbFABogIDSExXYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Gemini.Forcecontrol.GeneralizedForce), global::Gemini.Forcecontrol.GeneralizedForce.Parser, new[]{ "X", "Y", "Z", "K", "M", "N" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Gemini.Forcecontrol.ForceRequest), global::Gemini.Forcecontrol.ForceRequest.Parser, new[]{ "VesselId", "GeneralizedForce" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Gemini.Forcecontrol.ForceResponse), global::Gemini.Forcecontrol.ForceResponse.Parser, new[]{ "Success" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GeneralizedForce : pb::IMessage<GeneralizedForce> {
    private static readonly pb::MessageParser<GeneralizedForce> _parser = new pb::MessageParser<GeneralizedForce>(() => new GeneralizedForce());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GeneralizedForce> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gemini.Forcecontrol.ForceControlReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeneralizedForce() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeneralizedForce(GeneralizedForce other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      k_ = other.k_;
      m_ = other.m_;
      n_ = other.n_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeneralizedForce Clone() {
      return new GeneralizedForce(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private float z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "k" field.</summary>
    public const int KFieldNumber = 4;
    private float k_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float K {
      get { return k_; }
      set {
        k_ = value;
      }
    }

    /// <summary>Field number for the "m" field.</summary>
    public const int MFieldNumber = 5;
    private float m_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float M {
      get { return m_; }
      set {
        m_ = value;
      }
    }

    /// <summary>Field number for the "n" field.</summary>
    public const int NFieldNumber = 6;
    private float n_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float N {
      get { return n_; }
      set {
        n_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GeneralizedForce);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GeneralizedForce other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(K, other.K)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(M, other.M)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(N, other.N)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
      if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
      if (Z != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
      if (K != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(K);
      if (M != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(M);
      if (N != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(N);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Y);
      }
      if (Z != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Z);
      }
      if (K != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(K);
      }
      if (M != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(M);
      }
      if (N != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(N);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (Z != 0F) {
        size += 1 + 4;
      }
      if (K != 0F) {
        size += 1 + 4;
      }
      if (M != 0F) {
        size += 1 + 4;
      }
      if (N != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GeneralizedForce other) {
      if (other == null) {
        return;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.Z != 0F) {
        Z = other.Z;
      }
      if (other.K != 0F) {
        K = other.K;
      }
      if (other.M != 0F) {
        M = other.M;
      }
      if (other.N != 0F) {
        N = other.N;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            X = input.ReadFloat();
            break;
          }
          case 21: {
            Y = input.ReadFloat();
            break;
          }
          case 29: {
            Z = input.ReadFloat();
            break;
          }
          case 37: {
            K = input.ReadFloat();
            break;
          }
          case 45: {
            M = input.ReadFloat();
            break;
          }
          case 53: {
            N = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ForceRequest : pb::IMessage<ForceRequest> {
    private static readonly pb::MessageParser<ForceRequest> _parser = new pb::MessageParser<ForceRequest>(() => new ForceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ForceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gemini.Forcecontrol.ForceControlReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForceRequest(ForceRequest other) : this() {
      vesselId_ = other.vesselId_;
      generalizedForce_ = other.generalizedForce_ != null ? other.generalizedForce_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForceRequest Clone() {
      return new ForceRequest(this);
    }

    /// <summary>Field number for the "vesselId" field.</summary>
    public const int VesselIdFieldNumber = 1;
    private string vesselId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VesselId {
      get { return vesselId_; }
      set {
        vesselId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "generalizedForce" field.</summary>
    public const int GeneralizedForceFieldNumber = 2;
    private global::Gemini.Forcecontrol.GeneralizedForce generalizedForce_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Gemini.Forcecontrol.GeneralizedForce GeneralizedForce {
      get { return generalizedForce_; }
      set {
        generalizedForce_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ForceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ForceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VesselId != other.VesselId) return false;
      if (!object.Equals(GeneralizedForce, other.GeneralizedForce)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (VesselId.Length != 0) hash ^= VesselId.GetHashCode();
      if (generalizedForce_ != null) hash ^= GeneralizedForce.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (VesselId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(VesselId);
      }
      if (generalizedForce_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GeneralizedForce);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (VesselId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VesselId);
      }
      if (generalizedForce_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GeneralizedForce);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ForceRequest other) {
      if (other == null) {
        return;
      }
      if (other.VesselId.Length != 0) {
        VesselId = other.VesselId;
      }
      if (other.generalizedForce_ != null) {
        if (generalizedForce_ == null) {
          GeneralizedForce = new global::Gemini.Forcecontrol.GeneralizedForce();
        }
        GeneralizedForce.MergeFrom(other.GeneralizedForce);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            VesselId = input.ReadString();
            break;
          }
          case 18: {
            if (generalizedForce_ == null) {
              GeneralizedForce = new global::Gemini.Forcecontrol.GeneralizedForce();
            }
            input.ReadMessage(GeneralizedForce);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ForceResponse : pb::IMessage<ForceResponse> {
    private static readonly pb::MessageParser<ForceResponse> _parser = new pb::MessageParser<ForceResponse>(() => new ForceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ForceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gemini.Forcecontrol.ForceControlReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForceResponse(ForceResponse other) : this() {
      success_ = other.success_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForceResponse Clone() {
      return new ForceResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ForceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ForceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ForceResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
