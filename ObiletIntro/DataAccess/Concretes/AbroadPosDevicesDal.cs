using ObiletIntro.DataAccess.Abstracts;
using ObiletIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletIntro.DataAccess.Concretes;

internal class AbroadPosDevicesDal : IPosDeviceDal
{
    List<PosDevices> _posDevices;
    public AbroadPosDevicesDal()
    {
        PosDevices abroadPosDevices1 = new PosDevices();
        abroadPosDevices1.Id = 1;
        abroadPosDevices1.Name = "Halkbank";
        abroadPosDevices1.Commission = 1.67;

        PosDevices abroadPosDevices2 = new PosDevices();
        abroadPosDevices2.Id = 1;
        abroadPosDevices2.Name = "City Bank";
        abroadPosDevices2.Commission = 1.83;

        PosDevices abroadPosDevices3 = new PosDevices();
        abroadPosDevices3.Id = 1;
        abroadPosDevices3.Name = "HTBC";
        abroadPosDevices3.Commission = 1.44;

        _posDevices = new List<PosDevices> { abroadPosDevices1, abroadPosDevices2, abroadPosDevices3 };
    }


    public List<PosDevices> GetAll()
    {
        return _posDevices;
    }

    public void Add(PosDevices device)
    {
        _posDevices.Add(device);
    }

    public void Delete(int id)
    {
        Console.WriteLine("Pos cihazı silindi.");
    }

    public void Update(PosDevices device)
    {
        Console.WriteLine("Pos cihazı güncellendi.");
    }
}
