using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新自定义字段选项 响应体
/// <para>根据一个自定义字段的GUID和其选项的GUID，更新该选项的数据。要更新的字段必须是单选或者多选类型，且要更新的字段必须归属于该字段。</para>
/// <para>更新时，将`update_fields`字段中填写所有要修改的任务字段名，同时在`option`字段中填写要修改的字段的新值即可。`update_fields`支持的字段包括：</para>
/// <para>* `name`:  选项名称</para>
/// <para>* `color_index`: 选项的颜色索引值</para>
/// <para>* `is_hidden`: 是否从界面上隐藏</para>
/// <para>* `insert_before`: 将当前option放到同字段某个option之前的那个option_guid。</para>
/// <para>* `insert_after`: 将当前option放到同字段某个option之后的那个option_guid。</para>
/// <para>接口ID：7270765454292221954</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field-option/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field-option%2fpatch</para>
/// </summary>
public record PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidResponseDto
{
    /// <summary>
    /// <para>更新后的option数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("option")]
    public PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidResponseDtoOption? Option { get; set; }

    /// <summary>
    /// <para>更新后的option数据</para>
    /// </summary>
    public record PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidResponseDtoOption
    {
        /// <summary>
        /// <para>选项的GUID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4216f79b-3fda-4dc6-a0c4-a16022e47152</para>
        /// </summary>
        [JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>选项名称，不能为空，最大50个字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：高优</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>选项的颜色索引值，可以是0～54中的一个数字。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("color_index")]
        public int? ColorIndex { get; set; }

        /// <summary>
        /// <para>选项是否隐藏。隐藏后的选项在界面不可见，也不可以再通过openapi将字段值设为该选项。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("is_hidden")]
        public bool? IsHidden { get; set; }
    }
}
