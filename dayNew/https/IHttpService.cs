using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDetection.https
{
    public interface IHttpService
    {
        /// <summary>
        /// Get访问WebAPI
        /// </summary>
        /// <param name="url">网页地址</param>
        /// <returns>访问失败返回错误原因，正确返回Json结果</returns>
        Task<TResponse> GetAsync<TResponse>(string url) where TResponse : class;

        /// <summary>
        /// Post访问WebAPI
        /// </summary>
        /// <param name="url">网页地址</param>
        /// <returns>访问失败返回错误原因，正确返回Json结果</returns>
        Task<TResponse> PostAsync<TResponse>(string url, object Param) where TResponse : class;
    }
}
