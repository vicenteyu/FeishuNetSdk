using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 创建自定义任务选项 响应体
/// <para>为单选或多选字段添加一个自定义选项。一个单选/多选字段最大支持100个选项。</para>
/// <para>新添加的选项如果不隐藏，其名字不能和已存在的不隐藏选项的名字重复。</para>
/// <para>接口ID：7270765454292287490</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field-option/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field-option%2fcreate</para>
/// </summary>
public record PostTaskV2CustomFieldsByCustomFieldGuidOptionsResponseDto
{
    /// <summary>
    /// <para>创建的选项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("option")]
    public PostTaskV2CustomFieldsByCustomFieldGuidOptionsResponseDtoOption? Option { get; set; }

    /// <summary>
    /// <para>创建的选项</para>
    /// </summary>
    public record PostTaskV2CustomFieldsByCustomFieldGuidOptionsResponseDtoOption
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
        /// <para>选项的颜色索引值，可以是0～54中的一个数字。如果不填写则会随机选一个。</para>
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
