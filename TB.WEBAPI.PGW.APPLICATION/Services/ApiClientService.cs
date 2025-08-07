using Microsoft.Extensions.Logging;
using System.Net;
using System.Text;
using System.Text.Json;
using TB.WEBAPI.PGW.APPLICATION.DTOs;
using TB.WEBAPI.PGW.APPLICATION.Interfaces;

namespace TB.WEBAPI.PGW.APPLICATION.Services
{
    public class ApiClientService(IHttpClientFactory httpClientFactory, ILogger<ApiClientService> logger) : IApiClientService
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;
        private readonly ILogger<ApiClientService> _logger = logger;

        public async Task<ApiResponseDto<TResponse>> GetAsync<TResponse>(string clientName, string endpoint)
        {
            try
            {
                var client = _httpClientFactory.CreateClient(clientName);
                var response = await client.GetAsync(endpoint);
                var content = await response.Content.ReadAsStringAsync();

                var apiResponse = new ApiResponseDto<TResponse>
                {
                    Status = response.IsSuccessStatusCode ? "success" : "error",
                    Code = (int)response.StatusCode,
                    Message = response.IsSuccessStatusCode ? "Request completed successfully." : "An error occurred.",
                    Timestamp = DateTime.UtcNow.ToString("o"),
                    Data = response.IsSuccessStatusCode ? JsonSerializer.Deserialize<TResponse>(content) : default
                };

                return apiResponse;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request for {Endpoint}", endpoint);                
                return new ApiResponseDto<TResponse>()
                {
                    Code = (int)HttpStatusCode.InternalServerError,
                    Message = "An error occurred while processing the request.",
                    Status = "error",
                    Timestamp = DateTime.UtcNow.ToString("o"),
                    Data = default,
                };
            }
        }

        public async Task<ApiResponseDto<TResponse>> PostAsync<TRequest, TResponse>(string clientName, string endpoint, TRequest request)
        {
            try
            {
                var client = _httpClientFactory.CreateClient(clientName);
                var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endpoint, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                var apiResponse = new ApiResponseDto<TResponse>
                {
                    Status = response.IsSuccessStatusCode ? "success" : "error",
                    Code = (int)response.StatusCode,
                    Message = response.IsSuccessStatusCode ? "Request completed successfully." : "An error occurred.",
                    Timestamp = DateTime.UtcNow.ToString("o"),
                    Data = response.IsSuccessStatusCode ? JsonSerializer.Deserialize<TResponse>(responseContent) : default,
                };

                return apiResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request for {Endpoint}", endpoint);
                return new ApiResponseDto<TResponse>()
                {
                    Code = (int)HttpStatusCode.InternalServerError,
                    Message = "An error occurred while processing the request.",
                    Status = "error",
                    Timestamp = DateTime.UtcNow.ToString("o"),
                    Data = default,
                };
            }
        }

        public async Task<ApiResponseDto<TResponse>> PostAsync<TResponse>(string clientName, string endpoint)
        {
            try
            {
                var client = _httpClientFactory.CreateClient(clientName);
                var content = new StringContent("", Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endpoint, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                var apiResponse = new ApiResponseDto<TResponse>
                {
                    Status = response.IsSuccessStatusCode ? "success" : "error",
                    Code = (int)response.StatusCode,
                    Message = response.IsSuccessStatusCode ? "Request completed successfully." : "An error occurred.",
                    Timestamp = DateTime.UtcNow.ToString("o"),
                    Data = response.IsSuccessStatusCode ? JsonSerializer.Deserialize<TResponse>(responseContent) : default,
                };

                return apiResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request for {Endpoint}", endpoint);
                return new ApiResponseDto<TResponse>()
                {
                    Code = (int)HttpStatusCode.InternalServerError,
                    Message = "An error occurred while processing the request.",
                    Status = "error",
                    Timestamp = DateTime.UtcNow.ToString("o"),
                    Data = default,
                };
            }
        }
    }
}