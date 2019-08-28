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

namespace NodeApi_4_3
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SmartContractDataResult : TBase
  {
    private APIResponse _status;
    private List<SmartContractMethod> _methods;
    private Dictionary<string, Variant> _variables;

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

    public List<SmartContractMethod> Methods
    {
      get
      {
        return _methods;
      }
      set
      {
        __isset.methods = true;
        this._methods = value;
      }
    }

    public Dictionary<string, Variant> Variables
    {
      get
      {
        return _variables;
      }
      set
      {
        __isset.variables = true;
        this._variables = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool status;
      public bool methods;
      public bool variables;
    }

    public SmartContractDataResult() {
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
                  Methods = new List<SmartContractMethod>();
                  TList _list70 = iprot.ReadListBegin();
                  for( int _i71 = 0; _i71 < _list70.Count; ++_i71)
                  {
                    SmartContractMethod _elem72;
                    _elem72 = new SmartContractMethod();
                    _elem72.Read(iprot);
                    Methods.Add(_elem72);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Map) {
                {
                  Variables = new Dictionary<string, Variant>();
                  TMap _map73 = iprot.ReadMapBegin();
                  for( int _i74 = 0; _i74 < _map73.Count; ++_i74)
                  {
                    string _key75;
                    Variant _val76;
                    _key75 = iprot.ReadString();
                    _val76 = new Variant();
                    _val76.Read(iprot);
                    Variables[_key75] = _val76;
                  }
                  iprot.ReadMapEnd();
                }
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
        TStruct struc = new TStruct("SmartContractDataResult");
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
        if (Methods != null && __isset.methods) {
          field.Name = "methods";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Methods.Count));
            foreach (SmartContractMethod _iter77 in Methods)
            {
              _iter77.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Variables != null && __isset.variables) {
          field.Name = "variables";
          field.Type = TType.Map;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.Struct, Variables.Count));
            foreach (string _iter78 in Variables.Keys)
            {
              oprot.WriteString(_iter78);
              Variables[_iter78].Write(oprot);
            }
            oprot.WriteMapEnd();
          }
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
      StringBuilder __sb = new StringBuilder("SmartContractDataResult(");
      bool __first = true;
      if (Status != null && __isset.status) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Status: ");
        __sb.Append(Status== null ? "<null>" : Status.ToString());
      }
      if (Methods != null && __isset.methods) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Methods: ");
        __sb.Append(Methods);
      }
      if (Variables != null && __isset.variables) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Variables: ");
        __sb.Append(Variables);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
