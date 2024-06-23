// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetVerificationV1VerificationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取认证信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.VerificationInformation.Spec;
/// <summary>
/// 获取认证信息 响应体
/// <para>获取企业主体名称、是否认证等信息。</para>
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
    [JsonPropertyName("verification")]
    public VerificationSuffix? Verification { get; set; }

    /// <summary></summary>
    public record VerificationSuffix
    {
        /// <summary>
        /// <para>企业主体名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>企业是否完成认证； true 表示已经完成认证，false 表示未认证</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("has_verification")]
        public bool? HasVerification { get; set; }
    }
}
