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
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NodeApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SmartContractCompileResult : TBase
  {
    private APIResponse _status;
    private List<ByteCodeObject> _byteCodeObjects;
    private TokenStandart _ts;

    public APIResponse Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }

    public List<ByteCodeObject> ByteCodeObjects
    {
      get
      {
        return _byteCodeObjects;
      }
      set
      {
        __isset.byteCodeObjects = true;
        this._byteCodeObjects = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="TokenStandart"/>
    /// </summary>
    public TokenStandart Ts
    {
      get
      {
        return _ts;
      }
      set
      {
        __isset.ts = true;
        this._ts = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool status;
      public bool byteCodeObjects;
      public bool ts;
    }

    public SmartContractCompileResult() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Struct) {
                Status = new APIResponse();
                Status.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  ByteCodeObjects = new List<ByteCodeObject>();
                  TList _list71 = iprot.ReadListBegin();
                  for( int _i72 = 0; _i72 < _list71.Count; ++_i72)
                  {
                    ByteCodeObject _elem73;
                    _elem73 = new ByteCodeObject();
                    _elem73.Read(iprot);
                    ByteCodeObjects.Add(_elem73);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                Ts = (TokenStandart)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("SmartContractCompileResult");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Status != null && __isset.status) {
          field.Name = "status";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Status.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (ByteCodeObjects != null && __isset.byteCodeObjects) {
          field.Name = "byteCodeObjects";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, ByteCodeObjects.Count));
            foreach (ByteCodeObject _iter74 in ByteCodeObjects)
            {
              _iter74.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.ts) {
          field.Name = "ts";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Ts);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("SmartContractCompileResult(");
      bool __first = true;
      if (Status != null && __isset.status) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Status: ");
        __sb.Append(Status== null ? "<null>" : Status.ToString());
      }
      if (ByteCodeObjects != null && __isset.byteCodeObjects) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ByteCodeObjects: ");
        __sb.Append(ByteCodeObjects);
      }
      if (__isset.ts) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ts: ");
        __sb.Append(Ts);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}