using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索员工信息 请求体
/// <para>该接口会按照应用拥有的「员工数据」的权限范围返回数据，请确定在「开发者后台 - 权限管理 - 数据权限」中有申请「员工资源」权限范围</para>
/// <para>接口ID：7211423970042167300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fsearch</para>
/// </summary>
public record PostCorehrV2EmployeesSearchBodyDto
{
    /// <summary>
    /// <para>返回数据的字段列表，为空时不返回任何字段</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("fields")]
    public string[]? Fields { get; set; }

    /// <summary>
    /// <para>雇佣 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("employment_id_list")]
    public string[]? EmploymentIdList { get; set; }

    /// <summary>
    /// <para>工号列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("employee_number_list")]
    public string[]? EmployeeNumberList { get; set; }

    /// <summary>
    /// <para>邮箱，精确匹配查询</para>
    /// <para>必填：否</para>
    /// <para>示例值：13312345678@qq.com</para>
    /// </summary>
    [JsonProperty("work_email")]
    public string? WorkEmail { get; set; }

    /// <summary>
    /// <para>个人电话，精确匹配查询</para>
    /// <para><br><b>字段权限要求：</b></para>
    /// <para><br>按照手机号搜索：(corehr:person.phone.search:read)</para>
    /// <para>必填：否</para>
    /// <para>示例值：16760342300</para>
    /// </summary>
    [JsonProperty("phone_number")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// <para>搜索关键字，支持对邮箱、工号和姓名的模糊匹配</para>
    /// <para>必填：否</para>
    /// <para>示例值：张三</para>
    /// </summary>
    [JsonProperty("key_word")]
    public string? KeyWord { get; set; }

    /// <summary>
    /// <para>雇佣状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：hired</para>
    /// <para>可选值：<list type="bullet">
    /// <item>hired：在职</item>
    /// <item>terminated：离职</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("employment_status")]
    public string? EmploymentStatus { get; set; }

    /// <summary>
    /// <para>人员类型 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6971090097697521314</para>
    /// </summary>
    [JsonProperty("employee_type_id")]
    public string? EmployeeTypeId { get; set; }

    /// <summary>
    /// <para>部门 ID，根据员工主职的直接部门查询，可以通过【查询部门】API 获取 部门 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("department_id_list")]
    public string[]? DepartmentIdList { get; set; }

    /// <summary>
    /// <para>直接上级的雇佣 ID，根据员工主职的直接上级查询</para>
    /// <para>必填：否</para>
    /// <para>示例值：7027024823985447820</para>
    /// </summary>
    [JsonProperty("direct_manager_id_list")]
    public string[]? DirectManagerIdList { get; set; }

    /// <summary>
    /// <para>虚线上级的雇佣 ID，根据员工主职的虚线上级查询</para>
    /// <para>必填：否</para>
    /// <para>示例值：7027024823985117820</para>
    /// </summary>
    [JsonProperty("dotted_line_manager_id_list")]
    public string[]? DottedLineManagerIdList { get; set; }

    /// <summary>
    /// <para>转正式员工日期-搜索范围开始</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonProperty("regular_employee_start_date_start")]
    public string? RegularEmployeeStartDateStart { get; set; }

    /// <summary>
    /// <para>转正式员工日期-搜索范围结束</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonProperty("regular_employee_start_date_end")]
    public string? RegularEmployeeStartDateEnd { get; set; }

    /// <summary>
    /// <para>入职日期-搜索范围开始，需要与搜索范围结束一同使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonProperty("effective_time_start")]
    public string? EffectiveTimeStart { get; set; }

    /// <summary>
    /// <para>入职日期-搜索范围结束</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonProperty("effective_time_end")]
    public string? EffectiveTimeEnd { get; set; }

    /// <summary>
    /// <para>工作地点 ID 列表，查询属于该工作地点及下级工作地点的员工</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("work_location_id_list_include_sub")]
    public string[]? WorkLocationIdListIncludeSub { get; set; }

    /// <summary>
    /// <para>常用英文全名精确搜索</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("preferred_english_full_name_list")]
    public string[]? PreferredEnglishFullNameList { get; set; }

    /// <summary>
    /// <para>常用本地全名精确搜索</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("preferred_local_full_name_list")]
    public string[]? PreferredLocalFullNameList { get; set; }

    /// <summary>
    /// <para>居民身份证件号码精确搜索</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("national_id_number_list")]
    public string[]? NationalIdNumberList { get; set; }

    /// <summary>
    /// <para>个人电话列表，精确匹配查询</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("phone_number_list")]
    public string[]? PhoneNumberList { get; set; }

    /// <summary>
    /// <para>工作邮箱地址列表，精确匹配查询</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("email_address_list")]
    public string[]? EmailAddressList { get; set; }

    /// <summary>
    /// <para>部门 ID 列表，查询属于该部门及下级部门的员工</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("department_id_list_include_sub")]
    public string[]? DepartmentIdListIncludeSub { get; set; }
}
