using System.Collections.Generic;
using System.Linq;

namespace Zextia.Services
{
    /// <summary>
    /// Representa o resultado de uma operação de serviço sem retorno de dados
    /// </summary>
    public class ServiceResult
    {
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public List<string> Errors { get; private set; }

        protected ServiceResult(bool success, string message, List<string> errors)
        {
            Success = success;
            Message = message;
            Errors = errors ?? new List<string>();
        }

        public static ServiceResult Ok(string message = null)
        {
            return new ServiceResult(true, message, null);
        }

        public static ServiceResult Fail(string error)
        {
            return new ServiceResult(false, null, new List<string> { error });
        }

        public static ServiceResult Fail(List<string> errors)
        {
            return new ServiceResult(false, null, errors);
        }
    }

    /// <summary>
    /// Representa o resultado de uma operação de serviço com retorno de dados
    /// </summary>
    /// <typeparam name="T">Tipo de dados retornado</typeparam>
    public class ServiceResult<T> : ServiceResult
    {
        public T Data { get; private set; }

        private ServiceResult(bool success, T data, string message, List<string> errors)
            : base(success, message, errors)
        {
            Data = data;
        }

        public static ServiceResult<T> Ok(T data, string message = null)
        {
            return new ServiceResult<T>(true, data, message, null);
        }

        public new static ServiceResult<T> Fail(string error)
        {
            return new ServiceResult<T>(false, default(T), null, new List<string> { error });
        }

        public new static ServiceResult<T> Fail(List<string> errors)
        {
            return new ServiceResult<T>(false, default(T), null, errors);
        }
    }
}
