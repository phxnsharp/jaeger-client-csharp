/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;


namespace Jaeger.Thrift.Agent
{

  public partial class SamplingStrategyResponse : TBase
  {
    private ProbabilisticSamplingStrategy _probabilisticSampling;
    private RateLimitingSamplingStrategy _rateLimitingSampling;
    private PerOperationSamplingStrategies _operationSampling;

    /// <summary>
    /// 
    /// <seealso cref="SamplingStrategyType"/>
    /// </summary>
    public SamplingStrategyType StrategyType { get; set; }

    public ProbabilisticSamplingStrategy ProbabilisticSampling
    {
      get
      {
        return _probabilisticSampling;
      }
      set
      {
        __isset.probabilisticSampling = true;
        this._probabilisticSampling = value;
      }
    }

    public RateLimitingSamplingStrategy RateLimitingSampling
    {
      get
      {
        return _rateLimitingSampling;
      }
      set
      {
        __isset.rateLimitingSampling = true;
        this._rateLimitingSampling = value;
      }
    }

    public PerOperationSamplingStrategies OperationSampling
    {
      get
      {
        return _operationSampling;
      }
      set
      {
        __isset.operationSampling = true;
        this._operationSampling = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool probabilisticSampling;
      public bool rateLimitingSampling;
      public bool operationSampling;
    }

    public SamplingStrategyResponse()
    {
    }

    public SamplingStrategyResponse(SamplingStrategyType strategyType) : this()
    {
      this.StrategyType = strategyType;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_strategyType = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                StrategyType = (SamplingStrategyType)await iprot.ReadI32Async(cancellationToken);
                isset_strategyType = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                ProbabilisticSampling = new ProbabilisticSamplingStrategy();
                await ProbabilisticSampling.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                RateLimitingSampling = new RateLimitingSamplingStrategy();
                await RateLimitingSampling.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Struct)
              {
                OperationSampling = new PerOperationSamplingStrategies();
                await OperationSampling.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_strategyType)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("SamplingStrategyResponse");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "strategyType";
        field.Type = TType.I32;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async((int)StrategyType, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (ProbabilisticSampling != null && __isset.probabilisticSampling)
        {
          field.Name = "probabilisticSampling";
          field.Type = TType.Struct;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await ProbabilisticSampling.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (RateLimitingSampling != null && __isset.rateLimitingSampling)
        {
          field.Name = "rateLimitingSampling";
          field.Type = TType.Struct;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await RateLimitingSampling.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (OperationSampling != null && __isset.operationSampling)
        {
          field.Name = "operationSampling";
          field.Type = TType.Struct;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await OperationSampling.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder("SamplingStrategyResponse(");
      sb.Append(", StrategyType: ");
      sb.Append(StrategyType);
      if (ProbabilisticSampling != null && __isset.probabilisticSampling)
      {
        sb.Append(", ProbabilisticSampling: ");
        sb.Append(ProbabilisticSampling== null ? "<null>" : ProbabilisticSampling.ToString());
      }
      if (RateLimitingSampling != null && __isset.rateLimitingSampling)
      {
        sb.Append(", RateLimitingSampling: ");
        sb.Append(RateLimitingSampling== null ? "<null>" : RateLimitingSampling.ToString());
      }
      if (OperationSampling != null && __isset.operationSampling)
      {
        sb.Append(", OperationSampling: ");
        sb.Append(OperationSampling== null ? "<null>" : OperationSampling.ToString());
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
