// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: force_control/force_control.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Gemini.Forcecontrol {
  public static partial class ForceControl
  {
    static readonly string __ServiceName = "gemini.forcecontrol.ForceControl";

    static readonly grpc::Marshaller<global::Gemini.Forcecontrol.ForceRequest> __Marshaller_gemini_forcecontrol_ForceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gemini.Forcecontrol.ForceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Gemini.Forcecontrol.ForceResponse> __Marshaller_gemini_forcecontrol_ForceResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gemini.Forcecontrol.ForceResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Gemini.Forcecontrol.ForceRequest, global::Gemini.Forcecontrol.ForceResponse> __Method_ApplyForce = new grpc::Method<global::Gemini.Forcecontrol.ForceRequest, global::Gemini.Forcecontrol.ForceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ApplyForce",
        __Marshaller_gemini_forcecontrol_ForceRequest,
        __Marshaller_gemini_forcecontrol_ForceResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Gemini.Forcecontrol.ForceControlReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ForceControl</summary>
    [grpc::BindServiceMethod(typeof(ForceControl), "BindService")]
    public abstract partial class ForceControlBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Gemini.Forcecontrol.ForceResponse> ApplyForce(global::Gemini.Forcecontrol.ForceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ForceControl</summary>
    public partial class ForceControlClient : grpc::ClientBase<ForceControlClient>
    {
      /// <summary>Creates a new client for ForceControl</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ForceControlClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ForceControl that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ForceControlClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ForceControlClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ForceControlClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Gemini.Forcecontrol.ForceResponse ApplyForce(global::Gemini.Forcecontrol.ForceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ApplyForce(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Gemini.Forcecontrol.ForceResponse ApplyForce(global::Gemini.Forcecontrol.ForceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ApplyForce, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Gemini.Forcecontrol.ForceResponse> ApplyForceAsync(global::Gemini.Forcecontrol.ForceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ApplyForceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Gemini.Forcecontrol.ForceResponse> ApplyForceAsync(global::Gemini.Forcecontrol.ForceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ApplyForce, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ForceControlClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ForceControlClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ForceControlBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ApplyForce, serviceImpl.ApplyForce).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ForceControlBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ApplyForce, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Gemini.Forcecontrol.ForceRequest, global::Gemini.Forcecontrol.ForceResponse>(serviceImpl.ApplyForce));
    }

  }
}
#endregion
