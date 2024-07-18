using ObiletIntro.Business;
using ObiletIntro.DataAccess.Concretes;
using ObiletIntro.Entities;

PosDeviceManager posDeviceManager = new(new DomesticPosDevicesDal());

List<PosDevices> domesticPosDevices = posDeviceManager.GetAll();

for (int i = 0; i < domesticPosDevices.Count; i++)
{
    Console.WriteLine(domesticPosDevices[i].Name + " / " + domesticPosDevices[i].Commission);
}