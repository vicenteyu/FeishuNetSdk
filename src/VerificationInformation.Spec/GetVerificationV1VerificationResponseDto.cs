using Newtonsoft.Json;
namespace FeishuNetSdk.VerificationInformation.Spec;
/// <summary>
/// 获取认证信息 响应体
/// <para>获取企业主体名称、是否认证等信息。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=verification&version=v1&resource=verification&method=get)</para>
/// <para>接口ID：7155320694884614148</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/verification-v1/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fverification-v1%2fverification%2fget</para>
/// </summary>
public record GetVerificationV1VerificationResponseDto
{
    /// <summary>
    /// <para>认证信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("verification")]
    public VerificationSuffix? Verification { get; set; }

    public record VerificationSuffix
    {
        /// <summary>
        /// <para>企业主体名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>企业是否完成认证； true 表示已经完成认证，false 表示未认证</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("has_verification")]
        public bool? HasVerification { get; set; }
    }
}
