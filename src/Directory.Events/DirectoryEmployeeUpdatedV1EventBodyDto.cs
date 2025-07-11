// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="DirectoryEmployeeUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>员工信息被修改 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory.Events;
/// <summary>
/// 员工信息被修改 事件体
/// <para>在员工资料更新时接收事件通知。</para>
/// <para>接口ID：7419214646853140484</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fevents%2fupdated</para>
/// </summary>
public record DirectoryEmployeeUpdatedV1EventBodyDto() : EventBodyDto("directory.employee.updated_v1")
{
    /// <summary>
    /// <para>变化的属性列表，枚举了被修改的属性字段名。如果某个属性名被列出但在修改的实体信息中缺失，可能是由于缺乏读取权限，需要进一步核实。</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `100`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("changed_properties")]
    public string[]? ChangedProperties { get; set; }

    /// <summary>
    /// <para>员工实体</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee_prev")]
    public EmployeeEntity? EmployeePrev { get; set; }

    /// <summary>
    /// <para>员工实体</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee_curr")]
    public EmployeeEntity? EmployeeCurr { get; set; }

    /// <summary>
    /// 员工实体
    /// </summary>
    public record EmployeeEntity
    {
        /// <summary>
        /// <para>员工基础信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("base_info")]
        public EmployeeBaseEntity? BaseInfo { get; set; }

        /// <summary>
        /// 员工基础信息
        /// </summary>
        public record EmployeeBaseEntity
        {
            /// <summary>
            /// <para>用户的open_id,ID类型参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("employee_id")]
            public string? EmployeeId { get; set; }

            /// <summary>
            /// <para>姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public NameSuffix? Name { get; set; }

            /// <summary>
            /// 姓名
            /// </summary>
            public record NameSuffix
            {
                /// <summary>
                /// <para>i18n文本</para>
                /// <para>**字段权限要求（满足任一）**：</para>
                /// <para>- directory:employee.base.base:read : 查看员工个人基本信息</para>
                /// <para>- directory:employee.base.name.name:read : 查看员工的姓名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18nText? Name { get; set; }

                /// <summary>
                /// <para>别名</para>
                /// <para>**字段权限要求（满足任一）**：</para>
                /// <para>- directory:employee.base.base:read : 查看员工个人基本信息</para>
                /// <para>- directory:employee.base.name.another_name:read : 查看员工的别名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("another_name")]
                public string? AnotherName { get; set; }
            }

            /// <summary>
            /// <para>手机号</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 最大长度：`255` 字符</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- directory:employee.base.mobile:read : 查看员工手机号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("mobile")]
            public string? Mobile { get; set; }

            /// <summary>
            /// <para>用户的联系邮箱</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 最大长度：`255` 字符</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- directory:employee.base.email:read : 查看员工联系邮箱</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>性别</para>
            /// <para>**可选值有**：</para>
            /// <para>0:未知,1:男,2:女,3:其他</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- directory:employee.base.gender:read : 查看员工性别</para>
            /// <para>必填：否</para>
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
            /// <para>部门信息</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`0` ～ `20`</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- directory:employee.base.department:read : 查看员工所属部门信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("departments")]
            public Department[]? Departments { get; set; }

            /// <summary>
            /// 部门信息
            /// </summary>
            public record Department
            {
                /// <summary>
                /// <para>部门ID,部门ID类型为 open_department_id，了解部门 ID 可参见[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)。</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 最大长度：`64` 字符</para>
                /// <para>**字段权限要求（满足任一）**：</para>
                /// <para>- directory:department.base:read : 查看部门基础信息</para>
                /// <para>- directory:department.external_id:read : 查看部门自定义 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department_id")]
                public string? DepartmentId { get; set; }
            }

            /// <summary>
            /// <para>用户在部门内的排序信息， 第一个部门为主部门</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`0` ～ `20`</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.base.department:read : 查看员工所属部门信息</para>
            /// <para>- directory:employee.base.dept_order:read : 查看员工在部门内的排序</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("employee_order_in_departments")]
            public UserDepartmentSortInfo[]? EmployeeOrderInDepartments { get; set; }

