// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1OfferApplicationFormsByOfferApplicationFormIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 Offer 申请表模板信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取 Offer 申请表模板信息 响应体
/// <para>获取 Offer 申请表模板信息。</para>
/// <para>接口ID：7081627245290651652</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_application_form/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer_application_form%2fget</para>
/// </summary>
public record GetHireV1OfferApplicationFormsByOfferApplicationFormIdResponseDto
{
    /// <summary>
    /// <para>Offer 申请表详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offer_apply_form")]
    public OfferApplyFormInfo? OfferApplyForm { get; set; }

    /// <summary>
    /// <para>Offer 申请表详情</para>
    /// </summary>
    public record OfferApplyFormInfo
    {
        /// <summary>
        /// <para>offer申请表 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：23746823748</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>offer申请表名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>offer申请表名称</para>
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
        /// <para>schema 信息，用于描述申请表单结构的元数据定义，即对申请表内容的描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("schema")]
        public OfferApplyFormSchema? Schema { get; set; }

        /// <summary>
        /// <para>schema 信息，用于描述申请表单结构的元数据定义，即对申请表内容的描述</para>
        /// </summary>
        public record OfferApplyFormSchema
        {
            /// <summary>
            /// <para>schema ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7080465990618843430</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>模块列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("module_list")]
            public OfferApplyFormModuleInfo[]? ModuleLists { get; set; }

            /// <summary>
            /// <para>模块列表</para>
            /// </summary>
            public record OfferApplyFormModuleInfo
            {
                /// <summary>
                /// <para>模块 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：23746823748</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>模块名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>模块名称</para>
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
                /// <para>是否为自定义模块</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_customized")]
                public bool? IsCustomized { get; set; }

                /// <summary>
                /// <para>模块状态是否启用</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：已启用</item>
                /// <item>2：已停用</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("active_status")]
                public int? ActiveStatus { get; set; }

                /// <summary>
                /// <para>模块填写提示</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("hint")]
                public I18n? Hint { get; set; }

                /// <summary>
                /// <para>字段列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("object_list")]
                public OfferApplyFormObjectInfo[]? ObjectLists { get; set; }

                /// <summary>
                /// <para>字段列表</para>
                /// </summary>
                public record OfferApplyFormObjectInfo
                {
                    /// <summary>
                    /// <para>字段 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：23847293234</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>字段名称</para>
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
                    /// <para>字段描述</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("description")]
                    public I18n? Description { get; set; }

                    /// <summary>
                    /// <para>所属模块 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：23847293234</para>
                    /// </summary>
                    [JsonPropertyName("module_id")]
                    public string? ModuleId { get; set; }

                    /// <summary>
                    /// <para>是否为自定义字段</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_customized")]
                    public bool? IsCustomized { get; set; }

                    /// <summary>
                    /// <para>是否必填</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_required")]
                    public bool? IsRequired { get; set; }

                    /// <summary>
                    /// <para>是否启用</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：已启用</item>
                    /// <item>2：已停用</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("active_status")]
                    public int? ActiveStatus { get; set; }

                    /// <summary>
                    /// <para>是否修改后需审批</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("need_approve")]
                    public bool? NeedApprove { get; set; }

                    /// <summary>
                    /// <para>是否敏感</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_sensitive")]
                    public bool? IsSensitive { get; set; }

                    /// <summary>
                    /// <para>字段类型枚举</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：单行文本</item>
                    /// <item>2：多行文本</item>
                    /// <item>3：单选</item>
                    /// <item>4：多选</item>
                    /// <item>5：日期</item>
                    /// <item>6：月份选择</item>
                    /// <item>7：年份选择</item>
                    /// <item>8：数字</item>
                    /// <item>9：金额</item>
                    /// <item>10：公式</item>
                    /// <item>11：默认字段</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("object_type")]
                    public int? ObjectType { get; set; }

                    /// <summary>
                    /// <para>配置信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("config")]
                    public OfferApplyFormObjectConfigInfo? Config { get; set; }

