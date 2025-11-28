// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-29
//
// Last Modified By : yxr
// Last Modified On : 2024-11-29
// ************************************************************************
// <copyright file="PostCorehrV2OffboardingsEditBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>编辑离职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 编辑离职信息 请求体
/// <para>该接口用于编辑飞书人事的[离职信息](https://people.feishu.cn/people/members/dimission/management)，支持的字段包括离职日期、离职原因、离职申请发起时间和离职申请审批通过时间等等，同时也支持编辑离职的自定义字段（附件字段除外）。当接口成功提交后，会产生对应的[离职信息变更](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/offboarding/events/updated)事件。</para>
/// <para>接口ID：7386577676713328643</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/offboarding/edit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2fedit</para>
/// </summary>
public record PostCorehrV2OffboardingsEditBodyDto
{
    /// <summary>
    /// <para>离职记录ID，不允许为空。可以通过[搜索离职信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/offboarding/search)获取，取值于接口返回的data &gt; items &gt; offboarding_id</para>
    /// <para>必填：是</para>
    /// <para>示例值：7095671727698478604</para>
    /// </summary>
    [JsonPropertyName("offboarding_id")]
    public string OffboardingId { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作人雇佣 ID（employment_id），ID类型与查询参数 user_id_type取值一致：</para>
    /// <para>1、当user_id_type取值为open_id时，ID获取方式参考[如何获取自己的Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>2、当user_id_type取值为user_id时，ID获取方式参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>3、当user_id_type取值为union_id时，ID获取方式参考[如何获取自己的 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)。</para>
    /// <para>4、当user_id_type取值为people_corehr_id时，先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。</para>
    /// <para>注意：为空时，默认系统操作人</para>
    /// <para>必填：否</para>
    /// <para>示例值：6982509313466189341</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>编辑字段数据信息，不允许为空。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("update_data")]
    public ObjectFieldData[] UpdateDatas { get; set; } = [];

    /// <summary>
    /// <para>编辑字段数据信息，不允许为空。</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段唯一标识</para>
        /// <para>（api_name）</para>
        /// <para>注意：</para>
        /// <para>1.该字段取值于[人员档案配置](https://people.feishu.cn/people/hr-settings/profile) &gt; 信息配置 &gt; 离职信息 中各字段的字段编码</para>
        /// <para>2.自定义字段也可以通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)获取</para>
        /// <para>3.不可编辑的字段api_name</para>
        /// <para>范围：</para>
        /// <para>-wk_id</para>
        /// <para>-wk_tenant_id</para>
        /// <para>-employment</para>
        /// <para>-process_id</para>
        /// <para>-flow_id</para>
        /// <para>-node_id</para>
        /// <para>-initiator_id</para>
        /// <para>-status</para>
        /// <para>-checklist_status</para>
        /// <para>-checklist_process_id</para>
        /// <para>-type,hrbp_ids</para>
        /// <para>-hrbp_list</para>
        /// <para>-probation_id</para>
        /// <para>-wk_created_at</para>
        /// <para>-wk_created_by</para>
        /// <para>-wk_updated_at</para>
        /// <para>-wk_updated_by</para>
        /// <para>-wk_deleted_at</para>
        /// <para>-wk_is_deleted</para>
        /// <para>-noncompete_agreement_id</para>
        /// <para>-social_insurance_end_date</para>
        /// <para>-provident_fund_end_date</para>
        /// <para>-sign_type</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同，例如：</para>
        /// <para>-文本类型（1）:"文本"</para>
        /// <para>-布尔类型（2）:"true"</para>
        /// <para>-数字类型（3）:"123"</para>
        /// <para>-单值枚举类型（4）:"option_1"</para>
        /// <para>-多值枚举类型（4）："[\"option_1\",\"option_2\"]"</para>
        /// <para>-日期类型（7）:"2024-06-30"</para>
        /// <para>注意：</para>
        /// <para>1.枚举字段的枚举值取值于[人员档案配置](https://people.feishu.cn/people/hr-settings/profile) &gt; 信息配置 &gt; 离职信息 对应字段选项集的选项编码。</para>
        /// <para>2.枚举字段值也可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，参考接口返回的 字段详情 &gt; 字段类型配置信息 &gt; 选项配置信息 &gt; 选项信息 &gt; 枚举常量集 API name</para>
        /// <para>3.人员字段目前只支持传入员工的雇佣ID。先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。</para>
        /// <para>4.暂不支持填写附件类型字段。</para>
        /// <para>必填：是</para>
        /// <para>示例值：Sandy</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
