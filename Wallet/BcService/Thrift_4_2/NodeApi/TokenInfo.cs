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
  public partial class TokenInfo : TBase
  {
    private byte[] _address;
    private string _code;
    private string _name;
    private string _totalSupply;
    private byte[] _owner;
    private int _transfersCount;
    private int _transactionsCount;
    private int _holdersCount;
    private TokenStandart _standart;

    public byte[] Address
    {
      get
      {
        return _address;
      }
      set
      {
        __isset.address = true;
        this._address = value;
      }
    }

    public string Code
    {
      get
      {
        return _code;
      }
      set
      {
        __isset.code = true;
        this._code = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public string TotalSupply
    {
      get
      {
        return _totalSupply;
      }
      set
      {
        __isset.totalSupply = true;
        this._totalSupply = value;
      }
    }

    public byte[] Owner
    {
      get
      {
        return _owner;
      }
      set
      {
        __isset.owner = true;
        this._owner = value;
      }
    }

    public int TransfersCount
    {
      get
      {
        return _transfersCount;
      }
      set
      {
        __isset.transfersCount = true;
        this._transfersCount = value;
      }
    }

    public int TransactionsCount
    {
      get
      {
        return _transactionsCount;
      }
      set
      {
        __isset.transactionsCount = true;
        this._transactionsCount = value;
      }
    }

    public int HoldersCount
    {
      get
      {
        return _holdersCount;
      }
      set
      {
        __isset.holdersCount = true;
        this._holdersCount = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="TokenStandart"/>
    /// </summary>
    public TokenStandart Standart
    {
      get
      {
        return _standart;
      }
      set
      {
        __isset.standart = true;
        this._standart = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool address;
      public bool code;
      public bool name;
      public bool totalSupply;
      public bool owner;
      public bool transfersCount;
      public bool transactionsCount;
      public bool holdersCount;
      public bool standart;
    }

    public TokenInfo() {
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
                Address = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Code = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                TotalSupply = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                Owner = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I32) {
                TransfersCount = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.I32) {
                TransactionsCount = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.I32) {
                HoldersCount = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.I32) {
                Standart = (TokenStandart)iprot.ReadI32();
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
        TStruct struc = new TStruct("TokenInfo");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Address != null && __isset.address) {
          field.Name = "address";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Address);
          oprot.WriteFieldEnd();
        }
        if (Code != null && __isset.code) {
          field.Name = "code";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Code);
          oprot.WriteFieldEnd();
        }
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (TotalSupply != null && __isset.totalSupply) {
          field.Name = "totalSupply";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(TotalSupply);
          oprot.WriteFieldEnd();
        }
        if (Owner != null && __isset.owner) {
          field.Name = "owner";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Owner);
          oprot.WriteFieldEnd();
        }
        if (__isset.transfersCount) {
          field.Name = "transfersCount";
          field.Type = TType.I32;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(TransfersCount);
          oprot.WriteFieldEnd();
        }
        if (__isset.transactionsCount) {
          field.Name = "transactionsCount";
          field.Type = TType.I32;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(TransactionsCount);
          oprot.WriteFieldEnd();
        }
        if (__isset.holdersCount) {
          field.Name = "holdersCount";
          field.Type = TType.I32;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(HoldersCount);
          oprot.WriteFieldEnd();
        }
        if (__isset.standart) {
          field.Name = "standart";
          field.Type = TType.I32;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Standart);
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
      StringBuilder __sb = new StringBuilder("TokenInfo(");
      bool __first = true;
      if (Address != null && __isset.address) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Address: ");
        __sb.Append(Address);
      }
      if (Code != null && __isset.code) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Code: ");
        __sb.Append(Code);
      }
      if (Name != null && __isset.name) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (TotalSupply != null && __isset.totalSupply) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TotalSupply: ");
        __sb.Append(TotalSupply);
      }
      if (Owner != null && __isset.owner) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Owner: ");
        __sb.Append(Owner);
      }
      if (__isset.transfersCount) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TransfersCount: ");
        __sb.Append(TransfersCount);
      }
      if (__isset.transactionsCount) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TransactionsCount: ");
        __sb.Append(TransactionsCount);
      }
      if (__isset.holdersCount) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("HoldersCount: ");
        __sb.Append(HoldersCount);
      }
      if (__isset.standart) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Standart: ");
        __sb.Append(Standart);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}