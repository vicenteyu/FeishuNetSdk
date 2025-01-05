// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索员工信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索员工信息 请求体
/// <para>查询员工的工作信息、个人信息等数据</para>
/// <para>接口ID：7211423970042167300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fsearch</para>
/// </summary>
public record PostCorehrV2EmployeesSearchBodyDto
{
    /// <summary>
    /// <para>需要查询的字段列表</para>
    /// <para>- 参考[【字段下钻】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/query-employment-fields)</para>
    /// <para>- 为空时仅返回 employment_id</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }

    /// <summary>
    /// <para>雇佣 ID 列表</para>
    /// <para>- 在 [【创建雇佣】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employment/create)</para>
    /// <para>返回的 ID</para>
    /// <para>- ID类型应于 user_id_type 一致</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id_list")]
    public string[]? EmploymentIdList { get; set; }

    /// <summary>
    /// <para>工号列表，是在[【创建雇佣】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employment/create)时主动传递的或者自动生成的工号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee_number_list")]
    public string[]? EmployeeNumberList { get; set; }

    /// <summary>
    /// <para>邮箱，精确匹配查询</para>
    /// <para>必填：否</para>
    /// <para>示例值：13312345678@qq.com</para>
    /// </summary>
    [JsonPropertyName("work_email")]
    public string? WorkEmail { get; set; }

    /// <summary>
    /// <para>个人电话，精确匹配查询</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:person.phone.search:read : 使用个人电话搜索</para>
    /// <para>必填：否</para>
    /// <para>示例值：16760342300</para>
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// <para>搜索关键字，支持对邮箱、工号和姓名的模糊匹配</para>
    /// <para>- 模糊搜索基于相关性返回，返回数据不固定，请勿依赖此字段翻页查询</para>
    /// <para>必填：否</para>
    /// <para>示例值：张三</para>
    /// </summary>
    [JsonPropertyName("key_word")]
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
    [JsonPropertyName("employment_status")]
    public string? EmploymentStatus { get; set; }

    /// <summary>
    /// <para>人员类型 ID，可通过[【批量查询人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)</para>
    /// <para>接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6971090097697521314</para>
    /// </summary>
    [JsonPropertyName("employee_type_id")]
    public string? EmployeeTypeId { get; set; }

    /// <summary>
    /// <para>部门 ID，根据员工主职的直接部门查询，可以通过[【批量查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get) API 获取 部门 ID</para>
    /// <para>- ID 类型应与 open_departemtn_id 一致</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_id_list")]
    public string[]? DepartmentIdList { get; set; }

    /// <summary>
    /// <para>直接上级的雇佣 ID，根据员工主职的直接上级查询</para>
    /// <para>- 可基于当前接口获取员工的直属上级雇佣ID</para>
    /// <para>- 可基于[【创建雇佣】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employment/create)时返回的雇佣ID</para>
    /// <para>- ID 类型应与 user_id_type 一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：7027024823985447820</para>
    /// </summary>
    [JsonPropertyName("direct_manager_id_list")]
    public string[]? DirectManagerIdList { get; set; }

    /// <summary>
    /// <para>虚线上级的雇佣 ID，根据员工主职的虚线上级查询</para>
    /// <para>- 可基于当前接口获取员工的虚线上级雇佣ID</para>
    /// <para>- 可基于[【创建雇佣】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employment/create)时返回的雇佣ID</para>
    /// <para>- ID 类型应与 user_id_type 一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：7027024823985117820</para>
    /// </summary>
    [JsonPropertyName("dotted_line_manager_id_list")]
    public string[]? DottedLineManagerIdList { get; set; }

    /// <summary>
    /// <para>转正式员工日期-搜索范围开始</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("regular_employee_start_date_start")]
    public string? RegularEmployeeStartDateStart { get; set; }

    /// <summary>
    /// <para>转正式员工日期-搜索范围结束</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("regular_employee_start_date_end")]
    public string? RegularEmployeeStartDateEnd { get; set; }

    /// <summary>
    /// <para>入职日期-搜索范围开始，需要与搜索范围结束一同使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_time_start")]
    public string? EffectiveTimeStart { get; set; }

    /// <summary>
    /// <para>入职日期-搜索范围结束</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_time_end")]
    public string? EffectiveTimeEnd { get; set; }

    /// <summary>
    /// <para>工作地点 ID 列表，查询属于该工作地点及下级工作地点的员工</para>
    /// <para>- 可通过 [【批量查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)</para>
    /// <para>接口获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("work_location_id_list_include_sub")]
    public string[]? WorkLocationIdListIncludeSub { get; set; }

    /// <summary>
    /// <para>常用英文全名精确搜索</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("preferred_english_full_name_list")]
    public string[]? PreferredEnglishFullNameList { get; set; }

    /// <summary>
    /// <para>常用本地全名精确搜索</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("preferred_local_full_name_list")]
    public string[]? PreferredLocalFullNameList { get; set; }

    /// <summary>
    /// <para>居民身份证件号码精确搜索</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:person.national_id.search:read : 使用身份证号搜索</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("national_id_number_list")]
    public string[]? NationalIdNumberList { get; set; }

    /// <summary>
    /// <para>个人电话列表，精确匹配查询</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:person.phone.search:read : 使用个人电话搜索</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("phone_number_list")]
    public string[]? PhoneNumberList { get; set; }

