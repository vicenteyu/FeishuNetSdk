namespace FeishuNetSdk.Extensions;

/// <summary>
/// 分页响应体扩展方法
/// </summary>
public static class PaginationExtensions
{
    /// <summary>
    /// 获取所有分页记录
    /// </summary>
    /// <typeparam name="TRecord">分页数据项类型</typeparam>
    /// <typeparam name="TResponse">响应体类型</typeparam>
    /// <param name="apiCall">接口方法</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static async Task<List<TRecord>> GetAllPagesAsync<TRecord, TResponse>(
        this Func<string?, Task<FeishuResponse<TResponse>>> apiCall) where TResponse : IPageableResponse<TRecord>
    {
        var allRecords = new List<TRecord>();
        TResponse? data = default;
        do
        {
            var response = await apiCall(data?.PageToken);
            if (!response.IsSuccess)
            {
                throw new Exception(response.Msg);
            }
            if (response.Data is null)
            {
                throw new Exception("Response data is null.");
            }
            data = response.Data;
            allRecords.AddRange(data?.Items ?? []);
        }
        while (data?.HasMore == true && !string.IsNullOrEmpty(data?.PageToken));
        return allRecords;
    }
}
