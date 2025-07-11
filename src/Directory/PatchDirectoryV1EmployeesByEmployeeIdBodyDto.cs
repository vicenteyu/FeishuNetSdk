// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-07-11
// ************************************************************************
// <copyright file="PatchDirectoryV1EmployeesByEmployeeIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新员工 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 更新员工信息 请求体
/// <para>本接口用于更新在职/离职员工的信息、冻结/恢复员工。未传递的参数不会进行更新。</para>
/// <para>员工指飞书企业内身份为「Employee」的成员，等同于通讯录OpenAPI中的「User」。</para>
/// <para>接口ID：7359428154233667588</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fpatch</para>
/// </summary>
public record PatchDirectoryV1EmployeesByEmployeeIdBodyDto
{
    /// <summary>
    /// <para>更新员工对象</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("employee")]
    public UpdateEmployee Employee { get; set; } = new();

    /// <summary>
    /// <para>更新员工对象</para>
    /// </summary>
    public record UpdateEmployee
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
            /// <para>员工的姓名。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18nText Name { get; set; } = new();

            /// <summary>
            /// <para>员工的姓名。</para>
            /// </summary>
            public record I18nText
            {
                /// <summary>
                /// <para>默认值</para>
                /// <para>长度范围：1- 64 字符</para>
                /// <para>必填：是</para>
                /// <para>示例值：工位</para>
                /// </summary>
                [JsonPropertyName("default_value")]
                public string DefaultValue { get; set; } = string.Empty;

                /// <summary>
                /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
                /// <para>必填：否</para>
                /// <para>示例值：{"zh_cn":"工位1"}</para>
                /// </summary>
                [JsonPropertyName("i18n_value")]
                public I18nLanguage<string>? I18nValue { get; set; }
            }

