using ObiletIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletIntro.DataAccess.Abstracts;

public interface IPosDeviceDal
{
    List<PosDevices> GetAll();
    void Add(PosDevices device);
    void Delete(int id);
    void Update(PosDevices device);
}