            /// <summary>
            /// 用户在部门内的排序信息， 第一个部门为主部门
            /// </summary>
            public record UserDepartmentSortInfo
            {
                /// <summary>
                /// <para>部门id，部门id类型为 open_department_id，了解部门 ID 可参见[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department_id")]
                public string? DepartmentId { get; set; }

                /// <summary>
                /// <para>用户在部门内的排序权重</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("order_weight_in_deparment")]
                public string? OrderWeightInDeparment { get; set; }

                /// <summary>
                /// <para>用户多个部门间的排序权重</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("order_weight_among_deparments")]
                public string? OrderWeightAmongDeparments { get; set; }
            }

            /// <summary>
            /// <para>个人签名</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.base.base:read : 查看员工个人基本信息</para>
            /// <para>- directory:employee.base.description:read : 查看员工的个性签名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>用户活跃状态</para>
            /// <para>**可选值有**：</para>
            /// <para>1:未激活,2:激活,3:冻结,4:主动退出,5:未加入</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.base.active_status:read : 查看员工账号活跃状态</para>
            /// <para>- directory:employee.base.status:read : 查看员工状态信息</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：未激活</item>
            /// <item>2：激活</item>
            /// <item>3：冻结</item>
            /// <item>4：主动退出</item>
            /// <item>5：未加入</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }

            /// <summary>
            /// <para>是否离职</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.base.is_resigned:read : 查看员工离职状态</para>
            /// <para>- directory:employee.base.status:read : 查看员工状态信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("is_resigned")]
            public bool? IsResigned { get; set; }

            /// <summary>
            /// <para>直属上级的用户open_id，了解用户 ID 可参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.base.leader:read : 查看员工上级信息</para>
            /// <para>- directory:employee.base.leader_id:read : 查看员工直属上级 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("leader_id")]
            public string? LeaderId { get; set; }

