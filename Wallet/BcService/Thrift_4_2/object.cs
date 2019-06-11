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


#if !SILVERLIGHT
[Serializable]
#endif
public partial class @object : TBase
{
  private string _nameClass;
  private byte[] _instance;

  public string NameClass
  {
    get
    {
      return _nameClass;
    }
    set
    {
      __isset.nameClass = true;
      this._nameClass = value;
    }
  }

  public byte[] Instance
  {
    get
    {
      return _instance;
    }
    set
    {
      __isset.instance = true;
      this._instance = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool nameClass;
    public bool instance;
  }

  public @object() {
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
            if (field.Type == TType.String) {
              NameClass = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Instance = iprot.ReadBinary();
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
      TStruct struc = new TStruct("object");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (NameClass != null && __isset.nameClass) {
        field.Name = "nameClass";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NameClass);
        oprot.WriteFieldEnd();
      }
      if (Instance != null && __isset.instance) {
        field.Name = "instance";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Instance);
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
    StringBuilder __sb = new StringBuilder("object(");
    bool __first = true;
    if (NameClass != null && __isset.nameClass) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("NameClass: ");
      __sb.Append(NameClass);
    }
    if (Instance != null && __isset.instance) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Instance: ");
      __sb.Append(Instance);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
