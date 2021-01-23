using System;

namespace Patterns.Behavioral.Memento.Interfaces
{
    public interface IWideMemento : INarrowMemento
    {
        (string, DateTime) GetState();
    }
}