            /// <summary>
            /// <para>虚线上级的用户open_id，了解用户 ID 可参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`0` ～ `10`</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.base.dotted_line_leaders:read : 查看员工虚线上级 ID</para>
            /// <para>- directory:employee.base.leader:read : 查看员工上级信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dotted_line_leader_ids")]
            public string[]? DottedLineLeaderIds { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`0` ～ `100`</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- directory:employee.base.custom_field:read : 查看员工自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_field_values")]
            public CustomFieldValue[]? CustomFieldValues { get; set; }

            /// <summary>
            /// 自定义字段值
            /// </summary>
            public record CustomFieldValue
            {
                /// <summary>
                /// <para>自定义字段key</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("field_key")]
                public string? FieldKey { get; set; }

                /// <summary>
                /// <para>自定义字段类型</para>
                /// <para>**可选值有**：</para>
                /// <para>1:多行文本,2:网页链接,3:枚举选项,4:人员,10:多选枚举类型(目前仅支持文本类型),11:人员列表</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：多行文本</item>
                /// <item>2：网页链接</item>
                /// <item>3：枚举选项</item>
                /// <item>4：人员</item>
                /// <item>10：多选枚举类型(目前仅支持文本类型)</item>
                /// <item>11：人员列表</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("field_type")]
                public string? FieldType { get; set; }

                /// <summary>
                /// <para>i18n文本</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text_value")]
                public I18nText? TextValue { get; set; }

                /// <summary>
                /// <para>网页链接字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("url_value")]
                public UrlValueSuffix? UrlValue { get; set; }

                /// <summary>
                /// 网页链接字段值
                /// </summary>
                public record UrlValueSuffix
                {
                    /// <summary>
                    /// <para>i18n文本</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("link_text")]
                    public I18nText? LinkText { get; set; }

                    /// <summary>
                    /// <para>移动端网页链接</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string? Url { get; set; }

                    /// <summary>
                    /// <para>桌面端网页链接</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("pcurl")]
                    public string? Pcurl { get; set; }
                }

                /// <summary>
                /// <para>枚举</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("enum_value")]
                public EnumValueSuffix? EnumValue { get; set; }

                /// <summary>
                /// 枚举
                /// </summary>
                public record EnumValueSuffix
                {
                    /// <summary>
                    /// <para>选项结果ID</para>
                    /// <para>**数据校验规则**：</para>
                    /// <para>- 长度范围：`0` ～ `100`</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("enum_ids")]
                    public string[]? EnumIds { get; set; }

                    /// <summary>
                    /// <para>选项类型</para>
                    /// <para>**可选值有**：</para>
                    /// <para>1:文本,2:图片</para>
                    /// <para>必填：否</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：文本</item>
                    /// <item>2：图片</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("enum_type")]
                    public string? EnumType { get; set; }
                }

                /// <summary>
                /// <para>人员字段值</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 长度范围：`0` ～ `100`</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("user_values")]
                public UserValue[]? UserValues { get; set; }

                /// <summary>
                /// 人员字段值
                /// </summary>
                public record UserValue
                {
                    /// <summary>
                    /// <para>人员ID列表，了解用户 ID 可参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
                    /// <para>**数据校验规则**：</para>
                    /// <para>- 长度范围：`0` ～ `100`</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("ids")]
                    public string[]? Ids { get; set; }

                    /// <summary>
                    /// <para>人员类型</para>
                    /// <para>**可选值有**：</para>
                    /// <para>1:员工</para>
                    /// <para>必填：否</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：员工</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("user_type")]
                    public string? UserType { get; set; }
                }
            }

            /// <summary>
            /// <para>离职时间</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- directory:employee.base.resign_time:read : 查看员工离职时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resign_time")]
            public string? ResignTime { get; set; }

            /// <summary>
            /// <para>头像url</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.base.avatar:read : 查看员工的头像</para>
            /// <para>- directory:employee.base.base:read : 查看员工个人基本信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("avatar")]
            public ImageLink? Avatar { get; set; }

            /// <summary>
            /// 头像url
            /// </summary>
            public record ImageLink
            {
                /// <summary>
                /// <para>72*72像素头像链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("avatar_72")]
                public string? Avatar72 { get; set; }

                /// <summary>
                /// <para>240*240像素头像链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("avatar_240")]
                public string? Avatar240 { get; set; }

                /// <summary>
                /// <para>640*640像素头像链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("avatar_640")]
                public string? Avatar640 { get; set; }

                /// <summary>
                /// <para>原始头像链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("avatar_origin")]
                public string? AvatarOrigin { get; set; }
            }

            /// <summary>
            /// <para>自定义背景图 url</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.base.background_image:read : 查看员工的名片页自定义背景图</para>
            /// <para>- directory:employee.base.base:read : 查看员工个人基本信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("background_image")]
            public string? BackgroundImage { get; set; }
        }

        /// <summary>
        /// <para>员工工作信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_info")]
        public EmployeeWorkEntity? WorkInfo { get; set; }

        /// <summary>
        /// 员工工作信息
        /// </summary>
        public record EmployeeWorkEntity
        {
            /// <summary>
            /// <para>工作地国家/地区</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.base_work:read : 查看员工基础工作信息</para>
            /// <para>- directory:employee.work.work_country_or_region:read : 查看员工的工作国家/地区</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_country_or_region")]
            public string? WorkCountryOrRegion { get; set; }

            /// <summary>
            /// <para>地点，为管理后台中工作信息的"工作城市"字段</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.base_work:read : 查看员工基础工作信息</para>
            /// <para>- directory:employee.work.work_place:read : 查看员工的工作地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_place")]
            public Place? WorkPlace { get; set; }

            /// <summary>
            /// 地点，为管理后台中工作信息的"工作城市"字段
            /// </summary>
            public record Place
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("place_id")]
                public string? PlaceId { get; set; }
            }

            /// <summary>
            /// <para>员工工位信息</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.base_work:read : 查看员工基础工作信息</para>
            /// <para>- directory:employee.work.work_station:read : 查看员工的工位</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_station")]
            public I18nText? WorkStation { get; set; }

