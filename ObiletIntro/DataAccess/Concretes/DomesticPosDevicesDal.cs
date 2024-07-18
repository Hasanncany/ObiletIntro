using ObiletIntro.DataAccess.Abstracts;
using ObiletIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletIntro.DataAccess.Concretes;

public class DomesticPosDevicesDal : IPosDeviceDal
{
    List<PosDevices> _posDevices;
    public DomesticPosDevicesDal()
    {
        PosDevices domesticPosDevices1 = new PosDevices();
        domesticPosDevices1.Id = 1;
        domesticPosDevices1.Name = "Halkbank";
        domesticPosDevices1.Commission = 1.17;

        PosDevices domesticPosDevices2 = new PosDevices();
        domesticPosDevices2.Id = 2;
        domesticPosDevices2.Name = "Akbank";
        domesticPosDevices2.Commission = 1.13;

        PosDevices domesticPosDevices3 = new PosDevices();
        domesticPosDevices3.Id = 3;
        domesticPosDevices3.Name = "Garanti";
        domesticPosDevices3.Commission = 1.24;

        _posDevices = new List<PosDevices> { domesticPosDevices1, domesticPosDevices2, domesticPosDevices3 };
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
