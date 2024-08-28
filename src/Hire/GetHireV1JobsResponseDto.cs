// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-02
// ************************************************************************
// <copyright file="GetHireV1JobsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取职位列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取职位列表 响应体
/// <para>获取职位列表，仅支持获取默认字段信息，获取详细信息可调用[获取职位信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/get)接口。</para>
/// <para>接口ID：7001051759612919811</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2flist</para>
/// </summary>
public record GetHireV1JobsResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>职位列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Job[]? Items { get; set; }

    /// <summary>
    /// <para>职位列表</para>
    /// </summary>
    public record Job
    {
        /// <summary>
        /// <para>职位 ID，详情请查看：[获取职位信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7379609334215919883</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>职位名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试职位</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>职位描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：这是一个测试职位</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>职位编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：R18</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>职位要求</para>
        /// <para>必填：否</para>
        /// <para>示例值：要求应届生，且无犯罪记录</para>
        /// </summary>
        [JsonPropertyName("requirement")]
        public string? Requirement { get; set; }

        /// <summary>
        /// <para>雇佣类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recruitment_type")]
        public JobRecruitmentType? RecruitmentType { get; set; }

        /// <summary>
        /// <para>雇佣类型</para>
        /// </summary>
        public record JobRecruitmentType
        {
            /// <summary>
            /// <para>雇佣类型 ID，详情请查看：[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中「职位性质/雇佣类型（recruitment_type）枚举定义」</para>
            /// <para>必填：否</para>
            /// <para>示例值：7379609334215919883</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>雇佣类型中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：全职</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>雇佣类型英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：FullTime</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>雇佣类型启用状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：启用</item>
            /// <item>2：未启用</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }
        }

        /// <summary>
        /// <para>部门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department")]
        public JobDepartment? Department { get; set; }

        /// <summary>
        /// <para>部门</para>
        /// </summary>
        public record JobDepartment
        {
            /// <summary>
            /// <para>部门 ID，与入参中的`department_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-xxxx</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>部门中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：字节跳动</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>部门英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Bytedance</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>工作城市</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("city")]
        public JobCity? City { get; set; }

        /// <summary>
        /// <para>工作城市</para>
        /// </summary>
        public record JobCity
        {
            /// <summary>
            /// <para>工作城市码，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：C20</para>
            /// </summary>
            [JsonPropertyName("city_code")]
            public string? CityCode { get; set; }

            /// <summary>
            /// <para>工作城市中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：成都</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>工作城市英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Chengdu</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>最低职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("min_job_level")]
        public JobLevel? MinJobLevel { get; set; }

        /// <summary>
        /// <para>最低职级</para>
        /// </summary>
        public record JobLevel
        {
            /// <summary>
            /// <para>职级 ID，与入参`job_level_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：7379609334215919883</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职级中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：级别-2</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>职级英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：level-2</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>职级启用状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：启用</item>
            /// <item>2：未启用</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }
        }

        /// <summary>
        /// <para>最高职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("max_job_level")]
        public JobLevel? MaxJobLevel { get; set; }

        /// <summary>
        /// <para>职位亮点列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("highlight_list")]
        public JobHighlight[]? HighlightLists { get; set; }

        /// <summary>
        /// <para>职位亮点列表</para>
        /// </summary>
        public record JobHighlight
        {
            /// <summary>
            /// <para>职位亮点 ID，详情请查看：详情请参考：[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中职位亮枚举定义」</para>
            /// <para>必填：否</para>
            /// <para>示例值：7379609334215919883</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位亮点中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：团队氛围好</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>职位亮点英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Positive team atmosphere</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>职位序列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_category")]
        public JobJobCategory? JobCategory { get; set; }

        /// <summary>
        /// <para>职位序列</para>
        /// </summary>
        public record JobJobCategory
        {
            /// <summary>
            /// <para>职位序列 ID，与入参`job_family_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：7379609334215919883</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位序列中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：序列-A</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>职位序列英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：category-A</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>职位序列启用状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：启用</item>
            /// <item>2：未启用</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }
        }

        /// <summary>
        /// <para>职位类别</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_type")]
        public JobJobType? JobType { get; set; }

        /// <summary>
        /// <para>职位类别</para>
        /// </summary>
        public record JobJobType
        {
            /// <summary>
            /// <para>职位类别 ID，详情请查看：[获取职位类别列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_type/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890840777044265230</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位类别中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：金融</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>职位类别英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Finance</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>启用状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：启用</item>
        /// <item>2：未启用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int? ActiveStatus { get; set; }

        /// <summary>
        /// <para>创建人ID，若为空则为系统或其他对接系统创建，与入参`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：7379609334215919883</para>
        /// </summary>
        [JsonPropertyName("create_user_id")]
        public string? CreateUserId { get; set; }

        /// <summary>
        /// <para>创建时间，请使用create_timestamp</para>
        /// <para>必填：否</para>
        /// <para>示例值：1617170925462</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间，请使用update_timestamp</para>
        /// <para>必填：否</para>
        /// <para>示例值：1617170925462</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// <para>招聘流程类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：社招流程</item>
        /// <item>2：校招流程</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("process_type")]
        public int? ProcessType { get; set; }

        /// <summary>
        /// <para>招聘流程 ID，详情请查看：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>招聘流程中文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：校招招聘流程</para>
        /// </summary>
        [JsonPropertyName("process_name")]
        public string? ProcessName { get; set; }

        /// <summary>
        /// <para>招聘流程英文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Campus process</para>
        /// </summary>
        [JsonPropertyName("process_en_name")]
        public string? ProcessEnName { get; set; }

        /// <summary>
        /// <para>职能分类</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_function")]
        public IdNameObject? JobFunction { get; set; }

        /// <summary>
        /// <para>职能分类</para>
        /// </summary>
        public record IdNameObject
        {
            /// <summary>
            /// <para>职能分类 ID，详情请查看：[获取职能分类列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_function/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7379609334215919883</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职能分类名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>职能分类名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>职能分类中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：金融</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>职能分类英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：finance</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>项目</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("subject")]
        public IdNameObject? Subject { get; set; }

        /// <summary>
        /// <para>招聘数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("head_count")]
        public int? HeadCount { get; set; }

        /// <summary>
        /// <para>工作经验要求</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：不限</item>
        /// <item>2：应届毕业生</item>
        /// <item>3：1年以下</item>
        /// <item>4：1-3年</item>
        /// <item>5：3-5年</item>
        /// <item>6：5-7年</item>
        /// <item>7：7-10年</item>
        /// <item>8：10年以上</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("experience")]
        public int? Experience { get; set; }

        /// <summary>
        /// <para>到期日期 请使用expiry_timestamp</para>
        /// <para>必填：否</para>
        /// <para>示例值：1622484739955</para>
        /// </summary>
        [JsonPropertyName("expiry_time")]
        public long? ExpiryTime { get; set; }

        /// <summary>
        /// <para>最低薪资，单位：K</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("min_salary")]
        public int? MinSalary { get; set; }

        /// <summary>
        /// <para>最高薪资，单位：K</para>
        /// <para>必填：否</para>
        /// <para>示例值：20</para>
        /// </summary>
        [JsonPropertyName("max_salary")]
        public int? MaxSalary { get; set; }

        /// <summary>
        /// <para>学历要求</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：小学及以上</item>
        /// <item>2：初中及以上</item>
        /// <item>3：专职及以上</item>
        /// <item>4：高中及以上</item>
        /// <item>5：大专及以上</item>
        /// <item>6：本科及以上</item>
        /// <item>7：硕士及以上</item>
        /// <item>8：博士及以上</item>
        /// <item>20：不限</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("required_degree")]
        public int? RequiredDegree { get; set; }

        /// <summary>
        /// <para>工作城市列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("city_list")]
        public CodeNameObject[]? CityLists { get; set; }

        /// <summary>
        /// <para>工作城市列表</para>
        /// </summary>
        public record CodeNameObject
        {
            /// <summary>
            /// <para>城市编码，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：CT_232</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>城市名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>城市名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>城市中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：成都</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>城市英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Chengdu</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>职位属性</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：实体职位</item>
        /// <item>2：虚拟职位</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("job_attribute")]
        public int? JobAttribute { get; set; }

        /// <summary>
        /// <para>创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1617170925462</para>
        /// </summary>
        [JsonPropertyName("create_timestamp")]
        public string? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1617170925462</para>
        /// </summary>
        [JsonPropertyName("update_timestamp")]
        public string? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>到期时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1622484739955</para>
        /// </summary>
        [JsonPropertyName("expiry_timestamp")]
        public string? ExpiryTimestamp { get; set; }

        /// <summary>
        /// <para>目标专业</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("target_major_list")]
        public TargetMajorInfo[]? TargetMajorLists { get; set; }

        /// <summary>
        /// <para>目标专业</para>
        /// </summary>
        public record TargetMajorInfo
        {
            /// <summary>
            /// <para>目标专业ID，「0」 为不限专业，其他情况可通过[「根据主数据编码批量获取专业」](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/batch_major/get)获取专业详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>目标专业中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：考古</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>目标专业英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：archeology</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }
    }
}
