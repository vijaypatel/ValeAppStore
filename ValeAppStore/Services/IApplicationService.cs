using System;
namespace ValeAppStore
{
    public interface IApplicationService
    {
        void LaunchApp(string packageName);

        bool IsInstalled(string packageName);
    }
}