            /// <summary>
            /// <para>工号</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 最大长度：`255` 字符</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.base_work:read : 查看员工基础工作信息</para>
            /// <para>- directory:employee.work.job_number:read : 查看员工的工号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_number")]
            public string? JobNumber { get; set; }

            /// <summary>
            /// <para>分机号</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 最大长度：`99` 字符</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.base_work:read : 查看员工基础工作信息</para>
            /// <para>- directory:employee.work.extension_number:read : 查看员工的分机号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("extension_number")]
            public string? ExtensionNumber { get; set; }

            /// <summary>
            /// <para>入职日期，例如：2007-03-20</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.join_date:read : 查看员工的入职日期</para>
            /// <para>- directory:employee.work.employment:read : 查看员工雇佣信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("join_date")]
            public string? JoinDate { get; set; }

            /// <summary>
            /// <para>员工类型</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.employment_type:read : 查看员工的员工类型</para>
            /// <para>- directory:employee.work.employment:read : 查看员工雇佣信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("employment_type")]
            public int? EmploymentType { get; set; }

            /// <summary>
            /// <para>员工人事状态</para>
            /// <para>**可选值有**：</para>
            /// <para>1:在职,2:离职,3:待入职,4:取消入职,5:待离职</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.staff_status:read : 查看员工的人事状态</para>
            /// <para>- directory:employee.work.employment:read : 查看员工雇佣信息</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：在职</item>
            /// <item>2：离职</item>
            /// <item>3：待入职</item>
            /// <item>4：取消入职</item>
            /// <item>5：待离职</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("staff_status")]
            public int? StaffStatus { get; set; }

            /// <summary>
            /// <para>职务</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- directory:employee.work.job_title:read : 查看员工职务信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_title")]
            public JobTitleSuffix? JobTitle { get; set; }

            /// <summary>
            /// 职务
            /// </summary>
            public record JobTitleSuffix
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 最大长度：`64` 字符</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("job_title_id")]
                public string? JobTitleId { get; set; }
            }

            /// <summary>
            /// <para>离职日期，例如：2007-03-20</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.resign_date:read : 查看员工离职日期</para>
            /// <para>- directory:employee.work.employment:read : 查看员工雇佣信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resign_date")]
            public string? ResignDate { get; set; }

            /// <summary>
            /// <para>离职原因</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.resign_reason:read : 查看员工离职原因</para>
            /// <para>- directory:employee.work.employment:read : 查看员工雇佣信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resign_reason")]
            public int? ResignReason { get; set; }

            /// <summary>
            /// <para>离职备注</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 最大长度：`5000` 字符</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.resign_remark:read : 查看员工离职备注</para>
            /// <para>- directory:employee.work.employment:read : 查看员工雇佣信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resign_remark")]
            public string? ResignRemark { get; set; }

            /// <summary>
            /// <para>离职类型</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- directory:employee.work.resign_type:read : 查看员工离职类型</para>
            /// <para>- directory:employee.work.employment:read : 查看员工雇佣信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resign_type")]
            public int? ResignType { get; set; }
        }

        /// <summary>
        /// i18n文本
        /// </summary>
        public record I18nText
        {
            /// <summary>
            /// <para>默认值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("default_value")]
            public string? DefaultValue { get; set; }

            /// <summary>
            /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public I18nLanguage<string>? I18nValue { get; set; }
        }
    }

    /// <summary>
    /// <para>字段异常信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("abnormal")]
    public AbnormalRecord? Abnormal { get; set; }

    /// <summary>
    /// 字段异常信息
    /// </summary>
    public record AbnormalRecord
    {
        /// <summary>
        /// <para>异常ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>行级异常</para>
        /// <para>**可选值有**：</para>
        /// <para>0:成功,1000:没权限</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`0` ～ `100`</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：成功</item>
        /// <item>1000：没权限</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("row_error")]
        public int? RowError { get; set; }

        /// <summary>
        /// <para>列级异常，key为字段名,value为下列枚举</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("field_errors")]
        public Dictionary<string, int>? FieldErrors { get; set; }
    }
}
