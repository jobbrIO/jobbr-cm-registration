using System;

namespace Jobbr.ComponentModel.Registration
{
    public interface IJobbrBuilder
    {
        void Register<T>(Type type);

        void Add<T>(object instance);
    }
}