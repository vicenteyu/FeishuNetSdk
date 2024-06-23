// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchAcsV1UsersByUserIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改用户部分信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Acs.Spec;
/// <summary>
/// 修改用户部分信息 请求体
/// <para>飞书智能门禁在人脸识别成功后会有韦根信号输出，输出用户的卡号。</para>
/// <para>对于使用韦根协议的门禁系统，企业可使用该接口录入用户卡号。</para>
/// <para>接口ID：6979790924691963906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/user/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fuser%2fpatch</para>
/// </summary>
public record PatchAcsV1UsersByUserIdBodyDto
{
    /// <summary>
    /// <para>用户特征</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("feature")]
    public FeatureSuffix? Feature { get; set; }

    /// <summary></summary>
    public record FeatureSuffix
    {
        /// <summary>
        /// <para>卡号</para>
        /// <para>**示例值**：123456</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("card")]
        public int? Card { get; set; }
    }
}
