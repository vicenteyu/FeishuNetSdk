namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新背调自定义字段 请求体
/// <para>更新用户在发起背调时的自定义字段。更新操作不支持更新自定义字段类型，只允许更新字段名称，且将影响已发起的背调表单展示。</para>
/// <para>接口ID：7195815976042594306</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check_custom_field/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check_custom_field%2fbatch_update</para>
/// </summary>
public record PatchHireV1EcoBackgroundCheckCustomFieldsBatchUpdateBodyDto
{
    /// <summary>
    /// <para>背调账号 ID，可在「账号绑定」事件中获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6995842370159937061</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义字段列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("custom_field_list")]
    public EcoBackgroundCheckCustomFieldData[] CustomFieldLists { get; set; } = Array.Empty<EcoBackgroundCheckCustomFieldData>();

    /// <summary>
    /// <para>自定义字段列表</para>
    /// </summary>
    public record EcoBackgroundCheckCustomFieldData
    {
        /// <summary>
        /// <para>自定义字段类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：text</para>
        /// <para>可选值：<list type="bullet">
        /// <item>text：单行文本，最多100个汉字</item>
        /// <item>textarea：多行文本，最多200个汉字</item>
        /// <item>number：数字</item>
        /// <item>boolean：布尔</item>
        /// <item>select：单选</item>
        /// <item>multiselect：多选</item>
        /// <item>date：日期</item>
        /// <item>file：附件</item>
        /// <item>resume：候选人简历</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段的标识，在同一账号内唯一</para>
        /// <para>必填：是</para>
        /// <para>示例值：candidate_resume</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段的名称，用户在安排背调表单看到的控件标题</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n Name { get; set; } = new();

        /// <summary>
        /// <para>自定义字段的名称，用户在安排背调表单看到的控件标题</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// <para>自定义字段的描述，如果是输入控件，为用户在安排背调表单看到的 placeholder 或 提示文字</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n? Description { get; set; }

        /// <summary>
        /// <para>type 为 select 或 multiselect 时必填，单选或多选的选项</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("options")]
        public EcoBackgroundCheckCustomFieldDataOption[]? Options { get; set; }

        /// <summary>
        /// <para>type 为 select 或 multiselect 时必填，单选或多选的选项</para>
        /// </summary>
        public record EcoBackgroundCheckCustomFieldDataOption
        {
            /// <summary>
            /// <para>选项的 key</para>
            /// <para>必填：是</para>
            /// <para>示例值：A</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>选项的名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n Name { get; set; } = new();

            /// <summary>
            /// <para>选项的名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }
    }
}