    /// <summary>
    /// <para>工作邮箱地址列表，精确匹配查询</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("email_address_list")]
    public string[]? EmailAddressList { get; set; }

    /// <summary>
    /// <para>部门 ID 列表，查询属于该部门及下级部门的员工</para>
    /// <para>- 可通过[【批量查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)</para>
    /// <para>获取</para>
    /// <para>- ID 类型应与 department_id_type 一致</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("department_id_list_include_sub")]
    public string[]? DepartmentIdListIncludeSub { get; set; }

    /// <summary>
    /// <para>其他国籍ID列表，精准匹配查询</para>
    /// <para>- 字段权限要求</para>
    /// <para>- corehr:person.additional_nationalities:read : 读取员工其他国籍</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("additional_national_id_number_list")]
    public string[]? AdditionalNationalIdNumberList { get; set; }

    /// <summary>
    /// <para>公民身份类型列表，精确匹配查询</para>
    /// <para>- 字段权限要求</para>
    /// <para>- corehr:person.citizenship_status:read : 读取员工公民身份</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("citizenship_status_list")]
    public string[]? CitizenshipStatusList { get; set; }

    /// <summary>
    /// <para>成本中心 ID 列表</para>
    /// <para>- 可通过 [【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search) 获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("cost_center_id_list")]
    public string[]? CostCenterIdList { get; set; }

    /// <summary>
    /// <para>任职公司 ID 列表</para>
    /// <para>- [【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)获取</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:job_data.service_company:read : 读取员工任职公司</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("service_company_list")]
    public string[]? ServiceCompanyList { get; set; }

    /// <summary>
    /// <para>任职公司 ID 列表（含下级）</para>
    /// <para>- [【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)获取</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:job_data.service_company:read : 读取员工任职公司</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("service_company_list_include_sub")]
    public string[]? ServiceCompanyListIncludeSub { get; set; }

    /// <summary>
    /// <para>序列 ID 列表</para>
    /// <para>- [【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("job_family_id_list")]
    public string[]? JobFamilyIdList { get; set; }

    /// <summary>
    /// <para>序列 ID 列表（含下级）</para>
    /// <para>- [【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("job_family_id_list_include_sub")]
    public string[]? JobFamilyIdListIncludeSub { get; set; }

    /// <summary>
    /// <para>职级 ID 列表</para>
    /// <para>- 可通过[【批量查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)获取</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:employment.job_level:read : 读取员工职级</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("job_level_id_list")]
    public string[]? JobLevelIdList { get; set; }

    /// <summary>
    /// <para>职等 ID 列表</para>
    /// <para>- 可通过[【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)获取</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:employment.job_grade:read : 读取员工职等</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("job_grade_id_list")]
    public string[]? JobGradeIdList { get; set; }

    /// <summary>
    /// <para>职务 ID 列表</para>
    /// <para>- 可通过[【批量查询职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)获取</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:employment.job:read : 读取员工职务</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("job_id_list")]
    public string[]? JobIdList { get; set; }

    /// <summary>
    /// <para>岗位 ID 列表</para>
    /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:employment.position:read : 读取员工岗位</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("position_id_list")]
    public string[]? PositionIdList { get; set; }

    /// <summary>
    /// <para>岗位 ID 列表（含下级）</para>
    /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:employment.position:read : 读取员工岗位</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("position_id_list_include_sub")]
    public string[]? PositionIdListIncludeSub { get; set; }

    /// <summary>
    /// <para>工时制度 ID 列表</para>
    /// <para>- 可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("working_hours_type_id_list")]
    public string[]? WorkingHoursTypeIdList { get; set; }

    /// <summary>
    /// <para>国籍 ID 列表</para>
    /// <para>- 可通过[【查询国籍信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search)获取</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:person.nationality:read : 读取员工国籍</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("nationality_id_list")]
    public string[]? NationalityIdList { get; set; }

    /// <summary>
    /// <para>员工所属薪资组 ID 列表</para>
    /// <para>- 可通过 [【获取薪资组基本信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/paygroup/list) 获取</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:employment.pay_group:read : 读取员工薪资组</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("pay_group_id_list")]
    public string[]? PayGroupIdList { get; set; }

    /// <summary>
    /// <para>员工所属外派薪资组 ID 列表</para>
    /// <para>- 可通过 [【获取薪资组基本信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/paygroup/list) 获取</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:employment.assignment_pay_group:read : 读取员工外派薪资组</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("assignment_pay_group_id_list")]
    public string[]? AssignmentPayGroupIdList { get; set; }

    /// <summary>
    /// <para>员工当前合同类型列表</para>
    /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询</para>
    /// <para>- object_api_name：contract</para>
    /// <para>- custom_api_name：contract_type</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:employment.contract_type:read : 读取员工当前合同类型</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("contract_type_list")]
    public string[]? ContractTypeList { get; set; }

    /// <summary>
    /// <para>员工当前所属薪资方案 ID 列表</para>
    /// <para>- 可通过[【批量查询薪资方案】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/plan/list)获取</para>
    /// <para>- 字段权限要求：</para>
    /// <para>- corehr:employment.archive_cpst_plan:read : 读取员工当前薪资方案</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("archive_cpst_plan_id_list")]
    public string[]? ArchiveCpstPlanIdList { get; set; }
}
