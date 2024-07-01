// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoBanksSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询银行信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询银行信息 请求体
/// <para>根据银行 ID 、银行名称，查询银行信息</para>
/// <para>接口ID：7301516605753196547</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-bank%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoBanksSearchBodyDto
{
    /// <summary>
    /// <para>银行 ID 列表，可通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)等接口返回的 `person_info.bank_account_list.bank_id_v2` 字段获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("bank_id_list")]
    public string[]? BankIdList { get; set; }

    /// <summary>
    /// <para>银行名称列表，支持对银行名称精确搜索</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("bank_name_list")]
    public string[]? BankNameList { get; set; }

    /// <summary>
    /// <para>状态列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>默认值：[1]</para>
    /// </summary>
    [JsonPropertyName("status_list")]
    public int[]? StatusList { get; set; }

    /// <summary>
    /// <para>最早更新时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public string? UpdateStartTime { get; set; }

    /// <summary>
    /// <para>最晚更新时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public string? UpdateEndTime { get; set; }
}
