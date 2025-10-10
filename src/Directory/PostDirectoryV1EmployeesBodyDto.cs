// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-07-11
// ************************************************************************
// <copyright file="PostDirectoryV1EmployeesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建员工 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 创建员工 请求体
/// <para>本接口用于在企业下创建员工。支持传入姓名、手机号等信息，生成在职状态的员工对象。</para>
/// <para>员工指飞书企业内身份为「Employee」的成员，等同于通讯录OpenAPI中的「User」。</para>
/// <para>接口ID：7359428154233651204</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fcreate</para>
/// </summary>
public record PostDirectoryV1EmployeesBodyDto
{
    /// <summary>
    /// <para>创建员工对象</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("employee")]
    public CreateEmployee Employee { get; set; } = new();

    /// <summary>
    /// <para>创建员工对象</para>
    /// </summary>
    public record CreateEmployee
    {
        /// <summary>
        /// <para>姓名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public UpsertName? Name { get; set; }

        /// <summary>
        /// <para>姓名</para>
        /// </summary>
        public record UpsertName
        {
            /// <summary>
            /// <para>员工的姓名，最多可输入 64 字</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18nText Name { get; set; } = new();

            /// <summary>
            /// <para>别名，最多可输入 64 字</para>
            /// <para>必填：否</para>
            /// <para>示例值：jack</para>
            /// </summary>
            [JsonPropertyName("another_name")]
            public string? AnotherName { get; set; }
        }

        /// <summary>
        /// <para>员工的手机号，最多可输入 255 字。注意：</para>
        /// <para>1. 在企业内的在职员工中不可重复。</para>
        /// <para>2. 未认证企业仅支持添加中国大陆手机号，通过飞书认证的企业允许添加海外手机号。</para>
        /// <para>3. 国际电话区号前缀中必须包含加号 +。</para>
        /// <para>必填：否</para>
        /// <para>示例值：13011111111" 或 "+8613011111111</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>企业内在职员工的唯一标识。支持自定义，未自定义时系统自动生成。ID支持修改。注意：</para>
        /// <para>1. 在职员工的ID不可重复</para>
        /// <para>2. ID不能包含空格</para>
        /// <para>必填：否</para>
        /// <para>示例值：u273y71 **数据校验规则**： 长度范围：1-64字符</para>
        /// </summary>
        [JsonPropertyName("custom_employee_id")]
        public string? CustomEmployeeId { get; set; }

        /// <summary>
        /// <para>员工的头像key。获取图片的key请使用 [上传图片 - 服务端 API - 开发文档 - 飞书开放平台](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)，上传时图片类型需要选择 用于设置头像</para>
        /// <para>必填：否</para>
        /// <para>示例值：8abc397a-9950-44ea-9302-e1d8fe00858g</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("avatar_key")]
        public string? AvatarKey { get; set; }

        /// <summary>
        /// <para>员工在工作中的邮箱。注意：</para>
        /// <para>1. 在企业内的在职员工中不可重复。</para>
        /// <para>2. 非中国大陆手机号成员必须同时添加邮箱。</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@gmail.com</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>员工的企业邮箱。请先确保已在管理后台启用飞书邮箱服务。企业邮箱的域名需要企业在管理后台申请并开启。如果企业没有开启对应域名的企业邮箱，设置用户的企业邮箱会操作失败。</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@gmail.com</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("enterprise_email")]
        public string? EnterpriseEmail { get; set; }

        /// <summary>
        /// <para>性别</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：男</item>
        /// <item>2：女</item>
        /// <item>3：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// <para>员工在所属部门内的排序信息。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("employee_order_in_departments")]
        public UpsertUserDepartmentSortInfo[]? EmployeeOrderInDepartments { get; set; }

        /// <summary>
        /// <para>员工在所属部门内的排序信息。</para>
        /// </summary>
        public record UpsertUserDepartmentSortInfo
        {
            /// <summary>
            /// <para>指定员工所在的部门，标识企业内一个唯一的部门，与department_id_type类型保持一致。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eeddjisdwe</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>员工在部门内的排序权重。</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("order_weight_in_deparment")]
            public string? OrderWeightInDeparment { get; set; }