            /// <summary>
            /// <para>别名，最多可输入 64 字</para>
            /// <para>必填：否</para>
            /// <para>示例值：Jack</para>
            /// </summary>
            [JsonPropertyName("another_name")]
            public string? AnotherName { get; set; }
        }

        /// <summary>
        /// <para>员工的手机号，最多可输入 255 字。注意：</para>
        /// <para>1. 在企业内的在职员工中不可重复</para>
        /// <para>2. 未认证企业仅支持添加中国大陆手机号，通过飞书认证的企业允许添加海外手机号</para>
        /// <para>3. 国际电话区号前缀中必须包含加号 +</para>
        /// <para>必填：否</para>
        /// <para>示例值：13011111111" 或 "+8613011111111</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>企业内在职员工的唯一标识。支持自定义，未自定义时系统自动生成。ID支持修改。注意：</para>
        /// <para>1. 在职员工的ID不可重复。</para>
        /// <para>2. ID不能包含空格。</para>
        /// <para>必填：否</para>
        /// <para>示例值：eesadeq</para>
        /// </summary>
        [JsonPropertyName("custom_employee_id")]
        public string? CustomEmployeeId { get; set; }

        /// <summary>
        /// <para>员工的头像key。获取图片的key请使用 [上传图片 - 服务端 API - 开发文档 - 飞书开放平台](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)，上传时图片类型需要选择 用于设置头像</para>
        /// <para>必填：否</para>
        /// <para>示例值：dadwqeqwdsa</para>
        /// </summary>
        [JsonPropertyName("avatar_key")]
        public string? AvatarKey { get; set; }

        /// <summary>
        /// <para>员工在工作中的邮箱。注意：</para>
        /// <para>1. 在企业内的在职员工中不可重复。</para>
        /// <para>2. 非中国大陆手机号成员必须同时添加邮箱。</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@163.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>员工的企业邮箱。请先确保已在管理后台启用飞书邮箱服务。企业邮箱的域名需要企业在管理后台申请并开启。如果企业没有开启对应域名的企业邮箱，设置用户的企业邮箱会操作失败。</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@163.com</para>
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
        /// <para>员工在所属部门内的排序信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("employee_order_in_departments")]
        public UpsertUserDepartmentSortInfo[]? EmployeeOrderInDepartments { get; set; }

        /// <summary>
        /// <para>员工在所属部门内的排序信息</para>
        /// </summary>
        public record UpsertUserDepartmentSortInfo
        {
            /// <summary>
            /// <para>部门id，与department_id_type类型保持一致。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eediasdjw</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>员工在部门内的排序权重</para>
            /// <para>**数据校验规则：**</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("order_weight_in_deparment")]
            public string? OrderWeightInDeparment { get; set; }

            /// <summary>
            /// <para>该部门在用户所属的多个部门间的排序权重</para>
            /// <para>必填：否</para>
            /// <para>示例值：20</para>
            /// </summary>
            [JsonPropertyName("order_weight_among_deparments")]
            public string? OrderWeightAmongDeparments { get; set; }

            /// <summary>
            /// <para>是否为用户的主部门（用户只能有一个主部门，且排序权重应最大，不填则默认使用排序第一的部门作为主部门)</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_main_department")]
            public bool? IsMainDepartment { get; set; }
        }

        /// <summary>
        /// <para>背景图的key。获取图片的key请使用 [上传图片 - 服务端 API - 开发文档 - 飞书开放平台](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)，上传时图片类型需要选择 用于发送消息</para>
        /// <para>必填：否</para>
        /// <para>示例值：qweasdqawqeq</para>
        /// </summary>
        [JsonPropertyName("background_image_key")]
        public string? BackgroundImageKey { get; set; }

        /// <summary>
        /// <para>员工的个性签名</para>
        /// <para>必填：否</para>
        /// <para>示例值：新员工入职</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>员工的直属上级ID。注意：</para>
        /// <para>1. 不可成环，即A的上级是B，B的上级是A。</para>
        /// <para>2. 上级需要是一个在职的员工。</para>
        /// <para>必填：否</para>
        /// <para>示例值：eeshfosd</para>
        /// </summary>
        [JsonPropertyName("leader_id")]
        public string? LeaderId { get; set; }

        /// <summary>
        /// <para>员工的虚线上级ID，与employee_id_type类型保持一致。注意：</para>
        /// <para>1. 不可成环，即A的上级是B，B的上级是A。</para>
        /// <para>2. 上级需要是一个在职的员工。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("dotted_line_leader_ids")]
        public string[]? DottedLineLeaderIds { get; set; }

        /// <summary>
        /// <para>工作地国家/地区码。获取国家/地区的编码请使用 [分页批量查询国家/地区](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/country_region/list)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDM2312312</para>
        /// </summary>
        [JsonPropertyName("work_country_or_region")]
        public string? WorkCountryOrRegion { get; set; }

        /// <summary>
        /// <para>工作地点ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1111sdda</para>
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
        /// <para>工位</para>
        /// </summary>
        public record I18nText
        {
            /// <summary>
            /// <para>默认值</para>
            /// <para>必填：是</para>
            /// <para>示例值：工位</para>
            /// </summary>
            [JsonPropertyName("default_value")]
            public string DefaultValue { get; set; } = string.Empty;

            /// <summary>
            /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"zh_cn":"工位"}</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public object? I18nValue { get; set; }
        }

        /// <summary>
        /// <para>工号。企业内在职员工的工号不可重复。</para>
        /// <para>必填：否</para>
        /// <para>示例值：28549233</para>
        /// </summary>
        [JsonPropertyName("job_number")]
        public string? JobNumber { get; set; }

        /// <summary>
        /// <para>分机号，最多可输入 99 字。企业内所有员工的分机号不可重复。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2854923</para>
        /// </summary>
        [JsonPropertyName("extension_number")]
        public string? ExtensionNumber { get; set; }

        /// <summary>
        /// <para>入职日期</para>
        /// <para>固定格式为：'YYYY-MM-DD' , 固定长度为：10</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-10-10</para>
        /// </summary>
        [JsonPropertyName("join_date")]
        public string? JoinDate { get; set; }

        /// <summary>
        /// <para>员工类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1 **可选值有**： &lt;md-enum&gt; &lt;md-enum-item key="0" &gt;未知&lt;/md-enum-item&gt; &lt;md-enum-item key="1" &gt;全职&lt;/md-enum-item&gt; &lt;md-enum-item key="2" &gt;实习&lt;/md-enum-item&gt; &lt;md-enum-item key="3" &gt;外包&lt;/md-enum-item&gt; &lt;md-enum-item key="4" &gt;劳务&lt;/md-enum-item&gt; &lt;md-enum-item key="5" &gt;顾问&lt;/md-enum-item&gt; &lt;/md-enum&gt;</para>
        /// </summary>
        [JsonPropertyName("employment_type")]
        public int? EmploymentType { get; set; }

        /// <summary>
        /// <para>职务ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ewdjdssd</para>
        /// </summary>
        [JsonPropertyName("job_title_id")]
        public string? JobTitleId { get; set; }

        /// <summary>
        /// <para>职级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：asdfghjk</para>
        /// </summary>
        [JsonPropertyName("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>序列ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：qwertyui</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>离职日期</para>
        /// <para>固定格式为：'YYYY-MM-DD' , 固定长度为：10</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-10-10</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("resign_date")]
        public string? ResignDate { get; set; }

        /// <summary>
        /// <para>离职原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：置空</item>
        /// <item>1：薪酬不符合预期</item>
        /// <item>2：工作时间过长</item>
        /// <item>3：不满意工作内容</item>
        /// <item>4：不认可上级或管理层</item>
        /// <item>5：职业发展机会有限</item>
        /// <item>6：对公司文化缺乏认同</item>
        /// <item>7：组织架构调整（主动离职）</item>
        /// <item>8：合同到期</item>
        /// <item>9：跳槽</item>
        /// <item>10：转行</item>
        /// <item>11：家庭原因</item>
        /// <item>12：健康状况不佳</item>
        /// <item>13：工作地点原因</item>
        /// <item>14：其他(主动离职)</item>
        /// <item>15：意外</item>
        /// <item>16：身故</item>
        /// <item>17：解雇</item>
        /// <item>18：试用期不通过</item>
        /// <item>19：工作表现不佳</item>
        /// <item>20：工作产出低</item>
        /// <item>21：组织架构调整（被动离职）</item>
        /// <item>22：违纪</item>
        /// <item>23：违法</item>
        /// <item>24：其他（被动离职）</item>
        /// <item>25：其他（其他）</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("resign_reason")]
        public string? ResignReason { get; set; }

        /// <summary>
        /// <para>离职备注信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：个人原因</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("resign_remark")]
        public string? ResignRemark { get; set; }

        /// <summary>
        /// <para>离职类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：置空</item>
        /// <item>1：主动</item>
        /// <item>2：被动</item>
        /// <item>3：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("resign_type")]
        public string? ResignType { get; set; }

        /// <summary>
        /// <para>是否冻结员工账号。</para>
        /// <para>true为冻结，false为恢复账号。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_frozen")]
        public bool? IsFrozen { get; set; }

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
            /// <item>10：多选枚举类型(目前仅支持文本类型)</item>
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
            /// <para>文本字段值</para>
            /// </summary>
            public record I18nText
            {
                /// <summary>
                /// <para>默认值</para>
                /// <para>必填：是</para>
                /// <para>示例值：姓名字段</para>
                /// </summary>
                [JsonPropertyName("default_value")]
                public string DefaultValue { get; set; } = string.Empty;

                /// <summary>
                /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
                /// <para>必填：否</para>
                /// <para>示例值：{"zh_cn":"姓名字段"}</para>
                /// </summary>
                [JsonPropertyName("i18n_value")]
                public object? I18nValue { get; set; }
            }

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
                /// <para>网页标题</para>
                /// </summary>
                public record I18nText
                {
                    /// <summary>
                    /// <para>默认值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：网页标题</para>
                    /// </summary>
                    [JsonPropertyName("default_value")]
                    public string DefaultValue { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：{"zh_cn":"网页标题"}</para>
                    /// </summary>
                    [JsonPropertyName("i18n_value")]
                    public object? I18nValue { get; set; }
                }

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
            /// <para>枚举</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enum_value")]
            public CustomFieldValueEnumValue? EnumValue { get; set; }

            /// <summary>
            /// <para>枚举</para>
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
}
