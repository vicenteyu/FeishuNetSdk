// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2025-07-02
// ************************************************************************
// <copyright file="GetHireV1OfferApplicationFormsByOfferApplicationFormIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 Offer 申请表信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取 Offer 申请表信息 响应体
/// <para>根据 Offer 申请表 ID 获取 Offer 申请表信息，可获取到的信息包括申请表名称、申请表模块、申请表字段等。</para>
/// <para>## Offer 申请表产品示意图</para>
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
        /// <para>Offer 申请表 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7190465990618843431</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>Offer 申请表名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>Offer 申请表名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：校招 Offer 申请表</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：campus offer application form</para>
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
                /// <para>示例值：7230465990618843432</para>
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
                    /// <para>中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：基础信息模块</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：basic info module</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>是否为自定义模块：</para>
                /// <para>- true：自定义模块</para>
                /// <para>- false：系统预置模块</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_customized")]
                public bool? IsCustomized { get; set; }

                /// <summary>
                /// <para>模块启用状态</para>
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
                    /// <para>示例值：7260465990618843426</para>
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
                        /// <para>中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：薪资总包字段</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：salary total package field</para>
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
                    /// <para>示例值：7230465990618843432</para>
                    /// </summary>
                    [JsonPropertyName("module_id")]
                    public string? ModuleId { get; set; }

                    /// <summary>
                    /// <para>是否为自定义字段：</para>
                    /// <para>- true：自定义字段</para>
                    /// <para>- false：系统预置字段</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_customized")]
                    public bool? IsCustomized { get; set; }

                    /// <summary>
                    /// <para>是否必填：</para>
                    /// <para>- true：必填</para>
                    /// <para>- false：非必填</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_required")]
                    public bool? IsRequired { get; set; }

                    /// <summary>
                    /// <para>字段启用状态</para>
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
                    /// <para>修改后是否需要审批：</para>
                    /// <para>- true：需要审批</para>
                    /// <para>- false：不需要审批</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("need_approve")]
                    public bool? NeedApprove { get; set; }

                    /// <summary>
                    /// <para>是否敏感字段（敏感字段会在发起 Offer 审批时隐藏）</para>
                    /// <para>- true：敏感字段</para>
                    /// <para>- false：非敏感字段</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_sensitive")]
                    public bool? IsSensitive { get; set; }

                    /// <summary>
                    /// <para>字段类型（废弃）</para>
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
                    /// <para>字段类型枚举</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：default</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>text：单行文本</item>
                    /// <item>long_text：多行文本</item>
                    /// <item>select：单选</item>
                    /// <item>multi_select：多选</item>
                    /// <item>date_select：日期选择</item>
                    /// <item>month_select：月份选择</item>
                    /// <item>year_select：年份选择</item>
                    /// <item>number：数字</item>
                    /// <item>amount：金额</item>
                    /// <item>formula：公式</item>
                    /// <item>boolean：布尔值</item>
                    /// <item>file：附件</item>
                    /// <item>personnel_select：人员单选</item>
                    /// <item>personnel_multi_select：人员多选</item>
                    /// <item>city_single_select：城市单选</item>
                    /// <item>corehr_text：单行文本（引用自人事）</item>
                    /// <item>corehr_long_text：多行文本（引用自人事）</item>
                    /// <item>corehr_select：单选（引用自人事）</item>
                    /// <item>corehr_multi_select：多选（引用自人事）</item>
                    /// <item>corehr_date_select：日期选择（引用自人事）</item>
                    /// <item>corehr_number：数字（引用自人事）</item>
                    /// <item>corehr_boolean：布尔值（引用自人事）</item>
                    /// <item>corehr_attachment：附件（引用自人事）</item>
                    /// <item>corehr_personnel_select：人员单选（引用自人事）</item>
                    /// <item>corehr_personnel_multi_select：人员多选（引用自人事）</item>
                    /// <item>default：默认字段</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("object_type_v2")]
                    public string? ObjectTypeV2 { get; set; }

                    /// <summary>
                    /// <para>字段配置信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("config")]
                    public OfferApplyFormObjectConfigInfo? Config { get; set; }

                    /// <summary>
                    /// <para>字段配置信息</para>
                    /// </summary>
                    public record OfferApplyFormObjectConfigInfo
                    {
                        /// <summary>
                        /// <para>选项信息，仅在在字段类型object_type_v2为单选、多选时有值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("options")]
                        public OfferApplyFormConfigOptionInfo[]? Options { get; set; }

                        /// <summary>
                        /// <para>选项信息，仅在在字段类型object_type_v2为单选、多选时有值</para>
                        /// </summary>
                        public record OfferApplyFormConfigOptionInfo
                        {
                            /// <summary>
                            /// <para>选项 ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：7551465990618843435</para>
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
                                /// <para>中文名称</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：全年薪资选项</para>
                                /// </summary>
                                [JsonPropertyName("zh_cn")]
                                public string? ZhCn { get; set; }

                                /// <summary>
                                /// <para>英文名称</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：annual salary option</para>
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
                        /// <para>公式信息，仅在在字段类型object_type_v2为公式时有值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("formula")]
                        public OfferApplyFormConfigFormulaInfo? Formula { get; set; }

                        /// <summary>
                        /// <para>公式信息，仅在在字段类型object_type_v2为公式时有值</para>
                        /// </summary>
                        public record OfferApplyFormConfigFormulaInfo
                        {
                            /// <summary>
                            /// <para>计算公式。由薪资字段ID、运算符组成，薪资字段来源于offer申请表-薪资信息模块，公式中包含的薪资字段具体信息通过同级字段extra_map获取。示例："( [6872592813776914699] * 12 + 20 / 2 ) / [6872592813776914699] + 2000"，其中6872592813776914699为薪资字段ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：[object_id] * 12</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string? Value { get; set; }

                            /// <summary>
                            /// <para>计算结果显示格式</para>
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
                            /// <para>公式字段信息</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("extra_map")]
                            public OfferApplyFormFormulaExtraMapInfo[]? ExtraMaps { get; set; }

                            /// <summary>
                            /// <para>公式字段信息</para>
                            /// </summary>
                            public record OfferApplyFormFormulaExtraMapInfo
                            {
                                /// <summary>
                                /// <para>公式字段 ID，字段来源于Offer申请表 - 薪资信息模块。如value示例中的：6872592813776914699</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：object_id</para>
                                /// </summary>
                                [JsonPropertyName("key")]
                                public string? Key { get; set; }

                                /// <summary>
                                /// <para>公式字段名称</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("value")]
                                public I18n? Value { get; set; }

                                /// <summary>
                                /// <para>公式字段名称</para>
                                /// </summary>
                                public record I18n
                                {
                                    /// <summary>
                                    /// <para>中文名称。如：基本工资</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：月薪</para>
                                    /// </summary>
                                    [JsonPropertyName("zh_cn")]
                                    public string? ZhCn { get; set; }

                                    /// <summary>
                                    /// <para>英文名称。如：Basic salary</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：monthly income</para>
                                    /// </summary>
                                    [JsonPropertyName("en_us")]
                                    public string? EnUs { get; set; }
                                }
                            }
                        }

                        /// <summary>
                        /// <para>字段显示条件配置</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("object_display_config")]
                        public OfferApplyFormObjectDisplayConfigInfo? ObjectDisplayConfig { get; set; }

                        /// <summary>
                        /// <para>字段显示条件配置</para>
                        /// </summary>
                        public record OfferApplyFormObjectDisplayConfigInfo
                        {
                            /// <summary>
                            /// <para>显示条件类型</para>
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
                            /// <para>条件列表。由字段 ID、运算符、字段值组合成一个条件。如：</para>
                            /// <para>- 招聘类型（字段 ID 对应的字段）--等于--社招</para>
                            /// <para>- 入职部门（字段 ID 对应的字段）--包含--人事部</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("pre_object_config_list")]
                            public OfferApplyFormPreObjectConfigInfo[]? PreObjectConfigLists { get; set; }

                            /// <summary>
                            /// <para>条件列表。由字段 ID、运算符、字段值组合成一个条件。如：</para>
                            /// <para>- 招聘类型（字段 ID 对应的字段）--等于--社招</para>
                            /// <para>- 入职部门（字段 ID 对应的字段）--包含--人事部</para>
                            /// </summary>
                            public record OfferApplyFormPreObjectConfigInfo
                            {
                                /// <summary>
                                /// <para>字段 ID，字段来源于offer申请表</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：7560465990618843426</para>
                                /// </summary>
                                [JsonPropertyName("id")]
                                public string? Id { get; set; }

                                /// <summary>
                                /// <para>运算符</para>
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