            /// <summary>
            /// <para>该部门在用户所属的多个部门间的排序权重。</para>
            /// <para>必填：否</para>
            /// <para>示例值：20</para>
            /// </summary>
            [JsonPropertyName("order_weight_among_deparments")]
            public string? OrderWeightAmongDeparments { get; set; }

            /// <summary>
            /// <para>是否为用户的主部门（用户只能有一个主部门，且排序权重应最大，不填则默认使用排序第一的部门作为主部门),可选值:true/false。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_main_department")]
            public bool? IsMainDepartment { get; set; }
        }

        /// <summary>
        /// <para>员工的直属上级ID，与employee_id_type类型保持一致。注意：</para>
        /// <para>1. 不可成环，即A的上级是B，B的上级是A。</para>
        /// <para>2. 上级需要是一个在职的员工。</para>
        /// <para>必填：否</para>
        /// <para>示例值：eeasdqwwe</para>
        /// </summary>
        [JsonPropertyName("leader_id")]
        public string? LeaderId { get; set; }

        /// <summary>
        /// <para>员工的虚线上级ID，与employee_id_type类型保持一致。注意：</para>
        /// <para>1. 不可成环，即A的上级是B，B的上级是A。</para>
        /// <para>2. 上级需要是一个在职的员工。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("dotted_line_leader_ids")]
        public string[]? DottedLineLeaderIds { get; set; }

        /// <summary>
        /// <para>工作地国家/地区码。获取国家/地区的编码请使用 [分页批量查询国家/地区](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/country_region/list)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDM34234234</para>
        /// </summary>
        [JsonPropertyName("work_country_or_region")]
        public string? WorkCountryOrRegion { get; set; }

        /// <summary>
        /// <para>工作地点ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：eqwedas</para>
        /// </summary>
        [JsonPropertyName("work_place_id")]
        public string? WorkPlaceId { get; set; }

        /// <summary>
        /// <para>工位</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_station")]
        public I18nText? WorkStation { get; set; }

        /// <summary>
        /// <para>工号。企业内在职员工的工号不可重复。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2845435 **数据校验规则：** 长度范围：0-255字符</para>
        /// </summary>
        [JsonPropertyName("job_number")]
        public string? JobNumber { get; set; }

        /// <summary>
        /// <para>分机号，最多可输入 99 字。企业内所有员工的分机号不可重复。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2845435</para>
        /// </summary>
        [JsonPropertyName("extension_number")]
        public string? ExtensionNumber { get; set; }

        /// <summary>
        /// <para>入职日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-10-10 **数据校验规则：** 长度范围：固定长度：10 个字符，固定格式：“yyyy-mm-dd”</para>
        /// </summary>
        [JsonPropertyName("join_date")]
        public string? JoinDate { get; set; }

        /// <summary>
        /// <para>员工类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：全职</item>
        /// <item>2：实习</item>
        /// <item>3：外包</item>
        /// <item>4：劳务</item>
        /// <item>5：顾问</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("employment_type")]
        public int? EmploymentType { get; set; }

