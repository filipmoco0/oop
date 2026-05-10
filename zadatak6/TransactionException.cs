using System;

namespace Zadatak6;

public class TransactionException : Exception
{
    public TransactionException(string poruka) : base(poruka)
    {
    }
}
