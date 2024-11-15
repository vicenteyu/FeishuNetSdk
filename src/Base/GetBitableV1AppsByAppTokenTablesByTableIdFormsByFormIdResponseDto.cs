// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取表单元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 获取表单元数据 响应体
/// <para>获取表单的所有元数据，包括表单名称、描述、是否共享等。</para>
/// <para>接口ID：7119425455108685852</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form%2fget</para>
/// </summary>
public record GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdResponseDto
{
    /// <summary>
    /// <para>表单元数据信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("form")]
    public AppTableForm Form { get; set; } = new();

    /// <summary>
    /// <para>表单元数据信息</para>
    /// </summary>
    public record AppTableForm
    {
        /// <summary>
        /// <para>表单名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：文档问题反馈</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>表单描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：请详细描述开发中遇到的问题，并附上问题截图</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>是否开启表单分享，使表单支持填写。可选值：</para>
        /// <para>- true：支持填写</para>
        /// <para>- false：不支持填写</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("shared")]
        public bool? Shared { get; set; }

        /// <summary>
        /// <para>分享 URL 链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/share/base/shrcnCy1KAlpahNotmhRn1abcde</para>
        /// </summary>
        [JsonPropertyName("shared_url")]
        public string? SharedUrl { get; set; }

        /// <summary>
        /// <para>分享范围限制</para>
        /// <para>必填：否</para>
        /// <para>示例值：tenant_editable</para>
        /// <para>可选值：<list type="bullet">
        /// <item>off：仅邀请的人可填写</item>
        /// <item>tenant_editable：组织内获得链接的人可填写</item>
        /// <item>anyone_editable：互联网上获得链接的人可填写</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("shared_limit")]
        public string? SharedLimit { get; set; }

        /// <summary>
        /// <para>是否将填写次数限制为一次。可选值：</para>
        /// <para>- true：设置表单仅支持填写一次</para>
        /// <para>- false：不限制表单填写次数</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("submit_limit_once")]
        public bool? SubmitLimitOnce { get; set; }
    }
}