        /// <summary>
        /// <para>职务ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：wqedsaqw</para>
        /// </summary>
        [JsonPropertyName("job_title_id")]
        public string? JobTitleId { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_field_values")]
        public CustomFieldValue[]? CustomFieldValues { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record CustomFieldValue
        {
            /// <summary>
            /// <para>自定义字段类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：多行文本</item>
            /// <item>2：网页链接</item>
            /// <item>3：枚举选项</item>
            /// <item>4：人员</item>
            /// <item>9：电话</item>
            /// <item>10：多选枚举类型</item>
            /// <item>11：人员列表</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("field_type")]
            public string? FieldType { get; set; }

            /// <summary>
            /// <para>文本字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("text_value")]
            public I18nText? TextValue { get; set; }

            /// <summary>
            /// <para>网页链接字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("url_value")]
            public CustomFieldValueUrlValue? UrlValue { get; set; }

            /// <summary>
            /// <para>网页链接字段值</para>
            /// </summary>
            public record CustomFieldValueUrlValue
            {
                /// <summary>
                /// <para>网页标题</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("link_text")]
                public I18nText LinkText { get; set; } = new();

                /// <summary>
                /// <para>移动端网页链接</para>
                /// <para>必填：是</para>
                /// <para>示例值：https://m.bytedance.com/afnasjfna</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// <para>桌面端网页链接</para>
                /// <para>必填：是</para>
                /// <para>示例值：http://www.fs.cn</para>
                /// </summary>
                [JsonPropertyName("pcurl")]
                public string Pcurl { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>枚举字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enum_value")]
            public CustomFieldValueEnumValue? EnumValue { get; set; }

            /// <summary>
            /// <para>枚举字段值</para>
            /// </summary>
            public record CustomFieldValueEnumValue
            {
                /// <summary>
                /// <para>选项结果ID</para>
                /// <para>必填：是</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("enum_ids")]
                public string[] EnumIds { get; set; } = Array.Empty<string>();

                /// <summary>
                /// <para>选项类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：文本</item>
                /// <item>2：图片</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("enum_type")]
                public string EnumType { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>人员字段值</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("user_values")]
            public UserValue[]? UserValues { get; set; }

            /// <summary>
            /// <para>人员字段值</para>
            /// </summary>
            public record UserValue
            {
                /// <summary>
                /// <para>人员ID，与employee_id_type类型保持一致。</para>
                /// <para>必填：是</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("ids")]
                public string[] Ids { get; set; } = Array.Empty<string>();
            }

            /// <summary>
            /// <para>电话字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone_value")]
            public CustomFieldValuePhoneValue? PhoneValue { get; set; }

            /// <summary>
            /// <para>电话字段值</para>
            /// </summary>
            public record CustomFieldValuePhoneValue
            {
                /// <summary>
                /// <para>电话号</para>
                /// <para>必填：是</para>
                /// <para>示例值：18812345678</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>分机号</para>
                /// <para>必填：否</para>
                /// <para>示例值：234234234</para>
                /// </summary>
                [JsonPropertyName("extension_number")]
                public string? ExtensionNumber { get; set; }
            }

            /// <summary>
            /// <para>自定义字段key</para>
            /// <para>必填：否</para>
            /// <para>示例值：C-1000001</para>
            /// </summary>
            [JsonPropertyName("field_key")]
            public string? FieldKey { get; set; }
        }
    }

    /// <summary>
    /// <para>国际化语言</para>
    /// </summary>
    public record I18nText
    {
        /// <summary>
        /// <para>默认值</para>
        /// <para>最小长度：1字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("default_value")]
        public string DefaultValue { get; set; } = string.Empty;

        /// <summary>
        /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"zh_cn":"张三"}</para>
        /// </summary>
        [JsonPropertyName("i18n_value")]
        public I18nLanguage<string>? I18nValue { get; set; }
    }

    /// <summary>
    /// <para>接口拓展选项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("options")]
    public CreateEmployeeOptions? Options { get; set; }

    /// <summary>
    /// <para>接口拓展选项</para>
    /// </summary>
    public record CreateEmployeeOptions
    {
        /// <summary>
        /// <para>员工的数据驻留地。仅限开通了Multi-Geo的企业可选填，且仅能填入企业数据驻留地列表中的Geo。可通过**获取地理位置列表**接口查询企业开通的Geo，请注意这里需要传入**小写字母**。</para>
        /// <para>需要申请以下权限才能写入：</para>
        /// <para>- directory:employee.base.geo:write : 写入员工数据所在地</para>
        /// <para>必填：否</para>
        /// <para>示例值：cn</para>
        /// </summary>
        [JsonPropertyName("geo_name")]
        public string? GeoName { get; set; }

        /// <summary>
        /// <para>分配给员工的席位ID列表。可通过下方接口获取到该租户的可用席位ID，参见[获取席位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/tenant-v2/tenant-product_assign_info/query)。当在混合license模式下，此字段为必填。</para>
        /// <para>需要申请以下权限才能写入：</para>
        /// <para>- directory:employee.base.subscription_ids:write : 写入员工席位信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("subscription_ids")]
        public string[]? SubscriptionIds { get; set; }
    }
}
