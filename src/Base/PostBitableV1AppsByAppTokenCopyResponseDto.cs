using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 复制多维表格 响应体
/// <para>复制一个多维表格，可以指定复制到某个有权限的文件夹下</para>
/// <para>接口ID：7205776220394160156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcopy</para>
/// </summary>
public record PostBitableV1AppsByAppTokenCopyResponseDto
{
    /// <summary>
    /// <para>返回响应体</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("app")]
    public PostBitableV1AppsByAppTokenCopyResponseDtoApp? App { get; set; }

    /// <summary>
    /// <para>返回响应体</para>
    /// </summary>
    public record PostBitableV1AppsByAppTokenCopyResponseDtoApp
    {
        /// <summary>
        /// <para>多维表格的 app_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：S404b*****e9PQsYDWYcNryFn0g</para>
        /// </summary>
        [JsonProperty("app_token")]
        public string? AppToken { get; set; }

        /// <summary>
        /// <para>多维表格的名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：一篇新的多维表格</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多维表格 App 归属文件夹</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldbco*****CIMltVc</para>
        /// </summary>
        [JsonProperty("folder_token")]
        public string? FolderToken { get; set; }

        /// <summary>
        /// <para>多维表格 App URL</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/base/S404b*****e9PQsYDWYcNryFn0g</para>
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>默认的表格id</para>
        /// <para>必填：否</para>
        /// <para>示例值："" //只有创建才返回默认表Id</para>
        /// </summary>
        [JsonProperty("default_table_id")]
        public string? DefaultTableId { get; set; }

        /// <summary>
        /// <para>文档时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonProperty("time_zone")]
        public string? TimeZone { get; set; }
    }
}
