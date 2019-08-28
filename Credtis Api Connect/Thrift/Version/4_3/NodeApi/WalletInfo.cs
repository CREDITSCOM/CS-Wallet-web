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
  public partial class WalletInfo : TBase
  {
    private byte[] _address;
    private Amount _balance;
    private long _transactionsNumber;
    private long _firstTransactionTime;

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

    public Amount Balance
    {
      get
      {
        return _balance;
      }
      set
      {
        __isset.balance = true;
        this._balance = value;
      }
    }

    public long TransactionsNumber
    {
      get
      {
        return _transactionsNumber;
      }
      set
      {
        __isset.transactionsNumber = true;
        this._transactionsNumber = value;
      }
    }

    public long FirstTransactionTime
    {
      get
      {
        return _firstTransactionTime;
      }
      set
      {
        __isset.firstTransactionTime = true;
        this._firstTransactionTime = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool address;
      public bool balance;
      public bool transactionsNumber;
      public bool firstTransactionTime;
    }

    public WalletInfo() {
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
              if (field.Type == TType.Struct) {
                Balance = new Amount();
                Balance.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I64) {
                TransactionsNumber = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I64) {
                FirstTransactionTime = iprot.ReadI64();
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
        TStruct struc = new TStruct("WalletInfo");
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
        if (Balance != null && __isset.balance) {
          field.Name = "balance";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          Balance.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.transactionsNumber) {
          field.Name = "transactionsNumber";
          field.Type = TType.I64;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(TransactionsNumber);
          oprot.WriteFieldEnd();
        }
        if (__isset.firstTransactionTime) {
          field.Name = "firstTransactionTime";
          field.Type = TType.I64;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(FirstTransactionTime);
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
      StringBuilder __sb = new StringBuilder("WalletInfo(");
      bool __first = true;
      if (Address != null && __isset.address) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Address: ");
        __sb.Append(Address);
      }
      if (Balance != null && __isset.balance) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Balance: ");
        __sb.Append(Balance== null ? "<null>" : Balance.ToString());
      }
      if (__isset.transactionsNumber) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TransactionsNumber: ");
        __sb.Append(TransactionsNumber);
      }
      if (__isset.firstTransactionTime) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("FirstTransactionTime: ");
        __sb.Append(FirstTransactionTime);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
