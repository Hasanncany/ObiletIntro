using ObiletIntro.DataAccess.Abstracts;
using ObiletIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletIntro.Business;

public class PosDeviceManager
{
    private readonly IPosDeviceDal _posDeviceDal;
    public PosDeviceManager(IPosDeviceDal posDeviceDal)
    {
        _posDeviceDal = posDeviceDal;        
    }

    public List<PosDevices> GetAll()
    {
        return _posDeviceDal.GetAll();
    }

    public void Add(PosDevices posDevice)
    {
        _posDeviceDal.Add(posDevice);
    }

    public void Delete(int id)
    {
        _posDeviceDal.Delete(id);
    }

    public void Update(PosDevices posDevice)
    {
        _posDeviceDal.Update(posDevice);
    }
}
