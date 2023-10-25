using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建账号自定义字段 请求体
/// <para>定制用户在服务商处的身份标示字段（如用户在服务商处的租户 ID）。用户在飞书招聘后台添加帐号后，系统会推送「帐号绑定」事件给开发者，事件将携带用户填写的自定义字段信息，开发者可根据此信息识别飞书招聘用户在服务商处的身份信息，完成飞书招聘用户和服务商帐号的绑定，并以此来推送对应的套餐或试卷列表等。 可多次推送，多次推送为覆盖逻辑。</para>
/// <para>接口ID：7195815979079581697</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_account_custom_field/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_account_custom_field%2fcreate</para>
/// </summary>
public record PostHireV1EcoAccountCustomFieldsBodyDto
{
    /// <summary>
    /// <para>适用范围</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：背调</item>
    /// <item>2：笔试</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("scope")]
    public int Scope { get; set; }

    /// <summary>
    /// <para>自定义字段列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("custom_field_list")]
    public EcoAccountCustomFieldData[] CustomFieldLists { get; set; } = Array.Empty<EcoAccountCustomFieldData>();

    /// <summary>
    /// <para>自定义字段列表</para>
    /// </summary>
    public record EcoAccountCustomFieldData
    {
        /// <summary>
        /// <para>自定义字段的标识，同一 scope 内须唯一</para>
        /// <para>必填：是</para>
        /// <para>示例值：org_id</para>
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段的名称，用户在添加账号表单看到的控件标题</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n Name { get; set; } = new();

        /// <summary>
        /// <para>自定义字段的名称，用户在添加账号表单看到的控件标题</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonProperty("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonProperty("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// <para>自定义字段的描述，用户在添加账号表单看到的 place holder</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("description")]
        public I18n? Description { get; set; }
    }
}
