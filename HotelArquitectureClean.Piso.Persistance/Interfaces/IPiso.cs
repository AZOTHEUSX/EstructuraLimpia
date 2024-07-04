using HotelMonolitic.Web.Data.Models;
using System;

public interface IPiso
{
    List<PisoGetModel> pisoGetModels();
    PisoGetModel pisoGetModels(int IdPiso);
    void Save(PisoSaveModel piso);
    void UpdatePiso(PisoUpdateModel pisoUpdate);
    void DeletePiso(PisoDeleteModel pisoDelete);
}

