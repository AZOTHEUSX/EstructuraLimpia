

namespace HotelArquitectureClean.Piso.Application.Core
{
    public class ServiceResultPiso
    {
        public ServiceResultPiso() 
        {
            this.Success = true;
        }
        public string? Message { get; set; }
        public bool Success { get; set; }
        public dynamic? Result { get; set; }
    }
}
