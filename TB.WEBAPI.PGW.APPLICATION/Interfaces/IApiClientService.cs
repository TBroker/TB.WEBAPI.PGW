using TB.WEBAPI.PGW.APPLICATION.DTOs;

namespace TB.WEBAPI.PGW.APPLICATION.Interfaces
{
    public interface IApiClientService
    {
        Task<ApiResponseDto<TResponse>> GetAsync<TResponse>(string clientName, string endpoint);

        Task<ApiResponseDto<TResponse>> PostAsync<TRequest, TResponse>(string clientName, string endpoint, TRequest request);

        Task<ApiResponseDto<TResponse>> PostAsync<TResponse>(string clientName, string endpoint);
    }
}