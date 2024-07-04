

namespace HotelArquitectureClean.Piso.Application.Core
{
    public class ServiceResultRecepcion
    {
        public ServiceResultRecepcion() 
        {
            this.Success = true;
        }
        public string? Message { get; set; }
        public bool Success { get; set; }
        public dynamic? Result { get; set; }
    }
}
