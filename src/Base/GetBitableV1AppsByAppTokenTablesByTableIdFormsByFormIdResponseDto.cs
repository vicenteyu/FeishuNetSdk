using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 获取表单元数据 响应体
/// <para>获取表单的所有元数据项</para>
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
    [JsonProperty("form")]
    public AppTableForm Form { get; set; } = new();

    /// <summary>
    /// <para>表单元数据信息</para>
    /// </summary>
    public record AppTableForm
    {
        /// <summary>
        /// <para>表单名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：表单</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>表单描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：表单描述</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>是否开启共享</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("shared")]
        public bool? Shared { get; set; }

        /// <summary>
        /// <para>分享 URL</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://bytedance.feishu.cn/share/base/shrcnCy1KAlpahNotmhRn1abcde</para>
        /// </summary>
        [JsonProperty("shared_url")]
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
        [JsonProperty("shared_limit")]
        public string? SharedLimit { get; set; }

        /// <summary>
        /// <para>填写次数限制一次</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("submit_limit_once")]
        public bool? SubmitLimitOnce { get; set; }
    }
}