                    /// <summary>
                    /// <para>配置信息</para>
                    /// </summary>
                    public record OfferApplyFormObjectConfigInfo
                    {
                        /// <summary>
                        /// <para>选项信息</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("options")]
                        public OfferApplyFormConfigOptionInfo[]? Options { get; set; }

                        /// <summary>
                        /// <para>选项信息</para>
                        /// </summary>
                        public record OfferApplyFormConfigOptionInfo
                        {
                            /// <summary>
                            /// <para>选项 ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：2378568265</para>
                            /// </summary>
                            [JsonPropertyName("id")]
                            public string? Id { get; set; }

                            /// <summary>
                            /// <para>选项名称</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("name")]
                            public I18n? Name { get; set; }

                            /// <summary>
                            /// <para>选项名称</para>
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
                            /// <para>选项描述</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("description")]
                            public I18n? Description { get; set; }
                        }

                        /// <summary>
                        /// <para>公式信息</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("formula")]
                        public OfferApplyFormConfigFormulaInfo? Formula { get; set; }

                        /// <summary>
                        /// <para>公式信息</para>
                        /// </summary>
                        public record OfferApplyFormConfigFormulaInfo
                        {
                            /// <summary>
                            /// <para>公式值</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：[object_id_1] + [object_id_2] * 12</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string? Value { get; set; }

                            /// <summary>
                            /// <para>公式结果类型枚举</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：金额</item>
                            /// <item>2：数字</item>
                            /// <item>3：百分比</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("result")]
                            public int? Result { get; set; }

                            /// <summary>
                            /// <para>公式额外描述</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("extra_map")]
                            public OfferApplyFormFormulaExtraMapInfo[]? ExtraMaps { get; set; }

                            /// <summary>
                            /// <para>公式额外描述</para>
                            /// </summary>
                            public record OfferApplyFormFormulaExtraMapInfo
                            {
                                /// <summary>
                                /// <para>object ID</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：object_id_1</para>
                                /// </summary>
                                [JsonPropertyName("key")]
                                public string? Key { get; set; }

                                /// <summary>
                                /// <para>object 名称</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("value")]
                                public I18n? Value { get; set; }

                                /// <summary>
                                /// <para>object 名称</para>
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

                        /// <summary>
                        /// <para>级联配置信息</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("object_display_config")]
                        public OfferApplyFormObjectDisplayConfigInfo? ObjectDisplayConfig { get; set; }

                        /// <summary>
                        /// <para>级联配置信息</para>
                        /// </summary>
                        public record OfferApplyFormObjectDisplayConfigInfo
                        {
                            /// <summary>
                            /// <para>展示条件枚举</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：全部满足</item>
                            /// <item>2：任一满足</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("display_condition")]
                            public int? DisplayCondition { get; set; }

                            /// <summary>
                            /// <para>字段条件配置</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("pre_object_config_list")]
                            public OfferApplyFormPreObjectConfigInfo[]? PreObjectConfigLists { get; set; }

                            /// <summary>
                            /// <para>字段条件配置</para>
                            /// </summary>
                            public record OfferApplyFormPreObjectConfigInfo
                            {
                                /// <summary>
                                /// <para>字段 ID</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：687529575</para>
                                /// </summary>
                                [JsonPropertyName("id")]
                                public string? Id { get; set; }

                                /// <summary>
                                /// <para>运算符枚举</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：1</para>
                                /// <para>可选值：<list type="bullet">
                                /// <item>1：等于</item>
                                /// <item>2：不等于</item>
                                /// <item>3：包含</item>
                                /// <item>4：不包含</item>
                                /// </list></para>
                                /// </summary>
                                [JsonPropertyName("operator")]
                                public int? Operator { get; set; }

                                /// <summary>
                                /// <para>字段值</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("value")]
                                public string[]? Value { get; set; }
                            }
                        }
                    }
                }
            }
        }
    }
}
