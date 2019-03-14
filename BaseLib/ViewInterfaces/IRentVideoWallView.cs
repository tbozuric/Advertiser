using System;
using DomainModel;

namespace BaseLib.ViewInterfaces
{
    public interface IRentVideoWallView : IView
    {
        Address Location { get; }
        string Oib { get; }
        string Name { get; }
        string Surname { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        float Price { get; }
    }
}